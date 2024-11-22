using System;

namespace Luge
{
    class Car{
        public string model;

        public Car(string modelName){
            model = modelName;
        }
        static void Main(string [] arg){
            Car ford = new Car("Mustang");
            Console.WriteLine(ford.model);
        }

    }
}