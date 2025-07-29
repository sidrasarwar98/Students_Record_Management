using System.Data;
using Microsoft.AspNetCore.Mvc;
using StudentCRUD.Models;
using System.Data.SqlClient;

namespace StudentCRUD.Controllers
{
    public class StudentsController : Controller
    {
        private readonly DataAccess _dbHelper;

        public StudentsController(DataAccess dbHelper)
        {
            _dbHelper = dbHelper;
        }
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public JsonResult GetStudents()
        {
            string query = "SELECT * FROM Students";
            DataTable dt = _dbHelper.GetDataTable(query);
            List<Student> students = new List<Student>();

            foreach (DataRow row in dt.Rows)
            {
                students.Add(new Student
                {
                    S_Id = Convert.ToInt32(row["S_Id"]),
                    S_Name = row["S_Name"].ToString(),
                    S_Age = Convert.ToInt32(row["S_age"])
                });
            }
            return Json(students);
        }
        [HttpPost]
        public JsonResult AddStudent([FromBody] Student student)
        {
            string query = "INSERT INTO Students (S_Name, S_age) VALUES (@Name, @Age)";
            var parameters = new SqlParameter[]
            {
                new SqlParameter("@Name", student.S_Name),
                new SqlParameter("@Age", student.S_Age)
            };
            int result = _dbHelper.ExecuteQuery(query, parameters);
            return Json(result > 0 ? new { success = true } : new { success = false });
        }



        [HttpPut]
        public JsonResult UpdateStudent([FromBody] Student student)
        {
            string query = "UPDATE Students SET S_Name = @Name, S_age = @Age WHERE S_Id = @Id";
            var parameters = new SqlParameter[]
            {
                new SqlParameter("@Name", student.S_Name),
                new SqlParameter("@Age", student.S_Age),
                new SqlParameter("@Id", student.S_Id)
            };
            int result = _dbHelper.ExecuteQuery(query, parameters);
            return Json(result > 0 ? new { success = true } : new { success = false });
        }



        [HttpDelete]
        public JsonResult DeleteStudent(int id)
        {
            string query = "DELETE FROM Students WHERE S_Id = @Id";
            var parameters = new SqlParameter[]
            {
                new SqlParameter("@Id", id)
            };
            int result = _dbHelper.ExecuteQuery(query, parameters);
            return Json(result > 0 ? new { success = true } : new { success = false });
        }
    }

}
