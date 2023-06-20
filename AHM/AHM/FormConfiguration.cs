using AHM.AhmDataSet1TableAdapters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Configuration;
using System.Text.Json;
using System.Deployment.Application;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using AHM.Properties;
using System.Xml;

namespace AHM
{
    public partial class FormConfiguration : System.Windows.Forms.Form
    {
        TreeNode selectedNode;
        public int SelectedPlantId { get; private set; }
        public int SelectedLineId { get; private set; }
        public int SelectedMachineId { get; private set; }
        public int SelectedParameterId { get; private set; }
        public string ConnectionString { get; private set; }

        public FormConfiguration(string connectionString)
        {
            InitializeComponent();
            this.ConnectionString = connectionString;
            InitializeTableAdapters();
        }

        private void FormConfiguration_Load(object sender, EventArgs e)
        {
           PopulateTreeView();
        }

        public void InitializeTableAdapters()
        {
            // Inisialisasi table adapter dengan connection string
            this.pART_IDTableAdapter.Connection = new SqlConnection(ConnectionString);
            this.mACHINETableAdapter.Connection = new SqlConnection(ConnectionString);
            this.lINETableAdapter.Connection = new SqlConnection(ConnectionString);
            this.pLANTTableAdapter.Connection = new SqlConnection(ConnectionString);
            this.cONFIGURATIONTableAdapter.Connection = new SqlConnection(ConnectionString);
        }

        public void PopulateTreeView()
        {
            this.treeView1.Nodes.Clear();

            this.pART_IDTableAdapter.Fill(this.ahmDataSet0.PART_ID);
            this.mACHINETableAdapter.Fill(this.ahmDataSet0.MACHINE);
            this.lINETableAdapter.Fill(this.ahmDataSet0.LINE);
            this.pLANTTableAdapter.Fill(this.ahmDataSet0.PLANT);
            this.cONFIGURATIONTableAdapter.Fill(this.ahmDataSet0.CONFIGURATION);

            try
            {
                foreach (DataRow plantRow in ahmDataSet0.PLANT.Rows)
                {
                    TreeNode plantNode = new TreeNode(plantRow["plant_code"].ToString());
                    plantNode.Tag = plantRow["plant_id"];
                    treeView1.Nodes.Add(plantNode);

                    var linesForPlant = ahmDataSet0.LINE.Select($"id_plant_id = {plantRow["plant_id"]}");

                    foreach (var lineRow in linesForPlant)
                    {
                        TreeNode lineNode = new TreeNode(lineRow["line_name"].ToString());
                        lineNode.Tag = lineRow["line_id"];
                        plantNode.Nodes.Add(lineNode);

                        var machinesForLine = ahmDataSet0.MACHINE.Select($"id_line_id = {lineRow["line_id"]}");

                        foreach (var machineRow in machinesForLine)
                        {
                            TreeNode machineNode = new TreeNode(machineRow["machine_name"].ToString());
                            machineNode.Tag = machineRow["machine_id"];
                            lineNode.Nodes.Add(machineNode);

                            var partIdsForMachine = ahmDataSet0.PART_ID.Select($"id_machine_id = {machineRow["machine_id"]}");

                            foreach (var partIdRow in partIdsForMachine)
                            {
                                TreeNode partIdNode = new TreeNode(partIdRow["part_id_name"].ToString());
                                partIdNode.Tag = partIdRow["part_id_id"];
                                machineNode.Nodes.Add(partIdNode);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Terjadi kesalahan: " + ex.Message);
            }
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            selectedNode = e.Node;

            if (selectedNode.Tag is int selectedPlantId)
            {
                SelectedPlantId = selectedPlantId;
            }
            if (selectedNode.Tag is int selectedLineId)
            {
                SelectedLineId = selectedLineId;
            }
            if (selectedNode.Tag is int selectedMachineId)
            {
                SelectedMachineId = selectedMachineId;
            }
            if (selectedNode.Tag is int selectedParameterId)
            {
                SelectedParameterId = selectedParameterId;
            }
        }

        public TreeNode GetSelectedNode()
        {
            return treeView1.SelectedNode;
        }

        private void btnMachine_Click(object sender, EventArgs e)
        {
            FormConMachine formMachine = new FormConMachine(this);
            formMachine.ShowDialog();
        }


        private void btnLine_Click(object sender, EventArgs e)
        {
            FormConLine formLine = new FormConLine(this);
            formLine.ShowDialog();
        }

        private void btnParameter_Click(object sender, EventArgs e)
        {
            FormConParameter formParameter = new FormConParameter(this);
            formParameter.ShowDialog();
        }

        private void btnModPlant_Click(object sender, EventArgs e)
        {
            FormModifyPlant formPlant = new FormModifyPlant(this);
            formPlant.ShowDialog();
        }

        private void treeView1_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            if (e.Node.Level == 3)
            {
                FormEditParameter formEditParameter = new FormEditParameter(this);
                formEditParameter.ShowDialog();
            }
            else if (e.Node.Level == 2)
            {
                FormEditMachine formEditMachine = new FormEditMachine(this);
                formEditMachine.ShowDialog();
            }
            else if (e.Node.Level == 1)
            {
                FormEditLine formEditLine = new FormEditLine(this);
                formEditLine.ShowDialog();
            }
        }

    }
}