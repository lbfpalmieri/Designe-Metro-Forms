using System;
using System.Data.SqlClient;
using System.Data;

namespace LDV_DESIGNE_BZ.Class
{
    class BankDAO
    {
        DataAccess query = new DataAccess();

        #region INSERT
        public bool DepositBankStatement(Bank bank)
        {
            //Limpa os parâmetros existentes
            query.LimparParametros();
            string SQL = @"INSERT INTO LDVBANKSTATEMENT
                           (VALUESTATEMENT, DATESTATEMENT, DESCSTATEMENT, NUMBERACCBANK)
                           VALUES
                           (@VALUESTATEMENT, @DATESTATEMENT, @DESCSTATEMENT, @NUMBERACCBANK)";

            //Adiciona os parâmetros da instrução SQL
            query.AdicionarParametro("@VALUESTATEMENT", SqlDbType.Decimal, bank.ValueStatement);
            query.AdicionarParametro("@DATESTATEMENT", SqlDbType.DateTime, bank.DateStatement);
            query.AdicionarParametro("@DESCSTATEMENT", SqlDbType.VarChar,bank.DescStatement);
            query.AdicionarParametro("@NUMBERACCBANK", SqlDbType.VarChar,bank.NumberAccountBank);

            //Retorna a quantidade de linhas afetadas
            return (query.ExecutaAtualizacao(SQL) > 0);
        }
        #endregion

        #region Saldo total da conta (REVISAR)
        public decimal SaldoConta(string accBank)
        {
            decimal Retorno;

            SqlCommand total = new SqlCommand();
            total.Connection = DataAccess.connection();

            try
            {
                total.CommandText = "SELECT SUM(VALUESTATEMENT) "
                                  + "FROM LDVBANKACCOUNT AS LDVACC "
                                  + "INNER JOIN LDVBANKSTATEMENT AS LDVS "
                                  + "ON LDVACC.NUMBERACCOUNT = LDVS.NUMBERACCBANK "
                                  + "WHERE LDVACC.NUMBERACCOUNT = '" + accBank + "'";

                Retorno = Convert.ToDecimal(total.ExecuteScalar().ToString());
                total.Connection.Close();
            }
            catch (Exception)
            {
                Retorno = 0;
                throw;
            }

            return Retorno;
        }
        #endregion

        #region Saldo positivo da conta (REVISAR)
        public decimal SaldoPositivo(string accBank)
        {
            decimal Retorno;

            SqlCommand total = new SqlCommand();
            total.Connection = DataAccess.connection();

            try
            {
                total.CommandText = "SELECT " +
                                    "SUM(VALUESTATEMENT) " +
                                    "FROM LDVBANKACCOUNT LDVACC " +
                                    "INNER JOIN LDVBANKSTATEMENT LDVS " +
                                    "ON LDVACC.NUMBERACCOUNT = LDVS.NUMBERACCBANK " +
                                    "WHERE VALUESTATEMENT > 0 " +
                                    "AND NUMBERACCOUNT = '" + accBank + "'";

                Retorno = Convert.ToDecimal(total.ExecuteScalar().ToString());
                total.Connection.Close();
            }
            catch (Exception)
            {
                Retorno = 0;
                throw;
            }

            return Retorno;
        }
        #endregion

        #region Saldo negativo da conta (REVISAR)
        public decimal SaldoNegativo(string accBank)
        {
            decimal Retorno;

            SqlCommand total = new SqlCommand();
            total.Connection = DataAccess.connection();

            try
            {
                total.CommandText = "SELECT " +
                                    "SUM(VALUESTATEMENT) " +
                                    "FROM LDVBANKACCOUNT LDVACC " +
                                    "INNER JOIN LDVBANKSTATEMENT LDVS " +
                                    "ON LDVACC.NUMBERACCOUNT = LDVS.NUMBERACCBANK " +
                                    "WHERE VALUESTATEMENT < 0 " +
                                    "AND NUMBERACCOUNT = '" + accBank + "'";

                Retorno = Convert.ToDecimal(total.ExecuteScalar().ToString());
                total.Connection.Close();
            }
            catch (Exception)
            {
                Retorno = 0;
                throw;
            }

            return Retorno;
        }
        #endregion
    }
}
