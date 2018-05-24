using System;

namespace Learning.DesignPattern.CommandPattern
{
    public class CommandPatternDemo
    {
        public void TryCommandPattern()
        {
            Console.WriteLine("Enter Command (ON/OFF) : ");
            var cmd = Console.ReadLine();

            var lamp = new Light();
            ICommand switchUp = new FlipUpCommand(lamp);
            ICommand switchDown = new FlipDownCommand(lamp);

            var s = new Switch();

            if (cmd == "ON")
            {
                s.StoreAndExecute(switchUp);
            }
            else if (cmd == "OFF")
            {
                s.StoreAndExecute(switchDown);
            }
            else
            {
                Console.WriteLine("Command \"ON\" or \"OFF\" is required.");
            }

            Console.ReadKey();
        }

    }
}
