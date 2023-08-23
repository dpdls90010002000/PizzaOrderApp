using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yein_Pizza2
{
    public class Order
    {
        public string Name { get; set; }
        public double Number { get; set; }
        public int OrderedQuantity { get; set; }
        public string OrderedToppings { get; set; }
        public string OrderedSize { get; set; }
        public string OrderVege { get; set; }

        public string Coupon { get; set; }

        private double _taxAmount;
        private double _finalCost;

        public Order()
        {

            Name = "Unknown";
            Number = 0;
            OrderedQuantity = 0;
            OrderedToppings = "Unknown";
            OrderedSize = "Unknown";
            OrderVege = "Unknown";

        }

        public Order(string name, double number, int orderedQuantity, string orderedToppings, string orderedSize, string orderVege, string coupon)
        {
            Name = name;
            Number = number;
            OrderedQuantity = orderedQuantity;
            OrderedToppings = orderedToppings;
            OrderedSize = orderedSize;
            OrderVege = orderVege;
            Coupon = coupon;
        }
        public double FinalCost { get { return _finalCost; } }
        public double TaxAmount { get { return _taxAmount; } }

        public void CalculateCost()
        {
            double sizecost;
            double totalcost;
            double tax = 0.13;

            if(OrderVege == "Vegetarian")
            {


                if(OrderedSize == "Small")
                {
                    sizecost = 5.99;
                }
                else if(OrderedSize == "Medium")
                {
                    sizecost = 7.99;

                }else if(OrderedSize == "Large")
                {
                    sizecost = 10.99;

                }
                else
                {
                    sizecost = 13.99;
                }
            }
            else
            {
                
                if(OrderedSize == "Small")
                {
                    sizecost = 6.99;
                }
                else if(OrderedSize == "Medium")
                {
                    sizecost = 8.99;

                }else if(OrderedSize == "Large")
                {
                    sizecost = 12.99;

                }
                else
                {
                    sizecost = 15.00;
                }

                
            }


            if (!string.IsNullOrEmpty(OrderedToppings))
            {
                List<string> toppingList = new List<string>(OrderedToppings.Split(','));
                int numberOfToppings = toppingList.Count - 1;



                totalcost = (sizecost + (0.33 * numberOfToppings)) * OrderedQuantity;

            }
            else
            {
                totalcost = sizecost * OrderedQuantity;
            }


            if (Coupon == "OFFERSPECIAL")
            {
                double offerPrice = totalcost -(totalcost * 0.20);
                _taxAmount = Math.Round(offerPrice * tax,2);
                _finalCost = Math.Round(offerPrice + _taxAmount,2);
            }
            else if (Coupon =="JIGISHA")
            {
                _finalCost = 0;
            }
            else
            {

                _taxAmount = Math.Round(totalcost * tax,2);
                _finalCost = Math.Round(totalcost + _taxAmount, 2);
            }
                
        }


            

        }
    }

