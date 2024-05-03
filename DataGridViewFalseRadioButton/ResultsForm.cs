using System.Collections.Generic;
using System.Windows.Forms;
using DataGridViewCheckBoxHelpers;

namespace DataGridViewFalseRadioButton
{
    public partial class ResultsForm : Form
    {
        public ResultsForm()
        {
            InitializeComponent();
        }
        public ResultsForm(List<SelectedRadioButton> pList)
        {
            InitializeComponent();
            foreach (var item in pList)
            {
                dataGridView1.Rows.Add(item.id, item.CompanyName, item.Rating.ToString());
            }
        }
    }
}
