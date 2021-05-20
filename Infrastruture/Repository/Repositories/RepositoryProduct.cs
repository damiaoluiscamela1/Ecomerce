using Domain.Interfaces.InterfaceProduct;
using Entities.Entities;
using Infrastruture.Configuration;
using Infrastruture.Repository.Generics;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastruture.Repository.Repositories
{
    public class RepositoryProduct : RepositoryGenerics<Produto>, IProduct

    {
        private readonly DbContextOptions<ContextBase> _optionsbuilder;

        public RepositoryProduct()
        {
            _optionsbuilder = new DbContextOptions<ContextBase>();
        }
        public async Task<List<Produto>> ListarProdutosUsuarios(string UserId)
        {
            using (var banco = new ContextBase(_optionsbuilder)) 
            {
                return await banco.Produto.Where(p => p.UserId == UserId).AsNoTracking().ToListAsync();
            }
        }
    }
}
