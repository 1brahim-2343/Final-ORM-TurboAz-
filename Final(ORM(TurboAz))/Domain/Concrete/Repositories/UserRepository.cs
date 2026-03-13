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
    public class UserRepository : IUserRepository
    {
        private readonly TurboContext _context;

        public UserRepository(TurboContext context)
        {
            _context = context;
        }
        public User? Add(User obj)
        {
            User? addedObj = null;
            try
            {
                addedObj = _context.Users.Add(obj).Entity;
            }
            catch (Exception ex)
            {
                ex.Message.ShowErrorMessage();
            }
            return addedObj;
        }

        public void AddRange(params User[] values)
        {
            _context.AddRange(values);
        }

        public bool Delete(int id)
        {
            var objToDelete = _context.Users.SingleOrDefault(c => c.Id == id);
            if (objToDelete != null)
            {
                _context.Remove(objToDelete);
                return true;
            }
            return false;
        }

        public bool Delete(Expression<Func<User, bool>> exp)
        {
            var objToDelete = _context.Users.FirstOrDefault(exp);
            if (objToDelete != null)
            {
                _context.Remove(objToDelete);
                return true;
            }
            return false;
        }

        public User? Get(int id)
        {
            var objToGet = _context.Users.FirstOrDefault(c => c.Id == id);
            return objToGet;
        }

        public User? Get(Expression<Func<User, bool>> exp)
        {
            var objToGet = _context.Users.FirstOrDefault(exp);
            return objToGet;
        }

        public IEnumerable<User> GetAll()
        {
            return _context.Users;
        }

        public IEnumerable<User> GetAll(Expression<Func<User, bool>> exp)
        {
            var objToGet = _context.Users.Where(exp);
            return objToGet;
        }

        public void PrintAll(IEnumerable<User> values)
        {
            Console.Clear();
            var users = values.ToList();
            for (int i = 0; i < users.Count; i++)
            {
                Console.WriteLine($"{i + 1}.{users[i].Username}");
            }
        }

        public int SaveChanges()
        {
            return _context.SaveChanges();
        }

        public bool Update(User obj)
        {
            var objToUpdate = _context.Users.Find(obj.Id);
            if (objToUpdate != null)
            {
                _context.Users.Update(obj);
                return true;
            }
            else
            {
                throw new InvalidOperationException("Object was not found");
            }
        }
    }
}
