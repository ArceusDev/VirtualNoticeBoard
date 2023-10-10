using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using VirtualNoticeBoard.Contracts;
using VirtualNoticeBoard.Models;

namespace VirtualNoticeBoard.Controllers
{
    [Route("api/teachers")]
    [ApiController]
    public class TeacherController : Controller
    {
        private readonly IVNB _vnbRepo;
        public TeacherController(IVNB vnbRepo)
        {
            _vnbRepo = vnbRepo;
        }
        [HttpGet]
        public async Task<IActionResult> GetTeachers()
        {
            try
            {
                IEnumerable<Teacher> teachers = await _vnbRepo.GetTeachers();
                return Ok(teachers);
            }
            catch (Exception ex)
            {
                //log error
                return StatusCode(500, ex.Message);
            }
        }
    }
}
