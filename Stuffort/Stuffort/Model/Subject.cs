﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using System.Threading.Tasks;
using SQLite;

namespace Stuffort.Model
{
    public class Subject
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }

        [MaxLength(50)]
        public string Name { get; set; }

        public DateTime AddedTime { get; set; }
    }
}