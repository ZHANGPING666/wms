﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LHYS.WMS.Models.Home
{
    public class MenuBShow
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Nullable<int> OrderNumber { get; set; }
        public string Url { get; set; }
        public int MenuAId { get; set; }
    }
}