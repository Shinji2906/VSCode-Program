using QLySV_T36S4.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLySV_T36S4.BLL.Services
{
    public class StudentService
    {
        private QLSV_Entities dbContext;
        public StudentService()
        {
            dbContext = new QLSV_Entities();
        }

        public List<Student> GetAllStudents()
        {
            return dbContext.Student.Include("Faculty").ToList();
        }

        public Student GetStudentById(string id)
        {
            return dbContext.Student.Include("Falcuty")
                .FirstOrDefault(sv => sv.StudentID == id);
        }

        public void AddStudent(Student student)
        {
            dbContext.Student.Add(student);
            dbContext.SaveChanges();
        }

        public void UpdateStudent(Student student)
        {
            var existingStudent = dbContext.Student.Find(student.StudentID);
            if (existingStudent != null) 
            { 
                existingStudent.StudentName = student.StudentName;
                existingStudent.AverageScore = student.AverageScore;
                existingStudent.Faculty =  student.Faculty;
                dbContext.SaveChanges();
            }
        }

        public void DeleteStudent(string id) 
        {
            var student = dbContext.Student.Find(id);
            if (student != null)
            { 
                dbContext.Student.Remove(student);
                dbContext.SaveChanges();
            }
        }

        public void DeteleStudent (Student student)
        {
            DeleteStudent(student.StudentID);
        }
    }
}
