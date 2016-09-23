using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMCSLib
{
    public class Person : IPrint
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
        public string PhoneNumber { get; set; }
        public string Address { get; set; }
        public string EmailID { get; set; }
        public int SSN { get; set; }
        public DateTime Date { get; set; }
        public string ReferredBy { get; set; }

        public void addPerson(int id,
                               string Name,
                               string Gender,
                               string PhoneNumber,
                               string Address,
                               string EmailID,
                               int SSN,
                               DateTime date,
                               string referredBy)
        {
            // string msg = id + Name + Gender + PhoneNumber + Address + EmailID + SSN + date + referredBy;

            StringBuilder msg = new StringBuilder("id:" + id);
            msg.AppendLine("Name: " + Name);
            msg.AppendLine("Gender: " + Gender);
            msg.AppendLine("PhoneNumber: " + PhoneNumber);
            msg.AppendLine("Address: " + Address);
            msg.AppendLine("EmailID: " + EmailID);
            msg.AppendLine("SSN: " + SSN);
            msg.AppendLine("Date :" + date);
            msg.AppendLine("ReferredBy: " + referredBy);
            IPrintRecord(msg);
        }


        public new  void IPrintRecord(StringBuilder msg)
        {
            Console.WriteLine("The person details are: \n" + msg);
        }
    }
}
