using patterns.console.Decorator;
using patterns.console.Strategy.Strategies;
using patterns.console.StrategyPattern;

DecoratorPatternExample();

Console.ReadKey();

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

