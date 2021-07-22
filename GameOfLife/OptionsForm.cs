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

            rulesTableLayout.HorizontalScroll.Maximum = 0;
            rulesTableLayout.AutoScroll = false;
            rulesTableLayout.VerticalScroll.Visible = false;
            rulesTableLayout.AutoScroll = true;

            borderComboBox.DataSource = Enum.GetValues(typeof(EBorderMode));
        }
    }
}
