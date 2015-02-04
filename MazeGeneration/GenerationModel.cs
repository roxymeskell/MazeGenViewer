using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;
using System.Threading;

namespace MazeGeneration
{
    /// <summary>
    /// Obseravable model of the current maze as it is generated.
    /// </summary>
    class GenerationModel : IObservable<Cell[,]>
    {
        public static int[] nums = new int[] { 1, 2, 3, 4, 5 };

        private static readonly Type[] algorithmList = Assembly.GetExecutingAssembly().GetTypes()
                                                    .Where(type => type.BaseType == typeof(MazeAlgorithm) && !type.IsAbstract).ToArray();
        private static readonly Type[] paramTypes = new Type[0];
        private static readonly object[] paramObjects = new object[0];

        private List<IObserver<Cell[,]>> observers;
        private readonly List<MazeAlgorithm> algorithm;
        private readonly List<String> algorithmName;

        private Cell[,] grid;
        private bool generateToggle;
        private int gridWidth, gridHeight;
        private int interval;
        private int currAlgorithm;

        public Cell[,] Grid
        {
            get { return grid; }
        }
        public bool Toggle
        {
            get { return generateToggle; }
        }
        public int GridWidth
        {
            get { return gridWidth; }
        }
        public int GridHeight
        {
            get { return gridHeight; }
        }
        public int Interval
        {
            get { return interval; }
            set { interval = value; }
        }
        public String DefaultAlgorithm
        {
            get { return algorithmName.FirstOrDefault(); }
        }

        public GenerationModel()
        {
            observers = new List<IObserver<Cell[,]>>();

            interval = 1;
            currAlgorithm = 0;

            algorithm = new List<MazeAlgorithm>();
            algorithmName = new List<String>();
            for (int _i = 0; _i < algorithmList.Length; _i++)
            {
                algorithm.Add((MazeAlgorithm)algorithmList[_i].GetConstructor(paramTypes).Invoke(paramObjects));
                algorithmName.Add(algorithm.ElementAt(_i).GetName());
            }

            gridWidth = 10;
            gridHeight = 10;
            CreateGrid();
            algorithm[currAlgorithm].Setup(grid);
        }

        public GenerationModel(IObserver<Cell[,]> _subscriber)
        {
            observers = new List<IObserver<Cell[,]>>();
            Subscribe(_subscriber);

            gridWidth = 10;
            gridHeight = 10;
            CreateGrid();

            interval = 1;
            currAlgorithm = 0;

            algorithm = new List<MazeAlgorithm>();
            algorithmName = new List<String>();
            for (int _i = 0; _i < algorithmList.Length; _i++)
            {
                algorithm.Add((MazeAlgorithm)algorithmList[_i].GetConstructor(paramTypes).Invoke(paramObjects));
                algorithmName.Add(algorithm.ElementAt(_i).GetName());
            }

            gridWidth = 10;
            gridHeight = 10;
            CreateGrid();
            algorithm[currAlgorithm].Setup(grid);
        }

        public void setGridWidth(int _width)
        {
            generateToggle = false;
            gridWidth = _width;
            CreateGrid();
            algorithm[currAlgorithm].Setup(grid);
            UpdateObservers();
        }

        public void setGridHeight(int _height)
        {
            generateToggle = false;
            gridHeight = _height;
            CreateGrid();
            algorithm[currAlgorithm].Setup(grid);
            UpdateObservers();
        }

        public void SetAlgorithm(String _name)
        {
            currAlgorithm = algorithmName.FindIndex(name => name.Equals(_name));

            CreateGrid();

            generateToggle = false;
            try
            {
                algorithm.ElementAt(currAlgorithm).Setup(grid);
            }
            catch (Exception e)
            {
                Console.WriteLine("Not implemented");
            }

            UpdateObservers();
        }

        public void ToggleGeneration()
        {
            generateToggle = !generateToggle;

            if (generateToggle)
            {
                Thread generationThread = new Thread(new ThreadStart(GenerateCells));
                generationThread.Start();
            }
        }

        private void GenerateCells()
        {
            while (generateToggle) 
            {
                generateToggle &= algorithm[currAlgorithm].NextCell();
                UpdateObservers();
                Thread.Sleep(interval * 100);
            }
        }

        private void CreateGrid()
        {
            grid = new Cell[gridWidth, gridHeight];
            for (int x = 0; x < gridWidth; x++)
            {
                for (int y = 0; y < gridHeight; y++)
                {
                    grid[x, y] = new Cell(x, y);
                }
            }
        }

        public IEnumerable<String> GetAlgorithms()
        {
            return algorithmName;
        }

        public void FormClosed()
        {
            generateToggle = false;
        }

        public void UpdateObservers()
        {
            foreach (IObserver<Cell[,]> observer in observers)
            {
                observer.OnNext(grid);
            }
        }

        public IDisposable Subscribe(IObserver<Cell[,]> observer)
        {
            if (!observers.Contains(observer))
                observers.Add(observer);
            return new Unsubscriber(observers, observer);
        }

        private class Unsubscriber : IDisposable
        {
            private List<IObserver<Cell[,]>> _observers;
            private IObserver<Cell[,]> _observer;

            public Unsubscriber(List<IObserver<Cell[,]>> observers, IObserver<Cell[,]> observer)
            {
                this._observers = observers;
                this._observer = observer;
            }

            public void Dispose()
            {
                if (_observer != null && _observers.Contains(_observer))
                    _observers.Remove(_observer);
            }
        }
    }
}
