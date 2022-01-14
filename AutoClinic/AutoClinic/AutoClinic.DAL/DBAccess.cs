using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using AutoClinic.TypeLibrary.Models;
using AutoClinic.TypeLibrary.ViewModels;
using AutoClinic.TypeLibrary.Interfaces;

namespace AutoClinic.DAL
{
    public class DBAccess : IAutoClinic
    {
        //Create Quote
        public bool CreateQuote(Quote quote)
        {
            List<SqlParameter> param = new List<SqlParameter>();
            foreach (var prop in quote.GetType().GetProperties())
            {
                if (prop.GetValue(quote) != null)
                {
                    param.Add(new SqlParameter("@" + prop.Name.ToString(), prop.GetValue(quote)));
                }
            }
            return SqlDBHelper.NonQuery("uspCreateQuote", CommandType.StoredProcedure, param.ToArray());
        }

        //Create Booking
        public bool BookAppointment(Booking booking)
        {
            List<SqlParameter> param = new List<SqlParameter>();
            foreach (var prop in booking.GetType().GetProperties())
            {
                if (prop.GetValue(booking) != null)
                {
                    param.Add(new SqlParameter("@" + prop.Name.ToString(), prop.GetValue(booking)));
                }
            }
            return SqlDBHelper.NonQuery("uspBookAppointment", CommandType.StoredProcedure, param.ToArray());
        }

        //Update Booking
        public bool UpdateBooking(UpdateBooking booking)
        {
            List<SqlParameter> param = new List<SqlParameter>();
            foreach (var prop in booking.GetType().GetProperties())
            {
                if (prop.GetValue(booking) != null)
                {
                    param.Add(new SqlParameter("@" + prop.Name.ToString(), prop.GetValue(booking)));
                }
            }
            return SqlDBHelper.NonQuery("uspUpdateAppointment", CommandType.StoredProcedure, param.ToArray());
        }

        //Assign Mechanic
        public bool AssignMechanic(AssignMechanic mechanic)
        {
            List<SqlParameter> param = new List<SqlParameter>();
            foreach (var prop in mechanic.GetType().GetProperties())
            {
                if (prop.GetValue(mechanic) != null)
                {
                    param.Add(new SqlParameter("@" + prop.Name.ToString(), prop.GetValue(mechanic)));
                }
            }
            return SqlDBHelper.NonQuery("uspAssignMechanic", CommandType.StoredProcedure, param.ToArray());
        }

        //View Bookings
        public List<UspViewBookings> ViewBooking()
        {
            List<UspViewBookings> list = new List<UspViewBookings>();
            using (DataTable table = SqlDBHelper.Select("uspViewAppointment", CommandType.StoredProcedure))
            {
                if (table.Rows.Count > 0)
                {
                    foreach (DataRow row in table.Rows)
                    {
                        UspViewBookings vb = new UspViewBookings
                        {
                            BookingID = Convert.ToString(row["Appointment Number"]),
                            CustomerName = Convert.ToString(row["Customer Name"]),
                            QuoteID = Convert.ToInt32(row["Quote Number"]),
                            Brand = Convert.ToString(row["Brand"]),
                            Make = Convert.ToString(row["Make"]),
                            Model = Convert.ToString(row["Model"]),
                            Service = Convert.ToString(row["Service Name"]),
                            DateIn = Convert.ToDateTime(row["Start Date"]),
                            DateOut = Convert.ToDateTime(row["End Date"]),
                            Comment = Convert.ToString(row["Additional Info"]),
                            Arrived = Convert.ToBoolean(row["In Workshop"])
                        };
                        list.Add(vb);
                    }
                }
            }
            return list;
        }

        //Update Vehicle Informaiton
        public bool UpdateVehicle(UpdateVehicleInfo vehicle)
        {
            List<SqlParameter> param = new List<SqlParameter>();
            foreach (var prop in vehicle.GetType().GetProperties())
            {
                if (prop.GetValue(vehicle) != null)
                {
                    param.Add(new SqlParameter("@" + prop.Name.ToString(), prop.GetValue(vehicle)));
                }
            }
            return SqlDBHelper.NonQuery("uspUpdateVehicleInfo", CommandType.StoredProcedure, param.ToArray());
        }

        //View Daily Service
        public List<UspViewSchedule> ViewSchedule(string mechanicID)
        {
            List<UspViewSchedule> list = new List<UspViewSchedule>();
            SqlParameter[] pars = new SqlParameter[]
            {
                new SqlParameter("@MechanicID", mechanicID)
            };
            using (DataTable table = SqlDBHelper.ParamSelect("uspViewSchedule", CommandType.StoredProcedure, pars))
            {
                if (table.Rows.Count > 0)
                {
                    foreach (DataRow row in table.Rows)
                    {
                        UspViewSchedule vs = new UspViewSchedule
                        {
                            MechanicID = Convert.ToString(row["Mechanic"]),
                            ServiceName = Convert.ToString(row["Service Name"]),
                            ServiceDescription = Convert.ToString(row["Description"]),
                            Date = Convert.ToDateTime(row["Day"]),
                            Notes = Convert.ToString(row["Info"]),
                            Status = Convert.ToBoolean(row["Status"])
                        };
                        list.Add(vs);
                    }
                }
            }
            return list;
        }

