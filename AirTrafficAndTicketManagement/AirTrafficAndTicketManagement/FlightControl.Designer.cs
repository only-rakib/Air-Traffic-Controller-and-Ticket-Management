namespace AirTrafficAndTicketManagement
{
    partial class FlightControl
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FlightControl));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.cell_del = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.flightNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fromDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.departureTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.araivalTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.araivalDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.availableSeatForFirstClassDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.availableSeatForBusinessClassDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.availableSeatForEconomyClassDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.costOfFirstClassDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.costOfBusinessClassDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.costOfEconomyClassDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aTCFlightListBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.aTC_and_TicketDataSet = new AirTrafficAndTicketManagement.ATC_and_TicketDataSet();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonBack = new System.Windows.Forms.Button();
            this.aTCFlightListTableAdapter = new AirTrafficAndTicketManagement.ATC_and_TicketDataSetTableAdapters.ATCFlightListTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aTCFlightListBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aTC_and_TicketDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cell_del,
            this.flightNameDataGridViewTextBoxColumn,
            this.fromDataGridViewTextBoxColumn,
            this.toDataGridViewTextBoxColumn,
            this.dateDataGridViewTextBoxColumn,
            this.departureTimeDataGridViewTextBoxColumn,
            this.araivalTimeDataGridViewTextBoxColumn,
            this.araivalDateDataGridViewTextBoxColumn,
            this.availableSeatForFirstClassDataGridViewTextBoxColumn,
            this.availableSeatForBusinessClassDataGridViewTextBoxColumn,
            this.availableSeatForEconomyClassDataGridViewTextBoxColumn,
            this.costOfFirstClassDataGridViewTextBoxColumn,
            this.costOfBusinessClassDataGridViewTextBoxColumn,
            this.costOfEconomyClassDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.aTCFlightListBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1202, 288);
            this.dataGridView1.TabIndex = 0;
            // 
            // cell_del
            // 
            this.cell_del.HeaderText = "Delete";
            this.cell_del.Name = "cell_del";
            this.cell_del.TrueValue = "Yes";
            // 
            // flightNameDataGridViewTextBoxColumn
            // 
            this.flightNameDataGridViewTextBoxColumn.DataPropertyName = "Flight Name";
            this.flightNameDataGridViewTextBoxColumn.HeaderText = "Flight Name";
            this.flightNameDataGridViewTextBoxColumn.Name = "flightNameDataGridViewTextBoxColumn";
            // 
            // fromDataGridViewTextBoxColumn
            // 
            this.fromDataGridViewTextBoxColumn.DataPropertyName = "From";
            this.fromDataGridViewTextBoxColumn.HeaderText = "From";
            this.fromDataGridViewTextBoxColumn.Name = "fromDataGridViewTextBoxColumn";
            // 
            // toDataGridViewTextBoxColumn
            // 
            this.toDataGridViewTextBoxColumn.DataPropertyName = "To";
            this.toDataGridViewTextBoxColumn.HeaderText = "To";
            this.toDataGridViewTextBoxColumn.Name = "toDataGridViewTextBoxColumn";
            // 
            // dateDataGridViewTextBoxColumn
            // 
            this.dateDataGridViewTextBoxColumn.DataPropertyName = "Date";
            this.dateDataGridViewTextBoxColumn.HeaderText = "Date";
            this.dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
            // 
            // departureTimeDataGridViewTextBoxColumn
            // 
            this.departureTimeDataGridViewTextBoxColumn.DataPropertyName = "Departure Time";
            this.departureTimeDataGridViewTextBoxColumn.HeaderText = "Departure Time";
            this.departureTimeDataGridViewTextBoxColumn.Name = "departureTimeDataGridViewTextBoxColumn";
            // 
            // araivalTimeDataGridViewTextBoxColumn
            // 
            this.araivalTimeDataGridViewTextBoxColumn.DataPropertyName = "Araival Time";
            this.araivalTimeDataGridViewTextBoxColumn.HeaderText = "Araival Time";
            this.araivalTimeDataGridViewTextBoxColumn.Name = "araivalTimeDataGridViewTextBoxColumn";
            // 
            // araivalDateDataGridViewTextBoxColumn
            // 
            this.araivalDateDataGridViewTextBoxColumn.DataPropertyName = "Araival Date";
            this.araivalDateDataGridViewTextBoxColumn.HeaderText = "Araival Date";
            this.araivalDateDataGridViewTextBoxColumn.Name = "araivalDateDataGridViewTextBoxColumn";
            // 
            // availableSeatForFirstClassDataGridViewTextBoxColumn
            // 
            this.availableSeatForFirstClassDataGridViewTextBoxColumn.DataPropertyName = "AvailableSeatForFirstClass";
            this.availableSeatForFirstClassDataGridViewTextBoxColumn.HeaderText = "AvailableSeatForFirstClass";
            this.availableSeatForFirstClassDataGridViewTextBoxColumn.Name = "availableSeatForFirstClassDataGridViewTextBoxColumn";
            // 
            // availableSeatForBusinessClassDataGridViewTextBoxColumn
            // 
            this.availableSeatForBusinessClassDataGridViewTextBoxColumn.DataPropertyName = "AvailableSeatForBusinessClass";
            this.availableSeatForBusinessClassDataGridViewTextBoxColumn.HeaderText = "AvailableSeatForBusinessClass";
            this.availableSeatForBusinessClassDataGridViewTextBoxColumn.Name = "availableSeatForBusinessClassDataGridViewTextBoxColumn";
            // 
            // availableSeatForEconomyClassDataGridViewTextBoxColumn
            // 
            this.availableSeatForEconomyClassDataGridViewTextBoxColumn.DataPropertyName = "AvailableSeatForEconomyClass";
            this.availableSeatForEconomyClassDataGridViewTextBoxColumn.HeaderText = "AvailableSeatForEconomyClass";
            this.availableSeatForEconomyClassDataGridViewTextBoxColumn.Name = "availableSeatForEconomyClassDataGridViewTextBoxColumn";
            // 
            // costOfFirstClassDataGridViewTextBoxColumn
            // 
            this.costOfFirstClassDataGridViewTextBoxColumn.DataPropertyName = "Cost of First Class";
            this.costOfFirstClassDataGridViewTextBoxColumn.HeaderText = "Cost of First Class";
            this.costOfFirstClassDataGridViewTextBoxColumn.Name = "costOfFirstClassDataGridViewTextBoxColumn";
            // 
            // costOfBusinessClassDataGridViewTextBoxColumn
            // 
            this.costOfBusinessClassDataGridViewTextBoxColumn.DataPropertyName = "Cost of Business Class";
            this.costOfBusinessClassDataGridViewTextBoxColumn.HeaderText = "Cost of Business Class";
            this.costOfBusinessClassDataGridViewTextBoxColumn.Name = "costOfBusinessClassDataGridViewTextBoxColumn";
            // 
            // costOfEconomyClassDataGridViewTextBoxColumn
            // 
            this.costOfEconomyClassDataGridViewTextBoxColumn.DataPropertyName = "Cost of Economy Class";
            this.costOfEconomyClassDataGridViewTextBoxColumn.HeaderText = "Cost of Economy Class";
            this.costOfEconomyClassDataGridViewTextBoxColumn.Name = "costOfEconomyClassDataGridViewTextBoxColumn";
            // 
            // aTCFlightListBindingSource
            // 
            this.aTCFlightListBindingSource.DataMember = "ATCFlightList";
            this.aTCFlightListBindingSource.DataSource = this.aTC_and_TicketDataSet;
            this.aTCFlightListBindingSource.AddingNew += new System.ComponentModel.AddingNewEventHandler(this.aTCFlightListBindingSource_AddingNew);
            // 
            // aTC_and_TicketDataSet
            // 
            this.aTC_and_TicketDataSet.DataSetName = "ATC_and_TicketDataSet";
            this.aTC_and_TicketDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(1058, 427);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(99, 34);
            this.buttonSave.TabIndex = 1;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(902, 427);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(104, 34);
            this.buttonDelete.TabIndex = 2;
            this.buttonDelete.Text = "Delete";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonBack
            // 
            this.buttonBack.Location = new System.Drawing.Point(102, 427);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(83, 34);
            this.buttonBack.TabIndex = 3;
            this.buttonBack.Text = "Back";
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // aTCFlightListTableAdapter
            // 
            this.aTCFlightListTableAdapter.ClearBeforeFill = true;
            // 
            // FlightControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::AirTrafficAndTicketManagement.Properties.Resources.abstract_color_background_picture_8016_1280x800;
            this.ClientSize = new System.Drawing.Size(1226, 500);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FlightControl";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FlightControl";
            this.Load += new System.EventHandler(this.FlightControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aTCFlightListBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aTC_and_TicketDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private ATC_and_TicketDataSet aTC_and_TicketDataSet;
        private System.Windows.Forms.BindingSource aTCFlightListBindingSource;
        private ATC_and_TicketDataSetTableAdapters.ATCFlightListTableAdapter aTCFlightListTableAdapter;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.DataGridViewCheckBoxColumn cell_del;
        private System.Windows.Forms.DataGridViewTextBoxColumn flightNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fromDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn toDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn departureTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn araivalTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn araivalDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn availableSeatForFirstClassDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn availableSeatForBusinessClassDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn availableSeatForEconomyClassDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn costOfFirstClassDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn costOfBusinessClassDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn costOfEconomyClassDataGridViewTextBoxColumn;
    }
}