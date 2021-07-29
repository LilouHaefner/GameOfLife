using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
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

    public enum EImportMode
    {
        Override,
        MaskLive,
        MaskDead
    }

    public enum EProjectType
    {
        Blank,
        Random,
        Lexicon
    }

    #endregion

    #region Structs

    public struct FUserOptions
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

    public struct FApplicationOptions
    {
        public struct FTextOptions
        {
            public string NeighborCountFontName;
            public float NeighborCountSizeMultiplier;
            public float NeighborCountSizeMin;

            public void Load()
            {
                NeighborCountFontName = Properties.Settings.Default.NeighborCountFontName;
                NeighborCountSizeMultiplier = Properties.Settings.Default.NeighborCountSizeMultiplier;
                NeighborCountSizeMin = Properties.Settings.Default.NeighborCountSizeMin;
            }
        }

        public struct FFileOptions
        {
            public string FileSuffix;
            public char LiveSymbol;
            public char DeadSymbol;
            public char CommentSymbol;

            public void Load()
            {
                FileSuffix = Properties.Settings.Default.FileSuffix;
                LiveSymbol = Properties.Settings.Default.LiveSymbol;
                DeadSymbol = Properties.Settings.Default.DeadSymbol;
                CommentSymbol = Properties.Settings.Default.CommentSymbol;
            }
        }

        public FTextOptions Text;
        public FFileOptions File;

        public void Load()
        {
            Text.Load();
            File.Load();
        }
    }

    public struct FImportOptions
    {
        public int OffsetX;
        public int OffsetY;
        public EImportMode ImportMode;
    }

    public struct FCell
    {
        public bool Value;
        public int Neighbors;
    }

    #endregion

    public partial class MainForm : Form
    {
        public FUserOptions UserOptions = new FUserOptions();
        FApplicationOptions ApplicationOptions = new FApplicationOptions();
        public FCell[,] Cells { get; private set; }
        Timer FormTimer = new Timer();

        // status bar
        int Generation = 0;
        int Live = 0;
        int Total = 0;

        // input
        bool bIsPlay = false;

        // save
        string LastSavedFileName;

        // helpers
        bool bShowHelpers = false;

        // constructor
        public MainForm()
        {
            InitializeComponent();

            // load options
            UserOptions.Load();
            ApplicationOptions.Load();

            // init world
            OnWorldInit();

            // setup the timer
            FormTimer.Interval = UserOptions.General.Interval;
            FormTimer.Tick += Timer_Tick;
            Pause();

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
            UserOptions.Save();
            Properties.Settings.Default.Save();
        }

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
            Cells = new FCell[UserOptions.General.Scale.X, UserOptions.General.Scale.Y];
        }

        public void OnWorldLoadCosmetic()
        {
            // set background color
            graphicsPanel.BackColor = UserOptions.Display.BackgroundColor;

            // show / hide hud
            hudPanel.Visible = UserOptions.Display.bShowHUD;

            if (UserOptions.Display.bShowHUD)
            {
                // show / hide seed
                hudSeedNameLabel.Visible = UserOptions.Generation.RandomMode == ERandomMode.Seed;
                hudSeedValueLabel.Visible = UserOptions.Generation.RandomMode == ERandomMode.Seed;

                // load seed
                if (UserOptions.Generation.RandomMode == ERandomMode.Seed) hudSeedValueLabel.Text = UserOptions.Generation.RandomSeed.ToString();

                // load hud labels
                hudIntervalValueLabel.Text = UserOptions.General.Interval.ToString();
                hudBorderValueLabel.Text = UserOptions.General.BorderMode.ToString();
                hudScaleValueLabel.Text = UserOptions.General.Scale.X.ToString() + " x " + UserOptions.General.Scale.Y.ToString();
            }

            // update total
            Total = Cells.GetLength(0) * Cells.GetLength(1); //UserOptions.General.Scale.X * UserOptions.General.Scale.Y;
            statusStripTotalStatusLabel.Text = "Total: " + Total.ToString();
        }

        private void OnWorldLoad()
        {
            // call cosmetic load event
            OnWorldLoadCosmetic();

            // reset saved file name
            LastSavedFileName = null;

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
            // update status labels
            statusStripGenerationStatusLabel.Text = "Generation: " + Generation.ToString();
            statusStripLiveStatusLabel.Text = "Live: " + Live.ToString();

            // repaint form
            graphicsPanel.Invalidate();
        }

        private void OnWorldTick()
        {
            // call cosmetic tick event
            OnWorldTickCosmetic();
        }

        private void OnWorldResize()
        {
            OnWorldInit();
            OnWorldLoad();
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

        private void ResizeWorld(int NewX, int NewY)
        {
            // save current state
            FCell[,] SavedCells = CopyCells(Cells);

            // update options
            UserOptions.General.Scale.X = NewX;
            UserOptions.General.Scale.Y = NewY;

            OnWorldResize();

            // reset to previous state
            if (Cells.GetLength(0) < SavedCells.GetLength(0) && Cells.GetLength(1) < SavedCells.GetLength(1))
            {
                for (int x = 0; x < Cells.GetLength(0); x++)
                {
                    for (int y = 0; y < Cells.GetLength(1); y++)
                    {
                        Cells[x, y].Value = SavedCells[x, y].Value;
                        Cells[x, y].Neighbors = SavedCells[x, y].Neighbors;
                    }
                }
            }
        }

        public void SetCellColor(Color InColor)
        {
            UserOptions.Display.CellColor = InColor;
        }

        public void SetGridColor(Color InColor)
        {
            UserOptions.Display.GridColor = InColor;
        }

        public void SetBackgroundColor(Color InColor)
        {
            UserOptions.Display.BackgroundColor = InColor;

            // update background color
            graphicsPanel.BackColor = UserOptions.Display.BackgroundColor;
        }

        private void UpdateOptions(FUserOptions NewOptions)
        {
            // check if scale needs to be updated
            if (NewOptions.General.Scale.X != UserOptions.General.Scale.X || NewOptions.General.Scale.Y != UserOptions.General.Scale.Y)
            {
                ResizeWorld(NewOptions.General.Scale.X, NewOptions.General.Scale.Y);
            }

            // check if interval needs to be updated
            if (NewOptions.General.Interval != UserOptions.General.Interval)
            {
                FormTimer.Interval = NewOptions.General.Interval;
            }

            // update options
            UserOptions = NewOptions;
        }

        #region Settings

        public void Reset()
        {
            Properties.Settings.Default.Reset();
            UserOptions.Load();

            // init world
            OnWorldInit();

            // load world
            OnWorldLoad();
        }

        public void Reload()
        {
            Properties.Settings.Default.Reload();
            UserOptions.Load();

            // init world
            OnWorldInit();

            // load world
            OnWorldLoad();
        }

        #endregion

        #region File Handling

        private void Save()
        {
            if (string.IsNullOrEmpty(LastSavedFileName) || !File.Exists(LastSavedFileName))
            {
                SaveAs();
            }
            else
            {
                OnSave(LastSavedFileName);
            }
        }

        private void OnSave(string FileName)
        {
            // create stream writer
            StreamWriter Writer = new StreamWriter(FileName);

            // updated saved file name
            LastSavedFileName = FileName;

            // write header
            Writer.WriteLine($"!Info");
            Writer.WriteLine($"[Live Symbol\t] {ApplicationOptions.File.LiveSymbol}");
            Writer.WriteLine($"[Dead Symbol\t] {ApplicationOptions.File.DeadSymbol}");
            Writer.WriteLine();
            Writer.WriteLine($"!Properties");
            Writer.WriteLine($"[Border Mode\t] {UserOptions.General.BorderMode}");
            Writer.WriteLine();

            // iterate through columns
            for (int y = 0; y < Cells.GetLength(1); y++)
            {
                String CurrentLine = string.Empty;

                // iterate through rows
                for (int x = 0; x < Cells.GetLength(0); x++)
                {
                    if (Cells[x, y].Value) CurrentLine += ApplicationOptions.File.LiveSymbol;
                    else if (!Cells[x, y].Value) CurrentLine += ApplicationOptions.File.DeadSymbol;
                }

                // write current line
                Writer.WriteLine(CurrentLine);
            }

            // close the file
            Writer.Close();
        }

        private void SaveAs(char DeadChar = '.', char LiveChar = 'O')
        {
            SaveFileDialog Dialog = new SaveFileDialog();
            Dialog.Filter = "All Files|*.*|Cells|*.cells";
            Dialog.FilterIndex = 2; Dialog.DefaultExt = "cells";

            if (DialogResult.OK == Dialog.ShowDialog())
            {
                OnSave(Dialog.FileName);
            }
        }

        private void Import()
        {
            if (bIsPlay) Pause();

            OpenFileDialog OpenDialog = new OpenFileDialog();
            OpenDialog.Filter = "All Files|*.*|Cells|*.cells";
            OpenDialog.FilterIndex = 2;

            if (OpenDialog.ShowDialog() == DialogResult.OK)
            {
                ImportForm ImportDialog = new ImportForm(this);

                if (ImportDialog.ShowDialog() == DialogResult.OK)
                {
                    ImportFile(OpenDialog.FileName, ImportDialog.ImportOptions);
                }
            }
        }

        private void ImportFile(string FileName, FImportOptions ImportOptions)
        {
            StreamReader Reader = new StreamReader(FileName);

            int LocalY = 0;

            // read cell data
            while (!Reader.EndOfStream)
            {
                string CurrentLine = Reader.ReadLine();

                // ignore empty lines
                if (string.IsNullOrWhiteSpace(CurrentLine)) continue;

                // ignore comments
                if (CurrentLine[0] == ApplicationOptions.File.CommentSymbol) continue;

                if (CurrentLine[0] == '[') continue;

                for (int LocalX = 0; LocalX < CurrentLine.Length; LocalX++)
                {
                    int CurrentX = ImportOptions.OffsetX + LocalX;
                    int CurrentY = ImportOptions.OffsetY + LocalY;

                    if (CurrentX != Math.Min(Math.Max(0, CurrentX), Cells.GetLength(0) - 1)) continue;
                    if (CurrentY != Math.Min(Math.Max(0, CurrentY), Cells.GetLength(1) - 1)) continue;

                    switch (ImportOptions.ImportMode)
                    {
                        case EImportMode.Override:
                            {
                                if (CurrentLine[LocalX] == ApplicationOptions.File.LiveSymbol) Cells[CurrentX, CurrentY].Value = true;
                                else if (CurrentLine[LocalX] == ApplicationOptions.File.DeadSymbol) Cells[CurrentX, CurrentY].Value = false;

                                break;
                            }

                        case EImportMode.MaskLive:
                            {
                                if (CurrentLine[LocalX] == ApplicationOptions.File.LiveSymbol) Cells[CurrentX, CurrentY].Value = true;

                                break;
                            }

                        case EImportMode.MaskDead:
                            {
                                if (CurrentLine[LocalX] == ApplicationOptions.File.DeadSymbol) Cells[CurrentX, CurrentY].Value = false;

                                break;
                            }
                    }
                }

                LocalY++;
            }

            // close the file.
            Reader.Close();

            OnWorldLoad();
        }

        private void Open()
        {
            if (bIsPlay) Pause();

            OpenFileDialog OpenDialog = new OpenFileDialog();
            OpenDialog.Filter = "All Files|*.*|Cells|*.cells";
            OpenDialog.FilterIndex = 2;

            if (OpenDialog.ShowDialog() == DialogResult.OK)
            {
                OpenFile(OpenDialog.FileName);
            }
        }

        private void OpenFile(string FileName)
        {
            StreamReader Reader = new StreamReader(FileName);

            int MaxWidth = 0;
            int MaxHeight = 0;

            // calculate world size from file
            while (!Reader.EndOfStream)
            {
                // read the next line
                string CurrentLine = Reader.ReadLine();

                // ignore empty lines
                if (string.IsNullOrWhiteSpace(CurrentLine)) continue;

                // ignore comments
                if (CurrentLine[0] == ApplicationOptions.File.CommentSymbol) continue;

                // ignore properties
                if (CurrentLine[0] == '[') continue;

                // update max width if necessary
                if (CurrentLine.Length > MaxWidth) MaxWidth = CurrentLine.Length;

                // increment max height
                MaxHeight++;
            }

            ResizeWorld(MaxWidth, MaxHeight);

            // return to the start of the file
            Reader.BaseStream.Seek(0, SeekOrigin.Begin);

            int y = 0;

            // read cell data
            while (!Reader.EndOfStream)
            {
                string CurrentLine = Reader.ReadLine();

                // ignore empty lines
                if (string.IsNullOrWhiteSpace(CurrentLine)) continue;

                // ignore comments
                if (CurrentLine[0] == ApplicationOptions.File.CommentSymbol) continue;

                // parse properties

                if (CurrentLine[0] == '[')
                {
                    // parse border mode
                    string BorderMode;
                    if (ParseProperty(CurrentLine, "Border Mode", out BorderMode))
                    {
                        Enum.TryParse(BorderMode, out UserOptions.General.BorderMode);
                    }

                    continue;
                }

                for (int x = 0; x < CurrentLine.Length; x++)
                {
                    if (CurrentLine[x] == ApplicationOptions.File.LiveSymbol) Cells[x, y].Value = true;
                    else if (CurrentLine[x] == ApplicationOptions.File.DeadSymbol) Cells[x, y].Value = false;
                }

                y++;
            }

            // Close the file.
            Reader.Close();

            OnWorldLoad();
        }

        bool ParseProperty(string Text, string PropertyName, out string PropertyValue)
        {
            PropertyValue = null;

            if (Text[0] == '[')
            {
                if (Text.StartsWith("[" + PropertyName))
                {
                    PropertyValue = Text.Replace("[", "").Replace(PropertyName, "").Replace("\t", "").Replace("]", "").Trim();
                    return true;
                }
            }

            return false;
        }

        #endregion

        #region Rules

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
                        if (Cells[x, y].Neighbors < UserOptions.Rules.NeighborLiveMin || Cells[x, y].Neighbors > UserOptions.Rules.NeighborLiveMax)
                        {
                            Queue.Add((x, y, false));
                        }
                    }
                    // // if cell is dead
                    else
                    {
                        if (Cells[x, y].Neighbors == UserOptions.Rules.CellBirthThreshold)
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

            switch (UserOptions.General.BorderMode)
            {
                case EBorderMode.Clip:
                    Count = CountNeighborsClip(X, Y, UserOptions.Rules.NeighborRadius);
                    break;
                case EBorderMode.Wrap:
                    Count = CountNeighborsWrap(X, Y, UserOptions.Rules.NeighborRadius);
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

        #endregion

        #region Generation

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

        #endregion

        #region Shared Actions

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

        private void ShowOptionsForm()
        {
            // create options form
            OptionsForm Dialog = new OptionsForm(this);

            // save current state
            FUserOptions SavedOptions = UserOptions;
            FCell[,] SavedCells = CopyCells(Cells);

            if (Dialog.ShowDialog() == DialogResult.OK)
            {
                // save options
                UpdateOptions(Dialog.UserOptions);
            }
            else
            {
                UserOptions = SavedOptions;
                Cells = CopyCells(SavedCells);
            }

            // load world cosmetic
            OnWorldLoadCosmetic();

            // repaint form
            graphicsPanel.Invalidate();
        }

        private void ShowNewProjectForm()
        {
            if (bIsPlay) Pause();

            // create options form
            NewProjectForm Dialog = new NewProjectForm();

            if (Dialog.ShowDialog() == DialogResult.OK)
            {
                switch (Dialog.ProjectType)
                {
                    case EProjectType.Blank:
                        {
                            OnWorldInit();
                            OnWorldLoad();
                            Clear();
                            Reset();

                            break;
                        }
                    case EProjectType.Random:
                        {
                            Random RandomGenerator = new Random();

                            int Scale = (RandomGenerator.Next() % 100) + 1;
                            UserOptions.General.Scale = new Point(Scale * 2, Scale);
                            UserOptions.General.BorderMode = (EBorderMode)(int)Math.Round(RandomGenerator.NextDouble());
                            UserOptions.Generation.RandomMode = ERandomMode.Time;
                            UserOptions.Generation.RandomThreshold = (float)RandomGenerator.NextDouble() * 10.0f;
                            UserOptions.Generation.RandomMultiplier = (float)(RandomGenerator.NextDouble() * 10.0f) / 2 + UserOptions.Generation.RandomThreshold;

                            OnWorldInit();

                            Randomize(UserOptions.Generation.RandomMode, UserOptions.Generation.RandomThreshold, UserOptions.Generation.RandomMultiplier);

                            OnWorldLoad();
                            ApplyRules();

                            break;
                        }
                    case EProjectType.Lexicon:
                        {
                            LexiconSearchForm SearchDialog = new LexiconSearchForm();

                            if (SearchDialog.ShowDialog() == DialogResult.OK)
                            {
                                FCell[,] Pattern;

                                if (GetPatternFromLexicon(SearchDialog.SearchValue, out Pattern))
                                {
                                    OnWorldInit();
                                    OnWorldLoad();
                                    Clear();

                                    UserOptions.General.Scale = new Point(Pattern.GetLength(0), Pattern.GetLength(1));
                                    UserOptions.General.BorderMode = EBorderMode.Clip;
                                    UserOptions.Generation.RandomMode = ERandomMode.Time;

                                    ResizeWorld(UserOptions.General.Scale.X, UserOptions.General.Scale.Y);
                                    Cells = CopyCells(Pattern);
                                    OnWorldLoad();
                                }
                            }

                            break;
                        }
                }
            }

            // repaint form
            graphicsPanel.Invalidate();
        }
        private bool GetPatternFromLexicon(string PatternName, out FCell[,] OutPattern)
        {
            OutPattern = new FCell[0, 0];

            List<string> Queue = new List<string>();

            StreamReader Reader = new StreamReader("Lexicon.txt");

            // calculate world size from file
            while (!Reader.EndOfStream)
            {
                // read the next line
                string CurrentLine = Reader.ReadLine();

                // ignore empty lines
                if (string.IsNullOrWhiteSpace(CurrentLine)) continue;

                if (CurrentLine[0] == ':')
                {
                    if (CurrentLine.Contains(':' + PatternName + ':'))
                    {
                        do
                        {
                            CurrentLine = Reader.ReadLine();

                            // ignore empty lines
                            if (string.IsNullOrWhiteSpace(CurrentLine)) continue;

                            // return if we reach the next pattern
                            if (CurrentLine[0] == ':')
                            {
                                if (Queue.Count <= 0)
                                {
                                    MessageBox.Show("Pattern missing definition");

                                    return false;
                                }
                                else
                                {
                                    break;
                                }
                            }

                            // search for indent
                            if (CurrentLine[0] == '\t')
                            {
                                Queue.Add(CurrentLine.Trim());
                            }
                        }
                        while (!Reader.EndOfStream);

                        if (Queue.Count > 0 && !Queue.Contains(null) && !Queue.Contains(string.Empty))
                        {
                            // Close the file.
                            Reader.Close();

                            int MaxWidth = 0;
                            int MaxHeight = Queue.Count;

                            for (int x = 0; x < Queue.Count; x++)
                            {
                                if (Queue[x].Length > MaxWidth) MaxWidth = Queue[x].Length;
                            }

                            OutPattern = new FCell[MaxWidth, MaxHeight];

                            for (int y = 0; y < Queue.Count; y++)
                            {
                                for (int x = 0; x < Queue[y].Length; x++)
                                {
                                    if (Queue[y][x] == ApplicationOptions.File.LiveSymbol) OutPattern[x, y].Value = true;
                                    else if (Queue[y][x] == ApplicationOptions.File.DeadSymbol) OutPattern[x, y].Value = false;
                                }
                            }

                            return true;
                        }
                    }
                }
                else
                {
                    continue;
                }
            }

            MessageBox.Show("Pattern not found");

            return false;
        }

        private void Clear()
        {
            if (bIsPlay) Pause();

            // reset live
            Live = 0;

            // iterate through cells
            for (int x = 0; x < Cells.GetLength(0); x++)
            {
                for (int y = 0; y < Cells.GetLength(1); y++)
                {
                    Cells[x, y].Value = false;
                    Cells[x, y].Neighbors = 0;
                }
            }

            OnWorldLoad();
        }

        private void Fill()
        {
            if (bIsPlay) Pause();

            // reset live
            Live = 0;

            // iterate through cells
            for (int x = 0; x < Cells.GetLength(0); x++)
            {
                for (int y = 0; y < Cells.GetLength(1); y++)
                {
                    Cells[x, y].Value = true;
                    Cells[x, y].Neighbors = 0;
                    Live++;
                }
            }

            OnWorldLoad();
        }

        #endregion

        #region Controls

        #region Graphics Panel

        private void graphicsPanel_Paint(object sender, PaintEventArgs e)
        {
            float PanelWidth = (float)graphicsPanel.ClientSize.Width;
            float PanelHeight = (float)graphicsPanel.ClientSize.Height;

            // calculate cell size
            float CellWidth = PanelWidth / (float)Cells.GetLength(0);
            float CellHeight = PanelHeight / (float)Cells.GetLength(1);

            // create brush for cell fill
            Brush CellBrush = new SolidBrush(UserOptions.Display.CellColor);

            // create pen for grid lines
            Pen GridPen = new Pen(UserOptions.Display.GridColor, 1);

            // create pen for helpers
            Pen HelperPenRectangle = new Pen(Color.FromArgb(128, 128, 128), 2);
            Pen HelperPenLines = new Pen(Color.FromArgb(96, 96, 96), 2);

            // create brush for neighbor count text
            Brush TextBrush = new SolidBrush(UserOptions.Display.GridColor);

            // neighbor count font setup
            float FontSizeMultiplier = 0.05f;
            float FontSize = Math.Min(CellWidth, CellHeight) * (ApplicationOptions.Text.NeighborCountSizeMultiplier * FontSizeMultiplier);
            Font Font = new Font(ApplicationOptions.Text.NeighborCountFontName, FontSize);
            StringFormat StringFormat = new StringFormat();
            StringFormat.Alignment = StringAlignment.Center;
            StringFormat.LineAlignment = StringAlignment.Center;

            bool bShowNeighbors = UserOptions.Display.bShowNeighborCount && FontSize == Math.Max(ApplicationOptions.Text.NeighborCountSizeMin, FontSize);

            // iterate through cells
            for (int x = 0; x < Cells.GetLength(0); x++)
            {
                for (int y = 0; y < Cells.GetLength(1); y++)
                {
                    Cells[x, y].Neighbors = CountNeighbors(x, y);

                    // create cell rectangle
                    RectangleF CellRect = RectangleF.Empty;
                    CellRect.X = x * CellWidth;
                    CellRect.Y = y * CellHeight;
                    CellRect.Width = CellWidth;
                    CellRect.Height = CellHeight;

                    // draw cell fill
                    if (Cells[x, y].Value == true)
                    {
                        e.Graphics.FillRectangle(CellBrush, CellRect);
                    }

                    // draw cell lines
                    if (UserOptions.Display.bShowGrid)
                    {
                        e.Graphics.DrawRectangle(GridPen, CellRect.X, CellRect.Y, CellRect.Width, CellRect.Height);
                    }

                    if (bShowNeighbors)
                    {
                        // only allow neighbor count to be shown if greater than 0 or cell is alive
                        if (Cells[x, y].Neighbors > 0 || Cells[x, y].Value)
                        {
                            // create rectangle
                            RectangleF Rect = new RectangleF(CellRect.X, CellRect.Y, CellRect.Width, CellRect.Height);

                            // draw neighbor count in rectangle
                            e.Graphics.DrawString(Cells[x, y].Neighbors.ToString(), Font, TextBrush, Rect, StringFormat);
                        }
                    }
                }
            }

            if (bShowHelpers)
            {
                float CrosshairRadius = 10.0f;
                e.Graphics.DrawRectangle(HelperPenRectangle, ((PanelWidth / 2) - (CrosshairRadius / 2)), ((PanelHeight / 2) - (CrosshairRadius / 2)), CrosshairRadius, CrosshairRadius);
                e.Graphics.DrawLine(HelperPenLines, new PointF((PanelWidth / 2), 1), new PointF((PanelWidth / 2), PanelHeight));
                e.Graphics.DrawLine(HelperPenLines, new PointF(0, (PanelHeight / 2)), new PointF(PanelWidth, (PanelHeight / 2)));
            }

            // clean up pens and brushes
            GridPen.Dispose();
            CellBrush.Dispose();
            HelperPenLines.Dispose();
            HelperPenRectangle.Dispose();
            TextBrush.Dispose();
        }

        private void graphicsPanel_MouseClick(object sender, MouseEventArgs e)
        {
            // check for LMB input
            if (e.Button == MouseButtons.Left)
            {
                float PanelWidth = (float)graphicsPanel.ClientSize.Width;
                float PanelHeight = (float)graphicsPanel.ClientSize.Height;

                // calculate cell size
                float CellWidth = PanelWidth / (float)Cells.GetLength(0);
                float CellHeight = PanelHeight / (float)Cells.GetLength(1);

                // calculate the cell that was clicked in
                int x = (int)(e.X / CellWidth);
                int y = (int)(e.Y / CellHeight);

                // toggle the value of the cell
                Cells[x, y].Value = !Cells[x, y].Value;

                if (Cells[x, y].Value) Live++;
                else Live--;

                OnWorldTick();
            }
        }

        #endregion

        #region Menu Strip

        private void menuStripNewMenuItem_Click(object sender, EventArgs e)
        {
            ShowNewProjectForm();
        }

        private void menuStripOpenMenuItem_Click(object sender, EventArgs e)
        {
            Open();
        }

        private void menuStripSaveMenuItem_Click(object sender, EventArgs e)
        {
            Save();
        }

        private void menuStripSaveAsMenuItem_Click(object sender, EventArgs e)
        {
            SaveAs();
        }

        private void menuStripImportMenuItem_Click(object sender, EventArgs e)
        {
            Import();
        }

        private void menuStripQuitMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void menuStripOptionsMenuItem_Click(object sender, EventArgs e)
        {
            ShowOptionsForm();
        }

        private void menuStripClearMenuItem_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void menuStripFillMenuItem_Click(object sender, EventArgs e)
        {
            Fill();
        }

        private void menuStripViewMenu_DropDownOpened(object sender, EventArgs e)
        {
            // update checkboxes
            menuStripShowHudMenuItem.Checked = UserOptions.Display.bShowHUD;
            menuStripShowNeighborCountMenuItem.Checked = UserOptions.Display.bShowNeighborCount;
            menuStripShowGridMenuItem.Checked = UserOptions.Display.bShowGrid;
            menuStripShowHelpersMenuItem.Checked = bShowHelpers;
        }

        private void menuStripShowHudMenuItem_Click(object sender, EventArgs e)
        {
            // toggle checkbox
            menuStripShowHudMenuItem.Checked = !menuStripShowHudMenuItem.Checked;

            // update options
            UserOptions.Display.bShowHUD = menuStripShowHudMenuItem.Checked;

            // call cosmetic load event
            OnWorldLoadCosmetic();

            // repaint form
            graphicsPanel.Invalidate();
        }

        private void menuStripShowNeighborCountMenuItem_Click(object sender, EventArgs e)
        {
            // toggle checkbox
            menuStripShowNeighborCountMenuItem.Checked = !menuStripShowNeighborCountMenuItem.Checked;

            // update options
            UserOptions.Display.bShowNeighborCount = menuStripShowNeighborCountMenuItem.Checked;

            // repaint form
            graphicsPanel.Invalidate();
        }

        private void menuStripShowGridMenuItem_Click(object sender, EventArgs e)
        {
            // toggle checkbox
            menuStripShowGridMenuItem.Checked = !menuStripShowGridMenuItem.Checked;

            // update options
            UserOptions.Display.bShowGrid = menuStripShowGridMenuItem.Checked;

            // repaint form
            graphicsPanel.Invalidate();
        }

        private void menuStripShowHelpersMenuItem_Click(object sender, EventArgs e)
        {
            // toggle checkbox
            menuStripShowHelpersMenuItem.Checked = !menuStripShowHelpersMenuItem.Checked;

            // toggle show helpers
            bShowHelpers = !bShowHelpers;

            // repaint form
            graphicsPanel.Invalidate();
        }

        private void menuStripAboutMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("https://en.wikipedia.org/wiki/Conway%27s_Game_of_Life");
        }

        #endregion

        #region Tool Strip

        private void toolStripOptionsButton_Click(object sender, EventArgs e)
        {
            ShowOptionsForm();
        }

        private void toolStripNewButton_Click(object sender, EventArgs e)
        {
            ShowNewProjectForm();
        }

        private void toolStripSaveButton_Click(object sender, EventArgs e)
        {
            Save();
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
            contextMenuShowHudMenuItem.Checked = UserOptions.Display.bShowHUD;
            contextMenuShowNeighborCountMenuItem.Checked = UserOptions.Display.bShowNeighborCount;
            contextMenuShowGridMenuItem.Checked = UserOptions.Display.bShowGrid;
            contextMenuShowHelpersMenuItem.Checked = bShowHelpers;
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
            ShowOptionsForm();
        }

        private void contextMenuClearMenuItem_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void contextMenuFillMenuItem_Click(object sender, EventArgs e)
        {
            Fill();
        }

        private void contextMenuShowHudMenuItem_Click(object sender, EventArgs e)
        {
            // toggle checkbox
            contextMenuShowHudMenuItem.Checked = !contextMenuShowHudMenuItem.Checked;

            // update options
            UserOptions.Display.bShowHUD = contextMenuShowHudMenuItem.Checked;

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
            UserOptions.Display.bShowNeighborCount = contextMenuShowNeighborCountMenuItem.Checked;

            // repaint form
            graphicsPanel.Invalidate();
        }

        private void contextMenuShowGridMenuItem_Click(object sender, EventArgs e)
        {
            // toggle checkbox
            contextMenuShowGridMenuItem.Checked = !contextMenuShowGridMenuItem.Checked;

            // update options
            UserOptions.Display.bShowGrid = contextMenuShowGridMenuItem.Checked;

            // repaint form
            graphicsPanel.Invalidate();
        }

        private void contextMenuShowHelpersMenuItem_Click(object sender, EventArgs e)
        {
            // toggle checkbox
            contextMenuShowHelpersMenuItem.Checked = !contextMenuShowHelpersMenuItem.Checked;

            // toggle show helpers
            bShowHelpers = !bShowHelpers;

            // repaint form
            graphicsPanel.Invalidate();
        }

        #endregion

        #endregion
    }
}
