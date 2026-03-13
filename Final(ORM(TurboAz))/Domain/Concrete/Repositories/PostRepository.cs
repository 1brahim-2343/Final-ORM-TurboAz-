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
    public class PostRepository : IPostRepository
    {
        private readonly TurboContext _context;

        public PostRepository(TurboContext context)
        {
            _context = context;
        }

        public Post? Add(Post obj)
        {
            Post? addedObj = null;
            try
            {
                addedObj = _context.Posts.Add(obj).Entity;
            }
            catch (Exception ex)
            {
                ex.Message.ShowErrorMessage();
            }
            return addedObj;
        }

        public void AddRange(params Post[] values)
        {
            _context.AddRange(values);
        }

        public bool Delete(int id)
        {
            var objToDelete = _context.Posts.SingleOrDefault(p => p.Id == id);
            if (objToDelete != null)
            {
                _context.Remove(objToDelete);
                return true;
            }
            return false;
        }

        public bool Delete(Expression<Func<Post, bool>> exp)
        {
            var objToDelete = _context.Posts.FirstOrDefault(exp);
            if (objToDelete != null)
            {
                _context.Remove(objToDelete);
                return true;
            }
            return false;
        }

        public Post? Get(int id)
        {
            var objToGet = _context.Posts.FirstOrDefault(p => p.Id == id);
            return objToGet;
        }

        public Post? Get(Expression<Func<Post, bool>> exp)
        {
            var objToGet = _context.Posts.FirstOrDefault(exp);
            return objToGet;
        }

        public IEnumerable<Post> GetAll()
        {
            return _context.Posts;
        }

        public IEnumerable<Post> GetAll(Expression<Func<Post, bool>> exp)
        {
            var objToGet = _context.Posts.Where(exp);
            return objToGet;
        }

        public void PrintAll(IEnumerable<Post> values)
        {
            Console.Clear();
            var posts = values.ToList();
            for (int i = 0; i < posts.Count; i++)
            {
                Console.WriteLine($"{i + 1}.{posts[i].Car.Model}");
            }
        }

        public int SaveChanges()
        {
            return _context.SaveChanges();
        }

        public bool Update(Post obj)
        {
            var objToUpdate = _context.Posts.Find(obj.Id);
            if (objToUpdate != null)
            {
                _context.Posts.Update(obj);
                return true;
            }
            else
            {
                throw new InvalidOperationException("Object was not found");
            }
        }
    }
}
