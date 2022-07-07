using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BetterReign.Core.Foundation.CFFilePrimitives
{
    internal class Property : constants
    {
        /// <summary>
        /// Gets the file size in MB.
        /// </summary>
        /// <param name="file">target file.</param>
        /// <returns>File size in MB.</returns>
        public string GetFileSize(string file)
        {
            var information = new FileInfo(file);
            long? length = information.Length / 1024 / 1024;
            
            if(length.HasValue)
            {               
                return length.ToString();
            }
            else
            {
                return Error;
            }

            return RanToEnd;
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="file">target file.</param>
        /// <returns>Working directory path,</returns>
        public string GetWorkingDirectory(string file)
        {
            var information = new FileInfo(file);
            var value = information.DirectoryName;

            if (!string.IsNullOrWhiteSpace(value))
            {
                return value;
            }
            else
            {
                return Error;
            }

            return RanToEnd;
        }
    }
}
