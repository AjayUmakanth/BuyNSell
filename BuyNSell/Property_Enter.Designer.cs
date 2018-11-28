namespace BuyNSell
{
    partial class Property_Enter
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cities = new System.Windows.Forms.ComboBox();
            this.locality = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.PName = new System.Windows.Forms.TextBox();
            this.Address = new System.Windows.Forms.TextBox();
            this.area = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.roads = new System.Windows.Forms.TextBox();
            this.no_floor = new System.Windows.Forms.Label();
            this.noFloor = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.floorNo = new System.Windows.Forms.TextBox();
            this.floor_no = new System.Windows.Forms.Label();
            this.rooms = new System.Windows.Forms.TextBox();
            this.road = new System.Windows.Forms.Label();
            this.regDate = new System.Windows.Forms.DateTimePicker();
            this.parking = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.additional = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.askPrice = new System.Windows.Forms.TextBox();
            this.availability = new System.Windows.Forms.CheckBox();
            this.corner = new System.Windows.Forms.CheckBox();
            this.garden = new System.Windows.Forms.CheckBox();
            this.image = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label16 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.Buy_Rent = new System.Windows.Forms.ComboBox();
            this.citiesLabel = new System.Windows.Forms.Label();
            this.localityText = new System.Windows.Forms.Label();
            this.Buy_RentText = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(57, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "City :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(30, 151);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Locality :";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // cities
            // 
            this.cities.FormattingEnabled = true;
            this.cities.Location = new System.Drawing.Point(110, 98);
            this.cities.Name = "cities";
            this.cities.Size = new System.Drawing.Size(121, 21);
            this.cities.TabIndex = 2;
            this.cities.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // locality
            // 
            this.locality.FormattingEnabled = true;
            this.locality.Location = new System.Drawing.Point(110, 150);
            this.locality.Name = "locality";
            this.locality.Size = new System.Drawing.Size(121, 21);
            this.locality.TabIndex = 3;
            this.locality.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(41, 203);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Name :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(24, 257);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "Address :";
            // 
            // PName
            // 
            this.PName.Location = new System.Drawing.Point(110, 205);
            this.PName.Name = "PName";
            this.PName.Size = new System.Drawing.Size(121, 20);
            this.PName.TabIndex = 6;
            this.PName.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Address
            // 
            this.Address.Location = new System.Drawing.Point(110, 257);
            this.Address.Multiline = true;
            this.Address.Name = "Address";
            this.Address.Size = new System.Drawing.Size(121, 87);
            this.Address.TabIndex = 7;
            this.Address.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // area
            // 
            this.area.Location = new System.Drawing.Point(110, 404);
            this.area.Name = "area";
            this.area.Size = new System.Drawing.Size(121, 20);
            this.area.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(45, 404);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "Area :";
            // 
            // roads
            // 
            this.roads.Location = new System.Drawing.Point(370, 207);
            this.roads.Name = "roads";
            this.roads.Size = new System.Drawing.Size(121, 20);
            this.roads.TabIndex = 11;
            this.roads.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // no_floor
            // 
            this.no_floor.AutoSize = true;
            this.no_floor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.no_floor.Location = new System.Drawing.Point(248, 151);
            this.no_floor.Name = "no_floor";
            this.no_floor.Size = new System.Drawing.Size(103, 20);
            this.no_floor.TabIndex = 10;
            this.no_floor.Text = "No of Floors :";
            this.no_floor.Click += new System.EventHandler(this.label6_Click);
            // 
            // noFloor
            // 
            this.noFloor.Location = new System.Drawing.Point(370, 153);
            this.noFloor.Name = "noFloor";
            this.noFloor.Size = new System.Drawing.Size(121, 20);
            this.noFloor.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(253, 99);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(110, 20);
            this.label7.TabIndex = 12;
            this.label7.Text = "No of Rooms :";
            // 
            // floorNo
            // 
            this.floorNo.Location = new System.Drawing.Point(370, 257);
            this.floorNo.Name = "floorNo";
            this.floorNo.Size = new System.Drawing.Size(121, 20);
            this.floorNo.TabIndex = 15;
            this.floorNo.TextChanged += new System.EventHandler(this.floorNo_TextChanged);
            // 
            // floor_no
            // 
            this.floor_no.AutoSize = true;
            this.floor_no.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.floor_no.Location = new System.Drawing.Point(270, 255);
            this.floor_no.Name = "floor_no";
            this.floor_no.Size = new System.Drawing.Size(81, 20);
            this.floor_no.TabIndex = 14;
            this.floor_no.Text = "Floor No. :";
            // 
            // rooms
            // 
            this.rooms.Location = new System.Drawing.Point(369, 98);
            this.rooms.Name = "rooms";
            this.rooms.Size = new System.Drawing.Size(121, 20);
            this.rooms.TabIndex = 17;
            this.rooms.TextChanged += new System.EventHandler(this.rooms_TextChanged);
            // 
            // road
            // 
            this.road.AutoSize = true;
            this.road.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.road.Location = new System.Drawing.Point(248, 205);
            this.road.Name = "road";
            this.road.Size = new System.Drawing.Size(101, 20);
            this.road.TabIndex = 16;
            this.road.Text = "Road Width :";
            this.road.Click += new System.EventHandler(this.label9_Click);
            // 
            // regDate
            // 
            this.regDate.Location = new System.Drawing.Point(369, 378);
            this.regDate.Name = "regDate";
            this.regDate.Size = new System.Drawing.Size(122, 20);
            this.regDate.TabIndex = 20;
            this.regDate.ValueChanged += new System.EventHandler(this.dateTimePicker2_ValueChanged);
            // 
            // parking
            // 
            this.parking.Location = new System.Drawing.Point(369, 306);
            this.parking.Name = "parking";
            this.parking.Size = new System.Drawing.Size(121, 20);
            this.parking.TabIndex = 22;
            this.parking.TextChanged += new System.EventHandler(this.textBox8_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(521, 379);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(83, 20);
            this.label10.TabIndex = 21;
            this.label10.Text = "Ask Price :";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(258, 324);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(91, 20);
            this.label11.TabIndex = 23;
            this.label11.Text = "(No of cars)";
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // additional
            // 
            this.additional.Location = new System.Drawing.Point(610, 155);
            this.additional.Multiline = true;
            this.additional.Name = "additional";
            this.additional.Size = new System.Drawing.Size(121, 90);
            this.additional.TabIndex = 26;
            this.additional.TextChanged += new System.EventHandler(this.textBox10_TextChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(517, 153);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(87, 20);
            this.label12.TabIndex = 25;
            this.label12.Text = "Additional :";
            this.label12.Click += new System.EventHandler(this.label12_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(279, 304);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(70, 20);
            this.label13.TabIndex = 27;
            this.label13.Text = "Parking :";
            this.label13.Click += new System.EventHandler(this.label13_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(263, 376);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(86, 20);
            this.label14.TabIndex = 28;
            this.label14.Text = "Reg Date :";
            // 
            // askPrice
            // 
            this.askPrice.Location = new System.Drawing.Point(610, 379);
            this.askPrice.Name = "askPrice";
            this.askPrice.Size = new System.Drawing.Size(121, 20);
            this.askPrice.TabIndex = 29;
            this.askPrice.TextChanged += new System.EventHandler(this.askPrice_TextChanged);
            // 
            // availability
            // 
            this.availability.AutoSize = true;
            this.availability.Location = new System.Drawing.Point(665, 98);
            this.availability.Name = "availability";
            this.availability.Size = new System.Drawing.Size(75, 17);
            this.availability.TabIndex = 30;
            this.availability.Text = "Availability";
            this.availability.UseVisualStyleBackColor = true;
            this.availability.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // corner
            // 
            this.corner.AutoSize = true;
            this.corner.Location = new System.Drawing.Point(535, 98);
            this.corner.Name = "corner";
            this.corner.Size = new System.Drawing.Size(57, 17);
            this.corner.TabIndex = 31;
            this.corner.Text = "Corner";
            this.corner.UseVisualStyleBackColor = true;
            this.corner.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // garden
            // 
            this.garden.AutoSize = true;
            this.garden.Location = new System.Drawing.Point(598, 98);
            this.garden.Name = "garden";
            this.garden.Size = new System.Drawing.Size(61, 17);
            this.garden.TabIndex = 32;
            this.garden.Text = "Garden";
            this.garden.UseVisualStyleBackColor = true;
            this.garden.CheckedChanged += new System.EventHandler(this.garden_CheckedChanged);
            // 
            // image
            // 
            this.image.Location = new System.Drawing.Point(610, 289);
            this.image.Name = "image";
            this.image.Size = new System.Drawing.Size(121, 20);
            this.image.TabIndex = 34;
            this.image.TextChanged += new System.EventHandler(this.textBox11_TextChanged);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(542, 289);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(62, 20);
            this.label15.TabIndex = 33;
            this.label15.Text = "Image :";
            this.label15.Click += new System.EventHandler(this.label15_Click_1);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(329, 434);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(109, 36);
            this.button1.TabIndex = 35;
            this.button1.Text = "Create";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(656, 315);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 36;
            this.button2.Text = "Browse";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(175, 28);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(456, 39);
            this.label16.TabIndex = 37;
            this.label16.Text = "Enter Your Property Details";
            this.label16.Click += new System.EventHandler(this.label16_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(17, 365);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(83, 20);
            this.label8.TabIndex = 38;
            this.label8.Text = "Buy/Rent :";
            this.label8.Click += new System.EventHandler(this.label6_Click_1);
            // 
            // Buy_Rent
            // 
            this.Buy_Rent.FormattingEnabled = true;
            this.Buy_Rent.Location = new System.Drawing.Point(110, 364);
            this.Buy_Rent.Name = "Buy_Rent";
            this.Buy_Rent.Size = new System.Drawing.Size(121, 21);
            this.Buy_Rent.TabIndex = 39;
            this.Buy_Rent.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged_1);
            // 
            // citiesLabel
            // 
            this.citiesLabel.AutoSize = true;
            this.citiesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.citiesLabel.Location = new System.Drawing.Point(106, 99);
            this.citiesLabel.Name = "citiesLabel";
            this.citiesLabel.Size = new System.Drawing.Size(43, 20);
            this.citiesLabel.TabIndex = 40;
            this.citiesLabel.Text = "City :";
            this.citiesLabel.Click += new System.EventHandler(this.label6_Click_2);
            // 
            // localityText
            // 
            this.localityText.AutoSize = true;
            this.localityText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.localityText.Location = new System.Drawing.Point(106, 151);
            this.localityText.Name = "localityText";
            this.localityText.Size = new System.Drawing.Size(70, 20);
            this.localityText.TabIndex = 41;
            this.localityText.Text = "Locality :";
            this.localityText.Click += new System.EventHandler(this.label6_Click_3);
            // 
            // Buy_RentText
            // 
            this.Buy_RentText.AutoSize = true;
            this.Buy_RentText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Buy_RentText.Location = new System.Drawing.Point(106, 365);
            this.Buy_RentText.Name = "Buy_RentText";
            this.Buy_RentText.Size = new System.Drawing.Size(83, 20);
            this.Buy_RentText.TabIndex = 42;
            this.Buy_RentText.Text = "Buy/Rent :";
            this.Buy_RentText.Click += new System.EventHandler(this.label9_Click_1);
            // 
            // Property_Enter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(847, 494);
            this.Controls.Add(this.Buy_RentText);
            this.Controls.Add(this.localityText);
            this.Controls.Add(this.citiesLabel);
            this.Controls.Add(this.Buy_Rent);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.image);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.garden);
            this.Controls.Add(this.corner);
            this.Controls.Add(this.availability);
            this.Controls.Add(this.askPrice);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.additional);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.parking);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.regDate);
            this.Controls.Add(this.rooms);
            this.Controls.Add(this.road);
            this.Controls.Add(this.floorNo);
            this.Controls.Add(this.floor_no);
            this.Controls.Add(this.noFloor);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.roads);
            this.Controls.Add(this.no_floor);
            this.Controls.Add(this.area);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Address);
            this.Controls.Add(this.PName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.locality);
            this.Controls.Add(this.cities);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Property_Enter";
            this.Text = "BuyNSell";
            this.Load += new System.EventHandler(this.Form6_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cities;
        private System.Windows.Forms.ComboBox locality;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox PName;
        private System.Windows.Forms.TextBox Address;
        private System.Windows.Forms.TextBox area;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox roads;
        private System.Windows.Forms.Label no_floor;
        private System.Windows.Forms.TextBox noFloor;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox floorNo;
        private System.Windows.Forms.Label floor_no;
        private System.Windows.Forms.TextBox rooms;
        private System.Windows.Forms.Label road;
        private System.Windows.Forms.DateTimePicker regDate;
        private System.Windows.Forms.TextBox parking;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox additional;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox askPrice;
        private System.Windows.Forms.CheckBox availability;
        private System.Windows.Forms.CheckBox corner;
        private System.Windows.Forms.CheckBox garden;
        private System.Windows.Forms.TextBox image;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox Buy_Rent;
        private System.Windows.Forms.Label citiesLabel;
        private System.Windows.Forms.Label localityText;
        private System.Windows.Forms.Label Buy_RentText;
    }
}