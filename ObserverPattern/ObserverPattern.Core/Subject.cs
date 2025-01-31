﻿using System;
using System.Collections.Generic;

namespace ObserverPattern.ObserverPattern.Core
{
    public class Subject : ISubject
    {
        private List<IObserver> observers = new List<IObserver>();
        private string ProductName { get; set; }
        private int ProductPrice { get; set; }
        private string Availability { get; set; }

        public Subject(string productName, int productPrice, string availability) {
            ProductName = productName;
            ProductPrice = productPrice;
            Availability = availability;
        }

        public string getAvailability() {
            return Availability;
        }
        public void setAvailability(string availability) {
            this.Availability = availability;
            Console.WriteLine("Availability changed from Out of Stock to Available.");
            NotifyObservers();
        }

        public void RegisterObserver(IObserver observer) {
            observers.Add(observer);
        }

        public void RemoveObserver(IObserver observer) {
            observers.Remove(observer);
        }

        public void NotifyObservers() {
            Console.WriteLine("Product Name :" + ProductName
                             + ", product Price : " + ProductPrice
                             + " is Now available. So notifying all Registered users ");
            Console.WriteLine();
            foreach (IObserver observer in observers)
            {
                observer.update(Availability);
            }
        }
    }
}
