using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPattern.BadCode
{
    public class LogisticApp
    {
        public void PlanDelivery(string transportType)
        {
            if (transportType == "road")
            {
                Truck truck = new Truck();
                truck.Deliver();
            }
            else if (transportType == "sea")
            {
                Ship ship = new Ship();
                ship.Deliver();
            }
        }
    }
}
