public partial class ProductMapper : IProductMapper
{
    public SmallUserDto MapToDto(User p1)
    {
        return p1 == null ? null : new SmallUserDto()
        {
            Name = p1.Name,
            Age = p1.Age
        };
    }
}