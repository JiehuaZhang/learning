using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning.DesignPattern.DecoratorPattern
{
    public class DecoratorPatternDemo
    {
        public void TryDecoratorPattern()
        {
            var car = new HondaCity();

            Console.WriteLine($"Honda City base price are : {car.Price}");

            var offer = new SpecialOffer(car)
            {
                DiscountPercentage = 25,
                Offer = "25 % discount"
            };

            Console.WriteLine($"{offer.Offer} @ Diwali Special Offer and price are: {offer.Price}");
        }
    }
}
