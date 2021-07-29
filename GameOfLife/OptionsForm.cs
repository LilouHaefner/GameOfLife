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
            get { return borderModeComboBox.SelectedItem; }
            set { borderModeComboBox.SelectedItem = value; }
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

        #endregion

        #region Events

        public event EventHandler EventOnApply;

        #endregion

        MainForm OwningForm;
        public FUserOptions UserOptions;

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
            borderModeComboBox.DataSource = Enum.GetValues(typeof(EBorderMode));
            randomModeComboBox.DataSource = Enum.GetValues(typeof(ERandomMode));

            // set owner
            OwningForm = InOwningForm;

            // load options
            LoadOptions(OwningForm.UserOptions);

            // set seed controls enabled
            if (UserOptions.Generation.RandomMode == ERandomMode.Seed)
            {
                randomSeedNumericUpDown.Enabled = true;
                randomSeedNewSeedButton.Enabled = true;
            }

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
            UserOptions.Generation.RandomMode = (ERandomMode)RandomMode;
            UserOptions.Generation.RandomSeed = (int)RandomSeed;
            UserOptions.Generation.RandomMultiplier = (float)RandomMultiplier;
            UserOptions.Generation.RandomThreshold = (float)RandomThreshold;

            // main form cosmetic tick
            OwningForm.OnWorldTickCosmetic();
        }

        private void LoadOptions(FUserOptions InUserOptions)
        {
            UserOptions = InUserOptions;

            // general
            ScaleX = UserOptions.General.Scale.X;
            ScaleY = UserOptions.General.Scale.Y;
            Interval = UserOptions.General.Interval;
            BorderMode = UserOptions.General.BorderMode;

            // rules
            NeighborRadius = UserOptions.Rules.NeighborRadius;
            NeighborLiveMin = UserOptions.Rules.NeighborLiveMin;
            NeighborLiveMax = UserOptions.Rules.NeighborLiveMax;
            CellBirthThreshold = UserOptions.Rules.CellBirthThreshold;

            // generation
            RandomMode = UserOptions.Generation.RandomMode;
            RandomSeed = UserOptions.Generation.RandomSeed;
            RandomMultiplier = (decimal)UserOptions.Generation.RandomMultiplier;
            RandomThreshold = (decimal)UserOptions.Generation.RandomThreshold;

            // display
            bShowHUD = UserOptions.Display.bShowHUD;
            bShowNeighborCount = UserOptions.Display.bShowNeighborCount;
            bShowGrid = UserOptions.Display.bShowGrid;
        }

        private void SaveOptions(object sender, EventArgs e)
        {
            // general
            UserOptions.General.Scale = new System.Drawing.Point((int)ScaleX, (int)ScaleY);
            UserOptions.General.Interval = (int)Interval;
            UserOptions.General.BorderMode = (EBorderMode)BorderMode;

            // rules
            UserOptions.Rules.NeighborRadius = (int)NeighborRadius;
            UserOptions.Rules.NeighborLiveMin = (int)NeighborLiveMin;
            UserOptions.Rules.NeighborLiveMax = (int)NeighborLiveMax;
            UserOptions.Rules.CellBirthThreshold = (int)CellBirthThreshold;

            // display
            UserOptions.Display.bShowHUD = bShowHUD;
            UserOptions.Display.bShowNeighborCount = bShowNeighborCount;
            UserOptions.Display.bShowGrid = bShowGrid;
        }

        private void dialogConfirmButton_Click(object sender, EventArgs e)
        {
            EventOnApply.Invoke(sender, e);
        }

        private void cellColorButton_Click(object sender, EventArgs e)
        {
            ColorDialog Dialog = new ColorDialog();

            Dialog.Color = UserOptions.Display.CellColor;

            if (Dialog.ShowDialog() == DialogResult.OK)
            {
                UserOptions.Display.CellColor = Dialog.Color;
                OwningForm.SetCellColor(Dialog.Color);
            }


            OwningForm.OnWorldTickCosmetic();
        }

        private void gridColorButton_Click(object sender, EventArgs e)
        {
            ColorDialog Dialog = new ColorDialog();

            Dialog.Color = UserOptions.Display.GridColor;

            if (Dialog.ShowDialog() == DialogResult.OK)
            {
                UserOptions.Display.GridColor = Dialog.Color;
                OwningForm.SetGridColor(Dialog.Color);
            }

            OwningForm.OnWorldTickCosmetic();
        }

        private void backgroundColorButton_Click(object sender, EventArgs e)
        {
            ColorDialog Dialog = new ColorDialog();

            Dialog.Color = UserOptions.Display.BackgroundColor;

            if (Dialog.ShowDialog() == DialogResult.OK)
            {
                UserOptions.Display.BackgroundColor = Dialog.Color;
                OwningForm.SetBackgroundColor(Dialog.Color);
            }

            OwningForm.OnWorldTickCosmetic();
        }

        private void resetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OwningForm.Reset();
            LoadOptions(OwningForm.UserOptions);
        }

        private void reloadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OwningForm.Reload();
            LoadOptions(OwningForm.UserOptions);
        }

        private void randomModeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (randomModeComboBox.SelectedValue)
            {
                case ERandomMode.Seed:
                    {
                        randomSeedNumericUpDown.Enabled = true;
                        randomSeedNewSeedButton.Enabled = true;

                        break;
                    }
                case ERandomMode.Time:
                    {
                        randomSeedNumericUpDown.Enabled = false;
                        randomSeedNewSeedButton.Enabled = false;

                        break;
                    }
            }
        }
    }
}
