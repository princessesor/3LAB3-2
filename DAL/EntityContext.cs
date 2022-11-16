using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class EntityContext
    {
        private string conn = ConfigurationManager.ConnectionStrings["3LAB32"].ToString();

        public void InsertUpdateDeleteSQLString(string sqlstring)
        {
            SqlConnection objsqlconn = new SqlConnection(conn);
            objsqlconn.Open();
            SqlCommand objcmd = new SqlCommand(sqlstring, objsqlconn);
            objcmd.ExecuteNonQuery();

        }

        public object ExecuteSqlString(string sqlstring)
        {
            SqlConnection objsqlconn = new SqlConnection(conn);
            objsqlconn.Open();
            DataSet ds = new DataSet();
            SqlCommand objcmd = new SqlCommand(sqlstring, objsqlconn);
            SqlDataAdapter objAdp = new SqlDataAdapter(objcmd);
            objAdp.Fill(ds);
            return ds;
        }

        public void AddNewStudentDL(string studfirstname, string studlastname, string studyrofstud, string studId, string dateofbirth)
        {
            DataSet ds = new DataSet();
            string sql = "INSERT into Customer (student_fname,student_lname,student_studyyr,student_id,student_dob) VALUES ('" + studfirstname + "','" + studlastname + "','" + studyrofstud + "','" + studId + "','" + dateofbirth + "')";
            InsertUpdateDeleteSQLString(sql);
        }

        public void UpdateStudentDL(string studfirstname, string studlastname, string studyyrofstud, string studId, string dateofbirth, string studid)
        {
            DataSet ds = new DataSet();
            string sql = "Update student set student_fname='" + studfirstname + "',student_lname = '" + studlastname + "',student_studyyr = '" + studyyrofstud + "',student_id = '" + studId + "',student_dob = '" + dateofbirth + "' Where student_id = '"  + "' ";
            InsertUpdateDeleteSQLString(sql);
        }

        public void DeleteStudentDL(string studentId)
        {
            DataSet ds = new DataSet();
            string sql = "Delete From student Where student_id = '" + studentId + "' ";
            InsertUpdateDeleteSQLString(sql);
        }


        public object LoadStudentDL()
        {
            DataSet ds = new DataSet();
            string sql = "SELECT * from Student order by student_id";
            ds = (DataSet)ExecuteSqlString(sql);
            return ds;
        }



    }
}
