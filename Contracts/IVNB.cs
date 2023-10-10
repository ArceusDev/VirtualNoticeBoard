using VirtualNoticeBoard.Models;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace VirtualNoticeBoard.Contracts
{
    public interface IVNB
    {
        public Task<IEnumerable<Teacher>> GetTeachers();
    }
}
