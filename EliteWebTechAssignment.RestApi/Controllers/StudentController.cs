using AutoWrapper.Wrappers;
using EliteWebTechAssignment.Domain.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;
using System.Web.Http.ExceptionHandling;

namespace EliteWebTechAssignment.RestApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        private readonly IStudentBusinessService _studentBusinessService;
        private readonly IExceptionLogger _logger;

        public StudentController(IStudentBusinessService studentBusinessService, IExceptionLogger logger)
        {
            _studentBusinessService = studentBusinessService;
            _logger = logger;
        }

        //[HttpGet]
        //public async Task<ActionResult<ApiResponse>> GetAllStudentsAsync()
        //{
        //    try
        //    {
        //        var result = _studentBusinessService.GetAllStudents();
        //        return Ok(result);
        //    }
        //    catch (Exception ex)
        //    {
        //        _logger.LogAsync();
        //    }
            
        //}
    }
}
