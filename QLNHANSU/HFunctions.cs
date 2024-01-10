using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using DataLayer;
namespace QLNHANSU
{
    public class HFunctions
    {
        public static int demSoNgayLamViecTrongThang(int thang,int nam)
        {
            DateTime startDate = new DateTime(nam, thang, 1);
            int totalDays = startDate.AddMonths(1).Subtract(startDate).Days;
            int songaychunhat = Enumerable.Range(1, totalDays)
                .Select(item => new DateTime(nam, thang, item))
                .Where(date => date.DayOfWeek == DayOfWeek.Sunday)
                .Count();
            int result = DateTime.DaysInMonth(nam, thang) - songaychunhat;
            return result;
        }
        public static int laySoNgayCuaThang(int thang, int nam)
        {
            return DateTime.DaysInMonth(nam, thang);
        }
        public static string layThuTrongTuan(int nam, int thang, int ngay)
        {
            string thu = "";
            DateTime newDate = new DateTime(nam, thang, ngay);
            switch (newDate.DayOfWeek.ToString())
            {
                case "Monday":
                    thu = "Thứ hai";
                    break;
                case "Tuesday":
                    thu = "Thứ ba";
                    break;
                case "Wednesday":
                    thu = "Thứ tư";
                    break;
                case "Thursday":
                    thu = "Thứ năm";
                    break;
                case "Friday":
                    thu = "Thứ sáu";
                    break;
                case "Saturday":
                    thu = "Thứ bảy";
                    break;
                case "Sunday":
                    thu = "Chủ nhật";
                    break;
            }
            return thu;
        }
        static SqlConnection con = new SqlConnection();
        public static void taoKetNoi()
        {
            con.ConnectionString = @"Data Source = LAPTOP-R4KU6F8T\MSSQLSERVER2;Initial catalog=QLNHANSU;integrated security=True;MultipleActiveResultSets=True;App=EntityFramework;User ID= sa;Password=123456;";
            
            try
            {
                con.Open();

            }
            catch (Exception)
            {
                throw;
            }
        }
        public static void dongketnoi()
        {
            con.Close();
        }
        public static DataTable getData(string query)
        {
            taoKetNoi();
            DataTable tb = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(query, con);
            da.Fill(tb);
            dongketnoi();
            return tb;
        }
        public static DataSet getDataSet(string query)
        {
            taoKetNoi();
            SqlDataAdapter da = new SqlDataAdapter(query, con);
            SqlCommandBuilder commandBuilder = new SqlCommandBuilder(da);
            DataSet ds = new DataSet();
            da.Fill(ds);
            return ds;
        }
        //public static void execQuery(string qr)
        //{
        //    taoKetNoi();
        //    SqlCommand cmd = new SqlCommand(qr, con);
        //    cmd.CommandType = CommandType.Text;
        //    cmd.ExecuteNonQuery();
        //    dongketnoi();
        //}
        public static void execQuery(string qr, SqlParameter[] parameters)
        {
            taoKetNoi();

            SqlCommand cmd = new SqlCommand(qr, con);
            cmd.CommandType = CommandType.Text;

            // Thêm tham số vào câu truy vấn
            if (parameters != null)
            {
                cmd.Parameters.AddRange(parameters);
            }

            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                Console.WriteLine($"SQL Error: {ex.Message}");
                // Xử lý ngoại lệ hoặc ném lại nếu cần
                throw;
            }
            finally
            {
                dongketnoi();
            }
        }
    }
}
