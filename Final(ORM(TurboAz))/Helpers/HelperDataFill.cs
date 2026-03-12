using Final_ORM_TurboAz__.Domain.Abstraction;
using Final_ORM_TurboAz__.Domain.Concrete.Entities;
using Final_ORM_TurboAz__.Domain.Concrete.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_ORM_TurboAz__.Helpers
{
    public static class HelperDataFill
    {
        public static void CreateAddVendors(IUnitOfWork unitOfWork)
        {
            IUnitOfWork context = unitOfWork;
            int vendorId = 0;
            Vendor v1 = new() { Id = ++vendorId, Name = "BMW" };
            Vendor v2 = new() { Id = ++vendorId, Name = "Mercedes-Benz" };
            Vendor v3 = new() { Id = ++vendorId, Name = "Audi" };
            Vendor v4 = new() { Id = ++vendorId, Name = "Toyota" };
            Vendor v5 = new() { Id = ++vendorId, Name = "Honda" };
            Vendor v6 = new() { Id = ++vendorId, Name = "Ford" };
            Vendor v7 = new() { Id = ++vendorId, Name = "Chevrolet" };
            Vendor v8 = new() { Id = ++vendorId, Name = "Volkswagen" };
            Vendor v9 = new() { Id = ++vendorId, Name = "Porsche" };
            Vendor v10 = new() { Id = ++vendorId, Name = "Ferrari" };
            Vendor v11 = new() { Id = ++vendorId, Name = "Lamborghini" };
            Vendor v12 = new() { Id = ++vendorId, Name = "Volvo" };
            Vendor v13 = new() { Id = ++vendorId, Name = "Nissan" };
            Vendor v14 = new() { Id = ++vendorId, Name = "Hyundai" };
            Vendor v15 = new() { Id = ++vendorId, Name = "Kia" };
            Vendor v16 = new() { Id = ++vendorId, Name = "Tesla" };
            Vendor v17 = new() { Id = ++vendorId, Name = "Jeep" };
            Vendor v18 = new() { Id = ++vendorId, Name = "Subaru" };
            Vendor v19 = new() { Id = ++vendorId, Name = "Mazda" };
            Vendor v20 = new() { Id = ++vendorId, Name = "Lexus" };
            context.VendorRepository.AddRange(v1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v11, v12, v13, v14, v15, v16, v17, v18, v19, v20);
            context.VendorRepository.SaveChanges();
        }

        public static void CreateAddColors(IUnitOfWork unitOfWork)
        {
            IUnitOfWork context = unitOfWork;
            int colorId = 0;
            Color c1 = new() { Id = ++colorId, Name = "Beige" };
            Color c2 = new() { Id = ++colorId, Name = "Black" };
            Color c3 = new() { Id = ++colorId, Name = "Blue" };
            Color c4 = new() { Id = ++colorId, Name = "Brown" };
            Color c5 = new() { Id = ++colorId, Name = "Gold" };
            Color c6 = new() { Id = ++colorId, Name = "Green" };
            Color c7 = new() { Id = ++colorId, Name = "Grey" };
            Color c8 = new() { Id = ++colorId, Name = "Multi color" };
            Color c9 = new() { Id = ++colorId, Name = "Orange" };
            Color c10 = new() { Id = ++colorId, Name = "Pink" };
            Color c11 = new() { Id = ++colorId, Name = "Purple" };
            Color c12 = new() { Id = ++colorId, Name = "Red" };
            Color c13 = new() { Id = ++colorId, Name = "Silver" };
            Color c14 = new() { Id = ++colorId, Name = "Two-tone" };
            Color c15 = new() { Id = ++colorId, Name = "White" };
            Color c16 = new() { Id = ++colorId, Name = "Yellow" };
            Color c2_1 = new() { Id = ++colorId, Name = "Black-Matte", IsMatte = true };
            Color c3_1 = new() { Id = ++colorId, Name = "Blue-Matte", IsMatte = true };
            Color c6_1 = new() { Id = ++colorId, Name = "Green-Matte", IsMatte = true };
            Color c7_1 = new() { Id = ++colorId, Name = "Grey-Matte", IsMatte = true };
            Color c12_1 = new() { Id = ++colorId, Name = "Red-Matte", IsMatte = true };
            Color c13_1 = new() { Id = ++colorId, Name = "Silver-Matte", IsMatte = true };
            Color c15_1 = new() { Id = ++colorId, Name = "White-Matte", IsMatte = true };

            context.ColorRepository.AddRange(c1, c2, c3, c4, c5, c6, c7, c8, c9, c10, c11, c12, c13, c14, c15, c16, c2_1, c3_1, c6_1, c7_1, c12_1, c13_1, c15_1);
            context.ColorRepository.SaveChanges();
        }

        public static void CreateAddBodyTypes(IUnitOfWork unitOfWork)
        {
            var context = unitOfWork;
            int bodyId = 0;

            BodyType b1 = new() { Id = ++bodyId, Name = "SUV" };
            BodyType b2 = new() { Id = ++bodyId, Name = "Sedan" };
            BodyType b3 = new() { Id = ++bodyId, Name = "Hatchback" };
            BodyType b4 = new() { Id = ++bodyId, Name = "Coupe" };
            BodyType b5 = new() { Id = ++bodyId, Name = "Convertible" };
            BodyType b6 = new() { Id = ++bodyId, Name = "Wagon" };
            BodyType b7 = new() { Id = ++bodyId, Name = "Minivan" };
            BodyType b8 = new() { Id = ++bodyId, Name = "Pickup" };
            BodyType b9 = new() { Id = ++bodyId, Name = "Crossover" };
            BodyType b10 = new() { Id = ++bodyId, Name = "Roadster" };

            context.BodyTypeRepository.AddRange(b1, b2, b3, b4, b5, b6, b7, b8, b9, b10);
            context.BodyTypeRepository.SaveChanges();
        }

        public static void CreateAddCars(IUnitOfWork unitOfWork)
        {
            var context = unitOfWork;
            Car c1 = new()
            {
                Model = "X7",
                VendorId = 1,
                BodyTypeId = 1,
                ColorId = 2,
                FuelType = FuelType.Hybrid,
                EngineVolume = 3.5,
                IsNew = true,
                ProductionDate = new DateOnly(2025, 07, 15),
                Price = 220000,
                Quantity = 5
            };
            Car c2 = new()
            {
                Model = "S-Class",
                VendorId = 2,
                BodyTypeId = 2,
                ColorId = 15,
                FuelType = FuelType.Petrol,
                EngineVolume = 4.0,
                IsNew = true,
                ProductionDate = new DateOnly(2025, 03, 10),
                Price = 180000,
                Quantity = 3
            };
            Car c3 = new()
            {
                Model = "A6",
                VendorId = 3,
                BodyTypeId = 2,
                ColorId = 13,
                FuelType = FuelType.Diesel,
                EngineVolume = 3.0,
                IsNew = true,
                ProductionDate = new DateOnly(2024, 11, 20),
                Price = 95000,
                Quantity = 7
            };
            Car c4 = new()
            {
                Model = "Land Cruiser",
                VendorId = 4,
                BodyTypeId = 1,
                ColorId = 2,
                FuelType = FuelType.Petrol,
                EngineVolume = 4.6,
                IsNew = false,
                ProductionDate = new DateOnly(2022, 05, 01),
                Price = 75000,
                Quantity = 4
            };
            Car c5 = new()
            {
                Model = "Civic",
                VendorId = 5,
                BodyTypeId = 3,
                ColorId = 3,
                FuelType = FuelType.Petrol,
                EngineVolume = 1.5,
                IsNew = true,
                ProductionDate = new DateOnly(2025, 01, 15),
                Price = 32000,
                Quantity = 10
            };
            Car c6 = new()
            {
                Model = "Mustang",
                VendorId = 6,
                BodyTypeId = 4,
                ColorId = 12,
                FuelType = FuelType.Petrol,
                EngineVolume = 5.0,
                IsNew = true,
                ProductionDate = new DateOnly(2024, 09, 30),
                Price = 65000,
                Quantity = 6
            };
            Car c7 = new()
            {
                Model = "Camaro",
                VendorId = 7,
                BodyTypeId = 4,
                ColorId = 17,
                FuelType = FuelType.Petrol,
                EngineVolume = 6.2,
                IsNew = false,
                ProductionDate = new DateOnly(2023, 06, 12),
                Price = 55000,
                Quantity = 3
            };
            Car c8 = new()
            {
                Model = "Golf",
                VendorId = 8,
                BodyTypeId = 3,
                ColorId = 7,
                FuelType = FuelType.Diesel,
                EngineVolume = 2.0,
                IsNew = true,
                ProductionDate = new DateOnly(2025, 02, 28),
                Price = 38000,
                Quantity = 8
            };
            Car c9 = new()
            {
                Model = "911",
                VendorId = 9,
                BodyTypeId = 4,
                ColorId = 13,
                FuelType = FuelType.Petrol,
                EngineVolume = 3.0,
                IsNew = true,
                ProductionDate = new DateOnly(2025, 04, 05),
                Price = 250000,
                Quantity = 2
            };
            Car c10 = new()
            {
                Model = "F8",
                VendorId = 10,
                BodyTypeId = 10,
                ColorId = 12,
                FuelType = FuelType.Petrol,
                EngineVolume = 3.9,
                IsNew = true,
                ProductionDate = new DateOnly(2024, 12, 01),
                Price = 350000,
                Quantity = 1
            };
            Car c11 = new()
            {
                Model = "Huracan",
                VendorId = 11,
                BodyTypeId = 4,
                ColorId = 16,
                FuelType = FuelType.Petrol,
                EngineVolume = 5.2,
                IsNew = true,
                ProductionDate = new DateOnly(2025, 01, 20),
                Price = 300000,
                Quantity = 1
            };
            Car c12 = new()
            {
                Model = "XC90",
                VendorId = 12,
                BodyTypeId = 1,
                ColorId = 23,
                FuelType = FuelType.Hybrid,
                EngineVolume = 2.0,
                IsNew = true,
                ProductionDate = new DateOnly(2025, 03, 15),
                Price = 85000,
                Quantity = 5
            };
            Car c13 = new()
            {
                Model = "Qashqai",
                VendorId = 13,
                BodyTypeId = 9,
                ColorId = 7,
                FuelType = FuelType.Petrol,
                EngineVolume = 1.3,
                IsNew = false,
                ProductionDate = new DateOnly(2023, 08, 10),
                Price = 40000,
                Quantity = 6
            };
            Car c14 = new()
            {
                Model = "Grandeur",
                VendorId = 14,
                BodyTypeId = 9,
                ColorId = 3,
                FuelType = FuelType.Hybrid,
                EngineVolume = 2.4,
                IsNew = true,
                ProductionDate = new DateOnly(2024, 10, 25),
                Price = 45000,
                Quantity = 9
            };
            Car c15 = new()
            {
                Model = "Sportage",
                VendorId = 15,
                BodyTypeId = 9,
                ColorId = 15,
                FuelType = FuelType.Diesel,
                EngineVolume = 1.6,
                IsNew = true,
                ProductionDate = new DateOnly(2025, 02, 10),
                Price = 42000,
                Quantity = 7
            };
            Car c16 = new()
            {
                Model = "Model 3",
                VendorId = 16,
                BodyTypeId = 2,
                ColorId = 15,
                FuelType = FuelType.Electric,
                EngineVolume = 0,
                IsNew = true,
                ProductionDate = new DateOnly(2025, 05, 01),
                Price = 55000,
                Quantity = 12
            };
            Car c17 = new()
            {
                Model = "Model X",
                VendorId = 16,
                BodyTypeId = 1,
                ColorId = 2,
                FuelType = FuelType.Electric,
                EngineVolume = 0,
                IsNew = true,
                ProductionDate = new DateOnly(2025, 04, 20),
                Price = 95000,
                Quantity = 4
            };
            Car c18 = new()
            {
                Model = "Wrangler",
                VendorId = 17,
                BodyTypeId = 1,
                ColorId = 21,
                FuelType = FuelType.Petrol,
                EngineVolume = 3.6,
                IsNew = false,
                ProductionDate = new DateOnly(2022, 07, 14),
                Price = 50000,
                Quantity = 5
            };
            Car c19 = new()
            {
                Model = "Outback",
                VendorId = 18,
                BodyTypeId = 6,
                ColorId = 6,
                FuelType = FuelType.Petrol,
                EngineVolume = 2.5,
                IsNew = true,
                ProductionDate = new DateOnly(2024, 08, 30),
                Price = 38000,
                Quantity = 6
            };
            Car c20 = new()
            {
                Model = "CX-5",
                VendorId = 19,
                BodyTypeId = 9,
                ColorId = 22,
                FuelType = FuelType.Diesel,
                EngineVolume = 2.2,
                IsNew = true,
                ProductionDate = new DateOnly(2025, 01, 05),
                Price = 36000,
                Quantity = 8
            };
            Car c21 = new()
            {
                Model = "RX 350",
                VendorId = 20,
                BodyTypeId = 1,
                ColorId = 13,
                FuelType = FuelType.Hybrid,
                EngineVolume = 3.5,
                IsNew = true,
                ProductionDate = new DateOnly(2025, 03, 22),
                Price = 72000,
                Quantity = 4
            };
            Car c22 = new()
            {
                Model = "GLE",
                VendorId = 2,
                BodyTypeId = 1,
                ColorId = 2,
                FuelType = FuelType.Diesel,
                EngineVolume = 3.0,
                IsNew = true,
                ProductionDate = new DateOnly(2024, 11, 11),
                Price = 130000,
                Quantity = 3
            };
            Car c23 = new()
            {
                Model = "Q7",
                VendorId = 3,
                BodyTypeId = 1,
                ColorId = 18,
                FuelType = FuelType.Hybrid,
                EngineVolume = 3.0,
                IsNew = true,
                ProductionDate = new DateOnly(2025, 02, 17),
                Price = 110000,
                Quantity = 5
            };
            Car c24 = new()
            {
                Model = "RAV4",
                VendorId = 4,
                BodyTypeId = 9,
                ColorId = 15,
                FuelType = FuelType.Hybrid,
                EngineVolume = 2.5,
                IsNew = false,
                ProductionDate = new DateOnly(2023, 04, 09),
                Price = 48000,
                Quantity = 11
            };
            Car c25 = new()
            {
                Model = "Accord",
                VendorId = 5,
                BodyTypeId = 2,
                ColorId = 7,
                FuelType = FuelType.Petrol,
                EngineVolume = 1.5,
                IsNew = false,
                ProductionDate = new DateOnly(2022, 12, 20),
                Price = 35000,
                Quantity = 7
            };
            Car c26 = new()
            {
                Model = "Explorer",
                VendorId = 6,
                BodyTypeId = 1,
                ColorId = 2,
                FuelType = FuelType.Petrol,
                EngineVolume = 3.0,
                IsNew = true,
                ProductionDate = new DateOnly(2025, 01, 30),
                Price = 58000,
                Quantity = 6
            };
            Car c27 = new()
            {
                Model = "Taycan",
                VendorId = 9,
                BodyTypeId = 2,
                ColorId = 20,
                FuelType = FuelType.Electric,
                EngineVolume = 0,
                IsNew = true,
                ProductionDate = new DateOnly(2025, 05, 10),
                Price = 180000,
                Quantity = 2
            };
            Car c28 = new()
            {
                Model = "Macan",
                VendorId = 9,
                BodyTypeId = 9,
                ColorId = 19,
                FuelType = FuelType.Electric,
                EngineVolume = 0,
                IsNew = true,
                ProductionDate = new DateOnly(2025, 04, 15),
                Price = 95000,
                Quantity = 3
            };
            Car c29 = new()
            {
                Model = "Urus",
                VendorId = 11,
                BodyTypeId = 1,
                ColorId = 9,
                FuelType = FuelType.Petrol,
                EngineVolume = 4.0,
                IsNew = true,
                ProductionDate = new DateOnly(2024, 10, 01),
                Price = 280000,
                Quantity = 1
            };
            Car c30 = new()
            {
                Model = "EQS",
                VendorId = 2,
                BodyTypeId = 2,
                ColorId = 23,
                FuelType = FuelType.Electric,
                EngineVolume = 0,
                IsNew = true,
                ProductionDate = new DateOnly(2025, 06, 01),
                Price = 160000,
                Quantity = 2
            };
            Car c31 = new()
            {
                Model = "Camry",
                VendorId = 4,
                BodyTypeId = 2,
                ColorId = 7,
                FuelType = FuelType.Petrol,
                EngineVolume = 2.5,
                IsNew = false,
                ProductionDate = new DateOnly(2019, 03, 15),
                Price = 22000,
                Quantity = 3,
                Mileage = 85000
            };
            Car c32 = new()
            {
                Model = "3 Series",
                VendorId = 1,
                BodyTypeId = 2,
                ColorId = 2,
                FuelType = FuelType.Petrol,
                EngineVolume = 2.0,
                IsNew = false,
                ProductionDate = new DateOnly(2018, 07, 20),
                Price = 28000,
                Quantity = 2,
                Mileage = 120000
            };
            Car c33 = new()
            {
                Model = "A4",
                VendorId = 3,
                BodyTypeId = 2,
                ColorId = 13,
                FuelType = FuelType.Diesel,
                EngineVolume = 2.0,
                IsNew = false,
                ProductionDate = new DateOnly(2017, 11, 10),
                Price = 19000,
                Quantity = 1,
                Mileage = 150000
            };
            Car c34 = new()
            {
                Model = "CR-V",
                VendorId = 5,
                BodyTypeId = 9,
                ColorId = 15,
                FuelType = FuelType.Petrol,
                EngineVolume = 1.5,
                IsNew = false,
                ProductionDate = new DateOnly(2020, 05, 08),
                Price = 31000,
                Quantity = 4,
                Mileage = 60000
            };
            Car c35 = new()
            {
                Model = "Passat",
                VendorId = 8,
                BodyTypeId = 6,
                ColorId = 7,
                FuelType = FuelType.Diesel,
                EngineVolume = 2.0,
                IsNew = false,
                ProductionDate = new DateOnly(2016, 09, 25),
                Price = 15000,
                Quantity = 2,
                Mileage = 210000
            };

            context.CarRepository.AddRange(c1, c2, c3, c4, c5, c6, c7, c8, c9, c10, c11, c12, c13, c14, c15, c16, c17, c18, c19, c20, c21, c22, c23, c24, c25, c26, c27, c28, c29, c30,c31,c32,c33,c34,c35);
            context.CarRepository.SaveChanges();
        }
    }
}
