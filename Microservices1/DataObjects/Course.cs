using System.Linq;
using System.Collections.Generic;
using System.Data;
using System.Threading.Tasks;

namespace Microservices1.DataObjects
{
    public class Course:IElement
    {
        oCourse _data;

        public Course(oCourse data)
        {
            _data = data;
        }

        public Course()
        {
        }

        public string Save()
        {
            return new DataAccess().ExecuteNonQuery("INSERT INTO dbo.Course (CourseID, Title, Credits, DepartmentID) VALUES(" + 
                _data.CourseID + ", '" + 
                _data.Title + "', " + 
                _data.Credits + ", " + 
                _data.DepartmentID + "); ");
        }

        public List<oCourse> GetCourses()
        {
            DataAccess data = new DataAccess();
             return data.ExecuteReader("select * from Course").AsEnumerable().Select(e => new oCourse { 
                 CourseID = int.Parse(e[0].ToString()), 
                 Title = e[1].ToString(), 
                 Credits = int.Parse(e[2].ToString()), 
                 DepartmentID = int.Parse(e[3].ToString()) }
             ).ToList(); ;
        }

        public List<oCourse> GetCourseByID(int id)
        {
            return GetCourses().Where(e => e.CourseID == id).ToList();
        }

        public string Save(oCourse data)
        {
            _data = data;
            return Save();
        }
    }
}
