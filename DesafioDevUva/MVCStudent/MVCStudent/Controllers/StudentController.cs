using Microsoft.AspNetCore.Mvc;
using MVCStudent.Models;
using System.Diagnostics;
using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;

namespace MVCStudent.Controllers
{
    [Route("[controller]")]
    public class StudentController : Controller
    {
        private readonly string apiUrl = "https://localhost:7156/api/StudentAPI/";

        public async Task<IActionResult> Index()
        {
            List<StudentModel> listStudent = new List<StudentModel>();

            using (var httpClient = new HttpClient())
            {
                using (var response = await httpClient.GetAsync(apiUrl))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    listStudent = JsonConvert.DeserializeObject<List<StudentModel>>(apiResponse);
                }
            }
            return View(listStudent);
       
        }
        [HttpPost]
        public async Task<IActionResult> GetStudentById(int id)
        {
            StudentModel studentById= new StudentModel();

            using (var httpClient = new HttpClient())
            {
                using (var response = await httpClient.GetAsync(apiUrl + "/" + id))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    studentById = JsonConvert.DeserializeObject<StudentModel>(apiResponse);
                }
            }
            return View(studentById);
        }
    }
}