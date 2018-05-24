using System;
using System.Collections.Generic;
using Learning.Common.Models;

namespace Learning.DesignPattern.RepositoryPattern
{
    public interface IStudentRepository: IDisposable
    {
        IEnumerable<Students> GetStudents();
        Students GetStudentByID(int studentID);
        void InsertStudent(Students student);
        void DeleteStudent(int studentID);
        void UpdateStudent(Students student);
        void Save();
    }
}
