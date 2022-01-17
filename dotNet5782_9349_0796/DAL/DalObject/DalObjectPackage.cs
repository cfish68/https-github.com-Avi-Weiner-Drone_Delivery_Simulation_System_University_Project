﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DalObject
{
    public partial class DalObject : DalApi.IDAL
    {
        /// <summary>
        /// Receives Package Id and returns its index in packageList
        /// </summary>
        /// <param name="PackageId"></param>
        /// <returns></returns>
        public DO.Package GetPackage(int PackageId)
        {
            int i = DataSource.PackageList.FindIndex(x => x.Id == PackageId);
            if (i == -1)
                throw new DO.MessageException("Error: Package not found.");

            return DataSource.PackageList[i];
        }

        /// <summary>
        /// receiving a package to deliver
        /// </summary>
        public void AddPackage(int InputSender, int InputReceiver, DO.WeightCategory InputWeight, DO.Priority InputPriority)
        {
                DataSource.PackageList.Add(new DO.Package
                {
                    Id = DataSource.GetNextUniqueID(),
                    SenderId = InputSender,
                    ReceiverId = InputReceiver,
                    Weight = InputWeight,
                    Priority = InputPriority,
                    Requested = DateTime.Now,
                    DroneId = 0, //No drone assigned yet
                    Scheduled = null,
                    PickedUp = null,
                    Delivered = null

                });

        }

        /// <summary>
        /// Assigning a drone to a package
        /// </summary>
        /// <param name="PackageId"></param>
        /// <param name="DroneId"></param>
        public static void AssignDroneToPackage(int PackageId, int DroneId)
        {
            //Test if DroneId is valid
            int i = DataSource.DroneList.FindIndex(x => x.Id == DroneId);
            if (i == -1)
                throw new DO.MessageException("Error: Drone not found.");

            DO.Package P = DataSource.PackageList.Find(x => x.Id == PackageId);

            P.DroneId = DroneId;
            P.Scheduled = DateTime.Now;
        }

        /// <summary>
        /// Receives a package from Id PackageId and "drops it off" with a customer
        /// </summary>
        /// <param name="PackageId"></param>
        public static void PackageDropOff(int PackageId)
        {
            DO.Package P = DataSource.PackageList.Find(x => x.Id == PackageId);
            P.Delivered = DateTime.Now;
        }
    }
}