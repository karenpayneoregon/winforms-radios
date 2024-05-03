using System.Data;
using System.Windows.Forms;

namespace DataGridViewCheckBoxHelpers
{
    public static class BindingSourceExtensions
    {
        public static DataTable DataTable(this BindingSource pBindingSource)
        {
            return (DataTable)pBindingSource.DataSource;
        }
    }
}
