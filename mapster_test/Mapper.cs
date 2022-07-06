using Mapster;

[Mapper]
public interface IProductMapper
{
    SmallUserDto MapToDto(User user);
}
