using repository.Models;
using repository.Services;
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

namespace AirConditionerShop_BuiManhCuong
{
    public partial class AirConditionerManagement : Form
    {
        StaffMember staff = new StaffMember();
        private AirconditionerRepository _airconditionerRepository;
        private SupplierCompanyRepository _supplierCompanyRepository;
        public AirConditionerManagement(StaffMember staff)
        {
            InitializeComponent();
            _airconditionerRepository = new AirconditionerRepository();
            _supplierCompanyRepository = new SupplierCompanyRepository();
            this.staff = staff;
        }

        private void AirConditionerManagement_Load(object sender, EventArgs e)
        {
            button1.PerformClick();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var listAirConditioner = _airconditionerRepository.GetAll();
            var listSupplierCompany = _supplierCompanyRepository.GetAll();
            cmbSupplierId.DataSource = listSupplierCompany;
            cmbSupplierId.DisplayMember = "SupplierName";
            cmbSupplierId.ValueMember = "SupplierId";
            cmbSupplierId.SelectedIndex = 0;
            txbAirId.Text = "";
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

            dgvAirConditioner.DataSource = bind;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (staff.Role == 1)
            {
                try
                {
                    if (string.IsNullOrWhiteSpace(txbAirName.Text.Trim()) ||
                        string.IsNullOrWhiteSpace(txbWarranty.Text.Trim()) ||
                        string.IsNullOrWhiteSpace(txbSound.Text.Trim()) ||
                        string.IsNullOrWhiteSpace(txbFeature.Text.Trim()) ||
                        numQuantity.Value <= 0 ||
                        string.IsNullOrWhiteSpace(txbDollar.Text.Trim()) ||
                        cmbSupplierId.SelectedValue == null)
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
                        SupplierId = cmbSupplierId.SelectedValue.ToString()
                    };

                    // Kiểm tra xem tên đã tồn tại chưa
                    var existingAirConditioner = _airconditionerRepository
                        .GetAll()
                        .FirstOrDefault(a => a.AirConditionerName == txbAirName.Text.Trim());

                    if (existingAirConditioner != null)
                    {
                        MessageBox.Show("An air conditioner with this name already exists. Please choose a different name.");
                        return;
                    }

                    if (int.TryParse(numQuantity.Value.ToString(), out int quantity))
                    {
                        if (quantity >= 0 && quantity < 4000000)
                        {
                            airConditioner.Quantity = quantity;
                        }
                        else
                        {
                            MessageBox.Show("Quantity must be greater than or equal to 0 and smaller than 4000000.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Invalid quantity. Please enter a valid number.");
                        return;
                    }

                    if (float.TryParse(txbDollar.Text.Trim(), out float dollarPrice))
                    {
                        if (dollarPrice >= 0 && dollarPrice < 4000000)
                        {
                            airConditioner.DollarPrice = dollarPrice;
                        }
                        else
                        {
                            MessageBox.Show("DollarPrice must be greater than or equal to 0 and smaller than 4000000.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Invalid dollar price. Please enter a valid number.");
                        return;
                    }

                    _airconditionerRepository.Add(airConditioner);

                    //var listAirCondition = _airconditionerRepository.GetAll();

                    //BindingSource bind = new BindingSource
                    //{
                    //    DataSource = listAirCondition
                    //};

                    //dgvAirConditioner.DataSource = bind;
                    button1.PerformClick();
                    MessageBox.Show("Air conditioner created successfully.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred: {ex.Message}");
                }
            }
            else { 
                MessageBox.Show("You have no permission to access this function!");
            }
            
        }

        private void dgvAirConditioner_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                // Kiểm tra xem hàng hiện tại có phải là hàng trống không
                if (!dgvAirConditioner.Rows[e.RowIndex].IsNewRow)
                {
                    var currentRow = dgvAirConditioner.CurrentRow;

                    // Kiểm tra từng ô xem có giá trị không
                    if (currentRow.Cells[0].Value != null) txbAirId.Text = currentRow.Cells[0].Value.ToString();
                    if (currentRow.Cells[1].Value != null) txbAirName.Text = currentRow.Cells[1].Value.ToString();
                    if (currentRow.Cells[2].Value != null) txbWarranty.Text = currentRow.Cells[2].Value.ToString();
                    if (currentRow.Cells[3].Value != null) txbSound.Text = currentRow.Cells[3].Value.ToString();
                    if (currentRow.Cells[4].Value != null) txbFeature.Text = currentRow.Cells[4].Value.ToString();
                    if (currentRow.Cells[5].Value != null) numQuantity.Value = int.Parse(currentRow.Cells[5].Value.ToString());
                    if (currentRow.Cells[6].Value != null) txbDollar.Text = currentRow.Cells[6].Value.ToString();
                    if (currentRow.Cells[7].Value != null) cmbSupplierId.SelectedValue = currentRow.Cells[7].Value.ToString();
                }
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txbAirId.Text.Trim()) ||
                    string.IsNullOrWhiteSpace(txbAirName.Text.Trim()) ||
                    string.IsNullOrWhiteSpace(txbWarranty.Text.Trim()) ||
                    string.IsNullOrWhiteSpace(txbSound.Text.Trim()) ||
                    string.IsNullOrWhiteSpace(txbFeature.Text.Trim()) ||
                    numQuantity.Value <= 0 ||
                    string.IsNullOrWhiteSpace(txbDollar.Text.Trim()) ||
                    cmbSupplierId.SelectedValue == null)
                {
                    MessageBox.Show("Please fill in all required fields.");
                    return;
                }

