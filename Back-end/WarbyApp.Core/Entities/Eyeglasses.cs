﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarbyApp.Core.Entities
{
    public class Eyeglasses:BaseEntity
    {
        public string Name { get; set; }
        public string Material { get; set; }
        public decimal CostPrice { get; set; }
        public decimal SalePrice { get; set; }
        public decimal DiscountPercent { get; set; } = 0;
        public bool MenCategory { get; set; } = false;
        public bool WomenCategory { get; set; } = false;
        public bool AllCategory { get; set; } = false;
        public bool NewarrivalsCategory { get; set; } = false;
        public bool BestsellersCategory { get; set; } = false;
        public bool ClassicmetalsCategory { get; set; } = false;
        public bool AutumnaltonesCategory { get; set; } = false;
        public bool BoldshapesCategory { get; set; } = false;
        public string Description1 { get; set; }
        public string Description2 { get; set; }
        public List<EyeglassesImage> EyeglassesImages { get; set; }
        public List<EyeglassesWidthCategory> EyeglassesWidthCategories { get; set; }
        public List<EyeglassesShapeCategory> EyeglassesShapeCategories { get; set; }
        public List<EyeglassesMaterialCategory> EyeglassesMaterialCategories { get; set; }
        public List<EyeglassesColorCategory> EyeglassesColorCategories { get; set; }
        public List<EyeglassesPriceCategory> EyeglassesPriceCategories { get; set; }
        public List<EyeglassesPrescriptionCategory> EyeglassesPrescriptionCategories { get; set; }
        public List<EyeglassesFeaturesCategory> EyeglassesFeaturesCategories { get; set; }
    }
}
