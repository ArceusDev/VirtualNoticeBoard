using System.ComponentModel.DataAnnotations.Schema;

namespace VirtualNoticeBoard.Models
{
    public class Teacher
    {
        public int teacher_id { get; set; }
        public string ?teacher_name { get; set; }
        public int ?department_id { get; set; }

    }
}
