using Final_ORM_TurboAz__.Domain.Abstraction;
using Final_ORM_TurboAz__.Domain.Concrete.Repositories;
using Final_ORM_TurboAz__.Helpers;

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

            var allcars = context.CarRepository.GetAll().ToList();
            foreach (var item in allcars)
            {
                Console.Write(item.Model);
                Console.WriteLine($" {item.Vendor.Name}");
            }
            // for now add custom helper methods for cars etc. (in ICarRepo(i.g))
        }
    }
}
