using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace TemperatureManagement.Utilities
{
    public class DataGridViewUtils
    {
        public static void ColumnAutoSizeMode(DataGridViewColumn column, DataGridView dtg)
        {
            if (dtg == null || column == null || dtg.Columns.Count == 0)
                return;

            try
            {
                var checkExist = dtg.Columns.Cast<DataGridViewColumn>().Where(r => r.Name.Equals(column.Name)).FirstOrDefault();
                if (checkExist == null)
                {
                    return;
                }

                dtg.Columns[column.Name].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
                dtg.Columns[column.Name].AutoSizeMode = column.AutoSizeMode;
                dtg.Columns[column.Name].Width = column.Width;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static IList<string> GetHeaderList(DataGridView gridView)
        {
            List<string> header = new List<string>();
            foreach (DataGridViewColumn hd in gridView.Columns)
            {
                header.Add(Regex.Replace(hd.HeaderText, @"\t|\n|\r", ""));
            }

            return header;
        }
    }
}
