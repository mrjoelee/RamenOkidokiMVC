﻿using System.Collections.Generic;

using Data.Models.FoodMenus;

using Data.Models.User;
using Data.Repositories;

namespace Data.Models
{
    public class Globals
    {
        //  private DatabaseRepository databaseRepository { get; set; }
        public static bool DisplayAddressForm { get; set; }
        public static bool DisplayHoursForm { get; set; }
        public static bool DisplayAddOnsForm { get; set; }
        public static bool UserSignedIn { get; set; }

      
        public static FoodCategory CurrentCategory { get; set; }
        

        //public static int OrderTotalItems { get; set; }
        //public static decimal OrderSubTotalCost { get; set; }
        //public static decimal OrderTotalCost
        //{
        //    get
        //    {
        //        return OrderSubTotalCost + TotalSalesTax;
        //    }
        //}

        //public static decimal TotalSalesTax
        //{
        //    get
        //    {
        //        return OrderSubTotalCost * SalesTax;
        //    }
        //}

        public static decimal SalesTax = 0.0625m;

        public static string SalesTaxString
        {
            get
            {
                return $"{ SalesTax * 100}%";
            }
        }


      

        public static List<FoodCategory> FoodCategoryList { get; set; }

        public static List<FoodItem> FoodItemList { get; set; }

        //    public static FoodCategory FoodCategory { get; set; }
    //    public static List<OrderItem> CartItemList { get; set; }

        public static void GetFoodItemsAndCategories()
        {
            DatabaseRepository databaseRepository = new DatabaseRepository();
            FoodCategoryList = databaseRepository.GetFoodCategories();
            FoodItemList = databaseRepository.GetFoodItems();
        }

        public Globals()
        {

            FoodCategoryList = new List<FoodCategory>();
            FoodItemList = new List<FoodItem>();
            //  FoodCategory = new FoodCategory();
        //    CartItemList = new List<OrderItem>();
        }
    }
}
