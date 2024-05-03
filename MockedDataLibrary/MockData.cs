using System.Collections.Generic;
using System.Data;

namespace MockedDataLibrary
{
    /// <summary>
    /// Simple mockup of data that may come from a database table.
    /// </summary>
    public class MockData
    {
        private readonly DataTable _customerTable;
        public DataTable Table { get { return _customerTable; } }
        public MockData()
        {
            var companyNames = new List<string>()
            {
                "Alfreds Futterkiste",
                "Ana Trujillo Emparedados y helados",
                "Around the Horn",
                "Bólido Comidas preparadas",
                "Folies gourmandes",
                "Königlich Essen",
                "QUICK Stop",
                "Toms Spezialitäten"
            };
            _customerTable = new DataTable();

            _customerTable.Columns.Add(new DataColumn()
            {
                ColumnName = "CustomerIdentifier",
                DataType = typeof(int),
                AutoIncrement = true, AutoIncrementSeed = 1
            });

            _customerTable.Columns.Add(new DataColumn()
            {
                ColumnName = "CompanyName", DataType = typeof(string)
            });
            

            companyNames.ForEach(name => _customerTable.Rows.Add(null, name));

        }
    }
}
