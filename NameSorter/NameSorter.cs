using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NameSorter
{
    public class NameSorter
    {
        /// <summary>
        /// Sort name array by Lastname then Given name
        /// </summary>
        /// <param name="names"></param>
        public static void SortNames(string[] names)
        {
            List<string> unSortedlist = new List<string>();
            for (int i = 0; i < names.Length; i++) 
            {
                names[i] = Helper.GetLastFirstName(names[i]);
            }

            Array.Sort(names);

            for (int i = 0; i < names.Length; i++)
            {
                names[i] = Helper.GetFirstLastName(names[i]);
            }

        }
    }
}
