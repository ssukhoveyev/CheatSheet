using System.Windows.Forms;

namespace MouseRollTest
{
    public partial class Form1 : Form
    {
        int i;
        public Form1()
        {
            InitializeComponent();

            i = 50;

            this.MouseWheel += new MouseEventHandler(this_MouseWheel);

            progressBar1.Value = i;
        }

        void this_MouseWheel(object sender, MouseEventArgs e)
        {
            if (e.Delta > 0)
            {
                textBox1.Text = "Вверх" + e.Delta;
                if(i < 100)
                    progressBar1.Value = i++;
            }
            else
            {
                textBox1.Text = "Вниз" + e.Delta;
                if(i > 0)
                    progressBar1.Value = i--;
            }
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Middle)
                MessageBox.Show("Click middle button.");
        }
    }
}
