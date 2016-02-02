using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lexicon_dag7
{
    class Program
    {
        static void Main(string[] args)
        {

            Person pObj = new Person("11");
            Console.WriteLine(pObj);


            // 'please key to close' feature
            Console.WriteLine("Press any key to close the window!!");
            Console.ReadKey();
            
            /*
            testing stuffs
            String symbol = "\u2202";
            Console.WriteLine(symbol);
            */

           
        }

        

    }
}
