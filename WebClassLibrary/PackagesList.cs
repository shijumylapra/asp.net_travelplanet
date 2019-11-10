//Design and Coding Shiju Abraham 10-16-2019 @ Sait Project Term II
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebClassLibrary
{
    public class PackagesList
    {
        public static int PackageId { get; set; }
        public static string PkgName { get; set; }
        public static DateTime PkgStartDate { get; set; }
        public static DateTime PkgEndDate { get; set; }
        public static string PkgDesc { get; set; }
        public static decimal PkgBasePrice { get; set; }
        public static decimal PkgAgencyCommission { get; set; }

        public static DateTime BookingDate { get; set; }
        public static string Bookingnumber { get; set; }
        public static double TravelerCount { get; set; }


        public PackagesList(int PId, string PName, DateTime PStartDate, DateTime PEndDate, string PDesc, decimal PBasePrice, decimal PCommission, DateTime bookingdate, string booknumber, double travelcount)
        {
            PackageId = PId;
            PkgName = PName;
            PkgStartDate = PStartDate;
            PkgEndDate = PEndDate;
            PkgDesc = PDesc;
            PkgBasePrice = PBasePrice;
            PkgAgencyCommission = PCommission;
            BookingDate = bookingdate;
            Bookingnumber = booknumber;
            TravelerCount = travelcount;
        }
        public PackagesList()
        {

        }
    }

    public class PackageonLoad
    {
        public  int PackageId { get; set; }
        public  string PkgName { get; set; }
        public  DateTime PkgStartDate { get; set; }
        public  DateTime PkgEndDate { get; set; }
        public  string PkgDesc { get; set; }
        public  decimal PkgBasePrice { get; set; }
        public  decimal PkgAgencyCommission { get; set; }

        public  DateTime BookingDate { get; set; }
        public  string Bookingnumber { get; set; }
        public  double TravelerCount { get; set; }


        public PackageonLoad(int PId, string PName, DateTime PStartDate, DateTime PEndDate, string PDesc, decimal PBasePrice, decimal PCommission, DateTime bookingdate, string booknumber, double travelcount)
        {
            PackageId = PId;
            PkgName = PName;
            PkgStartDate = PStartDate;
            PkgEndDate = PEndDate;
            PkgDesc = PDesc;
            PkgBasePrice = PBasePrice;
            PkgAgencyCommission = PCommission;
            BookingDate = bookingdate;
            Bookingnumber = booknumber;
            TravelerCount = travelcount;
        }
        public PackageonLoad()
        {

        }
    }

}
