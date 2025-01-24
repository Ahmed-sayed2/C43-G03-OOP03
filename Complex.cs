using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    internal class Complex
    {
        
        public int R { get; set; }
        public int Im { get; set; }
        public static Complex operator -(Complex C1, Complex C2) {
            return new Complex
            {
                R = C1.R - C2.R,
                Im = C1.Im - C2.Im
            };
        }
        public static Complex operator +(Complex C1, Complex C2)
        {
            return new Complex
            {
                R = C1.R + C2.R,
                Im = C1.Im + C2.Im
            };
        }
    }
    
}
