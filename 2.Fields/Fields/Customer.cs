using System.Collections.Generic;

namespace Fields
{
    public class Customer
    {
        public int Id;
        public string Name;
        public readonly List<Order> Orders = new List<Order>();
        //readonly is used so you cant reset this field by initializing it again

        /*You can create a constructor to initialize orders field like bellow, but you have to
         make sure that the default constructor is always called. Or you can initialize in the decalration like above
         
        public List<Order> Orders;
        public Customer(int id)
        {
            this.Id = id;
        }
        */

        public Customer(int id)
        {
            this.Id = id;
        }

        public Customer(int id, string name)
            : this(id)
        {
            this.Name = name;
        }
    }
}