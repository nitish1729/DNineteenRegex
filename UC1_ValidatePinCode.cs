using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace DNinetheen_Regex
{
    public class UC1_validatePinCode
    {
        public static void Main(string[] args)
        {
            // This will return if shyam exist
            Regex regex = new Regex(@"400088$");

            Match match = regex.Match("The Vaild Pin Code is 400088");

            if (match.Success)
            {
                Console.WriteLine("The valid Pin Code is : " + match.Value);
            }
            Console.ReadLine();
        }
    }
}
