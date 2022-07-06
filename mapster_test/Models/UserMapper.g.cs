public static partial class UserMapper
{
    public static SmallUserDto AdaptToSmallDto(this User p1)
    {
        return p1 == null ? null : new SmallUserDto()
        {
            Name = p1.Name,
            Age = p1.Age
        };
    }
    public static SmallUserDto AdaptTo(this User p2, SmallUserDto p3)
    {
        if (p2 == null)
        {
            return null;
        }
        SmallUserDto result = p3 ?? new SmallUserDto();
        
        result.Name = p2.Name;
        result.Age = p2.Age;
        return result;
        
    }
}