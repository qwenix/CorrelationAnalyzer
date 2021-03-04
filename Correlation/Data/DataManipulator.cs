using Microsoft.VisualBasic.FileIO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Correlation.Data {

    // Data must represents only as csv files. 

    public struct DataPaths {
        public const string MOVIES_DATA_PATH = "movies.csv";
        public const string ICECREAMS_DATA_PATH = "icecreams.csv";
    }

    public struct ImagePaths {
        public const string ELLIPS_IMAGE_PATH = "ellips.png";
    }

    public static class DataManipulator {

        /// <summary>
        /// Returns Data table that represents data in the file with certain parth. 
        /// </summary>
        public static DataTable GetDataTable(string path) {
            DataTable dataTable = new DataTable();

            using (var reader = new TextFieldParser(path)) {
                // Parsing parameters.
                reader.SetDelimiters(new string[] { "," });
                reader.HasFieldsEnclosedInQuotes = true;

                // Data columns.
                string[] columns = reader.ReadFields();
                foreach (string c in columns) {
                    var column = new DataColumn(c) {
                        AllowDBNull = true
                    };
                    dataTable.Columns.Add(column);
                }

                // Data rows.
                //while (!reader.EndOfData) {
                //    string[] data = reader.ReadFields();
                //    dataTable.Rows.Add(data);
                //}


                //Next code for tests.
                for (int i = 0; i < 1000; i++) {
                    string[] data = reader.ReadFields();
                    dataTable.Rows.Add(data);
                }
            }

            return dataTable;
        } 

        public static Bitmap GetImage(string path) {
            return new Bitmap(path);
        } 
    }
}
