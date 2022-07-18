using ProxyPattern;

var decoratedCalculator = LoggingDecorator<ICalculator>.Create(new Calculator());
decoratedCalculator.Add(3, 5);
Console.ReadKey();