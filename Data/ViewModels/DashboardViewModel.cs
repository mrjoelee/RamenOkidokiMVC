﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data.Models;
using Data.Models.DashboardData;

namespace Data.ViewModels
{
    public class DashboardViewModel
    {
        public BusinessLocation BusinessLocation { get; set; }
        public HoursOfOperation HoursOfOperation { get; set; }
        public AddOnCharges AddOns { get; set; }

        public List<Review> Reviews { get; set; }

        public int NewRating { get; set; }

        public DashboardViewModel()
        {
            BusinessLocation = DummyData.GetBusinessLocation();

            HoursOfOperation = DummyData.GetHoursOfOperation();

            AddOns = new AddOnCharges();

            //   AddOns.SalesTaxRate  = Globals.SalesTax.ToString();

            //   AddOns.DeliveryCharge = "$5.00";

        }
    }

}
