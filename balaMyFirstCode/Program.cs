using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Remoting.Lifetime;

using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace balaMyFirstCode
{
    internal class Program
    {
        static void Main(string[] args)
        {

            String filePath = "MyFirstDataSave.txt";
            fileSave Filesave = new fileSave(filePath);
            try
            {

                {
                    String myText = "Hello World Code"; //modify value so the for loop and switch to executes for the length of the value
                    int number = 42; //modify value to lessthan 20 to execute else command
                    float floatvalue = 3.63746477f; //modify integer value so the while loop executes for the length of the value
                    decimal decNum = 3.1472538m;
                    DateTime CurrDateTime = DateTime.Now;
                    int[] arrayint = new int[number/10];


                    Filesave.PrintClass(myText);
                    Filesave.PrintClass(number);
                    Filesave.PrintClass(floatvalue);
                    Filesave.PrintClass(decNum);
                    Filesave.PrintClass(CurrDateTime);
                }

                Filesave.SaveSuccess();
                Filesave.Continue();

            }
            catch (Exception ex)
            {
                Filesave.SaveFail(ex.Message);
                Filesave.Continue();

            }

        }
    }
}
