using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;


namespace DAL
{
    [Serializable()]
   public class Student : ISerializable
    {
        public string firstname { get; set; }
        public string lastname { get; set; }
        public string yearofstudy { get; set; }
        public string studentId { get; set; }
        public string dateofbirth { get; set; }

        public Student() { }

        public Student(string fname = "blank", string lname="blank", string yrofstudy="blank", 
            string studId="blank", string DOB="blank")
            
        { firstname = fname;
            lastname = lname;
            yearofstudy = yrofstudy;
            studentId = studId;
            dateofbirth = DOB;
        }

        public override string ToString()
        {
            return string.Format("{0} {1} is in their {2} and their id is {3} they were born in {4}",
                firstname, lastname, yearofstudy, studentId, dateofbirth);
        }

        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            info.AddValue("first name", firstname);
            info.AddValue("last name", lastname);
            info.AddValue("study year", yearofstudy);
            info.AddValue("student ID", studentId);
            info.AddValue("date of birth", dateofbirth);

        }
        public Student(SerializationInfo info, StreamingContext context)
        {
            firstname = (string)info.GetValue("first name", typeof(string));
            lastname = (string)info.GetValue("last name", typeof(string));
            yearofstudy = (string)info.GetValue("study year", typeof(string));
            studentId = (string)info.GetValue("student ID", typeof(string));
            dateofbirth = (string)info.GetValue("date of birth", typeof(string));
        }
    }
}
