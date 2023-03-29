using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pr3_2
{

    class SmsMessage
    {
        private string MessageText;
        public double Price;
        public SmsMessage() { }
        public SmsMessage(string smsmessage) {
            MessageText = smsmessage;
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
            for (int i = 0; i < B.Length; i++) {
                B[i] = A[i];
            }
            if (A.Length < 65) {
                Console.WriteLine("цена: " + 1.5);
            }
            else
            {
                if ((A.Length >= 65) && (A.Length < 250))
                {
                    double n = 0;
                    for (int i = 0; i < B.Length - 65; i++)
                    {
                        n = n + 0.5;
                    }
                    Price = 1.5 + n;
                }
                else
                {
                    value = "";
                    double n = 0;
                    for (int i = 0; i < 250; i++)
                    {
                        value = value + Convert.ToString(B[i]);
                        n = n + 0.5;
                    }
                    Price = 1.5 + n;
                    
                }
                Console.WriteLine("цена: " + Price);
            }

            return value;
        }
        public void DisplaySms() {

            Console.WriteLine($"{NormalizSmsMessage(MessageText)}");
        }
        static void Main()
        {
            Console.Write("введите сообщение: ");

            string sms = Console.ReadLine();
            SmsMessage message = new SmsMessage(sms);

            message.DisplaySms();

            Console.ReadKey( true );
        }
    }

}
