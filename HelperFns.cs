using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace EnigmaApp_v2
{
    public class HelperFns
    {
        
        public static void MessageBoxOK(string message, string caption)
        {
            
            MessageBoxButtons buttons = MessageBoxButtons.OK;
            DialogResult result;

            // Displays the MessageBox.

            result = MessageBox.Show(message, caption, buttons);
            
        }

        public static void MessageBoxYesNo(string message, string caption)
        {

            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result;

            // Displays the MessageBox.

            result = MessageBox.Show(message, caption, buttons);

        }

        public static int RandInt(int min, int max)
        {
            Random randGen = new Random();
            int randInt = 0;

            randInt = randGen.Next(min, max);

            return randInt;
            

        }

        // function to check if a number is a prime
        public static bool PrimeCheck(int posPrime)
        {
            // initialize local variables
            bool bCheck = false; // always return false unless proven otherwise, covers the 1 and 0 case
            int iPCheck = posPrime;

        // loop over the number, counting down till 2
          while (iPCheck > 1)
          {
               // check for remainder and decrement if there is a remainder
                if ((posPrime != 1) && (posPrime != 0) && (iPCheck != 2) &&((posPrime % (iPCheck - 1)) != 0))
                {
                    iPCheck--;
                }
                // else if no remainder, then the number is divisible
                else if ((posPrime != 1) && (posPrime != 0) && (iPCheck  != 2) && ((posPrime % (iPCheck - 1)) == 0))
                {
                    bCheck = false;
                   break;
                }
                    // 2 is always a prime
                else if (iPCheck == 2)
                {
                    bCheck = true;
                    break;

                }
                
                
           }

            return bCheck;
        }

        //checks if a certain string can be converted to an int
        public static bool stiInputCheck(string s)
        {
            bool noException = true;

            try
            {
                Convert.ToInt32(s);

            }
            catch (FormatException)
            {
                noException = false;
            }
            catch (OverflowException)
            {
                noException = false;

            }

            return noException;
        }

        public static double DTR(double degrees)
        {
            double rad = (double)(degrees * (Math.PI / 180.0));
            return rad;
        }

        public static double RTD(double radians)
        {
            double deg = (double)(radians * (180 / Math.PI));
            return deg;
        }

        public static double RootXY(double root, double radicand)
        {
            double result = 0;

            result = Math.Pow(radicand, (1 / root));

            return result;
        }

        public static double Factorial(double n)
        {
            double result = n;
            double counter = (n - 1);

            while (counter > 1)
            {
                result = result * counter;
                counter--;
            }

            return result;
        }

    }
}
