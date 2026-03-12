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
    public class VendorRepository : IVendorRepository
    {
        private readonly TurboContext _context;
        public VendorRepository(TurboContext context)
        {
            _context = context;
        }
        public Vendor? Add(Vendor obj)
        {
            Vendor? addedObj = null;
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

        public void AddRange(params Vendor[] values)
        {
            _context.AddRange(values);
        }


        public bool Delete(int id)
        {
            var objToDelete = _context.Vendors.SingleOrDefault(c => c.Id == id);
            if (objToDelete != null)
            {
                _context.Remove(objToDelete);
                return true;
            }
            return false;

        }

        public bool Delete(Expression<Func<Vendor, bool>> exp)
        {
            var objToDelete = _context.Vendors.FirstOrDefault(exp);
            if (objToDelete != null)
            {
                _context.Remove(objToDelete);
                return true;
            }
            return false;

        }

        public Vendor? Get(int id)
        {
            var objToGet = _context.Vendors.FirstOrDefault(c => c.Id == id);
            return objToGet;
        }

        public Vendor? Get(Expression<Func<Vendor, bool>> exp)
        {
            var objToGet = _context.Vendors.FirstOrDefault(exp);
            return objToGet;

        }



        public IEnumerable<Vendor> GetAll()
        {
            return _context.Vendors;
        }

        public IEnumerable<Vendor> GetAll(Expression<Func<Vendor, bool>> exp)
        {
            var objToGet = _context.Vendors.Where(exp);
            return objToGet;
        }

        public void PrintAll(IEnumerable<Vendor> values)
        {
            Console.Clear();
            var vendors = values.ToList();
            for (int i = 0; i < vendors.Count; i++)
            {
                Console.WriteLine($"{i+1}.{vendors[i].Name}");
            }
        }

        public int SaveChanges()
        {
            return _context.SaveChanges();
        }


        public bool Update(Vendor obj)
        {
            var objToUpdate = _context.Vendors.Find(obj.Id);
            if (objToUpdate != null)
            {
                _context.Vendors.Update(obj);
                return true;
            }
            else
            {
                throw new InvalidOperationException("Object was not found");
            }
        }
    }
}
