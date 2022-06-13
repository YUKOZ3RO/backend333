using System.Reflection.Metadata.Ecma335;
using Microsoft.AspNetCore.Mvc;

namespace backend333.Controllers;

[ApiController]
[Route("[controller]")]
public class WeatherForecastController : ControllerBase

{
    private static readonly string[] Summaries = new[]
    {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    };

    private static readonly int[] Integers = new int[]
    {
        1, 2, 3, 4, 5, 6, 7, 8, 9
    };


    private static readonly bool[] Boolean = new bool[]
    {
        true, false
    };


    private static readonly double[] Double = new double[]
    {
        1.2, 1.3, 1.4
    };

    private static readonly Person[] PersonList = new Person[]
    {
        new Person()
        {
            Name = "Corrine",
            Age = 25,
            Height = 1.72
        },

        new Person()
        {
            Name = "Icey",
            Age = 21,
            Height = 1.62
        },

        new XhosaPersion()
        {
            Name = "Darsi",
            Age = 22,
            Height = 1.72
        },

        new Latina()
        {
            Name = "Stormi",
            Age = 30,
            Height = 1.72
        },
    };

    public WeatherForecastController()
    {
    }

    [HttpGet(template: $"int")]
    public List<int> Get()
    {
        var number = new List<int>()
        {
            1, 2, 3, 4, 5
        };
        return number;
    }

    [HttpGet(template: "intInput")]
    public ActionResult<int> intInput([FromQuery] int number)
    {
        if (Integers.Contains(number))
        {
            return Ok(number);
        }

        return NotFound();
    }


    [HttpGet(template: "bools")]
    public List<bool> Bools()
    {
        var boolean = new List<bool>()
            {
                true, false
            }
            ;
        return boolean;
    }

    [HttpGet(template: "boolsInput")]
    public ActionResult<bool> BoolsInput([FromQuery] bool boolean)
    {
        if (Boolean.Contains(boolean))
        {
            return Ok(boolean);
        }

        return NotFound();

        return boolean;
    }

    [HttpGet(template: "strings")]
    public List<string> Strings()
    {
        var strings = new List<string>()
            {
                "yes", "no"
            }
            ;
        return strings;
    }

    [HttpGet(template: "stringInput")]
    public ActionResult<string> StringInput([FromQuery] string name1)
    {
        var content = new List<string>() { };
        foreach (var element in Summaries)
        {
            if (element.StartsWith(name1))
            {
                content.Add(element);
            }
        }

        if (content.Count == 0)
        {
            return NotFound();
        }

        return Ok(content);
    }

    [HttpGet(template: "doubles")]
    public List<double> Doubles()
    {
        var doubles = new List<double>
        {
            3.1
        };
        return doubles;
    }


    [HttpGet(template: "doublesInput")]
    public ActionResult<double> DoublesInput([FromQuery] double doubles)
    {
        if (Double.Contains(doubles))
        {
            return Ok(doubles);
        }

        return NotFound();
    }

    [HttpPost(template: "person")]
    public List<Person> Persons()
    {
        var person = new Person()

        {
            Name = "Corrine",
            Age = 25,
            Height = 1.75
        };
        var person2 = new Person()
        {
            Name = "Erin",
            Age = 22,
            Height = 1.62
        };
        var persons = new List<Person>();
        persons.Add(person);
        persons.Add(person);
        return persons;
    }

    [HttpGet(template: "personInput")]
    public ActionResult PersonInput([FromQuery] Person person)
    {
        var persons = new List<Person>() { };
        foreach (var element in PersonList)
        {
            Console.WriteLine(element.Greeting());
            if (element.Height== person.Height && element.Name == person.Name && element.Age == person.Age)
            { 
                persons.Add(person);
            }
            
        }

        
        return persons.Count == 0 ? NotFound() : Ok(persons);
    }
}