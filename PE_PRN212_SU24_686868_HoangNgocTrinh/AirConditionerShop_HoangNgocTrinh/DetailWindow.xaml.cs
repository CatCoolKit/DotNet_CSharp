using AirConditionerShop.BLL.Services;
using AirConditionerShop.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace AirConditionerShop_HoangNgocTrinh
{
    /// <summary>
    /// Interaction logic for DetailWindow.xaml
    /// </summary>
    public partial class DetailWindow : Window
    {
        private readonly AirConService _airConService = new();

        public DetailWindow()
        {
            InitializeComponent();
        }

        private void SaveButton_Click(object sender, RoutedEventArgs e)
        {
            var airCon = new AirConditioner
            {
                AirConditionerId = int.Parse(AirConditionerIdTextBox.Text),
                AirConditionerName = AirConditionerNameTextBox.Text,
                Warranty = WarrantyTextBox.Text,
                SoundPressureLevel = SoundPressureLevelTextBox.Text,
                FeatureFunction = FeatureFunctionTextBox.Text,
                Quantity = int.Parse(QuantityTextBox.Text),
                DollarPrice = int.Parse(DollarPriceTextBox.Text),
                SupplierId = "SC0006"
                //SupplierId = SupplierIdComboBox.SelectedValue.ToString(),
            };

            _airConService.Add(airCon);
            this.Close();
        }

        private void SaveButton_Click_1(object sender, RoutedEventArgs e)
        {
            var airCon = new AirConditioner
            {
                AirConditionerId = int.Parse(AirConditionerIdTextBox.Text),
                AirConditionerName = AirConditionerNameTextBox.Text,
                Warranty = WarrantyTextBox.Text,
                SoundPressureLevel = SoundPressureLevelTextBox.Text,
                FeatureFunction = FeatureFunctionTextBox.Text,
                Quantity = int.Parse(QuantityTextBox.Text),
                DollarPrice = int.Parse(DollarPriceTextBox.Text),
                SupplierId = "SC0006"
                //SupplierId = SupplierIdComboBox.SelectedValue.ToString(),
            };

            _airConService.Add(airCon);
            this.Close();
        }
    }
}
