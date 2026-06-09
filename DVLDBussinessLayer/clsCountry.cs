using DVLDDataAccess;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLDBussinessLayer
{
    public class clsCountry
    {
        public int ID { get; set; }
        public string CountryName { get; set; }

        clsCountry(int id , string countryName)
        {
            ID = id;
            CountryName = countryName;
        }
        public static DataTable GetAllCountries()
        {
            return clsCountryData.GetAllCountries();

        }
        public static clsCountry Find(string CountryName)
        {

            int ID = -1;


            if (clsCountryData.GetCountryInfoByName(CountryName, ref ID))

                return new clsCountry(ID, CountryName);
            else
                return null;

        }
        public static clsCountry Find(int id)
        {

            string CountryName = "";


            if (clsCountryData.GetCountryInfoByID(ref CountryName,  id))

                return new clsCountry(id, CountryName);
            else
                return null;

        }
    }
}
