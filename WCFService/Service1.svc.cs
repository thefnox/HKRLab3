using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WCFService
{

    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1
    {
        public int CoursesCompleted(int studentId)
        {
            var entities = new KnowledgeBridgeEntities1();
            var list = from student in entities.gradeInfoes where student.studentId == studentId select student;
            return list.Count();
        }

        public bool DeleteStudent(int studentId, string courseNumber)
        {
            var entities = new KnowledgeBridgeEntities1();
            var list = from student in entities.gradeInfoes where student.studentId == studentId && student.courseNumber == courseNumber select student;
            if (list.Count() > 0)
            {
                entities.gradeInfoes.Remove(list.SingleOrDefault());
                entities.SaveChanges();
                return true;
            }
            return false;
        }

        public void SaveStudent(int studentId, string courseNumber, string courseTitle, float hp, string coursePeriod, string studentName, string email, int grade)
        {
            var entities = new KnowledgeBridgeEntities1();
            gradeInfo entity = new gradeInfo();
            entity.studentId = studentId;
            entity.courseNumber = courseNumber;
            entity.courseTitle = courseTitle;
            entity.hp = hp;
            entity.coursePeriod = coursePeriod;
            entity.studentName = studentName;
            entity.email = email;
            entity.grade = grade;
            entities.gradeInfoes.Add(entity);
            entities.SaveChanges();
        }

        public bool UpdateStudent(int studentId, string courseNumber, string email, int grade)
        {
            var entities = new KnowledgeBridgeEntities1();
            var list = from student in entities.gradeInfoes where student.studentId == studentId && student.courseNumber == courseNumber select student;
            var course = list.SingleOrDefault();
            if (course != null)
            {
                course.email = email;
                course.grade = grade;
                entities.SaveChanges();
                return true;
            }
            return false;
        }
    }
}
