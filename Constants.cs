using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BetterReign
{
    internal class Constants
    {
        /// <summary>
        /// Percentile for predicting if a process is entering a suspended state.
        /// </summary>
        public enum SuspendedProcessProbabilties
        {
            Half = 50,              //           
            Suspended = 20          //  80% of threads in process are suspended.
        }


        /// <summary>
        /// Operational return codes.
        /// </summary>
        public enum ProcessOpperationResults
        {
            FailedStart = 2,
            Unknown = -1
        }


        /// <summary>
        /// Generic response for a process crossing the Suspended state percentile.
        /// <see cref="SuspendedProcessProbabilties"/> Percentages. 
        /// </summary>
        public const string OutputProcessBeingSuspended = "Target Process appears to be entering a suspended state.\n80% of threads have entered the Suspend sate.";
        /// <summary>
        /// Generic response for process exiting.
        /// </summary>
        public const string ProcessExitedResponse = "Process has exited.";
        /// <summary>
        /// Generic response for process failing to start.
        /// </summary>
        public const string ProcessFailedToStart = "Failed starting process";
        /// <summary>
        /// Sleep value.
        /// </summary>
        public const int UniversalSleep = 1000;
    }
}
