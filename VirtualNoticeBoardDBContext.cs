using Microsoft.EntityFrameworkCore;

namespace VirtualNoticeBoard
{
    public class VirtualNoticeBoardDBContext: DbContext
    {
        /*public DbSet<Student> Students { get; set; }
        public DbSet<Class> classes { get; set; }
        public DbSet<Teacher> teachers { get; set; }
        public DbSet<Department> departments { get; set; }
        public DbSet<Message> messages { get; set; }*/

        public VirtualNoticeBoardDBContext(DbContextOptions options) : base(options)
        {

        }
        
    }
}
