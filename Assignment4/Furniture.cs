using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4
{
    
     internal class Furniture
    {
        public int orderID;
        public int quantity;
        public int amount;
        public string orderDate;
        public string furnitureType;
        public string paymentMode;

        public Furniture(int orderID, int quantity, int amount, string orderDate, string furnitureType, string paymentMode)
        {
            this.orderID = orderID;
            this.quantity = quantity;
            this.amount = amount;
            this.orderDate = orderDate;
            this.furnitureType = furnitureType;
            this.paymentMode = paymentMode;
        }

    }

    class Chair : Furniture
    {
        string chairType;
        string purpose;
        int rate;

        public Chair(int orderID, int quantity, int amount, string orderDate, string furnitureType, string paymentMode, string chairType, string purpose, int rate) : base(orderID, quantity, amount, orderDate, furnitureType, paymentMode)
        {
            this.chairType = chairType;
            this.purpose = purpose;
            this.rate = rate;
        }


    }

    class WoodenChair : Chair
    {
        string woodType;

        public WoodenChair(int orderID, int quantity, int amount, string orderDate, string furnitureType, string paymentMode, string chairType, string purpose, int rate, string woodType) : base(orderID, quantity, amount, orderDate, furnitureType, paymentMode, chairType, purpose, rate)
        {
            this.woodType = woodType;
        }
        public void Getdata()
        {
            int a = Console.Read();


        }

    }

    class SteelChair : Chair
    {
        string steelType;

        public SteelChair(int orderID, int quantity, int amount, string orderDate, string furnitureType, string paymentMode, string chairType, string purpose, int rate, string steelType) : base(orderID, quantity, amount, orderDate, furnitureType, paymentMode, chairType, purpose, rate)
        {
            this.steelType = steelType;
        }
        public void Getdata()
        {
            int a = Console.Read();


        }
    }

    class PlasticChair : Chair
    {
        string color;

        public PlasticChair(int orderID, int quantity, int amount, string orderDate, string furnitureType, string paymentMode, string chairType, string purpose, int rate, string color) : base(orderID, quantity, amount, orderDate, furnitureType, paymentMode, chairType, purpose, rate)
        {
            this.color = color;
        }
        public void Getdata()
        {
            int a = Console.Read();


        }
    }

    class Cot : Furniture
    {
        string cotType;
        string capacity;
        int rate;

        public Cot(int orderID, int quantity, int amount, string orderDate, string furnitureType, string paymentMode, string cotType, string capacity, int rate) : base(orderID, quantity, amount, orderDate, furnitureType, paymentMode)
        {
            this.cotType = cotType;
            this.capacity = capacity;
            this.rate = rate;
        }


        public void show()
        {
            Console.Write("orderid : " + orderID + " quantity: " + quantity + " amount: " + amount + " orderdate: " + orderDate + " payment mode: " + paymentMode + " Cout Type: " + cotType + " Capacity: " + capacity + " Rate: " + rate);
        }

    }
    public class Results
    {
        static void Main(string[] args)
        {
            Cot c = new Cot(111, 10, 2200, "15/09/2022", "online", "Plastic", "Wood", "Single", 300);
            c.show();
        }



    }
}