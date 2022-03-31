using System.Collections.Generic;
using WebApplication1.Models;

namespace WebApplication1.DAL
{
    public class MockDbService : IDbservice
    {
        private static IEnumerable<Student> _students;

        static MockDbService()
        {
            _students = new List<Student>()
            {
                new Student{Id = 1, FirstName = "Frank", LastName = "Baron"},
                new Student { Id = 2, FirstName = "Jan", LastName = "Dzban" },
                new Student {Id = 3, FirstName = "Kasia", LastName ="Katarzyna"}
        };
           


            }







        public IEnumerable<Student> GetStudents()
        {
            throw new System.NotImplementedException();
        }

        
    }
}
