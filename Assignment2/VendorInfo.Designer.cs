namespace Assignment2
{
    partial class VendorInfo
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
            groupBox1 = new GroupBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtName = new TextBox();
            txtCompany = new TextBox();
            txtCell = new TextBox();
            listBox1 = new ListBox();
            groupBox2 = new GroupBox();
            groupBox3 = new GroupBox();
            rdCoffee = new RadioButton();
            rdTea = new RadioButton();
            rdHerbs = new RadioButton();
            groupBox4 = new GroupBox();
            rdMilk = new RadioButton();
            rdCream = new RadioButton();
            groupBox5 = new GroupBox();
            groupBox6 = new GroupBox();
            ckOnTime = new CheckBox();
            ckDelayed = new CheckBox();
            ckPaid = new CheckBox();
            ckUnpaid = new CheckBox();
            button1 = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox4.SuspendLayout();
            groupBox5.SuspendLayout();
            groupBox6.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(listBox1);
            groupBox1.Controls.Add(txtCell);
            groupBox1.Controls.Add(txtCompany);
            groupBox1.Controls.Add(txtName);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(403, 426);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Vendor Details";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(78, 53);
            label1.Name = "label1";
            label1.Size = new Size(39, 15);
            label1.TabIndex = 0;
            label1.Text = "Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(58, 85);
            label2.Name = "label2";
            label2.Size = new Size(59, 15);
            label2.TabIndex = 1;
            label2.Text = "Company";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(90, 120);
            label3.Name = "label3";
            label3.Size = new Size(27, 15);
            label3.TabIndex = 2;
            label3.Text = "Cell";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(89, 164);
            label4.Name = "label4";
            label4.Size = new Size(28, 15);
            label4.TabIndex = 3;
            label4.Text = "City";
            // 
            // txtName
            // 
            txtName.Location = new Point(123, 50);
            txtName.Name = "txtName";
            txtName.Size = new Size(260, 23);
            txtName.TabIndex = 4;
            // 
            // txtCompany
            // 
            txtCompany.Location = new Point(123, 82);
            txtCompany.Name = "txtCompany";
            txtCompany.Size = new Size(260, 23);
            txtCompany.TabIndex = 4;
            // 
            // txtCell
            // 
            txtCell.Location = new Point(123, 117);
            txtCell.Name = "txtCell";
            txtCell.Size = new Size(260, 23);
            txtCell.TabIndex = 4;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Items.AddRange(new object[] { "• Abilene", "• Andover", "• Arkansas City", "• Atchison", "• Augusta", "• Baldwin City", "• Bel Aire", "• Bonner Springs", "• Chanute", "• Coffeyville", "• Colby", "• Concordia", "• De Soto", "• Derby", "• Dodge City", "• El Dorado", "• Emporia", "• Eudora", "• Fort Scott", "• Garden City", "• Gardner", "• Great Bend", "• Hays", "• Haysville", "• Hutchinson", "• Independence", "• Iola", "• Junction City", "• Kansas City", "• Lansing", "• Lawrence", "• Leavenworth", "• Leawood", "• Lenexa", "• Liberal", "• Manhattan", "• McPherson", "• Merriam", "• Mission", "• Newton", "• Olathe", "• Ottawa", "• Overland Park", "• Paola", "• Park City", "• Parsons", "• Pittsburg", "• Prairie Village", "• Pratt", "• Roeland Park", "• Salina", "• Shawnee", "• Spring Hill", "• Stilwell", "• Topeka", "• Ulysses", "• Valley Center", "• Wellington", "• Wichita", "• Winfield" });
            listBox1.Location = new Point(123, 164);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(260, 214);
            listBox1.TabIndex = 5;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(groupBox4);
            groupBox2.Controls.Add(groupBox3);
            groupBox2.Location = new Point(421, 17);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(351, 242);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "groupBox2";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(rdHerbs);
            groupBox3.Controls.Add(rdTea);
            groupBox3.Controls.Add(rdCoffee);
            groupBox3.Location = new Point(27, 35);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(299, 95);
            groupBox3.TabIndex = 0;
            groupBox3.TabStop = false;
            groupBox3.Text = "Products Information";
            // 
            // rdCoffee
            // 
            rdCoffee.AutoSize = true;
            rdCoffee.Location = new Point(58, 22);
            rdCoffee.Name = "rdCoffee";
            rdCoffee.Size = new Size(94, 19);
            rdCoffee.TabIndex = 0;
            rdCoffee.TabStop = true;
            rdCoffee.Text = "Coffee Beans";
            rdCoffee.UseVisualStyleBackColor = true;
            // 
            // rdTea
            // 
            rdTea.AutoSize = true;
            rdTea.Location = new Point(58, 45);
            rdTea.Name = "rdTea";
            rdTea.Size = new Size(76, 19);
            rdTea.TabIndex = 0;
            rdTea.TabStop = true;
            rdTea.Text = "Green Tea";
            rdTea.UseVisualStyleBackColor = true;
            // 
            // rdHerbs
            // 
            rdHerbs.AutoSize = true;
            rdHerbs.Location = new Point(58, 67);
            rdHerbs.Name = "rdHerbs";
            rdHerbs.Size = new Size(56, 19);
            rdHerbs.TabIndex = 0;
            rdHerbs.TabStop = true;
            rdHerbs.Text = "Herbs";
            rdHerbs.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(rdCream);
            groupBox4.Controls.Add(rdMilk);
            groupBox4.Location = new Point(27, 136);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(299, 88);
            groupBox4.TabIndex = 1;
            groupBox4.TabStop = false;
            groupBox4.Text = "Dairy Products";
            // 
            // rdMilk
            // 
            rdMilk.AutoSize = true;
            rdMilk.Location = new Point(58, 24);
            rdMilk.Name = "rdMilk";
            rdMilk.Size = new Size(48, 19);
            rdMilk.TabIndex = 0;
            rdMilk.TabStop = true;
            rdMilk.Text = "Milk";
            rdMilk.UseVisualStyleBackColor = true;
            // 
            // rdCream
            // 
            rdCream.AutoSize = true;
            rdCream.Location = new Point(58, 49);
            rdCream.Name = "rdCream";
            rdCream.Size = new Size(60, 19);
            rdCream.TabIndex = 0;
            rdCream.TabStop = true;
            rdCream.Text = "Cream";
            rdCream.UseVisualStyleBackColor = true;
            // 
            // groupBox5
            // 
            groupBox5.Controls.Add(ckDelayed);
            groupBox5.Controls.Add(ckOnTime);
            groupBox5.Location = new Point(421, 265);
            groupBox5.Name = "groupBox5";
            groupBox5.Size = new Size(179, 100);
            groupBox5.TabIndex = 2;
            groupBox5.TabStop = false;
            groupBox5.Text = "Delivery";
            // 
            // groupBox6
            // 
            groupBox6.Controls.Add(ckUnpaid);
            groupBox6.Controls.Add(ckPaid);
            groupBox6.Location = new Point(606, 265);
            groupBox6.Name = "groupBox6";
            groupBox6.Size = new Size(166, 100);
            groupBox6.TabIndex = 0;
            groupBox6.TabStop = false;
            groupBox6.Text = "Payment";
            // 
            // ckOnTime
            // 
            ckOnTime.AutoSize = true;
            ckOnTime.Location = new Point(31, 23);
            ckOnTime.Name = "ckOnTime";
            ckOnTime.Size = new Size(71, 19);
            ckOnTime.TabIndex = 0;
            ckOnTime.Text = "On Time";
            ckOnTime.UseVisualStyleBackColor = true;
            // 
            // ckDelayed
            // 
            ckDelayed.AutoSize = true;
            ckDelayed.Location = new Point(31, 48);
            ckDelayed.Name = "ckDelayed";
            ckDelayed.Size = new Size(68, 19);
            ckDelayed.TabIndex = 0;
            ckDelayed.Text = "Delayed";
            ckDelayed.UseVisualStyleBackColor = true;
            // 
            // ckPaid
            // 
            ckPaid.AutoSize = true;
            ckPaid.Location = new Point(35, 23);
            ckPaid.Name = "ckPaid";
            ckPaid.Size = new Size(49, 19);
            ckPaid.TabIndex = 0;
            ckPaid.Text = "Paid";
            ckPaid.UseVisualStyleBackColor = true;
            // 
            // ckUnpaid
            // 
            ckUnpaid.AutoSize = true;
            ckUnpaid.Location = new Point(35, 48);
            ckUnpaid.Name = "ckUnpaid";
            ckUnpaid.Size = new Size(64, 19);
            ckUnpaid.TabIndex = 0;
            ckUnpaid.Text = "Unpaid";
            ckUnpaid.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(421, 371);
            button1.Name = "button1";
            button1.Size = new Size(351, 67);
            button1.TabIndex = 3;
            button1.Text = "SAVE";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // VendorInfo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(groupBox6);
            Controls.Add(groupBox5);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "VendorInfo";
            Text = "VendorInfo";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            groupBox5.ResumeLayout(false);
            groupBox5.PerformLayout();
            groupBox6.ResumeLayout(false);
            groupBox6.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private ListBox listBox1;
        private TextBox txtCell;
        private TextBox txtCompany;
        private TextBox txtName;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private GroupBox groupBox2;
        private GroupBox groupBox4;
        private RadioButton rdCream;
        private RadioButton rdMilk;
        private GroupBox groupBox3;
        private RadioButton rdHerbs;
        private RadioButton rdTea;
        private RadioButton rdCoffee;
        private GroupBox groupBox5;
        private CheckBox ckDelayed;
        private CheckBox ckOnTime;
        private GroupBox groupBox6;
        private CheckBox ckUnpaid;
        private CheckBox ckPaid;
        private Button button1;
    }
}