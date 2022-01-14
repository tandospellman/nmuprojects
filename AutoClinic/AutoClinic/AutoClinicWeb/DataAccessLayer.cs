using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace AutoClinicWeb
{
    public class DataAccessLayer
    {
        private string connectionString;
        SqlConnection dbConn;
        SqlCommand dbCmd = new SqlCommand();
        SqlDataAdapter dbAdapter = new SqlDataAdapter();

        public DataAccessLayer()
        {
            connectionString = ConfigurationManager.ConnectionStrings["dotEXE_CSMS"].ConnectionString;
            dbConn = new SqlConnection(connectionString);
        }

        private static string connString = ConfigurationManager.ConnectionStrings["dotEXE_CSMS"].ConnectionString;
        #region ParamSelect()
        internal static DataTable ParamSelect(string commandName, CommandType cmdType,
            SqlParameter[] pars)
        {
            DataTable table = new DataTable();
            using (SqlConnection con = new SqlConnection(connString))
            {
                using (SqlCommand cmd = con.CreateCommand())
                {
                    cmd.CommandType = cmdType;
                    cmd.CommandText = commandName;
                    cmd.Parameters.AddRange(pars);

                    try
                    {
                        if (con.State != ConnectionState.Open)
                        {
                            con.Open();
                        }
                        using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                        {
                            da.Fill(table);
                        }
                    }
                    catch
                    {
                        throw;
                    }
                }
            }
            return table;
        }
        #endregion ParamSelect()
        #region NonQuery()
        internal static bool NonQuery(string commandName, CommandType cmdType,
            SqlParameter[] pars)
        {
            int result = 0;
            using (SqlConnection con = new SqlConnection(connString))
            {
                using (SqlCommand cmd = con.CreateCommand())
                {
                    cmd.CommandType = cmdType;
                    cmd.CommandText = commandName;
                    cmd.Parameters.AddRange(pars);
                    if (con.State != ConnectionState.Open)
                    {
                        con.Open();
                        result = cmd.ExecuteNonQuery();
                    }

                }
            }
            return result > 0;
        }
        #endregion NonQuery()
        #region Select()
        internal static DataTable Select(string commandName, CommandType cmdType)
        {
            DataTable table = null;
            using (SqlConnection con = new SqlConnection(connString))
            {
                using (SqlCommand cmd = con.CreateCommand())
                {
                    cmd.CommandType = cmdType;
                    cmd.CommandText = commandName;

                    try
                    {
                        if (con.State != ConnectionState.Open)
                        {
                            con.Open();
                        }
                        using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                        {
                            table = new DataTable();
                            da.Fill(table);
                        }
                    }
                    catch (SqlException)
                    {
                        throw new System.Exception("Not available at this time");
                    }
                }
            }
            return table;
        }
        #endregion Select()

        public string ConnectionString
        {
            get { return connectionString; }
            set { connectionString = value; }
        }

        public void ConnectionCheck()
        {
            if (dbConn.State == ConnectionState.Closed)
                dbConn.Open();
        }

        //====================================================================RECEPTIONIST METHODS====================================================================

        //==========================================
        //               INSERT
        //==========================================
        #region InsertStatments()
        //Creates a new booking
        public int CreateBooking(string custID, int vehicleID, int serviceID, DateTime dateIn, string comment, bool arrived, bool active)
        {
            ConnectionCheck();
            string sqlInsert = "uspBookAppointment '" + custID + "', '" + vehicleID + "', '" + serviceID + "', '" + dateIn + "', '" + comment + "', '" + arrived + "', '" + active + "'";
            dbCmd = new SqlCommand(sqlInsert, dbConn);
            return dbCmd.ExecuteNonQuery();
        }

        //Creates a new job card
        public int CreateJob(int vehicleID, int bookingID, DateTime startDate, string notes, string paymentType, bool paymentStatus)
        {
            ConnectionCheck();
            string sqlInsert = "uspCreateJob '" + vehicleID + "', '" + bookingID + "', '" + startDate + "', '" + notes + "', '" + paymentType + "', '" + paymentStatus + "'";
            dbCmd = new SqlCommand(sqlInsert, dbConn);
            return dbCmd.ExecuteNonQuery();
        }

        //Creates a new quote
        public int CreateQuote(DateTime quoteDate, DateTime expiryDate, float totalCost, float discount, bool status)
        {
            ConnectionCheck();
            string sqlInsert = "uspCreateQuote '" + quoteDate + "', '" + expiryDate + "', '" + totalCost + "', '" + discount + "', '" + status + "'";
            dbCmd = new SqlCommand(sqlInsert, dbConn);
            return dbCmd.ExecuteNonQuery();
        }

        //Adds a new customer 
        public int AddCustomer(string firstName, string surname, string phoneNumber, string email)
        {
            ConnectionCheck();
            string sqlInsert = "uspAddCsutomer '" + "','" + firstName + "','" + surname + "','" + 
                phoneNumber + "','" + email + "'";
            dbCmd = new SqlCommand(sqlInsert, dbConn);

            return dbCmd.ExecuteNonQuery();
        }

        //Adds a new vehicle
        public int AddCustomerVehicle(string customerID, string regNo, string make, string model, string year)
        {
            ConnectionCheck();
            string sqlInsert = "uspAddCustomerVehicle '" + customerID + "','" + regNo + "','" + make + "','" +
                model + "','" + year + "'";
            dbCmd = new SqlCommand(sqlInsert, dbConn);

            return dbCmd.ExecuteNonQuery();
        }
        #endregion InsertStatements()
        //==========================================
        //               UPDATE
        //==========================================
        #region UpdateStatements()
        //Updates job card adding a mechanic
        public int AssignMechanic(int jobID, string mechanicID)
        {
            ConnectionCheck();
            string sqlUpdate = "uspAssignMechanic '" + jobID + "','" + mechanicID + "'";
            dbCmd = new SqlCommand(sqlUpdate, dbConn);
            return dbCmd.ExecuteNonQuery();
        }

        //Updates a booking
        public int UpdateBooking(int bookingID, string customerID, int vehicleID, int serviceID, DateTime dateIn, DateTime dateOut, string comment, bool arrived, bool active)
        {
            ConnectionCheck();
            string sqlUpdate = "uspUpdateAppointment '" + bookingID + "', '" + customerID + "', '" + vehicleID + "', '" + serviceID + "', '" + dateIn + "', '" + dateOut + "', '" + comment + "', '" + arrived + "', '" + active + "'";
            dbCmd = new SqlCommand(sqlUpdate, dbConn);
            return dbCmd.ExecuteNonQuery();
        }

        //Updates a job
        public int UpdateJob(int jobID, DateTime endDate, string notes, bool paymentStatus, bool status)
        {
            ConnectionCheck();
            string sqlUpdate = "uspUpdateJob '" + jobID + "', '" + endDate + "', '" + notes + "', '" + paymentStatus + "', '" + status + "'";
            dbCmd = new SqlCommand(sqlUpdate, dbConn);
            return dbCmd.ExecuteNonQuery();
        }

        //Updates a mechanic's information
        public int UpdateMechanic(string employeeID, string phoneNo, string email, string addLine1, string addLine2, 
            string suburb, string city, string postalCode)
        {
            ConnectionCheck();
            string sqlUpdate = "uspUpdateMechanic '" + employeeID + "', '" + phoneNo + "', '" + email + "', '" + addLine1 + "', '" 
                + addLine2 + "', '" + suburb + "', '" + city + "', '" + postalCode + "'";
            dbCmd = new SqlCommand(sqlUpdate, dbConn);

            return dbCmd.ExecuteNonQuery();

        }

        //Checks in a vehicle for its booking
        public int CheckInVehicle(int jobID)
        {
            ConnectionCheck();
            string sqlUpdate = "uspCheckInVehicle '" + jobID + "'";
            dbCmd = new SqlCommand(sqlUpdate, dbConn);

            return dbCmd.ExecuteNonQuery();
        }

        //Checks out a vehicle after it's service is complete
        public int CheckOutVehicle(int jobID)
        {
            ConnectionCheck();
            string sqlUpdate = "uspCheckOutVehicle '" + jobID + "'";
            dbCmd = new SqlCommand(sqlUpdate, dbConn);

            return dbCmd.ExecuteNonQuery();
        }

        //Updates the selected customer's information
        public int UpdateCustomerInfo(string customerID, string firstName, string surname, DateTime dateOfBirth, string phoneNo, 
            string email, string addLine1, string addLine2, string suburb, string city, string province, string postalCode,
            int active, double accountBalance)
        {
            ConnectionCheck();
            string sqlUpdate = "uspUpdateCustomerInfo '" + customerID + "','" + firstName + "','" + surname + "','" + dateOfBirth +
                "','" + phoneNo + "','" + email + "','" + addLine1 + "','" + addLine2 + "','" + suburb + "','" + city + "','" + province 
                + "','" + postalCode + "','" + active + "','" + accountBalance + "'";
            dbCmd = new SqlCommand(sqlUpdate, dbConn);

            return dbCmd.ExecuteNonQuery();
        }

        public int UpdateVehicleInfo(string vehicleID, string serialNo, string engineType, double milage, DateTime previousServiceDate)
        {
            ConnectionCheck();
            string sqlUpdate = "uspUpdateVehicleInfo '" + vehicleID + "','" + serialNo + "','" + engineType + "','" + milage +
                "','" + previousServiceDate + "'";
            dbCmd = new SqlCommand(sqlUpdate, dbConn);

            return dbCmd.ExecuteNonQuery();
        }
        #endregion UpdateStatements()

        //==========================================
        //               SELECT
        //==========================================
        #region SelectStatements()
        //Returns all bookings that are active
        public DataTable GetAllBookings()
        {
            dbCmd = new SqlCommand("uspViewAllBookings", dbConn);
            dbAdapter.SelectCommand = dbCmd;
            DataTable dt = new DataTable();
            dbAdapter.Fill(dt);
            return dt;
        }

        //Returns bookings based on a customer
        public DataTable GetBookingCustomer(string customerID)
        {
            dbCmd = new SqlCommand("uspSelectBookingCustomer '" + customerID + "'", dbConn);
            dbAdapter.SelectCommand = dbCmd;
            DataTable dt = new DataTable();
            dbAdapter.Fill(dt);
            return dt;
        }

        //Returns bookings based on a vehicle
        public DataTable GetBookingVehicle(int vehicleID)
        {
            dbCmd = new SqlCommand("uspSelectBookingVehicle '" + vehicleID + "'", dbConn);
            dbAdapter.SelectCommand = dbCmd;
            DataTable dt = new DataTable();
            dbAdapter.Fill(dt);
            return dt;
        }

        //Returns name and vehicle id on specific booking
        public DataTable GetSelectedBooking(int bookingID)
        {
            dbCmd = new SqlCommand("uspSelectedBooking '" + bookingID + "'", dbConn);
            dbAdapter.SelectCommand = dbCmd;
            DataTable dt = new DataTable();
            dbAdapter.Fill(dt);
            return dt;
        }

        //Returns all jobs that are active
        public DataTable GetAllJobs()
        {
            dbCmd = new SqlCommand("uspViewJobs", dbConn);
            dbAdapter.SelectCommand = dbCmd;
            DataTable dt = new DataTable();
            dbAdapter.Fill(dt);
            return dt;
        }

        //Returns jobs based on a mechanic
        public DataTable GetJobsMechanic(string mechanicID)
        {
            dbCmd = new SqlCommand("uspViewJobsMechanic '" + mechanicID + "'", dbConn);
            dbAdapter.SelectCommand = dbCmd;
            DataTable dt = new DataTable();
            dbAdapter.Fill(dt);
            return dt;
        }

        //Returns all quotes that are active
        public DataTable GetAllQuotes()
        {
            dbCmd = new SqlCommand("uspViewQuotes", dbConn);
            dbAdapter.SelectCommand = dbCmd;
            DataTable dt = new DataTable();
            dbAdapter.Fill(dt);
            return dt;
        }

        //Returns quotes based on a customer
        public DataTable GetQuoteCustomer(string customerID)
        {
            dbCmd = new SqlCommand("uspViewQuoteCustomer '" + customerID + "'", dbConn);
            dbAdapter.SelectCommand = dbCmd;
            DataTable dt = new DataTable();
            dbAdapter.Fill(dt);
            return dt;
        }

        //Returns a list of all active mechanics
        public DataTable GetActiveMechanics()
        {
            dbCmd = new SqlCommand("uspGetActiveMechanics", dbConn);
            dbAdapter.SelectCommand = dbCmd;
            DataTable dt = new DataTable();
            dbAdapter.Fill(dt);

            return dt;
        }

        //Returns a list of active login details
        public DataTable GetLogins()
        {
            dbCmd = new SqlCommand("uspCheckLogin", dbConn);
            dbAdapter.SelectCommand = dbCmd;
            DataTable dt = new DataTable();
            dbAdapter.Fill(dt);

            return dt;
        }

        //Returns a list of all active customers
        public DataTable GetAllActiveCustomers()
        {
            dbCmd = new SqlCommand("uspGetAllActiveCustomers", dbConn);
            dbAdapter.SelectCommand = dbCmd;
            DataTable dt = new DataTable();
            dbAdapter.Fill(dt);

            return dt;
        }

        //Returns a customer based on the Vehicle Registration Number entered
        public DataTable GetCustomerByVehicle(string regNumber)
        {
            dbCmd = new SqlCommand("uspGetCustomerByVehicle '" + regNumber + "'", dbConn);
            dbAdapter.SelectCommand = dbCmd;
            DataTable dt = new DataTable();
            dbAdapter.Fill(dt);

            return dt;
        }

        //Returns a customer based on the Name entered
        public DataTable GetCustomerByName(string firstName, string surname)
        {
            dbCmd = new SqlCommand("uspGetCustomerByName '" + firstName + "','" + surname + "'", dbConn);
            dbAdapter.SelectCommand = dbCmd;
            DataTable dt = new DataTable();
            dbAdapter.Fill(dt);

            return dt;
        }

        //Returns selected mechanic's info
        public DataTable GetMechanicInfo(string employeeNumber)
        {
            dbCmd = new SqlCommand("uspGetMechanicInfo '" + employeeNumber + "'", dbConn);
            dbAdapter.SelectCommand = dbCmd;
            DataTable dt = new DataTable();
            dbAdapter.Fill(dt);

            return dt;
        }

        //Returns mechanic names and ids
        public DataTable GetMechanicsIDs()
        {
            dbCmd = new SqlCommand("uspGetMechanicsIDs", dbConn);
            dbAdapter.SelectCommand = dbCmd;
            DataTable dt = new DataTable();
            dbAdapter.Fill(dt);

            return dt;
        }

        //Returns a customer's info
        public DataTable GetCustomerInfo(string firstName, string surname)
        {
            dbCmd = new SqlCommand("uspGetCustomerInfo '" + firstName + "','" + surname + "'", dbConn);
            dbAdapter.SelectCommand = dbCmd;
            DataTable dt = new DataTable();
            dbAdapter.Fill(dt);

            return dt;
        }

        //Returns all vehicles
        public DataTable GetActiveVehicles()
        {
            dbCmd = new SqlCommand("uspGetActiveVehicles", dbConn);
            dbAdapter.SelectCommand = dbCmd;
            DataTable dt = new DataTable();
            dbAdapter.Fill(dt);

            return dt;
        }
        #endregion SelectStatements()

        //======================================================================CUSTOMER METHODS======================================================================

        //==========================================
        //               INSERT
        //==========================================


        //==========================================
        //               UPDATE
        //==========================================


        //==========================================
        //               SELECT
        //==========================================

        //=======================================================================REPORT METHODS=======================================================================

        //==========================================
        //               SELECT
        //==========================================
        //Returns Jobs Completed that month
        public DataTable GetCompletedJobsMonth(int month)
        {
            dbCmd = new SqlCommand("uspSelectCompletedJobsMonth '" + month + "'", dbConn);
            dbAdapter.SelectCommand = dbCmd;
            DataTable dt = new DataTable();
            dbAdapter.Fill(dt);
            return dt;
        }

        //Returns Totals days work and avg day per job for a mechanic
        public DataTable GetDayForMechanic(string mechanicID)
        {
            dbCmd = new SqlCommand("uspMechanicDaysJob '" + mechanicID + "'", dbConn);
            dbAdapter.SelectCommand = dbCmd;
            DataTable dt = new DataTable();
            dbAdapter.Fill(dt);
            return dt;
        }
    }
}