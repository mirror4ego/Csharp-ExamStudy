using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_If
{
    class Program
    {
        static bool verbose = false;
        static bool continueOnError = false;
        static bool logging = false;

        static void Main(string[] args)
        {

            //IF 조건문

            int a = -11;
            int val;

            if (a >= 0)
            {
                val = a;
            }
            else
            {
                val = -a;
            }

            // 출력값 : 11
            Console.Write(val);

            // Switch 조건문

            string category = "사과";
            int price;

            switch (category)
            {
                case "사과":
                    price = 1000;
                    break;
                case "딸기":
                    price = 1100;
                    break;
                case "포도":
                    price = 900;
                    break;
                default:
                    price = 0;
                    break;
            }

            // 조건문 예제

            if (args.Length != 1)
            {
                Console.WriteLine("Usage: MyApp.exe option");
                return;
            }

            string option = args[0];
            switch (option.ToLower())
            {
                case "/v":
                case "/verbose":
                    verbose = true;
                    break;
                case "/c":
                    continueOnError = true;
                    break;
                case "/l":
                    logging = true;
                    break;
                default:
                    Console.WriteLine("Unknown argument: {0}", option);
                    break;
            }
        }
    }
}
