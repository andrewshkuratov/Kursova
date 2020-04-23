using System;
using Realms;
using System.Linq;
using System.Collections.Generic;
namespace Kursova
{
    public class Database
    {
        public Database()
        {
        }

        public void InsertToDb(string name, string date, string producer, double price)
        {
            var realm = Realm.GetInstance();
            Product product = new Product();
            product.name = name;
            product.date = date;
            product.producer = producer;
            product.price = price;
            realm.Write( () => realm.Add(product) );
        }

        public List<Product> GetFromDb(string param)
        {
            if(param == "")
            {
                var realm = Realm.GetInstance();
                var products = realm.All<Product>();
                return products.ToList();
            } else
            {
                var realm = Realm.GetInstance();
                var products = realm.All<Product>().Where(d=>d.name.Contains(param));
                return products.ToList();
            }
            
        }

        public void RemoveAll()
        {
            var realm = Realm.GetInstance();
            try
            {
                realm.Write( () => realm.RemoveAll());
            } catch (Realms.Exceptions.RealmInvalidObjectException e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
