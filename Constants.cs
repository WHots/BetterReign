using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BetterReign
{
    internal class Constants
    {
        public enum SuspendedProcessProbabilties
        {
            Half = 50,
            ThreeQuarters = 28,
            Suspended = 20
        }

        public const string OutputProcessBeingSuspended = "Target Process appears to be entering a suspended state.\n80% of threads have entered the Suspend sate.";
        public const int UniversalSleep = 1000;
    }
}
