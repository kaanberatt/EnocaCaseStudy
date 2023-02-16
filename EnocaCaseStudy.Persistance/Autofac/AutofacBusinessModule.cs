using Autofac;
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


    }
}
