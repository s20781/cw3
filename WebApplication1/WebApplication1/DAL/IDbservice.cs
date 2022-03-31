using WebApplication1.Models;
using System.Collections.Generic;

namespace WebApplication1.DAL
{
    public interface IDbservice
    {

        public IEnumerable<Student> GetStudents();
    }
}
