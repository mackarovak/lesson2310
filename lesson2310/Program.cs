using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.InteropServices;
using System.Globalization;

namespace lesson2310
{
    enum AccountType { Current, Savings }
    class Account
    {
        private static int TotalAccountCountInBank = 0;
        public Account(double balans, AccountType type)
        {
            Balans = balans;
            Type = type;
        }
        private readonly int currentAccountNumber;
        public Account()
        {
            TotalAccountCountInBank += 1;
            currentAccountNumber = TotalAccountCountInBank;
        }
        private double Balans { get { return Balans; } set { Balans = value; } }
        private AccountType Type { get { return Type; } set { Type = value; } }
        public override string ToString()
        {
            return base.ToString();
        }
        public void WithdrawFromTheAccount(double summa)
        {
            if (summa <= Balans)
            {
                double Nomoney = Balans - summa;
                Console.WriteLine(Nomoney);
            }
            else { Console.WriteLine("So there is no money, we are crying"); }
        }
        public static void Moneytransfer(out int val1, ref int vall2)
        {
            val1 = 0;
            int tmp = val1;
            val1 = vall2;
            vall2 = tmp;
        }
    }
    public class Temperature : IFormattable
    {
        private decimal temp;

        public Temperature(decimal temperature)
        {
            if (temperature < -273.15m)
                throw new ArgumentOutOfRangeException(String.Format("{0} is less than absolute zero.",
                                                      temperature));
            this.temp = temperature;
        }

        public decimal Celsius
        {
            get { return temp; }
        }

        public decimal Fahrenheit
        {
            get { return temp * 9 / 5 + 32; }
        }

        public decimal Kelvin
        {
            get { return temp + 273.15m; }
        }

        public override string ToString()
        {
            return this.ToString("G", CultureInfo.CurrentCulture);
        }

        public string ToString(string format)
        {
            return this.ToString(format, CultureInfo.CurrentCulture);
        }

        public string ToString(string format, IFormatProvider provider)
        {
            if (String.IsNullOrEmpty(format)) format = "G";
            if (provider == null) provider = CultureInfo.CurrentCulture;


            switch (format.ToUpperInvariant())
            {
                case "G":
                case "C":
                    return temp.ToString("F2", provider) + " °C";
                case "F":
                    return Fahrenheit.ToString("F2", provider) + " °F";
                case "K":
                    return Kelvin.ToString("F2", provider) + " K";
                default:
                    throw new FormatException(String.Format("The {0} format string is not supported.", format));
            }
        }
    }

    class Program
    {
        static void IfsIFormatTable(object obj)
        {
        if (obj is IFormattable)
        {
            Console.WriteLine(obj.ToString());
        }
        else
        {

            Console.WriteLine("Не удалось явно преобразовать к IFormatTable");
        }
        }
        public static string Reservedstring(string newstring)
        {
            return new string (newstring.Reverse().ToArray());
        }
        public static void Main(string[] args)
        {
            Console.WriteLine("Задание1");
            AccountType accounttype = AccountType.Current;
            double summa = Convert.ToDouble(Console.ReadLine());
            Account bank = new Account(140_000, AccountType.Savings);
            Console.WriteLine("{0} {1}", accounttype, bank);
            Account account = new Account(5000000000000000, AccountType.Savings);
            Console.WriteLine("Задание2");
            string input = Console.ReadLine();
            Console.WriteLine(Reservedstring(input));
            Console.WriteLine("Задание3");
            const string sourcefile = "result.out";
            string filename = string.Empty;
            Console.WriteLine("Какое имя у файла?");
            filename = Console.ReadLine();
            if (File.Exists(filename))
            {
                File.WriteAllText(sourcefile, File.ReadAllText(filename, Encoding.UTF8).ToUpper(), Encoding.UTF8);
                Console.WriteLine("Everything is fine, wrote the result to a file{0}", sourcefile);
            }
            else
            {
                Console.WriteLine("Want to cry,there is no file with the name {0}", filename);
            }
            Console.WriteLine("Задание4");
            Console.WriteLine("Введите строку");
            decimal tempurature = 34;
            object inputs = new Temperature(tempurature);
            IfsIFormatTable(inputs);
            List<string> emails = new List<string>();
            Console.ReadKey();
        }
    }
}
