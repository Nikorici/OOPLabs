using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPlab2
{
    public class Wagon
    {
        public string loadType;
        public double cappacity;
        public bool isLoaded;
        public static int counter = 1;
        public int wagonNumber;



        public Wagon(string loadType, double cappacity)
        {
            this.loadType = loadType;
            this.cappacity = cappacity;
            this.isLoaded = false;
            wagonNumber = counter++;
        }
        public int getWagonNumber()
        {
            return wagonNumber;
        }
        public void setLoadType(string loadType)
        {
            this.loadType = loadType;
        }

    }
}
