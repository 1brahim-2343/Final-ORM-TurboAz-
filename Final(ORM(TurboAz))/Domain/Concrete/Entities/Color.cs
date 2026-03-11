using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_ORM_TurboAz__.Domain.Concrete.Entities
{
    public class Color
    {
        public int Id { get; set; }
        private string name;

        public string Name
        {
            get { return name; }
            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                {
                    name = value;
                }
                else
                {
                    throw new ArgumentException("Model name cannot be null or whitespace");
                }
            }
        }


        public bool IsMatte { get; set; } = false;
    }
}
