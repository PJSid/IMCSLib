using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMCSLib
{
    public class Student : Person, IPrint
    {
        public int StudentID { get; set; }
        public string College { get; set; }
        public int Payrate { get; set; }



        public void addStudent(int id,
                                int StudentID,
                                string Name,
                                string Gender,
                                string PhoneNumber,
                                string Address,
                                string EmailID,
                                int SSN,
                                DateTime date,
                                string referredby,
                                string college,
                                int payrate)
        {
            StringBuilder msg2 = new StringBuilder("id: " + id);
            msg2.AppendLine("StudentID: " + StudentID);
            msg2.AppendLine("Name: " + Name);
            msg2.AppendLine("Gender: " + Gender);
            msg2.AppendLine("PhoneNumber: " + PhoneNumber);
            msg2.AppendLine("Address: " + Address);
            msg2.AppendLine("EmailID: " + EmailID);
            msg2.AppendLine("SSN: " + SSN);
            msg2.AppendLine("Date: " + date);
            msg2.AppendLine("ReferedBy: " + referredby);
            msg2.AppendLine("College: " + college);
            msg2.AppendLine("Payrate ($/hr): " + payrate);

            IPrintRecord(msg2);
        }

        public new void IPrintRecord(StringBuilder msg2)
        {
            Console.WriteLine("The student details entered are : \n" + msg2);
        }
    }

}
