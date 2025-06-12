using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Unicom_TIC_Management_System__UMS_.Models
{
    public class Course
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
/*private void btnDelete_Click(object sender, EventArgs e)
{
    if (selectedCourseId == -1)
    {
        MessageBox.Show("Please Select The Course!.");
        return;
    }

    string query = "DELETE FROM Courses WHERE CourseID = @Id";
    using (SQLiteCommand cmd = new SQLiteCommand(query, conn))
    {
        cmd.Parameters.AddWithValue("@Id", selectedCourseId);
        cmd.ExecuteNonQuery();
    }

    MessageBox.Show("Course Deleted Successfully!");
    txtCourseName.Clear();
    selectedCourseId = -1;
    LoadCourses();
}*/