using DVLDDataAccess;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLDBussinessLayer
{
    public class clsTestType
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public double Fees { get; set; }


        clsTestType()
        {
            Id = 0;
            Title = "";
            Description = "";
            Fees = 0;


        }

        clsTestType(int id, string title, string description, double fees)
        {
            Id = id;
            Title = title;
            Description = description;
            Fees = fees;
        }

        public static clsTestType Find(int id)
        {
            string Title = "", Description = "";
            double fees = 0;
            if (clsTestTypeData.GetTestTypeByID(id, ref Title, ref Description, ref fees))
            {
                return new clsTestType(id, Title, Description, fees);
            }


            return null;
        }

        public static DataTable GetTestTypes()
        {
            return clsTestTypeData.GetTestTypes();
        }

        public bool UpdateTestType()
        {
            return clsTestTypeData.UpdateTestType(this.Id, this.Title,this.Description, this.Fees);
        }
    }
}
