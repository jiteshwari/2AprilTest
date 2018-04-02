using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks; 
using System.Data.SqlClient;

namespace Cls
{
    class ADOJOINS
    {
        static SqlConnection con;
        static SqlCommand com;
        public static void connection()
        {
            con = new SqlConnection(@"Data Source=CG-DTE-Student;Initial Catalog=BhupyJ;Integrated Security=True");
            con.Open();
        }
        public static void LeftJion()
        {
            String sql = "SELECT student2.name, tblEmployee2.id FROM student2 LEFT JOIN tblEmployee2 on student2.name = tblEmployee2.name ORDER BY tblEmployee2.name";
            com = new SqlCommand(sql, con);
            SqlDataReader sdr = com.ExecuteReader();
            for (int i = 0; i < sdr.FieldCount; i++)
            {
                Console.Write(sdr.GetName(i) + "\t" + "\t");
            }
            Console.WriteLine();
            Console.WriteLine("=================================");
            while (sdr.Read())
            {
                for (int i = 0; i < sdr.FieldCount; i++)
                {
                    Console.Write(sdr[sdr.GetName(i)] + "\t" + "\t");
                }
                Console.WriteLine();
            }
        }
        public static void RightJion()
        {
            String sql = "SELECT student2.name, tblEmployee2.id FROM student2 RIGHT JOIN tblEemployee2 on student2.name = tblEmployee2.name ORDER BY tblEmployee2.name";
            com = new SqlCommand(sql, con);
            SqlDataReader sdr = com.ExecuteReader();
            for (int i = 0; i < sdr.FieldCount; i++)
            {
                Console.Write(sdr.GetName(i) + "\t" + "\t");
            }
            Console.WriteLine();
            Console.WriteLine("=================================");
            while (sdr.Read())
            {
                for (int i = 0; i < sdr.FieldCount; i++)
                {
                    Console.Write(sdr[sdr.GetName(i)] + "\t" + "\t");
                }
                Console.WriteLine();
            }
        }
        public static void FullJion()
        {
            String sql = "SELECT student2.name, tblEmployee2.id FROM student2 FULL OUTER JOIN tblEmployee2 on student2.name = tblEmployee2.name ORDER BY tblEmployee2.name";
            com = new SqlCommand(sql, con);
            SqlDataReader sdr = com.ExecuteReader();
            for (int i = 0; i < sdr.FieldCount; i++)
            {
                Console.Write(sdr.GetName(i) + "\t" + "\t");
            }
            Console.WriteLine();
            Console.WriteLine("=================================");
            while (sdr.Read())
            {
                for (int i = 0; i < sdr.FieldCount; i++)
                {
                    Console.Write(sdr[sdr.GetName(i)] + "\t" + "\t");
                }
                Console.WriteLine();
            }
        }
        static void Main(string[] args)
        {
            connection();
            //LeftJion();
            //RightJion();
            FullJion();

            Console.ReadLine();
        }
    }
}


