using EntityFrameworkConsoleSample.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkConsoleSample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1. Nuget-Paket EntityFramework (DBContext, DBSet)
            //2. Code First: Entity Model - class Customer { CustomerId ...
            //3. CustomerContext : DBContext --- DBSet
            //CRUD
            CreateDatabaseAddCustomer();
        }

        public static void CreateDatabaseAddCustomer()
        {
            CoustomerContextV2 ctx = new CoustomerContextV2();

            Customer myFirstCustomer = new Customer();
            //myFirstCustomer.CustomerId -- Identitywert
            myFirstCustomer.Firstname = "Jasi";
            myFirstCustomer.Lastname = "Feigel";
            myFirstCustomer.Points = 12;

            //Objekt dem DBSet hinzufügen
            ctx.Customers.Add(myFirstCustomer);
            //Objekt hat danach Zustand "Attached"
            ctx.SaveChanges(); //Übertragt alle änderungen (Insert, Update, Deletes) an DB
        }
    }
}
