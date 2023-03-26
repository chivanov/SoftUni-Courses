using System;
using System.Collections.Generic;
using System.Text;

namespace Tuple
{
    public class Tuple<Tfirst, Tsecond>
    {
        public Tuple(Tfirst firstElement, Tsecond secondElement)
        {
            this.FirstElement = firstElement;
            this.SecondElement = secondElement;
        }

        public Tfirst FirstElement { get; private set; }
        public Tsecond SecondElement { get; private set; }

        public override string ToString()
        {
            return $"{FirstElement} -> {SecondElement}";
        }
    }


}
