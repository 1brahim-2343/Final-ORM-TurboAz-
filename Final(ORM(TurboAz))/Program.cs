using Final_ORM_TurboAz__.DataAccess;
using Final_ORM_TurboAz__.Domain.Abstraction;
using Final_ORM_TurboAz__.Domain.Concrete.Entities;
using Final_ORM_TurboAz__.Domain.Concrete.Repositories;
using Final_ORM_TurboAz__.Helpers;
using Final_ORM_TurboAz__.Helpers.HelperMethods_User_;
using Microsoft.EntityFrameworkCore;

namespace Final_ORM_TurboAz__
{
    internal class Program
    {
        static IUnitOfWork context = new UnitOfWork();
        static void Main(string[] args)
        {
            #region FillDBWithData //run ONLY once
            //HelperDataFill.CreateAddVendors(context);
            //HelperDataFill.CreateAddColors(context); 
            //HelperDataFill.CreateAddBodyTypes(context); 
            //HelperDataFill.CreateAddCars(context);
            #endregion

            //var allCars = context.CarRepository.GetAll().ToList();
            //for (int i = 0; i < allCars.Count; i++)
            //{
            //    context.CarRepository.PrintCarsWODetails(i+1);
            //}

            UserMenu user = new(context);
            user.Start();

        }
    }
}
