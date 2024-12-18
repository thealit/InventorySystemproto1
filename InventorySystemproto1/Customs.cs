﻿using System;
using System.ComponentModel;
namespace InventorySystemproto1
{
    public class Customs
    {
        public class InventoryItem
        {
            string brand, model, category;
            decimal price;
            int stock;

            public InventoryItem(string brand, string model, string category, decimal price, int stock)
            {
                this.brand = brand;
                this.model = model;
                this.category = category;
                this.price = price;
                this.stock = stock;
            }

            public string Brand
            {
                get { return brand; }
                set { brand = value; }
            }

            public string Model
            {
                get { return model; }
                set { model = value; }
            }

            public string Category
            {
                get { return category; }
                set { category = value; }
            }

            public decimal Price
            {
                get { return price; }
                set { price = value; }
            }

            public int Stock
            {
                get { return stock; }
                set { stock = value; }
            }
        }

        public class OrderItem
        {
            string id, brand, model, category, orderStatus;
            int quantity;
            DateTime dateAdded;


            public OrderItem(string id, string brand, string model, string category, int quantity, DateTime dateAdded, string orderStatus)
            {
                this.id = id;
                this.brand = brand;
                this.model = model;
                this.category = category;
                this.orderStatus = orderStatus;
                this.dateAdded = dateAdded;
                this.quantity = quantity;
            }

            public string ID
            {
                get { return id; }
                set { id = value; }
            }

            public string Brand
            {
                get { return brand; }
                set { brand = value; }
            }

            public string Model
            {
                get { return model; }
                set { model = value; }
            }

            public string Category
            {
                get { return category; }
                set { category = value; }
            }

            [DisplayName("Order Status")]
            public string OrderStatus
            {
                get { return orderStatus; }
                set { orderStatus = value; }
            }

            [DisplayName("Date Added")]
            public DateTime DateAdded
            {
                get { return dateAdded; }
                set { dateAdded = value; }
            }

            public int Quantity
            {
                get { return quantity; }
                set { quantity = value; }
            }
        }

        public class SalesChart
        {
            int year;
            string month;
            decimal sales;


            public SalesChart(int year, string month, decimal sales)
            {        

                    this.year = year;
                    this.month = month;
                    this.sales = sales;
            }

            public int Year {
                get { return year; } 
                set { year = value; }   
            }

            public string Month
            {
                get { return month; }
                set { month = value; }
            }

            public decimal Sales
            {
                get { return sales; }
                set { sales = value; }
            }

        }
    }
}
