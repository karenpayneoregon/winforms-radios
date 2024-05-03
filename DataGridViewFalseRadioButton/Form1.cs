using System;
using System.Linq;
using System.Windows.Forms;
using DataGridViewCheckBoxHelpers;
using MockedDataLibrary;

namespace DataGridViewFalseRadioButton
{
    public partial class Form1 : Form
    {
        private readonly BindingSource _bsCustomers = new BindingSource();

        public Form1()
        {
            InitializeComponent();

            Shown += Form1_Shown;
            dataGridView1.CellClick += DataGridView1_CellClick;
        }
        /// <summary>
        /// Handles changing image for select/un-select
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (!(dataGridView1.CurrentCell is DataGridViewImageCell)) return;

            if ((int)dataGridView1.CurrentCell.Tag == (int)ImageSelection.Selected)
            {
                dataGridView1.CurrentCell.Value = Properties.Resources.RadioButtonUnselected;
                dataGridView1.CurrentCell.Tag = ImageSelection.Unselected;
            }
            else if ((int)dataGridView1.CurrentCell.Tag == (int)ImageSelection.Unselected)
            {
                if (dataGridView1.CurrentRow != null)
                {
                    var imageCells = dataGridView1.CurrentRow.Cells.OfType<DataGridViewImageCell>()
                        .Select(col => col);

                    foreach (var item in imageCells)
                    {
                        item.Value = Properties.Resources.RadioButtonUnselected;
                        item.Tag = ImageSelection.Unselected;

                    }
                }

                dataGridView1.CurrentCell.Tag = ImageSelection.Selected;
                dataGridView1.CurrentCell.Value = Properties.Resources.RadioButtonSelected;

                if (!string.IsNullOrWhiteSpace(dataGridView1.CurrentRow.ErrorText))
                {
                    dataGridView1.CurrentRow.ErrorText = "";
                }
            }
        }
        /// <summary>
        /// Setup DataGridView with mock data.
        /// Initialize DataGridViewImageColumns to unselected
        /// Demo manual setting of a selection
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_Shown(object sender, EventArgs e)
        {
            var ops = new MockData();

            _bsCustomers.DataSource = ops.Table;

            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.DataSource = _bsCustomers;
            dataGridView1.Columns.OfType<DataGridViewImageColumn>().Select(col => col)
                .ToList()
                .ForEach(col => col.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
            );

            for (var rowIndex = 0; rowIndex < dataGridView1.Rows.Count; rowIndex++)
            {
                dataGridView1.UnSelect(rowIndex);
            }


            dataGridView1.Columns["CompanyNameColumn"].SortMode = DataGridViewColumnSortMode.NotSortable;

            /*
                * Selection row 0 selection three time, this shows the language extension functions as expected.
                * (Each DataGridView column were created in the designer)
                */
            dataGridView1.SetSelection(0, "Option1Column");
            dataGridView1.SetSelection(0, "Option3Column");
            dataGridView1.SetSelection(0, "Option2Column");

        }
        /// <summary>
        /// Get all selected rows, if one or more have no selection 
        /// set their error text. If all rows have a selection show
        /// them in a child window.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmdGetSelection_Click(object sender, EventArgs e)
        {
            for (int indexer = 0; indexer < dataGridView1.Rows.Count; indexer++)
            {
                dataGridView1.Rows[indexer].ErrorText = "";
            }

            var selectedRadioButtonList = dataGridView1
                .GetSelections(_bsCustomers, "CustomerIdentifier","CompanyName");

            if (selectedRadioButtonList.Count != _bsCustomers.Count)
            {

                var notSelectedIndices = dataGridView1.GetNoneSelections(_bsCustomers);
                for (int indexer = 0; indexer < notSelectedIndices.Count; indexer++)
                {
                    dataGridView1.Rows[notSelectedIndices[indexer]].ErrorText = "Must provide a rating";
                }

                MessageBox.Show("Please provide a rating for each company.");
                return;
            }

            if (selectedRadioButtonList.Count > 0)
            {

                var f = new ResultsForm(selectedRadioButtonList);

                try
                {
                    f.ShowDialog();
                }
                finally
                {
                    f.Dispose();
                }
            }           
        }
        /// <summary>
        /// Reset to fresh, no selections
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmdReset_Click(object sender, EventArgs e)
        {

            for (var rowIndex = 0; rowIndex < dataGridView1.Rows.Count; rowIndex++)
            {
                dataGridView1.UnSelect(rowIndex);
                dataGridView1.Rows[rowIndex].ErrorText = "";
            }

        }
    }
}
