using QLySV_T36S4.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLySV_T36S4.BLL.Services
{
    public class FacultyService
    {
        //khai bao csdl
        private static QLSV_Entities dbContext;
        public FacultyService()
        {
            //ket noi toi csdl
            dbContext = new QLSV_Entities();
        }
        //doc du lieu
        public List<Faculty> GetAllFaculties()
        {
            return dbContext.Faculty.ToList();
        }

        public Faculty GetFaculty(int id)
        {
            return dbContext.Faculty.Find(id);
        }
        //tao moi du lieu
        public void Create_Faculty(Faculty faculty)
        {
            dbContext.Faculty.Add(faculty);
            dbContext.SaveChanges();
        }
        //thay doi du lieu
        public void Update_Faculty(Faculty faculty)
        {
           Faculty existing_Faculty =
                dbContext.Faculty.Find(faculty.FacultyID);
            if (existing_Faculty != null)
            {
                existing_Faculty.FacultyName = faculty.FacultyName;
                existing_Faculty.count_professor = faculty.count_professor;
                dbContext.Entry(faculty).State = 
                    System.Data.Entity.EntityState.Modified;
                dbContext.SaveChanges();
            }
        }
        //xoa
        public void Detele_Faculty (int id)
        {
             Faculty existing_Faculty = dbContext.Faculty.Find(id);
            if (existing_Faculty != null)
            {
                dbContext.Faculty.Remove(existing_Faculty);
                dbContext.SaveChanges();
            }
        }
    }
}
