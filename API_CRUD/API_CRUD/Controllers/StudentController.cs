using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using StudentDataAccess;

namespace API_CRUD.Controllers
{
    public class StudentController : ApiController
    {
        private STUDENTSEntities db = new STUDENTSEntities();

        //GET: api/students
        public IEnumerable<Student> Get()
        {
            return db.Students.ToList();
        }
        // GET: api/students/{Id}
        public Student Get(int Id)
        {
            Student student = db.Students.Find(Id);
            if (student != null)
                return student;
            else
                return null;
        }
        // POST: api/students
        public string Post(Student student)
        {
            db.Students.Add(student);
            db.SaveChanges();
            return "Student details Created Successfully";
        }
        // PUT: api/students/{id}
        public string Put(int Id, [FromBody] Student student)
        {
            try
            {
                var existingStudent = db.Students.Find(Id);
                if (existingStudent != null)
                {
                    existingStudent.Name = student.Name;
                    existingStudent.Course = student.Course;
                    existingStudent.Age = student.Age;
                    db.Entry(student).State = System.Data.Entity.EntityState.Modified;
                    db.SaveChanges();
                    return "Student Details updated successfully";
                }
                else
                {
                    return $"Student details with Id {Id} is not found";
                }
            }
            catch (Exception e)
            {
                return e.Message;

            }
        }

        // DELETE: api/students/{id}
        public string Delete(int Id)
        {
            try
            {
                Student student = db.Students.Find(Id);
                if (student != null)
                {
                    db.Students.Remove(student);
                    db.SaveChanges();
                    return "Student details deleted successfully";
                }
                else
                {
                    return "not deleted successfully";
                }
            }
            catch (Exception e)
            {

                return e.Message;
            }
        }
    }
}






   











