using System;

namespace ConsoleApp21
{
    class Program
    {
        static void Main(string[] args)
        {
            Shop shop = new Shop();
            
            while (true)
            {

                Console.WriteLine("1.Product elave edin  2.Product satin");
                string num = Console.ReadLine();
                bool isInt = int.TryParse(num, out int menu);

                if (isInt)
                {



                    switch (menu)
                    {

                        case 1:
                            TYPE:
                            Console.WriteLine("Product tipini qeyd edin :   Coffe or Tea?");
                            string type = Console.ReadLine();
                            if (type.ToUpper() != Type.COFFE.ToString() && type.ToUpper() != Type.TEA.ToString())
                            {
                                Console.WriteLine("Product tipi duzgun daxil edilmeyib ");
                                goto TYPE;
                            }
                            Console.WriteLine("Adi daxil edin ");
                            string name = Console.ReadLine();
                            Console.WriteLine("qiymet daxil edin");
                            string price = Console.ReadLine();
                            double pr = double.Parse(price);
                            Console.WriteLine("Say daxil edin");
                            string cnt = Console.ReadLine();
                            int count = int.Parse(cnt);
                            if (type.ToUpper() == Type.COFFE.ToString())
                            {
                                Coffe cofe = new Coffe(name, count, pr);
                               
                                bool isAdded = shop.Add(cofe);

                                if (isAdded)
                                {
                                    Console.WriteLine($"{cofe.Name} coffesi elave olundu");
                                }
                            }
                            
                            else if (type.ToUpper() == Type.TEA.ToString())
                            {
                                Tea tea = new Tea(name, count, pr);
                                bool isAdded = shop.Add(tea);


                                if (isAdded)
                                {
                                    Console.WriteLine($"{tea.Name} cayi elave olundu");
                                }
                            }
                            break;
                        case 2:
                            //Console.WriteLine("Product tipini qeyd edin :   Coffe or Tea?");
                            //string typee = Console.ReadLine();
                            //if (typee.ToUpper() != Type.COFFE.ToString().ToUpper() && typee.ToUpper() != Type.TEA.ToString().ToUpper())
                            //{
                            //    Console.WriteLine("Product tipi duzgun daxil edilmeyib ");
                               
                            //}
                            Console.WriteLine("Almaq istediyiniz meshulun adini qeyd edin ");
                            string namee = Console.ReadLine();
                            Console.WriteLine("Almaq istediyiniz meshulun sayini qeyd edin");
                            string cont = Console.ReadLine();
                            int connt = int.Parse(cont);
                            shop.Sell(namee, connt);
                            break;
                        default:
                            break;
                    }



                }

            }

        }
        enum Type
        {
            COFFE,
            TEA

        }

    }
}

