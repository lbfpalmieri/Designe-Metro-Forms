using System;
using System.Data;
using System.Data.SqlClient;

namespace LDV_DESIGNE_BZ.Class
{
    class UserDAO
    {
        User u = new User();
        DataAccess query = new DataAccess();

        #region AddUser()
        public bool AddUser(User user)
        {
            query.LimparParametros();
            string SQL = @"INSERT INTO LDVACCOUNTUSER
                          (CPFUSER, NAMEUSER, PASSUSER, EMAILUSER, TELUSER, TIPOUSER, FIRSTNAME, LASTNAME)
                          VALUES
                          (@CPFUSER, @NAMEUSER, @PASSUSER, @EMAILUSER, @TELUSER, @TIPOUSER, @FIRSTNAME, @LASTNAME)";

            query.AdicionarParametro("@CPFUSER", SqlDbType.VarChar, user.CPFuser);
            query.AdicionarParametro("@NAMEUSER", SqlDbType.VarChar, user.NameUser);
            query.AdicionarParametro("@PASSUSER", SqlDbType.VarChar, user.PassUser);
            query.AdicionarParametro("@EMAILUSER", SqlDbType.VarChar, user.EmailUser);
            query.AdicionarParametro("@TELUSER", SqlDbType.VarChar, user.TelUser);
            query.AdicionarParametro("@TIPOUSER", SqlDbType.VarChar, user.TipoUser);
            query.AdicionarParametro("@FIRSTNAME", SqlDbType.VarChar, user.FirstName);
            query.AdicionarParametro("@LASTNAME", SqlDbType.VarChar, user.LastName);

            //Retorna a quantidade de linhas afetadas
            return (query.ExecutaAtualizacao(SQL) > 0);
        }
        #endregion

        #region AlterAccount
        public bool AlterarUser(User user)
        {
            // Limpando os parâmetros
            query.LimparParametros();
            string SQL = @"UPDATE LDVACCOUNTUSER SET
                            CPFUSER = @CPFUSER
                            WHERE CPFUSER = @CPFUSER1";
            // Adicionando novos parâmetros
            query.AdicionarParametro("@CPFUSER1", SqlDbType.VarChar, user.CPFuser);
            query.AdicionarParametro("@CPFUSER", SqlDbType.VarChar, user.CPFAlter);
            // Executando a atualização na base verificando se o update executou com sucesso
            if (query.ExecutaAtualizacao(SQL) > 0)
                return true;
            return false;
        }
        #endregion
    }
}
