using System.ComponentModel.DataAnnotations.Schema;

namespace VirtualNoticeBoard.Models
{
    public class MessageTB
    {
        [Column("message_id")] public int Id { get; set; }
        [Column("message_text")] public string MessageText { get; set; }
        [Column("message_by")] public Teacher MessageBy { get; set; }
        [Column("message_for_department")] public Department ?MessageForDepartment { get; set; }
        [Column("message_for_class")] public Class ?MessageForClass { get; set; }
    }
}
