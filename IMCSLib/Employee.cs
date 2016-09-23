using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMCSLib
{
    public class Employee : Person, IPrint
    {
        public int EmpID { get; set; }
        public string Designation { get; set; }
        public int PayScale { get; set; }

        public void addEmployee(int id,
                                int EmpID,
                                string Name,
                                string Gender,
                                string PhoneNumber,
                                string Address,
                                string EmailID,
                                int SSN,
                                DateTime date,
                                string referredby,
                                string Designation,
                                int PayScale)
        {
            StringBuilder msg1 = new StringBuilder("Person Id: " + id);
            msg1.AppendLine("EmpID: " + EmpID);
            msg1.AppendLine("Name: " + Name);
            msg1.AppendLine("Gender: " + Gender);
            msg1.AppendLine("PhoneNumber: " + PhoneNumber);
            msg1.AppendLine("Address: " + Address);
            msg1.AppendLine("EmailID: " + EmailID);
            msg1.AppendLine("SSN: " + SSN);
            msg1.AppendLine("Date: " + date);
            msg1.AppendLine("ReferredBy: " + referredby);
            msg1.AppendLine("Designation: " + Designation);
            msg1.AppendLine("Payscale ($/hr):" + PayScale);

            IPrintRecord(msg1);

        }
       public new void IPrintRecord(StringBuilder msg1)
        {
            Console.WriteLine("The Employee details entered are : \n" + msg1);
        }
    }
    }
