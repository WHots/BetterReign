using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Morningstar.Core.Foundation.ProcessOperations.Performance
{
    /// <summary>
    /// Class to easily pull process stats & more.
    /// </summary>
    internal class Resources : Constants
    {
        
        /// <summary>
        /// Returns processes memory usage as string.
        /// </summary>
        /// <param name="udid">Target process</param>
        /// <returns>Memory usage.</returns>
        public string GetProcessMemoryUsage(int udid)
        {
            Process process;
            int workingset = 0;

            try
            {
                process = Process.GetProcessById(udid);

                if (process != null)
                {
                    workingset = (int)process.WorkingSet64 / 1024 / 1024;
                    process.Dispose();
                }
            }
            catch (Exception ErrorResponse)
            {
                if (ErrorResponse is InvalidOperationException || ErrorResponse is ArgumentException)
                {
                    return ProcessTerminatedDuringCapture;
                }
            }
            return workingset.ToString();           
        }
     

        /// <summary>
        /// Returns processes thread count.
        /// </summary>
        /// <param name="udid">Target process</param>
        /// <returns>Process thread count</returns>
        public string GetProcessThreadCount(int udid)
        {
            Process? process = null;
            string result = string.Empty;         

            try
            {
                process = Process.GetProcessById(udid);

                if (process != null)
                {
                    result = process.Threads.Count.ToString();
                    process.Dispose();
                }
            }
            catch (Exception ErrorResponse)
            {
                if (ErrorResponse is InvalidOperationException || ErrorResponse is ArgumentException)
                {
                    return ProcessTerminatedDuringCapture;
                }                    
            }   
            
            return result;          
        }


        /// <summary>
        /// Get the count of suspended threads in TargetProcess.
        /// </summary>
        /// <param name="udid"></param>
        /// <returns>Suspended thread count in process.</returns>
        public string GetProcessSuspendedThreadCount(int udid)
        {
            Process? process = null;           
            int suspendedthread = 0;


            try
            {
                process = Process.GetProcessById(udid);

                if (process != null)
                {
                    foreach (ProcessThread thread in process.Threads)
                    {
                        if (thread.ThreadState == System.Diagnostics.ThreadState.Wait)
                        {
                            if (thread.WaitReason == ThreadWaitReason.Suspended)
                            {
                                suspendedthread += 1;
                            }
                        }
                    }

                    process.Dispose();
                    return suspendedthread.ToString();
                }
            }
            catch (Exception ErrorResponse)
            {
                if (ErrorResponse is InvalidOperationException || ErrorResponse is ArgumentException)
                {
                    return ProcessTerminatedDuringCapture;
                }
                else
                {
                    suspendedthread = -1;
                }
            }

            return suspendedthread.ToString();
        }


        /// <summary>
        /// Returns processes handle count.
        /// </summary>
        /// <param name="udid">Target process</param>
        /// <returns>Process handle count</returns>
        public string GetProcessHandleCount(int udid)
        {
            Process? process = null;
            string result = string.Empty;

            try
            {
                process = Process.GetProcessById(udid);

                if (process != null)
                {
                    result = process.HandleCount.ToString();
                    process.Dispose();
                }
            }
            catch (Exception ErrorResponse)
            {
                if (ErrorResponse is InvalidOperationException || ErrorResponse is ArgumentException)
                {
                    return ProcessTerminatedDuringCapture;
                }
            }           
            return result;           
        }


        /// <summary>
        /// Returns processes start arguments.
        /// </summary>
        /// <param name="udid">Target process</param>
        /// <returns>Start arugments</returns>
        public string GetProcessArguments(int udid)
        {
            Process? process = null;
            string result = string.Empty;

            try
            {
                process = Process.GetProcessById(udid);

                if (process != null)
                {
                    result = process.StartInfo.Arguments;
                    process.Dispose();
                }
            }
            catch (Exception ErrorResponse)
            {
                if (ErrorResponse is InvalidOperationException || ErrorResponse is ArgumentException)
                {                    
                    return ResultWasEmpty;
                }
            }
            
            return result;
        }
      

        /// <summary>
        /// Returns process priority.
        /// </summary>
        /// <param name="udid">Target process</param>
        /// <Returns process priority.</returns>
        public string GetProcessPriority(int udid)
        {
            using (Process process = Process.GetProcessById(udid))
            {
                try
                {
                    switch (process.BasePriority)
                    {
                        case 4:
                            return "IDLE";
                        case 8:
                            return "Normal";
                        case 13:
                            return "High";
                        case 24:
                            return "RealTime";
                        default:
                            return "Unknown";
                    }
                }
                catch (InvalidOperationException)
                {
                    return ProcessTerminatedDuringCapture;
                }                             
            }
        }


        /// <summary>
        /// Returns processes working directory.
        /// </summary>
        /// <param name="udid">Target process</param>
        /// <returns>Working directory of process</returns>
        public string GetProcessWindowTitle(int udid)
        {
            string? result = null;

            using (Process process = Process.GetProcessById(udid))
            {
                result = process.MainWindowTitle;
            }

            if (string.IsNullOrWhiteSpace(result))
            {
                return ResultWasEmpty;
            }
            else
            {
                return result;
            }
        }
    }
}
