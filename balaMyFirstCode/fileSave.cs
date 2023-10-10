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
        public void Continue() // Class member

        {

            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();

        }
        public void PrintClass(int value) // Class member

        {

            using (StreamWriter dataWriter = new StreamWriter(filePath, true))
                dataWriter.WriteLine("Integer Value = " + value);


        }

        public void PrintClass(String value) // Class member

        {

            using (StreamWriter dataWriter = new StreamWriter(filePath, true))
                dataWriter.WriteLine("String Value = " + value);


        }


        public void PrintClass(float value) // Class member

        {

            using (StreamWriter dataWriter = new StreamWriter(filePath, true))
                dataWriter.WriteLine("float Value = " + value);


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
