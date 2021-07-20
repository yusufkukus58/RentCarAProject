using Business.Concrete;
using Business.Constants;
using DataAccess.Concrete.EntityFramework;
using Entity.Concrete;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            // CarTest();
            //  RentalTest();
            CustomerTest();
        }

        private static void CustomerTest()
        {
            CustomerManager customerMenager = new CustomerManager(new EfCustomerDal());
            customerMenager.Add(new Customer() { UserId = 1, CompanyName = "Bayram İndirimi" });
            Console.WriteLine(Messages.CustomerAdded);
            foreach (var customer in customerMenager.GetAll().Data)
            {
                Console.WriteLine(Messages.CustomerListed);
            }
        }

        private static void RentalTest()
        {
            RentalManager rentalManager = new RentalManager(new EfRentalDal());
            rentalManager.Add(new Rental()
            {

                CarId = 2,
                CustomerId = 1,
                RentDate = DateTime.Now,
                ReturnDate = new DateTime(2021, 03, 06)


            });
            Console.WriteLine(" Id     CarId    CustomerId          RentDate                  ReturnDate");
            Console.WriteLine("----   -------  -------------       -------------            ----------------");

            foreach (var rental in rentalManager.GetAll().Data)
            {
                Console.WriteLine(rental.Id + "    " + rental.CarId + "          " + rental.CustomerId + "               " + rental.RentDate + "       " + rental.ReturnDate);
            }
        }

        private static void CarTest()
        {
            CarManager carManager = new CarManager(new EfCarDal());
            var result = carManager.GetCarDetails();
            if (result.Success == true)
            {
                foreach (var item in result.Data)
                {
                    Console.WriteLine(item.CarId + "/" + item.BrandName);
                }

            }
            else
            {
                Console.WriteLine(result.Message);
            }
        }

    }
}
