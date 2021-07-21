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

        public enum ERandomMode
        {
            Seed,
            Time
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
                public ERandomMode RandomMode;
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
                public int NeighborTextMargin;
                public int NeighborTextSizeMin;
                public int NeighborTextSizeMax;
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

        // input
        bool bIsPlay = false;

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
            Options.Generation.RandomMode = ERandomMode.Seed;
            Options.Generation.RandomSeed = 2000;
            Options.Generation.RandomThreshold = 7.5f;
            Options.Generation.RandomMultiplier = 10.0f;
            Options.Display.bShowNeighbors = true;
            Options.Display.bShowGrid = true;
            Options.Display.GridColor = Color.FromArgb(240, 240, 240);
            Options.Display.CellColor = Color.FromArgb(208, 208, 208);
            Options.Display.NeighborTextMargin = 2;
            Options.Display.NeighborTextSizeMin = 8;
            Options.Display.NeighborTextSizeMin = 32;

            Cells = new FCell[Options.General.Scale.X, Options.General.Scale.Y];

            // setup the timer
            FormTimer.Enabled = false;
            FormTimer.Interval = Options.General.Interval;
            FormTimer.Tick += Timer_Tick;

            toolStripPauseButton.Enabled = false;

            Randomize();
            OnWorldLoad();
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
                if (bIsPlay) OnPause();
                else OnPlay();

                bIsPlay = !bIsPlay;
            }
        }

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
            float FontSize = (Math.Min(CellWidth, CellHeight) - (Options.Display.NeighborTextMargin * 2));
            Font Font = new Font("Century Gothic", FontSize);
            StringFormat StringFormat = new StringFormat();
            StringFormat.Alignment = StringAlignment.Center;
            StringFormat.LineAlignment = StringAlignment.Center;

            bool bShowNeighbors = Options.Display.bShowNeighbors && FontSize == Math.Min(Math.Max(Options.Display.NeighborTextSizeMin, FontSize), Options.Display.NeighborTextSizeMax);

            // iterate through the universe
            for (int x = 0; x < Cells.GetLength(0); x++)
            {
                for (int y = 0; y < Cells.GetLength(1); y++)
                {
                    // create rectangle to represent each cell in pixels
                    RectangleF cellRect = RectangleF.Empty;
                    cellRect.X = x * CellWidth;
                    cellRect.Y = y * CellHeight;
                    cellRect.Width = CellWidth;
                    cellRect.Height = CellHeight;

                    // fill the cell if live
                    if (Cells[x, y].Value == true)
                    {
                        e.Graphics.FillRectangle(CellBrush, cellRect);
                    }

                    // outline the cell
                    e.Graphics.DrawRectangle(GridPen, cellRect.X, cellRect.Y, cellRect.Width, cellRect.Height);

                    if (bShowNeighbors)
                    {
                        // only allow neighbor count to be shown if greater than 0 or cell is alive
                        if (Cells[x, y].Neighbors > 0 || Cells[x, y].Value)
                        {
                            // create rectangle
                            RectangleF rect = new RectangleF(cellRect.X, cellRect.Y, cellRect.Width, cellRect.Height);

                            // draw neighbor count in rectangle
                            e.Graphics.DrawString(2.ToString(), Font, Brushes.White, rect, StringFormat);
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
                // add implementation here

                // repaint form
                graphicsPanel.Invalidate();
            }
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            NextGeneration();
            OnWorldTick();
        }

        #region Input

        private void OnPlay()
        {
            // disable play and next buttons
            toolStripPlayButton.Enabled = false;
            toolStripNextButton.Enabled = false;

            // enable pause button
            toolStripPauseButton.Enabled = true;

            // enable timer
            FormTimer.Enabled = true;
        }

        private void OnPause()
        {
            // disable pause button
            toolStripPauseButton.Enabled = false;

            // enable play and next buttons
            toolStripPlayButton.Enabled = true;
            toolStripNextButton.Enabled = true;

            // disable timer
            FormTimer.Enabled = false;
        }

        private void OnNext(object sender, EventArgs e)
        {
            Timer_Tick(sender, e);

            // repaint form
            graphicsPanel.Invalidate();
        }

        #endregion

        #region Tool Strip

        private void toolStripPlayButton_Click(object sender, EventArgs e)
        {
            OnPlay();
        }

        private void toolStripPauseButton_Click(object sender, EventArgs e)
        {
            OnPause();
        }

        private void toolStripNextButton_Click(object sender, EventArgs e)
        {
            OnNext(sender, e);
        }

        #endregion

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

        private void OnWorldLoad()
        {
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

            OnWorldTick();

            hudIntervalValueLabel.Text = Options.General.Interval.ToString();
            hudSeedValueLabel.Text = Options.Generation.RandomSeed.ToString();
            hudBorderValueLabel.Text = Options.General.BorderMode.ToString();
            hudScaleValueLabel.Text = Options.General.Scale.X.ToString() + " x " + Options.General.Scale.Y.ToString();

            hudSeedNameLabel.Visible = Options.Generation.bRandomize;
            hudSeedValueLabel.Visible = Options.Generation.bRandomize;

            statusStripTotalStatusLabel.Text = "Total: " + Total.ToString();
        }

        private void OnWorldTick()
        {
            statusStripGenerationStatusLabel.Text = "Generation: " + Generation.ToString();
            statusStripLiveStatusLabel.Text = "Live: " + Live.ToString();
        }
    }
}
