using Final_ORM_TurboAz__.Helpers;
using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_ORM_TurboAz__.Domain.Concrete.Entities
{
    public class Car
    {
        public int Id { get; set; }
        private string model;

        public string Model
        {
            get { return model; }
            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                {
                    model = value;
                }
                else
                {
                    throw new ArgumentException("Car model can not be null or white space");
                }
            }
        }

        public int VendorId { get; set; }
        public virtual Vendor Vendor { get; set; }
        public int BodyTypeId { get; set; }
        public virtual BodyType BodyType { get; set; }
        public int ColorId { get; set; }
        public virtual Color Color { get; set; }
        public FuelType FuelType { get; set; }

        public bool IsNew { get; set; }

        private int mileage;

        public int Mileage
        {
            get { return mileage; }
            set
            {
                if(value < 0 || (IsNew == true && value != 0) )
                {
                    throw new ArgumentException($"Mileage value,{value} error. Check whether >= 0 or the car is new\\used");
                }
                if(IsNew == true)
                {
                    mileage = 0;
                }
                mileage = value;
            }
        }

        private DateOnly productionDate;

        public DateOnly ProductionDate
        {
            get { return productionDate; }
            set
            {
                if (value.Year < 1900 || value > DateOnly.FromDateTime(DateTime.Today))
                {
                    throw new ArgumentException($"Invalid date input,{value}");
                }
            }
        }

        private int price;

        public int Price
        {
            get { return price; }
            set
            {
                if (value < 100)
                {
                    throw new ArgumentException("Price can not be less than 100");
                }
                price = value;
            }
        }

        private int quantity;

        public int Quantity
        {
            get { return quantity; }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Quantity can not be below or equal to zero(0)");
                }
                quantity = value;
            }
        }

    }
}
