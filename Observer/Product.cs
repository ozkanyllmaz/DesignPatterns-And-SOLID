using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.Xml.Linq;

namespace Observer
{
    public class Product : ISubject
    {
        public string productName { get; set; }
        public int stock;

        // Abonelerin tutulduğu liste
        private List<IObserver> _observers = new List<IObserver>();

        public void Attach(IObserver observer)
            => _observers.Add(observer);

        public void Detach(IObserver observer)
            => _observers.Remove(observer);

        public void Notify()
        {
            foreach (var observer in _observers)
            {
                observer.Update($"{productName} ürünü tekrar stoklarda!");
            }
        }

        public void UpdateStock(int amount)
        {
            stock = amount;
            Console.WriteLine($"\n{productName} stok durumu değişti. Yeni Stok: {stock}");

            if (stock > 0)
            {
                Notify(); // Stok sıfırdan büyükse tüm abonelere bağır!
            }
        }
    }
}
