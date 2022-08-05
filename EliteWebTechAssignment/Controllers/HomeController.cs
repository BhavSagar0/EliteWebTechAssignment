using EliteWebTechAssignment.BusinessServices.ViewModels;
using EliteWebTechAssignment.Domain.Interfaces;
using EliteWebTechAssignment.Domain.Models;
using EliteWebTechAssignment.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace EliteWebTechAssignment.Controllers
{
    public class HomeController : Controller
    {
        private readonly IStudentBusinessService _studentBusinessService;

        public HomeController(IStudentBusinessService studentBusinessService)
        {
            _studentBusinessService = studentBusinessService;
        }
        public IActionResult Index(string searchString = "")
        {
            IEnumerable<StudentEntityModel> students = Enumerable.Empty<StudentEntityModel>();
            try
            {
                students = _studentBusinessService.GetAllStudents(searchString);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return View(students);
        }

        [HttpGet]
        public IActionResult CreateStudent(bool isSuccess = false)
        {
            CreateStudentViewModel createStudentViewModel = new CreateStudentViewModel();
            try
            {
                createStudentViewModel.programmeList = _studentBusinessService.GetAllProgrammes();
                createStudentViewModel.isSuccess = isSuccess;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return View(createStudentViewModel);
        }

        [HttpPost]
        public IActionResult CreateStudent(CreateStudentViewModel createStudentViewModel)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    if (_studentBusinessService.CreateStudent(createStudentViewModel.student))
                    {
                        createStudentViewModel.isSuccess = true;
                        return RedirectToAction(nameof(CreateStudent), new { isSuccess = createStudentViewModel.isSuccess });
                    }
                }
                else
                {
                    createStudentViewModel.programmeList = _studentBusinessService.GetAllProgrammes();
                }
            }
            catch(Exception ex) 
            {
                Console.WriteLine(ex.Message);
            }
            return View(createStudentViewModel);
        }

        [HttpGet]
        public IActionResult CreateProgramme(bool isSuccess = false)
        {
            CreateProgrammeViewModel createProgrammeViewModel = new CreateProgrammeViewModel();
            try
            {
                createProgrammeViewModel.isSuccess = isSuccess;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return View(createProgrammeViewModel);
        }

        [HttpPost]
        public IActionResult CreateProgramme(CreateProgrammeViewModel createProgrammeViewModel)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    IEnumerable<string> subjectsList = new List<string>()
                    {
                        createProgrammeViewModel.subject1,
                        createProgrammeViewModel.subject2,
                        createProgrammeViewModel.subject3
                    };

                    if (_studentBusinessService.CreateProgramme(createProgrammeViewModel.programme, subjectsList))
                    {
                        createProgrammeViewModel.isSuccess = true;
                        return RedirectToAction(nameof(CreateProgramme), new { isSuccess = createProgrammeViewModel.isSuccess });
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return View(createProgrammeViewModel);
        }

        [HttpGet]
        public IActionResult AddStudentIntakeYear(bool isSuccess = false)
        {
            AddStudentIntakeYearViewModel addStudentIntakeYearViewModel = new AddStudentIntakeYearViewModel();
            try
            {
                addStudentIntakeYearViewModel.students = _studentBusinessService.GetAllStudents();
                addStudentIntakeYearViewModel.isSuccess = isSuccess;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return View(addStudentIntakeYearViewModel);
        }

        [HttpPost]
        public IActionResult AddStudentIntakeYear(AddStudentIntakeYearViewModel addStudentIntakeYearViewModel)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    if (_studentBusinessService.AddStudentIntakeYear(addStudentIntakeYearViewModel.studentId, addStudentIntakeYearViewModel.intakeYear))
                        return RedirectToAction(nameof(AddStudentIntakeYear), new { isSuccess = true });
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return View(addStudentIntakeYearViewModel);
        }

        [HttpGet]
        public IActionResult UpdateStudent(bool isSuccess = false)
        {
            UpdateStudentViewModel updateStudentViewModel = new UpdateStudentViewModel();
            try
            {
                updateStudentViewModel.studentsList = _studentBusinessService.GetAllStudents();
                updateStudentViewModel.programmesList = _studentBusinessService.GetAllProgrammes();
                updateStudentViewModel.isSuccess = isSuccess;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return View(updateStudentViewModel);
        }
        [HttpPost]
        public IActionResult UpdateStudent(UpdateStudentViewModel updateStudentViewModel)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    if (_studentBusinessService.UpdateStudent(updateStudentViewModel.studentId, updateStudentViewModel.intakeYear, updateStudentViewModel.currentSem, updateStudentViewModel.programmeId))
                        return RedirectToAction(nameof(UpdateStudent), new { isSuccess = true });
                }
                else
                {
                    updateStudentViewModel.studentsList = _studentBusinessService.GetAllStudents();
                    updateStudentViewModel.programmesList = _studentBusinessService.GetAllProgrammes();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return View(updateStudentViewModel);
        }

        [HttpGet]
        public IActionResult AddStudentMarks(int studentId, bool isSuccess = false)
        {
            AddStudentMarksViewModel addStudentMarksViewModel = new AddStudentMarksViewModel();
            try
            {
                addStudentMarksViewModel.studentId = studentId;
                addStudentMarksViewModel.studentName = _studentBusinessService.GetStudentbyId(studentId).studentName;
                addStudentMarksViewModel.subjectsList = _studentBusinessService.GetStudentProgrammeSubjects(studentId);
                addStudentMarksViewModel.isSuccess = isSuccess;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return View(addStudentMarksViewModel);
        }
        [HttpPost]
        public IActionResult AddStudentMarks(AddStudentMarksViewModel addStudentMarksViewModel)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    IEnumerable<int> marksList = new List<int> 
                    {
                        addStudentMarksViewModel.subject1,
                        addStudentMarksViewModel.subject2,
                        addStudentMarksViewModel.subject3
                    };
                    

                    if (_studentBusinessService.AddStudentMarks(addStudentMarksViewModel.studentId, marksList))
                        return RedirectToAction(nameof(AddStudentMarks), new { studentId = addStudentMarksViewModel.studentId, isSuccess = true });
                }
                else
                {
                    addStudentMarksViewModel.subjectsList = _studentBusinessService.GetStudentProgrammeSubjects(addStudentMarksViewModel.studentId);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return View(addStudentMarksViewModel);
        }

        [HttpGet]
        public IActionResult DisplayStudentMarks(int studentId)
        {
            DisplayStudentMarksViewModel displayStudentMarksViewModel = new DisplayStudentMarksViewModel();
            try
            {
                displayStudentMarksViewModel.student = _studentBusinessService.GetStudentbyId(studentId);
                displayStudentMarksViewModel.subjectsList = _studentBusinessService.GetStudentProgrammeSubjects(studentId).ToList();
                displayStudentMarksViewModel.marksList = _studentBusinessService.GetStudentMarks(studentId);
                displayStudentMarksViewModel.intakeYear = _studentBusinessService.GetStudentIntakeYear(studentId);
                displayStudentMarksViewModel.currentSem = _studentBusinessService.GetStudentCurrentSem(studentId);
                displayStudentMarksViewModel.programme = _studentBusinessService.GetStudentProgramme(studentId);
            }
            catch { }
            return View(displayStudentMarksViewModel);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
