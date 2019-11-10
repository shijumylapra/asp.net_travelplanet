using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebClassLibrary
{
    public class Bookingdetails
    {
        public static int BookingId { get; set; }
        public static DateTime BookingDate { get; set; }
        public static string Bookingnumber { get; set; }
        public static double TravelerCount { get; set; }

        public static int CustomerId { get; set; }
        public static string TripTypeId { get; set; }
        public static int PackageId { get; set; }

        public static string Packagetitle { get; set; }
        public static DateTime PkgStartDate { get; set; }
        public static DateTime PkgEndDate { get; set; }
        public static string PkgDesc { get; set; }
        public static decimal PkgBasePrice { get; set; }
       

        public Bookingdetails(int PId, string PTitle, DateTime PStartDate, DateTime PEndDate, string PDesc, decimal PBasePrice, DateTime bookingdate, string booknumber, double travelcount)
        {
            PackageId = PId;
            Packagetitle = PTitle;
            PkgStartDate = PStartDate;
            PkgEndDate = PEndDate;
            PkgDesc = PDesc;
            PkgBasePrice = PBasePrice;
            BookingDate = bookingdate;
            Bookingnumber = booknumber;
            TravelerCount = travelcount;

        }

        
    }
    public class GetBookingDetails
    {
        public  static int BookingId { get; set; }
        public static DateTime BookingDate { get; set; }
        public static string Bookingnumber { get; set; }
        public static double TravelerCount { get; set; }

        public  int CustomerId { get; set; }
        public  string TripTypeId { get; set; }
        public static int PackageId { get; set; }

        public static string PackageName { get; set; }
        public static DateTime PkgStartDate { get; set; }
        public static DateTime PkgEndDate { get; set; }
        public static string PackageDesc { get; set; }
        public static double PkgBasePrice { get; set; }


        public  string CusFirstName { get; set; }
        public  string CusLastName { get; set; }
        public  string CusCity { get; set; }
        public  string CusCountry { get; set; }
        public  string CusBusPhone { get; set; }
        public  string CustEmail { get; set; }
        public  string CustPostal { get; set; }
        public static decimal TotalPrice { get; set; }

        public GetBookingDetails(int PId, string PTitle, DateTime PStartDate, DateTime PEndDate, string PDesc, double PBasePrice, DateTime bookingdate, string booknumber, double travelcount,decimal total)
        {
            PackageId = PId;
            PackageName = PTitle;
            PkgStartDate = PStartDate;
            PkgEndDate = PEndDate;
            PackageDesc = PDesc;
            PkgBasePrice = PBasePrice;
            BookingDate = bookingdate;
            Bookingnumber = booknumber;
            TravelerCount = travelcount;
            TotalPrice = total;
        }
        public GetBookingDetails()
        {
            TotalPrice = 0;
        }
    }
}
