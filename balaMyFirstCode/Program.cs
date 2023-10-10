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
                    String myText = "Hello World_This is Bala Writing first code to save data onto a text file";
                    int number = 42;
                    float floatvalue = 3.63746477f;
                    decimal decNum = 3.1472538m;
                    DateTime CurrDateTime = DateTime.Now;


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
