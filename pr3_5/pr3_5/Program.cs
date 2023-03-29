using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pr3_5
{

    class SmsMessage
    {
        private string MessageText;
        public double Price;
        public double MaxLenght;
        public double Priceunit;
        public SmsMessage() { }
        public SmsMessage(string smsmessage, double price, double maxlenght, double priceunit)
        {
            MessageText = smsmessage;
            this.Price = price;
            this.MaxLenght = maxlenght;
            this.Priceunit = priceunit;
        }
        public string smsmessage
        {
            get { return smsmessage; }
            set { smsmessage = NormalizSmsMessage(value); }
        }
        public string NormalizSmsMessage(string value)
        {
            string A = value;
            char[] B = new char[A.Length];
            for (int i = 0; i < B.Length; i++)
            {
                B[i] = A[i];
            }
            if (A.Length < 65)
            {
                Console.WriteLine("цена: " + Price);
            }
            else
            {
                if ((A.Length >= 65) && (A.Length < MaxLenght))
                {
                    double n = 0;
                    for (int i = 0; i < B.Length - 65; i++)
                    {
                        n = n + Priceunit;
                    }
                    Price = Price + n;
                }
                else
                {
                    value = "";
                    double n = 0;
                    for (int i = 0; i < MaxLenght; i++)
                    {
                        value = value + Convert.ToString(B[i]);
                        n = n + Priceunit;
                    }
                    Price = Price + n;

                }
                Console.WriteLine("цена: " + Price);
            }

            return value;
        }
        public void DisplaySms()
        {
            Console.WriteLine($"{NormalizSmsMessage(MessageText)}");
        }
        static void Main()
        {
            Console.WriteLine("введите сообщение: ");
            string sms = Console.ReadLine();

            Console.WriteLine("введите цену: ");
            double price = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("введите максимальную длину сообщения: ");
            double maxlenght = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("введите цену за 1 символ: ");
            double priceunit = Convert.ToDouble(Console.ReadLine());

            SmsMessage message = new SmsMessage(sms, price, maxlenght, priceunit);

            message.DisplaySms();

            Console.ReadKey(true);
        }
    }

}
