using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unicom_TIC_Management_System__UMS_.Models
{
    public class Attendance
    {
        public int AttendanceID { get; set; }
        public int StudentID { get; set; }
        public int SubjectID { get; set; }
        public DateTime Date { get; set; }  
        public string Status { get; set; }

    }
}
