using DVLDDataAccess;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLDBussinessLayer
{
    public class clsApplicationTypes
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public double Fees { get; set; }

        clsApplicationTypes()
        {
            Id = 0;
            Title = "";
            Fees = 0;
        }

        clsApplicationTypes(int id, string title, double fees)
        {
            Id = id;
            Title = title;
            Fees = fees;
        }

        public static clsApplicationTypes GetAppTypeByID(int id)
        {
            string Title = "";
            double fees = 0;
            if (clsApplicationTypesData.GetAppTypeByID(id, ref Title, ref fees))
            {
                return new clsApplicationTypes(id, Title, fees);
            }

            
            return null;
        }

        public static DataTable GetApplicationTypes()
        {
            return clsApplicationTypesData.GetApplicationTypes();
        }

        public bool UpdateAppType()
        {
            return clsApplicationTypesData.UpdateAppType(this.Id, this.Title, this.Fees);
        }

    }
}
