using System;
using System.Data.SqlClient;

namespace LDV_DESIGNE_BZ.Class
{
    class UserDAO
    {
        User u = new User();

        #region AddUser()
        public void AddUser(string cpfUser, string nameUser, string passUser, string emailUser, string telUser, string tipoUser, string firstName, string lastName)
        {
            u.CPFuser = cpfUser;
            u.NameUser = nameUser;
            u.PassUser = passUser;
            u.EmailUser = emailUser;
            u.TelUser = telUser;
            u.TipoUser = tipoUser;
            u.FirstName = firstName;
            u.LastName = lastName;

            SqlCommand addUser = new SqlCommand();
            addUser.Connection = DataAccess.connection();

            addUser.CommandText = "INSERT INTO LDVACCOUNTUSER " +
                                  "(CPFUSER, NAMEUSER, PASSUSER, EMAILUSER, TELUSER, TIPOUSER, FIRSTNAME, LASTNAME) " +
                                  "VALUES " +
                                  "(@CPFUSER, @NAMEUSER, @PASSUSER, @EMAILUSER, @TELUSER, @TIPOUSER, @FIRSTNAME, @LASTNAME)";
            try
            {
                addUser.Parameters.Add(new SqlParameter("@CPFUSER", u.CPFuser));
                addUser.Parameters.Add(new SqlParameter("@NAMEUSER", u.NameUser));
                addUser.Parameters.Add(new SqlParameter("@PASSUSER", u.PassUser));
                addUser.Parameters.Add(new SqlParameter("@EMAILUSER", u.EmailUser));
                addUser.Parameters.Add(new SqlParameter("@TELUSER", u.TelUser));
                addUser.Parameters.Add(new SqlParameter("@TIPOUSER", u.TipoUser));
                addUser.Parameters.Add(new SqlParameter("@FIRSTNAME", u.FirstName));
                addUser.Parameters.Add(new SqlParameter("@LASTNAME", u.LastName));

                addUser.ExecuteNonQuery();
                addUser.Connection.Close();

            }
            catch (Exception)
            {

                throw;
            }
        }
        #endregion
    }
}
