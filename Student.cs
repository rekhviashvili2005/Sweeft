using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweeft.Models
{
    // 777 დავალებაა და რაღაცა არ გამ
    public class Student // internal iyo da gavxade public
    { 
        public int StudentID { get; set; }
        public string FirstName { get; set; } = null!;
        public string LastName { get; set; } = null!;

        public ICollection<Teacher> Teachers { get; set; } = new List<Teacher>();
    }
}
