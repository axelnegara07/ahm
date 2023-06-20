namespace AHM
{
    partial class FormAddParameter
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
            this.chkSendServer = new System.Windows.Forms.CheckBox();
            this.txtMachineName = new System.Windows.Forms.TextBox();
            this.txtParameterName = new System.Windows.Forms.TextBox();
            this.cboTimes = new System.Windows.Forms.ComboBox();
            this.lblMachineName = new System.Windows.Forms.Label();
            this.lblParameterName = new System.Windows.Forms.Label();
            this.lblTimes = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.ahmDataSet0 = new AHM.AhmDataSet1();
            this.cONFIGURATIONBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cONFIGURATIONTableAdapter = new AHM.AhmDataSet1TableAdapters.CONFIGURATIONTableAdapter();
            this.tableAdapterManager = new AHM.AhmDataSet1TableAdapters.TableAdapterManager();
            this.lINETableAdapter = new AHM.AhmDataSet1TableAdapters.LINETableAdapter();
            this.mACHINETableAdapter = new AHM.AhmDataSet1TableAdapters.MACHINETableAdapter();
            this.pART_IDTableAdapter = new AHM.AhmDataSet1TableAdapters.PART_IDTableAdapter();
            this.pLANTTableAdapter = new AHM.AhmDataSet1TableAdapters.PLANTTableAdapter();
            this.pLANTBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lINEBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mACHINEBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pART_IDBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ahmDataSet0)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cONFIGURATIONBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pLANTBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lINEBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mACHINEBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pART_IDBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // chkSendServer
            // 
            this.chkSendServer.AutoSize = true;
            this.chkSendServer.Location = new System.Drawing.Point(25, 111);
            this.chkSendServer.Name = "chkSendServer";
            this.chkSendServer.Size = new System.Drawing.Size(114, 17);
            this.chkSendServer.TabIndex = 0;
            this.chkSendServer.Text = "Send To Server IT";
            this.chkSendServer.UseVisualStyleBackColor = true;
            // 
            // txtMachineName
            // 
            this.txtMachineName.Location = new System.Drawing.Point(119, 33);
            this.txtMachineName.Name = "txtMachineName";
            this.txtMachineName.ReadOnly = true;
            this.txtMachineName.Size = new System.Drawing.Size(100, 20);
            this.txtMachineName.TabIndex = 1;
            this.txtMachineName.TextChanged += new System.EventHandler(this.txtMachineName_TextChanged);
            // 
            // txtParameterName
            // 
            this.txtParameterName.Location = new System.Drawing.Point(120, 70);
            this.txtParameterName.Name = "txtParameterName";
            this.txtParameterName.Size = new System.Drawing.Size(100, 20);
            this.txtParameterName.TabIndex = 2;
            // 
            // cboTimes
            // 
            this.cboTimes.FormattingEnabled = true;
            this.cboTimes.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.cboTimes.Location = new System.Drawing.Point(120, 146);
            this.cboTimes.Name = "cboTimes";
            this.cboTimes.Size = new System.Drawing.Size(52, 21);
            this.cboTimes.TabIndex = 3;
            // 
            // lblMachineName
            // 
            this.lblMachineName.AutoSize = true;
            this.lblMachineName.Location = new System.Drawing.Point(25, 35);
            this.lblMachineName.Name = "lblMachineName";
            this.lblMachineName.Size = new System.Drawing.Size(79, 13);
            this.lblMachineName.TabIndex = 11;
            this.lblMachineName.Text = "Machine Name";
            // 
            // lblParameterName
            // 
            this.lblParameterName.AutoSize = true;
            this.lblParameterName.Location = new System.Drawing.Point(25, 73);
            this.lblParameterName.Name = "lblParameterName";
            this.lblParameterName.Size = new System.Drawing.Size(86, 13);
            this.lblParameterName.TabIndex = 12;
            this.lblParameterName.Text = "Parameter Name";
            // 
            // lblTimes
            // 
            this.lblTimes.AutoSize = true;
            this.lblTimes.Location = new System.Drawing.Point(25, 149);
            this.lblTimes.Name = "lblTimes";
            this.lblTimes.Size = new System.Drawing.Size(30, 13);
            this.lblTimes.TabIndex = 13;
            this.lblTimes.Text = "Time";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(24, 213);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(84, 23);
            this.btnSave.TabIndex = 16;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(165, 213);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 15;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // ahmDataSet0
            // 
            this.ahmDataSet0.DataSetName = "AhmDataSet1";
            this.ahmDataSet0.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cONFIGURATIONBindingSource
            // 
            this.cONFIGURATIONBindingSource.DataMember = "CONFIGURATION";
            this.cONFIGURATIONBindingSource.DataSource = this.ahmDataSet0;
            // 
            // cONFIGURATIONTableAdapter
            // 
            this.cONFIGURATIONTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CONFIGURATIONTableAdapter = this.cONFIGURATIONTableAdapter;
            this.tableAdapterManager.DEPTTableAdapter = null;
            this.tableAdapterManager.LINETableAdapter = this.lINETableAdapter;
            this.tableAdapterManager.MACHINETableAdapter = this.mACHINETableAdapter;
            this.tableAdapterManager.PART_IDTableAdapter = this.pART_IDTableAdapter;
            this.tableAdapterManager.PLANTTableAdapter = this.pLANTTableAdapter;
            this.tableAdapterManager.SUB_DEPTTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = AHM.AhmDataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.WCTTableAdapter = null;
            // 
            // lINETableAdapter
            // 
            this.lINETableAdapter.ClearBeforeFill = true;
            // 
            // mACHINETableAdapter
            // 
            this.mACHINETableAdapter.ClearBeforeFill = true;
            // 
            // pART_IDTableAdapter
            // 
            this.pART_IDTableAdapter.ClearBeforeFill = true;
            // 
            // pLANTTableAdapter
            // 
            this.pLANTTableAdapter.ClearBeforeFill = true;
            // 
            // pLANTBindingSource
            // 
            this.pLANTBindingSource.DataMember = "FK_PLANT_CONFIGURATION";
            this.pLANTBindingSource.DataSource = this.cONFIGURATIONBindingSource;
            // 
            // lINEBindingSource
            // 
            this.lINEBindingSource.DataMember = "FK_LINE_PLANT";
            this.lINEBindingSource.DataSource = this.pLANTBindingSource;
            // 
            // mACHINEBindingSource
            // 
            this.mACHINEBindingSource.DataMember = "FK_MACHINE_LINE";
            this.mACHINEBindingSource.DataSource = this.lINEBindingSource;
            // 
            // pART_IDBindingSource
            // 
            this.pART_IDBindingSource.DataMember = "FK_PART_ID_MACHINE";
            this.pART_IDBindingSource.DataSource = this.mACHINEBindingSource;
            // 
            // FormAddParameter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(262, 263);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.lblTimes);
            this.Controls.Add(this.lblParameterName);
            this.Controls.Add(this.lblMachineName);
            this.Controls.Add(this.cboTimes);
            this.Controls.Add(this.txtParameterName);
            this.Controls.Add(this.txtMachineName);
            this.Controls.Add(this.chkSendServer);
            this.Name = "FormAddParameter";
            this.Text = "Add Parameter Wizard";
            this.Load += new System.EventHandler(this.FormAddParameter_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ahmDataSet0)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cONFIGURATIONBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pLANTBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lINEBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mACHINEBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pART_IDBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox chkSendServer;
        private System.Windows.Forms.TextBox txtMachineName;
        private System.Windows.Forms.TextBox txtParameterName;
        private System.Windows.Forms.ComboBox cboTimes;
        private System.Windows.Forms.Label lblMachineName;
        private System.Windows.Forms.Label lblParameterName;
        private System.Windows.Forms.Label lblTimes;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private AhmDataSet1 ahmDataSet0;
        private System.Windows.Forms.BindingSource cONFIGURATIONBindingSource;
        private AhmDataSet1TableAdapters.CONFIGURATIONTableAdapter cONFIGURATIONTableAdapter;
        private AhmDataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private AhmDataSet1TableAdapters.LINETableAdapter lINETableAdapter;
        private AhmDataSet1TableAdapters.MACHINETableAdapter mACHINETableAdapter;
        private AhmDataSet1TableAdapters.PART_IDTableAdapter pART_IDTableAdapter;
        private AhmDataSet1TableAdapters.PLANTTableAdapter pLANTTableAdapter;
        private System.Windows.Forms.BindingSource pLANTBindingSource;
        private System.Windows.Forms.BindingSource lINEBindingSource;
        private System.Windows.Forms.BindingSource mACHINEBindingSource;
        private System.Windows.Forms.BindingSource pART_IDBindingSource;
    }
}