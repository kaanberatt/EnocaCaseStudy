using Autofac;
using EnocaCaseStudy.Application.Features.Companies.Commands.CreateCompany;
using EnocaCaseStudy.Application.Features.Companies.Commands.UpdateCompany;
using EnocaCaseStudy.Application.Features.Companies.Queries.GetListAllCompanyQuery;
using EnocaCaseStudy.Application.Features.Orders.Commands.CreateOrder;
using EnocaCaseStudy.Application.Features.Products.Commands.CreateProduct;
using EnocaCaseStudy.Application.Services;
using EnocaCaseStudy.Domain;
using EnocaCaseStudy.Domain.Entities;
using EnocaCaseStudy.Domain.Repositories.CompanyRepositories;
using EnocaCaseStudy.Domain.Repositories.OrderRepositories;
using EnocaCaseStudy.Domain.Repositories.ProductRepositories;
using EnocaCaseStudy.Persistance.Repositories.CompanyRepositories;
using EnocaCaseStudy.Persistance.Repositories.OrderRepositories;
using EnocaCaseStudy.Persistance.Repositories.ProductRepositories;
using EnocaCaseStudy.Persistance.Services;
using MediatR;
namespace EnocaCaseStudy.Persistance.Autofac;

public class AutofacBusinessModule : Module
{
    protected override void Load(ContainerBuilder builder)
    {
        builder.RegisterType<ProductCommandRepository>().As<IProductCommandRepository>();
        builder.RegisterType<ProductQueryRepository>().As<IProductQueryRepository>();
        builder.RegisterType<ProductService>().As<IProductService>();


        builder.RegisterType<OrderCommandRepository>().As<IOrderCommandRepository>();
        builder.RegisterType<OrderQueryRepository>().As<IOrderQueryRepository>();
        builder.RegisterType<OrderService>().As<IOrderService>();


        builder.RegisterType<CompanyCommandRepository>().As<ICompanyCommandRepository>();
        builder.RegisterType<CompanyQueryRepository>().As<ICompanyQueryRepository>();
        builder.RegisterType<CompanyService>().As<ICompanyService>();

        builder.RegisterType<UnitOfWork>().As<IUnitOfWork>();

        // Added MediaTR Services
        #region Companies
        builder.RegisterType<CreateCompanyCommandHandler>().As<IRequestHandler<CreateCompanyCommand, CreateCompanyCommandResponse>>();

        builder.RegisterType<GetListAllQueryHandler>().As<IRequestHandler<GetListAllCompanyQuery, GetListAllCompanyQueryResponse>>();

        builder.RegisterType<UpdateCompanyCommandHandler>().As<IRequestHandler<UpdateCompanyCommand, UpdateCompanyCommandResponse>>();
        #endregion

        #region Products
        builder.RegisterType<CreateProductCommandHandler>().As<IRequestHandler<CreateProductCommand, CreateProductCommandResponse>>();
        #endregion

        #region Orders
        builder.RegisterType<CreateOrderCommandHandler>().As<IRequestHandler<CreateOrderCommand, CreateOrderCommandResponse>>();
        #endregion
    }
}
