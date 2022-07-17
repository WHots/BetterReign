using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BetterReign
{
    [Serializable]
    internal class ProcessResponse : Exception
    {
        private const string ProcessExited = "The process has exited.";
        private const string FailedToStartProcess = "Failed starting process.";


        public ProcessResponse()
        {
        }


        public ProcessResponse(string message)
            : base(message)
        {
        }


        public ProcessResponse(string message, Exception inner)
            : base(message, inner)
        {
            Task.Run(() =>
            {
                MessageBox.Show(message);
            });            
        }
    }
}
