using MediatRApi.Services.Interfaces;

namespace MediatRApi.Services
{
    public class ValidationService : IValidationService
    {
        public void Validate<T>(T obj)
        {
            // Everything is good, carry on...
        }
    }
}
