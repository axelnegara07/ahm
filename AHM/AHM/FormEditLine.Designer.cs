namespace AHM
{
    partial class FormEditLine
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
            this.btnSave = new System.Windows.Forms.Button();
            this.lblWct = new System.Windows.Forms.Label();
            this.lblSubDept = new System.Windows.Forms.Label();
            this.lblDept = new System.Windows.Forms.Label();
            this.lblLineName = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.cboLineName = new System.Windows.Forms.ComboBox();
            this.cboDeptId = new System.Windows.Forms.ComboBox();
            this.dEPTBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ahmDataSet0 = new AHM.AhmDataSet1();
            this.cboSubDeptId = new System.Windows.Forms.ComboBox();
            this.sUB_DEPTBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cboWctId = new System.Windows.Forms.ComboBox();
            this.wCTBindingSource = new System.Windows.Forms.BindingSource(this.components);
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
            this.wCTTableAdapter = new AHM.AhmDataSet1TableAdapters.WCTTableAdapter();
            this.sUB_DEPTTableAdapter = new AHM.AhmDataSet1TableAdapters.SUB_DEPTTableAdapter();
            this.dEPTTableAdapter = new AHM.AhmDataSet1TableAdapters.DEPTTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dEPTBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ahmDataSet0)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sUB_DEPTBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wCTBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cONFIGURATIONBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pLANTBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lINEBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mACHINEBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pART_IDBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(24, 189);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(84, 23);
            this.btnSave.TabIndex = 24;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lblWct
            // 
            this.lblWct.AutoSize = true;
            this.lblWct.Location = new System.Drawing.Point(21, 139);
            this.lblWct.Name = "lblWct";
            this.lblWct.Size = new System.Drawing.Size(32, 13);
            this.lblWct.TabIndex = 23;
            this.lblWct.Text = "WCT";
            // 
            // lblSubDept
            // 
            this.lblSubDept.AutoSize = true;
            this.lblSubDept.Location = new System.Drawing.Point(21, 101);
            this.lblSubDept.Name = "lblSubDept";
            this.lblSubDept.Size = new System.Drawing.Size(52, 13);
            this.lblSubDept.TabIndex = 22;
            this.lblSubDept.Text = "Sub Dept";
            // 
            // lblDept
            // 
            this.lblDept.AutoSize = true;
            this.lblDept.Location = new System.Drawing.Point(21, 63);
            this.lblDept.Name = "lblDept";
            this.lblDept.Size = new System.Drawing.Size(30, 13);
            this.lblDept.TabIndex = 21;
            this.lblDept.Text = "Dept";
            // 
            // lblLineName
            // 
            this.lblLineName.AutoSize = true;
            this.lblLineName.Location = new System.Drawing.Point(21, 25);
            this.lblLineName.Name = "lblLineName";
            this.lblLineName.Size = new System.Drawing.Size(58, 13);
            this.lblLineName.TabIndex = 20;
            this.lblLineName.Text = "Line Name";
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(165, 189);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 19;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // cboLineName
            // 
            this.cboLineName.FormattingEnabled = true;
            this.cboLineName.Items.AddRange(new object[] {
            "CONVEYOR",
            "QUALITY"});
            this.cboLineName.Location = new System.Drawing.Point(150, 22);
            this.cboLineName.Name = "cboLineName";
            this.cboLineName.Size = new System.Drawing.Size(144, 21);
            this.cboLineName.TabIndex = 18;
            // 
            // cboDeptId
            // 
            this.cboDeptId.DataSource = this.dEPTBindingSource;
            this.cboDeptId.DisplayMember = "dept_code";
            this.cboDeptId.FormattingEnabled = true;
            this.cboDeptId.Location = new System.Drawing.Point(150, 60);
            this.cboDeptId.Name = "cboDeptId";
            this.cboDeptId.Size = new System.Drawing.Size(120, 21);
            this.cboDeptId.TabIndex = 17;
            this.cboDeptId.ValueMember = "dept_id";
            this.cboDeptId.SelectedIndexChanged += new System.EventHandler(this.cboDeptId_SelectedIndexChanged);
            // 
            // dEPTBindingSource
            // 
            this.dEPTBindingSource.DataMember = "DEPT";
            this.dEPTBindingSource.DataSource = this.ahmDataSet0;
            // 
            // ahmDataSet0
            // 
            this.ahmDataSet0.DataSetName = "AhmDataSet1";
            this.ahmDataSet0.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cboSubDeptId
            // 
            this.cboSubDeptId.DataSource = this.sUB_DEPTBindingSource;
            this.cboSubDeptId.DisplayMember = "sub_dept_code";
            this.cboSubDeptId.FormattingEnabled = true;
            this.cboSubDeptId.Location = new System.Drawing.Point(150, 98);
            this.cboSubDeptId.Name = "cboSubDeptId";
            this.cboSubDeptId.Size = new System.Drawing.Size(120, 21);
            this.cboSubDeptId.TabIndex = 16;
            this.cboSubDeptId.ValueMember = "sub_dept_id";
            this.cboSubDeptId.SelectedIndexChanged += new System.EventHandler(this.cboSubDeptId_SelectedIndexChanged);
            // 
            // sUB_DEPTBindingSource
            // 
            this.sUB_DEPTBindingSource.DataMember = "SUB_DEPT";
            this.sUB_DEPTBindingSource.DataSource = this.ahmDataSet0;
            // 
            // cboWctId
            // 
            this.cboWctId.DataSource = this.wCTBindingSource;
            this.cboWctId.DisplayMember = "wct_code";
            this.cboWctId.FormattingEnabled = true;
            this.cboWctId.Location = new System.Drawing.Point(150, 136);
            this.cboWctId.Name = "cboWctId";
            this.cboWctId.Size = new System.Drawing.Size(144, 21);
            this.cboWctId.TabIndex = 15;
            this.cboWctId.ValueMember = "wct_id";
            // 
            // wCTBindingSource
            // 
            this.wCTBindingSource.DataMember = "WCT";
            this.wCTBindingSource.DataSource = this.ahmDataSet0;
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
            // wCTTableAdapter
            // 
            this.wCTTableAdapter.ClearBeforeFill = true;
            // 
            // sUB_DEPTTableAdapter
            // 
            this.sUB_DEPTTableAdapter.ClearBeforeFill = true;
            // 
            // dEPTTableAdapter
            // 
            this.dEPTTableAdapter.ClearBeforeFill = true;
            // 
            // FormEditLine
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(323, 244);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lblWct);
            this.Controls.Add(this.lblSubDept);
            this.Controls.Add(this.lblDept);
            this.Controls.Add(this.lblLineName);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.cboLineName);
            this.Controls.Add(this.cboDeptId);
            this.Controls.Add(this.cboSubDeptId);
            this.Controls.Add(this.cboWctId);
            this.Name = "FormEditLine";
            this.Text = "FormEditLine";
            this.Load += new System.EventHandler(this.FormEditLine_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dEPTBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ahmDataSet0)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sUB_DEPTBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wCTBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cONFIGURATIONBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pLANTBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lINEBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mACHINEBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pART_IDBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lblWct;
        private System.Windows.Forms.Label lblSubDept;
        private System.Windows.Forms.Label lblDept;
        private System.Windows.Forms.Label lblLineName;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.ComboBox cboLineName;
        private System.Windows.Forms.ComboBox cboDeptId;
        private System.Windows.Forms.ComboBox cboSubDeptId;
        private System.Windows.Forms.ComboBox cboWctId;
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
        private System.Windows.Forms.BindingSource wCTBindingSource;
        private AhmDataSet1TableAdapters.WCTTableAdapter wCTTableAdapter;
        private System.Windows.Forms.BindingSource sUB_DEPTBindingSource;
        private AhmDataSet1TableAdapters.SUB_DEPTTableAdapter sUB_DEPTTableAdapter;
        private System.Windows.Forms.BindingSource dEPTBindingSource;
        private AhmDataSet1TableAdapters.DEPTTableAdapter dEPTTableAdapter;
    }
}