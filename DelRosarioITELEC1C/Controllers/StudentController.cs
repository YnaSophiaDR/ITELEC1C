using Microsoft.AspNetCore.Mvc;
using DelRosarioITELEC1C.Models;


namespace DelRosarioITELEC1C.Controllers
{
    public class StudentController : Controller
    {
        List<Student> StudentList = new List<Student>
            {
                new Student()
                {
                    Id= 1,FirstName = "Yna Sophia",LastName = "Del Rosario", Course = Course.BSIT, AdmissionDate = DateTime.Parse("2022-08-26"), GPA = 1.0, Email = "yna@gmail.com"
                },
                new Student()
                {
                    Id= 2,FirstName = "Thomas",LastName = "Shelby", Course = Course.BSIS, AdmissionDate = DateTime.Parse("2022-08-07"), GPA = 1.75, Email = "tommyshelby@gmail.com"
                },
                new Student()
                {
                    Id= 3,FirstName = "Robert",LastName = "Oppenheimer", Course = Course.BSCS, AdmissionDate = DateTime.Parse("2020-01-25"), GPA = 1.25, Email = "kaboom@gmail.com"
                }
            };
        public IActionResult Index()
        {
            
            return View(StudentList);
        }
        public IActionResult Student()
        {

            return View(StudentList);
        }



        public IActionResult ShowDetail(int id)
        {
            //Search for the student whose id matches the given id
            Student? student = StudentList.FirstOrDefault(st => st.Id == id);
            
            if (student != null)//was an student found?
                return View(student);

            return NotFound();
        }

    }
}
