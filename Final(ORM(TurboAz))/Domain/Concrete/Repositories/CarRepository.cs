using Final_ORM_TurboAz__.DataAccess;
using Final_ORM_TurboAz__.Domain.Abstraction;
using Final_ORM_TurboAz__.Domain.Concrete.Entities;
using Final_ORM_TurboAz__.Helpers.ExtensionMethods;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Final_ORM_TurboAz__.Domain.Concrete.Repositories
{
    public class CarRepository : ICarRepository
    {
        private readonly TurboContext _context;
        public CarRepository(TurboContext context)
        {
            _context = context;
        }
        public Car? Add(Car obj)
        {
            Car? addedObj = null;
            try
            {
                addedObj = _context.Add(obj).Entity;
            }
            catch (Exception ex)
            {
                ex.Message.ShowMessage();
            }
            return addedObj;
        }

        public void AddRange(params Car[] values)
        {
            _context.AddRange(values);
        }

        public void DecreaseQuantityByOne(Car obj)
        {
            var objToDecrease = _context.Cars.FirstOrDefault(c => c.Id == obj.Id);
            if (objToDecrease != null && objToDecrease.Quantity > 1)
                objToDecrease.Quantity--;
            else
            {
                throw new Exception("Either object not found OR Quantity can not be below or equal to zero");
            }
        }

        public bool Delete(int id)
        {
            var objToDelete = _context.Cars.SingleOrDefault(c => c.Id == id);
            if (objToDelete != null)
            {
                _context.Remove(objToDelete);
                return true;
            }
            return false;

        }

        public bool Delete(Expression<Func<Car, bool>> exp)
        {
            var objToDelete = _context.Cars.FirstOrDefault(exp);
            if (objToDelete != null)
            {
                _context.Remove(objToDelete);
                return true;
            }
            return false;

        }

        public Car? Get(int id)
        {
            var objToGet = _context.Cars.FirstOrDefault(c => c.Id == id);
            return objToGet;
        }

        public Car? Get(Expression<Func<Car, bool>> exp)
        {
            var objToGet = _context.Cars.FirstOrDefault(exp);
            return objToGet;
            
        }


        
        public IEnumerable<Car> GetAll()
        {
            return _context.Cars;
        }

        public IEnumerable<Car> GetAll(Expression<Func<Car, bool>> exp)
        {
            var objToGet = _context.Cars.Where(exp);
            return objToGet;
        }

        public int SaveChanges()
        {
            return _context.SaveChanges();
        }

        public bool Update(Car obj)
        {
            var objToUpdate = _context.Cars.Find(obj.Id);
            if (objToUpdate != null)
            {
                _context.Cars.Update(obj);
                return true;
            }
            else
            {
                throw new InvalidOperationException("Object was not found");
            }
        }
    }
}
