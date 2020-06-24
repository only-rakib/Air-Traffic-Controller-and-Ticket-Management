namespace AirTrafficAndTicketManagement
{
    partial class PrintTicket
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PrintTicket));
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.textBoxCO = new System.Windows.Forms.TextBox();
            this.textBoxFlight = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBoxSeat = new System.Windows.Forms.TextBox();
            this.textBoxChildren = new System.Windows.Forms.TextBox();
            this.textBoxAdult = new System.Windows.Forms.TextBox();
            this.textBoxInfants = new System.Windows.Forms.TextBox();
            this.textBoxTicketNumber = new System.Windows.Forms.TextBox();
            this.textBoxCabin = new System.Windows.Forms.TextBox();
            this.textBoxDate = new System.Windows.Forms.TextBox();
            this.textBoxPassport = new System.Windows.Forms.TextBox();
            this.textBoxTotalCost = new System.Windows.Forms.TextBox();
            this.textBoxFrom = new System.Windows.Forms.TextBox();
            this.textBoxFlightName = new System.Windows.Forms.TextBox();
            this.textBoxTo = new System.Windows.Forms.TextBox();
            this.Print = new System.Windows.Forms.Button();
            this.Name1 = new System.Windows.Forms.Label();
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
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.buttonMainMenu = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textBoxpicture = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            this.printPreviewDialog1.Load += new System.EventHandler(this.printPreviewDialog1_Load);
            // 
            // textBoxCO
            // 
            this.textBoxCO.Location = new System.Drawing.Point(154, 234);
            this.textBoxCO.Name = "textBoxCO";
            this.textBoxCO.ReadOnly = true;
            this.textBoxCO.Size = new System.Drawing.Size(164, 20);
            this.textBoxCO.TabIndex = 2;
            // 
            // textBoxFlight
            // 
            this.textBoxFlight.Location = new System.Drawing.Point(154, 287);
            this.textBoxFlight.Name = "textBoxFlight";
            this.textBoxFlight.ReadOnly = true;
            this.textBoxFlight.Size = new System.Drawing.Size(164, 20);
            this.textBoxFlight.TabIndex = 3;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(154, 186);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(164, 20);
            this.textBox2.TabIndex = 4;
            // 
            // textBoxSeat
            // 
            this.textBoxSeat.Location = new System.Drawing.Point(564, 292);
            this.textBoxSeat.Name = "textBoxSeat";
            this.textBoxSeat.ReadOnly = true;
            this.textBoxSeat.Size = new System.Drawing.Size(164, 20);
            this.textBoxSeat.TabIndex = 5;
            // 
            // textBoxChildren
            // 
            this.textBoxChildren.Location = new System.Drawing.Point(564, 394);
            this.textBoxChildren.Name = "textBoxChildren";
            this.textBoxChildren.ReadOnly = true;
            this.textBoxChildren.Size = new System.Drawing.Size(164, 20);
            this.textBoxChildren.TabIndex = 6;
            // 
            // textBoxAdult
            // 
            this.textBoxAdult.Location = new System.Drawing.Point(564, 343);
            this.textBoxAdult.Name = "textBoxAdult";
            this.textBoxAdult.ReadOnly = true;
            this.textBoxAdult.Size = new System.Drawing.Size(164, 20);
            this.textBoxAdult.TabIndex = 7;
            // 
            // textBoxInfants
            // 
            this.textBoxInfants.Location = new System.Drawing.Point(564, 447);
            this.textBoxInfants.Name = "textBoxInfants";
            this.textBoxInfants.ReadOnly = true;
            this.textBoxInfants.Size = new System.Drawing.Size(164, 20);
            this.textBoxInfants.TabIndex = 8;
            // 
            // textBoxTicketNumber
            // 
            this.textBoxTicketNumber.Location = new System.Drawing.Point(154, 124);
            this.textBoxTicketNumber.Name = "textBoxTicketNumber";
            this.textBoxTicketNumber.ReadOnly = true;
            this.textBoxTicketNumber.Size = new System.Drawing.Size(164, 20);
            this.textBoxTicketNumber.TabIndex = 9;
            // 
            // textBoxCabin
            // 
            this.textBoxCabin.Location = new System.Drawing.Point(564, 235);
            this.textBoxCabin.Name = "textBoxCabin";
            this.textBoxCabin.ReadOnly = true;
            this.textBoxCabin.Size = new System.Drawing.Size(164, 20);
            this.textBoxCabin.TabIndex = 10;
            // 
            // textBoxDate
            // 
            this.textBoxDate.Location = new System.Drawing.Point(154, 498);
            this.textBoxDate.Name = "textBoxDate";
            this.textBoxDate.ReadOnly = true;
            this.textBoxDate.Size = new System.Drawing.Size(164, 20);
            this.textBoxDate.TabIndex = 11;
            // 
            // textBoxPassport
            // 
            this.textBoxPassport.Location = new System.Drawing.Point(154, 340);
            this.textBoxPassport.Name = "textBoxPassport";
            this.textBoxPassport.ReadOnly = true;
            this.textBoxPassport.Size = new System.Drawing.Size(164, 20);
            this.textBoxPassport.TabIndex = 12;
            // 
            // textBoxTotalCost
            // 
            this.textBoxTotalCost.Location = new System.Drawing.Point(564, 501);
            this.textBoxTotalCost.Name = "textBoxTotalCost";
            this.textBoxTotalCost.ReadOnly = true;
            this.textBoxTotalCost.Size = new System.Drawing.Size(164, 20);
            this.textBoxTotalCost.TabIndex = 13;
            // 
            // textBoxFrom
            // 
            this.textBoxFrom.Location = new System.Drawing.Point(154, 394);
            this.textBoxFrom.Name = "textBoxFrom";
            this.textBoxFrom.ReadOnly = true;
            this.textBoxFrom.Size = new System.Drawing.Size(164, 20);
            this.textBoxFrom.TabIndex = 14;
            // 
            // textBoxFlightName
            // 
            this.textBoxFlightName.Location = new System.Drawing.Point(564, 186);
            this.textBoxFlightName.Name = "textBoxFlightName";
            this.textBoxFlightName.ReadOnly = true;
            this.textBoxFlightName.Size = new System.Drawing.Size(164, 20);
            this.textBoxFlightName.TabIndex = 15;
            // 
            // textBoxTo
            // 
            this.textBoxTo.Location = new System.Drawing.Point(154, 450);
            this.textBoxTo.Name = "textBoxTo";
            this.textBoxTo.ReadOnly = true;
            this.textBoxTo.Size = new System.Drawing.Size(164, 20);
            this.textBoxTo.TabIndex = 16;
            // 
            // Print
            // 
            this.Print.Location = new System.Drawing.Point(636, 525);
            this.Print.Name = "Print";
            this.Print.Size = new System.Drawing.Size(92, 28);
            this.Print.TabIndex = 17;
            this.Print.Text = "Print";
            this.Print.UseVisualStyleBackColor = true;
            this.Print.Click += new System.EventHandler(this.Print_Click_1);
            // 
            // Name1
            // 
            this.Name1.AutoSize = true;
            this.Name1.BackColor = System.Drawing.Color.Transparent;
            this.Name1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name1.Location = new System.Drawing.Point(59, 186);
            this.Name1.Name = "Name1";
            this.Name1.Size = new System.Drawing.Size(45, 17);
            this.Name1.TabIndex = 19;
            this.Name1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(454, 189);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 17);
            this.label2.TabIndex = 20;
            this.label2.Text = "Flight Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(498, 502);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 17);
            this.label3.TabIndex = 21;
            this.label3.Text = "Cost";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(491, 448);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 17);
            this.label4.TabIndex = 22;
            this.label4.Text = "Infant";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(497, 344);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 17);
            this.label5.TabIndex = 23;
            this.label5.Text = "Adult";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(470, 236);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 17);
            this.label6.TabIndex = 24;
            this.label6.Text = "Cabin";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(79, 450);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(25, 17);
            this.label7.TabIndex = 25;
            this.label7.Text = "To";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(64, 397);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(40, 17);
            this.label8.TabIndex = 26;
            this.label8.Text = "From";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(40, 341);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(64, 17);
            this.label9.TabIndex = 27;
            this.label9.Text = "Passport";
            this.label9.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(62, 287);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(42, 17);
            this.label10.TabIndex = 28;
            this.label10.Text = "Flight";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(497, 293);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(37, 17);
            this.label11.TabIndex = 29;
            this.label11.Text = "Seat";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(477, 397);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(60, 17);
            this.label12.TabIndex = 30;
            this.label12.Text = "Children";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(27, 127);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(100, 17);
            this.label13.TabIndex = 31;
            this.label13.Text = "Ticket Number";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(66, 499);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(38, 17);
            this.label14.TabIndex = 32;
            this.label14.Text = "Date";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.Transparent;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(47, 237);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(57, 17);
            this.label15.TabIndex = 33;
            this.label15.Text = "Care Of";
            // 
            // buttonMainMenu
            // 
            this.buttonMainMenu.Location = new System.Drawing.Point(29, 24);
            this.buttonMainMenu.Name = "buttonMainMenu";
            this.buttonMainMenu.Size = new System.Drawing.Size(75, 23);
            this.buttonMainMenu.TabIndex = 35;
            this.buttonMainMenu.Text = "Main Menu";
            this.buttonMainMenu.UseVisualStyleBackColor = true;
            this.buttonMainMenu.Click += new System.EventHandler(this.buttonMainMenu_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(564, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(164, 145);
            this.pictureBox2.TabIndex = 34;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::AirTrafficAndTicketManagement.Properties.Resources.Biman_Bangladesh_Airlines___Logo2;
            this.pictureBox1.Location = new System.Drawing.Point(154, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(152, 62);
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            // 
            // textBoxpicture
            // 
            this.textBoxpicture.Location = new System.Drawing.Point(374, 54);
            this.textBoxpicture.Name = "textBoxpicture";
            this.textBoxpicture.ReadOnly = true;
            this.textBoxpicture.Size = new System.Drawing.Size(100, 20);
            this.textBoxpicture.TabIndex = 36;
            this.textBoxpicture.Visible = false;
            // 
            // PrintTicket
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(758, 563);
            this.Controls.Add(this.textBoxpicture);
            this.Controls.Add(this.buttonMainMenu);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Name1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Print);
            this.Controls.Add(this.textBoxTo);
            this.Controls.Add(this.textBoxFlightName);
            this.Controls.Add(this.textBoxFrom);
            this.Controls.Add(this.textBoxTotalCost);
            this.Controls.Add(this.textBoxPassport);
            this.Controls.Add(this.textBoxDate);
            this.Controls.Add(this.textBoxCabin);
            this.Controls.Add(this.textBoxTicketNumber);
            this.Controls.Add(this.textBoxInfants);
            this.Controls.Add(this.textBoxAdult);
            this.Controls.Add(this.textBoxChildren);
            this.Controls.Add(this.textBoxSeat);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBoxFlight);
            this.Controls.Add(this.textBoxCO);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "PrintTicket";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Print";
            this.Load += new System.EventHandler(this.PrintTicket_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Windows.Forms.TextBox textBoxCO;
        private System.Windows.Forms.TextBox textBoxFlight;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBoxSeat;
        private System.Windows.Forms.TextBox textBoxChildren;
        private System.Windows.Forms.TextBox textBoxAdult;
        private System.Windows.Forms.TextBox textBoxInfants;
        private System.Windows.Forms.TextBox textBoxTicketNumber;
        private System.Windows.Forms.TextBox textBoxCabin;
        private System.Windows.Forms.TextBox textBoxDate;
        private System.Windows.Forms.TextBox textBoxPassport;
        private System.Windows.Forms.TextBox textBoxTotalCost;
        private System.Windows.Forms.TextBox textBoxFrom;
        private System.Windows.Forms.TextBox textBoxFlightName;
        private System.Windows.Forms.TextBox textBoxTo;
        private System.Windows.Forms.Button Print;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label Name1;
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
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button buttonMainMenu;
        private System.Windows.Forms.TextBox textBoxpicture;
    }
}