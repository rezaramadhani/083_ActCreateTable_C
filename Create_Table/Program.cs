using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace Create_Table
{
    class Program
    {
        static void Main(string[] args)
        {
            new Program().Create();
        }

        public void Create()
        {
            SqlConnection con = null;
            try
            {
                con = new SqlConnection("data source=LAPTOP-LHK17QQH;database=ProdiTi;integrated Security = TRUE");
                con.Open();

                SqlCommand cm = new SqlCommand("create table Mahasiswa (NIM char(12) not null primary key, Nama varchar(50), Alamat varchar(255), Jenis_Kelamin varchar(1))", con);

                cm.ExecuteNonQuery();

                Console.WriteLine("Table sukses dibuat!");
                Console.ReadKey();
            }
            catch (Exception e)
            {
                Console.WriteLine("Oops, sepertinya ada yang salah." + e);
                Console.ReadKey();
            }
            finally
            {
                con.Close();
            }
        }
    }
}
