﻿using System;
using System.Collections.Generic;

namespace CoffeeRewardsApp
{
    class Program
    {

        private static List<Customer> customer = new List<Customer>();

        static void Main(string[] args)

        {
            Console.ForegroundColor = ConsoleColor.Blue;
            //Console.WriteLine("************");
            Console.WriteLine("****** Welcome to my Coffee rewards application ******");

            
            Customer paul = new Customer(004, "Paul", "Kavuma", "paul@gmail.com", 12);
 
            customer.Add(paul);

            //customer.Sort();

            //foreach (var Customer in customer)
            //{
            //    customer.DisplayCustomerDetails();
            //}
            //customer.LastName = "Kavuma";

            //paul.DisplayCustomerDetails();
            //double total = paul.CalculateTotalSpent();
            //paul.CalculateRewards();
            

            Console.ReadLine();
        }

    }
}
