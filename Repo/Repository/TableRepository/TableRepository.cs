using Data.Entities;
using Microsoft.EntityFrameworkCore;
using Repo.shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repo.Repository.TableRepository
{
   public  class TableRepository : Repository<Table>, ITableRepository
    {
        private DbSet<Table> TableEntity;
        public TableRepository(ApplicationContext context) : base(context)
        {
            TableEntity = context.Set<Table>();
        }
    }
}