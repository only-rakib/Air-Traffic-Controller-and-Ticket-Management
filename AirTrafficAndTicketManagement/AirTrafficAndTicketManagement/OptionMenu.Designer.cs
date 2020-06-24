namespace AirTrafficAndTicketManagement
{
    partial class OptionMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OptionMenu));
            this.buttonATC = new System.Windows.Forms.Button();
            this.buttonTicket = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonATC
            // 
            this.buttonATC.BackColor = System.Drawing.Color.Transparent;
            this.buttonATC.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonATC.FlatAppearance.BorderSize = 0;
            this.buttonATC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonATC.ForeColor = System.Drawing.Color.Transparent;
            this.buttonATC.Location = new System.Drawing.Point(288, 113);
            this.buttonATC.Name = "buttonATC";
            this.buttonATC.Size = new System.Drawing.Size(234, 80);
            this.buttonATC.TabIndex = 0;
            this.buttonATC.UseVisualStyleBackColor = false;
            this.buttonATC.Click += new System.EventHandler(this.buttonATC_Click);
            // 
            // buttonTicket
            // 
            this.buttonTicket.BackColor = System.Drawing.Color.Transparent;
            this.buttonTicket.FlatAppearance.BorderSize = 0;
            this.buttonTicket.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonTicket.ForeColor = System.Drawing.Color.Transparent;
            this.buttonTicket.Location = new System.Drawing.Point(291, 237);
            this.buttonTicket.Name = "buttonTicket";
            this.buttonTicket.Size = new System.Drawing.Size(230, 80);
            this.buttonTicket.TabIndex = 1;
            this.buttonTicket.UseVisualStyleBackColor = false;
            this.buttonTicket.Click += new System.EventHandler(this.buttonTicket_Click);
            // 
            // OptionMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::AirTrafficAndTicketManagement.Properties.Resources.option_Background;
            this.ClientSize = new System.Drawing.Size(727, 494);
            this.Controls.Add(this.buttonTicket);
            this.Controls.Add(this.buttonATC);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "OptionMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.OptionMenu_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonATC;
        private System.Windows.Forms.Button buttonTicket;
    }
}