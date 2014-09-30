using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SparkleDotNET
{
    class KNKVCMethodInvokeFailedException : Exception {

        public KNKVCMethodInvokeFailedException(Exception innerException)
            : base("Method invoke failed", innerException) {

        }
    }
}
