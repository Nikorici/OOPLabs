using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPlab2
{
    public class Station
    {
        public string name;
        public List<Wagon> stationWagons;
        public int trainsNumber;
        public int maxLoadingTrainsNumber;
        public Train currentTrain;
        public Station(string name, List<Wagon> stationWagons, int trainsNumber, int maxLoadingTrainsNumber)
        {
            this.name = name;
            this.stationWagons = stationWagons;
            this.trainsNumber = trainsNumber;
            this.maxLoadingTrainsNumber = maxLoadingTrainsNumber;
        }
        public void isOccupied()
        {
            if (this.maxLoadingTrainsNumber == trainsNumber)
            {
                Console.WriteLine("There is a max trains numbar");
            }
            else
            {
                Console.WriteLine("Is free");
            }
        }
        public void loadWagons()
        {
            foreach (Wagon item in this.stationWagons)
            {
                item.isLoaded = true;
            }

        }
        public void loadTrain(Train train)
        {
            if (train.listOfStations[0].name == this.name)
            {
                train.attach(stationWagons);
                stationWagons.Clear();
                List<Station> temp = new List<Station>();
                for (int i = 1; i < train.listOfStations.Count; i++)
                {
                    temp.Add(train.listOfStations[i]);
                }
                train.listOfStations.Clear();
                train.listOfStations = temp;
            }
            else
            {
                Console.WriteLine("Trenul dat nu este la statie");
            }
        }
        public void unloadTrain(Train train)
        {
            this.stationWagons = train.listOfWagons;
            train.detach();

        }
    }

}
