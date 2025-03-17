using patterns.console.Command;
using patterns.console.Decorator;
using patterns.console.Observer;
using patterns.console.Strategy.Strategies;
using patterns.console.StrategyPattern;

DecoratorPatternExample();
ObservablePatternExample();
StrategyPatternExample();
CommandPatternExample();

Console.ReadKey();

static void CommandPatternExample()
{
    Calculator calculator = new Calculator();
    CalculatorInvoker invoker = new CalculatorInvoker();

    ICommand add5 = new AddCommand(calculator, 5);
    ICommand subtract3 = new SubtractCommand(calculator, 3);

    invoker.ExecuteCommand(add5);    // Current Value: 5
    invoker.ExecuteCommand(subtract3); // Current Value: 2
    invoker.UndoLastCommand();
}
static void ObservablePatternExample()
{
    PhoneStore store = new PhoneStore();

    ICustomer customer1 = new NiPhoneCustomer();
    ICustomer customer2 = new NanDroidCustomer();

    store.AddCustomer(customer1);
    store.AddCustomer(customer2);

    store.NewPhoneArrival("NiPhone 15");
    store.NewPhoneArrival("NanDroid X");
}
static void DecoratorPatternExample()
{
    IEngine engine = new BasicEngine();
    Console.WriteLine(engine.Description());

    engine = new SuperEngine(engine);
    Console.WriteLine(engine.Description());

    engine = new UltimateEngine(engine);
    Console.WriteLine(engine.Description());
}

static void StrategyPatternExample()
{
    Console.WriteLine("Welcome to the Strategy Pattern Example");
    TravelPlanner travelPlanner = new TravelPlanner();
    travelPlanner.SetTravelStrategy(new Plane());
    travelPlanner.Drive(1100);
   
} 

