using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using LibraryManagementCrud.Models;
namespace LibraryManagementCrud.CrudOpeartion.SupplierDetails
{
    public class SupplierDetailsOperations
    {
        private readonly string connectionString = "Data Source=.;Initial Catalog=lms_db;Integrated Security=True";
        //string connectionString = ConfigurationManager.ConnectionStrings["CompanyDBConnect"].ConnectionString;

        public string InsertSupplierdetails(Models.Suppliers supplier)
        {
            try
            {
                using (var connection = new SqlConnection(connectionString))
                {
                    var commandsupplier = new SqlCommand
                    {
                        CommandText = "AddSupplier",
                        Connection = connection,
                        CommandType = CommandType.StoredProcedure,
                    };

                    commandsupplier.Parameters.AddWithValue("@SupplierName", supplier.SupplierName);
                    commandsupplier.Parameters.AddWithValue("@SupplierAddress", supplier.SupplierAddress);
                    commandsupplier.Parameters.AddWithValue("@SupplierCity", supplier.SupplierCity);
                    commandsupplier.Parameters.AddWithValue("@SupplierPincode", supplier.SupplierPincode);
                    commandsupplier.Parameters.AddWithValue("@Suppliercontact", supplier.SupplierContact);
                    commandsupplier.Parameters.AddWithValue("@SupplierEmail", supplier.SupplierEmail);



                    connection.Open();
                    var idInserted = commandsupplier.ExecuteScalar();

                    supplier.SupplierId = Convert.ToInt32(idInserted);

                    foreach (var bookdetails in supplier.bookdetaillist)
                    {
                        var command = new SqlCommand
                        {
                            CommandText = "AddBookDetails",
                            Connection = connection,
                            CommandType = CommandType.StoredProcedure,
                        };

                        command.Parameters.AddWithValue("@BookTitle", bookdetails.BookTitle);
                        command.Parameters.AddWithValue("@Category", bookdetails.BookCategory);
                        command.Parameters.AddWithValue("@Author", bookdetails.BookAuthor);
                        command.Parameters.AddWithValue("@Publication", bookdetails.BookPublication);
                        command.Parameters.AddWithValue("@Publishdate", bookdetails.BookPublish_Date);
                        command.Parameters.AddWithValue("@BookEdition", bookdetails.BookEdition);
                        command.Parameters.AddWithValue("@Price", bookdetails.BookPrice);
                        command.Parameters.AddWithValue("@RankNumber", bookdetails.BookRank_Number);
                        command.Parameters.AddWithValue("@DateArrival", bookdetails.BookDate_Arrival);
                        command.Parameters.AddWithValue("@SupplierId", supplier.SupplierId);

                        command.ExecuteNonQuery();
                        command.Parameters.Clear();
                    }
                    commandsupplier.Parameters.Clear();
                    connection.Close();
                }
                return "Supplier With Book Detail Record Inserted Successfully...";
            }

            catch (Exception exception)
            {
                return exception.Message;
            }


        }
    }
}
