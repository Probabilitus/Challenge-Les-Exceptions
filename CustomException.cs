using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LES_EXCEPTIONS
{
    public class CustomException : Exception
    {
        public DateTime ErrorTime { get; set; }

        public CustomException(string message)
            : base(message)
        {
            ErrorTime = DateTime.Now;
        }
    }
}
