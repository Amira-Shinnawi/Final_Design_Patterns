using System;
using System.Collections;
using System.Collections.Generic;

namespace Final_Design_Patterns.Behavioural_Pattern
    /*.Structural_Pattern.Proxy*/
    /*.Structural_Pattern.Facade*/
    /*.Structural_Pattern.Bridge*/
    /*.Adapter*/
    /*.FactoryMethod*/
    /*.Singleton*/
{
    class Program
    {
        static void Main(string[] args)
        {
            //Singleton

            //Single singleton1 = Single.GetInstance();
            //singleton1.showMessage();
            //singleton1.Addone();
            //Console.WriteLine(singleton1.count);//1

            //Single singleton2 = Single.GetInstance();
            //singleton2.showMessage();
            //singleton2.Addone();//when deleted this ,will be print: 1
            //Console.WriteLine(singleton2.count);//2

            /*####################################################################*/

            //FactoryMethod

            //Sandwich sandwich1 = sandwichFactory.createSandwich(sandwichFactory.Cheese_Burger);
            //sandwich1.prepare();

            //Sandwich sandwich2 = sandwichFactory.createSandwich(sandwichFactory.Chicken_Burger);
            //sandwich2.prepare();

            /*####################################################################*/

            //Adapter
            //Vehicle car = new Car();
            //car.acceleration();
            //car.Break();
            //car.soundHorn();

            //Console.WriteLine(" ");

            //Vehicle vehicle = new BicycleAdapter(new Bicycle());
            //vehicle.acceleration();
            //vehicle.Break();
            //vehicle.soundHorn();

            /*####################################################################*/

            //Bridge

            //Shape shape1 = new Triangle(new GreenColor());
            //shape1.applyColor();

            //Console.WriteLine("");

            //Shape shape2 = new Triangle(new RedColor());
            //shape2.applyColor();

            /*####################################################################*/

            //Facade
            //ShopMaker shopMaker = new ShopMaker();
            //Console.WriteLine("Enter your choise ");

            //Console.WriteLine("1:Nokia");
            //Console.WriteLine("2:IPhone");
            //Console.WriteLine("3:Samsung");

            //int choise = Convert.ToInt32(Console.ReadLine());
            //if (choise == 1)
            //{
            //    shopMaker.nokiaPhoneSale();
            //}
            //else if (choise == 2)
            //{
            //    shopMaker.iphonePhoneSale();
            //}
            //else if (choise == 3)
            //{
            //    shopMaker.samsungPhoneSale();
            //}

            //another sol

            //switch (choise)
            //{
            //    case 1:

            //        shopMaker.nokiaPhoneSale();
            //        break;
            //    case 2:

            //        shopMaker.iphonePhoneSale();
            //        break;
            //    case 3:

            //        shopMaker.samsungPhoneSale();
            //        break;
            //    default:
            //        Console.WriteLine("Nothing You purchased");
            //        break;
            //}

            /*####################################################################*/
            //Proxy

            //IList blocklist = new List<string>() { "Instigram","Twitter", "Facebook", "Youtube" };
            //internetServiceProvider serviceProvider = new internetProxy();

            //foreach(string list in blocklist)
            //{
            //    Console.WriteLine(serviceProvider.ServeSite(list));
            //}

            /*####################################################################*/

            //Observer
            Student student1 = new Student(name:"Ali");
            Student student2 = new Student(name:"Amira");
            Student student3 = new Student(name:"Amir");

            Course java = new Course(name:"Java Course");
            java.Subscribe(student1);
            java.Subscribe(student2);
            java.Subscribe(student3);

            java.unSubscribe(student3);
            java.setAvailable(false);
        }
    }
}
