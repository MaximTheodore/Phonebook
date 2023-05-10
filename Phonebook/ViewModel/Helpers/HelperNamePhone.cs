using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Phonebook.ViewModel.Helpers
{
    internal class HelperNamePhone
    {
        public static bool PhoneNumber_phone(string phoneNumber)
        {

            
            Regex regex = new Regex(@"\w*");
            MatchCollection matches = regex.Matches(phoneNumber);
            if (matches.Count > 0)
            {
                return true;
            }
            return false;
        }
        public static bool Name_name(string Name) 
        {
            Regex regex = new Regex(@"[+][1-9] [0-9]{3}[0-9]{3}[0-9]{2}[0-9]{2}");
            Regex regex1 = new Regex(@"[0-9]{3}-[0-9]{4}");
            MatchCollection matches = regex.Matches(Name);
            MatchCollection matches1 = regex1.Matches(Name);
            if (matches1.Count > 0 || matches.Count>0) 
            {
                return true;
            }
            return false;

        }
    }
}
