namespace AHM
{
    partial class FormModifyPlant
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
            this.ahmDataSet0 = new AHM.AhmDataSet1();
            this.cONFIGURATIONBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cONFIGURATIONTableAdapter = new AHM.AhmDataSet1TableAdapters.CONFIGURATIONTableAdapter();
            this.tableAdapterManager = new AHM.AhmDataSet1TableAdapters.TableAdapterManager();
            this.lINETableAdapter = new AHM.AhmDataSet1TableAdapters.LINETableAdapter();
            this.mACHINETableAdapter = new AHM.AhmDataSet1TableAdapters.MACHINETableAdapter();
            this.pART_IDTableAdapter = new AHM.AhmDataSet1TableAdapters.PART_IDTableAdapter();
            this.lINEBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mACHINEBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pART_IDBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pLANTBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pLANTTableAdapter = new AHM.AhmDataSet1TableAdapters.PLANTTableAdapter();
            this.cboVid = new System.Windows.Forms.ComboBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lblPlantName = new System.Windows.Forms.Label();
            this.lblVid = new System.Windows.Forms.Label();
            this.txtPlantName = new System.Windows.Forms.TextBox();
            this.pLANTBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ahmDataSet0)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cONFIGURATIONBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lINEBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mACHINEBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pART_IDBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pLANTBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pLANTBindingSource1)).BeginInit();
            this.SuspendLayout();
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
            this.tableAdapterManager.PLANTTableAdapter = null;
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
            // mACHINEBindingSource
            // 
            this.mACHINEBindingSource.DataSource = this.lINEBindingSource;
            // 
            // pART_IDBindingSource
            // 
            this.pART_IDBindingSource.DataSource = this.mACHINEBindingSource;
            // 
            // pLANTBindingSource
            // 
            this.pLANTBindingSource.DataMember = "PLANT";
            this.pLANTBindingSource.DataSource = this.ahmDataSet0;
            // 
            // pLANTTableAdapter
            // 
            this.pLANTTableAdapter.ClearBeforeFill = true;
            // 
            // cboVid
            // 
            this.cboVid.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.pLANTBindingSource, "plant_id", true));
            this.cboVid.FormattingEnabled = true;
            this.cboVid.Items.AddRange(new object[] {
            "1000",
            "1100",
            "1200",
            "1300",
            "1400",
            "1500"});
            this.cboVid.Location = new System.Drawing.Point(138, 70);
            this.cboVid.Name = "cboVid";
            this.cboVid.Size = new System.Drawing.Size(73, 21);
            this.cboVid.TabIndex = 0;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(28, 188);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(84, 23);
            this.btnSave.TabIndex = 16;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(169, 188);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 15;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // lblPlantName
            // 
            this.lblPlantName.AutoSize = true;
            this.lblPlantName.Location = new System.Drawing.Point(25, 35);
            this.lblPlantName.Name = "lblPlantName";
            this.lblPlantName.Size = new System.Drawing.Size(62, 13);
            this.lblPlantName.TabIndex = 17;
            this.lblPlantName.Text = "Plant Name";
            // 
            // lblVid
            // 
            this.lblVid.AutoSize = true;
            this.lblVid.Location = new System.Drawing.Point(25, 73);
            this.lblVid.Name = "lblVid";
            this.lblVid.Size = new System.Drawing.Size(25, 13);
            this.lblVid.TabIndex = 18;
            this.lblVid.Text = "VID";
            // 
            // txtPlantName
            // 
            this.txtPlantName.Location = new System.Drawing.Point(138, 35);
            this.txtPlantName.Name = "txtPlantName";
            this.txtPlantName.Size = new System.Drawing.Size(132, 20);
            this.txtPlantName.TabIndex = 19;
            // 
            // pLANTBindingSource1
            // 
            this.pLANTBindingSource1.DataMember = "FK_PLANT_CONFIGURATION";
            this.pLANTBindingSource1.DataSource = this.cONFIGURATIONBindingSource;
            // 
            // FormModifyPlant
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(321, 259);
            this.Controls.Add(this.txtPlantName);
            this.Controls.Add(this.lblVid);
            this.Controls.Add(this.lblPlantName);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.cboVid);
            this.Name = "FormModifyPlant";
            this.Text = "Modify Plant Wizard";
            this.Load += new System.EventHandler(this.FormModifyPlant_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ahmDataSet0)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cONFIGURATIONBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lINEBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mACHINEBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pART_IDBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pLANTBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pLANTBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private AhmDataSet1 ahmDataSet0;
        private System.Windows.Forms.BindingSource cONFIGURATIONBindingSource;
        private AhmDataSet1TableAdapters.CONFIGURATIONTableAdapter cONFIGURATIONTableAdapter;
        private AhmDataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private AhmDataSet1TableAdapters.LINETableAdapter lINETableAdapter;
        private AhmDataSet1TableAdapters.MACHINETableAdapter mACHINETableAdapter;
        private AhmDataSet1TableAdapters.PART_IDTableAdapter pART_IDTableAdapter;
        private System.Windows.Forms.BindingSource lINEBindingSource;
        private System.Windows.Forms.BindingSource mACHINEBindingSource;
        private System.Windows.Forms.BindingSource pART_IDBindingSource;
        private System.Windows.Forms.BindingSource pLANTBindingSource;
        private AhmDataSet1TableAdapters.PLANTTableAdapter pLANTTableAdapter;
        private System.Windows.Forms.ComboBox cboVid;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lblPlantName;
        private System.Windows.Forms.Label lblVid;
        private System.Windows.Forms.TextBox txtPlantName;
        private System.Windows.Forms.BindingSource pLANTBindingSource1;
    }
}