using Newtonsoft.Json;
using Mapster;

// Serialize object to json and print to console
public class Program
{
    public static void Print(object obj)
    {
        Console.WriteLine(JsonConvert.SerializeObject(obj, Formatting.Indented));
    }

    public static void Main(IProductMapper productMapper)
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
        var smallDto = productMapper.MapToDto(user);
        Print(smallDto);
        var fullDto = smallDto.Adapt<User>();
        Print(fullDto);
    }
}
