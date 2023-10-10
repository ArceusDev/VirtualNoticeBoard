using System.ComponentModel.DataAnnotations.Schema;

namespace VirtualNoticeBoard.Models
{
    public class Student
    {
        [Column("roll_number")] public string RollNumber { get; set; }
        [Column("class_name")] public Class ClassName { get; set; }
    }
}
