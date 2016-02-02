using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lexicon_dag7
{
    public class Person
    {
        string FName = "";
        string LName = "";

        /* */

        public Person()
        {
            Console.WriteLine("hello");
        }

        public Person(string FName)
        {
            this.FName = FName;
        }

        public Person(string FName, string LName)
        {
            this.FName = FName;
            this.LName = LName;
        }
    }
}
