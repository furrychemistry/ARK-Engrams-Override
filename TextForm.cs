using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArkEngrams
{
	public partial class TextForm : Form
	{
		public TextForm()
		{
			InitializeComponent();
		}

		private void selectAllToolStripMenuItem_Click(object sender, EventArgs e)
			=> txtResult.SelectAll();

		private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
		{
			try
			{ txtResult.SelectedText = string.Empty; }
			catch { }
		}

		private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
		{
			try
			{ txtResult.Paste(); }
			catch { }
		}

		private void copyToolStripMenuItem_Click(object sender, EventArgs e)
		{
			try
			{ txtResult.Copy(); }
			catch { }
		}

		private void cutToolStripMenuItem_Click(object sender, EventArgs e)
		{
			try
			{ txtResult.Cut(); }
			catch { }
		}

		private void copyAllToolStripMenuItem_Click(object sender, EventArgs e)
			=> Clipboard.SetText(txtResult.Text);

		private void undoToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (txtResult.CanUndo)
				txtResult.Undo();
		}
	}
}
