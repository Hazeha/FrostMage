using System;
using System.Windows.Forms;
using CustomClassTemplate.Settings;

namespace CustomClassTemplate.Gui
{
    public partial class CCGui : Form
    {
        public CCGui()
        {
            InitializeComponent();
            load();
        }


        private void save()
        {
            CustomClassSettings.Values.DrinkName = drinkTb.Text;  //Drink Name
            CustomClassSettings.Values.FoodName = foodTb.Text;   //Food Name

          //  CustomClassSettings.Values.ConjureWater = Watercunj.Text;  //Cunjure drink name
         //   CustomClassSettings.Values.ConjureFood = Foodcunj.Text;  //Conjure food name
            CustomClassSettings.Values.StamScroll = scStam.Text; // Stam Scroll
            CustomClassSettings.Values.SpiritScroll = scSpirit.Text; // Spirit scroll
            CustomClassSettings.Values.ProtScroll = scProt.Text; // Prot Scroll
            CustomClassSettings.Values.ElixirUse = Elixir.Text;  // Elixir
            CustomClassSettings.Values.HealthPot = Hpotion.Text; // HealthPot
            CustomClassSettings.Values.ManaPot = Mpotion.Text; //ManaPot
            CustomClassSettings.Values.WeaponEnch = scWeapEnch.Text; // WeaponEnch
            CustomClassSettings.Values.ManaGem = cbManaGem.Text; // WeaponEnch
            CustomClassSettings.Values.MeleeAttackRange = (int)meleeNud.Value;
            CustomClassSettings.Values.RangedAttackRange = (int)castNud.Value;
            CustomClassSettings.Values.Save();
        }

        private void load()
        {
            CustomClassSettings.Values.Load();
            drinkTb.Text = CustomClassSettings.Values.DrinkName;
            foodTb.Text = CustomClassSettings.Values.FoodName;
          //  Watercunj.Text = CustomClassSettings.Values.ConjureWater;
          //  Foodcunj.Text = CustomClassSettings.Values.ConjureFood;
            scStam.Text = CustomClassSettings.Values.StamScroll;
            scSpirit.Text = CustomClassSettings.Values.SpiritScroll;
            scProt.Text = CustomClassSettings.Values.ProtScroll;
            Elixir.Text = CustomClassSettings.Values.ElixirUse;
            Hpotion.Text = CustomClassSettings.Values.HealthPot;
            Mpotion.Text = CustomClassSettings.Values.ManaPot;
            scWeapEnch.Text = CustomClassSettings.Values.WeaponEnch;
            cbManaGem.Text = CustomClassSettings.Values.ManaGem;
            meleeNud.Value = CustomClassSettings.Values.MeleeAttackRange;
            castNud.Value = CustomClassSettings.Values.RangedAttackRange;
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            save();
        }

        private void reloadBtn_Click(object sender, EventArgs e)
        {
            load();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void foodTb_TextChanged(object sender, EventArgs e)
        {

        }

        private void drinkTb_TextChanged(object sender, EventArgs e)
        {

        }

        private void CCGui_Load(object sender, EventArgs e)
        {

        }

        private void comboBox9_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void meleelb_Click(object sender, EventArgs e)
        {

        }

        private void castlb_Click(object sender, EventArgs e)
        {

        }

        private void castNud_ValueChanged(object sender, EventArgs e)
        {

        }

        private void meleeNud_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Hpotion_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Mpotion_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void scSpirit_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
