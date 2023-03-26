using System;
using System.Collections.Generic;
using System.Text;

namespace Tuple
{
    public class Threeuple<Tfirst, Tsecond, Tthird>
    {
        public Threeuple(Tfirst firstElement, Tsecond secondElement, Tthird thirdElement)
        {
            this.FirstElement = firstElement;
            this.SecondElement = secondElement;
            this.ThirdElement = thirdElement;   
        }

        public Tfirst FirstElement { get; private set; }
        public Tsecond SecondElement { get; private set; }
        public Tthird ThirdElement  { get; private set; }

        public override string ToString()
        {
            return $"{FirstElement} -> {SecondElement} -> {ThirdElement}";
        }
    }


}
