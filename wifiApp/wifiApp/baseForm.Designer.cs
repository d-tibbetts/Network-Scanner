namespace wifiApp
{
    partial class fmWifiApp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fmWifiApp));
            this.notifyIconMessages = new System.Windows.Forms.NotifyIcon(this.components);
            this.backgroundWorkerPythonScript = new System.ComponentModel.BackgroundWorker();
            this.progressBarPython = new System.Windows.Forms.ProgressBar();
            this.lblProgress = new System.Windows.Forms.Label();
            this.menuStripBaseForm = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.profileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewAndChangeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutUsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.mACaddressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.connectiontimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.allowDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.corbinBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this._Database_WIFIDataSet = new wifiApp._Database_WIFIDataSet();
            this.corbinTableAdapter = new wifiApp._Database_WIFIDataSetTableAdapters.corbinTableAdapter();
            this.labelUpdateUser = new System.Windows.Forms.Label();
            this.toolTipBaseform = new System.Windows.Forms.ToolTip(this.components);
            this.refreshTableToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStripBaseForm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.corbinBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._Database_WIFIDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // notifyIconMessages
            // 
            this.notifyIconMessages.Icon = global::wifiApp.Properties.Resources.Wifi_Transparent;
            this.notifyIconMessages.Text = "Who\'s Stealing My Wifi";
            this.notifyIconMessages.Visible = true;
            this.notifyIconMessages.BalloonTipClicked += new System.EventHandler(this.notifyIconMessages_BalloonTipClicked);
            this.notifyIconMessages.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIconMessages_MouseDoubleClick);
            // 
            // backgroundWorkerPythonScript
            // 
            this.backgroundWorkerPythonScript.WorkerReportsProgress = true;
            this.backgroundWorkerPythonScript.WorkerSupportsCancellation = true;
            this.backgroundWorkerPythonScript.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorkerPythonScript_DoWork);
            this.backgroundWorkerPythonScript.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorkerPythonScript_ProgressChanged);
            this.backgroundWorkerPythonScript.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorkerPythonScript_RunWorkerCompleted);
            // 
            // progressBarPython
            // 
            this.progressBarPython.Location = new System.Drawing.Point(15, 356);
            this.progressBarPython.Name = "progressBarPython";
            this.progressBarPython.Size = new System.Drawing.Size(480, 30);
            this.progressBarPython.TabIndex = 1;
            this.progressBarPython.Visible = false;
            // 
            // lblProgress
            // 
            this.lblProgress.AutoSize = true;
            this.lblProgress.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProgress.Location = new System.Drawing.Point(165, 338);
            this.lblProgress.Name = "lblProgress";
            this.lblProgress.Size = new System.Drawing.Size(154, 15);
            this.lblProgress.TabIndex = 2;
            this.lblProgress.Text = "Scan in progress...0%";
            this.lblProgress.Visible = false;
            // 
            // menuStripBaseForm
            // 
            this.menuStripBaseForm.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStripBaseForm.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.refreshTableToolStripMenuItem,
            this.profileToolStripMenuItem,
            this.searchToolStripMenuItem,
            this.aboutUsToolStripMenuItem});
            this.menuStripBaseForm.Location = new System.Drawing.Point(0, 0);
            this.menuStripBaseForm.Name = "menuStripBaseForm";
            this.menuStripBaseForm.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            this.menuStripBaseForm.Size = new System.Drawing.Size(515, 24);
            this.menuStripBaseForm.TabIndex = 3;
            this.menuStripBaseForm.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(47, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(102, 22);
            this.exitToolStripMenuItem.Text = "E&xit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // profileToolStripMenuItem
            // 
            this.profileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewAndChangeToolStripMenuItem});
            this.profileToolStripMenuItem.Name = "profileToolStripMenuItem";
            this.profileToolStripMenuItem.Size = new System.Drawing.Size(68, 20);
            this.profileToolStripMenuItem.Text = "Profile";
            // 
            // viewAndChangeToolStripMenuItem
            // 
            this.viewAndChangeToolStripMenuItem.Name = "viewAndChangeToolStripMenuItem";
            this.viewAndChangeToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
            this.viewAndChangeToolStripMenuItem.Text = "View and Change";
            this.viewAndChangeToolStripMenuItem.Click += new System.EventHandler(this.viewAndChangeToolStripMenuItem_Click);
            // 
            // searchToolStripMenuItem
            // 
            this.searchToolStripMenuItem.Name = "searchToolStripMenuItem";
            this.searchToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.searchToolStripMenuItem.Text = "Search";
            this.searchToolStripMenuItem.Click += new System.EventHandler(this.searchToolStripMenuItem_Click);
            // 
            // aboutUsToolStripMenuItem
            // 
            this.aboutUsToolStripMenuItem.Name = "aboutUsToolStripMenuItem";
            this.aboutUsToolStripMenuItem.Size = new System.Drawing.Size(75, 20);
            this.aboutUsToolStripMenuItem.Text = "About Us";
            this.aboutUsToolStripMenuItem.Click += new System.EventHandler(this.aboutUsToolStripMenuItem_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.mACaddressDataGridViewTextBoxColumn,
            this.connectiontimeDataGridViewTextBoxColumn,
            this.allowDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.corbinBindingSource;
            this.dataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGridView1.Location = new System.Drawing.Point(15, 123);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dataGridView1.Size = new System.Drawing.Size(480, 169);
            this.dataGridView1.TabIndex = 4;
            this.toolTipBaseform.SetToolTip(this.dataGridView1, "Double click to update connection");
            this.dataGridView1.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseDoubleClick);
            // 
            // mACaddressDataGridViewTextBoxColumn
            // 
            this.mACaddressDataGridViewTextBoxColumn.DataPropertyName = "MAC_address";
            this.mACaddressDataGridViewTextBoxColumn.HeaderText = "MAC_address";
            this.mACaddressDataGridViewTextBoxColumn.Name = "mACaddressDataGridViewTextBoxColumn";
            this.mACaddressDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // connectiontimeDataGridViewTextBoxColumn
            // 
            this.connectiontimeDataGridViewTextBoxColumn.DataPropertyName = "connection_time";
            this.connectiontimeDataGridViewTextBoxColumn.HeaderText = "connection_time";
            this.connectiontimeDataGridViewTextBoxColumn.Name = "connectiontimeDataGridViewTextBoxColumn";
            this.connectiontimeDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // allowDataGridViewTextBoxColumn
            // 
            this.allowDataGridViewTextBoxColumn.DataPropertyName = "allow";
            this.allowDataGridViewTextBoxColumn.HeaderText = "allow";
            this.allowDataGridViewTextBoxColumn.Name = "allowDataGridViewTextBoxColumn";
            this.allowDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // corbinBindingSource
            // 
            this.corbinBindingSource.DataMember = "corbin";
            this.corbinBindingSource.DataSource = this._Database_WIFIDataSet;
            // 
            // _Database_WIFIDataSet
            // 
            this._Database_WIFIDataSet.DataSetName = "_Database_WIFIDataSet";
            this._Database_WIFIDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // corbinTableAdapter
            // 
            this.corbinTableAdapter.ClearBeforeFill = true;
            // 
            // labelUpdateUser
            // 
            this.labelUpdateUser.AutoSize = true;
            this.labelUpdateUser.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUpdateUser.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.labelUpdateUser.Location = new System.Drawing.Point(12, 295);
            this.labelUpdateUser.Name = "labelUpdateUser";
            this.labelUpdateUser.Size = new System.Drawing.Size(483, 14);
            this.labelUpdateUser.TabIndex = 5;
            this.labelUpdateUser.Text = "Scans can take up to 5 minutes depending on your internet connection";
            this.labelUpdateUser.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelUpdateUser.Visible = false;
            // 
            // refreshTableToolStripMenuItem
            // 
            this.refreshTableToolStripMenuItem.Name = "refreshTableToolStripMenuItem";
            this.refreshTableToolStripMenuItem.Size = new System.Drawing.Size(110, 20);
            this.refreshTableToolStripMenuItem.Text = "Refresh Table";
            this.refreshTableToolStripMenuItem.Click += new System.EventHandler(this.refreshTableToolStripMenuItem_Click);
            // 
            // fmWifiApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.BackgroundImage = global::wifiApp.Properties.Resources.wifiTransparentSmaller;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(515, 398);
            this.Controls.Add(this.labelUpdateUser);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lblProgress);
            this.Controls.Add(this.progressBarPython);
            this.Controls.Add(this.menuStripBaseForm);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStripBaseForm;
            this.MaximizeBox = false;
            this.Name = "fmWifiApp";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Who\'s Stealing My Wifi?";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.fmWifiApp_FormClosing);
            this.Load += new System.EventHandler(this.fmWifiApp_Load);
            this.menuStripBaseForm.ResumeLayout(false);
            this.menuStripBaseForm.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.corbinBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._Database_WIFIDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NotifyIcon notifyIconMessages;
        private System.ComponentModel.BackgroundWorker backgroundWorkerPythonScript;
        private System.Windows.Forms.ProgressBar progressBarPython;
        private System.Windows.Forms.Label lblProgress;
        private System.Windows.Forms.MenuStrip menuStripBaseForm;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem profileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem searchToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewAndChangeToolStripMenuItem;
        private _Database_WIFIDataSet _Database_WIFIDataSet;
        private System.Windows.Forms.BindingSource corbinBindingSource;
        private _Database_WIFIDataSetTableAdapters.corbinTableAdapter corbinTableAdapter;
        private System.Windows.Forms.Label labelUpdateUser;
        private System.Windows.Forms.ToolStripMenuItem aboutUsToolStripMenuItem;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ToolTip toolTipBaseform;
        private System.Windows.Forms.DataGridViewTextBoxColumn mACaddressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn connectiontimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn allowDataGridViewTextBoxColumn;
        private System.Windows.Forms.ToolStripMenuItem refreshTableToolStripMenuItem;


    }
}

