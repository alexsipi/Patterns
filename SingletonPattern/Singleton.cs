﻿using System;
using System.Collections.Generic;
using System.Text;

namespace SingletonPattern
{
    public class Singleton
    {
        private static Singleton _instance;

        public static Singleton Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new Singleton();
                }

                return _instance;
            }
        }

        public void print() {
            Console.WriteLine("Singleton class");
        }
    }
}
