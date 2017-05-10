using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Azure.WebJobs;

namespace WebJobs.TableStorage
{
    public class Functions
    {
        public static void AddEvents([Table("events")] ICollector<Event> tableBinding, TextWriter logger)
        {
            var qty = 10000;

            for (int i = 0; i < qty; i++)
            {
                tableBinding.Add(new Event
                {
                    PartitionKey = "sensor",
                    RowKey = i.ToString(),
                    Time = DateTime.UtcNow,
                    Name = "Event" + i.ToString()
                });

                logger.WriteLine("Added event #{0}", i);
            }
        }

        public static void ReadTable([Table("events")] IQueryable<Event> tableBinding, TextWriter logger)
        {
            var entities = tableBinding.ToList();
            entities.ForEach(entity => logger.WriteLine("PK: {0}, RK: {1}", entity.PartitionKey, entity.RowKey));
        }
    }
}
