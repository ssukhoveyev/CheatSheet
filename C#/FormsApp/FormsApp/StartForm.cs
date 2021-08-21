using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormsApp
{
    public partial class StartForm : Form
    {
        public StartForm()
        {
            InitializeComponent();
        }

        private void buttonFullScreenForm_Click(object sender, EventArgs e)
        {
            FullScreenForm f = new FullScreenForm();
            f.Show();
        }

        private void buttonCloseEvent_Click(object sender, EventArgs e)
        {
            CloseEventForm f = new CloseEventForm();
            f.Owner = this;
            f.FormClosed += CloseEventForm_FormClosed;
            f.Show();
        }

        private void CloseEventForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            MessageBox.Show("Форма закрыта.");
        }

        private void buttonTransparentForm_Click(object sender, EventArgs e)
        {
            TransparentForm tf = new TransparentForm();
            tf.Show();
        }
    }
}
