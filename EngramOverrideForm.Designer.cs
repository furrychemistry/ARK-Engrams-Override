namespace ArkEngrams
{
	partial class EngramOverrideForm
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			this.label1 = new System.Windows.Forms.Label();
			this.cmbSelectedCategory = new System.Windows.Forms.ComboBox();
			this.btnSaveChanges = new System.Windows.Forms.Button();
			this.chkTopMost = new System.Windows.Forms.CheckBox();
			this.label2 = new System.Windows.Forms.Label();
			this.txtFormTitle = new System.Windows.Forms.TextBox();
			this.btnGetGameiniText = new System.Windows.Forms.Button();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.engramCategoriesBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.aRKDataSet = new ArkEngrams.ARKDataSet();
			this.engramsBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.engramCategoriesTableAdapter = new ArkEngrams.ARKDataSetTableAdapters.EngramCategoriesTableAdapter();
			this.engramsTableAdapter = new ArkEngrams.ARKDataSetTableAdapters.EngramsTableAdapter();
			this.chkAllowAddDelete = new System.Windows.Forms.CheckBox();
			this.btnRequery = new System.Windows.Forms.Button();
			this.btnReloadCategories = new System.Windows.Forms.Button();
			this.engramIndexDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.engramClassNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.categoryIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
			this.friendlyNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.arkCostDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.myCostDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.useMyCostDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
			this.arkLevelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.myLevelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.useMyLevelDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
			this.autoUnlockLevelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.useAutoUnlockLevelDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
			this.removePrerequisitesDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
			this.hiddenDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.engramCategoriesBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.aRKDataSet)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.engramsBindingSource)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(1, 29);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(49, 13);
			this.label1.TabIndex = 2;
			this.label1.Text = "Category";
			// 
			// cmbSelectedCategory
			// 
			this.cmbSelectedCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbSelectedCategory.FormattingEnabled = true;
			this.cmbSelectedCategory.Location = new System.Drawing.Point(57, 26);
			this.cmbSelectedCategory.Name = "cmbSelectedCategory";
			this.cmbSelectedCategory.Size = new System.Drawing.Size(151, 21);
			this.cmbSelectedCategory.TabIndex = 3;
			this.cmbSelectedCategory.TabStop = false;
			this.cmbSelectedCategory.SelectedIndexChanged += new System.EventHandler(this.cmbSelectedCategory_SelectedIndexChanged);
			// 
			// btnSaveChanges
			// 
			this.btnSaveChanges.Location = new System.Drawing.Point(67, 53);
			this.btnSaveChanges.Name = "btnSaveChanges";
			this.btnSaveChanges.Size = new System.Drawing.Size(57, 23);
			this.btnSaveChanges.TabIndex = 4;
			this.btnSaveChanges.TabStop = false;
			this.btnSaveChanges.Text = "Save";
			this.btnSaveChanges.UseVisualStyleBackColor = true;
			this.btnSaveChanges.Click += new System.EventHandler(this.btnSaveChanges_Click);
			// 
			// chkTopMost
			// 
			this.chkTopMost.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.chkTopMost.AutoSize = true;
			this.chkTopMost.Location = new System.Drawing.Point(861, 2);
			this.chkTopMost.Name = "chkTopMost";
			this.chkTopMost.Size = new System.Drawing.Size(68, 17);
			this.chkTopMost.TabIndex = 5;
			this.chkTopMost.TabStop = false;
			this.chkTopMost.Text = "TopMost";
			this.chkTopMost.UseVisualStyleBackColor = true;
			this.chkTopMost.CheckedChanged += new System.EventHandler(this.chkTopMost_CheckedChanged);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(1, 3);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(53, 13);
			this.label2.TabIndex = 6;
			this.label2.Text = "Form Title";
			// 
			// txtFormTitle
			// 
			this.txtFormTitle.Location = new System.Drawing.Point(57, 0);
			this.txtFormTitle.Name = "txtFormTitle";
			this.txtFormTitle.Size = new System.Drawing.Size(151, 20);
			this.txtFormTitle.TabIndex = 7;
			this.txtFormTitle.TabStop = false;
			this.txtFormTitle.Text = "ARK Engrams";
			this.txtFormTitle.TextChanged += new System.EventHandler(this.txtFormTitle_TextChanged);
			// 
			// btnGetGameiniText
			// 
			this.btnGetGameiniText.Location = new System.Drawing.Point(130, 53);
			this.btnGetGameiniText.Name = "btnGetGameiniText";
			this.btnGetGameiniText.Size = new System.Drawing.Size(105, 23);
			this.btnGetGameiniText.TabIndex = 8;
			this.btnGetGameiniText.TabStop = false;
			this.btnGetGameiniText.Text = "Get Game.ini Text";
			this.btnGetGameiniText.UseVisualStyleBackColor = true;
			this.btnGetGameiniText.Click += new System.EventHandler(this.btnGetGameiniText_Click);
			// 
			// dataGridView1
			// 
			this.dataGridView1.AllowUserToAddRows = false;
			this.dataGridView1.AllowUserToDeleteRows = false;
			this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.dataGridView1.AutoGenerateColumns = false;
			this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.WindowText;
			this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.engramIndexDataGridViewTextBoxColumn,
            this.engramClassNameDataGridViewTextBoxColumn,
            this.categoryIDDataGridViewTextBoxColumn,
            this.friendlyNameDataGridViewTextBoxColumn,
            this.arkCostDataGridViewTextBoxColumn,
            this.myCostDataGridViewTextBoxColumn,
            this.useMyCostDataGridViewCheckBoxColumn,
            this.arkLevelDataGridViewTextBoxColumn,
            this.myLevelDataGridViewTextBoxColumn,
            this.useMyLevelDataGridViewCheckBoxColumn,
            this.autoUnlockLevelDataGridViewTextBoxColumn,
            this.useAutoUnlockLevelDataGridViewCheckBoxColumn,
            this.removePrerequisitesDataGridViewCheckBoxColumn,
            this.hiddenDataGridViewCheckBoxColumn});
			this.dataGridView1.DataSource = this.engramsBindingSource;
			this.dataGridView1.Location = new System.Drawing.Point(0, 82);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.Size = new System.Drawing.Size(929, 438);
			this.dataGridView1.TabIndex = 9;
			// 
			// engramCategoriesBindingSource
			// 
			this.engramCategoriesBindingSource.DataMember = "EngramCategories";
			this.engramCategoriesBindingSource.DataSource = this.aRKDataSet;
			// 
			// aRKDataSet
			// 
			this.aRKDataSet.DataSetName = "ARKDataSet";
			this.aRKDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// engramsBindingSource
			// 
			this.engramsBindingSource.DataMember = "Engrams";
			this.engramsBindingSource.DataSource = this.aRKDataSet;
			// 
			// engramCategoriesTableAdapter
			// 
			this.engramCategoriesTableAdapter.ClearBeforeFill = true;
			// 
			// engramsTableAdapter
			// 
			this.engramsTableAdapter.ClearBeforeFill = true;
			// 
			// chkAllowAddDelete
			// 
			this.chkAllowAddDelete.AutoSize = true;
			this.chkAllowAddDelete.Location = new System.Drawing.Point(214, 2);
			this.chkAllowAddDelete.Name = "chkAllowAddDelete";
			this.chkAllowAddDelete.Size = new System.Drawing.Size(109, 17);
			this.chkAllowAddDelete.TabIndex = 10;
			this.chkAllowAddDelete.Text = "Allow Add/Delete";
			this.chkAllowAddDelete.UseVisualStyleBackColor = true;
			this.chkAllowAddDelete.CheckedChanged += new System.EventHandler(this.chkAllowAddDelete_CheckedChanged);
			// 
			// btnRequery
			// 
			this.btnRequery.Location = new System.Drawing.Point(4, 53);
			this.btnRequery.Name = "btnRequery";
			this.btnRequery.Size = new System.Drawing.Size(57, 23);
			this.btnRequery.TabIndex = 11;
			this.btnRequery.TabStop = false;
			this.btnRequery.Text = "Requery";
			this.btnRequery.UseVisualStyleBackColor = true;
			this.btnRequery.Click += new System.EventHandler(this.btnRequery_Click);
			// 
			// btnReloadCategories
			// 
			this.btnReloadCategories.Location = new System.Drawing.Point(214, 25);
			this.btnReloadCategories.Name = "btnReloadCategories";
			this.btnReloadCategories.Size = new System.Drawing.Size(109, 23);
			this.btnReloadCategories.TabIndex = 12;
			this.btnReloadCategories.TabStop = false;
			this.btnReloadCategories.Text = "Reload Categories";
			this.btnReloadCategories.UseVisualStyleBackColor = true;
			this.btnReloadCategories.Click += new System.EventHandler(this.btnReloadCategories_Click);
			// 
			// engramIndexDataGridViewTextBoxColumn
			// 
			this.engramIndexDataGridViewTextBoxColumn.DataPropertyName = "EngramIndex";
			this.engramIndexDataGridViewTextBoxColumn.HeaderText = "EngramIndex";
			this.engramIndexDataGridViewTextBoxColumn.Name = "engramIndexDataGridViewTextBoxColumn";
			this.engramIndexDataGridViewTextBoxColumn.ReadOnly = true;
			this.engramIndexDataGridViewTextBoxColumn.Visible = false;
			// 
			// engramClassNameDataGridViewTextBoxColumn
			// 
			this.engramClassNameDataGridViewTextBoxColumn.DataPropertyName = "EngramClassName";
			this.engramClassNameDataGridViewTextBoxColumn.HeaderText = "EngramClassName";
			this.engramClassNameDataGridViewTextBoxColumn.Name = "engramClassNameDataGridViewTextBoxColumn";
			this.engramClassNameDataGridViewTextBoxColumn.ReadOnly = true;
			this.engramClassNameDataGridViewTextBoxColumn.Visible = false;
			// 
			// categoryIDDataGridViewTextBoxColumn
			// 
			this.categoryIDDataGridViewTextBoxColumn.DataPropertyName = "CategoryID";
			this.categoryIDDataGridViewTextBoxColumn.DataSource = this.engramCategoriesBindingSource;
			this.categoryIDDataGridViewTextBoxColumn.DisplayMember = "CategoryName";
			this.categoryIDDataGridViewTextBoxColumn.DropDownWidth = 120;
			this.categoryIDDataGridViewTextBoxColumn.HeaderText = "Category";
			this.categoryIDDataGridViewTextBoxColumn.MaxDropDownItems = 60;
			this.categoryIDDataGridViewTextBoxColumn.Name = "categoryIDDataGridViewTextBoxColumn";
			this.categoryIDDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
			this.categoryIDDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
			this.categoryIDDataGridViewTextBoxColumn.ValueMember = "ID";
			this.categoryIDDataGridViewTextBoxColumn.Width = 120;
			// 
			// friendlyNameDataGridViewTextBoxColumn
			// 
			this.friendlyNameDataGridViewTextBoxColumn.DataPropertyName = "FriendlyName";
			this.friendlyNameDataGridViewTextBoxColumn.DividerWidth = 4;
			this.friendlyNameDataGridViewTextBoxColumn.HeaderText = "Name";
			this.friendlyNameDataGridViewTextBoxColumn.Name = "friendlyNameDataGridViewTextBoxColumn";
			this.friendlyNameDataGridViewTextBoxColumn.Width = 208;
			// 
			// arkCostDataGridViewTextBoxColumn
			// 
			this.arkCostDataGridViewTextBoxColumn.DataPropertyName = "ArkCost";
			this.arkCostDataGridViewTextBoxColumn.HeaderText = "Ark Cost";
			this.arkCostDataGridViewTextBoxColumn.Name = "arkCostDataGridViewTextBoxColumn";
			this.arkCostDataGridViewTextBoxColumn.ReadOnly = true;
			this.arkCostDataGridViewTextBoxColumn.Width = 35;
			// 
			// myCostDataGridViewTextBoxColumn
			// 
			this.myCostDataGridViewTextBoxColumn.DataPropertyName = "MyCost";
			this.myCostDataGridViewTextBoxColumn.HeaderText = "My Cost";
			this.myCostDataGridViewTextBoxColumn.Name = "myCostDataGridViewTextBoxColumn";
			this.myCostDataGridViewTextBoxColumn.Width = 35;
			// 
			// useMyCostDataGridViewCheckBoxColumn
			// 
			this.useMyCostDataGridViewCheckBoxColumn.DataPropertyName = "UseMyCost";
			this.useMyCostDataGridViewCheckBoxColumn.DividerWidth = 4;
			this.useMyCostDataGridViewCheckBoxColumn.HeaderText = "Use My Cost";
			this.useMyCostDataGridViewCheckBoxColumn.Name = "useMyCostDataGridViewCheckBoxColumn";
			this.useMyCostDataGridViewCheckBoxColumn.Width = 60;
			// 
			// arkLevelDataGridViewTextBoxColumn
			// 
			this.arkLevelDataGridViewTextBoxColumn.DataPropertyName = "ArkLevel";
			this.arkLevelDataGridViewTextBoxColumn.HeaderText = "Ark Level";
			this.arkLevelDataGridViewTextBoxColumn.Name = "arkLevelDataGridViewTextBoxColumn";
			this.arkLevelDataGridViewTextBoxColumn.ReadOnly = true;
			this.arkLevelDataGridViewTextBoxColumn.Width = 40;
			// 
			// myLevelDataGridViewTextBoxColumn
			// 
			this.myLevelDataGridViewTextBoxColumn.DataPropertyName = "MyLevel";
			this.myLevelDataGridViewTextBoxColumn.HeaderText = "My Level";
			this.myLevelDataGridViewTextBoxColumn.Name = "myLevelDataGridViewTextBoxColumn";
			this.myLevelDataGridViewTextBoxColumn.Width = 40;
			// 
			// useMyLevelDataGridViewCheckBoxColumn
			// 
			this.useMyLevelDataGridViewCheckBoxColumn.DataPropertyName = "UseMyLevel";
			this.useMyLevelDataGridViewCheckBoxColumn.DividerWidth = 4;
			this.useMyLevelDataGridViewCheckBoxColumn.HeaderText = "Use My Level";
			this.useMyLevelDataGridViewCheckBoxColumn.Name = "useMyLevelDataGridViewCheckBoxColumn";
			this.useMyLevelDataGridViewCheckBoxColumn.Width = 60;
			// 
			// autoUnlockLevelDataGridViewTextBoxColumn
			// 
			this.autoUnlockLevelDataGridViewTextBoxColumn.DataPropertyName = "AutoUnlockLevel";
			this.autoUnlockLevelDataGridViewTextBoxColumn.HeaderText = "Auto Unlock Level";
			this.autoUnlockLevelDataGridViewTextBoxColumn.Name = "autoUnlockLevelDataGridViewTextBoxColumn";
			this.autoUnlockLevelDataGridViewTextBoxColumn.Width = 90;
			// 
			// useAutoUnlockLevelDataGridViewCheckBoxColumn
			// 
			this.useAutoUnlockLevelDataGridViewCheckBoxColumn.DataPropertyName = "UseAutoUnlockLevel";
			this.useAutoUnlockLevelDataGridViewCheckBoxColumn.DividerWidth = 4;
			this.useAutoUnlockLevelDataGridViewCheckBoxColumn.HeaderText = "Use Auto Unlock";
			this.useAutoUnlockLevelDataGridViewCheckBoxColumn.Name = "useAutoUnlockLevelDataGridViewCheckBoxColumn";
			this.useAutoUnlockLevelDataGridViewCheckBoxColumn.Width = 70;
			// 
			// removePrerequisitesDataGridViewCheckBoxColumn
			// 
			this.removePrerequisitesDataGridViewCheckBoxColumn.DataPropertyName = "RemovePrerequisites";
			this.removePrerequisitesDataGridViewCheckBoxColumn.DividerWidth = 4;
			this.removePrerequisitesDataGridViewCheckBoxColumn.HeaderText = "Remove Prerequisites";
			this.removePrerequisitesDataGridViewCheckBoxColumn.Name = "removePrerequisitesDataGridViewCheckBoxColumn";
			this.removePrerequisitesDataGridViewCheckBoxColumn.Width = 80;
			// 
			// hiddenDataGridViewCheckBoxColumn
			// 
			this.hiddenDataGridViewCheckBoxColumn.DataPropertyName = "Hidden";
			this.hiddenDataGridViewCheckBoxColumn.HeaderText = "Hidden";
			this.hiddenDataGridViewCheckBoxColumn.Name = "hiddenDataGridViewCheckBoxColumn";
			this.hiddenDataGridViewCheckBoxColumn.Width = 50;
			// 
			// EngramOverrideForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(931, 520);
			this.Controls.Add(this.btnRequery);
			this.Controls.Add(this.btnReloadCategories);
			this.Controls.Add(this.cmbSelectedCategory);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.chkTopMost);
			this.Controls.Add(this.txtFormTitle);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.chkAllowAddDelete);
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.btnSaveChanges);
			this.Controls.Add(this.btnGetGameiniText);
			this.Name = "EngramOverrideForm";
			this.Text = "ARK Engrams";
			this.Load += new System.EventHandler(this.EngramOverrideForm_Load);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.engramCategoriesBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.aRKDataSet)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.engramsBindingSource)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ComboBox cmbSelectedCategory;
		private System.Windows.Forms.Button btnSaveChanges;
		private System.Windows.Forms.CheckBox chkTopMost;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtFormTitle;
		private System.Windows.Forms.Button btnGetGameiniText;
		private System.Windows.Forms.DataGridView dataGridView1;
		private ARKDataSet aRKDataSet;
		private System.Windows.Forms.BindingSource engramsBindingSource;
		private System.Windows.Forms.BindingSource engramCategoriesBindingSource;
		private ARKDataSetTableAdapters.EngramCategoriesTableAdapter engramCategoriesTableAdapter;
		private ARKDataSetTableAdapters.EngramsTableAdapter engramsTableAdapter;
		private System.Windows.Forms.CheckBox chkAllowAddDelete;
		private System.Windows.Forms.Button btnRequery;
		private System.Windows.Forms.Button btnReloadCategories;
		private System.Windows.Forms.DataGridViewTextBoxColumn engramIndexDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn engramClassNameDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewComboBoxColumn categoryIDDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn friendlyNameDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn arkCostDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn myCostDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewCheckBoxColumn useMyCostDataGridViewCheckBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn arkLevelDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn myLevelDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewCheckBoxColumn useMyLevelDataGridViewCheckBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn autoUnlockLevelDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewCheckBoxColumn useAutoUnlockLevelDataGridViewCheckBoxColumn;
		private System.Windows.Forms.DataGridViewCheckBoxColumn removePrerequisitesDataGridViewCheckBoxColumn;
		private System.Windows.Forms.DataGridViewCheckBoxColumn hiddenDataGridViewCheckBoxColumn;
	}
}