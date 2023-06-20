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
    public partial class FormConParameter : Form
    {
        private FormConfiguration formConfiguration;
        private string connectionString;
        public FormConParameter(FormConfiguration formConfiguration)
        {
            InitializeComponent();
            this.formConfiguration = formConfiguration;
            this.connectionString = formConfiguration.ConnectionString;
        }

        private void FormConParameter_Load(object sender, EventArgs e)
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

        private void btnAddParameter_Click(object sender, EventArgs e)
        {
            FormAddParameter formAddParameter = new FormAddParameter(this, formConfiguration);
            this.Close();
            formAddParameter.ShowDialog();
        }

        private void btnDeleteParameter_Click(object sender, EventArgs e)
        {
            var selectedNode = formConfiguration.GetSelectedNode();
            if (selectedNode == null)
            {
                MessageBox.Show("Mohon pilih Part ID yang ingin dihapus");
                return;
            }

            if (selectedNode.Level != 3)
            {
                MessageBox.Show("Mohon pilih Part ID yang ingin dihapus");
                return;
            }

            if (MessageBox.Show($"Apakah Anda yakin ingin menghapus Part ID {selectedNode.Text}?", "Konfirmasi Hapus Part ID", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                var partIdRow = ahmDataSet0.PART_ID.FirstOrDefault(r => r["part_id_name"].ToString() == selectedNode.Text);

                if (partIdRow == null)
                {
                    MessageBox.Show("Part ID tidak ditemukan");
                    return;
                }

                partIdRow.Delete();

                pART_IDTableAdapter.Update(ahmDataSet0.PART_ID);

                selectedNode.Remove();

                MessageBox.Show("Part ID berhasil dihapus");
            }
        }

    }
}
