enum CURRENCYTYPE { NOTDEFINED, DOLLAR, EURO, HRIVNA, FUNTSTERLING };

namespace task1
{
    internal class Program
    {

        static void Main(string[] args)
        {
            /*
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            Console.InputEncoding = System.Text.Encoding.Unicode;
            //Money dolCash1 = new Dollars(100, 0.50);
            Money dolCash1 = new Dollars(100.50);
            Console.WriteLine(dolCash1);
            Dollars dolCash2 = new Dollars(50, 0);
            Console.WriteLine(dolCash2);

            Dollars sumCash = dolCash2.Sum(dolCash1);
            Console.WriteLine(sumCash);

            Euro euroCach = new Euro(100);
            Console.WriteLine(euroCach);
            sumCash = dolCash2.Sum(euroCach);
            Console.WriteLine(sumCash);

            Hrivna localMoney = new Hrivna(100);
            Console.WriteLine(localMoney);
            Dollars dollars = new Dollars(100);
            Hrivna sumHrivna = localMoney.Sum(dollars);
            Console.WriteLine(sumHrivna);
            dolCash2.Plus(3);
            Console.WriteLine(dolCash2);
            dolCash2.Minus(6);
            Console.WriteLine(dolCash2);

            Console.WriteLine(localMoney);
            localMoney.Plus(5.5);
            Console.WriteLine(localMoney);
            Console.ReadKey();*/
            Product p = new Product("Молоко", new Hrivna(87.90));
            Console.WriteLine(p);
            p.increaseCost(12);
            Console.WriteLine(p);
            p.decreaseCost(20);
            Console.WriteLine(p);
        }
    }

    internal class Money
    {
        static double[] currencyRaiting = new double[] { 1, 0.7924, 0.8708, 0.022, 1 }; //коэффициент валют на 27.04.2023
        public static double[] CurrencyRaiting
        {
            get
            {
                return currencyRaiting;
            }

        }

        protected int currency = 0;
        protected double pennies = 0;
        protected CURRENCYTYPE type = CURRENCYTYPE.NOTDEFINED;
        public virtual CURRENCYTYPE Type { get; protected set; }



        public virtual (int, double) Cur_Pennie
        {
            get
            {
                return (currency, pennies);
            }
        }

        public virtual int Currency
        {
            get
            {
                return currency;
            }
            set
            {
                currency = value;
            }
        }

        public virtual double Pennies
        {
            get
            {
                return pennies;
            }
            set
            {
                if ((int)value >= 100)
                {
                    currency += (int)value;
                    pennies = value - (int)value;
                }
                else
                    pennies = value;
            }
        }

        protected void Normalize(ref int c, ref double p)
        {
            if ((int)p > 0)
            {
                c += (int)p;
                p -= (int)p;
            }
        }


        public Money()
        { }
        public Money(int c, double p, CURRENCYTYPE type = CURRENCYTYPE.NOTDEFINED)
        {
            Normalize(ref c, ref p);
            Currency = c;
            Pennies = p;
            Type = type;
        }
        public override string ToString()
        {
            (string curSign, string penSign) = GetName(Type);
            return String.Format($"{currency}{curSign}, {pennies} {penSign}.");
        }

        private (string, string) GetName(CURRENCYTYPE t) => t switch
        {
            CURRENCYTYPE.DOLLAR => ("$", "cents"),
            CURRENCYTYPE.EURO => ("\u20AC", "erocents"),
            CURRENCYTYPE.HRIVNA => (" \u20B4", "копiйок"),
            CURRENCYTYPE.FUNTSTERLING => ("\u00A3", "pennies"),
            _ => ("currency", "pennies")

        };

        protected double ToDouble()
        {
            return pennies + currency;
        }
        protected double ToDouble(int cur, double pen)
        {

            return pen + cur;
        }

        protected (int, double) ToMoney(double num)
        {
            int temp = (int)(num * 100);
            return ((int)num, num - (int)num);
        }

        public (int, double) ConvertBaseTo(CURRENCYTYPE t)
        {
            double tempNumber = ToDouble();
            tempNumber /= CurrencyRaiting[(int)t];
            return ToMoney(tempNumber);
        }
        protected void ConvertToBase(CURRENCYTYPE t)
        {
            double tempNumber = ToDouble(currency, pennies);
            (int cur, double pen) = ToMoney(tempNumber * CurrencyRaiting[(int)t]);
            currency = cur;
            pennies = pen;
        }
        public void Plus(double num)
        {
            double temp = Pennies + Currency + num;
            (int cur, double pen) = ToMoney(temp * CurrencyRaiting[(int)Type]);
            Currency = cur;
            Pennies = pen;
        }
        public void Minus(double num)
        {
            double temp = Pennies + Currency - num;
            (int cur, double pen) = ToMoney(temp * CurrencyRaiting[(int)Type]);
            Currency = cur;
            Pennies = pen;
        }

    }
    internal class Dollars : Money
    {
        public Dollars() : base(0, 0, CURRENCYTYPE.DOLLAR)
        {
        }

        public Dollars(int c, double p)
        {
            Normalize(ref c, ref p);
            Type = CURRENCYTYPE.DOLLAR;
            int ind = (int)CURRENCYTYPE.DOLLAR;

            double[] arr = CurrencyRaiting;
            double tempNumber = ToDouble(c, p);
            (int cur, double pen) = base.ToMoney(tempNumber * arr[ind]);
            Currency = cur;
            Pennies = pen;
        }
        public Dollars(double p)
        {
            Type = CURRENCYTYPE.DOLLAR;
            (int cur, double pen) = base.ToMoney(p * CurrencyRaiting[(int)Type]);
            Currency = cur;
            Pennies = pen;
        }
        public override int Currency
        {
            get
            {
                (int c, double p) = ConvertBaseToDollars();
                return c;
            }
            set => base.Currency = value;
        }

