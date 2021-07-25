using System;
using System.Windows.Forms;

namespace GameOfLife
{
    public partial class OptionsForm : Form
    {
        #region Control Properties

        // general

        public decimal ScaleX
        {
            get { return scaleXNumericUpDown.Value; }
            set { scaleXNumericUpDown.Value = value; }
        }

        public decimal ScaleY
        {
            get { return scaleYNumericUpDown.Value; }
            set { scaleYNumericUpDown.Value = value; }
        }

        public decimal Interval
        {
            get { return intervalNumericUpDown.Value; }
            set { intervalNumericUpDown.Value = value; }
        }

        public object BorderMode
        {
            get { return borderComboBox.SelectedItem; }
            set { borderComboBox.SelectedItem = value; }
        }

        // rules

        public decimal NeighborRadius
        {
            get { return neighborRadiusNumericUpDown.Value; }
            set { neighborRadiusNumericUpDown.Value = value; }
        }

        public decimal NeighborLiveMin
        {
            get { return neighborLiveMinNumericUpDown.Value; }
            set { neighborLiveMinNumericUpDown.Value = value; }
        }

        public decimal NeighborLiveMax
        {
            get { return neighborLiveMaxNumericUpDown.Value; }
            set { neighborLiveMaxNumericUpDown.Value = value; }
        }

        public decimal CellBirthThreshold
        {
            get { return cellBirthThresholdNumericUpDown.Value; }
            set { cellBirthThresholdNumericUpDown.Value = value; }
        }

        // generation

        public object RandomMode
        {
            get { return randomModeComboBox.SelectedItem; }
            set { randomModeComboBox.SelectedItem = value; }
        }

        public decimal RandomSeed
        {
            get { return randomSeedNumericUpDown.Value; }
            set { randomSeedNumericUpDown.Value = value; }
        }

        public decimal RandomThreshold
        {
            get { return randomThresholdNumericUpDown.Value; }
            set { randomThresholdNumericUpDown.Value = value; }
        }

        public decimal RandomMultiplier
        {
            get { return randomMultiplierNumericUpDown.Value; }
            set { randomMultiplierNumericUpDown.Value = value; }
        }

        // display

        public bool bShowHUD
        {
            get { return showHudCheckbox.Checked; }
            set { showHudCheckbox.Checked = value; }
        }

        public bool bShowNeighborCount
        {
            get { return showNeighborCountCheckbox.Checked; }
            set { showNeighborCountCheckbox.Checked = value; }
        }

        public bool bShowGrid
        {
            get { return showGridCheckbox.Checked; }
            set { showGridCheckbox.Checked = value; }
        }

        public System.Drawing.Color CellColor
        {
            get { return cellColorDialog.Color; }
            set { cellColorDialog.Color = value; }
        }

        public System.Drawing.Color GridColor
        {
            get { return gridColorDialog.Color; }
            set { gridColorDialog.Color = value; }
        }

        #endregion

        #region Events

        public event EventHandler EventOnApply;

        #endregion

        MainForm OwningForm;
        public FOptions Options;

        public OptionsForm(MainForm InOwningForm)
        {
            InitializeComponent();            

            // set up tab autoscrolling

            generalTableLayout.HorizontalScroll.Maximum = 0;
            generalTableLayout.AutoScroll = false;
            generalTableLayout.VerticalScroll.Visible = false;
            generalTableLayout.AutoScroll = true;

            rulesTableLayout.HorizontalScroll.Maximum = 0;
            rulesTableLayout.AutoScroll = false;
            rulesTableLayout.VerticalScroll.Visible = false;
            rulesTableLayout.AutoScroll = true;

            generationTableLayout.HorizontalScroll.Maximum = 0;
            generationTableLayout.AutoScroll = false;
            generationTableLayout.VerticalScroll.Visible = false;
            generationTableLayout.AutoScroll = true;

            displayTableLayout.HorizontalScroll.Maximum = 0;
            displayTableLayout.AutoScroll = false;
            displayTableLayout.VerticalScroll.Visible = false;
            displayTableLayout.AutoScroll = true;

            // set combo box data sources
            borderComboBox.DataSource = Enum.GetValues(typeof(EBorderMode));
            randomModeComboBox.DataSource = Enum.GetValues(typeof(ERandomMode));

            // set owner
            OwningForm = InOwningForm;

            // load options
            LoadOptions(OwningForm.Options);

            // bind apply event
            EventOnApply += SaveOptions;
        }

