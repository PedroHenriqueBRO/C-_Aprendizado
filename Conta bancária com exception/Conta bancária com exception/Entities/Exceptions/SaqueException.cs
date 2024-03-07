using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conta_bancária_com_exception.Entities.Exceptions
{
    public class SaqueException : ArgumentOutOfRangeException
    {
        public SaqueException(string message) :base(message){ }
    }
}
