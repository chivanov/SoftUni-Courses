using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Telephony.Exeptions;

namespace Telephony
{
    public class Smartphone : ICallable, IBrowseable
    {

        public string Call(string number)
        {
            if (!number.All(c => Char.IsDigit(c)))
            {
                throw new ArgumentException(ExeptionMessages.InvalidNumberExeption);
            }
            return number.Length > 7 ? $"Calling... {number}" : $"Dialing... {number}";
        }
        public string Browse(string url)
        {
            if (url.Any(c => char.IsDigit(c)))
            {
                throw new ArgumentException(ExeptionMessages.InvalidUrlExeption);
            }
            return $"Browsing: {url}!";
        }

      
    }
}
