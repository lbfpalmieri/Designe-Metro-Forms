namespace LDV_DESIGNE_BZ.Class
{
    class User
    {
        public string CPFuser { get; set; }
        public string CPFAlter { get; set; }
        public string NameUser { get; set; }
        public string PassUser { get; set; }
        public string EmailUser { get; set; }
        public string TelUser { get; set; }
        public string TipoUser { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public User()
        {
        }

        public User(string cPFuser, string cPFAlter)
        {
            CPFuser = cPFuser;
            CPFAlter = cPFAlter;
        }

        public User(string cPFuser, string cPFAlter, string nameUser, string passUser, string emailUser, string telUser, string tipoUser, string firstName, string lastName) : this(cPFuser, cPFAlter)
        {
            NameUser = nameUser;
            PassUser = passUser;
            EmailUser = emailUser;
            TelUser = telUser;
            TipoUser = tipoUser;
            FirstName = firstName;
            LastName = lastName;
        }
    }
}
