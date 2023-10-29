namespace part_03
{
    class Program
    {
        static void Main()
        {
            Currency cur = new Currency();
            cur.Value = 1200;
            Console.WriteLine(cur.Value.ToString());

            CurrencyRUB rub = new CurrencyRUB(cur);
            Console.WriteLine(rub.Value.ToString());
            CurrencyUSD usd = rub;
            Console.WriteLine(usd.Value.ToString());
            CurrencyEUR eur = usd;
            Console.WriteLine(eur.Value.ToString());
            CurrencyRUB rub1 = eur;
            Console.WriteLine(rub1.Value.ToString());
        }
        public class CurrencyRUB : Currency
        {
            public CurrencyRUB()
            {
                this.Value = 0;
            }
            public CurrencyRUB (Currency obj)
            {
                this.Value = obj.Value;
            }
            public static implicit operator CurrencyRUB(CurrencyUSD param)
            {
                return new CurrencyRUB { Value = param.Value * 50 };
            }
            public static implicit operator CurrencyRUB(CurrencyEUR param)
            {
                return new CurrencyRUB { Value = param.Value * 60 };
            }
            public static explicit operator CurrencyUSD(CurrencyRUB param)
            {
                return new CurrencyUSD { Value = param.Value / 50 };
            }
            public static explicit operator CurrencyEUR(CurrencyRUB param)
            {
                return new CurrencyEUR { Value = param.Value / 60 };
            }
        }
        public class CurrencyEUR : Currency
        {
            public CurrencyEUR()
            {
                this.Value = base.Value;
            }
            public static implicit operator CurrencyEUR(CurrencyUSD param)
            {
                return new CurrencyEUR { Value = param.Value / 1.2 };
            }
            public static implicit operator CurrencyEUR(CurrencyRUB param)
            {
                return new CurrencyEUR { Value = param.Value / 60 };
            }
            public static explicit operator CurrencyUSD(CurrencyEUR param)
            {
                return new CurrencyUSD { Value = param.Value * 1.2 };
            }
            public static explicit operator CurrencyRUB(CurrencyEUR param)
            {
                return new CurrencyRUB { Value = param.Value * 60 };
            }
        }
        public class CurrencyUSD : Currency
        {
            public CurrencyUSD()
            {
                this.Value = base.Value;
            }
            public static implicit operator CurrencyUSD(CurrencyRUB param)
            {
                return new CurrencyUSD { Value = param.Value / 50 };
            }
            public static implicit operator CurrencyUSD(CurrencyEUR param)
            {
                return new CurrencyUSD { Value = param.Value * 1.2 };
            }
            public static explicit operator CurrencyRUB(CurrencyUSD param)
            {
                return new CurrencyRUB { Value = param.Value * 50 };
            }
            public static explicit operator CurrencyEUR(CurrencyUSD param)
            {
                return new CurrencyEUR { Value = param.Value / 1.2 };
            }
        }
        public class Currency
        {
            public double Value { get; set; }
        }
    }
}