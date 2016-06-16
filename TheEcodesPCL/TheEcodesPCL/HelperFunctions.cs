using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheEcodes
{

    /// <summary>
    /// A class to give ease integrating the code the with the application UI.
    /// </summary>
    /// <remarks></remarks>
    public static class HelperFunctions
    {

        /// <summary>
        /// Converts the given string aliasing any E-code, to that respective Ecode enumeration value.
        /// </summary>
        /// <param name="ECodeString">String having the valid metadata of E-code</param>
        /// <returns></returns>
        /// <remarks></remarks>
        public static Ecode ConvertStringToEcode(string ECodeString)
        {
            try
            {
                if (string.IsNullOrEmpty(ECodeString) == true)
                {
                    goto Er;
                }
                else
                {
                    var ec = Enum.Parse(typeof(Ecode), Convert.ToString(ECodeString), true);
                    return ((Ecode)ec);
                }
            }
            catch
            {
                goto Er;
            }
        Er:
            throw StringToEcodeException;

        }

        /// <summary>
        /// Returns the integrity of a particular E-code.
        /// </summary>
        /// <param name="EcodeNumber">Valid E-code to be converted.</param>
        /// <returns></returns>
        /// <remarks></remarks>
        public static Integrity CheckForIntegrity(Ecode EcodeNumber)
        {
            try
            {
                EcodeInformation Einfo = new EcodeInformation(EcodeNumber);
                return Einfo.CodeIntegrity;
            }
            catch
            {
                goto Er;
            }
        Er:
            throw InvalidEcodeException;

        }


        /// <summary>
        /// Retrieves all the E-codes in a list of string.
        /// </summary>
        /// <returns></returns>
        /// <remarks></remarks>

        public static List<string> EnumerateEcodesToList()
        {

            string[] x = Enum.GetNames(typeof(Ecode));

            List<string> _lst = new List<string>();
            foreach (var ele in x)
            {
                _lst.Add(ele);
            }
            return _lst;
        }

        public static ArgumentException StringToEcodeException = new ArgumentException("Invalid E-code metadata found.");
        public static ArgumentException InvalidEcodeException = new ArgumentException("Could not cast the given E-code.");
    }
}
