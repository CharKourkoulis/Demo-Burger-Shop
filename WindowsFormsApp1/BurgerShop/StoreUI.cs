using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BurgerItem;

namespace BurgerShop
{
    public partial class StoreUI : Form
    {
        Store store = new Store("DemoBurgerStore");
        List<Burger> burgersList = new List<Burger>();

        BindingSource burgersBinding = new BindingSource();
        BindingSource cartBinding = new BindingSource();
        private double TotalPrice = 0;



        public StoreUI()
        {
            InitializeComponent();
            LoadData();

            burgersBinding.DataSource = store.Burgers;
            burgerListbox.DataSource = burgersBinding;
            burgerListbox.DisplayMember = "Display";
            burgerListbox.ValueMember = "Display";

            cartBinding.DataSource = burgersList;
            cartListbox.DataSource = cartBinding;
            cartListbox.DisplayMember = "Display";
            cartListbox.ValueMember = "Display";

        }




        private void LoadData()
        {
            store.Burgers.Add(new Burger { Name = "Classic Burger", TypeOfMeat = "beef", Price = 5.50 });
            store.Burgers.Add(new Burger { Name = "Cheese Burger", TypeOfMeat = "beef", Price = 6.50 });
            store.Burgers.Add(new Burger { Name = "Chicken Burger", TypeOfMeat = "chicken", Price = 5.50 });
            store.Burgers.Add(new Burger { Name = "Blue Burger", TypeOfMeat = "beef", Price = 6.50 });
            store.Burgers.Add(new Burger { Name = "Angus Burger", TypeOfMeat = "Angus", Price = 5.50 });
            store.Burgers.Add(new Burger { Name = "Vegan Burger", TypeOfMeat = "No meat", Price = 5.00 });
            store.Burgers.Add(new Burger { Name = "Chili Burger", TypeOfMeat = "beef", Price = 6.00 });

        }

        private void BurgerListbox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void AddToCartButton_Click(object sender, EventArgs e)
        {
            Burger selectedBurger = (Burger)burgerListbox.SelectedItem;
            burgersList.Add(selectedBurger);
            TotalPrice += selectedBurger.Price;
            totalpricebox.Text = string.Format("$ {0}", TotalPrice);
            cartBinding.ResetBindings(false);
        }

        private void CheckoutButton_Click(object sender, EventArgs e)
        {
            //foreach (var item in burgersList)
            //{
            //    item.Sold = true;
            //    TotalPrice += item.Price;                  
            //}

            totalpricebox.Text = string.Format("$ {0}", TotalPrice);
            burgersList.Clear();         
            cartBinding.ResetBindings(false);
            MessageBox.Show("Order is Sent!");
            totalpricebox.Text = string.Format("$ 0.0");
        }
    }
}
