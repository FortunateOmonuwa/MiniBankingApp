using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPrinciple
{
    public class Vehicle : IVehicle
    {
        string IVehicle.Color { get; }
        public bool IsConvertible { get; }

        public void Move()
        {
            Console.WriteLine("Moving");
        }

        void IVehicle.Move()
        {
            throw new NotImplementedException();
        }
    }
}
