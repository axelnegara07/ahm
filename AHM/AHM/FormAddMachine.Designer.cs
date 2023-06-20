using System.Linq;

namespace AHM
{
    partial class FormAddMachine
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
            this.lbllMachineName = new System.Windows.Forms.Label();
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
            this.lblMachineNo = new System.Windows.Forms.Label();
            this.txtMachineName = new System.Windows.Forms.TextBox();
            this.mACHINEBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.cboMachineCode = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.ahmDataSet0)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cONFIGURATIONBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pLANTBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lINEBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mACHINEBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pART_IDBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mACHINEBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbllMachineName
            // 
            this.lbllMachineName.AutoSize = true;
            this.lbllMachineName.Location = new System.Drawing.Point(25, 35);
            this.lbllMachineName.Name = "lbllMachineName";
            this.lbllMachineName.Size = new System.Drawing.Size(79, 13);
            this.lbllMachineName.TabIndex = 0;
            this.lbllMachineName.Text = "Machine Name";
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
            // lblMachineNo
            // 
            this.lblMachineNo.AutoSize = true;
            this.lblMachineNo.Location = new System.Drawing.Point(25, 73);
            this.lblMachineNo.Name = "lblMachineNo";
            this.lblMachineNo.Size = new System.Drawing.Size(65, 13);
            this.lblMachineNo.TabIndex = 2;
            this.lblMachineNo.Text = "Machine No";
            // 
            // txtMachineName
            // 
            this.txtMachineName.Location = new System.Drawing.Point(133, 33);
            this.txtMachineName.Name = "txtMachineName";
            this.txtMachineName.Size = new System.Drawing.Size(149, 20);
            this.txtMachineName.TabIndex = 4;
            // 
            // mACHINEBindingSource1
            // 
            this.mACHINEBindingSource1.DataMember = "MACHINE";
            this.mACHINEBindingSource1.DataSource = this.ahmDataSet0;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(28, 142);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 6;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(207, 142);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 7;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // cboMachineCode
            // 
            this.cboMachineCode.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.mACHINEBindingSource, "machine_id", true));
            this.cboMachineCode.FormattingEnabled = true;
            this.cboMachineCode.Items.AddRange(new object[] {
            "OP - 10",
            "OP - 20",
            "OP - 30",
            "OP - 40",
            "OP - 50"});
            this.cboMachineCode.Location = new System.Drawing.Point(133, 70);
            this.cboMachineCode.Name = "cboMachineCode";
            this.cboMachineCode.Size = new System.Drawing.Size(149, 21);
            this.cboMachineCode.TabIndex = 8;
            this.cboMachineCode.SelectedIndexChanged += new System.EventHandler(this.cboMachineCode_SelectedIndexChanged);
            // 
            // FormAddMachine
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(317, 192);
            this.Controls.Add(this.cboMachineCode);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtMachineName);
            this.Controls.Add(this.lblMachineNo);
            this.Controls.Add(this.lbllMachineName);
            this.Name = "FormAddMachine";
            this.Text = "Add Machine Wizard";
            this.Load += new System.EventHandler(this.FormAddMachine_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ahmDataSet0)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cONFIGURATIONBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pLANTBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lINEBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mACHINEBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pART_IDBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mACHINEBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbllMachineName;
        private AhmDataSet1 ahmDataSet0;
        private System.Windows.Forms.BindingSource cONFIGURATIONBindingSource;
        private AhmDataSet1TableAdapters.CONFIGURATIONTableAdapter cONFIGURATIONTableAdapter;
        private AhmDataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private AhmDataSet1TableAdapters.PLANTTableAdapter pLANTTableAdapter;
        private System.Windows.Forms.BindingSource pLANTBindingSource;
        private AhmDataSet1TableAdapters.LINETableAdapter lINETableAdapter;
        private System.Windows.Forms.BindingSource lINEBindingSource;
        private AhmDataSet1TableAdapters.MACHINETableAdapter mACHINETableAdapter;
        private System.Windows.Forms.BindingSource mACHINEBindingSource;
        private AhmDataSet1TableAdapters.PART_IDTableAdapter pART_IDTableAdapter;
        private System.Windows.Forms.BindingSource pART_IDBindingSource;
        private System.Windows.Forms.Label lblMachineNo;
        private System.Windows.Forms.TextBox txtMachineName;
        private System.Windows.Forms.BindingSource mACHINEBindingSource1;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.ComboBox cboMachineCode;
    }
}