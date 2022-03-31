using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp12.Models
{
    class Bicycle:Vehicle
    {
        public int PedalKind { get; set; }
        public Bicycle(double DriveTime, double DrivePath, int HorsePower, int TankSize, int CurrentOil, string Fueltype, int leftFuelAmount, int WhellTicknese)
        {
            this.DriveTime = DriveTime;
            this.DrivePath = DrivePath;
            this.HorsePower = HorsePower;
            this.TankSize = TankSize;
            this.CurrentOil = CurrentOil;
            this.Fueltype = Fueltype;
            this.leftFuelAmount = leftFuelAmount;
            this.WhellTicknese = WhellTicknese;
        }
    }
}
