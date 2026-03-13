using Final_ORM_TurboAz__.DataAccess;
using Final_ORM_TurboAz__.Domain.Abstraction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_ORM_TurboAz__.Domain.Concrete.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        private TurboContext _context = new TurboContext();
        public ICarRepository CarRepository => new CarRepository(_context);

        public IVendorRepository VendorRepository => new VendorRepository(_context);

        public IColorRepository ColorRepository => new ColorRepository(_context);

        public IBodyTypeRepository BodyTypeRepository => new BodyTypeRepository(_context);
        public IUserRepository UserRepository => new UserRepository(_context);

        public IPostRepository PostRepository => new PostRepository(_context);
    }
}
