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
    public partial class LexiconSearchForm : Form
    {
        public string SearchValue
        {
            get
            {
                return searchTextBox.Text;
            }
            set
            {
                searchTextBox.Text = value;
            }
        }

        public LexiconSearchForm()
        {
            InitializeComponent();
        }
    }
}
