using Dapper;
using System.Data;
using VirtualNoticeBoard.Contracts;
using VirtualNoticeBoard.Models;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace VirtualNoticeBoard.Repository
{
    public class VNBRepository : IVNB
    {
        private readonly DapperContext _context;
        public VNBRepository(DapperContext context)
        {
            _context = context; 
        }

        public async Task<IEnumerable<Teacher>> GetTeachers()
        {
            string query = "SELECT * FROM Teacher";
            using (IDbConnection connection = _context.CreateConnection())
            {
                var teachers = await connection.QueryAsync<Teacher>(query);
                return teachers.ToList();
            }
        }
    }
}
