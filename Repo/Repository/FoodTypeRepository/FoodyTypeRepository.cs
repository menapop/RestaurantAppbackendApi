using Data.Entities;
using Microsoft.EntityFrameworkCore;
using Repo.shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repo.Repository.FoodTypeRepository
{
    public class FoodyTypeRepository : Repository<FoodType>, IFoodyTypeRepository
    {
        private DbSet<FoodType> FoodTypeEntity;
        public FoodyTypeRepository(ApplicationContext context) : base(context)
        {
            FoodTypeEntity = context.Set<FoodType>();
        }
    }
}