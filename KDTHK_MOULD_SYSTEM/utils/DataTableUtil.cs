using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Collections;

namespace KDTHK_MOULD_SYSTEM.utils
{
    public class DataTableUtil
    {
        
    }

    public class DataTableReplacement : IEnumerable<IEnumerable<object>>
    {
        private readonly DtrColumnCollection _columns;
        private readonly DtrRowCollection _rows;

        public DataTableReplacement()
        {
            _columns = new DtrColumnCollection();
            _rows = new DtrRowCollection();
        }

        public DtrColumnCollection Columns
        {
            get { return _columns; }
        }

        public DtrRowCollection Rows { get { return _rows; } }

        public DtrRow NewRow()
        {
            return new DtrRow(this);
        }

        public DataTable ToDataTable()
        {
            var dt = new DataTable();
            dt.BeginLoadData();
            _columns.CreateColumns(dt);
            _rows.CreateRows(dt);
            dt.EndLoadData();
            return dt;
        }

        public IEnumerator<IEnumerable<object>> GetEnumerator()
        {
            foreach (var row in _rows)
                yield return row.ToArray();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }

    public class DtrRowCollection : IEnumerable<DtrRow>
    {
        private readonly List<DtrRow> _rows;

        public DtrRowCollection()
        {
            _rows = new List<DtrRow>();
        }

        public void Add(DtrRow newRow)
        {
            _rows.Add(newRow);
        }

        public DtrRow this[int i]
        {
            get { return _rows[i]; }
        }

        public void CreateRows(DataTable dt)
        {
            foreach (var dtrRow in _rows)
                dt.Rows.Add(dtrRow.ToArray());
        }

        public IEnumerator<DtrRow> GetEnumerator()
        {
            return _rows.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }

    public class DtrRow
    {
        private readonly object[] _arr;
        private readonly DataTableReplacement _dtr;

        public DtrRow(DataTableReplacement dtr)
        {
            _dtr = dtr;
            var columnCount = _dtr.Columns.Count;
            _arr = new object[columnCount];
        }

        public object this[string columnName]
        {
            get
            {
                var index = _dtr.Columns.GetIndex(columnName);
                return _arr[index];
            }
            set
            {
                var index = _dtr.Columns.GetIndex(columnName);
                _arr[index] = value;
            }
        }

        public object this[int columnIndex]
        {
            get
            {
                return _arr[columnIndex];
            }
            set
            {
                _arr[columnIndex] = value;
            }
        }

        public object[] ToArray()
        {
            return _arr;
        }
    }

    public class DtrColumnCollection
    {
        private readonly Dictionary<string, int> _columnIndexes;
        private readonly Dictionary<string, Type> _columnTypes;

        public DtrColumnCollection()
        {
            _columnIndexes = new Dictionary<string, int>();
            _columnTypes = new Dictionary<string, Type>();
        }

        public int Count { get { return _columnIndexes.Count; } }

        public void Add(string columnName, Type columnType)
        {
            var index = _columnIndexes.Count;
            _columnIndexes.Add(columnName, index);
            _columnTypes.Add(columnName, columnType);
        }

        public int GetIndex(string columnName)
        {
            return _columnIndexes[columnName];
        }

        public void CreateColumns(DataTable dt)
        {
            foreach (var pair in _columnTypes)
                dt.Columns.Add(pair.Key, pair.Value);
        }
    }
}
