using System.ComponentModel.DataAnnotations;

namespace backend333;

public class WeatherForecast
{
    public WeatherForecast(int temperatureC)
    {
        TemperatureC = temperatureC;
    }

    public DateTime Date { get; set; }

    public int TemperatureC { get; }

    public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);

    public string? Summary { get; set; }
}

public class Person
{
    public virtual string Greeting()
    {
        return "Hello";
    }

    
        
    
    public string Name { get; set; }
    public int Age { get; set; }

    public double Height { get; set; }
}

public class XhosaPersion : Person
{
    public override string Greeting()
    {
        return "molweni";
    }
}

public class Latina : Person
{
    public override string Greeting()
    {
        return "ola";
    }
}
 