namespace WinAsynchMethod
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private async void button3_Click(object sender, EventArgs e)
        {
            int a, b;
            try
            {
                a = Int32.Parse(txbA.Text);
                b = Int32.Parse(txbB.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("При выполнении преобразования типов возникла ошибка");
                txbA.Text = txbB.Text = "";
                return;
            }
            int res = await Subb(a, b);
            lblResult.Text = res.ToString();
        }
        private async Task<int> Subb(int a, int b)
        {
            return await Task.Run(() =>
            {
                Thread.Sleep(5000);
                return a - b;
            }
            );
        }
    }
}
