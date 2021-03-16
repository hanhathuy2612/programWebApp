﻿using eShopSolution.Data.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace eShopSolution.Data.Entities
{
    public class Promotion
    {
        public int Id { get; set; }
        public DateTime FromDate{ get; set; }
        public DateTime ToDate{ get; set; }
        public bool AppleForAll{ get; set; }
        public decimal DiscountPercent { get; set; }
        public decimal DiscountAmount { get; set; }
        public int ProductIds { get; set; }
        public int ProductCategotyIds { get; set; }
        public Status Status{ get; set; }
        public string Name { get; set; }

    }
}
