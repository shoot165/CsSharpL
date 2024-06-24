using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Pr5
{
    public class MageEventArgs : EventArgs
    {
        public string Message { get; }

        public MageEventArgs(string message)
        {
            Message = message;
        }
    }
}
