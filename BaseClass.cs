using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    internal class BaseClass
    {
        public virtual void DisplayMessage() {
            Console.WriteLine("Message from BaseClass");

        }
    }
    internal class DerivedCalass:BaseClass
    {
        public override void DisplayMessage()
        {
            Console.WriteLine("Message from derviedClass");
        }
    }
    internal class DerivedCalass2 : BaseClass
    {
        public new void DisplayMessage()
        {
            Console.WriteLine("Message from derviedClass2");
        }
    }
}
