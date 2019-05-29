﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LDV_DESIGNE_BZ.Class
{
    class BankAccountDAO
    {
        DataAccess query = new DataAccess();

        #region InsertAccount
        public bool InsertAccount(BankAccount BankAcc)
        {
            //Limpa os parâmetros existentes
            query.LimparParametros();
            string SQL = @"INSERT INTO LDVBANKACCOUNT
                           (NUMBERACCOUNT, CPFHOLDER)
                           VALUES
                           (@NUMBERACCOUNT, @CPFHOLDER)";

            //Adiciona os parâmetros da instrução SQL
            query.AdicionarParametro("@NUMBERACCOUNT", SqlDbType.VarChar, BankAcc.NumberAccount);
            query.AdicionarParametro("@CPFHOLDER", SqlDbType.VarChar, BankAcc.CPFHolder);

            //Retorna a quantidade de linhas afetadas
            return (query.ExecutaAtualizacao(SQL) > 0);
        }
        #endregion

        #region DeleteAccount
        public bool DeleteAccount(BankAccount BankAcc)
        {
            query.LimparParametros();
            string SQL = @"DELETE FROM LDVBANKACCOUNT WHERE NUMBERACCOUNT = @NUMBERACCOUNT";
            query.AdicionarParametro("@NUMBERACCOUNT", SqlDbType.VarChar, BankAcc.NumberAccount);
            if (query.ExecutaAtualizacao(SQL) > 0)
                return true;
            return false;
        }
        #endregion
    }
}