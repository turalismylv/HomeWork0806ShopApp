using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp21
{

    class Shop
    {
        public double Totalincome { get; set; }
        public Object[] product;
        public Shop()
        {
            product = new object[0];
        }
        public bool Add(Object obj)
        {
            string type = obj.GetType().Name;
            switch (type)
            {
                case "Coffe":
                    {
                        Coffe addedCoffee = (Coffe)obj;
                        foreach (var item in product)
                        {
                            if (item.GetType().Name != "Tea")
                            {
                                Coffe coffee = (Coffe)item;
                                if (coffee.Name == addedCoffee.Name)
                                {
                                    Console.WriteLine("Bu Coffee movcuddur!!!");
                                    return false;
                                }
                            }
                        }
                        break;
                    }
                case "Tea":
                    {
                        Tea addedTea = (Tea)obj;
                        foreach (var item in product)
                        {
                            if (item.GetType().Name != "Coffe")
                            {
                                Tea tea = (Tea)item;
                                if (tea.Name == addedTea.Name)
                                {
                                    Console.WriteLine("Bu tea movcuddur!!!");
                                    return false;
                                }
                            }
                        }
                        break;
                    }
            }

            Array.Resize(ref product, product.Length + 1);
            product[product.Length - 1] = obj;

            return true;


        }
        public static void RemoveAt(ref Object[] arr, int index)
        {
            for (int a = index; a < arr.Length - 1; a++)
            {
                arr[a] = arr[a + 1];
            }
            Array.Resize(ref arr, arr.Length - 1);
        }
        public bool Sell(string name, int count)
        {
            if (product.Length == 0)
            {
                Console.WriteLine("Produkt yoxdur");
                return false;
            }
            foreach (var item in product)
            {
                string type = item.GetType().Name;
                switch (type)
                {
                    case "Coffe":
                        {
                            Coffe coffee = (Coffe)item;
                            if (coffee.Name != name)
                            {
                                Console.WriteLine("Bu kofeden yoxdur");
                                return false;
                            }
                            else if (coffee.Count < count && coffee.Name == name)
                            {
                                Console.WriteLine("Bu kofeden yeterli qeder yoxdur");
                                return false;
                            }
                            else if (coffee.Name == name)
                            {
                                Totalincome += coffee.Price * count;
                                coffee.Count -= count;
                                int indexOfItem = Array.IndexOf(product, item);
                                if (coffee.Count == 0)
                                {
                                    RemoveAt(ref product, indexOfItem);
                                }
                                Console.WriteLine($"{count} eded {coffee.Name} satildi. Gelir {Totalincome}");
                                return true;
                            }
                            break;
                        }
                    case "Tea":
                        {
                            Tea teaa = (Tea)item;
                            if (teaa.Name != name)
                            {
                                Console.WriteLine("Bu caydan yoxdur");
                                return false;
                            }
                            else if (teaa.Count < count && teaa.Name == name)
                            {
                                Console.WriteLine("Bu caydan yeterli qeder yoxdur");
                                return false;
                            }
                            else if (teaa.Name == name)
                            {
                                Totalincome += teaa.Price * count;
                                teaa.Count -= count;
                                int indexOfItem = Array.IndexOf(product, item);
                                if (teaa.Count == 0)
                                {
                                    RemoveAt(ref product, indexOfItem);
                                }
                                Console.WriteLine($"{count} eded {teaa.Name} satildi. Gelir {Totalincome}");
                                return true;
                            }

                            break;
                        }
                    default:
                        break;
                }
            }

            return true;

        }
    }
}








// Shop classiniz olsun icinde productlarin arrayi olsun. TotalIncome propertysi olsun
// Bundan elave COffee, Tea classlariniz olsun Name ve count ve price proplari olsun ikisinde de .
// Shopdaki produclar yanliz Tea ve Cofee ola biler.Console application acilanda
// menuda 2 secim cixsin. 1. Product elave edin; 2. Product satin;
// 1 daxil etdikde istifadeciden Name , Price  ,count ve producttype alib productlara elave olunsun
// producttype olaraq c ve ya t daxil edebiler. eger c daxil edibse Coffee , t daxil edibse Tea obyekti elave edin
// ve yeniden menuya qayitsin. Name-i eyni olan product elave oluna bilmesin. eger Americano adli product
// varsa ikinci Americano producti elave etmek isteseler. Bu Product artiq var cap olunsun
// 2. daxil etdikde istifadeciden satilacaq mehsulun adini ve sayini alinib satis olunsun
// ve yeniden menu acilsin
// ve TotalIncome buna uygun artsin. Meselen new Coffee{Name: "Americano", Price : 6.50, Count : 3}
// productu elave etmisem. 2 dene americano satisi olunsa 13 manat gelirim. olmalidir.
// ve Americanonun sayi 1 -e dusmelidir, Eger istifadecinin istediyi count qeder yoxdursa. yoxdur yazilib
// yeniden menuya qayitmalidir
