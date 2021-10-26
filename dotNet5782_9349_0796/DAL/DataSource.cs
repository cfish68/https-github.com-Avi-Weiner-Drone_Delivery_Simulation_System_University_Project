﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DalObject
{
    class DataSource
    {
        class Config
        {
            /// <summary>
            /// Index of first free element in DroneList. 
            /// </summary>
            public static int FreeDronei { get; set; } = 0;
            /// <summary>
            /// Index of first free element in StationList.
            /// </summary>
            public static int FreeStationi { get; set; } = 0;
            /// <summary>
            /// Index of first free element in CustomerList.
            /// </summary>
            public static int FreeCustomeri { get; set; } = 0;
            /// <summary>
            /// Index of first free element in ParcelList.
            /// </summary>
            public static int FreeParceli { get; set; } = 0;

            //Told to include the below field in exercise 1 but I am not sure what it is.
            //static int PackagesId;
        }

        static IDAL.DO.Drone[] DroneList = new IDAL.DO.Drone[10];
        static IDAL.DO.Station[] StationList = new IDAL.DO.Station[5];
        static IDAL.DO.Customer[] CustomerList = new IDAL.DO.Customer[100];
        static IDAL.DO.Parcel[] ParcelList = new IDAL.DO.Parcel[1000];

        /// <summary>
        /// Initialie all the arrays according to exercise 1 specs.
        /// </summary>
        public static void Initialize()
        {
            var rand = new Random();

            //2 base stations
            for (int i = 0; i < 2; i++)
            {
                //StationList[i].Id = rand.Next(10000,99999);

                StationList[i].Id = Config.FreeStationi;
                //Random double latitude between -90 and 90
                StationList[i].Latitude = rand.NextDouble() * 180 - 90;
                //Random double longitude between -180 and 180
                StationList[i].Longitude = rand.NextDouble() * 360 - 180;
                
            //public int Id { get; set; }
            //public int Name { get; set; }
            //public double Longitude { get; set; }
            //public double Latitude { get; set; }
            //public int ChargeSlots { get; set; }
                //increment 
            }
            //5 drones
            for (int i = 0; i < 5; i++)
            {

            }
            //10 customers
            for (int i = 0; i < 10; i++)
            {

            }
            //10 packages
            for (int i = 0; i < 10; i++)
            {

            }
        }

        
}

