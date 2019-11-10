using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebClassLibrary
{
    public class StorePackages
    {
        public static int PackageId { get; set; }
        public static string PkgName { get; set; }
        public static DateTime PkgStartDate { get; set; }
        public static DateTime PkgEndDate { get; set; }
        public static string PkgDesc { get; set; }
        public static decimal PkgBasePrice { get; set; }
        public static decimal PkgAgencyCommission { get; set; }

    }
}
