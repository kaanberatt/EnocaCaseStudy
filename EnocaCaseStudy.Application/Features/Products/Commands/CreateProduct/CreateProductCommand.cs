using MediatR;

namespace EnocaCaseStudy.Application.Features.Products.Commands.CreateProduct;

public class CreateProductCommand: IRequest<CreateProductCommandResponse>
{
        public int CompanyId { get; set; }
        public string ProductName { get; set; }
        public decimal Stock { get; set; }
        public decimal Price { get; set; }

}
