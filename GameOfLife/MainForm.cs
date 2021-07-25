using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace GameOfLife
{
    #region Enums

    public enum EBorderMode
    {
        Clip,   // same as 'finite'
        Wrap   // same as 'toroidal'
        //Tile   // not yet implemented
        //Reflect // not yet implemented
    }

    public enum ERandomMode
    {
        Seed,
        Time
    }

    #endregion

    #region Structs

    public struct FOptions
    {
        public struct FOptionsGeneral
        {
            public Point Scale;
            public int Interval;
            public EBorderMode BorderMode;

            public void Load()
            {
                Scale = Properties.Settings.Default.Scale;
                Interval = Properties.Settings.Default.Interval;
                BorderMode = Properties.Settings.Default.BorderMode;
            }

            public void Save()
            {
                Properties.Settings.Default.Scale = Scale;
                Properties.Settings.Default.Interval = Interval;
                Properties.Settings.Default.BorderMode = BorderMode;
            }
        }

        public struct FOptionsRules
        {
            public int NeighborRadius;
            public int NeighborLiveMin;
            public int NeighborLiveMax;
            public int CellBirthThreshold;

            public void Load()
            {
                NeighborRadius = Properties.Settings.Default.NeighborRadius;
                NeighborLiveMin = Properties.Settings.Default.NeighborLiveMin;
                NeighborLiveMax = Properties.Settings.Default.NeighborLiveMax;
                CellBirthThreshold = Properties.Settings.Default.CellBirthThreshold;
            }

            public void Save()
            {
                Properties.Settings.Default.NeighborRadius = NeighborRadius;
                Properties.Settings.Default.NeighborLiveMin = NeighborLiveMin;
                Properties.Settings.Default.NeighborLiveMax = NeighborLiveMax;
                Properties.Settings.Default.CellBirthThreshold = CellBirthThreshold;
            }
        }

        public struct FOptionsGeneration
        {
            public ERandomMode RandomMode;
            public int RandomSeed;
            public float RandomThreshold;
            public float RandomMultiplier;

            public void Load()
            {
                RandomMode = Properties.Settings.Default.RandomMode;
                RandomSeed = Properties.Settings.Default.RandomSeed;
                RandomThreshold = Properties.Settings.Default.RandomThreshold;
                RandomMultiplier = Properties.Settings.Default.RandomMultiplier;
            }

            public void Save()
            {
                Properties.Settings.Default.RandomMode = RandomMode;
                Properties.Settings.Default.RandomSeed = RandomSeed;
                Properties.Settings.Default.RandomThreshold = RandomThreshold;
                Properties.Settings.Default.RandomMultiplier = RandomMultiplier;
            }
        }

        public struct FOptionsDisplay
        {
            public bool bShowHUD;
            public bool bShowNeighborCount;
            public bool bShowGrid;
            public Color GridColor;
            public Color CellColor;
            public Color BackgroundColor;

            public void Load()
            {
                bShowHUD = Properties.Settings.Default.bShowHUD;
                bShowNeighborCount = Properties.Settings.Default.bShowNeighborCount;
                bShowGrid = Properties.Settings.Default.bShowGrid;
                GridColor = Properties.Settings.Default.GridColor;
                CellColor = Properties.Settings.Default.CellColor;
                BackgroundColor = Properties.Settings.Default.BackgroundColor;
            }

            public void Save()
            {
                Properties.Settings.Default.bShowHUD = bShowHUD;
                Properties.Settings.Default.bShowNeighborCount = bShowNeighborCount;
                Properties.Settings.Default.bShowGrid = bShowGrid;
                Properties.Settings.Default.GridColor = GridColor;
                Properties.Settings.Default.CellColor = CellColor;
                Properties.Settings.Default.BackgroundColor = BackgroundColor;
            }
        }

        public FOptionsGeneral General;
        public FOptionsRules Rules;
        public FOptionsGeneration Generation;
        public FOptionsDisplay Display;

        public void Load()
        {
            General.Load();
            Rules.Load();
            Generation.Load();
            Display.Load();
        }

        public void Save()
        {
            General.Save();
            Rules.Save();
            Generation.Save();
            Display.Save();
        }
    }

    public struct FCell
    {
        public bool Value;
        public int Neighbors;
    }

    #endregion

    public partial class MainForm : Form
    {
        public FOptions Options = new FOptions();
        FCell[,] Cells;
        Timer FormTimer = new Timer();

        // status bar
        int Generation = 0;
        int Live = 0;
        int Total = 0;

        // input
        bool bIsPlay = false;

        // text
        float NeighborTextSizeMulitplier = 10;
        float NeighborTextSizeMin = 4;
        float NeighborTextSizeMax = 24;

        // constructor
        public MainForm()
        {
            InitializeComponent();

            Options.Load();

            // init world
            OnWorldInit();

            // setup the timer
            FormTimer.Enabled = false;
            FormTimer.Interval = Options.General.Interval;
            FormTimer.Tick += Timer_Tick;

            // randomize world
            Randomize(Options.Generation.RandomMode, Options.Generation.RandomThreshold, Options.Generation.RandomMultiplier, Options.Generation.RandomSeed);

            // load world
            OnWorldLoad();

            // repaint form
            graphicsPanel.Invalidate();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            // add implementation here
        }

        private void MainForm_KeyPress(object sender, KeyPressEventArgs e)
        {
            // check for play input
            if (e.KeyChar == ' ')
            {
                if (bIsPlay) Pause();
                else Play();
            }
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Options.Save();
            Properties.Settings.Default.Save();
        }

        public void Reset()
        {
            Properties.Settings.Default.Reset();
            Options.Load();

            // init world
            OnWorldInit();

            // load world
            OnWorldLoad();
        }

        public void Reload()
        {
            Properties.Settings.Default.Reload();
            Options.Load();

            // init world
            OnWorldInit();

            // load world
            OnWorldLoad();
        }

        #region Shared Actions

        private void Clear()
        {
            // iterate through cells
            for (int x = 0; x < Cells.GetLength(0); x++)
            {
                for (int y = 0; y < Cells.GetLength(1); y++)
                {
                    Cells[x, y].Value = false;
                    Cells[x, y].Neighbors = 0;
                }
            }

            // repaint form
            graphicsPanel.Invalidate();
        }

        private void Play()
        {
            // disable play and next buttons

            // tool strip
            toolStripPlayButton.Enabled = false;
            toolStripNextButton.Enabled = false;

            // context menu
            contextMenuPlayMenuItem.Enabled = false;
            contextMenuNextMenuItem.Enabled = false;

            // enable pause buttons

            // tool strip
            toolStripPauseButton.Enabled = true;

            // context menu
            contextMenuPauseMenuItem.Enabled = true;

            // enable timer
            FormTimer.Enabled = true;

            // update play input
            bIsPlay = true;
        }

        private void Pause()
        {
            // enable play and next buttons

            // tool strip
            toolStripPlayButton.Enabled = true;
            toolStripNextButton.Enabled = true;

            // context menu
            contextMenuPlayMenuItem.Enabled = true;
            contextMenuNextMenuItem.Enabled = true;

            // disable pause buttons

            // tool strip
            toolStripPauseButton.Enabled = false;

            // context menu
            contextMenuPauseMenuItem.Enabled = false;

            // disable timer
            FormTimer.Enabled = false;

            // update play input
            bIsPlay = false;
        }

        private void Next(object sender, EventArgs e)
        {
            Timer_Tick(sender, e);

            // repaint form
            graphicsPanel.Invalidate();
        }

        private void ShowOptions()
        {
            // create options form
            OptionsForm Dialog = new OptionsForm(this);

            // save current state
            FOptions SavedOptions = Options;
            FCell[,] SavedCells = CopyCells(Cells);

            if (Dialog.ShowDialog() == DialogResult.OK)
            {
                // save options
                UpdateOptions(Dialog.Options);
            }
            else
            {
                Options = SavedOptions;
                Cells = CopyCells(SavedCells);
            }

            // load world cosmetic
            OnWorldLoadCosmetic();

            // repaint form
            graphicsPanel.Invalidate();
        }

        #endregion

        #region Graphics Panel

        private void graphicsPanel_Paint(object sender, PaintEventArgs e)
        {
            // calculate cell size
            float CellWidth = (float)graphicsPanel.ClientSize.Width / (float)Cells.GetLength(0);
            float CellHeight = (float)graphicsPanel.ClientSize.Height / (float)Cells.GetLength(1);

            // create pen for grid lines
            Pen GridPen = new Pen(Options.Display.GridColor, 1);

            // create pen for cell fill
            Brush CellBrush = new SolidBrush(Options.Display.CellColor);

            // neighbor count font setup
            float FontSizeMultiplier = 0.05f;
            float FontSize = Math.Min(CellWidth, CellHeight) * (NeighborTextSizeMulitplier * FontSizeMultiplier);
            Font Font = new Font("Century Gothic", FontSize);
            StringFormat StringFormat = new StringFormat();
            StringFormat.Alignment = StringAlignment.Center;
            StringFormat.LineAlignment = StringAlignment.Center;

            bool bShowNeighbors = Options.Display.bShowNeighborCount && FontSize == Math.Min(Math.Max(NeighborTextSizeMin, FontSize), NeighborTextSizeMax);

            // iterate through cells
            for (int x = 0; x < Cells.GetLength(0); x++)
            {
                for (int y = 0; y < Cells.GetLength(1); y++)
                {
                    Cells[x, y].Neighbors = CountNeighbors(x, y);

                    // create rectangle to represent each cell in pixels
                    RectangleF cellRect = RectangleF.Empty;
                    cellRect.X = x * CellWidth;
                    cellRect.Y = y * CellHeight;
                    cellRect.Width = CellWidth;
                    cellRect.Height = CellHeight;

                    // draw cell fill
                    if (Cells[x, y].Value == true)
                    {
                        e.Graphics.FillRectangle(CellBrush, cellRect);
                    }

                    // draw cell lines
                    if (Options.Display.bShowGrid)
                    {
                        e.Graphics.DrawRectangle(GridPen, cellRect.X, cellRect.Y, cellRect.Width, cellRect.Height);
                    }

                    if (bShowNeighbors)
                    {
                        // only allow neighbor count to be shown if greater than 0 or cell is alive
                        if (Cells[x, y].Neighbors > 0 || Cells[x, y].Value)
                        {
                            // create rectangle
                            RectangleF rect = new RectangleF(cellRect.X, cellRect.Y, cellRect.Width, cellRect.Height);

                            // draw neighbor count in rectangle
                            e.Graphics.DrawString(Cells[x, y].Neighbors.ToString(), Font, Brushes.White, rect, StringFormat);
                        }
                    }
                }
            }

            // clean up pens and brushes
            GridPen.Dispose();
            CellBrush.Dispose();
        }

        private void graphicsPanel_MouseClick(object sender, MouseEventArgs e)
        {
            // check for LMB input
            if (e.Button == MouseButtons.Left)
            {
                // calculate the width and height of each cell in pixels
                float cellWidth = (float)graphicsPanel.ClientSize.Width / (float)Cells.GetLength(0);
                float cellHeight = (float)graphicsPanel.ClientSize.Height / (float)Cells.GetLength(1);

                // calculate the cell that was clicked in
                int x = (int)(e.X / cellWidth);
                int y = (int)(e.Y / cellHeight);

                // toggle the value of the cell
                Cells[x, y].Value = !Cells[x, y].Value;

                // repaint form
                graphicsPanel.Invalidate();
            }
        }

        #endregion

        #region Menu Strip

        private void menuStripQuitMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void menuStripClearMenuItem_Click(object sender, EventArgs e)
        {
            Clear();
        }

        #endregion

        #region Tool Strip

        private void toolStripOptionsButton_Click(object sender, EventArgs e)
        {
            ShowOptions();
        }

        private void toolStripPlayButton_Click(object sender, EventArgs e)
        {
            Play();
        }

        private void toolStripPauseButton_Click(object sender, EventArgs e)
        {
            Pause();
        }

        private void toolStripNextButton_Click(object sender, EventArgs e)
        {
            Next(sender, e);
        }

        #endregion

        #region Context Menu

        private void contextMenu_Opened(object sender, EventArgs e)
        {
            // update checkboxes
            contextMenuShowHudMenuItem.Checked = Options.Display.bShowHUD;
            contextMenuShowNeighborCountMenuItem.Checked = Options.Display.bShowNeighborCount;
            contextMenuShowGridMenuItem.Checked = Options.Display.bShowGrid;
        }

        private void contextMenuPlayMenuItem_Click(object sender, EventArgs e)
        {
            Play();
        }

        private void contextMenuPauseMenuItem_Click(object sender, EventArgs e)
        {
            Pause();
        }

        private void contextMenuNextMenuItem_Click(object sender, EventArgs e)
        {
            Next(sender, e);
        }

        private void contextMenuOptionsMenuItem_Click(object sender, EventArgs e)
        {
            ShowOptions();
        }

        private void contextMenuClearMenuItem_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void contextMenuShowHudMenuItem_Click(object sender, EventArgs e)
        {
            // toggle checkbox
            contextMenuShowHudMenuItem.Checked = !contextMenuShowHudMenuItem.Checked;

            // update options
            Options.Display.bShowHUD = contextMenuShowHudMenuItem.Checked;

            // call cosmetic load event
            OnWorldLoadCosmetic();

            // repaint form
            graphicsPanel.Invalidate();
        }

        private void contextMenuShowNeighborCountMenuItem_Click(object sender, EventArgs e)
        {
            // toggle checkbox
            contextMenuShowNeighborCountMenuItem.Checked = !contextMenuShowNeighborCountMenuItem.Checked;

            // update options
            Options.Display.bShowNeighborCount = contextMenuShowNeighborCountMenuItem.Checked;

            // repaint form
            graphicsPanel.Invalidate();
        }

        private void contextMenuShowGridMenuItem_Click(object sender, EventArgs e)
        {
            // toggle checkbox
            contextMenuShowGridMenuItem.Checked = !contextMenuShowGridMenuItem.Checked;

            // update options
            Options.Display.bShowGrid = contextMenuShowGridMenuItem.Checked;

            // repaint form
            graphicsPanel.Invalidate();
        }

        #endregion

        private void Timer_Tick(object sender, EventArgs e)
        {
            ApplyRules();

            // increment generation
            Generation++;

            // repaint form
            graphicsPanel.Invalidate();

            // call tick event
            OnWorldTick();
        }

        private void OnWorldInit()
        {
            Cells = new FCell[Options.General.Scale.X, Options.General.Scale.Y];
        }

        public void OnWorldLoadCosmetic()
        {
            // set background color
            graphicsPanel.BackColor = Options.Display.BackgroundColor;

            // show / hide hud
            hudPanel.Visible = Options.Display.bShowHUD;

            if (Options.Display.bShowHUD)
            {
                // show / hide seed
                hudSeedNameLabel.Visible = Options.Generation.RandomMode == ERandomMode.Seed;
                hudSeedValueLabel.Visible = Options.Generation.RandomMode == ERandomMode.Seed;

                // load seed
                if (Options.Generation.RandomMode == ERandomMode.Seed) hudSeedValueLabel.Text = Options.Generation.RandomSeed.ToString();

                // load hud labels
                hudIntervalValueLabel.Text = Options.General.Interval.ToString();
                hudBorderValueLabel.Text = Options.General.BorderMode.ToString();
                hudScaleValueLabel.Text = Options.General.Scale.X.ToString() + " x " + Options.General.Scale.Y.ToString();
            }

            // update total
            Total = Options.General.Scale.X * Options.General.Scale.Y;
            statusStripTotalStatusLabel.Text = "Total: " + Total.ToString();
        }

        private void OnWorldLoad()
        {
            // call cosmetic load event
            OnWorldLoadCosmetic();

            // disable pause buttons
            toolStripPauseButton.Enabled = false;
            contextMenuPauseMenuItem.Enabled = false;

            // reset labels
            Generation = 0;
            Live = 0;

            // iterate through cells
            for (int x = 0; x < Cells.GetLength(0); x++)
            {
                for (int y = 0; y < Cells.GetLength(1); y++)
                {
                    // calculate cell neighbors, live
                    Cells[x, y].Neighbors = CountNeighbors(x, y);
                    if (Cells[x, y].Value) Live++;
                }
            }

            // call tick event
            OnWorldTick();
        }

        public void OnWorldTickCosmetic()
        {
            // repaint form
            graphicsPanel.Invalidate();
        }

        private void OnWorldTick()
        {
            // update status labels
            statusStripGenerationStatusLabel.Text = "Generation: " + Generation.ToString();
            statusStripLiveStatusLabel.Text = "Live: " + Live.ToString();

            // call cosmetic tick event
            OnWorldTickCosmetic();
        }

        private void ApplyRules()
        {
            // create queue
            List<(int x, int y, bool Value)> Queue = new List<(int x, int y, bool Value)>();

            // iterate through cells
            for (int x = 0; x < Cells.GetLength(0); x++)
            {
                for (int y = 0; y < Cells.GetLength(1); y++)
                {
                    // // if cell is live
                    if (Cells[x, y].Value)
                    {
                        if (Cells[x, y].Neighbors < 2 || Cells[x, y].Neighbors > 3)
                        {
                            Queue.Add((x, y, false));
                        }
                    }
                    // // if cell is dead
                    else
                    {
                        if (Cells[x, y].Neighbors == 3)
                        {
                            Queue.Add((x, y, true));
                        }
                    }
                }
            }

            // resolve queue
            for (int i = 0; i < Queue.Count; i++)
            {
                Cells[Queue[i].x, Queue[i].y].Value = Queue[i].Value;
                
                // update live
                if (Queue[i].Value) Live++;
                else Live--;
            }
        }

        private int CountNeighbors(int X, int Y)
        {
            int Count = 0;

            switch (Options.General.BorderMode)
            {
                case EBorderMode.Clip:
                    Count = CountNeighborsClip(X, Y, Options.Rules.NeighborRadius);
                    break;
                case EBorderMode.Wrap:
                    Count = CountNeighborsWrap(X, Y, Options.Rules.NeighborRadius);
                    break;
            }

            return Count;
        }

        private int CountNeighborsClip(int X, int Y, int Radius)
        {
            int Count = 0;
            int LengthX = Cells.GetLength(0);
            int LengthY = Cells.GetLength(1);

            // iterate through a (2 * Radius) by (2 * Radius) square centered on cell (x, y)
            for (int OffsetX = -Radius; OffsetX <= Radius; OffsetX++)
            {
                for (int OffsetY = -Radius; OffsetY <= Radius; OffsetY++)
                {
                    int CellX = X + OffsetX;
                    int CellY = Y + OffsetY;

                    // if OffsetX and OffsetY are both equal to 0, continue
                    if (OffsetX == 0 && OffsetY == 0) continue;

                    // if CellX is less than 0, continue
                    if (CellX < 0) continue;

                    // if CellY is less than 0, continue
                    if (CellY < 0) continue;

                    // if CellX is greater than or equal to LengthX, continue
                    if (CellX >= LengthX) continue;

                    // if CellY is greater than or equal to LengthY, continue
                    if (CellY >= LengthY) continue;

                    if (Cells[CellX, CellY].Value) Count++;
                }
            }

            return Count;
        }

        private int CountNeighborsWrap(int X, int Y, int Radius)
        {
            int Count = 0;
            int LengthX = Cells.GetLength(0);
            int LengthY = Cells.GetLength(1);

            // iterate through a (2 * Radius) by (2 * Radius) square centered on cell (x, y)
            for (int OffsetX = -Radius; OffsetX <= Radius; OffsetX++)
            {
                for (int OffsetY = -Radius; OffsetY <= Radius; OffsetY++)
                {
                    int CellX = X + OffsetX;
                    int CellY = Y + OffsetY;

                    // if OffsetX and OffsetY are both equal to 0, continue
                    if (OffsetX == 0 && OffsetY == 0) continue;

                    // if CellX is less than 0, set to LengthX - 1
                    if (CellX < 0) CellX = LengthX - 1;

                    // if CellY is less than 0, set to LengthY - 1
                    if (CellY < 0) CellY = LengthY - 1;

                    // if CellX is greater than or equal to LengthX, set to 0
                    if (CellX >= LengthX) CellX = 0;

                    // if CellY is greater than or equal to LengthY, set to 0
                    if (CellY >= LengthY) CellY = 0;

                    if (Cells[CellX, CellY].Value) Count++;
                }
            }

            return Count;
        }

        public void Randomize(ERandomMode RandomMode, float Threshold, float Multiplier, int Seed = 0)
        {
            // reset live
            Live = 0;

            // create random generator
            Random RandomGenerator;

            // switch on random mode
            switch (RandomMode)
            {
                case ERandomMode.Seed:
                    RandomGenerator = new Random(Seed);
                    break;
                default:
                    RandomGenerator = new Random();
                    break;
            }

            // iterate through cells
            for (int x = 0; x < Cells.GetLength(0); x++)
            {
                for (int y = 0; y < Cells.GetLength(1); y++)
                {
                    // check random against threshold
                    Cells[x, y].Value = RandomGenerator.NextDouble() * Multiplier > Threshold;

                    // increment live
                    if (Cells[x, y].Value) Live++;
                }
            }
        }

        private FCell[,] CopyCells(FCell[,] InCells)
        {
            FCell[,] OutCells = new FCell[InCells.GetLength(0), InCells.GetLength(1)];

            for (int x = 0; x < Cells.GetLength(0); x++)
            {
                for (int y = 0; y < Cells.GetLength(1); y++)
                {
                    OutCells[x, y].Value = InCells[x, y].Value;
                    OutCells[x, y].Neighbors = InCells[x, y].Neighbors;
                }
            }

            return OutCells;
        }

        private void UpdateOptions(FOptions NewOptions)
        {
            // check if scale needs to be updated
            if (NewOptions.General.Scale.X != Options.General.Scale.X || NewOptions.General.Scale.Y != Options.General.Scale.Y)
            {
                Cells = new FCell[NewOptions.General.Scale.X, NewOptions.General.Scale.Y];

                // load world
                OnWorldLoad();
            }

            // check if interval needs to be updated
            if (NewOptions.General.Interval != Options.General.Interval)
            {
                FormTimer.Interval = NewOptions.General.Interval;
            }

            // update options
            Options = NewOptions;
        }

        public void SetCellColor(Color InColor)
        {
            Options.Display.CellColor = InColor;
        }

        public void SetGridColor(Color InColor)
        {
            Options.Display.GridColor = InColor;
        }

        public void SetBackgroundColor(Color InColor)
        {
            Options.Display.BackgroundColor = InColor;
            
            // update background color
            graphicsPanel.BackColor = Options.Display.BackgroundColor;
        }
    }
}
