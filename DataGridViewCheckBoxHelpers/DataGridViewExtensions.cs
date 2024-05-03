using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace DataGridViewCheckBoxHelpers
{
    public static class DataGridViewExtensions
    {
        /// <summary>
        /// Retrieves all rows in the DataGridView with a radio selection
        /// </summary>
        /// <param name="pDataGridView"></param>
        /// <param name="pBindingSource"></param>
        /// <param name="pIdentifierColumnName">Primary key</param>
        /// <param name="pFieldName">Field name displayed</param>
        /// <returns></returns>
        public static List<SelectedRadioButton> GetSelections(this DataGridView pDataGridView, BindingSource pBindingSource, string pIdentifierColumnName, string pFieldName)
        {
            var selectedRadioButtonList = new List<SelectedRadioButton>();
            DataGridViewColumn col;

            foreach (DataGridViewRow row in pDataGridView.Rows)
            {
                var imageCell = row.Cells.OfType<DataGridViewImageCell>().FirstOrDefault(data => (int)data.Tag == (int)ImageSelection.Selected);

                if (imageCell == null) continue;
                col = pDataGridView.CurrentRow.Cells[imageCell.ColumnIndex].OwningColumn;

                selectedRadioButtonList.Add(new SelectedRadioButton()
                {
                    RowIndex = imageCell.RowIndex,
                    ColumnName = col.Name,
                    ColumnIndex = col.Index,
                    Rating = col.Index.ToEnum<Ratings>(),
                    id = pBindingSource.DataTable().Rows[imageCell.RowIndex].Field<int>(pIdentifierColumnName),
                    CompanyName = pBindingSource.DataTable().Rows[imageCell.RowIndex].Field<string>(pFieldName)
                });
            }

            return selectedRadioButtonList;

        }
        /// <summary>
        /// Returns a list of DataGridView row indices that don't have a radio selection
        /// </summary>
        /// <param name="pDataGridView"></param>
        /// <param name="pBindingSource"></param>
        /// <returns></returns>
        public static List<int> GetNoneSelections(this DataGridView pDataGridView, BindingSource pBindingSource)
        {
            var rowsIndices = new List<int>();

            foreach (DataGridViewRow row in pDataGridView.Rows)
            {
                if (!row.Cells.OfType<DataGridViewImageCell>().Any(data => (int)data.Tag == (int)ImageSelection.Selected))
                {
                    rowsIndices.Add(row.Index);
                }
            }

            return rowsIndices;

        }
    }
}
