using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NameSorter
{
    public class Helper
    { 
        /// <summary>
        /// Get name in last name, given names order. 
        /// </summary>
        /// <param name="fullName">The full name in given names, last name order.</param>
        /// <returns>The name in last name, given names order.</returns>
        public static string GetLastFirstName(string fullName)
        {
            int lastIdx = fullName.LastIndexOf(' ');
            if (lastIdx == -1)
            {
                return fullName;
            }
            else
            {
                return fullName.Substring(lastIdx + 1) + ' ' + fullName.Substring(0, lastIdx).Trim();
            }
        }

        /// <summary>
        /// Get name in given names, last name order. 
        /// </summary>
        /// <param name="fullName">The full name in last name, given names order.</param>
        /// <returns>The name in given names, last name order.</returns>
        public static string GetFirstLastName(string fullName)
        {
            int firstIdx = fullName.IndexOf(' ');
            if (firstIdx == -1)
            {
                return fullName;
            }
            else
            {
                return fullName.Substring(firstIdx + 1).Trim() + ' ' + fullName.Substring(0, firstIdx);
            }
        }
    }
}
