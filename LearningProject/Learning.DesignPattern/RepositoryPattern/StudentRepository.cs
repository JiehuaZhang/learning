using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Learning.Common.Models;

namespace Learning.DesignPattern.RepositoryPattern
{
    public class StudentRepository :IStudentRepository
    {
        private bool disposed;

        private readonly LearningEntities context;

        public StudentRepository(LearningEntities context)
        {
            this.context = context;
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!disposed)
            {
                if (disposing)
                {
                    context.Dispose();
                }
            }
            disposed = true;
        }
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        public IEnumerable<Students> GetStudents()
        {
            return context.Students.ToList();
        }

        public Students GetStudentByID(int studentID)
        {
            return context.Students.Find(studentID);
        }

        public void InsertStudent(Students student)
        {
            context.Students.Add(student);
        }

        public void DeleteStudent(int studentID)
        {
            var student = context.Students.Find(studentID);
            if (student != null) context.Students.Remove(student);
        }

        public void UpdateStudent(Students student)
        {
           context.Entry(student).State = EntityState.Modified;
        }

        public void Save()
        {
            context.SaveChanges();
        }
    }
}
