using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FOPCSLecture
{
    using System;
    class Day5Quiz
    {

        public static void Main()
        {
            Console.Write("Enter a Matriculation No.: ");
            string matNo = Console.ReadLine();
            int matNoDigit = Convert.ToInt32(matNo.Length);

            if (matNoDigit != 7)
            {
                Console.WriteLine("Invalid");
            }
            else
            {
                string matNoCap = matNo.ToUpper();
                string n1 = matNoCap.Substring(1, 1);
                string n2 = matNoCap.Substring(2, 1);
                string n3 = matNoCap.Substring(3, 1);
                string n4 = matNoCap.Substring(4, 1);
                string n5 = matNoCap.Substring(5, 1);

                int n1I = Convert.ToInt32(n1);
                int n2I = Convert.ToInt32(n2);
                int n3I = Convert.ToInt32(n3);
                int n4I = Convert.ToInt32(n4);
                int n5I = Convert.ToInt32(n5);

                int sum = 0;
                n1I = (n1I * 6);
                sum = sum + n1I;

                n2I = (n2I * 5);
                sum = sum + n2I;

                n3I = (n3I * 4);
                sum = sum + n3I;

                n4I = (n4I * 3);
                sum = sum + n4I;

                n5I = (n5I * 2);
                sum = sum + n5I;

                int getRem = sum % 5;
                string lastAlpha = "";
                switch (getRem)
                {
                    case 0:
                        lastAlpha = "O";
                        break;
                    case 1:
                        lastAlpha = "P";
                        break;
                    case 2:
                        lastAlpha = "Q";
                        break;
                    case 3:
                        lastAlpha = "R";
                        break;
                    case 4:
                        lastAlpha = "S";
                        break;

                    default:
                        Console.WriteLine("Invalid");
                        break;
                }

                string checkSum = matNoCap.Substring(6, 1);

                if (lastAlpha == checkSum)
                {    //valid
                    Console.WriteLine("Valid");
                }
                else
                {
                    Console.WriteLine("Invalid");
                }
            }

        }        
    }
}




