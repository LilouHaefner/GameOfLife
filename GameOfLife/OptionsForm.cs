using System;
using System.Windows.Forms;

namespace GameOfLife
{
    public partial class OptionsForm : Form
    {
        public OptionsForm()
        {
            InitializeComponent();

            generalTableLayout.HorizontalScroll.Maximum = 0;
            generalTableLayout.AutoScroll = false;
            generalTableLayout.VerticalScroll.Visible = false;
            generalTableLayout.AutoScroll = true;
            
            borderComboBox.DataSource = Enum.GetValues(typeof(EBorderMode));
        }
    }
}
