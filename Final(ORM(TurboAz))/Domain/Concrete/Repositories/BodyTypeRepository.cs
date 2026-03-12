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
    public class BodyTypeRepository : IBodyTypeRepository
    {
        private readonly TurboContext _context;
        public BodyTypeRepository(TurboContext context)
        {
            _context = context;
        }
        public BodyType? Add(BodyType obj)
        {
            BodyType? addedObj = null;
            try
            {
                addedObj = _context.Add(obj).Entity;
            }
            catch (Exception ex)
            {
                ex.Message.ShowErrorMessage();
            }
            return addedObj;
        }

        public void AddRange(params BodyType[] values)
        {
            _context.AddRange(values);
        }


        public bool Delete(int id)
        {
            var objToDelete = _context.BodyTypes.SingleOrDefault(c => c.Id == id);
            if (objToDelete != null)
            {
                _context.Remove(objToDelete);
                return true;
            }
            return false;

        }

        public bool Delete(Expression<Func<BodyType, bool>> exp)
        {
            var objToDelete = _context.BodyTypes.FirstOrDefault(exp);
            if (objToDelete != null)
            {
                _context.Remove(objToDelete);
                return true;
            }
            return false;

        }

        public BodyType? Get(int id)
        {
            var objToGet = _context.BodyTypes.FirstOrDefault(c => c.Id == id);
            return objToGet;
        }

        public BodyType? Get(Expression<Func<BodyType, bool>> exp)
        {
            var objToGet = _context.BodyTypes.FirstOrDefault(exp);
            return objToGet;

        }



        public IEnumerable<BodyType> GetAll()
        {
            return _context.BodyTypes;
        }

        public IEnumerable<BodyType> GetAll(Expression<Func<BodyType, bool>> exp)
        {
            var objToGet = _context.BodyTypes.Where(exp);
            return objToGet;
        }

        public void PrintAll(IEnumerable<BodyType> values)
        {
            Console.Clear();
            var bodyTypes = values.ToList();
            for (int i = 0; i < bodyTypes.Count; i++)
            {
                Console.WriteLine($"{i+1}.{bodyTypes[i].Name}");
            }
        }

        public int SaveChanges()
        {
            return _context.SaveChanges();
        }

        public bool Update(BodyType obj)
        {
            var objToUpdate = _context.BodyTypes.Find(obj.Id);
            if (objToUpdate != null)
            {
                _context.BodyTypes.Update(obj);
                return true;
            }
            else
            {
                throw new InvalidOperationException("Object was not found");
            }
        }
    }
}