                if (!IsValidAirName(txbAirName.Text.Trim()))
                {
                    MessageBox.Show("Invalid name.");
                    return;
                }

                if (int.TryParse(txbAirId.Text.Trim(), out int airConditionerId))
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
                        airConditioner.SupplierId = cmbSupplierId.SelectedValue.ToString();

                        if (int.TryParse(numQuantity.Value.ToString(), out int quantity))
                        {
                            if (quantity >= 0 && quantity < 4000000)
                            {
                                airConditioner.Quantity = quantity;
                            }
                            else
                            {
                                MessageBox.Show("Quantity must be greater than or equal to 0 and smaller than 4000000.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return;
                            }
                        }
                        else
                        {
                            MessageBox.Show("Invalid quantity. Please enter a valid number.");
                            return;
                        }

                        if (float.TryParse(txbDollar.Text.Trim(), out float dollarPrice))
                        {
                            if (dollarPrice >= 0 && dollarPrice < 4000000)
                            {
                                airConditioner.DollarPrice = dollarPrice;
                            }
                            else
                            {
                                MessageBox.Show("DollarPrice must be greater than or equal to 0 and smaller than 4000000.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return;
                            }
                        }
                        else
                        {
                            MessageBox.Show("Invalid dollar price. Please enter a valid number.");
                            return;
                        }

                        _airconditionerRepository.Update(airConditioner);

                        button1.PerformClick();
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

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txbAirId.Text.Trim(), out int airConditionerId))
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

                    button1.PerformClick();

                    MessageBox.Show("Air conditioner deleted successfully.");
                }

            }
            else
            {
                MessageBox.Show("Air conditioner not found.");
            }

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            var search = txbSearch.Text.Trim().ToLower();
            var listAirCondition = _airconditionerRepository.GetAll();
            var listSupplierCompany = _supplierCompanyRepository.GetAll();
            var list = new List<NewListOut>();
            foreach (var item in listAirCondition)
            {
                var checkSupplier = listSupplierCompany.FirstOrDefault(s => s.SupplierId == item.SupplierId);
                if (item.FeatureFunction.ToLower().Contains(search))
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

                dgvAirConditioner.DataSource = bind;
            }
            else
            {
                MessageBox.Show("Not found, please try again!");
            }
        }

        public static bool IsValidAirName(string name)
        {
            if (name.Length < 5 || name.Length > 90)
            {
                return false;
            }

            string[] words = name.Split(' ');

            foreach (string word in words)
            {
                if (char.IsLetter(word[0]))
                {
                    if (!char.IsUpper(word[0]))
                    {
                        return false;
                    }
                }
            }

            return true;
        }

        public static bool IsTitleCase(string str)
        {
            TextInfo textInfo = new CultureInfo("en-US", false).TextInfo;
            return str == textInfo.ToTitleCase(str);
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            int currentValue = trackBar1.Value;
            txbTrackBar.Text = currentValue.ToString();

            PerformSearchByQuantity(currentValue);
        }

        private void txbTrackBar_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txbTrackBar.Text))
            {
                if (int.TryParse(txbTrackBar.Text, out int value))
                {
                    if (value >= trackBar1.Minimum && value <= trackBar1.Maximum)
                    {
                        trackBar1.Value = value;
                        PerformSearchByQuantity(value);
                    }
                    else
                    {
                        MessageBox.Show($"Value must be within the range {trackBar1.Minimum} to {trackBar1.Maximum}");
                    }
                }
                else
                {
                    MessageBox.Show("Please enter a valid integer.");
                }
            }
            else
            {
            }
        }

        private void PerformSearchByQuantity(int currentValue)
        {
            var listAirCondition = _airconditionerRepository.GetAll();
            var listSupplierCompany = _supplierCompanyRepository.GetAll();
            var list = new List<NewListOut>();
            foreach (var item in listAirCondition)
            {
                var checkSupplier = listSupplierCompany.FirstOrDefault(s => s.SupplierId == item.SupplierId);
                if (item.Quantity <= currentValue)
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

                dgvAirConditioner.DataSource = bind;
            }
            else
            {
                MessageBox.Show("Not found, please try again!");
            }
        }

    }
}
