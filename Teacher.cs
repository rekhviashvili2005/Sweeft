using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweeft.Models
{
    // 777 დავალებაა და რაღაცა არ გამ
    public class Teacher // internal iyo da public gavxade
    {
        public int TeacherID { get; set; }
        public string FirstName { get; set; } = null!;
        public string LastName { get; set; } = null!;
        public string Subject { get; set; } = null!;

        public ICollection<Student> Students { get; set; } = new List<Student>();

    }
}
