﻿using Microsoft.WindowsAzure.Storage.Table;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebJobs.TableStorage
{
    public class Event : TableEntity
    {
        public DateTime Time { get; set; }
        public string Name { get; set; }

    }
}
