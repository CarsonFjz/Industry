﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Industry.Data.Repositories;
using Industry.Domain.Entities;
using Repository.Pattern.Repositories;
using Service.Pattern;

namespace Industry.Services.Services
{
    public interface ICustomerService : IService<Customer>
    {
        Customer GetCustomerById(int shopperId);
        IEnumerable<Customer> GetCustomers();
    }

    public class CustomerService : Service<Customer>, ICustomerService
    {
        private readonly IRepositoryAsync<Customer> _repository;


        public CustomerService(IRepositoryAsync<Customer> repository)
            : base(repository)
        {
            _repository = repository;
            
        }

        public Customer GetCustomerById(int shopperId)
        {
            return _repository.GetCustomerById(shopperId);
        }

        public IEnumerable<Customer> GetCustomers()
        {
            return _repository.GetCustomers();
        }
    }
}