using System.ComponentModel.DataAnnotations.Schema;

namespace VirtualNoticeBoard.Models
{
    public class Department
    {
        public int department_id { get; set; }
        public string ?department_name { get; set; }
    }
}
