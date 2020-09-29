using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Entities
{
    public interface IVehicle
    {
        void Move();
    }
    public abstract class Vehicle : IVehicle //Vehicle реализует IVehicle
    {
        public virtual void Move()
        {
            Console.WriteLine("Move");
        }

        public abstract int GetWeight();
    }

    public class Bicycle : Vehicle //Bicycle наследует Vehicle
    {
        public List<Wheel> Wheels { get; set; } //Велосипед состоит из колес. Связь B-1 - W- M. Композиция
        public Frame Frame { get; set; }//Велосипед состоит из рамы

        public override int GetWeight()
        {
            return 15;
        }

        public override void Move()
        {
            Console.WriteLine("Я тут еду как велосипед");
        }

      
    }

    public class Biker
    {
        public int Age { get; set; }
        public string Name { get; set; }
        public IEnumerable<Bicycle> BicycleCollection { get; set; } //Велосипед ассоциируется с Байкером (не состоит)
        //Один Байкер может иметь много велосипедов
    }


    public class Wheel
    {
        public int SpokeCount { get; set; }
    }

    public class Frame
    {

    }
}
