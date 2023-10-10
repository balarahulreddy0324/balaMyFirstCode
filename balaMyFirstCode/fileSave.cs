using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace balaMyFirstCode
{
    internal class fileSave
    {
        private string filePath;

        public fileSave(String filePath) //Class Constructor 
        {
            this.filePath = filePath;
        }
        public void Continue() // Static Class member

        {

            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();

        }
        public void PrintClass(int value) // Class member

        {
          
            if (value > 20)
            {
                using (StreamWriter dataWriter = new StreamWriter(filePath, true))
                    dataWriter.WriteLine("Integer Value is verified in ifelse and is greaterthan 20 i.e = " + value);
            }
            else
            {
                using (StreamWriter dataWriter = new StreamWriter(filePath, true))
                    dataWriter.WriteLine("Integer Value is verified in ifelse and is lessthan 20 i.e = " + value);
            }

        }

        public void PrintClass(String value) // Class member

        {
            for (int i = 0; i < value.Length; i++)
            {
                char c = value[i];

                switch  (c)
                {
                    case 'a':
                    case 'e':
                    case 'i':
                    case 'o':
                    case 'u':
                        using (StreamWriter dataWriter = new StreamWriter(filePath, true))
                            dataWriter.WriteLine("The " + i + "th character n the string " + value + " is a vowel i.e "+ c);
                         
                    break;
                    default:
                        using (StreamWriter dataWriter = new StreamWriter(filePath, true))
                            dataWriter.WriteLine("The " + i + "th character n the string " + value + " is a consonant/space i.e " + c);
                        break;

                }
            }

        }


        public void PrintClass(float value) // Class member

        {
          int j = 1;
          
            while (j < value)
            {
                
                using (StreamWriter dataWriter = new StreamWriter(filePath, true))
                    dataWriter.WriteLine("Writing float Value in while loop for " + j + "times = " + value);
                j++;

            }

        }
        public void PrintClass(decimal value) // Class member

        {

            using (StreamWriter dataWriter = new StreamWriter(filePath, true))
                dataWriter.WriteLine("Decimal Value = " + value);


        }

        public void PrintClass(DateTime value) // Class member

        {

            using (StreamWriter dataWriter = new StreamWriter(filePath, true))
                dataWriter.WriteLine("DateTime Value = " + value);


        }

        public void SaveSuccess() // Class member

        {

            Console.WriteLine("Data Saved to file successfully");


        }

        public void SaveFail(String value) // Class member

        {

            Console.WriteLine("Exception throwed while saving data to file  " + value);


        }

    }
}
