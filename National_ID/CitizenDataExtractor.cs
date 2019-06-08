using System;
using System.ComponentModel;
using System.Text.RegularExpressions;

namespace National_ID
{
    class CitizenDataExtractor
    {
        public static CitizenData GetCitizenData(string id)
        {
            if (!Regex.IsMatch(id, "^(\\d){14}$"))
            {
                throw new ArgumentException("National ID must be a string of 14 digits.", nameof(id));
            }

            var governorate = ((Governorates)Convert.ToByte(id.Substring(7, 2))).ToString();

            if (governorate == "0")
            {
                throw new ArgumentException("National ID isn't valid");
            }

            var year = 1700 + (int)(100 * char.GetNumericValue(id[0])) + Convert.ToByte(id.Substring(1, 2));
            var month = Convert.ToByte(id.Substring(3, 2));
            var day = Convert.ToByte(id.Substring(5, 2));

            var gender = ((byte)char.GetNumericValue(id[12]) % 2 == 1) ? "Male" : "Female";
            return new CitizenData(year, month, day, governorate, gender);

        }
        
    }
}