        public override double Pennies
        {
            get
            {
                (int c, double p) = ConvertBaseToDollars();
                return p;
            }
            set => base.Pennies = value;
        }

        public override (int, double) Cur_Pennie
        {
            get
            {
                return ConvertBaseToDollars();
            }

        }

        public override CURRENCYTYPE Type { get => base.Type; protected set => base.Type = value; }
        public (int, double) ConvertBaseToDollars()
        {
            return base.ConvertBaseTo(Type);
        }
        public override string ToString()
        {
            return String.Format($"{Currency}$, {(int)(Pennies * 100)} cents");
        }


        public Dollars Sum(Money money)
        {
            if (money is Dollars)
            {
                return new Dollars(Currency + money.Currency, Pennies + money.Pennies);
            }
            else
            {
                (int c, double p) = money.ConvertBaseTo(Type);
                return new Dollars(Currency + c, Pennies + p);
            }
        }
        /*
        public void Plus(double num)
        {
            double temp = Pennies + Currency + num;
            (int cur, double pen) = base.ToMoney(temp * CurrencyRaiting[(int)Type]);
            Currency = cur;
            Pennies = pen;
        }
        public void Minus(double num)
        {
            double temp = Pennies + Currency - num;
            (int cur, double pen) = base.ToMoney(temp * CurrencyRaiting[(int)Type]);
            Currency = cur;
            Pennies = pen;
        }*/
    }

    internal class Euro : Money
    {
        public Euro() : base(0, 0, CURRENCYTYPE.EURO)
        {
        }

        public Euro(int c, double p)
        {
            Normalize(ref c, ref p);
            Type = CURRENCYTYPE.DOLLAR;
            int ind = (int)CURRENCYTYPE.EURO;
            double[] arr = CurrencyRaiting;
            double tempNumber = ToDouble(c, p);
            (int cur, double pen) = base.ToMoney(tempNumber * arr[ind]);
            Currency = cur;
            Pennies = pen;
        }
        public Euro(double p)
        {
            Type = CURRENCYTYPE.EURO;
            (int cur, double pen) = base.ToMoney(p * CurrencyRaiting[(int)Type]);
            Currency = cur;
            Pennies = pen;
        }
        public override int Currency
        {
            get
            {
                (int c, double p) = ConvertBaseToEuros();
                return c;
            }
            set => base.Currency = value;
        }

        public override double Pennies
        {
            get
            {
                (int c, double p) = ConvertBaseToEuros();
                return p;
            }
            set => base.Pennies = value;
        }

        public override (int, double) Cur_Pennie
        {
            get
            {
                return ConvertBaseToEuros();
            }

        }

        public override CURRENCYTYPE Type { get => base.Type; protected set => base.Type = value; }
        public (int, double) ConvertBaseToEuros()
        {
            return base.ConvertBaseTo(Type);
        }
        public override string ToString()
        {
            return String.Format($"{Currency}\u20AC, {(int)(Pennies * 100)} eurocents");

        }


        public Euro Sum(Money? money)
        {
            if (money is Euro)
            {

                return new Euro(Currency + money.Currency, Pennies + money.Pennies);
            }
            else
            {
                (int c, double p) = money.ConvertBaseTo(Type);
                return new Euro(Currency + c, Pennies + p);
            }
        }
    }

    internal class Hrivna : Money
    {
        public Hrivna() : base(0, 0, CURRENCYTYPE.EURO)
        {
        }

        public Hrivna(int c, double p)
        {
            Normalize(ref c, ref p);
            Type = CURRENCYTYPE.HRIVNA;
            int ind = (int)CURRENCYTYPE.HRIVNA;
            double[] arr = CurrencyRaiting;
            double tempNumber = ToDouble(c, p);
            (int cur, double pen) = base.ToMoney(tempNumber * arr[ind]);
            Currency = cur;
            Pennies = pen;
        }
        public Hrivna(double p)
        {
            Type = CURRENCYTYPE.HRIVNA;
            (int cur, double pen) = base.ToMoney(p * CurrencyRaiting[(int)Type]);
            Currency = cur;
            Pennies = pen;
        }

        public override int Currency
        {
            get
            {
                (int c, double p) = ConvertBaseToHrivnas();
                return c;
            }
            set => base.Currency = value;
        }

        public override double Pennies
        {
            get
            {
                (int c, double p) = ConvertBaseToHrivnas();
                return p;
            }
            set => base.Pennies = value;
        }

        public override (int, double) Cur_Pennie
        {
            get
            {
                return ConvertBaseToHrivnas();
            }

        }

        public override CURRENCYTYPE Type { get => base.Type; protected set => base.Type = value; }
        public (int, double) ConvertBaseToHrivnas()
        {
            return base.ConvertBaseTo(Type);
        }
        public override string ToString()
        {
            return String.Format($"{Currency}грн., {(int)(Pennies * 100)} копiйок");

        }


        public Hrivna Sum(Money money)
        {
            if (money is Hrivna)
            {
                return new Hrivna(Currency + money.Currency, Pennies + money.Pennies);
            }
            else
            {
                //var t = money.GetType();
                (int c, double p) = money.ConvertBaseTo(Type);
                return new Hrivna(Currency + c, Pennies + p);
            }
        }
    }
}