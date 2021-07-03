using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Extensions.DependencyInjection;
using Repo.Repository.FoodTypeRepository;
using Repo.Repository.ReservationRepository;
using Repo.Repository.TableRepository;
using Repo.Repository.UserReposiory;
using Repo.shared;
using Repo.UnitOfWork;

namespace Service.Initializer
{
    public class RepositoryInitializer
    {
        public RepositoryInitializer(IServiceCollection services)
        {
            services.AddTransient<IUnitOfWork, UnitOfWork>();

            services.AddTransient<IUserRepository, UserRepository>();

            services.AddTransient<IReservationRepository, ReservationRepository>();

            services.AddTransient<IFoodyTypeRepository, FoodyTypeRepository>();

            services.AddTransient<ITableRepository, TableRepository>();

            services.AddTransient<IFoodyTypeRepository, FoodyTypeRepository>();

            
        }
    }
}
