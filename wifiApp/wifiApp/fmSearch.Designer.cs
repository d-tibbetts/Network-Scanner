namespace wifiApp
{
    partial class fmSearch
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
            this.dateTimePickerSearch = new System.Windows.Forms.DateTimePicker();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.usernameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mACaddressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.connectiontimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.disconnecttimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.allowDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.corbinBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this._Database_WIFIDataSet1 = new wifiApp._Database_WIFIDataSet1();
            this.bttnSearch = new System.Windows.Forms.Button();
            this._Database_WIFIDataSet = new wifiApp._Database_WIFIDataSet();
            this.databaseWIFIDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.corbinTableAdapter = new wifiApp._Database_WIFIDataSet1TableAdapters.corbinTableAdapter();
            this.radioButtondate = new System.Windows.Forms.RadioButton();
            this.radioButtonMac = new System.Windows.Forms.RadioButton();
            this.textBoxMacAddress = new System.Windows.Forms.TextBox();
            this.groupBoxSelectSearch = new System.Windows.Forms.GroupBox();
            this.toolTipSearch = new System.Windows.Forms.ToolTip(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.corbinBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._Database_WIFIDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._Database_WIFIDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseWIFIDataSetBindingSource)).BeginInit();
            this.groupBoxSelectSearch.SuspendLayout();
            this.SuspendLayout();
            // 
            // dateTimePickerSearch
            // 
            this.dateTimePickerSearch.CalendarForeColor = System.Drawing.SystemColors.HotTrack;
            this.dateTimePickerSearch.CalendarMonthBackground = System.Drawing.SystemColors.Info;
            this.dateTimePickerSearch.CustomFormat = "yyyy-MM-dd";
            this.dateTimePickerSearch.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerSearch.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerSearch.Location = new System.Drawing.Point(26, 19);
            this.dateTimePickerSearch.Name = "dateTimePickerSearch";
            this.dateTimePickerSearch.Size = new System.Drawing.Size(190, 26);
            this.dateTimePickerSearch.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Location = new System.Drawing.Point(31, 202);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(451, 184);
            this.panel1.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.usernameDataGridViewTextBoxColumn,
            this.mACaddressDataGridViewTextBoxColumn,
            this.connectiontimeDataGridViewTextBoxColumn,
            this.disconnecttimeDataGridViewTextBoxColumn,
            this.allowDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.corbinBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(451, 184);
            this.dataGridView1.TabIndex = 0;
            this.toolTipSearch.SetToolTip(this.dataGridView1, "Your search results will appear here after clicking the search button");
            // 
            // usernameDataGridViewTextBoxColumn
            // 
            this.usernameDataGridViewTextBoxColumn.DataPropertyName = "Username";
            this.usernameDataGridViewTextBoxColumn.HeaderText = "Username";
            this.usernameDataGridViewTextBoxColumn.Name = "usernameDataGridViewTextBoxColumn";
            this.usernameDataGridViewTextBoxColumn.ReadOnly = true;
            this.usernameDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // mACaddressDataGridViewTextBoxColumn
            // 
            this.mACaddressDataGridViewTextBoxColumn.DataPropertyName = "MAC_address";
            this.mACaddressDataGridViewTextBoxColumn.HeaderText = "MAC_address";
            this.mACaddressDataGridViewTextBoxColumn.Name = "mACaddressDataGridViewTextBoxColumn";
            this.mACaddressDataGridViewTextBoxColumn.ReadOnly = true;
            this.mACaddressDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // connectiontimeDataGridViewTextBoxColumn
            // 
            this.connectiontimeDataGridViewTextBoxColumn.DataPropertyName = "connection_time";
            this.connectiontimeDataGridViewTextBoxColumn.HeaderText = "connection_time";
            this.connectiontimeDataGridViewTextBoxColumn.Name = "connectiontimeDataGridViewTextBoxColumn";
            this.connectiontimeDataGridViewTextBoxColumn.ReadOnly = true;
            this.connectiontimeDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // disconnecttimeDataGridViewTextBoxColumn
            // 
            this.disconnecttimeDataGridViewTextBoxColumn.DataPropertyName = "disconnect_time";
            this.disconnecttimeDataGridViewTextBoxColumn.HeaderText = "disconnect_time";
            this.disconnecttimeDataGridViewTextBoxColumn.Name = "disconnecttimeDataGridViewTextBoxColumn";
            this.disconnecttimeDataGridViewTextBoxColumn.ReadOnly = true;
            this.disconnecttimeDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // allowDataGridViewTextBoxColumn
            // 
            this.allowDataGridViewTextBoxColumn.DataPropertyName = "allow";
            this.allowDataGridViewTextBoxColumn.HeaderText = "allow";
            this.allowDataGridViewTextBoxColumn.Name = "allowDataGridViewTextBoxColumn";
            this.allowDataGridViewTextBoxColumn.ReadOnly = true;
            this.allowDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // corbinBindingSource
            // 
            this.corbinBindingSource.DataMember = "corbin";
            this.corbinBindingSource.DataSource = this._Database_WIFIDataSet1;
            // 
            // _Database_WIFIDataSet1
            // 
            this._Database_WIFIDataSet1.DataSetName = "_Database_WIFIDataSet1";
            this._Database_WIFIDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bttnSearch
            // 
            this.bttnSearch.BackColor = System.Drawing.SystemColors.HighlightText;
            this.bttnSearch.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttnSearch.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.bttnSearch.Location = new System.Drawing.Point(391, 151);
            this.bttnSearch.Name = "bttnSearch";
            this.bttnSearch.Size = new System.Drawing.Size(88, 29);
            this.bttnSearch.TabIndex = 2;
            this.bttnSearch.Text = "Search";
            this.toolTipSearch.SetToolTip(this.bttnSearch, "Click button to search.");
            this.bttnSearch.UseVisualStyleBackColor = false;
            this.bttnSearch.Click += new System.EventHandler(this.bttnSearch_Click);
            // 
            // _Database_WIFIDataSet
            // 
            this._Database_WIFIDataSet.DataSetName = "_Database_WIFIDataSet";
            this._Database_WIFIDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // databaseWIFIDataSetBindingSource
            // 
            this.databaseWIFIDataSetBindingSource.DataSource = this._Database_WIFIDataSet;
            this.databaseWIFIDataSetBindingSource.Position = 0;
            // 
            // corbinTableAdapter
            // 
            this.corbinTableAdapter.ClearBeforeFill = true;
            // 
            // radioButtondate
            // 
            this.radioButtondate.AutoSize = true;
            this.radioButtondate.Location = new System.Drawing.Point(6, 24);
            this.radioButtondate.Name = "radioButtondate";
            this.radioButtondate.Size = new System.Drawing.Size(14, 13);
            this.radioButtondate.TabIndex = 4;
            this.radioButtondate.TabStop = true;
            this.radioButtondate.UseVisualStyleBackColor = true;
            // 
            // radioButtonMac
            // 
            this.radioButtonMac.AutoSize = true;
            this.radioButtonMac.Location = new System.Drawing.Point(6, 72);
            this.radioButtonMac.Name = "radioButtonMac";
            this.radioButtonMac.Size = new System.Drawing.Size(14, 13);
            this.radioButtonMac.TabIndex = 5;
            this.radioButtonMac.TabStop = true;
            this.radioButtonMac.UseVisualStyleBackColor = true;
            // 
            // textBoxMacAddress
            // 
            this.textBoxMacAddress.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxMacAddress.ForeColor = System.Drawing.Color.Gray;
            this.textBoxMacAddress.Location = new System.Drawing.Point(26, 65);
            this.textBoxMacAddress.Name = "textBoxMacAddress";
            this.textBoxMacAddress.Size = new System.Drawing.Size(190, 26);
            this.textBoxMacAddress.TabIndex = 6;
            this.textBoxMacAddress.Text = "Enter MAC address";
            this.textBoxMacAddress.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // groupBoxSelectSearch
            // 
            this.groupBoxSelectSearch.BackColor = System.Drawing.Color.Transparent;
            this.groupBoxSelectSearch.Controls.Add(this.dateTimePickerSearch);
            this.groupBoxSelectSearch.Controls.Add(this.radioButtonMac);
            this.groupBoxSelectSearch.Controls.Add(this.textBoxMacAddress);
            this.groupBoxSelectSearch.Controls.Add(this.radioButtondate);
            this.groupBoxSelectSearch.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxSelectSearch.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.groupBoxSelectSearch.Location = new System.Drawing.Point(31, 82);
            this.groupBoxSelectSearch.Name = "groupBoxSelectSearch";
            this.groupBoxSelectSearch.Size = new System.Drawing.Size(234, 114);
            this.groupBoxSelectSearch.TabIndex = 7;
            this.groupBoxSelectSearch.TabStop = false;
            this.groupBoxSelectSearch.Text = "Search";
            this.toolTipSearch.SetToolTip(this.groupBoxSelectSearch, "Select radio button and enter  the MAC address or select date from the drop down " +
        "menu.");
            // 
            // fmSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.BackgroundImage = global::wifiApp.Properties.Resources.wifiTransparentSmaller;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(521, 398);
            this.Controls.Add(this.groupBoxSelectSearch);
            this.Controls.Add(this.bttnSearch);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.Icon = global::wifiApp.Properties.Resources.Wifi_Transparent;
            this.Name = "fmSearch";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Who\'s Stealing My Wifi?";
            this.Load += new System.EventHandler(this.fmSearch_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.corbinBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._Database_WIFIDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._Database_WIFIDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseWIFIDataSetBindingSource)).EndInit();
            this.groupBoxSelectSearch.ResumeLayout(false);
            this.groupBoxSelectSearch.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePickerSearch;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button bttnSearch;
        private System.Windows.Forms.BindingSource databaseWIFIDataSetBindingSource;
        private _Database_WIFIDataSet _Database_WIFIDataSet;
        private _Database_WIFIDataSet1 _Database_WIFIDataSet1;
        private System.Windows.Forms.BindingSource corbinBindingSource;
        private _Database_WIFIDataSet1TableAdapters.corbinTableAdapter corbinTableAdapter;
        private System.Windows.Forms.RadioButton radioButtondate;
        private System.Windows.Forms.RadioButton radioButtonMac;
        private System.Windows.Forms.TextBox textBoxMacAddress;
        private System.Windows.Forms.GroupBox groupBoxSelectSearch;
        private System.Windows.Forms.ToolTip toolTipSearch;
        private System.Windows.Forms.DataGridViewTextBoxColumn usernameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mACaddressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn connectiontimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn disconnecttimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn allowDataGridViewTextBoxColumn;
    }
}