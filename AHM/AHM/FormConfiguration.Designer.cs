namespace AHM
{
    partial class FormConfiguration
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
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.btnModPlant = new System.Windows.Forms.Button();
            this.btnLine = new System.Windows.Forms.Button();
            this.btnMachine = new System.Windows.Forms.Button();
            this.btnParameter = new System.Windows.Forms.Button();
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
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(12, 12);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(600, 341);
            this.treeView1.TabIndex = 0;
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            // 
            // btnModPlant
            // 
            this.btnModPlant.Location = new System.Drawing.Point(13, 371);
            this.btnModPlant.Name = "btnModPlant";
            this.btnModPlant.Size = new System.Drawing.Size(120, 23);
            this.btnModPlant.TabIndex = 1;
            this.btnModPlant.Text = "Modify Plant";
            this.btnModPlant.UseVisualStyleBackColor = true;
            this.btnModPlant.Click += new System.EventHandler(this.btnModPlant_Click);
            // 
            // btnLine
            // 
            this.btnLine.Location = new System.Drawing.Point(152, 371);
            this.btnLine.Name = "btnLine";
            this.btnLine.Size = new System.Drawing.Size(120, 23);
            this.btnLine.TabIndex = 2;
            this.btnLine.Text = "Add/Remove Line";
            this.btnLine.UseVisualStyleBackColor = true;
            this.btnLine.Click += new System.EventHandler(this.btnLine_Click);
            // 
            // btnMachine
            // 
            this.btnMachine.Location = new System.Drawing.Point(292, 371);
            this.btnMachine.Name = "btnMachine";
            this.btnMachine.Size = new System.Drawing.Size(150, 23);
            this.btnMachine.TabIndex = 3;
            this.btnMachine.Text = "Add/Remove Machine";
            this.btnMachine.UseVisualStyleBackColor = true;
            this.btnMachine.Click += new System.EventHandler(this.btnMachine_Click);
            // 
            // btnParameter
            // 
            this.btnParameter.Location = new System.Drawing.Point(462, 371);
            this.btnParameter.Name = "btnParameter";
            this.btnParameter.Size = new System.Drawing.Size(150, 23);
            this.btnParameter.TabIndex = 4;
            this.btnParameter.Text = "Add/Remove Parameter";
            this.btnParameter.UseVisualStyleBackColor = true;
            this.btnParameter.Click += new System.EventHandler(this.btnParameter_Click);
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
            // FormConfiguration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(622, 402);
            this.Controls.Add(this.btnParameter);
            this.Controls.Add(this.btnMachine);
            this.Controls.Add(this.btnLine);
            this.Controls.Add(this.btnModPlant);
            this.Controls.Add(this.treeView1);
            this.Name = "FormConfiguration";
            this.Text = "Plant Configuration Wizard";
            this.Load += new System.EventHandler(this.FormConfiguration_Load);
            treeView1.NodeMouseDoubleClick += treeView1_NodeMouseDoubleClick;
            ((System.ComponentModel.ISupportInitialize)(this.ahmDataSet0)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cONFIGURATIONBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pLANTBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lINEBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mACHINEBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pART_IDBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.Button btnModPlant;
        private System.Windows.Forms.Button btnLine;
        private System.Windows.Forms.Button btnMachine;
        private System.Windows.Forms.Button btnParameter;
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
    }
}

