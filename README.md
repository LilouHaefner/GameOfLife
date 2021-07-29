# Game of Life

##### A simple implementation of Conway's Game of Life in .NET

## Features

### Clear
`void()`

Clears all cells

### Fill
`void()`

Fills all cells

### Randomize
`void(ERandomMode RandomMode, float Threshold, float Multiplier, int Seed)`

Randomly fills cells at an approximate ratio of `Multiplier - Threshold` live to `Multiplier` total

### Lexicon Search
`bool(string PatternName, out FCell[,] OutPattern)`

Search `Lexicon.txt` for a `string` pattern and generate it, if possible.

## Options

### User
##### General
- `Point` Scale;
- `int` Interval;
- `EBorderMode` BorderMode;

##### Rules
- `int` NeighborRadius;
- `int` NeighborLiveMin;
- `int` NeighborLiveMax;
- `int` CellBirthThreshold;

##### Generation
- `ERandomMode` RandomMode;
- `int` RandomSeed;
- `float` RandomThreshold;
- `float` RandomMultiplier;

##### Display
- `bool` bShowHUD;
- `bool` bShowNeighborCount;
- `bool` bShowGrid;
- `Color` GridColor;
- `Color` CellColor;
- `Color` BackgroundColor;

### Application

##### Text
- `string` NeighborCountFontName;
- `float` NeighborCountSizeMultiplier;
- `float` NeighborCountSizeMin;

##### File
- `string` FileSuffix;
- `char` LiveSymbol;
- `char` DeadSymbol;
- `char` CommentSymbol;
