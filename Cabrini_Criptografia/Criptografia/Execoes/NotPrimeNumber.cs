using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Criptografia.Execoes
{
    public class NotPrimeNumber:Exception
    {
        public NotPrimeNumber(string message): base(message)
        {

        }
    }
}
