using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameOfLife
{
    public partial class NewProjectForm : Form
    {
        public EProjectType ProjectType;

        public NewProjectForm()
        {
            InitializeComponent();
        }

        private void blankButton_Click(object sender, EventArgs e)
        {
            ProjectType = EProjectType.Blank;
        }

        private void randomButton_Click(object sender, EventArgs e)
        {
            ProjectType = EProjectType.Random;
        }

        private void templateButton_Click(object sender, EventArgs e)
        {
            ProjectType = EProjectType.Lexicon;
        }
    }
}
