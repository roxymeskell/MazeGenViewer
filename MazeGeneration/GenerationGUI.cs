using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using System.Threading;

namespace MazeGeneration
{
    public partial class GenerationGUI : Form, IObserver<Cell[,]>
    {
        GenerationModel model;

        delegate void OnNextCallback(Cell[,] value);

        private static readonly Brush uncreatedCellBrush = Brushes.Gray;
        private static readonly Brush createdCellBrush = Brushes.White;
        private static readonly Brush textBrush = Brushes.Black;
        private static readonly Pen uncreatedCellPen = Pens.Gray;
        private static readonly Pen createdCellPen = Pens.White;
        private static readonly Pen wallPen = new Pen(Color.Black, 2f);

        public GenerationGUI()
        {
            InitializeComponent();

            model = new GenerationModel(this);
            foreach (String _name in this.model.GetAlgorithms())
            {
                this.TypeSelect.Items.Add(_name);
            }
            this.TypeSelect.SelectedIndex = 0;
            this.WidthSelection.Value = model.GridWidth;
            this.HeightSelection.Value = model.GridHeight;
            this.IntervalSelect.Value = model.Interval;

            this.SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
        }

        public void OnNext(Cell[,] value)
        {
            if (this.InvokeRequired)
            {
                OnNextCallback refresh = new OnNextCallback(OnNext);
                try
                {
                    this.Invoke(refresh, new object[] { value });
                }
                catch (ObjectDisposedException e)
                {
                    model.FormClosed();
                }
            }
            else
            {
                this.GridCanvas.Refresh();
                this.GenerateToggle.Text = model.Toggle ? "Stop" : "Start";
            }
        }

        public void OnCompleted()
        {

        }

        public void OnError(Exception error)
        {

        }

        private void GUI_Load(object sender, EventArgs e)
        {

        }

        private void TypeChange(object sender, EventArgs e)
        {
            model.SetAlgorithm(this.TypeSelect.Text);
        }

        private void IntervalChange(object sender, EventArgs e)
        {
            model.Interval = this.IntervalSelect.Value;
        }

        private void WidthChange(object sender, EventArgs e)
        {
            model.setGridWidth((int)this.WidthSelection.Value);
        }

        private void HeightChange(object sender, EventArgs e)
        {
            model.setGridHeight((int)this.HeightSelection.Value);
            //Console.WriteLine(sender.ToString());
        }

        private void ToggleGenerate(object sender, EventArgs e)
        {
            model.ToggleGeneration();
            this.GenerateToggle.Text = model.Toggle ? "Stop" : "Start";
        }

        /// <summary>
        /// Paints the grid according to the maze model
        /// </summary>
        /// <param name="sender">Object that invoked the method ??</param>
        /// <param name="e">PaintEventArgs object</param>
        private void PaintGrid(object sender, PaintEventArgs e)
        {
            int widthOfCell = this.GridCanvas.Width / model.GridWidth;
            int heightOfCell = this.GridCanvas.Height / model.GridHeight;

            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

            //Console.WriteLine(e.Graphics.VisibleClipBounds.ToString());

            for (int x = 0; x < model.GridWidth; x++)
            {
                for (int y = 0; y < model.GridHeight; y++)
                {
                    int xMin = (x * widthOfCell), yMin = (y * heightOfCell),
                        xMax = ((x + 1) * widthOfCell), yMax = ((y + 1) * heightOfCell);

                    //Fill cells
                    if (model.Grid[x, y].Created)
                    {
                        e.Graphics.FillRectangle(createdCellBrush, xMin, yMin, widthOfCell, heightOfCell);
                    }
                    else
                    {
                        e.Graphics.FillRectangle(uncreatedCellBrush, xMin, yMin, widthOfCell, heightOfCell);
                    }

                    //Draw walls
                    if (model.Grid[x, y].HasRightWall)
                    {
                        e.Graphics.DrawLine(wallPen, xMax, yMin, xMax, yMax);
                    }
                    if (model.Grid[x, y].HasLowerWall && !(x == model.GridWidth - 1 && y == model.GridHeight - 1))
                    {
                        e.Graphics.DrawLine(wallPen, xMin, yMax, xMax, yMax);
                    }

                    //Write values
                    e.Graphics.DrawString(model.Grid[x, y].Value, this.Font, textBrush, xMin, yMin);

                    //Draw outer walls
                    //If on outer left wall
                    if (x == 0)
                    {
                        e.Graphics.DrawLine(wallPen, xMin, yMin, xMin, yMax);
                    }
                    else
                    {
                        //If on outer top wall and not on outer left wall
                        if (y == 0)
                        {
                            e.Graphics.DrawLine(wallPen, xMin, yMin, xMax, yMin);
                        }
                    }
                    //If on outer right wall
                    if (x == model.GridWidth - 1)
                    {
                        e.Graphics.DrawLine(wallPen, xMax, yMin, xMax, yMax);
                    }
                    else
                    {
                        //If on outer lower wall and not on outer right wall
                        if (y == model.GridHeight - 1)
                        {
                            e.Graphics.DrawLine(wallPen, xMin, yMax, xMax, yMax);
                        }
                    }
                }
            }
           //end method
        }

        private void GUIClosing(object sender, FormClosingEventArgs e)
        {
            model.FormClosed();
        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
