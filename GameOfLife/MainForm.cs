using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace GameOfLife
{
    public partial class MainForm : Form
    {
        #region Enums

        public enum EBorderMode
        {
            Clip,   // same as 'finite'
            Wrap,   // same as 'toroidal'
            Tile,   // not yet implemented
            Reflect // not yet implemented
        }

        #endregion

        #region Structs

        struct FOptions
        {
            public struct FOptionsGeneral
            {
                public (int X, int Y) Scale;
                public int Interval;
                public EBorderMode BorderMode;
            }

            public struct FOptionsRules
            {
                public int NeighborRadius;
                public int NeighborDeathMin;
                public int NeighborDeathMax;
                public int NeighborBirthMin;
                public int NeighborBirthMax;
            }

            public struct FOptionsGeneration
            {
                public bool bRandomize;
                public int RandomSeed;
                public float RandomThreshold;
                public float RandomMultiplier;
            }

            public struct FOptionsDisplay
            {
                public bool bShowNeighbors;
                public bool bShowGrid;
                public Color GridColor;
                public Color CellColor;
                public int NeighborsTextMargin;
                public int NeighborsTextSizeMin;
            }

            public FOptionsGeneral General;
            public FOptionsRules Rules;
            public FOptionsGeneration Generation;
            public FOptionsDisplay Display;
        }

        struct FCell
        {
            public bool Value;
            public int Neighbors;
        }

        #endregion

        FOptions Options = new FOptions();
        FCell[,] Cells;
        Timer FormTimer = new Timer();

        // status bar
        int Generation = 0;
        int Live = 0;
        int Total = 0;

        public MainForm()
        {
            InitializeComponent();
            
            // setup options (temp)
            Options.General.Scale = (64, 32);
            Options.General.Interval = 20;
            Options.General.BorderMode = EBorderMode.Wrap;
            Options.Rules.NeighborRadius = 1;
            Options.Rules.NeighborDeathMin = 2;
            Options.Rules.NeighborDeathMax = 3;
            Options.Rules.NeighborBirthMin = 3;
            Options.Rules.NeighborBirthMax = 3;
            Options.Generation.bRandomize = true;
            Options.Generation.RandomSeed = 2000;
            Options.Generation.RandomThreshold = 7.5f;
            Options.Generation.RandomMultiplier = 10.0f;
            Options.Display.bShowNeighbors = true;
            Options.Display.bShowGrid = true;
            Options.Display.GridColor = Color.FromArgb(240, 240, 240);
            Options.Display.CellColor = Color.FromArgb(208, 208, 208);
            Options.Display.NeighborsTextMargin = 2;
            Options.Display.NeighborsTextSizeMin = 8;

            Cells = new FCell[Options.General.Scale.X, Options.General.Scale.Y];

            // setup the timer
            FormTimer.Enabled = false;
            FormTimer.Interval = Options.General.Interval;
            FormTimer.Tick += Timer_Tick;

            toolStripPauseButton.Enabled = false;

            Randomize();
            UpdateOptions();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            // add implementation here
        }

        private void MainForm_KeyPress(object sender, KeyPressEventArgs e)
        {
            // check for Spacebar input
            if (e.KeyChar == ' ')
            {
                // add implementation here
            }
        }

        private void graphicsPanel_Paint(object sender, PaintEventArgs e)
        {
            // add implementation here
        }

        private void graphicsPanel_MouseClick(object sender, MouseEventArgs e)
        {
            // check for LMB input
            if (e.Button == MouseButtons.Left)
            {
                // add implementation here

                graphicsPanel.Invalidate(); // repaint form
            }
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            NextGeneration();
            UpdateStatusStrip();
        }

        private void NextGeneration()
        {
            // add implementation here

            Generation++;

            // repaint form
            graphicsPanel.Invalidate();
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

            // add implementation here

            return Count;
        }

        private int CountNeighborsWrap(int X, int Y, int Radius)
        {
            int Count = 0;

            // add implementation here

            return Count;
        }

        private void Randomize()
        {
            // add implementation here
        }

        private void Clear()
        {
            // add implementation here
        }

        private void UpdateOptions()
        {
            // add implementation here

            Generation = 0;
            Live = 0;
            Total = Options.General.Scale.X * Options.General.Scale.Y;
            
            for (int x = 0; x < Cells.GetLength(0); x++)
            {
                for (int y = 0; y < Cells.GetLength(1); y++)
                {
                    if (Cells[x, y].Value) Live++;
                }
            }

            UpdateStatusStrip();

            hudIntervalValueLabel.Text = Options.General.Interval.ToString();
            hudSeedValueLabel.Text = Options.Generation.RandomSeed.ToString();
            hudBorderValueLabel.Text = Options.General.BorderMode.ToString();
            hudScaleValueLabel.Text = Options.General.Scale.X.ToString() + " x " + Options.General.Scale.Y.ToString();

            hudSeedNameLabel.Visible = Options.Generation.bRandomize;
            hudSeedValueLabel.Visible = Options.Generation.bRandomize;
        }

        private void UpdateStatusStrip()
        {
            statusStripGenerationStatusLabel.Text = "Generation: " + Generation.ToString();
            statusStripLiveStatusLabel.Text = "Live: " + Live.ToString();
            statusStripTotalStatusLabel.Text = "Total: " + Total.ToString();
        }

        #region Tool Strip

        private void toolStripPlayButton_Click(object sender, EventArgs e)
        {
            // disable play and next buttons
            toolStripPlayButton.Enabled = false;
            toolStripNextButton.Enabled = false;

            // enable pause button
            toolStripPauseButton.Enabled = true;

            // enable timer
            FormTimer.Enabled = true;
        }

        private void toolStripPauseButton_Click(object sender, EventArgs e)
        {
            // disable pause button
            toolStripPauseButton.Enabled = false;

            // enable play and next buttons
            toolStripPlayButton.Enabled = true;
            toolStripNextButton.Enabled = true;

            // disable timer
            FormTimer.Enabled = false;
        }

        private void toolStripNextButton_Click(object sender, EventArgs e)
        {
            Timer_Tick(sender, e);

            // repaint form
            graphicsPanel.Invalidate();
        }

        #endregion
    }
}
