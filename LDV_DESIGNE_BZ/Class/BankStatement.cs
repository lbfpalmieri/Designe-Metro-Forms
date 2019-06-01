using System;

namespace LDV_DESIGNE_BZ.Class
{
    class BankStatement
    {
        public decimal ValueStatement { get; set; }
        public DateTime DateStatement { get; set; }
        public string DescStatement { get; set; }
        public string NumberAccountBank { get; set; }

        public BankStatement()
        {
        }

        public BankStatement(decimal value, DateTime date, string desc, string number)
        {
            ValueStatement = value;
            DateStatement = date;
            DescStatement = desc;
            NumberAccountBank = number;
        }
    }
}
