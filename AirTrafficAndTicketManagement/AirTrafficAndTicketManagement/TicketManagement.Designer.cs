namespace AirTrafficAndTicketManagement
{
    partial class TicketManagement
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TicketManagement));
            this.labelName = new System.Windows.Forms.Label();
            this.labelCareof = new System.Windows.Forms.Label();
            this.comboBoxChoose = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.labelFrom = new System.Windows.Forms.Label();
            this.labelTo = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxCO = new System.Windows.Forms.TextBox();
            this.comboBoxFrom = new System.Windows.Forms.ComboBox();
            this.comboBoxTo = new System.Windows.Forms.ComboBox();
            this.labelPassport = new System.Windows.Forms.Label();
            this.textBoxPassport = new System.Windows.Forms.TextBox();
            this.labelChooseDate = new System.Windows.Forms.Label();
            this.labelSelectCabin = new System.Windows.Forms.Label();
            this.comboBoxSelectCabin = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.buttonUpload = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBoxInfants = new System.Windows.Forms.ComboBox();
            this.comboBoxChildren = new System.Windows.Forms.ComboBox();
            this.comboBoxAdult = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxChildren = new System.Windows.Forms.TextBox();
            this.textBoxInfants = new System.Windows.Forms.TextBox();
            this.textBoxAdult = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.buttonBack = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.BackColor = System.Drawing.Color.Transparent;
            this.labelName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelName.Location = new System.Drawing.Point(29, 23);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(45, 17);
            this.labelName.TabIndex = 0;
            this.labelName.Text = "Name";
            // 
            // labelCareof
            // 
            this.labelCareof.AutoSize = true;
            this.labelCareof.BackColor = System.Drawing.Color.Transparent;
            this.labelCareof.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCareof.Location = new System.Drawing.Point(29, 53);
            this.labelCareof.Name = "labelCareof";
            this.labelCareof.Size = new System.Drawing.Size(32, 17);
            this.labelCareof.TabIndex = 1;
            this.labelCareof.Text = "C/O";
            // 
            // comboBoxChoose
            // 
            this.comboBoxChoose.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.comboBoxChoose.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxChoose.ForeColor = System.Drawing.SystemColors.Desktop;
            this.comboBoxChoose.FormattingEnabled = true;
            this.comboBoxChoose.Items.AddRange(new object[] {
            "Domestic",
            "International"});
            this.comboBoxChoose.Location = new System.Drawing.Point(178, 80);
            this.comboBoxChoose.Name = "comboBoxChoose";
            this.comboBoxChoose.Size = new System.Drawing.Size(120, 21);
            this.comboBoxChoose.TabIndex = 2;
            this.comboBoxChoose.SelectedIndexChanged += new System.EventHandler(this.comboBoxChoose_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(29, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Choose your flight";
            // 
            // labelFrom
            // 
            this.labelFrom.AutoSize = true;
            this.labelFrom.BackColor = System.Drawing.Color.Transparent;
            this.labelFrom.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFrom.Location = new System.Drawing.Point(29, 138);
            this.labelFrom.Name = "labelFrom";
            this.labelFrom.Size = new System.Drawing.Size(40, 17);
            this.labelFrom.TabIndex = 4;
            this.labelFrom.Text = "From";
            // 
            // labelTo
            // 
            this.labelTo.AutoSize = true;
            this.labelTo.BackColor = System.Drawing.Color.Transparent;
            this.labelTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTo.Location = new System.Drawing.Point(29, 175);
            this.labelTo.Name = "labelTo";
            this.labelTo.Size = new System.Drawing.Size(25, 17);
            this.labelTo.TabIndex = 5;
            this.labelTo.Text = "To";
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(178, 26);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(159, 20);
            this.textBoxName.TabIndex = 6;
            // 
            // textBoxCO
            // 
            this.textBoxCO.Location = new System.Drawing.Point(178, 52);
            this.textBoxCO.Name = "textBoxCO";
            this.textBoxCO.Size = new System.Drawing.Size(159, 20);
            this.textBoxCO.TabIndex = 7;
            // 
            // comboBoxFrom
            // 
            this.comboBoxFrom.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxFrom.FormattingEnabled = true;
            this.comboBoxFrom.Location = new System.Drawing.Point(178, 138);
            this.comboBoxFrom.Name = "comboBoxFrom";
            this.comboBoxFrom.Size = new System.Drawing.Size(120, 21);
            this.comboBoxFrom.TabIndex = 8;
            this.comboBoxFrom.SelectedIndexChanged += new System.EventHandler(this.comboBoxFrom_SelectedIndexChanged);
            // 
            // comboBoxTo
            // 
            this.comboBoxTo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxTo.FormattingEnabled = true;
            this.comboBoxTo.Location = new System.Drawing.Point(178, 175);
            this.comboBoxTo.Name = "comboBoxTo";
            this.comboBoxTo.Size = new System.Drawing.Size(120, 21);
            this.comboBoxTo.TabIndex = 9;
            // 
            // labelPassport
            // 
            this.labelPassport.AutoSize = true;
            this.labelPassport.BackColor = System.Drawing.Color.Transparent;
            this.labelPassport.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPassport.Location = new System.Drawing.Point(29, 107);
            this.labelPassport.Name = "labelPassport";
            this.labelPassport.Size = new System.Drawing.Size(90, 17);
            this.labelPassport.TabIndex = 11;
            this.labelPassport.Text = "Passport No.";
            this.labelPassport.Visible = false;
            // 
            // textBoxPassport
            // 
            this.textBoxPassport.Location = new System.Drawing.Point(178, 107);
            this.textBoxPassport.Name = "textBoxPassport";
            this.textBoxPassport.Size = new System.Drawing.Size(120, 20);
            this.textBoxPassport.TabIndex = 12;
            this.textBoxPassport.Visible = false;
            // 
            // labelChooseDate
            // 
            this.labelChooseDate.AutoSize = true;
            this.labelChooseDate.BackColor = System.Drawing.Color.Transparent;
            this.labelChooseDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelChooseDate.Location = new System.Drawing.Point(29, 211);
            this.labelChooseDate.Name = "labelChooseDate";
            this.labelChooseDate.Size = new System.Drawing.Size(90, 17);
            this.labelChooseDate.TabIndex = 13;
            this.labelChooseDate.Text = "Choose Date";
            // 
            // labelSelectCabin
            // 
            this.labelSelectCabin.AutoSize = true;
            this.labelSelectCabin.BackColor = System.Drawing.Color.Transparent;
            this.labelSelectCabin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSelectCabin.Location = new System.Drawing.Point(29, 250);
            this.labelSelectCabin.Name = "labelSelectCabin";
            this.labelSelectCabin.Size = new System.Drawing.Size(87, 17);
            this.labelSelectCabin.TabIndex = 15;
            this.labelSelectCabin.Text = "Select Cabin";
            // 
            // comboBoxSelectCabin
            // 
            this.comboBoxSelectCabin.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSelectCabin.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxSelectCabin.FormattingEnabled = true;
            this.comboBoxSelectCabin.Items.AddRange(new object[] {
            "First Class",
            "Business Class",
            "Economy Class"});
            this.comboBoxSelectCabin.Location = new System.Drawing.Point(178, 250);
            this.comboBoxSelectCabin.Name = "comboBoxSelectCabin";
            this.comboBoxSelectCabin.Size = new System.Drawing.Size(120, 21);
            this.comboBoxSelectCabin.TabIndex = 16;
            this.comboBoxSelectCabin.SelectedIndexChanged += new System.EventHandler(this.comboBoxSelectCabin_SelectedIndexChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.pictureBox1.Location = new System.Drawing.Point(457, 30);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(134, 129);
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            // 
            // buttonUpload
            // 
            this.buttonUpload.BackColor = System.Drawing.Color.Transparent;
            this.buttonUpload.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonUpload.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonUpload.Location = new System.Drawing.Point(489, 175);
            this.buttonUpload.Name = "buttonUpload";
            this.buttonUpload.Size = new System.Drawing.Size(73, 33);
            this.buttonUpload.TabIndex = 18;
            this.buttonUpload.Text = "Upload";
            this.buttonUpload.UseVisualStyleBackColor = false;
            this.buttonUpload.Click += new System.EventHandler(this.buttonUpload_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(464, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = "Use 130*130 pixels";
            // 
            // buttonSearch
            // 
            this.buttonSearch.BackColor = System.Drawing.Color.Transparent;
            this.buttonSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSearch.Location = new System.Drawing.Point(457, 426);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(130, 42);
            this.buttonSearch.TabIndex = 20;
            this.buttonSearch.Text = "Next";
            this.buttonSearch.UseVisualStyleBackColor = false;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(29, 289);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 17);
            this.label2.TabIndex = 21;
            this.label2.Text = "Number Of Ticket";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(175, 289);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 17);
            this.label4.TabIndex = 22;
            this.label4.Text = "Adult";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(300, 289);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(138, 17);
            this.label5.TabIndex = 23;
            this.label5.Text = "Children(2-11 years)";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(464, 289);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(144, 17);
            this.label6.TabIndex = 24;
            this.label6.Text = "Infants(under 2years)";
            // 
            // comboBoxInfants
            // 
            this.comboBoxInfants.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxInfants.FormattingEnabled = true;
            this.comboBoxInfants.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "More"});
            this.comboBoxInfants.Location = new System.Drawing.Point(470, 327);
            this.comboBoxInfants.Name = "comboBoxInfants";
            this.comboBoxInfants.Size = new System.Drawing.Size(70, 21);
            this.comboBoxInfants.TabIndex = 25;
            this.comboBoxInfants.SelectedIndexChanged += new System.EventHandler(this.comboBoxInfants_SelectedIndexChanged);
            // 
            // comboBoxChildren
            // 
            this.comboBoxChildren.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxChildren.FormattingEnabled = true;
            this.comboBoxChildren.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "More"});
            this.comboBoxChildren.Location = new System.Drawing.Point(303, 327);
            this.comboBoxChildren.Name = "comboBoxChildren";
            this.comboBoxChildren.Size = new System.Drawing.Size(74, 21);
            this.comboBoxChildren.TabIndex = 26;
            this.comboBoxChildren.SelectedIndexChanged += new System.EventHandler(this.comboBoxChildren_SelectedIndexChanged);
            // 
            // comboBoxAdult
            // 
            this.comboBoxAdult.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxAdult.FormattingEnabled = true;
            this.comboBoxAdult.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "More"});
            this.comboBoxAdult.Location = new System.Drawing.Point(173, 327);
            this.comboBoxAdult.Name = "comboBoxAdult";
            this.comboBoxAdult.Size = new System.Drawing.Size(71, 21);
            this.comboBoxAdult.TabIndex = 27;
            this.comboBoxAdult.SelectedIndexChanged += new System.EventHandler(this.comboBoxAdult_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Location = new System.Drawing.Point(64, 361);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 13);
            this.label7.TabIndex = 28;
            this.label7.Text = "Enter Number";
            this.label7.Visible = false;
            // 
            // textBoxChildren
            // 
            this.textBoxChildren.Location = new System.Drawing.Point(303, 358);
            this.textBoxChildren.Name = "textBoxChildren";
            this.textBoxChildren.Size = new System.Drawing.Size(74, 20);
            this.textBoxChildren.TabIndex = 29;
            this.textBoxChildren.Visible = false;
            // 
            // textBoxInfants
            // 
            this.textBoxInfants.Location = new System.Drawing.Point(470, 361);
            this.textBoxInfants.Name = "textBoxInfants";
            this.textBoxInfants.Size = new System.Drawing.Size(70, 20);
            this.textBoxInfants.TabIndex = 30;
            this.textBoxInfants.Visible = false;
            // 
            // textBoxAdult
            // 
            this.textBoxAdult.Location = new System.Drawing.Point(173, 358);
            this.textBoxAdult.Name = "textBoxAdult";
            this.textBoxAdult.Size = new System.Drawing.Size(71, 20);
            this.textBoxAdult.TabIndex = 31;
            this.textBoxAdult.Visible = false;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "yyyy-MM-dd";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(178, 211);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(107, 20);
            this.dateTimePicker1.TabIndex = 14;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // buttonBack
            // 
            this.buttonBack.BackColor = System.Drawing.Color.Transparent;
            this.buttonBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBack.Location = new System.Drawing.Point(32, 426);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(130, 42);
            this.buttonBack.TabIndex = 32;
            this.buttonBack.Text = "Back";
            this.buttonBack.UseVisualStyleBackColor = false;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // TicketManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::AirTrafficAndTicketManagement.Properties.Resources.sky_blue_background_hd_picture_1366x768;
            this.ClientSize = new System.Drawing.Size(627, 501);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.textBoxAdult);
            this.Controls.Add(this.textBoxInfants);
            this.Controls.Add(this.textBoxChildren);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.comboBoxAdult);
            this.Controls.Add(this.comboBoxChildren);
            this.Controls.Add(this.comboBoxInfants);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.buttonUpload);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.comboBoxSelectCabin);
            this.Controls.Add(this.labelSelectCabin);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.labelChooseDate);
            this.Controls.Add(this.textBoxPassport);
            this.Controls.Add(this.labelPassport);
            this.Controls.Add(this.comboBoxTo);
            this.Controls.Add(this.comboBoxFrom);
            this.Controls.Add(this.textBoxCO);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.labelTo);
            this.Controls.Add(this.labelFrom);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxChoose);
            this.Controls.Add(this.labelCareof);
            this.Controls.Add(this.labelName);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "TicketManagement";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ticket Management";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelCareof;
        private System.Windows.Forms.ComboBox comboBoxChoose;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelFrom;
        private System.Windows.Forms.Label labelTo;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxCO;
        private System.Windows.Forms.ComboBox comboBoxFrom;
        private System.Windows.Forms.ComboBox comboBoxTo;
        private System.Windows.Forms.TextBox textBoxPassport;
        //private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelPassport;
        private System.Windows.Forms.Label labelChooseDate;
        private System.Windows.Forms.Label labelSelectCabin;
        private System.Windows.Forms.ComboBox comboBoxSelectCabin;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button buttonUpload;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBoxInfants;
        private System.Windows.Forms.ComboBox comboBoxChildren;
        private System.Windows.Forms.ComboBox comboBoxAdult;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxChildren;
        private System.Windows.Forms.TextBox textBoxInfants;
        private System.Windows.Forms.TextBox textBoxAdult;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button buttonBack;
    }
}