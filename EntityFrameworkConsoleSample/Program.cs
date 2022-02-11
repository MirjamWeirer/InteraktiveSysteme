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
            //CreateDatabaseAddCustomer();
            ArbeitenMitContext();
        }

        public static void ArbeitenMitContext()
        {
            CoustomerContextV3 ctx = new CoustomerContextV3();
            //Suche anhand von Primary Key --> nur ein Objekt als Return
            var customerNr1 = ctx.Customers.Find(1);
            customerNr1.Points = 5;

            //beliebige Suche -- Liste
            var customerJasi = ctx.Customers.Where(c => c.Firstname == "Jasi");

            foreach(var jasi in customerJasi)
            {
                jasi.Points = 15;
            }

            ctx.SaveChanges();
        }

        public static void CreateDatabaseAddCustomer()
        {
            CoustomerContextV3 ctx = new CoustomerContextV3();

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
