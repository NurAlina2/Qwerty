using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Qwerty.Filee
{
    class ProductObj
    {
        public static int Id { get; set; }
        public static string Name { get; set; }
        public static decimal Cost { get; set; }

        public static string MainImage { get; set; }
        public static string Description { get; set; }
        public static int DataOfAddition { get; set; }
        public static string UnitId { get; set; }
        public static string ManufacturerCountryId { get; set; }
        public static bool IsActive { get; set; }
    }
}
