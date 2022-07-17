using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
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
                return length.ToString() + " Mb";
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
        /// <returns>Working directory path.</returns>
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


        /// <summary>
        /// Calculates and md5 checksum of file.
        /// </summary>
        /// <param name="file">target file.</param>
        /// <returns>md5 signature as a string.</returns>
        public string GetMd5Hash(string file)
        {
            using (var md5 = MD5.Create())
            {
                using (var stream = File.OpenRead(file))
                {
                    var v = md5.ComputeHash(stream);
                    return BitConverter.ToString(v).Replace("-", "").ToLowerInvariant();
                }
            }
        }
    }
}
