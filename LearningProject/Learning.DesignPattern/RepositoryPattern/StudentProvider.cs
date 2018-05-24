using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Learning.Common.Models;

namespace Learning.DesignPattern.RepositoryPattern
{
    public class StudentProvider
    {
        private readonly IStudentRepository _studentRep;

        public StudentProvider(IStudentRepository studentRep)
        {
            _studentRep = studentRep;
        }

        public void InsertStudent()
        {
            using (_studentRep)
            {
                var student = new Students{Name = "Judy Zhang"};
                _studentRep.InsertStudent(student);
                _studentRep.Save();
            }
        }
    }
}
