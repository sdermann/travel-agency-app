using System;
using TravelAgency.DAl;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace TravelAgency.Models
{
    //Контора VISIT EASY - это турагентства, клиенты, обновления, акции, заказы
    [Serializable]
    public class VisitEasy 
    {


            public List<Agency> Agencies { private set; get; }
            public List<Client> Clients { private set; get; }
            public List<Admin> Admins { private set; get; }
            public List<FutureTrip> FutureTrips { private set; get; }
            public List<HotSale> HotSales { private set; get; }
            public List<Order> Orders { private set; get; }

            public VisitEasy()
            {
                Agencies = new List<Agency>();
                Clients = new List<Client>();
            Admins = new List<Admin>();
                FutureTrips = new List<FutureTrip>();
                HotSales = new List<HotSale>();
                Orders = new List<Order>();
            }

            public void FillTestData(int n)
        {
           
            // Agencies
            Agencies = new List<Agency>();
            for (int i = 0; i < n; i++)
            {
                List<Trip> Trips = new List<Trip>();
                for (int o = 0; o < 5; o++)
                {
                    Trips.Add(new Trip()
                    {
                        Location = $"{i}",
                        Price = i,
                        AdditionalService = $"{i}",
                        Accomodation = $"{i}",
                        Host = $"{i}",
                    }) ; 
                }
                var ps = new List<Portion>();
                for (int j = 0; j < 5; j++)
                {
                    ps.Add(new Portion { Trip = Trips[(j)], Amount = j });
                }
                
                Agencies.Add(new Agency(ps, $"Agency{i}", i * 10,i)) ;
            }
            // Clients
            Clients = new List<Client>();
            for (int i = 1; i <= n; i++)
            {
                Clients.Add(new Client { Name = $"Client{i}", Password = "123" });
            }
            //Admins
            // Clients
            Admins = new List<Admin>();
            for (int i = 1; i <= n; i++)
            {
                Admins.Add(new Admin { Name = $"Admin{i}", Password = "123" });
            }
            //Future trips
            FutureTrips = new List<FutureTrip>();
            for (int i = 0; i < 5; i++)
            {
                List<Trip> Trips = new List<Trip>();
                for (int o = 0; o < 5; o++)
                {
                    Trips.Add(new Trip()
                    {
                        Location = $"{i}",
                        Price = i,
                        AdditionalService = $"{i}",
                        Accomodation = $"{i}",
                        Host = $"{i}",
                    });
                }
                var ps = new List<Portion>();
                for (int j = 0; j < 5; j++)
                {
                    ps.Add(new Portion { Trip = Trips[(j) ], Amount = j });
                }
                FutureTrips.Add(new FutureTrip(ps));
            }
            //Hot Sales
            HotSales = new List<HotSale>();
            for (int i = 0; i < n - 5; i++)
            {
                List<Trip> Trips = new List<Trip>();
                for (int o = 0; o < 5; o++)
                {
                    Trips.Add(new Trip()
                    {
                        Location = $"{i}",
                        Price = i,
                        AdditionalService = $"{i}",
                        Accomodation = $"{i}",
                        Host = $"{i}",
                    });
                }
                var ps = new List<Portion>();
                for (int j = 0; j < 5; j++)
                {
                    ps.Add(new Portion { Trip = Trips[(j)], Amount = j });
                }
                DateTime x = new DateTime(2020, 5, 1, 8, 30, 52);
                HotSales.Add(new HotSale(ps,x));
            }
            // Orders
            Orders = new List<Order>();
            for (int i = 0; i < n - 5; i++)
            {
                List<Trip> Trips = new List<Trip>();
                for (int o = 0; o < 5; o++)
                {
                    Trips.Add(new Trip()
                    {
                        Location = $"Location{i}",
                        Price = i,
                        AdditionalService = $"{i}",
                        Accomodation = $"{i}",
                        Host = $"{i}",
                    });
                }
                var ps = new List<Portion>();
                for (int j = 0; j < 5; j++)
                {
                    ps.Add(new Portion { Trip = Trips[(j)], Amount = j });
                }
                Orders.Add(new Order(ps, Clients[i],DateTime.Now + TimeSpan.FromDays(i)));
            }
        }


        //////////////////////////////////////////////
        public void Save()
        {
            new Dao(this).Save();
        }

        public void Load()
        {
            new Dao(this).Load();
        }
    }
}
