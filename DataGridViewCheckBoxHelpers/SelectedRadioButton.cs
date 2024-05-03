namespace DataGridViewCheckBoxHelpers
{
    public class SelectedRadioButton
    {
        /// <summary>
        /// DataGridView Row index
        /// </summary>
        public int RowIndex { get; set; }
        /// <summary>
        /// Column name in DataGridView
        /// </summary>
        public string ColumnName { get; set; }
        /// <summary>
        /// Column index in DataGridView column collection
        /// </summary>
        public int ColumnIndex { get; set; }
        /// <summary>
        /// Rating for a row
        /// </summary>
        public Ratings Rating { get; set; }
        /// <summary>
        /// Primary key from data source
        /// </summary>
        public int id { get; set; }
        /// <summary>
        /// Company name we are rating
        /// </summary>
        public string CompanyName { get; set; }
        public override string ToString()
        {
            return CompanyName;
        }
    }
}
