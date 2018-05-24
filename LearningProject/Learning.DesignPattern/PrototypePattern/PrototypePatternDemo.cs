using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning.DesignPattern.PrototypePattern
{
    public class PrototypePatternDemo
    {
        public void TryPrototypePattern()
        {
            var dev = new Developer
            {
                Name = "Rahul",
                Role = "Team Leader",
                PreferredLanguage = "C#"
            };

            var devCopy = (Developer) dev.Clone();
            devCopy.Name = "Arif";//Not mention Role and PreferredLanguage, it will copy above

            Console.WriteLine(dev.GetDetails());
            Console.WriteLine(devCopy.GetDetails());

            var typist = new Typist
            {
                Name  = "Monu",
                Role = "Typist",
                WordsPerMinute = 120
            };

            var typistCopy = (Typist) typist.Clone();
            typistCopy.Name = "Sahil";
            typistCopy.WordsPerMinute = 115;//Not mention Role, it will copy above

            Console.WriteLine(typist.GetDetails());
            Console.WriteLine(typistCopy.GetDetails());



        }
    }
}
