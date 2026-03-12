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
    internal class ColorRepository : IColorRepository
    {
        private readonly TurboContext _context;
        public ColorRepository(TurboContext context)
        {
            _context = context;
        }
        public Color? Add(Color obj)
        {
            Color? addedObj = null;
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

        public void AddRange(params Color[] values)
        {
            _context.AddRange(values);
        }


        public bool Delete(int id)
        {
            var objToDelete = _context.Colors.SingleOrDefault(c => c.Id == id);
            if (objToDelete != null)
            {
                _context.Remove(objToDelete);
                return true;
            }
            return false;

        }

        public bool Delete(Expression<Func<Color, bool>> exp)
        {
            var objToDelete = _context.Colors.FirstOrDefault(exp);
            if (objToDelete != null)
            {
                _context.Remove(objToDelete);
                return true;
            }
            return false;

        }

        public Color? Get(int id)
        {
            var objToGet = _context.Colors.FirstOrDefault(c => c.Id == id);
            return objToGet;
        }

        public Color? Get(Expression<Func<Color, bool>> exp)
        {
            var objToGet = _context.Colors.FirstOrDefault(exp);
            return objToGet;

        }



        public IEnumerable<Color> GetAll()
        {
            return _context.Colors;
        }

        public IEnumerable<Color> GetAll(Expression<Func<Color, bool>> exp)
        {
            var objToGet = _context.Colors.Where(exp);
            return objToGet;
        }

        public void PrintAll(IEnumerable<Color> values)
        {
            Console.Clear();
            var colors = values.ToList();
            for (int i = 0; i < colors.Count; i++)
            {
                Console.WriteLine($"{i+1}.{colors[i].Name}");
            }
        }

        public int SaveChanges()
        {
            return _context.SaveChanges();
        }

        public bool Update(Color obj)
        {
            var objToUpdate = _context.Colors.Find(obj.Id);
            if (objToUpdate != null)
            {
                _context.Colors.Update(obj);
                return true;
            }
            else
            {
                throw new InvalidOperationException("Object was not found");
            }
        }
    }
}
