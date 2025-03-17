using patterns.console.Decorator;
using patterns.console.Observer;
using patterns.console.Strategy.Strategies;
using patterns.console.StrategyPattern;

DecoratorPatternExample();
ObservablePatternExample();
StrategyPatternExample();

Console.ReadKey();

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

