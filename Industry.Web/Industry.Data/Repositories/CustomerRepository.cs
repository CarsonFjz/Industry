﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Industry.Domain.Entities;
using Repository.Pattern.Repositories;

namespace Industry.Data.Repositories
{
    public static class CustomerRepository
    {
        public static Customer GetCustomerById(this IRepository<Customer> repository, int customerId)
        {
            return repository.Queryable().FirstOrDefault(s => s.Id == customerId);
        }
        public static IEnumerable<Customer> GetCustomers(this IRepository<Customer> repository)
        {
            return repository.Queryable();
        }
    }
}
