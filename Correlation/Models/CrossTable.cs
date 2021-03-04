using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Correlation.Models {
    public class CrossTable<T> {
        private List<List<T>> _rows;

        public CrossTable() {
            _rows = new List<List<T>>();
            RowHeaders = new List<string>();
            ColumnHeaders = new List<string>();
        }

        public T this[int i, int j] {
            get {
                return _rows[i][j];
            }
            set {
                _rows[i][j] = value;
            }
        }

        public List<string> RowHeaders { get; set; }
        public List<string> ColumnHeaders { get; set; }

        public int Width { get => ColumnHeaders.Count; }
        public int Height { get => RowHeaders.Count; }

        public int Total { get; set; }
        public int Round { get => Total.ToString().Length - 1; }

        public void Initialize() {
            RowHeaders = RowHeaders.Distinct().ToList();
            ColumnHeaders = ColumnHeaders.Distinct().ToList();
            for (int i = 0; i < Height; i++) {
                _rows.Add(new List<T>());
                for (int j = 0; j < Width; j++) {
                    _rows[i].Add(default);
                }
            }
        }

        public IEnumerator<T> GetEnumerator() {
            for (int i = 0; i < Height; i++) {
                for (int j = 0; j < Width; j++) {
                    yield return this[i, j];
                }
            }
        }
    }
}
