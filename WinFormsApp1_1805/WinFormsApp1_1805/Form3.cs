using Microsoft.EntityFrameworkCore;
using Repository;
using Repository.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1_1805
{
    public partial class Form3 : Form
    {
        StaffMember staff = new StaffMember();
        private AirconditionerRepository _airconditionerRepository;
        private SupplierCompanyRepository _supplierCompanyRepository;
        public Form3(StaffMember staff)
        {
            InitializeComponent();
            _airconditionerRepository = new AirconditionerRepository();
            _supplierCompanyRepository = new SupplierCompanyRepository();
            this.staff = staff;
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            var listAirConditioner = _airconditionerRepository.GetAll();
            var listSupplierCompany = _supplierCompanyRepository.GetAll();
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

            var newList = new List<NewListOut>();
            foreach (var item in listAirConditioner)
            {
                var check = listSupplierCompany.FirstOrDefault(s => s.SupplierId == item.SupplierId);
                if (check != null)
                {
                    newList.Add(new NewListOut
                    {
                        AirConditionerId = item.AirConditionerId,
                        AirConditionerName = item.AirConditionerName,
                        Warranty = item.Warranty,
                        SoundPressureLevel = item.SoundPressureLevel,
                        FeatureFunction = item.FeatureFunction,
                        Quantity = item.Quantity,
                        DollarPrice = item.DollarPrice,
                        SupplierId = item.SupplierId,
                        SupplierName = check.SupplierName
                    });
                }
            }

            BindingSource bind = new BindingSource();
            bind.DataSource = newList;

            dgvAirCondition.DataSource = bind;
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
                    if (dollarPrice > 0 && dollarPrice < 10)
                    {
                        airConditioner.DollarPrice = dollarPrice;
                    }
                    else
                    {
                        MessageBox.Show("DollarPrice must be greater than 0 and smaller than 10.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
                else
                {
                    MessageBox.Show("Invalid dollar price. Please enter a valid number.");
                    return;
                }

                _airconditionerRepository.Add(airConditioner);

                var listAirCondition = _airconditionerRepository.GetAll();

                BindingSource bind = new BindingSource
                {
                    DataSource = listAirCondition
                };

                dgvAirCondition.DataSource = bind;
                MessageBox.Show("Air conditioner created successfully.");
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

                if (!IsValidAirName(txbAirName.Text.Trim()))
                {
                    MessageBox.Show("Invalid name.");
                    return;
                }

                if (int.TryParse(txbAirID.Text.Trim(), out int airConditionerId))
                {
                    // Kiểm tra xem tên đã tồn tại chưa
                    var existingAirConditioner = _airconditionerRepository
                        .GetAll()
                        .FirstOrDefault(a => a.AirConditionerName == txbAirName.Text.Trim() && a.AirConditionerId != airConditionerId);

                    if (existingAirConditioner != null)
                    {
                        MessageBox.Show("An air conditioner with this name already exists. Please choose a different name.");
                        return;
                    }

                    //var airConditioner = dbContext.AirConditioners.FirstOrDefault(a => a.AirConditionerId == airConditionerId);
                    var airConditioner = _airconditionerRepository.GetById(airConditionerId);

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
                            if (dollarPrice > 0 && dollarPrice < 10)
                            {
                                airConditioner.DollarPrice = dollarPrice;
                            }
                            else
                            {
                                MessageBox.Show("DollarPrice must be greater than 0 and smaller than 10.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return;
                            }
                        }
                        else
                        {
                            MessageBox.Show("Invalid dollar price. Please enter a valid number.");
                            return;
                        }

                        _airconditionerRepository.Update(airConditioner);

                        var listAirCondition = _airconditionerRepository.GetAll();

                        BindingSource bind = new BindingSource
                        {
                            DataSource = listAirCondition
                        };

                        dgvAirCondition.DataSource = bind;
                        MessageBox.Show("Air conditioner updated successfully.");
                    }
                    else
                    {
                        MessageBox.Show("Air conditioner not found.");
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


            //var airConditioner = dbcontext.AirConditioners.FirstOrDefault(a => a.AirConditionerId == airConditionerId);
            var airConditioner = _airconditionerRepository.GetById(airConditionerId);

            if (airConditioner != null)
            {
                // Hiển thị hộp thoại xác nhận
                var confirmResult = MessageBox.Show(
                    "Are you sure you want to delete this air conditioner?",
                    "Confirm Delete",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (confirmResult == DialogResult.Yes)
                {
                    _airconditionerRepository.Delete(airConditioner);

                    var listAirCondition = _airconditionerRepository.GetAll();

                    BindingSource bind = new BindingSource();
                    bind.DataSource = listAirCondition;

                    dgvAirCondition.DataSource = bind;

                    MessageBox.Show("Air conditioner deleted successfully.");
                }
                    
            } else
            {
                MessageBox.Show("Air conditioner not found.");
            }

        }

        private void dgvAirCondition_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            var search = txbSearch.Text.Trim().ToLower();
            var listAirCondition = _airconditionerRepository.GetAll();
            var listSupplierCompany = _supplierCompanyRepository.GetAll();
            var list = new List<NewListOut>();
            foreach(var item in listAirCondition)
            {
                var checkSupplier = listSupplierCompany.FirstOrDefault(s => s.SupplierId == item.SupplierId);
                if (item.AirConditionerName.ToLower().Equals(search))
                {
                    list.Add(new NewListOut
                    {
                        AirConditionerId = item.AirConditionerId,
                        AirConditionerName = item.AirConditionerName,
                        Warranty = item.Warranty,
                        SoundPressureLevel = item.SoundPressureLevel,
                        FeatureFunction = item.FeatureFunction,
                        Quantity = item.Quantity,
                        DollarPrice = item.DollarPrice,
                        SupplierId = item.SupplierId,
                        SupplierName = checkSupplier.SupplierName
                    });
                }
            }
            
            if (list.Any())
            {
                BindingSource bind = new BindingSource();
                bind.DataSource = list;

                dgvAirCondition.DataSource = bind;
            }
            else { 
                MessageBox.Show("Not found, please try again!");
            }
        }

        public static bool IsValidAirName(string name)
        {
            if (string.IsNullOrWhiteSpace(name.Trim()))
            {
                return false;
            }

            if (name.Length < 5 || name.Length > 90)
            {
                return false;
            }

            return IsTitleCase(name);
        }

        public static bool IsTitleCase(string str)
        {
            TextInfo textInfo = new CultureInfo("en-US", false).TextInfo;
            return str == textInfo.ToTitleCase(str);
        }
    }
}
