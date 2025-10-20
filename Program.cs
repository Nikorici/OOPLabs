using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPlab2
{
    class Program
    {

        public static void Main()
        {   // initializam vagoanele
            Wagon station_wagon_budapest_1 = new Wagon("aur", 400);
            Wagon station_wagon_budapest_2 = new Wagon("silver", 200);
            Wagon station_wagon_budapest_3 = new Wagon("bronze", 200);
            Wagon station_wagon_buhuresti_1 = new Wagon("piatra", 1500);
            Wagon station_wagon_buhuresti_2 = new Wagon("minereuri", 200);
            Wagon station_wagon_buhuresti_3 = new Wagon("carbune", 199);

            //cream listele pentru wagoane 
            List<Wagon> listOfStationWagonsForBudapest = new List<Wagon>();
            List<Wagon> listOfStationWagonsForBuhuresti = new List<Wagon>();
            List<Wagon> listOfWagons = new List<Wagon>();
            List<Wagon> listofStationWagonsForComrat = new List<Wagon>();
            List<Wagon> listOfAllWagons = new List<Wagon>();


            listOfStationWagonsForBudapest.Add(station_wagon_budapest_1);
            listOfStationWagonsForBudapest.Add(station_wagon_budapest_2);
            listOfStationWagonsForBudapest.Add(station_wagon_budapest_3);
            listOfStationWagonsForBuhuresti.Add(station_wagon_buhuresti_1);
            listOfStationWagonsForBuhuresti.Add(station_wagon_buhuresti_2);
            listOfStationWagonsForBuhuresti.Add(station_wagon_buhuresti_3);


            //lista pentru statii
            List<Station> listOfStations = new List<Station>();

            //initializam statiile
            Station Station1 = new Station("Budapest", listOfStationWagonsForBudapest, 0, 1);
            Station Station2 = new Station("Buhuresti", listOfStationWagonsForBuhuresti, 0, 2);
            Station Station3 = new Station("Comrat", listofStationWagonsForComrat, 0, 1);

            //adaugam obiectele in liste
            listOfStations.Add(Station1);
            listOfStations.Add(Station2);
            listOfStations.Add(Station3);
            //initializam trenul
            Train Thomas = new Train(96, 8, listOfStations);
            //lista cu toate vagoanele
            listOfAllWagons.Add(station_wagon_buhuresti_3);
            listOfAllWagons.Add(station_wagon_budapest_3);
            listOfAllWagons.Add(station_wagon_buhuresti_2);
            listOfAllWagons.Add(station_wagon_buhuresti_1);
            listOfAllWagons.Add(station_wagon_budapest_1);
            listOfAllWagons.Add(station_wagon_budapest_2);




            Station1.loadTrain(Thomas);
            foreach (Wagon wagon in Thomas.listOfWagons)
            {
                Console.WriteLine(wagon.wagonNumber);
            }

            Station3.unloadTrain(Thomas);


            Console.WriteLine(Thomas.listOfWagons.Count());
            Console.WriteLine(Station3.stationWagons.Count());






        }
    }
}