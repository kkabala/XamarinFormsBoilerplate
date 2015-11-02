namespace XamarinDDDTemplate.Infrastructure.Enums
{
    public enum AccessType
    {
        Read = 1,
        Write = 2,
        ReadWrite = Write | Read
    }
}