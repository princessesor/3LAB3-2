using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BLL
{
    public class EntityService
    {
        public EntityContext objData = new EntityContext();

        public EntityContext objDataLayer = new EntityContext();

        public void AddNewStudent(string studfirstname, string studlastname, string studyyrofstud, string studId, string dateofbirth)
        {
            objDataLayer.AddNewStudentDL(studfirstname, studlastname, studyyrofstud, studId, dateofbirth);
        }

        public void UpdateStudent(string studfirstname, string studlastname, string studyyrofstud, string studentId, string dateofbirth, string studentid)
        {
            objDataLayer.UpdateStudentDL(studfirstname, studlastname, studyyrofstud, studentId, dateofbirth, studentid);
        }

        public void DeleteStudent(string studentId)
        {
            objDataLayer.DeleteStudentDL(studentId);
        }

        public object LoadStudent()
        {
            return objDataLayer.LoadStudentDL();
        }

    }
}
