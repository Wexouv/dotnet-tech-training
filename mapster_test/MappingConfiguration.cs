using Mapster;

public class MyRegister : ICodeGenerationRegister
{
    public void Register(CodeGenerationConfig config)
    {
        config.GenerateMapper("[name]Mapper")
                .ForType<User>()
                .ForType<Address>();
    }
}
