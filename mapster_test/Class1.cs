using Newtonsoft.Json;
using Mapster;

// Serialize object to json and print to console
public class Program
{
    public static void Print(object obj)
    {
        Console.WriteLine(JsonConvert.SerializeObject(obj, Formatting.Indented));
    }

    public static void Main()
    {
        var user = new User
        {
            Name = "John",
            Age = 30,
            Email = "test@gmail.com",
            Address = new Address
            {
                Street = "Main street",
                City = "New York",
                Country = "USA"
            }
        };

        Print(user);
        var smallDto = user.Adapt<SmallUserDto>();
        Print(smallDto);
        var fullDto = smallDto.Adapt<User>();
        Print(fullDto);
    }
}

public class User {
    public string Name { get; set; }
    public int Age { get; set; }
    public string Email { get; set; }
    public Address Address { get; set; }
}

public class Address {
    public string Street { get; set; }
    public string City { get; set; }
    public string Country { get; set; }
}

public class SmallUserDto
{
    public string Name { get; set; }
    public int Age { get; set; }
}
