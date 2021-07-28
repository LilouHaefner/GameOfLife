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
    public partial class ImportForm : Form
    {
        public FImportOptions ImportOptions;

        public ImportForm(MainForm InOwningForm)
        {
            InitializeComponent();

            // set numeric up down limits
            offsetXNumericUpDown.Minimum = -InOwningForm.Cells.GetLength(0) + 1;
            offsetXNumericUpDown.Maximum = InOwningForm.Cells.GetLength(0) - 1;
            offsetYNumericUpDown.Minimum = -InOwningForm.Cells.GetLength(1) + 1;
            offsetYNumericUpDown.Maximum = InOwningForm.Cells.GetLength(1) - 1;

            // set combo box data source
            importModeComboBox.DataSource = Enum.GetValues(typeof(EImportMode));
        }

        private void offsetXNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            ImportOptions.OffsetX = (int)offsetXNumericUpDown.Value;
        }

        private void offsetYNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            ImportOptions.OffsetY = (int)offsetYNumericUpDown.Value;
        }

        private void importModeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ImportOptions.ImportMode = (EImportMode)importModeComboBox.SelectedItem;
        }
    }
}
