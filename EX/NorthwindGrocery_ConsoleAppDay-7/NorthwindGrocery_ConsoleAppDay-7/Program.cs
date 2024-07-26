// See https://aka.ms/new-console-template for more information

using NorthwindGrocery_ConsoleAppDay_7;
Console.WriteLine("Hello, World!");

northwind nw = new northwind();
bool flag = true;
do
{
    Console.WriteLine("---------------------");
    Console.WriteLine("Enter the option:");
    Console.WriteLine("1.List all categories");
    Console.WriteLine("2.List products in a specific category");
    Console.WriteLine("3.List products in a price range");
    Console.WriteLine("4.List all suppliers");
    Console.WriteLine("5.List products from a specific supplier");
    Console.WriteLine("6.Quit");
    Console.WriteLine("---------------------");

    int option = int.Parse(Console.ReadLine());
    switch (option)
    {
        case 1:
            nw.getCategories();
            Console.WriteLine("---------------------");
            break;

        case 2:
            nw.displayCategories();
            bool check = false;
            do
            {
                Console.WriteLine("Select category to view its products");
                string category = Console.ReadLine();
                check = nw.CategoryExists(category);
                Console.WriteLine(check);
                if (check)
                {
                    nw.getCategoryProduct(category);
                }
            } while (!check);
            Console.WriteLine("---------------------");
            break;
        case 3:
            Console.WriteLine("Enter the price Range");
            double x = double.Parse(Console.ReadLine());
            double y = double.Parse(Console.ReadLine());
            nw.getProductsbasedonPrice(x, y);
            Console.WriteLine("---------------------");
            break;

        case 4:
            nw.getSuppliers();
            Console.WriteLine("---------------------");
            break;
        case 5:
            nw.getSuppliers();
            bool checkexist = false;
            do
            {
                Console.WriteLine("Select supplier to view its products");
                string supplier = Console.ReadLine();
                checkexist = nw.SupplierExists(supplier);
                Console.WriteLine(checkexist);
                if (checkexist)
                {
                    nw.getSupplierProduct(supplier);
                }
            } while (!checkexist);
            Console.WriteLine("---------------------");
            break;
        case 6:
            flag = false;
            break;
    }

} while (flag);


