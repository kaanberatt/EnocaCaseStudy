﻿using EnocaCaseStudy.Application.Features.Orders.Commands.CreateOrder;
using EnocaCaseStudy.Application.Services;
using EnocaCaseStudy.Application;
using EnocaCaseStudy.Domain.Entities;
using EnocaCaseStudy.Application.Repositories.OrderRepositories;

namespace EnocaCaseStudy.Persistance.Services;
public class OrderService : IOrderService
{
    private readonly IOrderCommandRepository _ordercommandRepository;
    private readonly IUnitOfWork _unitOfWork;
    public OrderService(IOrderCommandRepository ordercommandRepository, IUnitOfWork unitOfWork)
    {
        _ordercommandRepository = ordercommandRepository;
        _unitOfWork = unitOfWork;
    }

    public async Task<CreateOrderCommandResponse> AddAsync(CreateOrderCommand request)
    {
        try
        {
            var order = new Order()
            {
                CompanyId = request.CompanyId,
                ProductId = request.ProductId,
                CustomerName = request.CustomerName,
                CreatedDate = DateTime.Now,
                OrderDate = DateTime.Now
            };
            await _ordercommandRepository.AddAsync(order);
            await _unitOfWork.SaveChangesAsync();
            return new CreateOrderCommandResponse()
            {
                isSuccess = true,
                Message = "Order is completed"
            };
        }
        catch (Exception ex)
        {
            return new CreateOrderCommandResponse()
            {
                isSuccess = false,
                Message = ex.Message,
            };
        }
        
    }
}
