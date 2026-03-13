using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_ORM_TurboAz__.Domain.Concrete.Entities
{
    public class Post
    {
        public int Id { get; set; }
        public int CarID { get; set; }
        public virtual Car Car { get; set; }
        public int UserId { get; set; }
        public virtual User User { get; set; }
    }
}
