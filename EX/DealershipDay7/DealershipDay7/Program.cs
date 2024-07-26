// See https://aka.ms/new-console-template for more information

using DealershipDay7;

Console.WriteLine("Hello, World!");

Dealership ds = new Dealership();

// See https://aka.ms/new-console-template for more information


bool flag = true;
do
{
    Console.WriteLine("---------------------");
    Console.WriteLine("Enter the option:");
    Console.WriteLine("1.List all available cars");
    Console.WriteLine("2.List available cars with less than a specific odometer reading");
    Console.WriteLine("3.List available cars with a specific make and model");
    Console.WriteLine("4.List available cars between a specific price range");
    Console.WriteLine("5.Sell a car");
    Console.WriteLine("6.Change a car’s price");
    Console.WriteLine("7.Delete a car from inventory");
    Console.WriteLine("8.Quit");
    Console.WriteLine("---------------------");

    int option = int.Parse(Console.ReadLine());
    switch (option)
    {
        case 1:
            ds.displayCars();
            Console.WriteLine("---------------------");
            break;
        case 2:
            Console.WriteLine("Enter the odometer reading");
            int x = int.Parse(Console.ReadLine());
           
            ds.getCarsbasedonOdometer(x);
            Console.WriteLine("---------------------");
            break;
        case 3:
            ds.showCarMake();
            Console.WriteLine("Enter the car make");
            string make = Console.ReadLine();
            Console.WriteLine("---------------------");
            Console.WriteLine("List of car model from the selected make");
            ds.showCarModel(make);
            Console.WriteLine("Enter the car model from" + make);
            string model =Console.ReadLine();
            ds.getCarsbasedonmodelmake(make, model);
            Console.WriteLine("---------------------");
            break;
        case 4:
            Console.WriteLine("Enter the price Range");
            double p1 = double.Parse(Console.ReadLine());
            double p2 = double.Parse(Console.ReadLine());
            ds.getCarsbasedonPrice(p1, p2);
            Console.WriteLine("---------------------");
            break;
        case 5:
            Console.WriteLine("Enter the inventory number that is to be sold");
            string iv = Console.ReadLine();
            ds.showCardata(iv);
            Console.WriteLine("Enter the sales date");
            DateOnly sale_date = DateOnly.Parse(Console.ReadLine());
            Console.WriteLine("Enter the customer name");
            string name = Console.ReadLine();
            Console.WriteLine("Enter the customer phone number");
            string number = Console.ReadLine();
            Console.WriteLine("Enter the payment-method");
            string payment = Console.ReadLine();
            Console.WriteLine("Enter the payment amount");
            double amnt = double.Parse(Console.ReadLine());
            ds.insertCar(iv, sale_date, name, number, payment, amnt);
            ds.updateStatus(iv);
            break;
        case 6:
            Console.WriteLine("Enter the inventory number of the car to update price of car");
            string ivno = Console.ReadLine();
            ds.showCardata(ivno);
            Console.WriteLine("Enter the price of car to update");
            double pr = double.Parse(Console.ReadLine());
            ds.updatePrice(ivno, pr);
            Console.WriteLine("---------------------");
            break;
        case 7:
            Console.WriteLine("Enter the inventory number of the car to be deleted");
            string ivn = Console.ReadLine();
            ds.showCardata(ivn);
            Console.WriteLine("Are you sure you want to delete the car record?(y/n)");
            string res = Console.ReadLine();
            if(res.Equals('y') || res.Equals("yes"))
            {
                ds.deletecar(ivn);
            }
            Console.WriteLine("---------------------");
            break;
        case 8:
            flag = false;
            break;
    }

} while (flag);


