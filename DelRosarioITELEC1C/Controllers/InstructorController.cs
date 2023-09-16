using DelRosarioITELEC1C.Models;
using Microsoft.AspNetCore.Mvc;

namespace DelRosarioITELEC1C.Controllers
{
    public class InstructorController : Controller
    {
        List<Instructor> InstructorList = new List<Instructor>
            {
                new Instructor()
                {
                    Id= 1,FirstName = "Gabriel",LastName = "Montano", Rank = Rank.Instructor, IsTenured = true, HiringDate = DateTime.Parse("2022-08-26")
                },
                new Instructor()
                {
                    Id= 2,FirstName = "Cillian",LastName = "Murphy", Rank = Rank.AssistantProfessor, IsTenured = true, HiringDate = DateTime.Parse("2022-08-07")
                },
                new Instructor()
                {
                    Id= 3,FirstName = "Jackson", LastName = "Rippner", Rank = Rank.Professor, IsTenured= false, HiringDate = DateTime.Parse("2023-09-12")
                }
            };
        public IActionResult Index()
        {
            return View(InstructorList);
        }
        public IActionResult Instructor()
        {

            return View(InstructorList);
        }



        public IActionResult ShowDetail(int id)
        {
            //Search for the student whose id matches the given id
            Instructor? instructor = InstructorList.FirstOrDefault(st => st.Id == id);

            if (instructor != null)//was an student found?
                return View(instructor);

            return NotFound();
        }

    }
}

