using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EHealth.Shared.Models;

namespace EHealth.User.Web.ViewModels
{
    public class OrderSummaryViewModel
    {
        public double OrderTotal { get; set; }

        public List<string> MedicinesNames { get; set; }

        public List<Medicine> Medicines { get; set; }
    }
}
