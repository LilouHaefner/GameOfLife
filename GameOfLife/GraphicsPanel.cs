using System.Windows.Forms;

namespace GameOfLife
{
    class GraphicsPanel : Panel
    {
        public GraphicsPanel()
        {
            // enable double buffering
            this.DoubleBuffered = true;

            // force repaint on window resize
            this.SetStyle(ControlStyles.ResizeRedraw, true);
        }
    }
}
