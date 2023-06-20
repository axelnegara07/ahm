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
    public partial class FormEditLine : Form
    {
        private FormConfiguration formConfiguration;
        private string connectionString;
        public FormEditLine(FormConfiguration formConfiguration)
        {
            InitializeComponent();
            this.formConfiguration = formConfiguration;
            this.connectionString = formConfiguration.ConnectionString;
        }

        private void FormEditLine_Load(object sender, EventArgs e)
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

            int selectedLineId = formConfiguration.SelectedLineId;
            DataRow lineRow = ahmDataSet0.LINE.FindByline_id(selectedLineId);

            if (lineRow != null)
            {

                cboLineName.Text = lineRow["line_name"].ToString();
                cboDeptId.SelectedValue = lineRow["id_dept_id"];
                cboSubDeptId.SelectedValue = lineRow["id_sub_dept_id"];
                cboWctId.SelectedValue = lineRow["id_wct_id"];
            }
            else
            {
                MessageBox.Show("Invalid line selected.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            int selectedLineId = formConfiguration.SelectedLineId;
            DataRow lineRow = ahmDataSet0.LINE.FindByline_id(selectedLineId);

            if (lineRow != null)
            {
                int selectedDeptId = (int)cboDeptId.SelectedValue;
                int selectedSubDeptId = (int)cboSubDeptId.SelectedValue;
                int selectedWctId = (int)cboWctId.SelectedValue;

                lineRow["line_name"] = cboLineName.Text;
                lineRow["id_dept_id"] = selectedDeptId;
                lineRow["id_sub_dept_id"] = selectedSubDeptId;
                lineRow["id_wct_id"] = selectedWctId;
                lINETableAdapter.Update(ahmDataSet0.LINE);

                formConfiguration.PopulateTreeView();

                this.Close();
                
            }
            else
            {
                MessageBox.Show("Invalid plant selected.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cboSubDeptId_SelectedIndexChanged(object sender, EventArgs e)
        {

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
