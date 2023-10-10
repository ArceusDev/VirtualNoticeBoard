using System.ComponentModel.DataAnnotations.Schema;

namespace VirtualNoticeBoard.Models
{
    public class Class
    {
        [Column("class_name")] public string ClassName { get; set; }
        [Column("department_id")] public Department DepartmentID { get; set; }
    }
}
