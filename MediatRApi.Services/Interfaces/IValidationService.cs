namespace MediatRApi.Services.Interfaces
{
    public interface IValidationService
    {
        void Validate<T>(T obj);
    }
}
