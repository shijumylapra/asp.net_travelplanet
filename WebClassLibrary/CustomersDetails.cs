using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;

namespace WebClassLibrary
{
    public class CustomersDetails
    {
        public static int CustomerId { get; set; }
        public static string CusFirstName { get; set; }
        public static string CusLastName { get; set; }
        public static string CusCity { get; set; }
        public static string CusCountry { get; set; }
        public static string CusBusPhone { get; set; }
        public static string CustEmail { get; set; }
        public static string CustPostal { get; set; }

        public static int AgentId { get; set; }
        public static Int64 UserId { get; set; }
        public static string UserName { get; set; }
        public static string Password { get; set; }

        public CustomersDetails(int _CustomerId, string _CusFirstName, string _CusLastName, string _CusCity, string _CusCountry, string _CusBusPhone, string _CustEmail, string _CustPostal)
        {
            CustomerId = _CustomerId;
            CusFirstName = _CusFirstName;
            CusLastName = _CusLastName;
            CusCity = _CusCity;
            CusCountry = _CusCountry;
            CusBusPhone = _CusBusPhone;
            CustEmail = _CustEmail;
            CustPostal = _CustPostal;

        }
        public CustomersDetails()
        {

        }
    }
}
