using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arup.Exception
{
    public class Custom :System.Exception
    {
        public Custom() { }

        public Custom(String message) : base(message) { }

        public Custom(String message, System.Exception innerException) : base(message, innerException) { }

    }
}
