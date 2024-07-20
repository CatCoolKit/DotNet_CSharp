using Repository.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1_1805
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();

        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            using (var dbcontext = new AirConditionerShop2023DBContext())
            {
                var listAirConditioner = dbcontext.AirConditioners.ToList();
                var listSupplierCompany = dbcontext.SupplierCompanies.ToList();
                cmbSupplierID.DataSource = listSupplierCompany;
                cmbSupplierID.DisplayMember = "SupplierName";
                cmbSupplierID.ValueMember = "SupplierId";
                cmbSupplierID.SelectedIndex = 0;
                txbAirID.Text = "";
                txbAirName.Text = "";
                txbWarranty.Text = "";
                txbSound.Text = "";
                txbFeature.Text = "";
                numQuantity.Value = 0;
                txbDollar.Text = "";

                BindingSource bind = new BindingSource();
                bind.DataSource = listAirConditioner;

                dgvAirCondition.DataSource = bind;
            }
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            btnRefresh.PerformClick();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txbAirName.Text.Trim()) ||
                    string.IsNullOrWhiteSpace(txbWarranty.Text.Trim()) ||
                    string.IsNullOrWhiteSpace(txbSound.Text.Trim()) ||
                    string.IsNullOrWhiteSpace(txbFeature.Text.Trim()) ||
                    numQuantity.Value <= 0 ||
                    string.IsNullOrWhiteSpace(txbDollar.Text.Trim()) ||
                    cmbSupplierID.SelectedValue == null)
                {
                    MessageBox.Show("Please fill in all required fields.");
                    return;
                }

                var airConditioner = new AirConditioner
                {
                    AirConditionerId = DateTime.Now.Minute + DateTime.Now.Second,
                    AirConditionerName = txbAirName.Text.Trim(),
                    Warranty = txbWarranty.Text.Trim(),
                    SoundPressureLevel = txbSound.Text.Trim(),
                    FeatureFunction = txbFeature.Text.Trim(),
                    SupplierId = cmbSupplierID.SelectedValue.ToString()
                };

                if (int.TryParse(numQuantity.Value.ToString(), out int quantity))
                {
                    airConditioner.Quantity = quantity;
                }
                else
                {
                    MessageBox.Show("Invalid quantity. Please enter a valid number.");
                    return;
                }

                if (float.TryParse(txbDollar.Text.Trim(), out float dollarPrice))
                {
                    if (dollarPrice > 0)
                    {
                        airConditioner.DollarPrice = dollarPrice;
                    }
                    else
                    {
                        MessageBox.Show("DollarPrice must be greater than 0.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
                else
                {
                    MessageBox.Show("Invalid dollar price. Please enter a valid number.");
                    return;
                }

                using (var dbContext = new AirConditionerShop2023DBContext())
                {
                    dbContext.AirConditioners.Add(airConditioner);
                    dbContext.SaveChanges();

                    var listAirCondition = dbContext.AirConditioners.ToList();

                    BindingSource bind = new BindingSource
                    {
                        DataSource = listAirCondition
                    };

                    dgvAirCondition.DataSource = bind;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txbAirID.Text.Trim()) ||
                    string.IsNullOrWhiteSpace(txbAirName.Text.Trim()) ||
                    string.IsNullOrWhiteSpace(txbWarranty.Text.Trim()) ||
                    string.IsNullOrWhiteSpace(txbSound.Text.Trim()) ||
                    string.IsNullOrWhiteSpace(txbFeature.Text.Trim()) ||
                    numQuantity.Value <= 0 ||
                    string.IsNullOrWhiteSpace(txbDollar.Text.Trim()) ||
                    cmbSupplierID.SelectedValue == null)
                {
                    MessageBox.Show("Please fill in all required fields.");
                    return;
                }

                if (int.TryParse(txbAirID.Text.Trim(), out int airConditionerId))
                {
                    using (var dbContext = new AirConditionerShop2023DBContext())
                    {
                        var airConditioner = dbContext.AirConditioners.FirstOrDefault(a => a.AirConditionerId == airConditionerId);

                        if (airConditioner != null)
                        {
                            airConditioner.AirConditionerName = txbAirName.Text.Trim();
                            airConditioner.Warranty = txbWarranty.Text.Trim();
                            airConditioner.SoundPressureLevel = txbSound.Text.Trim();
                            airConditioner.FeatureFunction = txbFeature.Text.Trim();
                            airConditioner.SupplierId = cmbSupplierID.SelectedValue.ToString();

                            if (int.TryParse(numQuantity.Value.ToString(), out int quantity))
                            {
                                airConditioner.Quantity = quantity;
                            }
                            else
                            {
                                MessageBox.Show("Invalid quantity. Please enter a valid number.");
                                return;
                            }

                            if (float.TryParse(txbDollar.Text.Trim(), out float dollarPrice))
                            {
                                if (dollarPrice > 0)
                                {
                                    airConditioner.DollarPrice = dollarPrice;
                                }
                                else
                                {
                                    MessageBox.Show("DollarPrice must be greater than 0.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    return;
                                }
                            }
                            else
                            {
                                MessageBox.Show("Invalid dollar price. Please enter a valid number.");
                                return;
                            }

                            dbContext.SaveChanges();

                            var listAirCondition = dbContext.AirConditioners.ToList();

                            BindingSource bind = new BindingSource
                            {
                                DataSource = listAirCondition
                            };

                            dgvAirCondition.DataSource = bind;
                        }
                        else
                        {
                            MessageBox.Show("Air conditioner not found.");
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Invalid Air Conditioner ID. Please enter a valid number.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
        }

        private void dgvAirCondition_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                if (dgvAirCondition.Rows[e.RowIndex].HeaderCell.Value == null)
                {
                    txbAirID.Text = dgvAirCondition.CurrentRow.Cells[0].Value.ToString();
                    txbAirName.Text = dgvAirCondition.CurrentRow.Cells[1].Value.ToString();
                    txbWarranty.Text = dgvAirCondition.CurrentRow.Cells[2].Value.ToString();
                    txbSound.Text = dgvAirCondition.CurrentRow.Cells[3].Value.ToString();
                    txbFeature.Text = dgvAirCondition.CurrentRow.Cells[4].Value.ToString();
                    numQuantity.Value = int.Parse(dgvAirCondition.CurrentRow.Cells[5].Value.ToString());
                    txbDollar.Text = dgvAirCondition.CurrentRow.Cells[6].Value.ToString();
                    cmbSupplierID.SelectedValue = dgvAirCondition.CurrentRow.Cells[7].Value.ToString();
                }
            }

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txbAirID.Text.Trim(), out int airConditionerId))
            {
                MessageBox.Show("Invalid Air Conditioner ID. Please enter a valid number.");
                return;
            }

            using (var dbcontext = new AirConditionerShop2023DBContext())
            {
                var airConditioner = dbcontext.AirConditioners.FirstOrDefault(a => a.AirConditionerId == airConditionerId);

                if (airConditioner != null)
                {
                    dbcontext.Remove(airConditioner);
                    dbcontext.SaveChanges();

                    var listAirCondition = dbcontext.AirConditioners.ToList();

                    BindingSource bind = new BindingSource();
                    bind.DataSource = listAirCondition;

                    dgvAirCondition.DataSource = bind;
                }
            }
        }

        private void dgvAirCondition_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
