namespace ArkEngrams.ARKDataSetTableAdapters
{


	partial class EngramsTableAdapter
	{
		private System.Data.SqlClient.SqlCommand selectCmd = null;

		public int Fill(int categoryID, ARKDataSet.EngramsDataTable tbl)
		{
			if (selectCmd is null)
			{
				selectCmd = this._commandCollection[0].Clone();
				string select = selectCmd.CommandText;
				string where = " WHERE (Engrams.CategoryID = {0})"; 
				string orderBy = select.Contains("ORDER BY") ? select.Substring(select.IndexOf(" ORDER BY")) : string.Empty;
				select = select.Substring(0, select.Length - orderBy.Length);
				selectCmd.CommandText = select + where + orderBy;
			}

			selectCmd.CommandText = selectCmd.CommandText.Replace("= 0", categoryID.ToString());
			this.Adapter.SelectCommand = selectCmd;
			return this.Adapter.Fill(tbl);
		}
	}
}

namespace ArkEngrams
{


	partial class ARKDataSet
	{
	}
}
