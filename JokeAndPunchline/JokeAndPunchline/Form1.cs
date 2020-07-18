using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JokeAndPunchline
{
    public partial class JokeForm : Form
    {
        public JokeForm()
        {
            InitializeComponent();
        }

        private void SetupButton_Click(object sender, EventArgs e)
        {
            SetupLabel.Visible = true;
            PunchlineLabel.Visible = false;
        }

        private void PunchlineButton_Click(object sender, EventArgs e)
        {
            SetupLabel.Visible = false;
            PunchlineLabel.Visible = true;
        }
    }
}
