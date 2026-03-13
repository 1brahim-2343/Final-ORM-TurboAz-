using Final_ORM_TurboAz__.Domain.Concrete.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_ORM_TurboAz__.Domain.Abstraction
{
    public interface IUnitOfWork
    {
        public ICarRepository CarRepository { get; }

        public IVendorRepository VendorRepository { get; }

        public IColorRepository ColorRepository { get; }

        public IBodyTypeRepository BodyTypeRepository { get;}

        public IUserRepository UserRepository { get;}

        public IPostRepository PostRepository { get; }
    }
}
