using Learning.Common.Models;
using Learning.DesignPattern.RepositoryPattern;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Learning.DesignPattern.Test.DesignPattern
{
    [TestClass]
    public class StudentProviderTest
    {
        private readonly StudentProvider student = new StudentProvider(new StudentRepository(new LearningEntities()));
        
        [TestMethod]
        public void InsertStudentTest()
        {
            student.InsertStudent();
           
        }

    }
}
