using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomRandomList
{
    public class RandomList : List<string>
    {
        private Random random;
       
        Random rdm = new Random();   
        public string RemoveRandomElement()
        {
            if (Count == 0)
            {
                return null;
            }

            int index = rdm.Next(0, this.Count);
            string text = this[index];
            this.RemoveAt(index);
            return text;
        }
    }
}
