using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using LibraryManagementCrud.Models;
namespace LibraryManagementCrud.CrudOpeartion.LibraryMembers
{
    public class LibraryMemberOperation
    {
        
        private readonly string connectionString = "Data Source=.;Initial Catalog=lms_db;Integrated Security=True";
        //string connectionString = ConfigurationManager.ConnectionStrings["CompanyDBConnect"].ConnectionString;

        public string LibraryMemberInsert(Models.LibraryMembers libraryMembers)
        {
            try
            {
                //var emailValidOrNot = validationEmailOrPhoneNo.EmailValidate(company.CompanyEmailId);
                //var phoneNoValidOrNot = validationEmailOrPhoneNo.PhoneValidate(company.CompanyPhoneNo.ToString());
                //if (emailValidOrNot && phoneNoValidOrNot)
                //{
                    using (var connection = new SqlConnection(connectionString))
                    {
                        var command = new SqlCommand
                        {
                            CommandText = "AddMembers",
                            Connection = connection,
                            CommandType = CommandType.StoredProcedure,
                        };

                        command.Parameters.AddWithValue("@MemberName", libraryMembers.MemberName);
                        command.Parameters.AddWithValue("@MemberAddress", libraryMembers.MemberAddress);
                        command.Parameters.AddWithValue("@MemberCity", libraryMembers.MemberCity);
                        command.Parameters.AddWithValue("@MemberPincode", libraryMembers.MemberPincode);
                    command.Parameters.AddWithValue("@Date_Register", libraryMembers.MemberDate_Register);
                    command.Parameters.AddWithValue("@Date_Expire", libraryMembers.MemberDate_Expire);
                    command.Parameters.AddWithValue("@Membership_Status", libraryMembers.Membership_Status);
                   
                    connection.Open();
                    command.ExecuteNonQuery();
                    // command.Parameters.Clear();
                    connection.Close();
                    }
               // }
                //else
                //{
                //    return "Enter the Valid EmailOrPhone";
                //}
                return "Library Members Insert Successfully....";
            }

            catch (Exception e)
            {
                return e.Message;
            }

        }
    }
}

