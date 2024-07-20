namespace WinFormsApp1_1805
{
    public partial class calculation : Form
    {
        public calculation()
        {
            InitializeComponent(); //khởi tạo label

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string result = txtFullname.Text;
            if (result == "")
            {
                MessageBox.Show("Vui long nhap fullname");
                return;
            }
            lbresult.Text = result;
            MessageBox.Show("Xin chao");
        }

        private void submitCalculation_Click(object sender, EventArgs e)
        {
            // Check if the input fields are empty
            if (string.IsNullOrWhiteSpace(number1.Text) || string.IsNullOrWhiteSpace(number2.Text) || string.IsNullOrWhiteSpace(caculation.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ để thực hiện phép tính!");
                return;
            }

            // Declare variables for the inputs
            float nb1;
            float nb2;
            char cal;

            // Try parsing the numbers
            try
            {
                nb1 = float.Parse(number1.Text);
                nb2 = float.Parse(number2.Text);
            }
            catch (FormatException)
            {
                MessageBox.Show("Vui lòng nhập số hợp lệ!");
                return;
            }

            // Try parsing the operator
            try
            {
                cal = char.Parse(caculation.Text);
            }
            catch (FormatException)
            {
                MessageBox.Show("Vui lòng nhập phép tính hợp lệ!");
                return;
            }

            // Declare variable for the result
            float res = 0;

            // Perform the calculation based on the operator
            switch (cal)
            {
                case '+':
                    res = nb1 + nb2;
                    break;
                case '-':
                    res = nb1 - nb2;
                    break;
                case '*':
                    res = nb1 * nb2;
                    break;
                case '/':
                    if (nb2 == 0)
                    {
                        MessageBox.Show("Không thể chia cho 0!");
                        return;
                    }
                    res = nb1 / nb2;
                    break;
                default:
                    MessageBox.Show("Phép tính không hợp lệ! Vui lòng nhập một trong các phép tính: +, -, *, /");
                    return;
            }

            // Display the result
            rsCalculation.Text = res.ToString();


        }
    }
}
