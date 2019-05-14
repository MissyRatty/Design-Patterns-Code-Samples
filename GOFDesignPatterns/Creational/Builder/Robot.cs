using System;
using System.Collections.Generic;

namespace GOFDesignPatterns.Creational.Builder
{
    public class Robot
    {
        private List<string> _parts = new List<string>();

        public void Add(string part)
        {
            _parts.Add(part);
        }

        public void Show()
        {
            Console.WriteLine("\nRobot Parts ________________");
            foreach (var part in _parts)
            {
                Console.WriteLine(part);
            }
        }
    }
}