        //View Vehicle Info
       /* public List<UspViewVehicleInfo> ViewVehicleInfo(int vehicleID)
        {
            List<UspViewVehicleInfo> list = new List<UspViewVehicleInfo>();
            SqlParameter[] pars = new SqlParameter[]
            {
                new SqlParameter("@VehicleID", vehicleID)
            };
            using (DataTable table = SqlDBHelper.ParamSelect("uspViewVehicleInfo", CommandType.StoredProcedure, pars))
            {
                if (table.Rows.Count > 0)
                {
                    foreach (DataRow row in table.Rows)
                    {
                        UspViewVehicleInfo vvi = new UspViewVehicleInfo
                        {
                            //VehicleID = Convert.ToInt32(row["Vehicle ID"]),
                            CustomerName = Convert.ToString(row["Customer Name"]),
                            InsuranceID = Convert.ToInt32(row["Insurance ID"]),
                            RegistrationNo = Convert.ToString(row["Registration Number"]),
                            SerialNo = Convert.ToString(row["Serial Number"]),
                            Brand = Convert.ToString(row["Brand"]),
                            Make = Convert.ToString(row["Make"]),
                            Model = Convert.ToString(row["Model"]),
                            Year = Convert.ToString(row["Year"]),
                            EngineType = Convert.ToString(row["Engine Type"]),
                            Milage = Convert.ToDouble(row["Milage"]),
                            PreviousServiceDate = Convert.ToString(row["Last Service"])
                        };
                        list.Add(vvi);
                    }
                }
            }
            return list;
        }
        */
        public UspViewVehicleInfo ViewVehicleInfo(int vehicleID)
        {
            UspViewVehicleInfo vvi = null;
            SqlParameter[] pars = new SqlParameter[]
            {
                new SqlParameter("@VehicleID", vehicleID),
            };
            using (DataTable table = SqlDBHelper.ParamSelect("uspViewVehicleInfo", CommandType.StoredProcedure, pars))
            {
                    if (table.Rows.Count>0)
                {
                    DataRow row = table.Rows[0];
                    vvi = new UspViewVehicleInfo
                    {
                        CustomerName = Convert.ToString(row["Customer Name"]),
                        InsuranceID = Convert.ToInt32(row["Insurance ID"]),
                        RegistrationNo = Convert.ToString(row["Registration Number"]),
                        SerialNo = Convert.ToString(row["Serial Number"]),
                        Brand = Convert.ToString(row["Brand"]),
                        Make = Convert.ToString(row["Make"]),
                        Model = Convert.ToString(row["Model"]),
                        Year = Convert.ToString(row["Year"]),
                        EngineType = Convert.ToString(row["Engine Type"]),
                        Milage = Convert.ToDouble(row["Milage"]),
                        PreviousServiceDate = Convert.ToString(row["Last Service"])
                    };
                }
            }
            return vvi;
        }

        //View Customer Info
        public List<UspViewCustInfo> ViewCustInfo(string customerID)
        {
            List<UspViewCustInfo> list = new List<UspViewCustInfo>();
            SqlParameter[] pars = new SqlParameter[]
            {
                new SqlParameter("@CustomerID", customerID)
            };
            using (DataTable table = SqlDBHelper.ParamSelect("uspViewCustInfo", CommandType.StoredProcedure, pars))
            {
                if (table.Rows.Count > 0)
                {
                    foreach (DataRow row in table.Rows)
                    {
                        UspViewCustInfo vci = new UspViewCustInfo
                        {
                            CustomerName = Convert.ToString(row["Customer Name"]),
                            PhoneNumber = Convert.ToString(row["Phone Number"]),
                            EmailAddress = Convert.ToString(row["Email Address"]),
                            VehicleRegNo = Convert.ToString(row["Vehicle Registration Number"])
                        };
                        list.Add(vci);
                    }
                }
            }
            return list;
        }

        //Add Customer
        public bool AddCustomer(AddCustomer customer)
        {
            List<SqlParameter> param = new List<SqlParameter>();
            foreach (var prop in customer.GetType().GetProperties())
            {
                if (prop.GetValue(customer) != null)
                {
                    param.Add(new SqlParameter("@" + prop.Name.ToString(), prop.GetValue(customer)));
                }
            }
            return SqlDBHelper.NonQuery("uspAddCustomer", CommandType.StoredProcedure, param.ToArray());
        }

        //Check Login Details
        public List<UspCheckLogin> CheckLogin(string username)
        {
            List<UspCheckLogin> list = new List<UspCheckLogin>();
            SqlParameter[] pars = new SqlParameter[]
            {
                new SqlParameter("@username", username)
            };
            using (DataTable table = SqlDBHelper.ParamSelect("uspCheckLogin", CommandType.StoredProcedure, pars))
            {
                if (table.Rows.Count > 0)
                {
                    foreach (DataRow row in table.Rows)
                    {
                        UspCheckLogin cLog = new UspCheckLogin
                        {
                            Username = Convert.ToString(row["Username"]),
                            Password = Convert.ToString(row["Password"]),
                            EmployeeID = Convert.ToString(row["EmployeeID"]),
                            CustomerID = Convert.ToString(row["CustomerID"])
                        };

                        list.Add(cLog);
                    }
                }
            }
            return list;
        }
    }
}
