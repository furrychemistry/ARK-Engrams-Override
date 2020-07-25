using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace ArkEngrams
{
	public partial class EngramOverrideForm : Form
	{
		private readonly struct EngramCategoryEntry : IEquatable<EngramCategoryEntry>
		{
			public static readonly EngramCategoryEntry ShowAll
				= new EngramCategoryEntry(int.MinValue, "<Show All>");

			public readonly int ID;
			public readonly string Name;

			public bool IsShowAll => this == ShowAll;

			public EngramCategoryEntry(int id, string name)
			{
				ID = id;
				Name = name;
			}
			public EngramCategoryEntry(ARKDataSet.EngramCategoriesRow row)
				: this(row.ID, row.CategoryName) { }

			public bool Equals(EngramCategoryEntry other) => ID == other.ID && Name == other.Name;
			public override string ToString() => Name ?? string.Empty;
			public override bool Equals(object obj) => obj is EngramCategoryEntry && Equals((EngramCategoryEntry)obj);
			public override int GetHashCode() => ID;

			public static bool operator ==(EngramCategoryEntry a, EngramCategoryEntry b) => a.Equals(b);
			public static bool operator !=(EngramCategoryEntry a, EngramCategoryEntry b) => !a.Equals(b);
		}

		public EngramOverrideForm()
		{
			InitializeComponent();
		}

		private void EngramOverrideForm_Load(object sender, EventArgs e)
		{
			engramCategoriesTableAdapter.Fill(aRKDataSet.EngramCategories);

			ComboBox.ObjectCollection cmbCategoryID_Items = cmbSelectedCategory.Items;
			ARKDataSet.EngramCategoriesDataTable categories = new ARKDataSet.EngramCategoriesDataTable();
			engramCategoriesTableAdapter.Fill(categories);

			cmbCategoryID_Items.Add(EngramCategoryEntry.ShowAll);

			foreach (ARKDataSet.EngramCategoriesRow row in categories)
				cmbCategoryID_Items.Add(new EngramCategoryEntry(row));

			cmbSelectedCategory.SelectedIndex = 0;
			chkAllowAddDelete.Checked = false;

			aRKDataSet.WriteXmlSchema(@"V:\ARK.xsd");
			aRKDataSet.WriteXml(@"V:\ARK.xml");
		}

		private void btnSaveChanges_Click(object sender, EventArgs e)
		{
			try
			{
				try
				{ dataGridView1.EndEdit(); }
				catch { }

				DataSet changes = aRKDataSet.GetChanges();

				if (changes != null)
					engramsTableAdapter.Adapter.Update(changes);

				cmbSelectedCategory_SelectedIndexChanged(null, null);
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}
		private void cmbSelectedCategory_SelectedIndexChanged(object sender, EventArgs e)
		{
			try
			{
				EngramCategoryEntry entry = (EngramCategoryEntry)cmbSelectedCategory.SelectedItem;

				if (entry.IsShowAll)
					engramsTableAdapter.Fill(aRKDataSet.Engrams);
				else
					engramsTableAdapter.FillByCategoryID(aRKDataSet.Engrams, entry.ID);

				dataGridView1.Focus();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		private void chkTopMost_CheckedChanged(object sender, EventArgs e)
		{
			TopMost = chkTopMost.Checked;
		}

		private void txtFormTitle_TextChanged(object sender, EventArgs e)
		{
			Text = txtFormTitle.Text;
		}

		private async void btnGetGameiniText_Click(object sender, EventArgs e)
		{
			const string autoUnlockformat = "EngramEntryAutoUnlocks=(EngramClassName=\"{0}\",LevelToAutoUnlock={1})";
			// {1} and {4} can be either "true" -or- "false"
			const string overrideFormat = "OverrideNamedEngramEntries=(EngramIndex={0},EngramHidden={1}," +
				"EngramPointsCost={2},EngramLevelRequirement={3},RemoveEngramPreReq={4})";

			List<string> unlocks = new List<string>();
			List<string> overrides = new List<string>();

			ARKDataSet.EngramsDataTable tbl = null; //engramsViewTableAdapter.GetGameiniChanges();

			foreach (ARKDataSet.EngramsRow row in tbl)
			{
				if (row.UseAutoUnlockLevel)
					unlocks.Add(string.Format(autoUnlockformat, row.EngramClassName, row.AutoUnlockLevel));

				if (row.Hidden || row.UseMyCost || row.UseMyLevel || row.RemovePrerequisites)
					overrides.Add(string.Format(overrideFormat, row.EngramIndex, row.Hidden.ToString()
						, row.UseMyCost ? row.MyCost : row.ArkCost, row.UseMyLevel ? row.MyLevel : row.ArkLevel
						, row.RemovePrerequisites.ToString()));
			}

			List<string> all = new List<string>(unlocks.Count + overrides.Count);
			all.AddRange(unlocks);
			all.AddRange(overrides);

			GetGameiniTextForm frm = new GetGameiniTextForm();
			frm.txtResult.Text = string.Join(Environment.NewLine, string.Join(Environment.NewLine, all));
			frm.txtResult.Select(0, 0);
			frm.Show();
		}

		private void chkAllowAddDelete_CheckedChanged(object sender, EventArgs e)
		{
			bool state = chkAllowAddDelete.Checked;
			dataGridView1.AllowUserToAddRows = state;
			dataGridView1.AllowUserToDeleteRows = state;
		}
	}
}