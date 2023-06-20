using AHM.AhmDataSet1TableAdapters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AHM
{
    public partial class FormConLine : System.Windows.Forms.Form
    {
        private FormConfiguration formConfiguration;
        private string connectionString;

        public FormConLine(FormConfiguration formConfiguration)
        {
            InitializeComponent();
            this.formConfiguration = formConfiguration;
            this.connectionString = formConfiguration.ConnectionString;
        }

        private void FormConLine_Load(object sender, EventArgs e)
        {
            this.pART_IDTableAdapter.Connection.ConnectionString = connectionString;
            this.mACHINETableAdapter.Connection.ConnectionString = connectionString;
            this.lINETableAdapter.Connection.ConnectionString = connectionString;
            this.pLANTTableAdapter.Connection.ConnectionString = connectionString;
            this.cONFIGURATIONTableAdapter.Connection.ConnectionString = connectionString;

            this.pART_IDTableAdapter.Fill(this.ahmDataSet0.PART_ID);
            this.mACHINETableAdapter.Fill(this.ahmDataSet0.MACHINE);
            this.lINETableAdapter.Fill(this.ahmDataSet0.LINE);
            this.pLANTTableAdapter.Fill(this.ahmDataSet0.PLANT);
            this.cONFIGURATIONTableAdapter.Fill(this.ahmDataSet0.CONFIGURATION);
        }

        private void btnAddLine_Click(object sender, EventArgs e)
        {
            FormAddLine formAddLine = new FormAddLine(this, formConfiguration);
            this.Close();
            formAddLine.ShowDialog();
        }

        private void btnDeleteLine_Click(object sender, EventArgs e)
        {
            var selectedNode = formConfiguration.GetSelectedNode();
            if (selectedNode == null)
            {
                MessageBox.Show("Mohon pilih Line yang ingin dihapus");
                return;
            }

            if (selectedNode.Level != 1)
            {
                MessageBox.Show("Mohon pilih Line yang ingin dihapus");
                return;
            }

            if (MessageBox.Show($"Apakah Anda yakin ingin menghapus Line {selectedNode.Text} beserta seluruh Machine dan Part ID yang terkait?", "Konfirmasi Hapus Line", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                var lineRow = ahmDataSet0.LINE.FirstOrDefault(r => r["line_name"].ToString() == selectedNode.Text);

                if (lineRow == null)
                {
                    MessageBox.Show("Line tidak ditemukan");
                    return;
                }

                var machineIdsForLine = ahmDataSet0.MACHINE.Select($"id_line_id = {lineRow["line_id"]}");

                foreach (var machineIdRow in machineIdsForLine)
                {
                    var machineNode = selectedNode.Nodes.Find(machineIdRow["machine_name"].ToString(), false).FirstOrDefault();
                    if (machineNode != null)
                    {
                        machineNode.Remove();
                    }

                    var partIdsForMachine = ahmDataSet0.PART_ID.Select($"id_machine_id = {machineIdRow["machine_id"]}");

                    foreach (var partIdRow in partIdsForMachine)
                    {
                        partIdRow.Delete();
                    }

                    machineIdRow.Delete();
                }

                lineRow.Delete();

                mACHINETableAdapter.Update(ahmDataSet0.MACHINE);
                pART_IDTableAdapter.Update(ahmDataSet0.PART_ID);
                lINETableAdapter.Update(ahmDataSet0.LINE);

                selectedNode.Remove();

                MessageBox.Show("Line berhasil dihapus");
            }
        }

    }
}
