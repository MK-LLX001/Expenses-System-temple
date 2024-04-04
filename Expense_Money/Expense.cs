using MaterialSkin.Controls;
using System;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Expense_Money
{
    public partial class Expense : MaterialForm
    {
        public Expense()
        {
            InitializeComponent();
        }

        private Config cd = new Config();
        private SqlCommand cmd = new SqlCommand();
        private SqlDataAdapter da = new SqlDataAdapter();
        private DataSet ds = new DataSet();
        private int ex_id;
        public int moneykip;
        public int moneybat;

        private void Expenses01_Load(object sender, System.EventArgs e)
        {
            cd.connect();
            showdate();
        }

        private void showdate()
        {
            try
            {
                da = new SqlDataAdapter("Select * from Tb_expenses", cd.conn);
                ds.Tables.Clear();
                da.Fill(ds);

                dataGridView1.DataSource = ds.Tables[0];
                dataGridView1.Refresh(); // รีเฟรช DataGridView เพื่อแสดงข้อมูลใหม่

                // เพิ่มแถวใหม่และเลื่อนไปที่แถวสุดท้าย
                dataGridView1.Rows[dataGridView1.Rows.Count - 1].Selected = true;
                dataGridView1.FirstDisplayedScrollingRowIndex = dataGridView1.Rows.Count - 1;


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private bool checkeddate()
        {
            if (txtMoneykip.Text == string.Empty)
            {
                MessageBox.Show("please enter description", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        private void refrestdate()
        {
            txtDatetime.ResetText();
            txtDesc.ResetText();
            txtMoneykip.ResetText();
            txtMoneybat.ResetText();
            SwitchReceipt.Checked = false;
            SwitchReceiptonline.Checked = false;
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            try
            {
                da = new SqlDataAdapter("Select * from Tb_expenses", cd.conn);
                da.Fill(ds);
                ds.Tables.Clear();
                da.Fill(ds);
                dataGridView2.DataSource = ds.Tables[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Seach2_TextChanged(object sender, EventArgs e)
        {
            da = new SqlDataAdapter("select * from Tb_expenses where ex_desc like N'%" + Seach2.Text + "%'", cd.conn);
            da.Fill(ds);
            ds.Tables[0].Rows.Clear();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void btndeleteall_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult title = MessageBox.Show(" Do you want to delete?", "Waring", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (title == DialogResult.Yes)
                {
                    DialogResult title1 = MessageBox.Show(" Are your sure", "Waring", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                    if (title1 == DialogResult.Yes)
                    {
                        cmd = new SqlCommand("delete from Tb_expenses", cd.conn);
                        cmd.Parameters.AddWithValue("ex_id", this.ex_id);

                        if (cmd.ExecuteNonQuery() == 1)
                        {
                            MessageBox.Show("Delete data successfully");
                        }
                    }
                }
                showdate();
                refrestdate();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //************************************************
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (checkeddate())
            {
                try
                {
                    cmd = new SqlCommand("INSERT INTO Tb_expenses VALUES(@Date,@Desc,@Moneykip,@Moneybat,@Receipt,@Receiptonline)", cd.conn);
                    cmd.Parameters.AddWithValue("@Date", txtDatetime.Value);
                    cmd.Parameters.AddWithValue("@Desc", txtDesc.Text);

                    cmd.Parameters.AddWithValue("@Moneykip", moneykip);
                    cmd.Parameters.AddWithValue("@Moneybat", moneybat);

                    string receipt = "Null";
                    if (SwitchReceipt.Checked == true)
                    {
                        receipt = "Yes";
                        cmd.Parameters.AddWithValue("@Receipt", receipt);
                    }
                    else
                    {
                        cmd.Parameters.AddWithValue("@Receipt", receipt);
                    }
                    string receiptonline = "Null";
                    if (SwitchReceiptonline.Checked == true)
                    {
                        receiptonline = "Yes";
                        cmd.Parameters.AddWithValue("@Receiptonline", receiptonline);
                    }
                    else
                    {
                        cmd.Parameters.AddWithValue("@Receiptonline", receiptonline);
                    }

                    if (cmd.ExecuteNonQuery() == 1)
                    {
                        //MessageBox.Show("Save date successfully");
                    }
                    else
                    {
                        MessageBox.Show("Save date Error");
                    }

                    showdate();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                cmd = new SqlCommand("UPDATE Tb_expenses SET ex_data=@Date,ex_desc=@Desc,ex_moneykip=@Moneykip,ex_moneybat=@Moneybat,ex_receipt=@Receipt,ex_receiptonline=@Receiptonline where ex_id=@id", cd.conn);
                cmd.Parameters.AddWithValue("@id", this.ex_id);
                cmd.Parameters.AddWithValue("@Date", txtDatetime.Value);
                cmd.Parameters.AddWithValue("@Desc", txtDesc.Text);

                cmd.Parameters.AddWithValue("@Moneykip", moneykip);
                cmd.Parameters.AddWithValue("@Moneybat", moneybat);

                string receipt = "Null";
                if (SwitchReceipt.Checked == true)
                {
                    receipt = "Yes";
                    cmd.Parameters.AddWithValue("@Receipt", receipt);
                }
                else
                {
                    cmd.Parameters.AddWithValue("@Receipt", receipt);
                }
                string receiptonline = "Null";
                if (SwitchReceiptonline.Checked == true)
                {
                    receiptonline = "Yes";
                    cmd.Parameters.AddWithValue("@Receiptonline", receiptonline);
                }
                else
                {
                    cmd.Parameters.AddWithValue("@Receiptonline", receiptonline);
                }

                if (cmd.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Update date successfully");
                }
                else
                {
                    MessageBox.Show("please select your date", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                showdate();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                ex_id = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
                txtDatetime.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtDesc.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
                txtMoneykip.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
                txtMoneybat.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
                var receipt = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
                var receiptonline = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
                if (receipt == "Yes")
                {
                    SwitchReceipt.Checked = true;
                }
                else
                {
                    SwitchReceipt.Checked = false;
                }
                if (receiptonline == "Yes")
                {
                    SwitchReceiptonline.Checked = true;
                }
                else
                {
                    SwitchReceiptonline.Checked = false;
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        private void txtSeach_TextChanged(object sender, EventArgs e)
        {
            da = new SqlDataAdapter("select * from Tb_expenses where ex_desc like N'%" + txtSeach.Text + "%'", cd.conn);
            da.Fill(ds);
            ds.Tables[0].Rows.Clear();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void btnDetele_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (txtMoneykip.Text == string.Empty)
                {
                    MessageBox.Show("please select your date", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    DialogResult title = MessageBox.Show("Do you want to delete?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (title == DialogResult.Yes)
                    {
                        cmd = new SqlCommand("DELETE FROM Tb_expenses  where ex_id=@id", cd.conn);
                        cmd.Parameters.AddWithValue("@id", this.ex_id);

                        if (cmd.ExecuteNonQuery() == 1)
                        {
                            MessageBox.Show("Delete date successfully");
                        }
                        else
                        {
                            MessageBox.Show("Delete date Error");
                        }
                    }

                    refrestdate();
                    showdate();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            print1 pt = new print1();
            pt.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            refrestdate();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult title = MessageBox.Show("Do you want to Exit?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (title == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void txtMoneybat_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (char.IsDigit(e.KeyChar))
                {
                    string currentText = txtMoneybat.Text.Replace(",", "");
                    if (currentText.Length >= 12)
                    {
                        e.Handled = true;
                        return;
                    }
                    double number = double.Parse(currentText + e.KeyChar);
                    moneybat = Convert.ToInt32(Math.Round(number, 0));
                    if (moneybat >= 1000000000)
                    {
                        txtMoneybat.Text = "###,###,###";
                    }
                    else
                    {
                        txtMoneybat.Text = moneybat.ToString("N0");
                    }
                    txtMoneybat.SelectionStart = txtMoneybat.Text.Length;
                    e.Handled = true;
                    // txtMoneybat.Text = Number.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txtMoneykip_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (char.IsDigit(e.KeyChar))
                {
                    string currentText = txtMoneykip.Text.Replace(",", "");
                    if (currentText.Length >= 12)
                    {
                        e.Handled = true;
                        return;
                    }
                    double number = double.Parse(currentText + e.KeyChar);
                    moneykip = Convert.ToInt32(Math.Round(number, 0));
                    if (moneykip >= 1000000000)
                    {
                        txtMoneykip.Text = "###,###,###";
                    }
                    else
                    {
                        txtMoneykip.Text = moneykip.ToString("N0");
                    }
                    txtMoneykip.SelectionStart = txtMoneykip.Text.Length;
                    e.Handled = true;
                    // txtMoneybat.Text = Number.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}