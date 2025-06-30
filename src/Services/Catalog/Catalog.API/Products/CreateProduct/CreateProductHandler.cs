using System.Windows.Input;
using BuildingBlocks.CQRS;
using Catalog.API.Models;
using MediatR;

namespace Catalog.API.Products.CreateProduct
{
    public record CreateProductCommand(string Name, List<string> Category, string Description, string ImageFile, decimal Price)
        : ICommand<CreateProductResult>;
    public record CreateProductResult(Guid id);
    internal class CreateProductCommandHandler : ICommandHandler<CreateProductCommand, CreateProductResult>
    {
        public async Task<CreateProductResult> Handle(CreateProductCommand command, CancellationToken cancellationToken)
        {
            //create product
            var product = new Product
            {
                Id = Guid.NewGuid(),
                Name = command.Name,
                Category = command.Category,
                Description = command.Description,
                ImageFile = command.ImageFile,
                Price = command.Price
            };
            //save to db

            // TDL 


            //return result

            return  new CreateProductResult(Guid.NewGuid());

            throw new NotImplementedException();
        }
    }
}
