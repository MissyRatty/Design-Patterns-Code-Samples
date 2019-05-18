using GOFDesignPatterns.Creational.AbstractFactory;
using GOFDesignPatterns.Creational.Builder;
using GOFDesignPatterns.Creational.Factory;
using GOFDesignPatterns.Creational.Prototype;
using GOFDesignPatterns.Creational.Singleton;
using GOFDesignPatterns.Others.NullObjectPattern;
using GOFDesignPatterns.Structural.Adapter;
using GOFDesignPatterns.Structural.Adapter.Target;
using GOFDesignPatterns.Structural.Decorator;
using GOFDesignPatterns.Structural.Facade.FacadeClass;
using System;
using System.Collections.Generic;
using System.Linq;

namespace GOFDesignPatterns
{
    public class Program
    {
        private static IXmlConverter _xmlConverter;
        private static Pizza _pizza;
        private static IUserRepository _userRepository;

        static void Main(string[] args)
        {
            //Creational Patterns
            Singleton();
            Builder();
            Factory();
            AbstractFactory();
            Prototype();

            //Structural Patterns
            _xmlConverter = new XmlConverter(new DataProvider());
            Adapter();
            Decorator();
            Facade();

            //Others
            NullObject();
        }

        #region Creational Patterns

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

        #endregion

        #region Structural Patterns

        #region Adapter

        private static void Adapter()
        {
            //Get Collection of Employees
            var employees = GetEmployeeXmlData();

            //the Adapter class instance
            var adapter = new XmlToJsonAdapter(_xmlConverter, new JsonConverter(employees));

            //use the adapter to convert your xml data into json
            adapter.ConvertXmlToJson();
        }

        private static IEnumerable<Employee> GetEmployeeXmlData()
        {
            // get employee data in xml and pass xml data into a Collection of Employee Objects
            return _xmlConverter.GetXml()
                                .Element("Employees")
                                .Elements("Employee")
                                .Select(x => new Employee
                                {
                                    FirstName = x.Attribute("FirstName").Value,
                                    LastName = x.Attribute("LastName").Value,
                                    City = x.Attribute("City").Value
                                });
        }

        #endregion

        #region Decorator

        private static void Decorator()
        {
            CreatePlainPizza();
            CreatePizzaWithMozzarella();
            CreatePizzaWithTomatoSauce();
            CreatePizzaWithAllToppings();
        }

        private static void CreatePlainPizza()
        {
            Console.WriteLine("\n-------------------- Creating Plain Pizza With No Topping --------------------");
            _pizza = new PlainPizza();
            Console.WriteLine("Ingredients of plain pizza: " + _pizza.GetDescription());
            Console.WriteLine("Plain Pizza Price: " + _pizza.GetCost());
            Console.WriteLine("\n");
        }

        private static void CreatePizzaWithMozzarella()
        {
            Console.WriteLine("\n-------------------- Creating Pizza With Mozzarella Topping --------------------");
            _pizza = new Mozzarella(new PlainPizza());
            Console.WriteLine("Ingredients of pizza with mozzarella toppings => " + _pizza.GetDescription());
            Console.WriteLine("Pizza with mozzarella toppings Price: " + _pizza.GetCost());
            Console.WriteLine("\n");
        }

        private static void CreatePizzaWithTomatoSauce()
        {
            Console.WriteLine("\n-------------------- Creating Pizza With Tomato Sauce Topping --------------------");
            _pizza = new TomatoSauce(new PlainPizza());
            Console.WriteLine("Ingredients of pizza with tomato sauce toppings => " + _pizza.GetDescription());
            Console.WriteLine("Pizza with tomato sauce toppings Price: " + _pizza.GetCost());
            Console.WriteLine("\n");
        }

        private static void CreatePizzaWithAllToppings()
        {
            Console.WriteLine("\n-------------------- Creating Pizza With Tomato Sauce and Mozzarella Toppings --------------------");
            // the plain pizza object will be sent to the Mozzarella topping constructor and TomatoSauceTopping constructor
            _pizza = new TomatoSauce(new Mozzarella(new PlainPizza()));
            Console.WriteLine("Ingredients of pizza with all toppings => " + _pizza.GetDescription());
            Console.WriteLine("Pizza with all toppings Price: " + _pizza.GetCost());
        }

        #endregion

        #region Facade

        private static void Facade()
        {
            BankAccountFacade accessingBank = new BankAccountFacade(123456, 1234);
            accessingBank.WithDrawCash(50);
            accessingBank.WithDrawCash(60);
            accessingBank.DepositCash(60);
            accessingBank.WithDrawCash(60);
        }

        #endregion

        #endregion

        #region Others

        #region Null Object Pattern

        private static void NullObject()
        {
            _userRepository = new UserRepository();
            var user = _userRepository.GetUserById(Guid.NewGuid());

            //Without the Null Object pattern, this line would throw an exception
            user.IncrementSessionTicket();

            Console.WriteLine("The user's name is {0}", user.Name);
            Console.ReadKey();
        }

        #endregion

        #endregion
    }
}
