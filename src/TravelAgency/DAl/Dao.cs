using TravelAgency.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;


namespace TravelAgency.DAl
{
   
        public class Dao
        {
            VisitEasy store;
            const string filePath = "store.bin";

            public Dao(VisitEasy store)
            {
                this.store = store;
            }

            public void Save()
            {
                using (Stream stream = File.Create(filePath))
                {
                    var serializer = new BinaryFormatter();
                    serializer.Serialize(stream, store);
                }
            }

            public void Load()
            {
                using (Stream stream = File.OpenRead(filePath))
                {
                    var serializer = new BinaryFormatter();
                    VisitEasy st = (VisitEasy)serializer.Deserialize(stream);

                    Copy(st.Agencies, store.Agencies);
                    Copy(st.Clients, store.Clients);
                    Copy(st.FutureTrips, store.FutureTrips);
                    Copy(st.HotSales, store.HotSales);
                    Copy(st.Orders, store.Orders);


            }

            void Copy<T>(List<T> from, List<T> to)
                {
                    to.Clear();
                    to.AddRange(from);
                }
            }
        }
    
}