        private void randomSeedNewSeedButton_Click(object sender, EventArgs e)
        {
            Random RandomGenerator = new Random();
            randomSeedNumericUpDown.Value = RandomGenerator.Next((int)randomSeedNumericUpDown.Minimum, (int)randomSeedNumericUpDown.Maximum);
        }

        private void randomizeButton_Click(object sender, EventArgs e)
        {
            OwningForm.Randomize((ERandomMode)RandomMode, (float)RandomThreshold, (float)RandomMultiplier, (int)RandomSeed);

            // save generation options
            Options.Generation.RandomMode = (ERandomMode)RandomMode;
            Options.Generation.RandomSeed = (int)RandomSeed;
            Options.Generation.RandomMultiplier = (float)RandomMultiplier;
            Options.Generation.RandomThreshold = (float)RandomThreshold;

            // main form cosmetic tick
            OwningForm.OnWorldTickCosmetic();
        }

        private void LoadOptions(FOptions InOptions)
        {
            Options = InOptions;

            // general
            ScaleX = Options.General.Scale.X;
            ScaleY = Options.General.Scale.Y;
            Interval = Options.General.Interval;
            BorderMode = Options.General.BorderMode;

            // rules
            NeighborRadius = Options.Rules.NeighborRadius;
            NeighborLiveMin = Options.Rules.NeighborLiveMin;
            NeighborLiveMax = Options.Rules.NeighborLiveMax;
            CellBirthThreshold = Options.Rules.CellBirthThreshold;

            // generation
            RandomMode = Options.Generation.RandomMode;
            RandomSeed = Options.Generation.RandomSeed;
            RandomMultiplier = (decimal)Options.Generation.RandomMultiplier;
            RandomThreshold = (decimal)Options.Generation.RandomThreshold;

            // display
            bShowHUD = Options.Display.bShowHUD;
            bShowNeighborCount = Options.Display.bShowNeighborCount;
            bShowGrid = Options.Display.bShowGrid;
            CellColor = Options.Display.CellColor;
            GridColor = Options.Display.GridColor;
        }

        private void SaveOptions(object sender, EventArgs e)
        {
            // general
            Options.General.Scale = ((int)ScaleX, (int)ScaleY);
            Options.General.Interval = (int)Interval;
            Options.General.BorderMode = (EBorderMode)BorderMode;

            // rules
            Options.Rules.NeighborRadius = (int)NeighborRadius;
            Options.Rules.NeighborLiveMin = (int)NeighborLiveMin;
            Options.Rules.NeighborLiveMax = (int)NeighborLiveMax;
            Options.Rules.CellBirthThreshold = (int)CellBirthThreshold;

            // display
            Options.Display.bShowHUD = bShowHUD;
            Options.Display.bShowNeighborCount = bShowNeighborCount;
            Options.Display.bShowGrid = bShowGrid;
            Options.Display.CellColor = CellColor;
            Options.Display.GridColor = GridColor;
        }

        private void dialogConfirmButton_Click(object sender, EventArgs e)
        {
            EventOnApply.Invoke(sender, e);
        }

        private void cellColorButton_Click(object sender, EventArgs e)
        {
            CellColor = Options.Display.CellColor;

            if (cellColorDialog.ShowDialog() == DialogResult.OK)
            {
                Options.Display.CellColor = CellColor;
            }
        }

        private void gridColorButton_Click(object sender, EventArgs e)
        {
            GridColor = Options.Display.GridColor;

            if (gridColorDialog.ShowDialog() == DialogResult.OK)
            {
                Options.Display.GridColor = GridColor;
            }
        }
    }
}
