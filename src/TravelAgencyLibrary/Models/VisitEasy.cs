using TravelAgency.DAl;
using System;
using System.Collections.Generic;
using System.Drawing;
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
            public List<Order> Orders { private set; get; }

            public VisitEasy()
            {
                Agencies = new List<Agency>();
                Clients = new List<Client>();
                Admins = new List<Admin>();
                Orders = new List<Order>();
            }


        // If any data changed.
        public bool IsDirty;
        public void FillTestData(int n)
            {
           
            // Agencies
            Agencies = new List<Agency>();
            var noImage = new Bitmap(Path.GetFullPath("palm.png"));
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
                    });
                }
                var ps = new List<Portion>();
                for (int j = 0; j < 5; j++)
                {
                    ps.Add(new Portion { Trip = Trips[(j)], Amount = j,OnSaleOrInFuture = "OnSale"});
                }
                
                Agencies.Add(new Agency($"Name{i}","Good",0,0,ps,noImage)) ;
            }
            // Clients
            Clients = new List<Client>();
            for (int i = 1; i <= n; i++)
            {
                Clients.Add(new Client ($"Client{i}", 123,"E-mail" ));
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

        public void AddAgency(Agency agency)
        {
            Agencies.Add(agency);
        }

        //////////////////////////////////////////////
        public void Save()
        {
            new Dao(this).Save();
            IsDirty = false;
        }

        public void Load()
        {
            new Dao(this).Load();
            IsDirty = false;
        }
    }
}
