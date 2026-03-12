using Final_ORM_TurboAz__.Domain.Abstraction;
using Final_ORM_TurboAz__.Domain.Concrete.Entities;
using Final_ORM_TurboAz__.Helpers.ExtensionMethods;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_ORM_TurboAz__.Helpers.HelperMethods_User_
{
    public class UserMenu
    {
        private readonly IUnitOfWork _context;
        public UserMenu(IUnitOfWork context)
        {
            _context = context;
        }
        public void Start()
        {
            Console.WriteLine("[1] Show All Cars(Vendor&Model)");
            Console.WriteLine("[2] Show New Cars Only");
            Console.WriteLine("[3] Custom Filter");
            var choice = Console.ReadKey();

            switch (choice.Key)
            {
                case ConsoleKey.D1:
                    {

                        var cars = _context.CarRepository.GetAll();
                        _context.CarRepository.PrintAll(cars);
                        break;
                    }
                case ConsoleKey.D2:
                    {
                        var newCars = _context.CarRepository.GetAllNewCars();
                        _context.CarRepository.PrintAll(newCars);
                        break;
                    }
                case ConsoleKey.D3:
                    {
                        int carToShow = CustomFilter();
                        Console.Clear();
                        _context.CarRepository.PrintCarWDetails(carToShow);
                        break;
                    }
                default:
                    break;
            }
        }
        private int CustomFilter()
        {
            List<string> possibleChoices = ["Body type", "Mileage", "Production date", "Color", "Price", "Fuel type", "Engine volume"];
            List<Car>? filteredCars = null;
        CustomFilterStart:
            //Console.Clear();
            bool conditionToContinue = true;
            while (conditionToContinue)
            {
                Console.Clear();
                for (int i = 0; i < possibleChoices.Count; i++)
                {
                    Console.WriteLine($"{i + 1}.{possibleChoices[i]}");
                }
                var choice = Console.ReadKey();

                switch (choice.Key)
                {
                    case ConsoleKey.D1:
                        {
                        BodyFilterStart:
                            try
                            {
                                filteredCars = BodyTypeFilter(filteredCars).ToList();
                            }
                            catch (Exception ex)
                            {
                                ex.Message.ShowErrorMessage();
                                Thread.Sleep(1000);
                                goto BodyFilterStart;
                            }
                            if (filteredCars != null)
                                _context.CarRepository.PrintAll(filteredCars);
                            else
                                Console.WriteLine("No cars available for the given criteria.");

                            Console.WriteLine("\nPress [Enter] to add more filters or enter a car [number] for detailed info.");
                            var postChoice = Console.ReadKey();
                            if (postChoice.Key != ConsoleKey.Enter)
                            {
                                conditionToContinue = false;
                                int carNum = 0;
                                if (!(int.TryParse(postChoice.KeyChar.ToString(), out carNum)))
                                    continue;
                                return filteredCars[carNum - 1].Id;
                            }
                            break;
                        }
                    case ConsoleKey.D2:
                        {
                        MileageFilterStart:
                            try
                            {
                                filteredCars = MileageFilter(filteredCars).ToList();
                            }
                            catch (Exception ex)
                            {
                                ex.Message.ShowErrorMessage();
                                Thread.Sleep(1000);
                                goto MileageFilterStart;
                            }
                            if (filteredCars != null)
                                _context.CarRepository.PrintAll(filteredCars);
                            else
                                Console.WriteLine("No cars available for the given criteria.");

                            Console.WriteLine("\nPress [Enter] to add more filters or enter a car [number] for detailed info.");
                            var postChoice = Console.ReadKey();
                            if (postChoice.Key != ConsoleKey.Enter)
                            {
                                conditionToContinue = false;
                                int carNum = 0;
                                if (!(int.TryParse(postChoice.KeyChar.ToString(), out carNum)))
                                    continue;
                                return filteredCars[carNum - 1].Id;
                            }
                            break;
                        }
                    case ConsoleKey.D3:
                        {
                        ProdDateFilter:
                            try
                            {
                                filteredCars = ProdDateFilter(filteredCars).ToList();
                            }
                            catch (Exception ex)
                            {
                                ex.Message.ShowErrorMessage();
                                Thread.Sleep(1000);
                                goto ProdDateFilter;
                            }
                            if (filteredCars != null)
                                _context.CarRepository.PrintAll(filteredCars);
                            else
                                Console.WriteLine("No cars available for the given criteria.");

                            Console.WriteLine("\nPress [Enter] to add more filters or enter a car [number] for detailed info.");
                            var postChoice = Console.ReadKey();
                            if (postChoice.Key != ConsoleKey.Enter)
                            {
                                conditionToContinue = false;
                                int carNum = 0;
                                if (!(int.TryParse(postChoice.KeyChar.ToString(), out carNum)))
                                    continue;
                                return filteredCars[carNum - 1].Id;
                            }
                            break;
                        }
                    case ConsoleKey.D4:
                        {
                        ColorFilterStart:
                            try
                            {
                                filteredCars = ColorFilter(filteredCars).ToList();
                            }
                            catch (Exception ex)
                            {
                                ex.Message.ShowErrorMessage();
                                Thread.Sleep(1000);
                                goto ColorFilterStart;
                            }
                            if (filteredCars != null)
                                _context.CarRepository.PrintAll(filteredCars);
                            else
                                Console.WriteLine("No cars available for the given criteria.");

                            Console.WriteLine("\nPress [Enter] to add more filters or enter a car [number] for detailed info.");
                            var postChoice = Console.ReadKey();
                            if (postChoice.Key != ConsoleKey.Enter)
                            {
                                conditionToContinue = false;
                                int carNum = 0;
                                if (!(int.TryParse(postChoice.KeyChar.ToString(), out carNum)))
                                    continue;
                                return filteredCars[carNum - 1].Id;
                            }
                            break;
                        }
                    case ConsoleKey.D5:
                        {
                        PriceRangeFilterStart:
                            try
                            {
                                filteredCars = PriceFilter(filteredCars).ToList();
                            }
                            catch (Exception ex)
                            {
                                ex.Message.ShowErrorMessage();
                                Thread.Sleep(1000);
                                goto PriceRangeFilterStart;
                                throw;
                            }
                            if (filteredCars != null)
                                _context.CarRepository.PrintAll(filteredCars);
                            else
                                Console.WriteLine("No cars available for the given criteria.");

                            Console.WriteLine("\nPress [Enter] to add more filters or enter a car [number] for detailed info.");
                            var postChoice = Console.ReadKey();
                            if (postChoice.Key != ConsoleKey.Enter)
                            {
                                conditionToContinue = false;
                                int carNum = 0;
                                if (!(int.TryParse(postChoice.KeyChar.ToString(), out carNum)))
                                    continue;
                                return filteredCars[carNum - 1].Id;
                            }
                            break;
                        }
                    case ConsoleKey.D6:
                        {
                        FuelTypeFilter:
                            try
                            {
                                filteredCars = FuelTypeFilter(filteredCars).ToList();
                            }
                            catch (Exception ex)
                            {
                                ex.Message.ShowErrorMessage();
                                Thread.Sleep(1000);
                                goto FuelTypeFilter;
                            }
                            if (filteredCars != null)
                                _context.CarRepository.PrintAll(filteredCars);
                            else
                                Console.WriteLine("No cars available for the given criteria.");

                            Console.WriteLine("\nPress [Enter] to add more filters or enter a car [number] for detailed info.");
                            var postChoice = Console.ReadKey();
                            if (postChoice.Key != ConsoleKey.Enter)
                            {
                                conditionToContinue = false;
                                int carNum = 0;
                                if (!(int.TryParse(postChoice.KeyChar.ToString(), out carNum)))
                                    continue;
                                return filteredCars[carNum - 1].Id;
                            }
                            break;
                        }
                    case ConsoleKey.D7:
                        {
                        EngineVolumeFilterStart:
                            try
                            {
                                filteredCars = EngineVolumeFilter(filteredCars).ToList();
                            }
                            catch (Exception ex)
                            {
                                ex.Message.ShowErrorMessage();
                                Thread.Sleep(1000);
                                goto EngineVolumeFilterStart;
                                throw;
                            }
                            if (filteredCars != null)
                                _context.CarRepository.PrintAll(filteredCars);
                            else
                                Console.WriteLine("No cars available for the given criteria.");

                            Console.WriteLine("\nPress [Enter] to add more filters or enter a car [number] for detailed info.");
                            var postChoice = Console.ReadKey();
                            if (postChoice.Key != ConsoleKey.Enter)
                            {
                                conditionToContinue = false;
                                int carNum = 0;
                                if (!(int.TryParse(postChoice.KeyChar.ToString(), out carNum)))
                                    continue;
                                return filteredCars[carNum - 1].Id;
                            }
                            break;
                        }
                    default:
                        goto CustomFilterStart;
                }
            }
            return 0;
        }
        private IEnumerable<Car> BodyTypeFilter(List<Car>? filteredCars)
        {
            var bodyTypes = _context.BodyTypeRepository.GetAll().ToList();
            _context.BodyTypeRepository.PrintAll(bodyTypes);
            Console.Write("Choose one: ");
            int choice = 0;
            IEnumerable<Car>? result = null;
            if (!(int.TryParse(Console.ReadLine(), out choice)) || choice > bodyTypes.Count || choice <= 0)
            {
                throw new ArgumentException("Input (valid) number only");
            }
            if (filteredCars != null)
            {
                result = _context.CarRepository.GetAll(c => c.BodyType.Name == bodyTypes[choice - 1].Name).Intersect(filteredCars);
            }
            else
            {
                result = _context.CarRepository.GetAll(c => c.BodyType.Name == bodyTypes[choice - 1].Name);
            }
            return result;
        }
        private IEnumerable<Car> MileageFilter(List<Car>? filteredCars)
        {
            int min = 0;
            int max = 0;
            Console.Write("\bMin mileage: ");
            if (!(int.TryParse(Console.ReadLine(), out min)) || min < 0)
            {
                throw new ArgumentException("Mileage must be (valid) number");
            }
            Console.Write($"Max mileage (more than {min}): ");
            if (!(int.TryParse(Console.ReadLine(), out max)) || max < min)
            {
                throw new ArgumentException("Mileage must be (valid) number");
            }
            IEnumerable<Car>? result = null;
            if (filteredCars != null)
            {
                result = _context.CarRepository.GetAll(c => c.Mileage > min && c.Mileage < max).Intersect(filteredCars);
            }
            else
            {
                result = _context.CarRepository.GetAll(c => c.Mileage > min && c.Mileage < max);
            }
            return result;
        }
        private IEnumerable<Car> ProdDateFilter(List<Car>? filteredCars)
        {
            int min = 0;
            int max = 0;
            Console.Write("\bMin year(at least 2000): ");
            if (!(int.TryParse(Console.ReadLine(), out min)) || min < 2000)
            {
                throw new ArgumentException("Year must be (valid) number");
            }
            Console.Write($"Max year (more than {min}): ");
            if (!(int.TryParse(Console.ReadLine(), out max)) || max < min)
            {
                throw new ArgumentException("Year must be (valid) number");
            }
            IEnumerable<Car>? result = null;
            if (filteredCars != null)
            {
                result = _context.CarRepository.GetAll(c => c.ProductionDate.Year >= min && c.ProductionDate.Year <= max).Intersect(filteredCars);
            }
            else
            {
                result = _context.CarRepository.GetAll(c => c.ProductionDate.Year >= min && c.ProductionDate.Year <= max);
            }
            return result;
        }
        private IEnumerable<Car> ColorFilter(List<Car>? filteredCars)
        {
            var availableColors = _context.ColorRepository.GetAll().ToList();
            _context.ColorRepository.PrintAll(availableColors);
            Console.Write("Choose one: ");
            int choice = 0;
            IEnumerable<Car>? result = null;
            if (!(int.TryParse(Console.ReadLine(), out choice)) || choice > availableColors.Count || choice <= 0)
            {
                throw new ArgumentException("Input (valid) number only");
            }
            if (filteredCars != null)
            {
                result = _context.CarRepository.GetAll(c => c.Color.Name == availableColors[choice - 1].Name).Intersect(filteredCars);
            }
            else
            {
                result = _context.CarRepository.GetAll(c => c.Color.Name == availableColors[choice - 1].Name);
            }
            return result;

        }
        private IEnumerable<Car> PriceFilter(List<Car>? filteredCars)
        {
            int min = 0;
            int max = 0;
            Console.Write("\bMin price(at least 100): ");
            if (!(int.TryParse(Console.ReadLine(), out min)) || min < 0)
            {
                throw new ArgumentException("Price must be (valid) number");
            }
            Console.Write($"Max price (more than {min}): ");
            if (!(int.TryParse(Console.ReadLine(), out max)) || max < min)
            {
                throw new ArgumentException("Price must be (valid) number");
            }
            IEnumerable<Car>? result = null;
            if (filteredCars != null)
            {
                result = _context.CarRepository.GetAll(c => c.Price > min && c.Price < max).Intersect(filteredCars);
            }
            else
            {
                result = _context.CarRepository.GetAll(c => c.Price > min && c.Price < max);
            }
            return result;
        }
        private IEnumerable<Car> FuelTypeFilter(List<Car>? filteredCars)
        {
            List<FuelType> fuelTypes = [FuelType.Petrol, FuelType.Electric, FuelType.Diesel, FuelType.Hybrid];
            Console.Clear();
            for (int i = 0; i < fuelTypes.Count; i++)
            {
                Console.WriteLine($"{i + 1}.{fuelTypes[i]}");
            }
            Console.Write("Choose one: ");
            int choice = 0;
            IEnumerable<Car>? result = null;
            if (!(int.TryParse(Console.ReadLine(), out choice)) || choice > fuelTypes.Count || choice <= 0)
            {
                throw new ArgumentException("Input (valid) number only");
            }
            if (filteredCars != null)
            {
                result = _context.CarRepository.GetAll(c => c.FuelType == fuelTypes[choice - 1]).Intersect(filteredCars);
            }
            else
            {
                result = _context.CarRepository.GetAll(c => c.FuelType == fuelTypes[choice - 1]);
            }
            return result;
        }
        private IEnumerable<Car> EngineVolumeFilter(List<Car>? filteredCars)
        {
            float min = 0;
            float max = 0;
            Console.Write("\bMin volume: ");
            if (!(float.TryParse(Console.ReadLine(), out min)) || min < 0)
            {
                throw new ArgumentException("Volume must be (valid) number");
            }
            Console.Write($"Max volume (more than {min}): ");
            if (!(float.TryParse(Console.ReadLine(), out max)) || max < min)
            {
                throw new ArgumentException("Volume must be (valid) number");
            }
            IEnumerable<Car>? result = null;
            if (filteredCars != null)
            {
                result = _context.CarRepository.GetAll(c => c.EngineVolume > min && c.EngineVolume < max).Intersect(filteredCars);
            }
            else
            {
                result = _context.CarRepository.GetAll(c => c.EngineVolume > min && c.EngineVolume < max);
            }
            return result;
        }
    }
}
