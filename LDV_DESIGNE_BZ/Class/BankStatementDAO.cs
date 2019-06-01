using System;
using System.Data.SqlClient;
using System.Data;

namespace LDV_DESIGNE_BZ.Class
{
    class BankStatementDAO
    {
        DataAccess query = new DataAccess();
        BankStatement bankStatement = new BankStatement();

        #region INSERT
        public bool DepositBankStatement(BankStatement bank)
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

        #region Valor total de depósitos
        public decimal TotalDeposito(string AccBank)
        {
            // Limpando parãmetros existentes
            query.LimparParametros();
            string SQL = @"SELECT 
                            SUM(VALUESTATEMENT) AS VALUESTATEMENT
                            FROM LDVBANKACCOUNT LDVACC 
                            INNER JOIN LDVBANKSTATEMENT LDVS 
                            ON LDVACC.NUMBERACCOUNT = LDVS.NUMBERACCBANK 
                            WHERE VALUESTATEMENT > 0 
                            AND NUMBERACCOUNT = @AccBank";
            // Adicionando novos parâmetros
            query.AdicionarParametro("@AccBank", SqlDbType.VarChar, AccBank);
            // Obtendo um DataTable com as informações
            DataTable dtResult = query.ExecutaConsulta(SQL);
            // Preenchendo os dados do objeto      
            try
            {
                bankStatement.ValueStatement = Convert.ToDecimal(dtResult.Rows[0]["VALUESTATEMENT"].ToString());
                // Retornando o objeto com as informações carregadas da base de dados
                return bankStatement.ValueStatement;
            }
            catch (Exception)
            {
                return bankStatement.ValueStatement = 0;
            }
        }
        #endregion

        #region Valor total de débitos
        public decimal TotalDebito(string AccBank)
        {           
            // Limpando parãmetros existentes
            query.LimparParametros();
            string SQL = @"SELECT
                            SUM(VALUESTATEMENT) AS VALUESTATEMENT
                            FROM LDVBANKACCOUNT LDVACC 
                            INNER JOIN LDVBANKSTATEMENT LDVS 
                            ON LDVACC.NUMBERACCOUNT = LDVS.NUMBERACCBANK 
                            WHERE VALUESTATEMENT < 0 
                            AND NUMBERACCOUNT = @AccBank";
            // Adicionando novos parâmetros
            query.AdicionarParametro("@AccBank", SqlDbType.VarChar, AccBank);
            // Obtendo um DataTable com as informações
            DataTable dtResult = query.ExecutaConsulta(SQL);
            // Preenchendo os dados do objeto      
            try
            {
                bankStatement.ValueStatement = Convert.ToDecimal(dtResult.Rows[0]["VALUESTATEMENT"].ToString());
                // Retornando o objeto com as informações carregadas da base de dados
                return bankStatement.ValueStatement;
            }
            catch (Exception)
            {
                return bankStatement.ValueStatement = 0;
            }
        }
        #endregion

        #region Retorna o saldo total da conta
        public decimal SaldoTotalConta(string AccBank)
        {
            // Limpando os parãmetros
            query.LimparParametros();
            string SQL = @"SELECT SUM(VALUESTATEMENT) AS VALUESTATEMENT
                            FROM LDVBANKACCOUNT AS LDVACC
                            INNER JOIN LDVBANKSTATEMENT AS LDVS 
                            ON LDVACC.NUMBERACCOUNT = LDVS.NUMBERACCBANK 
                            WHERE LDVACC.NUMBERACCOUNT = @AccBank";
            // Adicionando novos parâmetros
            query.AdicionarParametro("@AccBank", SqlDbType.VarChar, AccBank);
            // Obtendo um DataTable com as informações
            DataTable dtResult = query.ExecutaConsulta(SQL);
            // Preenchendo os dados do objeto      
            try
            {
                bankStatement.ValueStatement = Convert.ToDecimal(dtResult.Rows[0]["VALUESTATEMENT"].ToString());
                // Retornando o objeto com as informações carregadas da base de dados
                return bankStatement.ValueStatement;
            }
            catch (Exception)
            {
                return bankStatement.ValueStatement = 0;
            }
        }
        #endregion
    }
}
