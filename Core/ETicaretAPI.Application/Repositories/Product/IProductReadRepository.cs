﻿using ETicaretAPI.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETicaretAPI.Application.Repositories
{
    public interface IProductReadRepository : IReadRepository<Product>
    {
        Task<Product> GetByIdAsync(string id);
        Task<object?> GetByIdAsync(string id, bool v);
    }
}
