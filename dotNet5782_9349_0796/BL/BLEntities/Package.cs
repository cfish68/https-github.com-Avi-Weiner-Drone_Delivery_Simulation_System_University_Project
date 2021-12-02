﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IBL
{
    namespace BO
    {
        public class Package
        {
            public int Id { get; set; }
            public Customer Sender { get; set; }
            public Customer Receiver { get; set; }
            public IDAL.DO.WeightCategory Weight { get; set; }
            public IDAL.DO.Priority Priority { get; set; }
            /// <summary>
            /// Drone changed to just droneId due to possible creation
            /// of endless loop between BL Package and BL Drone.
            /// </summary>
            public int DroneId { get; set; } 
            /// <summary>
            /// Time package was created (same as requested in DAL)
            /// </summary>
            public DateTime? CreationTime { get; set; }
            /// <summary>
            /// Time assigned to a drone (same as scheduled in DAL)
            /// </summary>
            public DateTime? AssigningTime { get; set; }
            /// <summary>
            /// Same as PickedUp in DAL
            /// </summary>
            public DateTime? CollectingTime { get; set; }
            /// <summary>
            /// Same as Delivered in DAL
            /// </summary>
            public DateTime? DeliveringTime { get; set; }

            public override string ToString()
            {
                string toReturn = "Package ID: " + Id + "\nSender: " + Sender.ToString() +
                    "\nReceiver: " + Receiver.ToString() + "\nWeight: " + Weight.ToString() + 
                    "\nPriority: " + Priority.ToString() + "\nDrone ID: " + DroneId + 
                    "\nCreation time: " + CreationTime + "\n Assigning time: " + AssigningTime 
                    + "\ncollecting time: " + CollectingTime + "\nDelivering time: " + DeliveringTime + "\n";
                return toReturn;
            }

        }
    }
}
