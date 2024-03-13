using FluentValidation;

namespace StarFitApi.Models.Dto;

public interface IDataTransferObject
{
    public class Validator : AbstractValidator<IDataTransferObject>
    {
        public Validator()
        {
        }
    }

    public Task Validate();
}