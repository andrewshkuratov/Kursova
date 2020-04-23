using System;
using Realms;
namespace Kursova
{
    public class Product : RealmObject
    {
        public string name { get; set; }
        public string date { get; set; }
        public string producer { get; set; }
        public double price { get; set; }
    }
}
