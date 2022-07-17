using BetterReign.Core.Foundation.CFFilePrimitives;
using Morningstar.Core.Foundation.ProcessOperations.Performance;
using System.Diagnostics;

namespace BetterReign
{

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Targeted file to monitor.
        /// </summary>
        private string TargetFile = string.Empty;
        /// <remarks>
        /// <see cref="ProcessExited(object, EventArgs)"/> 
        /// </remarks>
        private bool ProcessIsRunning = false;
        

        Resources processGeneralInformation = new Resources();


        /// <summary>
        /// If 'TargetProcess' is terminated ...
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ProcessExited(object sender, System.EventArgs e)
        {
            ProcessIsRunning = false;
            Task.Run(() =>
            {
                MessageBox.Show(Constants.ProcessExitedResponse);
            });
        }


        /// <summary>
        /// Builds process & runs it.
        /// </summary>
        /// <param name="file">Target file to run.</param>
        /// <returns></returns>
        /// <remarks>
        /// <see cref="TargetFile"/> Object build.
        /// </remarks>
        private int StartProcess(string file)
        {        
            var userStartedProcess = new Process();
            userStartedProcess.StartInfo.FileName = file;
            userStartedProcess.StartInfo.CreateNoWindow = false;
            userStartedProcess.StartInfo.WindowStyle = ProcessWindowStyle.Minimized;
            userStartedProcess.EnableRaisingEvents = true;
            userStartedProcess.Exited += new EventHandler(ProcessExited);
            userStartedProcess.Start();

            if(userStartedProcess != null)
            {
                var targetProcess = new TargetProcess(userStartedProcess.Id, userStartedProcess.ProcessName, null);
                Task.Run(() => { CaptureGeneralProcessInformation(targetProcess); });
            }
            else
            {
                return -1;
            }

            this.ProcessIsRunning = true;
            return 1;                     
        }


        /// <summary>
        /// Captures process information.
        /// </summary>
        /// <param name="process">Selected process Object.</param>
        /// <remarks>
        /// <see cref="TargetProcess"/> For object class.
        /// <see cref="StartProcess"/> For usage.
        /// </remarks>
        private void CaptureGeneralProcessInformation(TargetProcess process)
        {             
            BackgroundWork.ControlInvoke(label_ProcessStartArugments, () => label_ProcessStartArugments.Text = processGeneralInformation.GetProcessArguments(process.ProcessId));          

            while (ProcessIsRunning)
            {
                BackgroundWork.ControlInvoke(label_ProcessMemoryUsage, () => label_ProcessMemoryUsage.Text = processGeneralInformation.GetProcessMemoryUsage(process.ProcessId).ToString() + "Mb");
                BackgroundWork.ControlInvoke(label_ProcessWindowTitle, () => label_ProcessWindowTitle.Text = processGeneralInformation.GetProcessWindowTitle(process.ProcessId));
                BackgroundWork.ControlInvoke(label_ProcessThreadCount, () => label_ProcessThreadCount.Text = processGeneralInformation.GetProcessThreadCount(process.ProcessId));
                BackgroundWork.ControlInvoke(label_SuspendedThreadCount, () => label_SuspendedThreadCount.Text = processGeneralInformation.GetProcessSuspendedThreadCount(process.ProcessId));
                BackgroundWork.ControlInvoke(label_ProcessHandleCount, () => label_ProcessHandleCount.Text = processGeneralInformation.GetProcessHandleCount(process.ProcessId));
                BackgroundWork.ControlInvoke(label_ProcessPriority, () => label_ProcessPriority.Text = processGeneralInformation.GetProcessPriority(process.ProcessId));
                Task.Delay(Constants.UniversalSleep);
            }

            return;
        }


        /// <summary>
        /// Selects file to gather information on.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void menuitem_File_SelectFile_Click(object sender, EventArgs e)
        {
            string file = string.Empty;
            Property property = new Property();

            var openFileDialog = new OpenFileDialog()
            {
                InitialDirectory = Environment.CurrentDirectory,
                Title = "Select File",
                Filter = "exe files (*.exe)|*.exe",
                FilterIndex = 2,
                RestoreDirectory = true
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                file = openFileDialog.FileName;
                label_FileDirectory.Text = property.GetWorkingDirectory(file);
                label_FileSizeMb.Text = property.GetFileSize(file);
                label_FileSignature.Text = property.GetMd5Hash(file);
            }

            ProcessIsRunning = false;

            if (!string.IsNullOrEmpty(value: file))
            {
                int startprocess = StartProcess(file:file);

                if(startprocess == (int)Constants.ProcessOpperationResults.FailedStart)
                {
                    Task.Run(() =>
                    {
                        MessageBox.Show(Constants.ProcessFailedToStart);
                    });
                }
            }          
        }


        private void label_SuspendedThreadCount_TextChanged(object sender, EventArgs e)
        {

            int threadcount = 0;
            int suspendedthreadcount = 0;

            try
            {
                threadcount = Int32.Parse(s: label_ProcessThreadCount.Text);
                suspendedthreadcount = Int32.Parse(s: label_SuspendedThreadCount.Text);
            }
            catch (FormatException)
            {
                return;
            }
            catch (ArgumentNullException)
            {
                return;
            }

            bool exceeded = false;

            if(threadcount >= 1 & suspendedthreadcount >= 1)
            {
                int percentage = (threadcount - suspendedthreadcount * 100) / suspendedthreadcount;
                exceeded = (percentage <= (int)Constants.SuspendedProcessProbabilties.Suspended) ? true : false;                
            }
            else
            {
                return;
            }
            if (exceeded)
            {
                MessageBox.Show(Constants.OutputProcessBeingSuspended);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label_FileDirectory_Click(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
    }
}


/// <summary>
/// Selected process OBJ.
/// </summary>
public class TargetProcess
{
    private int processId;
    private string processName;

    public int ProcessId { get => processId; set => processId = value; }
    public string ProcessName { get => processName; set => processName = value; }
    public int? ProcessVersion { get; set; }


    public TargetProcess(int pid, string name, int? version)
    {
        ProcessId = pid;
        ProcessName = name;
        ProcessVersion = version;
    }
}


class BackgroundWork
{
    delegate void UniversalVoidDelegate();

    public static void ControlInvoke(Control control, Action function)
    {
        if (control.IsDisposed || control.Disposing)
            return;

        if (control.InvokeRequired)
        {
            control.Invoke(new UniversalVoidDelegate(() => ControlInvoke(control, function)));
            return;
        }
        function();
    }
}