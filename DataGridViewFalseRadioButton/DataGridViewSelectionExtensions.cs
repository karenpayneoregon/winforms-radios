using System.Data;
using DataGridViewCheckBoxHelpers;
using System.Linq;
using System.Windows.Forms;

namespace DataGridViewFalseRadioButton
{
    public static class DataGridViewSelectionExtensions
    {
        /// <summary>
        /// Unselect all DataGridViewImageCells. If pRow is out of range an exception is thrown.
        /// </summary>
        /// <param name="pDataGridView"></param>
        /// <param name="pRow">Row index to clear</param>
        public static void UnSelect(this DataGridView pDataGridView, int pRow)
        {
            pDataGridView.Rows[pRow].Cells.OfType<DataGridViewImageCell>().ToList().ForEach(col =>
                {
                    col.Tag = ImageSelection.Unselected;
                    col.Value = Properties.Resources.RadioButtonUnselected;
                }
            );
        }

        public static DataTable DataTable(this DataGridView pDataGridView)
        {

            return (DataTable) pDataGridView.DataSource;
        }

        /// <summary>
        /// Select option by row index, column name
        /// </summary>
        /// <param name="pDataGridView"></param>
        /// <param name="pRow">Row index in pDataGridView</param>
        /// <param name="pColumnName">Column name in pDataGridView</param>
        public static void SetSelection(this DataGridView pDataGridView, int pRow, string pColumnName)
        {
            if (!pDataGridView.Columns.Contains(pColumnName)) return;

            pDataGridView.UnSelect(pRow);

            pDataGridView.Rows[pRow].Cells[pColumnName].Tag = ImageSelection.Selected;
            pDataGridView.Rows[pRow].Cells[pColumnName].Value = Properties.Resources.RadioButtonSelected;

        }
        /// <summary>
        /// Select option by row index, column index
        /// </summary>
        /// <param name="pDataGridView"></param>
        /// <param name="pRow">Row index in pDataGridView</param>
        /// <param name="pColumnIndex">Column index in pDataGridView</param>
        public static void SetSelection(this DataGridView pDataGridView, int pRow, int pColumnIndex)
        {
            if (!pDataGridView.Columns.Contains(pDataGridView.Columns[pColumnIndex].Name)) return;


            pDataGridView.UnSelect(pRow);

            pDataGridView.Rows[pRow].Cells[pColumnIndex].Tag = ImageSelection.Selected;
            pDataGridView.Rows[pRow].Cells[pColumnIndex].Value = Properties.Resources.RadioButtonSelected;

        }

    }
}
