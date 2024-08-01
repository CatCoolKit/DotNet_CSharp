using Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Eternity
{
    public partial class ZodiacManager : Form
    {
        public ZodiacManager()
        {
            InitializeComponent();
        }

        private void btnShowImage_Click(object sender, EventArgs e)
        {
            Image image = Image.FromFile(@"signs\HotGirl.jpg");

            picImage.Image = image;
        }

        private void btnCheckZodiac_Click(object sender, EventArgs e)
        {
            var day = int.Parse(txtDay.Text);
            var month = int.Parse(txtMonth.Text);
            string zodiac = ZodiacCalculator.GetZodiacEnglish(month, day);
            string zodiacVN = ZodiacCalculator.GetZodiacVietnamese(zodiac);
            string ZodiacImage = "signs\\" + zodiac + ".jpg";
            Image image = Image.FromFile(ZodiacImage);

            picImage.Image = image;
            lblYourZodiac.Text = $"Your zodiac sign is - Cung hoàng đạo của bạn là: {zodiac} | {zodiacVN}";
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit(); // Exit the application
        }
    }
}
