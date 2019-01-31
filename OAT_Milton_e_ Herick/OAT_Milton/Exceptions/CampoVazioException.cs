using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OAT_Milton.Exceptions
{
    class CampoVazioException : Exception
    {
        public CampoVazioException()
        {

        }

        public CampoVazioException(string message) : base(message)
        {

        }
    }
}
