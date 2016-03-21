namespace CustomClassTemplate.Gui
{
    partial class CCGui
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.foodlb = new System.Windows.Forms.Label();
            this.drinklb = new System.Windows.Forms.Label();
            this.meleelb = new System.Windows.Forms.Label();
            this.castlb = new System.Windows.Forms.Label();
            this.meleeNud = new System.Windows.Forms.NumericUpDown();
            this.castNud = new System.Windows.Forms.NumericUpDown();
            this.saveBtn = new System.Windows.Forms.Button();
            this.reloadBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.drinkTb = new System.Windows.Forms.ComboBox();
            this.foodTb = new System.Windows.Forms.ComboBox();
            this.scStam = new System.Windows.Forms.ComboBox();
            this.scSpirit = new System.Windows.Forms.ComboBox();
            this.scProt = new System.Windows.Forms.ComboBox();
            this.Elixir = new System.Windows.Forms.ComboBox();
            this.Mpotion = new System.Windows.Forms.ComboBox();
            this.Hpotion = new System.Windows.Forms.ComboBox();
            this.scWeapEnch = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.cbManaGem = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.meleeNud)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.castNud)).BeginInit();
            this.SuspendLayout();
            // 
            // foodlb
            // 
            this.foodlb.AutoSize = true;
            this.foodlb.Location = new System.Drawing.Point(22, 31);
            this.foodlb.Name = "foodlb";
            this.foodlb.Size = new System.Drawing.Size(68, 13);
            this.foodlb.TabIndex = 0;
            this.foodlb.Text = "Food Name: ";
            // 
            // drinklb
            // 
            this.drinklb.AutoSize = true;
            this.drinklb.Location = new System.Drawing.Point(21, 59);
            this.drinklb.Name = "drinklb";
            this.drinklb.Size = new System.Drawing.Size(69, 13);
            this.drinklb.TabIndex = 1;
            this.drinklb.Text = "Drink Name: ";
            // 
            // meleelb
            // 
            this.meleelb.AutoSize = true;
            this.meleelb.Location = new System.Drawing.Point(47, 132);
            this.meleelb.Name = "meleelb";
            this.meleelb.Size = new System.Drawing.Size(87, 13);
            this.meleelb.TabIndex = 4;
            this.meleelb.Text = "Melee Distance: ";
            this.meleelb.Click += new System.EventHandler(this.meleelb_Click);
            // 
            // castlb
            // 
            this.castlb.AutoSize = true;
            this.castlb.Location = new System.Drawing.Point(55, 158);
            this.castlb.Name = "castlb";
            this.castlb.Size = new System.Drawing.Size(79, 13);
            this.castlb.TabIndex = 5;
            this.castlb.Text = "Cast Distance: ";
            this.castlb.Click += new System.EventHandler(this.castlb_Click);
            // 
            // meleeNud
            // 
            this.meleeNud.Location = new System.Drawing.Point(140, 130);
            this.meleeNud.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.meleeNud.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.meleeNud.Name = "meleeNud";
            this.meleeNud.Size = new System.Drawing.Size(66, 20);
            this.meleeNud.TabIndex = 6;
            this.meleeNud.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.meleeNud.ValueChanged += new System.EventHandler(this.meleeNud_ValueChanged);
            // 
            // castNud
            // 
            this.castNud.Location = new System.Drawing.Point(140, 156);
            this.castNud.Maximum = new decimal(new int[] {
            42,
            0,
            0,
            0});
            this.castNud.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.castNud.Name = "castNud";
            this.castNud.Size = new System.Drawing.Size(66, 20);
            this.castNud.TabIndex = 7;
            this.castNud.Value = new decimal(new int[] {
            25,
            0,
            0,
            0});
            this.castNud.ValueChanged += new System.EventHandler(this.castNud_ValueChanged);
            // 
            // saveBtn
            // 
            this.saveBtn.Location = new System.Drawing.Point(228, 159);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(75, 23);
            this.saveBtn.TabIndex = 8;
            this.saveBtn.Text = "Save";
            this.saveBtn.UseVisualStyleBackColor = true;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // reloadBtn
            // 
            this.reloadBtn.Location = new System.Drawing.Point(319, 159);
            this.reloadBtn.Name = "reloadBtn";
            this.reloadBtn.Size = new System.Drawing.Size(75, 23);
            this.reloadBtn.TabIndex = 9;
            this.reloadBtn.Text = "Reload";
            this.reloadBtn.UseVisualStyleBackColor = true;
            this.reloadBtn.Click += new System.EventHandler(this.reloadBtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(425, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Protection:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(450, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Spirit:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(442, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Stamina:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(439, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(171, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "(BETA) USES ALL, OR ON LOOT.";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(110, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Food Name: ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(458, 31);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(31, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "Elixir:";
            this.label7.Click += new System.EventHandler(this.label4_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(220, 31);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(74, 13);
            this.label8.TabIndex = 11;
            this.label8.Text = "Health Potion:";
            this.label8.Click += new System.EventHandler(this.label3_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(224, 56);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(70, 13);
            this.label9.TabIndex = 12;
            this.label9.Text = "Mana Potion:";
            this.label9.Click += new System.EventHandler(this.label2_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(215, 82);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(79, 13);
            this.label10.TabIndex = 13;
            this.label10.Text = "Weapon Ench:";
            this.label10.Click += new System.EventHandler(this.label1_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(318, 9);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(74, 13);
            this.label11.TabIndex = 14;
            this.label11.Text = "Elixirs / Potion";
            // 
            // drinkTb
            // 
            this.drinkTb.FormattingEnabled = true;
            this.drinkTb.Items.AddRange(new object[] {
            "Conjured Water",
            "Conjured Fresh Water",
            "Conjured Purified Water",
            "Conjured Spring Water",
            "Conjured Mineral Water",
            "Major Sparkling Water",
            "Conjured Crystal Water"});
            this.drinkTb.Location = new System.Drawing.Point(85, 56);
            this.drinkTb.Name = "drinkTb";
            this.drinkTb.Size = new System.Drawing.Size(121, 21);
            this.drinkTb.TabIndex = 15;
            // 
            // foodTb
            // 
            this.foodTb.FormattingEnabled = true;
            this.foodTb.Items.AddRange(new object[] {
            "Conjured Muffin",
            "Conjured Bread",
            "Conjured Rye",
            "Conjured Pumpernickel",
            "Conjured Sourdough",
            "Conjured Sweet Roll",
            "Conjured Cinnamon Roll"});
            this.foodTb.Location = new System.Drawing.Point(85, 28);
            this.foodTb.Name = "foodTb";
            this.foodTb.Size = new System.Drawing.Size(121, 21);
            this.foodTb.TabIndex = 16;
            // 
            // scStam
            // 
            this.scStam.FormattingEnabled = true;
            this.scStam.Items.AddRange(new object[] {
            "Scroll of Stamina",
            "Scroll of Stamina II",
            "Scroll of Stamina III",
            "Scroll of Stamina IV"});
            this.scStam.Location = new System.Drawing.Point(489, 107);
            this.scStam.Name = "scStam";
            this.scStam.Size = new System.Drawing.Size(121, 21);
            this.scStam.TabIndex = 15;
            // 
            // scSpirit
            // 
            this.scSpirit.Enabled = false;
            this.scSpirit.FormattingEnabled = true;
            this.scSpirit.Items.AddRange(new object[] {
            "Scroll of Spirit",
            "Scroll of Spirit II",
            "Scroll of Spirit III",
            "Scroll of Spirit IV"});
            this.scSpirit.Location = new System.Drawing.Point(489, 55);
            this.scSpirit.Name = "scSpirit";
            this.scSpirit.Size = new System.Drawing.Size(121, 21);
            this.scSpirit.TabIndex = 16;
            this.scSpirit.SelectedIndexChanged += new System.EventHandler(this.scSpirit_SelectedIndexChanged);
            // 
            // scProt
            // 
            this.scProt.Enabled = false;
            this.scProt.FormattingEnabled = true;
            this.scProt.Items.AddRange(new object[] {
            "Scroll of Protection",
            "Scroll of Protection II",
            "Scroll of Protection III",
            "Scroll of Protection IV"});
            this.scProt.Location = new System.Drawing.Point(489, 80);
            this.scProt.Name = "scProt";
            this.scProt.Size = new System.Drawing.Size(121, 21);
            this.scProt.TabIndex = 15;
            // 
            // Elixir
            // 
            this.Elixir.Enabled = false;
            this.Elixir.FormattingEnabled = true;
            this.Elixir.Items.AddRange(new object[] {
            "Elixir of Minor Fortitude",
            "Elixir of Wisdom",
            "Elixir of Defense",
            "Elixir of Firepower",
            "Elixir of Fortitude",
            "Elixir of Greater Defense",
            "Arcane Elixir",
            "Elixir of the Sages",
            "Elixir of the Mongoose",
            "Greater Arcane Elixir",
            "Elixir of Superior Defense",
            "Elixir of Frost Power",
            "Elixir of Greater Firepower",
            "Elixir of Greater Intellect"});
            this.Elixir.Location = new System.Drawing.Point(489, 28);
            this.Elixir.Name = "Elixir";
            this.Elixir.Size = new System.Drawing.Size(121, 21);
            this.Elixir.TabIndex = 15;
            // 
            // Mpotion
            // 
            this.Mpotion.FormattingEnabled = true;
            this.Mpotion.Items.AddRange(new object[] {
            "Minor Mana Potion",
            "Lesser Mana Potion",
            "Mana Potion",
            "Greater Mana Potion",
            "Superior Mana Potion",
            "Major Mana Potion"});
            this.Mpotion.Location = new System.Drawing.Point(293, 53);
            this.Mpotion.Name = "Mpotion";
            this.Mpotion.Size = new System.Drawing.Size(121, 21);
            this.Mpotion.TabIndex = 15;
            this.Mpotion.SelectedIndexChanged += new System.EventHandler(this.Mpotion_SelectedIndexChanged);
            // 
            // Hpotion
            // 
            this.Hpotion.FormattingEnabled = true;
            this.Hpotion.Items.AddRange(new object[] {
            "Minor Healing Potion",
            "Lesser Healing Potion",
            "Healing Potion",
            "Greater Healing Potion",
            "Superior Healing Potion",
            "Major Healing Potion"});
            this.Hpotion.Location = new System.Drawing.Point(293, 28);
            this.Hpotion.Name = "Hpotion";
            this.Hpotion.Size = new System.Drawing.Size(121, 21);
            this.Hpotion.TabIndex = 16;
            this.Hpotion.SelectedIndexChanged += new System.EventHandler(this.Hpotion_SelectedIndexChanged);
            // 
            // scWeapEnch
            // 
            this.scWeapEnch.FormattingEnabled = true;
            this.scWeapEnch.Items.AddRange(new object[] {
            "Minor Wizard Oil",
            "Lesser Wizard Oil",
            "Wizard Oil",
            "Brilliant Wizard Oil",
            "Blessed Wizard Oil",
            "Superior Wizard Oil"});
            this.scWeapEnch.Location = new System.Drawing.Point(294, 80);
            this.scWeapEnch.Name = "scWeapEnch";
            this.scWeapEnch.Size = new System.Drawing.Size(121, 21);
            this.scWeapEnch.TabIndex = 15;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(230, 111);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(62, 13);
            this.label13.TabIndex = 18;
            this.label13.Text = "Mana Gem:";
            // 
            // cbManaGem
            // 
            this.cbManaGem.FormattingEnabled = true;
            this.cbManaGem.Items.AddRange(new object[] {
            "Mana Agate",
            "Mana Jade",
            "Mana Citrine",
            "Mana Ruby"});
            this.cbManaGem.Location = new System.Drawing.Point(294, 107);
            this.cbManaGem.Name = "cbManaGem";
            this.cbManaGem.Size = new System.Drawing.Size(121, 21);
            this.cbManaGem.TabIndex = 17;
            // 
            // CCGui
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(619, 189);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.cbManaGem);
            this.Controls.Add(this.Hpotion);
            this.Controls.Add(this.scSpirit);
            this.Controls.Add(this.foodTb);
            this.Controls.Add(this.scWeapEnch);
            this.Controls.Add(this.Mpotion);
            this.Controls.Add(this.scProt);
            this.Controls.Add(this.Elixir);
            this.Controls.Add(this.scStam);
            this.Controls.Add(this.drinkTb);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.reloadBtn);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.castNud);
            this.Controls.Add(this.meleeNud);
            this.Controls.Add(this.castlb);
            this.Controls.Add(this.meleelb);
            this.Controls.Add(this.drinklb);
            this.Controls.Add(this.foodlb);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "CCGui";
            this.Text = "Mage Config";
            this.Load += new System.EventHandler(this.CCGui_Load);
            ((System.ComponentModel.ISupportInitialize)(this.meleeNud)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.castNud)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label foodlb;
        private System.Windows.Forms.Label drinklb;
        private System.Windows.Forms.Label meleelb;
        private System.Windows.Forms.Label castlb;
        private System.Windows.Forms.NumericUpDown meleeNud;
        private System.Windows.Forms.NumericUpDown castNud;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.Button reloadBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox drinkTb;
        private System.Windows.Forms.ComboBox foodTb;
        private System.Windows.Forms.ComboBox scStam;
        private System.Windows.Forms.ComboBox scSpirit;
        private System.Windows.Forms.ComboBox scProt;
        private System.Windows.Forms.ComboBox Elixir;
        private System.Windows.Forms.ComboBox Mpotion;
        private System.Windows.Forms.ComboBox Hpotion;
        private System.Windows.Forms.ComboBox scWeapEnch;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox cbManaGem;
    }
}