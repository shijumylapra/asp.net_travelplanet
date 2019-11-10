//Design and Coding Shiju Abraham 10-16-2019 @ Sait Project Term II
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebClassLibrary
{
    public class CustomerData
    {
        static decimal totalprice;
        public static List<CustomersDetails> GetCustomerDeatils;
        public static List<PackagesList> PackagesList(int Idcus)
        {
            List<PackagesList> listofPackages = new List<PackagesList>();
            PackagesList LPackages = null;
            System.Data.SqlClient.SqlConnection connection = Connection.GetConnection();

            string selectQuery = "select Packages.PackageId,CustFirstName,CustEmail,PkgName,PkgStartDate,PkgEndDate,PkgDesc,PkgBasePrice" +
                " from Customers inner join UserLogin on Customers.UserId = UserLogin.UserId inner join Packages" +
                " on UserLogin.PackageId = Packages.PackageId where Customers.CustomerId = " + Idcus + "";

            System.Data.SqlClient.SqlCommand selectCommand = new System.Data.SqlClient.SqlCommand(selectQuery, connection);
            try
            {
                connection.Open();
                System.Data.SqlClient.SqlDataReader reader = selectCommand.ExecuteReader();
                while (reader.Read())
                {
                    LPackages = new PackagesList((int)reader["PackageId"], reader["PkgName"].ToString(), Convert.ToDateTime(reader["PkgStartDate"]), Convert.ToDateTime(reader["PkgEndDate"]), (string)reader["PkgDesc"], (decimal)reader["PkgBasePrice"],0,DateTime.Today,"",0);
                     listofPackages.Add(LPackages);
                    CustomersDetails.UserName = (string)reader["CustFirstName"];
                }
            }
            catch (System.Data.SqlClient.SqlException ex)
            {
                throw ex;
            }
            finally
            {
                connection.Close();
            }
            return listofPackages;
        }

        private void GenerateID()
        {
            System.Data.SqlClient.SqlConnection conn = Connection.GetConnection();
            conn.Open();
            System.Data.SqlClient.SqlCommand cmd = new System.Data.SqlClient.SqlCommand("Select Max(CustomerId) from Customers", conn);

            System.Data.SqlClient.SqlDataReader Dreader;
            Dreader = cmd.ExecuteReader();

            string newId = string.Format("050{0}0001", DateTime.Now.Year);
            if (Dreader.HasRows)
            {
                string prefix = string.Format("050{0}", DateTime.Now.Year);
                while (Dreader.Read())
                {

                    newId = string.Format("{0}{1}", DateTime.Now.Year, Dreader[0].ToString() + 1);

                }
            }

            Users.UserId = Convert.ToInt64(newId);
            conn.Close();

        }

        public int SaveCustomerDetails()
        {
            GenerateID();
            SaveLogin();
            System.Data.SqlClient.SqlConnection conn = Connection.GetConnection();
 
            String savePackages = "Insert into Customers (CustFirstName, CustLastName, CustAddress, CustCity," +
                " CustProv, CustPostal, CustCountry, CustHomePhone, CustBusPhone, CustEmail, AgentId, UserId)values" +
                "(@CustFirstName, @CustLastName, '', @CustCity, '', @CustPostal, @CustCountry, @CustBusPhone, '', @CustEmail, @AgentId, @UserId)";
            ;
            System.Data.SqlClient.SqlCommand cmd = new System.Data.SqlClient.SqlCommand(savePackages, conn);
            cmd.Parameters.AddWithValue("@CustFirstName", CustomersDetails.CusFirstName);
            cmd.Parameters.AddWithValue("@CustLastName", CustomersDetails.CusLastName);
            cmd.Parameters.AddWithValue("@CustCity", CustomersDetails.CusCity);
            cmd.Parameters.AddWithValue("@CustCountry", CustomersDetails.CusCountry);
            cmd.Parameters.AddWithValue("@CustBusPhone", CustomersDetails.CusBusPhone);
            cmd.Parameters.AddWithValue("@CustPostal", CustomersDetails.CustPostal);
            cmd.Parameters.AddWithValue("@CustEmail", CustomersDetails.CustEmail);
            cmd.Parameters.AddWithValue("@AgentId", CustomersDetails.AgentId);
            cmd.Parameters.AddWithValue("@UserId", Users.UserId);

            try
            {
                conn.Open();

                if (cmd.ExecuteNonQuery() > 0)
                {
                    return SaveBookingDetails();
    
                }


            }
            catch (System.Data.SqlClient.SqlException ex)
            {
                throw ex;

            }
            finally
            {
                conn.Close();
            }

            return 0;
        }
        private int SaveBookingDetails()
        {

            string saveBooking = "insert into Bookings(BookingDate, BookingNo, TravelerCount, CustomerId,TripTypeId, PackageId) VALUES (GETDATE(), 'TT34', 2,(SELECT MAX(Customers.CustomerId)from Customers),@TripTypeId,@PackageId)";
            string getcusID = "SELECT MAX(Customers.CustomerId)from Customers";

            using (System.Data.SqlClient.SqlConnection sconn = Connection.GetConnection())
            {
                sconn.Open();
                using (System.Data.SqlClient.SqlCommand command1 = new System.Data.SqlClient.SqlCommand(saveBooking, sconn))
                {
                    command1.Parameters.AddWithValue("@BookingNo", Bookingdetails.Bookingnumber);
                    command1.Parameters.AddWithValue("@TravelerCount", Bookingdetails.TravelerCount);
                    command1.Parameters.AddWithValue("@TripTypeId", Bookingdetails.TripTypeId);
                    command1.Parameters.AddWithValue("@PackageId", Bookingdetails.PackageId);

                    if (command1.ExecuteNonQuery() > 0)
                    {
                        using (System.Data.SqlClient.SqlCommand command2 = new System.Data.SqlClient.SqlCommand(getcusID, sconn))
                        {
                            System.Data.SqlClient.SqlDataReader Dreader;
                            Dreader = command2.ExecuteReader();
                            if (Dreader.HasRows)
                            {
                                while (Dreader.Read())
                                {
                                    return  int.Parse(Dreader[0].ToString());
                                }
                            }
                        }
                    }
                    
                }
               
            }
            return 0;
        }
        public bool SaveBookingDetailsAfterLogin(int CustomerId)
        {

            string saveBooking = "insert into Bookings(BookingDate, BookingNo, TravelerCount, CustomerId,TripTypeId, PackageId) VALUES (GETDATE(), 'TT34', 2,@CustomerID,@TripTypeId,@PackageId)";
          
            using (System.Data.SqlClient.SqlConnection sconn = Connection.GetConnection())
            {
                sconn.Open();
                using (System.Data.SqlClient.SqlCommand command1 = new System.Data.SqlClient.SqlCommand(saveBooking, sconn))
                {
                    command1.Parameters.AddWithValue("@CustomerID", CustomerId);
                    command1.Parameters.AddWithValue("@BookingNo", Bookingdetails.Bookingnumber);
                    command1.Parameters.AddWithValue("@TravelerCount", Bookingdetails.TravelerCount);
                    command1.Parameters.AddWithValue("@TripTypeId", Bookingdetails.TripTypeId);
                    command1.Parameters.AddWithValue("@PackageId", Bookingdetails.PackageId);

                    if (command1.ExecuteNonQuery() > 0)
                    {
                        return true;
                    }

                }

            }
            return false;
        }
        private bool SaveLogin()
        {

            System.Data.SqlClient.SqlConnection conn = Connection.GetConnection();
            //  Customer Cus = new Customer();
            String savePackages = "Insert into UserLogin(UserId,UserName,UserPassword,PackageId) VALUES (@UserId,@UserName,@UserPassword,@PackageId)";
            System.Data.SqlClient.SqlCommand cmd = new System.Data.SqlClient.SqlCommand(savePackages, conn);
            cmd.Parameters.AddWithValue("@UserId", Users.UserId);
            cmd.Parameters.AddWithValue("@UserName", Users.UserName);
            cmd.Parameters.AddWithValue("@UserPassword", Users.UserPassword);
            cmd.Parameters.AddWithValue("@PackageId", Users.CusPackageId);

            try
            {
                conn.Open();

                if (cmd.ExecuteNonQuery() > 0)
                {
                    return true;
                }


            }
            catch (System.Data.SqlClient.SqlException ex)
            {
                throw ex;

            }
            finally
            {
                conn.Close();
            }

            return true;
        }

        public int IsLoggedIn( )
        {
            System.Data.SqlClient.SqlDataReader Dreader;
                System.Data.SqlClient.SqlConnection conn = Connection.GetConnection();
                
                try
                {
                    using (var cmd = new System.Data.SqlClient.SqlCommand("select CustomerId,UserLogin.UserName,Customers.CustFirstName,Customers.CustLastName from Customers inner join UserLogin on Customers.UserId = UserLogin.UserId where UserLogin.UserName = @userName and UserLogin.UserPassword = @passWord", conn))
                    {
                        cmd.Parameters.Add(new System.Data.SqlClient.SqlParameter("@userName", Users.UserName));
                        cmd.Parameters.Add(new System.Data.SqlClient.SqlParameter("@passWord", Users.UserPassword));
                        conn.Open();
                        Dreader = cmd.ExecuteReader();
                    }

                    if (Dreader.Read())
                    {
                    CustomersDetails.CusFirstName = (string)Dreader["CustFirstName"];
                    CustomersDetails.CusLastName = (string)Dreader["CustLastName"];
                    Users.CustomerId = (int)Dreader["CustomerId"];
                    Users.UserName = (string)Dreader["UserName"];

                    conn.Close(); Dreader.Close();
                    return 1;
                        
                       
                    }

                  
                }
                catch (System.Data.SqlClient.SqlException exception)
                {
                    throw exception;
                }
                finally
                {
                    if (conn.State == System.Data.ConnectionState.Open)
                        conn.Close();
                    conn.Dispose();
                     
                }
                return 0;
           

        }

        public static List<CustomersDetails> GetAllCustomers()
        {
            List<CustomersDetails> customers = new List<CustomersDetails>();
            CustomersDetails cust = null;
            
            System.Data.SqlClient.SqlConnection conn = Connection.GetConnection();
      
            string selectStatement = "select CustomerId,CustFirstName,CustLastName, CustAddress, CustCity, CustProv, " +
                "CustPostal, CustCountry, CustHomePhone,CustBusPhone, " +
                "CustEmail from Customers where CustomerId = "+   Users.CustomerId +"";

            System.Data.SqlClient.SqlCommand cmd = new System.Data.SqlClient.SqlCommand(selectStatement, conn);

            try
            {
                conn.Open();
                System.Data.SqlClient.SqlDataReader Dreader = cmd.ExecuteReader();

                while (Dreader.Read()) // while there are customers
                {
                    cust = new CustomersDetails();
                    CustomersDetails.CustomerId = (int)Dreader["CustomerId"];
                    CustomersDetails.CusFirstName = (string)Dreader["CustFirstName"];
                    CustomersDetails.CusLastName = (string)Dreader["CustLastName"];
                    CustomersDetails.CusCity = (string)Dreader["CustCity"];
                    CustomersDetails.CustPostal = (string)Dreader["CustPostal"];
                    CustomersDetails.CusCountry = (string)Dreader["CustCountry"];
                    CustomersDetails.CusBusPhone = (string)Dreader["CustBusPhone"];
                    customers.Add(cust);
                }
            }
            catch (System.Data.SqlClient.SqlException ex)
            {
                throw ex;
            }
            finally
            {
                conn.Close();
            }
            return customers;
        }
 


        public static List<PackagesList> GetPackagesDetails()
        {
            List<PackagesList> PackageData = new List<PackagesList>();
            PackagesList LPackages = null;
            System.Data.SqlClient.SqlConnection conn = Connection.GetConnection();
            System.Data.SqlClient.SqlCommand cmd = new System.Data.SqlClient.SqlCommand("Select * from Packages order by Packages.PkgName Asc", conn);
            System.Data.SqlClient.SqlDataReader reader;
            try
            {
                conn.Open();
                reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    LPackages = new PackagesList((int)reader["PackageId"], reader["PkgName"].ToString(), Convert.ToDateTime(reader["PkgStartDate"]), Convert.ToDateTime(reader["PkgEndDate"]), (string)reader["PkgDesc"], (decimal)reader["PkgBasePrice"], (decimal)reader["PkgAgencyCommission"], DateTime.Today, "", 0);
                    PackageData.Add(LPackages);
                }
            }
            catch (System.Data.SqlClient.SqlException ex)
            {
                throw ex;
            }
            finally
            {
                conn.Close();
            }
            return PackageData;
        }


        public static List<PackageonLoad> GetPackagesDetailsLoad()
        {
            List<PackageonLoad> PackageData = new List<PackageonLoad>();
            PackageonLoad LPackages = null;
            System.Data.SqlClient.SqlConnection conn = Connection.GetConnection();
            System.Data.SqlClient.SqlCommand cmd = new System.Data.SqlClient.SqlCommand(" SELECT TOP 6 * FROM Packages ORDER BY PackageId DESC", conn);
            System.Data.SqlClient.SqlDataReader reader;
            try
            {
                conn.Open();
                reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    LPackages = new PackageonLoad((int)reader["PackageId"], reader["PkgName"].ToString(), Convert.ToDateTime(reader["PkgStartDate"]), Convert.ToDateTime(reader["PkgEndDate"]), (string)reader["PkgDesc"], (decimal)reader["PkgBasePrice"], (decimal)reader["PkgAgencyCommission"], DateTime.Today, "", 0);
                    PackageData.Add(LPackages);
                }
            }
            catch (System.Data.SqlClient.SqlException ex)
            {
                throw ex;
            }
            finally
            {
                conn.Close();
            }
            return PackageData;
        }
        //public static List<int>[] UserPackageList(int customerId)
        //{
        //    List<int>[] list = new List<int>[1];
        //    list[0] = new List<int>();



        //    System.Data.SqlClient.SqlConnection conn = Connection.GetConnection();
        //    System.Data.SqlClient.SqlCommand cmd = new System.Data.SqlClient.SqlCommand("select PackageId  from Bookings where CustomerId = "+ customerId  + "", conn);
        //    System.Data.SqlClient.SqlDataReader reader;
        //    try
        //    {
        //        conn.Open();
        //        reader = cmd.ExecuteReader();

        //        while (reader.Read())
        //        {
        //            list[0].Add((int)reader["PackageId"]);
        //        }
        //    }
        //    catch (System.Data.SqlClient.SqlException ex)
        //    {
        //        throw ex;
        //    }
        //    finally
        //    {
        //        conn.Close();
        //    }
        //    return list;
        //}

        public static List<int> UserPackageList(int customerId)
        {
            List<int>  list = new List<int>();
                
            System.Data.SqlClient.SqlConnection conn = Connection.GetConnection();
            System.Data.SqlClient.SqlCommand cmd = new System.Data.SqlClient.SqlCommand("select PackageId  from Bookings where CustomerId = " + customerId + "", conn);
            System.Data.SqlClient.SqlDataReader reader;
            try
            {
                conn.Open();
                reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    list.Add((int)reader["PackageId"]);
                }
            }
            catch (System.Data.SqlClient.SqlException ex)
            {
                throw ex;
            }
            finally
            {
                conn.Close();
            }
            return list;
        }


        //public static GetBookingDetails GetRecordsPackages(int CusId)
        //{
        //        GetBookingDetails LGetBookingDeatils = new GetBookingDetails();
        //        System.Data.SqlClient.SqlDataReader reader1;


        //    string Query1 = "select [Packages].[PkgName]as PackageName,[Packages].[PkgStartDate]," +
        //        "[Packages].[PkgEndDate],[Packages].[PkgDesc] as PackageDesc,[Packages].[PkgBasePrice]," +
        //        "[Bookings].[BookingDate],[Bookings].[BookingNo],[Bookings].[TravelerCount]," +
        //        "[Customers].[CustFirstName],[Customers].[CustLastName],[Customers].[CustCity]," +
        //        "[Customers].[CustCountry],[Customers].[CustBusPhone],[Customers].[CustEmail]," +
        //        "[Customers].[CustPostal] from[dbo].[Customers] inner join[dbo].[Bookings] on " +
        //        "[dbo].[Customers].[CustomerId] = [dbo].[Bookings].[CustomerId] inner join[dbo].[Packages] " +
        //        "on [dbo].[Packages].[PackageId] = [dbo].[Bookings].[PackageId] where [Bookings].[CustomerId] = " + CusId + " ";
        //    try
        //    {
        //        using (System.Data.SqlClient.SqlConnection sconn = Connection.GetConnection())
        //        {
        //            sconn.Open();
        //            using (System.Data.SqlClient.SqlCommand command1 = new System.Data.SqlClient.SqlCommand(Query1, sconn))
        //            {
        //                reader1 = command1.ExecuteReader(System.Data.CommandBehavior.CloseConnection);

        //                while (reader1.Read())
        //                {

        //                    LGetBookingDeatils.PackageName = Convert.ToString(reader1["PackageName"]);
        //                    LGetBookingDeatils.PkgStartDate = Convert.ToDateTime(reader1["PkgStartDate"]);
        //                    LGetBookingDeatils.PkgEndDate = Convert.ToDateTime(reader1["PkgEndDate"]);
        //                    LGetBookingDeatils.PackageDesc = Convert.ToString(reader1["PackageDesc"]);
        //                    LGetBookingDeatils.PkgBasePrice = Convert.ToDecimal(reader1["PkgBasePrice"]);
        //                    LGetBookingDeatils.BookingDate = Convert.ToDateTime(reader1["BookingDate"]);
        //                    LGetBookingDeatils.Bookingnumber = reader1["BookingNo"].ToString();
        //                    LGetBookingDeatils.TravelerCount = Convert.ToInt16(reader1["TravelerCount"]);
        //                    totalprice += Convert.ToDecimal(reader1["PkgBasePrice"]);
        //                    LGetBookingDeatils.TotalPrice = Convert.ToDecimal(totalprice);


        //                    LGetBookingDeatils.CusFirstName = Convert.ToString(reader1["PackageName"]);
        //                    LGetBookingDeatils.CusLastName = Convert.ToString(reader1["PackageName"]);
        //                    LGetBookingDeatils.CusCity = Convert.ToString(reader1["PackageName"]);
        //                    LGetBookingDeatils.CusCountry = Convert.ToString(reader1["PackageName"]);
        //                    LGetBookingDeatils.CusBusPhone = Convert.ToString(reader1["PackageName"]);
        //                    LGetBookingDeatils.CustPostal = Convert.ToString(reader1["PackageName"]);

        //                }


        //            }
        //            sconn.Close();
        //        }
        //    }
        //    catch (System.Data.SqlClient.SqlException ex)
        //    {
        //        throw ex;
        //    }
        //    finally
        //    {

        //    }
        //    return LGetBookingDeatils;

        //}

        public static List<GetBookingDetails> GetRecordsPackages(int CusId)
        {

             List<GetBookingDetails> GetBookingDeatils = new List<GetBookingDetails>();
            GetBookingDetails LGetBookingDeatils = null;

            GetCustomerDeatils = new List<CustomersDetails>();
            CustomersDetails LGetCustomer = null;

            System.Data.SqlClient.SqlDataReader reader1;


            string Query1 = "select [Packages].[PkgName]as PackageName,[Packages].[PackageId],[Packages].[PkgStartDate]," +
                "[Packages].[PkgEndDate],[Packages].[PkgDesc] as PackageDesc,[Packages].[PkgBasePrice]," +
                "[Bookings].[BookingDate],[Bookings].[BookingNo],[Bookings].[TravelerCount]," +
                "[Customers].[CustFirstName],[Customers].[CustLastName],[Customers].[CustCity]," +
                "[Customers].[CustCountry],[Customers].[CustHomePhone],[Customers].[CustEmail]," +
                "[Customers].[CustPostal] from[dbo].[Customers] inner join[dbo].[Bookings] on " +
                "[dbo].[Customers].[CustomerId] = [dbo].[Bookings].[CustomerId] inner join[dbo].[Packages] " +
                "on [dbo].[Packages].[PackageId] = [dbo].[Bookings].[PackageId] where [Bookings].[CustomerId] = " + CusId + " ";
            try
            {
              
                using (System.Data.SqlClient.SqlConnection sconn = Connection.GetConnection())
                {
                    sconn.Open();
                    using (System.Data.SqlClient.SqlCommand command1 = new System.Data.SqlClient.SqlCommand(Query1, sconn))
                    {
                        reader1 = command1.ExecuteReader(System.Data.CommandBehavior.CloseConnection);
                        totalprice = 0;
                        while (reader1.Read())
                        {
                            totalprice += (Convert.ToDecimal(reader1["PkgBasePrice"]) * Convert.ToDecimal(reader1["TravelerCount"])); ;
                            LGetBookingDeatils = new GetBookingDetails((int)reader1["PackageId"],Convert.ToString(reader1["PackageName"]).ToString(),Convert.ToDateTime(reader1["PkgStartDate"]),Convert.ToDateTime(reader1["PkgEndDate"]),Convert.ToString(reader1["PackageDesc"]),Convert.ToDouble(reader1["PkgBasePrice"]),Convert.ToDateTime(reader1["BookingDate"]),Convert.ToString(reader1["BookingNo"]),Convert.ToInt16(reader1["TravelerCount"]), totalprice);
                           
                            GetBookingDeatils.Add(LGetBookingDeatils);

                               LGetCustomer =  new CustomersDetails(CusId, Convert.ToString(reader1["CustFirstName"]), Convert.ToString(reader1["CustLastName"]), Convert.ToString(reader1["CustCity"]), Convert.ToString(reader1["CustCountry"]), Convert.ToString(reader1["CustHomePhone"]), Convert.ToString(reader1["CustEmail"]), Convert.ToString(reader1["CustPostal"]));
                              GetCustomerDeatils.Add(LGetCustomer);
                        }
                    }
                    sconn.Close();
                }
            }
            catch (System.Data.SqlClient.SqlException ex)
            {
                throw ex;
            }
            finally
            {
                
            }
            return GetBookingDeatils;
        }

        public static List<PackagesList> GetPackage(int PackageId)
        {
            List<PackagesList> PackageData = new List<PackagesList>();
            PackagesList LPackages = null;
            System.Data.SqlClient.SqlConnection conn = Connection.GetConnection();
            System.Data.SqlClient.SqlCommand cmd = new System.Data.SqlClient.SqlCommand("select P.PackageId,P.PkgName,P.PkgStartDate,P.PkgEndDate,P.PkgDesc,P.PkgBasePrice,P.PkgAgencyCommission,B.BookingDate,B.BookingNo,B.TravelerCount from Bookings B inner join Packages P on P.PackageId = B.PackageId where B.PackageId = " + PackageId + "", conn);
            System.Data.SqlClient.SqlDataReader reader;
            try
            {
                conn.Open();
                reader = cmd.ExecuteReader();

                while (reader.Read())
                {

                    LPackages = new PackagesList((int)reader["PackageId"], reader["PkgName"].ToString(),Convert.ToDateTime(reader["PkgStartDate"]), Convert.ToDateTime(reader["PkgEndDate"]),(string)reader["PkgDesc"],(decimal)reader["PkgBasePrice"],(decimal)reader["PkgAgencyCommission"],(DateTime)reader["BookingDate"],(string)reader["BookingNo"], (double)reader["TravelerCount"]);

                    PackageData.Add(LPackages);

                }
            }
            catch (System.Data.SqlClient.SqlException ex)
            {
                throw ex;
            }
            finally
            {
                conn.Close();
            }
            return PackageData;
        }

        //public static List<GetBookingDetails> GetCustomerPackageRecords(int CusId)
        //{
            
        //    List<GetBookingDetails> GetBookingDeatils = new List<GetBookingDetails>();
        //    GetBookingDetails LGetBookingDeatils = null;
        //    System.Data.SqlClient.SqlDataReader reader1;
           
        //    string Query1 = "select [Packages].[PkgName]as PackageName,[Packages].[PkgStartDate]," +
        //        "[Packages].[PkgEndDate],[Packages].[PkgDesc] as PackageDesc,[Packages].[PkgBasePrice]," +
        //        "[Bookings].[BookingDate],[Bookings].[BookingNo],[Bookings].[TravelerCount] " +
        //        "from[dbo].[Bookings] inner join [dbo].[Packages] on " +
        //        "[dbo].[Packages].[PackageId] = [dbo].[Bookings].[PackageId] where[Bookings].[CustomerId] = " + CusId + "";
        //    try
        //    {
        //        using (System.Data.SqlClient.SqlConnection sconn = Connection.GetConnection())
        //        {
        //            sconn.Open();
        //            using (System.Data.SqlClient.SqlCommand command1 = new System.Data.SqlClient.SqlCommand(Query1, sconn))
        //            {
        //                reader1 = command1.ExecuteReader(System.Data.CommandBehavior.CloseConnection);

        //                while (reader1.Read())
        //                {
        //                    LGetBookingDeatils = new GetBookingDetails();
        //                    LGetBookingDeatils.PackageName = Convert.ToString(reader1["PackageName"]);
        //                    LGetBookingDeatils.PkgStartDate = Convert.ToDateTime(reader1["PkgStartDate"]);
        //                    LGetBookingDeatils.PkgEndDate = Convert.ToDateTime(reader1["PkgEndDate"]);
        //                    LGetBookingDeatils.PackageDesc = Convert.ToString(reader1["PackageDesc"]);
        //                    LGetBookingDeatils.PkgBasePrice = Convert.ToDecimal(reader1["PkgBasePrice"]);
        //                    LGetBookingDeatils.BookingDate = Convert.ToDateTime(reader1["BookingDate"]);
        //                    LGetBookingDeatils.Bookingnumber =  reader1["BookingNo"].ToString();
        //                    LGetBookingDeatils.TravelerCount = Convert.ToInt16(reader1["TravelerCount"]);
        //                    totalprice += Convert.ToDecimal(reader1["PkgBasePrice"]);
        //                    LGetBookingDeatils.TotalPrice = Convert.ToDecimal(totalprice);
        //                    GetBookingDeatils.Add(LGetBookingDeatils);
        //                }

                 
        //            }
        //            sconn.Close();
        //        }
        //    }
        //    catch (System.Data.SqlClient.SqlException ex)
        //    {
        //        throw ex;
        //    }
        //    finally
        //    {
               
        //    }
        //    return GetBookingDeatils;
  
        //}


        //public static List<Customer> GetPackage()
        //{
        //    List<Customer> PackageData = new List<Customer>();
        //    Customer CList = null;
        //    System.Data.SqlClient.SqlConnection conn = Connection.GetConnection();
        //    System.Data.SqlClient.SqlCommand cmd = new System.Data.SqlClient.SqlCommand("select CustFirstName,CustLastName,CustCity,CustPostal,CustCountry,CustHomePhone,CustEmail from Customers inner join UserLogin on Customers.UserId = UserLogin.UserId where UserLogin.UserId =" + PackageId + "", conn);
        //    System.Data.SqlClient.SqlDataReader reader;
        //    try
        //    {
        //        conn.Open();
        //        reader = cmd.ExecuteReader();

        //        while (reader.Read())
        //        {
        //            LPackages = new PackagesList((int)reader["PackageId"], reader["PkgName"].ToString(), Convert.ToDateTime(reader["PkgStartDate"]), Convert.ToDateTime(reader["PkgEndDate"]), (string)reader["PkgDesc"], (decimal)reader["PkgBasePrice"], (decimal)reader["PkgAgencyCommission"]);
        //            PackageData.Add(LPackages);
        //        }
        //    }
        //    catch (System.Data.SqlClient.SqlException ex)
        //    {
        //        throw ex;
        //    }
        //    finally
        //    {
        //        conn.Close();
        //    }
        //    return PackageData;
        //}

    }
}
 