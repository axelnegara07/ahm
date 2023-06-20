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
    public partial class FormAddLine : System.Windows.Forms.Form
    {
        private FormConfiguration formConfiguration;
        private FormConLine formConLine;
        private string connectionString;
        public FormAddLine(FormConLine formConLine, FormConfiguration formConfiguration)
        {
            InitializeComponent();
            this.formConLine = formConLine;
            this.formConfiguration = formConfiguration;
            this.connectionString = formConfiguration.ConnectionString;
        }

        private void FormAddLine_Load(object sender, EventArgs e)
        {
            this.dEPTTableAdapter.Connection.ConnectionString = connectionString;
            this.sUB_DEPTTableAdapter.Connection.ConnectionString = connectionString;
            this.wCTTableAdapter.Connection.ConnectionString = connectionString;
            this.pART_IDTableAdapter.Connection.ConnectionString = connectionString;
            this.mACHINETableAdapter.Connection.ConnectionString = connectionString;
            this.lINETableAdapter.Connection.ConnectionString = connectionString;
            this.pLANTTableAdapter.Connection.ConnectionString = connectionString;
            this.cONFIGURATIONTableAdapter.Connection.ConnectionString = connectionString;

            this.dEPTTableAdapter.Fill(this.ahmDataSet0.DEPT);
            this.sUB_DEPTTableAdapter.Fill(this.ahmDataSet0.SUB_DEPT);
            this.wCTTableAdapter.Fill(this.ahmDataSet0.WCT);
            this.pART_IDTableAdapter.Fill(this.ahmDataSet0.PART_ID);
            this.mACHINETableAdapter.Fill(this.ahmDataSet0.MACHINE);
            this.lINETableAdapter.Fill(this.ahmDataSet0.LINE);
            this.pLANTTableAdapter.Fill(this.ahmDataSet0.PLANT);
            this.cONFIGURATIONTableAdapter.Fill(this.ahmDataSet0.CONFIGURATION);

            if (formConfiguration.GetSelectedNode().Level != 0)
            {
                MessageBox.Show("Please select a plant.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(cboLineName.Text))
            {
                MessageBox.Show("Please enter a line name.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int selectedDeptId = (int)cboDeptId.SelectedValue;
            int selectedSubDeptId = (int)cboSubDeptId.SelectedValue;
            int selectedWctId = (int)cboWctId.SelectedValue;
            var newRow = ahmDataSet0.LINE.NewLINERow();
            newRow.line_name = cboLineName.Text;
            newRow.id_dept_id = selectedDeptId;
            newRow.id_sub_dept_id = selectedSubDeptId;
            newRow.id_wct_id = selectedWctId;
            newRow.id_plant_id = formConfiguration.SelectedPlantId;
            ahmDataSet0.LINE.AddLINERow(newRow);
            lINETableAdapter.Update(ahmDataSet0.LINE);

            formConfiguration.PopulateTreeView();

            this.Close();

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cboDeptId_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboDeptId.SelectedValue != null)
            {
                int selectedDeptId = Convert.ToInt32(cboDeptId.SelectedValue);

                // Menggunakan relasi untuk mendapatkan sub departemen yang terkait dengan departemen yang dipilih
                DataRow[] subDeptRows = ahmDataSet0.SUB_DEPT.Select($"id_dept_id = {selectedDeptId}");

                // Mengosongkan ComboBox sub_dept
                cboSubDeptId.DataSource = null;
                cboSubDeptId.Items.Clear();

                if (subDeptRows != null && subDeptRows.Length > 0)
                {
                    // Membuat DataTable baru untuk menyimpan data sub departemen
                    DataTable subDeptTable = new DataTable();
                    subDeptTable.Columns.Add("sub_dept_code", typeof(string));
                    subDeptTable.Columns.Add("sub_dept_id", typeof(int));

                    // Mengisi DataTable dengan data sub departemen
                    foreach (DataRow row in subDeptRows)
                    {
                        subDeptTable.Rows.Add(row["sub_dept_code"], row["sub_dept_id"]);
                    }

                    // Mengisi ComboBox sub_dept dengan data sub departemen dari DataTable
                    cboSubDeptId.DataSource = subDeptTable;
                    cboSubDeptId.DisplayMember = "sub_dept_code";
                    cboSubDeptId.ValueMember = "sub_dept_id";
                }
            }
        }


    }
}
