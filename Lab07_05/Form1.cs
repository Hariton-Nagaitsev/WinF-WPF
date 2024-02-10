using System.Text;

namespace Lab07_05
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            if (int.TryParse(MaxValueTextBox.Text, out int maxValue))
            {
                // �������� ������ ������ ��� ���������� ��������� ����������
                Thread sieveThread = new Thread(() =>
                {
                    string result = GoButt(maxValue);

                    // ���������� ���������� � �������� ������
                    this.Invoke((MethodInvoker)delegate
                    {
                        ResultTextBox.Text = result;
                    });
                });

                // ������ ���������� ������
                sieveThread.Start();
            }
            else
            {
                ResultTextBox.Text = "Unable to parse maximum value.";
            }
        }

        private string GoButt(int maxValue)
        {
            StringBuilder resultText = new StringBuilder();

            for (int trial = 2; trial <= maxValue; trial++)
            {
                bool isPrime = true;

                for (int divisor = 2; divisor <= Math.Sqrt(trial); divisor++)
                {
                    if (trial % divisor == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }

                if (isPrime)
                {
                    resultText.AppendFormat("{0} ", trial);
                }
            }

            return resultText.ToString();
        }
    }
}
