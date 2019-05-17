using GOFDesignPatterns.Creational.AbstractFactory;
using GOFDesignPatterns.Creational.Builder;
using GOFDesignPatterns.Creational.Factory;
using GOFDesignPatterns.Creational.Prototype;
using GOFDesignPatterns.Creational.Singleton;
using System;

namespace GOFDesignPatterns
{
    public class Program
    {
        static void Main(string[] args)
        {
            Singleton();
            Builder();
            Factory();
            AbstractFactory();
            Prototype();
        }

        #region Singleton

        private static void Singleton()
        {
            ScrabbleLetters newInstance = ScrabbleLetters.Instance();

            //Get Instance ID
            Console.WriteLine("Instance 1 ID: " + newInstance.GetHashCode());

            //get all game letters stored in the list
            Console.WriteLine("All Game Letters => " +
                String.Join(", ", newInstance.GetAvailableGameLetters()));

            var playerOneTiles = newInstance.GetTiles(3);

            Console.WriteLine("Player 1 just picked: " + String.Join(", ", playerOneTiles));

            Console.WriteLine("Available Letters are: " +
                String.Join(", ", newInstance.GetAvailableGameLetters()));


            ScrabbleLetters newInstance2 = ScrabbleLetters.Instance();

            //Get Instance ID
            Console.WriteLine("Instance 2 ID: " + newInstance2.GetHashCode());

            var playerTwoTiles = newInstance.GetTiles(2);

            Console.WriteLine("Player 2 just picked: " + String.Join(", ", playerTwoTiles));

            Console.WriteLine("Available Letters are: " +
                String.Join(", ", newInstance.GetAvailableGameLetters()));
        }

        #endregion

        #region Builder

        private static void Builder()
        {
            //create robot shop with robot builders
            RobotShop robotShop = new RobotShop();
            IRobotBuilder robotBuilder;

            //construct and display animal robots
            robotBuilder = new AnimalRobotBuilder();
            robotShop.Construct(robotBuilder);
            Robot animalRobot = robotBuilder.GetRobot();
            animalRobot.Show();

            //construct and display human robots
            robotBuilder = new HumanRobotBuilder();
            robotShop.Construct(robotBuilder);
            Robot humanRobot = robotBuilder.GetRobot();
            humanRobot.Show();
        }

        #endregion

        #region Factory Method

        private static void Factory()
        {
            CreateCar();
            CreateBicycle();
        }

        private static void CreateCar()
        {
            //Create a car
            IVehicleFactory _vehicleFactory = new CarFactory();
            IVehicle car = _vehicleFactory.CreateVehicle();
            car.Actions();
            car.Parts();
        }

        private static void CreateBicycle()
        {
            //Create a bicycle
            IVehicleFactory _vehicleFactory = new BicycleFactory();
            IVehicle bicycle = _vehicleFactory.CreateVehicle();
            bicycle.Actions();
            bicycle.Parts();
        }

        #endregion

        #region Abstract Factory

        private static void AbstractFactory()
        {
            CreateBus();
            CreateTruck();
        }

        private static void CreateBus()
        {
            VehicleFactory busFactory = new BusFactory();
            VehicleShop busShop = new VehicleShop(busFactory);
            busShop.ConstructVehicle();
        }

        private static void CreateTruck()
        {
            VehicleFactory truckFactory = new TruckFactory();
            VehicleShop truckShop = new VehicleShop(truckFactory);
            truckShop.ConstructVehicle();
        }

        #endregion

        #region Prototype

        private static void Prototype()
        {
            CloneFactory animalMaker = new CloneFactory();
            Sheep sheep = new Sheep("Scooby Doo");
            Sheep clonedSheep = (Sheep)animalMaker.GetClone(sheep);

            //check the type of object created for both sheep and cloned sheep instances
            Console.WriteLine(sheep);
            Console.WriteLine(clonedSheep);

            //Check if sheep and its cloned object have the same property values
            Console.WriteLine("The sheep name is " + sheep.Name);
            Console.WriteLine("The cloned sheep name is " + clonedSheep.Name);

            // if the hashcodes are different, then these objects were stored in different memory addresses.
            // that will mean that, we have successfully created a copy or clone of the current sheep(scooby doo) object
            Console.WriteLine("Sheep Hashcode is: " + sheep.GetHashCode());
            Console.WriteLine("Cloned Sheep Hashcode is: " + clonedSheep.GetHashCode());
        }

        #endregion
    }
}
