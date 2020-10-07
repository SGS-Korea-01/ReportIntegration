namespace Sgs.ReportIntegration
{
    partial class CtrlEditBom
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DevExpress.XtraGrid.GridLevelNode gridLevelNode1 = new DevExpress.XtraGrid.GridLevelNode();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CtrlEditBom));
            this.reportPanel = new Ulee.Controls.UlPanel();
            this.bomTab = new System.Windows.Forms.TabControl();
            this.bomProductPage = new System.Windows.Forms.TabPage();
            this.bomSplit = new System.Windows.Forms.SplitContainer();
            this.productGrid = new DevExpress.XtraGrid.GridControl();
            this.productGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.productValidColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.productValidCheckEdit = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.productCodeColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.productJobNoColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.productNameColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.productImageColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.partGrid = new DevExpress.XtraGrid.GridControl();
            this.partGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.partNameColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.partMaterialNoColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.partJobNoColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.partMaterialNameColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.bomExcelPage = new System.Windows.Forms.TabPage();
            this.bomExcelSheet = new DevExpress.XtraSpreadsheet.SpreadsheetControl();
            this.bomMessgaePage = new System.Windows.Forms.TabPage();
            this.totalLogEdit = new System.Windows.Forms.TextBox();
            this.viewSplit = new System.Windows.Forms.SplitContainer();
            this.gridPanel = new Ulee.Controls.UlPanel();
            this.bomToDateEdit = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.bomDateCheck = new System.Windows.Forms.CheckBox();
            this.bomFromDateEdit = new System.Windows.Forms.DateTimePicker();
            this.bomAreaCombo = new System.Windows.Forms.ComboBox();
            this.bomResetButton = new System.Windows.Forms.Button();
            this.label19 = new System.Windows.Forms.Label();
            this.bomGrid = new DevExpress.XtraGrid.GridControl();
            this.bomGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.bomRegTimeColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.bomAreaColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.bomFNameColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.bomFindButton = new System.Windows.Forms.Button();
            this.bomNameEdit = new DevExpress.XtraEditors.TextEdit();
            this.label4 = new System.Windows.Forms.Label();
            this.bgPanel.SuspendLayout();
            this.reportPanel.SuspendLayout();
            this.bomTab.SuspendLayout();
            this.bomProductPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bomSplit)).BeginInit();
            this.bomSplit.Panel1.SuspendLayout();
            this.bomSplit.Panel2.SuspendLayout();
            this.bomSplit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productValidCheckEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.partGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.partGridView)).BeginInit();
            this.bomExcelPage.SuspendLayout();
            this.bomMessgaePage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.viewSplit)).BeginInit();
            this.viewSplit.Panel1.SuspendLayout();
            this.viewSplit.Panel2.SuspendLayout();
            this.viewSplit.SuspendLayout();
            this.gridPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bomGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bomGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bomNameEdit.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // bgPanel
            // 
            this.bgPanel.BevelOuter = Ulee.Controls.EUlBevelStyle.None;
            this.bgPanel.Controls.Add(this.viewSplit);
            this.bgPanel.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bgPanel.Size = new System.Drawing.Size(820, 568);
            // 
            // reportPanel
            // 
            this.reportPanel.BevelInner = Ulee.Controls.EUlBevelStyle.None;
            this.reportPanel.BevelOuter = Ulee.Controls.EUlBevelStyle.None;
            this.reportPanel.Controls.Add(this.bomTab);
            this.reportPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reportPanel.InnerColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(160)))), ((int)(((byte)(160)))));
            this.reportPanel.InnerColor2 = System.Drawing.Color.White;
            this.reportPanel.Location = new System.Drawing.Point(0, 0);
            this.reportPanel.Name = "reportPanel";
            this.reportPanel.OuterColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(160)))), ((int)(((byte)(160)))));
            this.reportPanel.OuterColor2 = System.Drawing.Color.White;
            this.reportPanel.Size = new System.Drawing.Size(556, 568);
            this.reportPanel.Spacing = 0;
            this.reportPanel.TabIndex = 1;
            this.reportPanel.TextHAlign = Ulee.Controls.EUlHoriAlign.Center;
            this.reportPanel.TextVAlign = Ulee.Controls.EUlVertAlign.Middle;
            // 
            // bomTab
            // 
            this.bomTab.Controls.Add(this.bomProductPage);
            this.bomTab.Controls.Add(this.bomExcelPage);
            this.bomTab.Controls.Add(this.bomMessgaePage);
            this.bomTab.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bomTab.Location = new System.Drawing.Point(0, 0);
            this.bomTab.Margin = new System.Windows.Forms.Padding(4);
            this.bomTab.Name = "bomTab";
            this.bomTab.Padding = new System.Drawing.Point(6, 4);
            this.bomTab.SelectedIndex = 0;
            this.bomTab.Size = new System.Drawing.Size(556, 568);
            this.bomTab.TabIndex = 12;
            this.bomTab.SelectedIndexChanged += new System.EventHandler(this.bomTab_SelectedIndexChanged);
            // 
            // bomProductPage
            // 
            this.bomProductPage.Controls.Add(this.bomSplit);
            this.bomProductPage.Location = new System.Drawing.Point(4, 26);
            this.bomProductPage.Name = "bomProductPage";
            this.bomProductPage.Size = new System.Drawing.Size(548, 538);
            this.bomProductPage.TabIndex = 2;
            this.bomProductPage.Text = "  Product / Part  ";
            this.bomProductPage.UseVisualStyleBackColor = true;
            this.bomProductPage.Resize += new System.EventHandler(this.bomProductPage_Resize);
            // 
            // bomSplit
            // 
            this.bomSplit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bomSplit.Location = new System.Drawing.Point(0, 0);
            this.bomSplit.Name = "bomSplit";
            this.bomSplit.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // bomSplit.Panel1
            // 
            this.bomSplit.Panel1.Controls.Add(this.productGrid);
            this.bomSplit.Panel1MinSize = 128;
            // 
            // bomSplit.Panel2
            // 
            this.bomSplit.Panel2.Controls.Add(this.partGrid);
            this.bomSplit.Panel2MinSize = 128;
            this.bomSplit.Size = new System.Drawing.Size(548, 538);
            this.bomSplit.SplitterDistance = 266;
            this.bomSplit.TabIndex = 0;
            // 
            // productGrid
            // 
            this.productGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            gridLevelNode1.RelationName = "Level1";
            this.productGrid.LevelTree.Nodes.AddRange(new DevExpress.XtraGrid.GridLevelNode[] {
            gridLevelNode1});
            this.productGrid.Location = new System.Drawing.Point(0, 0);
            this.productGrid.MainView = this.productGridView;
            this.productGrid.Name = "productGrid";
            this.productGrid.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.productValidCheckEdit});
            this.productGrid.Size = new System.Drawing.Size(548, 266);
            this.productGrid.TabIndex = 0;
            this.productGrid.TabStop = false;
            this.productGrid.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.productGridView});
            this.productGrid.DoubleClick += new System.EventHandler(this.productGrid_DoubleClick);
            // 
            // productGridView
            // 
            this.productGridView.Appearance.FixedLine.Font = new System.Drawing.Font("Arial", 9F);
            this.productGridView.Appearance.FixedLine.Options.UseFont = true;
            this.productGridView.Appearance.FocusedCell.Font = new System.Drawing.Font("Arial", 9F);
            this.productGridView.Appearance.FocusedCell.Options.UseFont = true;
            this.productGridView.Appearance.FocusedRow.Font = new System.Drawing.Font("Arial", 9F);
            this.productGridView.Appearance.FocusedRow.Options.UseFont = true;
            this.productGridView.Appearance.HeaderPanel.Font = new System.Drawing.Font("Arial", 9F);
            this.productGridView.Appearance.HeaderPanel.Options.UseFont = true;
            this.productGridView.Appearance.HideSelectionRow.Font = new System.Drawing.Font("Arial", 9F);
            this.productGridView.Appearance.HideSelectionRow.Options.UseFont = true;
            this.productGridView.Appearance.OddRow.Font = new System.Drawing.Font("Arial", 9F);
            this.productGridView.Appearance.OddRow.Options.UseFont = true;
            this.productGridView.Appearance.Preview.Font = new System.Drawing.Font("Arial", 9F);
            this.productGridView.Appearance.Preview.Options.UseFont = true;
            this.productGridView.Appearance.Row.Font = new System.Drawing.Font("Arial", 9F);
            this.productGridView.Appearance.Row.Options.UseFont = true;
            this.productGridView.Appearance.SelectedRow.Font = new System.Drawing.Font("Arial", 9F);
            this.productGridView.Appearance.SelectedRow.Options.UseFont = true;
            this.productGridView.Appearance.ViewCaption.Font = new System.Drawing.Font("Arial", 9F);
            this.productGridView.Appearance.ViewCaption.Options.UseFont = true;
            this.productGridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.productValidColumn,
            this.productCodeColumn,
            this.productJobNoColumn,
            this.productNameColumn,
            this.productImageColumn});
            this.productGridView.CustomizationFormBounds = new System.Drawing.Rectangle(2884, 580, 210, 186);
            this.productGridView.GridControl = this.productGrid;
            this.productGridView.HorzScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Never;
            this.productGridView.Name = "productGridView";
            this.productGridView.OptionsBehavior.Editable = false;
            this.productGridView.OptionsBehavior.ReadOnly = true;
            this.productGridView.OptionsView.ColumnAutoWidth = false;
            this.productGridView.OptionsView.ShowGroupPanel = false;
            this.productGridView.OptionsView.ShowIndicator = false;
            this.productGridView.RowHeight = 32;
            this.productGridView.Tag = 1;
            this.productGridView.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.productGridView_FocusedRowChanged);
            // 
            // productValidColumn
            // 
            this.productValidColumn.AppearanceCell.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productValidColumn.AppearanceCell.Options.UseFont = true;
            this.productValidColumn.AppearanceCell.Options.UseTextOptions = true;
            this.productValidColumn.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.productValidColumn.AppearanceHeader.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productValidColumn.AppearanceHeader.Options.UseFont = true;
            this.productValidColumn.AppearanceHeader.Options.UseTextOptions = true;
            this.productValidColumn.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.productValidColumn.Caption = " ";
            this.productValidColumn.ColumnEdit = this.productValidCheckEdit;
            this.productValidColumn.FieldName = "valid";
            this.productValidColumn.MaxWidth = 24;
            this.productValidColumn.MinWidth = 24;
            this.productValidColumn.Name = "productValidColumn";
            this.productValidColumn.OptionsColumn.AllowEdit = false;
            this.productValidColumn.OptionsColumn.AllowFocus = false;
            this.productValidColumn.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.productValidColumn.OptionsColumn.AllowIncrementalSearch = false;
            this.productValidColumn.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.productValidColumn.OptionsColumn.AllowMove = false;
            this.productValidColumn.OptionsColumn.AllowShowHide = false;
            this.productValidColumn.OptionsColumn.AllowSize = false;
            this.productValidColumn.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.productValidColumn.OptionsColumn.FixedWidth = true;
            this.productValidColumn.OptionsColumn.ImmediateUpdateRowPosition = DevExpress.Utils.DefaultBoolean.False;
            this.productValidColumn.OptionsColumn.Printable = DevExpress.Utils.DefaultBoolean.False;
            this.productValidColumn.OptionsColumn.ReadOnly = true;
            this.productValidColumn.OptionsFilter.AllowAutoFilter = false;
            this.productValidColumn.OptionsFilter.AllowFilter = false;
            this.productValidColumn.Visible = true;
            this.productValidColumn.VisibleIndex = 0;
            this.productValidColumn.Width = 24;
            // 
            // productValidCheckEdit
            // 
            this.productValidCheckEdit.AutoHeight = false;
            this.productValidCheckEdit.Name = "productValidCheckEdit";
            this.productValidCheckEdit.ReadOnly = true;
            this.productValidCheckEdit.ValueChecked = 1;
            this.productValidCheckEdit.ValueUnchecked = 0;
            // 
            // productCodeColumn
            // 
            this.productCodeColumn.AppearanceCell.Font = new System.Drawing.Font("Arial", 9F);
            this.productCodeColumn.AppearanceCell.Options.UseFont = true;
            this.productCodeColumn.AppearanceCell.Options.UseTextOptions = true;
            this.productCodeColumn.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.productCodeColumn.AppearanceHeader.Font = new System.Drawing.Font("Arial", 9F);
            this.productCodeColumn.AppearanceHeader.Options.UseFont = true;
            this.productCodeColumn.AppearanceHeader.Options.UseTextOptions = true;
            this.productCodeColumn.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.productCodeColumn.Caption = "Item No";
            this.productCodeColumn.FieldName = "itemno";
            this.productCodeColumn.MaxWidth = 92;
            this.productCodeColumn.MinWidth = 92;
            this.productCodeColumn.Name = "productCodeColumn";
            this.productCodeColumn.OptionsColumn.AllowEdit = false;
            this.productCodeColumn.OptionsColumn.AllowFocus = false;
            this.productCodeColumn.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.productCodeColumn.OptionsColumn.AllowIncrementalSearch = false;
            this.productCodeColumn.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.productCodeColumn.OptionsColumn.AllowMove = false;
            this.productCodeColumn.OptionsColumn.AllowShowHide = false;
            this.productCodeColumn.OptionsColumn.AllowSize = false;
            this.productCodeColumn.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.True;
            this.productCodeColumn.OptionsColumn.FixedWidth = true;
            this.productCodeColumn.OptionsColumn.ImmediateUpdateRowPosition = DevExpress.Utils.DefaultBoolean.False;
            this.productCodeColumn.OptionsColumn.Printable = DevExpress.Utils.DefaultBoolean.False;
            this.productCodeColumn.OptionsColumn.ReadOnly = true;
            this.productCodeColumn.OptionsColumn.TabStop = false;
            this.productCodeColumn.OptionsFilter.AllowAutoFilter = false;
            this.productCodeColumn.OptionsFilter.AllowFilter = false;
            this.productCodeColumn.Visible = true;
            this.productCodeColumn.VisibleIndex = 1;
            this.productCodeColumn.Width = 92;
            // 
            // productJobNoColumn
            // 
            this.productJobNoColumn.AppearanceCell.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productJobNoColumn.AppearanceCell.Options.UseFont = true;
            this.productJobNoColumn.AppearanceHeader.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productJobNoColumn.AppearanceHeader.Options.UseFont = true;
            this.productJobNoColumn.Caption = "Job No";
            this.productJobNoColumn.FieldName = "jobno";
            this.productJobNoColumn.MaxWidth = 92;
            this.productJobNoColumn.MinWidth = 92;
            this.productJobNoColumn.Name = "productJobNoColumn";
            this.productJobNoColumn.OptionsColumn.AllowEdit = false;
            this.productJobNoColumn.OptionsColumn.AllowFocus = false;
            this.productJobNoColumn.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.productJobNoColumn.OptionsColumn.AllowIncrementalSearch = false;
            this.productJobNoColumn.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.productJobNoColumn.OptionsColumn.AllowMove = false;
            this.productJobNoColumn.OptionsColumn.AllowShowHide = false;
            this.productJobNoColumn.OptionsColumn.AllowSize = false;
            this.productJobNoColumn.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.True;
            this.productJobNoColumn.OptionsColumn.FixedWidth = true;
            this.productJobNoColumn.OptionsColumn.ImmediateUpdateRowPosition = DevExpress.Utils.DefaultBoolean.False;
            this.productJobNoColumn.OptionsColumn.Printable = DevExpress.Utils.DefaultBoolean.False;
            this.productJobNoColumn.OptionsColumn.ReadOnly = true;
            this.productJobNoColumn.OptionsFilter.AllowAutoFilter = false;
            this.productJobNoColumn.OptionsFilter.AllowFilter = false;
            this.productJobNoColumn.Visible = true;
            this.productJobNoColumn.VisibleIndex = 2;
            this.productJobNoColumn.Width = 92;
            // 
            // productNameColumn
            // 
            this.productNameColumn.AppearanceCell.Font = new System.Drawing.Font("Arial", 9F);
            this.productNameColumn.AppearanceCell.Options.UseFont = true;
            this.productNameColumn.AppearanceCell.Options.UseTextOptions = true;
            this.productNameColumn.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.productNameColumn.AppearanceHeader.Font = new System.Drawing.Font("Arial", 9F);
            this.productNameColumn.AppearanceHeader.Options.UseFont = true;
            this.productNameColumn.AppearanceHeader.Options.UseTextOptions = true;
            this.productNameColumn.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.productNameColumn.Caption = "Product Name";
            this.productNameColumn.FieldName = "name";
            this.productNameColumn.MinWidth = 180;
            this.productNameColumn.Name = "productNameColumn";
            this.productNameColumn.OptionsColumn.AllowEdit = false;
            this.productNameColumn.OptionsColumn.AllowFocus = false;
            this.productNameColumn.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.productNameColumn.OptionsColumn.AllowIncrementalSearch = false;
            this.productNameColumn.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.productNameColumn.OptionsColumn.AllowMove = false;
            this.productNameColumn.OptionsColumn.AllowShowHide = false;
            this.productNameColumn.OptionsColumn.AllowSize = false;
            this.productNameColumn.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.True;
            this.productNameColumn.OptionsColumn.FixedWidth = true;
            this.productNameColumn.OptionsColumn.ImmediateUpdateRowPosition = DevExpress.Utils.DefaultBoolean.False;
            this.productNameColumn.OptionsColumn.Printable = DevExpress.Utils.DefaultBoolean.False;
            this.productNameColumn.OptionsColumn.ReadOnly = true;
            this.productNameColumn.OptionsFilter.AllowAutoFilter = false;
            this.productNameColumn.OptionsFilter.AllowFilter = false;
            this.productNameColumn.Visible = true;
            this.productNameColumn.VisibleIndex = 3;
            this.productNameColumn.Width = 266;
            // 
            // productImageColumn
            // 
            this.productImageColumn.AppearanceCell.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productImageColumn.AppearanceCell.Options.UseFont = true;
            this.productImageColumn.AppearanceCell.Options.UseImage = true;
            this.productImageColumn.AppearanceCell.Options.UseTextOptions = true;
            this.productImageColumn.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.productImageColumn.AppearanceHeader.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productImageColumn.AppearanceHeader.Options.UseFont = true;
            this.productImageColumn.AppearanceHeader.Options.UseTextOptions = true;
            this.productImageColumn.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.productImageColumn.Caption = "Image";
            this.productImageColumn.FieldName = "image";
            this.productImageColumn.MinWidth = 52;
            this.productImageColumn.Name = "productImageColumn";
            this.productImageColumn.OptionsColumn.AllowEdit = false;
            this.productImageColumn.OptionsColumn.AllowFocus = false;
            this.productImageColumn.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.productImageColumn.OptionsColumn.AllowIncrementalSearch = false;
            this.productImageColumn.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.productImageColumn.OptionsColumn.AllowMove = false;
            this.productImageColumn.OptionsColumn.AllowShowHide = false;
            this.productImageColumn.OptionsColumn.AllowSize = false;
            this.productImageColumn.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.productImageColumn.OptionsColumn.FixedWidth = true;
            this.productImageColumn.OptionsColumn.ImmediateUpdateRowPosition = DevExpress.Utils.DefaultBoolean.False;
            this.productImageColumn.OptionsColumn.Printable = DevExpress.Utils.DefaultBoolean.False;
            this.productImageColumn.OptionsColumn.ReadOnly = true;
            this.productImageColumn.OptionsFilter.AllowAutoFilter = false;
            this.productImageColumn.OptionsFilter.AllowFilter = false;
            this.productImageColumn.Visible = true;
            this.productImageColumn.VisibleIndex = 4;
            this.productImageColumn.Width = 52;
            // 
            // partGrid
            // 
            this.partGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.partGrid.Location = new System.Drawing.Point(0, 0);
            this.partGrid.MainView = this.partGridView;
            this.partGrid.Name = "partGrid";
            this.partGrid.Size = new System.Drawing.Size(548, 268);
            this.partGrid.TabIndex = 1;
            this.partGrid.TabStop = false;
            this.partGrid.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.partGridView});
            // 
            // partGridView
            // 
            this.partGridView.Appearance.FixedLine.Font = new System.Drawing.Font("Arial", 9F);
            this.partGridView.Appearance.FixedLine.Options.UseFont = true;
            this.partGridView.Appearance.FocusedCell.Font = new System.Drawing.Font("Arial", 9F);
            this.partGridView.Appearance.FocusedCell.Options.UseFont = true;
            this.partGridView.Appearance.FocusedRow.Font = new System.Drawing.Font("Arial", 9F);
            this.partGridView.Appearance.FocusedRow.Options.UseFont = true;
            this.partGridView.Appearance.HeaderPanel.Font = new System.Drawing.Font("Arial", 9F);
            this.partGridView.Appearance.HeaderPanel.Options.UseFont = true;
            this.partGridView.Appearance.HideSelectionRow.Font = new System.Drawing.Font("Arial", 9F);
            this.partGridView.Appearance.HideSelectionRow.Options.UseFont = true;
            this.partGridView.Appearance.OddRow.Font = new System.Drawing.Font("Arial", 9F);
            this.partGridView.Appearance.OddRow.Options.UseFont = true;
            this.partGridView.Appearance.Preview.Font = new System.Drawing.Font("Arial", 9F);
            this.partGridView.Appearance.Preview.Options.UseFont = true;
            this.partGridView.Appearance.Row.Font = new System.Drawing.Font("Arial", 9F);
            this.partGridView.Appearance.Row.Options.UseFont = true;
            this.partGridView.Appearance.SelectedRow.Font = new System.Drawing.Font("Arial", 9F);
            this.partGridView.Appearance.SelectedRow.Options.UseFont = true;
            this.partGridView.Appearance.ViewCaption.Font = new System.Drawing.Font("Arial", 9F);
            this.partGridView.Appearance.ViewCaption.Options.UseFont = true;
            this.partGridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.partNameColumn,
            this.partMaterialNoColumn,
            this.partJobNoColumn,
            this.partMaterialNameColumn});
            this.partGridView.CustomizationFormBounds = new System.Drawing.Rectangle(2884, 580, 210, 186);
            this.partGridView.GridControl = this.partGrid;
            this.partGridView.HorzScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Never;
            this.partGridView.Name = "partGridView";
            this.partGridView.OptionsBehavior.Editable = false;
            this.partGridView.OptionsBehavior.ReadOnly = true;
            this.partGridView.OptionsView.ColumnAutoWidth = false;
            this.partGridView.OptionsView.ShowGroupPanel = false;
            this.partGridView.OptionsView.ShowIndicator = false;
            this.partGridView.Tag = 1;
            // 
            // partNameColumn
            // 
            this.partNameColumn.AppearanceCell.Font = new System.Drawing.Font("Arial", 9F);
            this.partNameColumn.AppearanceCell.Options.UseFont = true;
            this.partNameColumn.AppearanceCell.Options.UseTextOptions = true;
            this.partNameColumn.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.partNameColumn.AppearanceHeader.Font = new System.Drawing.Font("Arial", 9F);
            this.partNameColumn.AppearanceHeader.Options.UseFont = true;
            this.partNameColumn.AppearanceHeader.Options.UseTextOptions = true;
            this.partNameColumn.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.partNameColumn.Caption = "Part Name";
            this.partNameColumn.FieldName = "name";
            this.partNameColumn.MinWidth = 140;
            this.partNameColumn.Name = "partNameColumn";
            this.partNameColumn.OptionsColumn.AllowEdit = false;
            this.partNameColumn.OptionsColumn.AllowFocus = false;
            this.partNameColumn.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.partNameColumn.OptionsColumn.AllowIncrementalSearch = false;
            this.partNameColumn.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.partNameColumn.OptionsColumn.AllowMove = false;
            this.partNameColumn.OptionsColumn.AllowShowHide = false;
            this.partNameColumn.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.True;
            this.partNameColumn.OptionsColumn.ImmediateUpdateRowPosition = DevExpress.Utils.DefaultBoolean.False;
            this.partNameColumn.OptionsColumn.Printable = DevExpress.Utils.DefaultBoolean.False;
            this.partNameColumn.OptionsColumn.ReadOnly = true;
            this.partNameColumn.OptionsColumn.TabStop = false;
            this.partNameColumn.OptionsFilter.AllowAutoFilter = false;
            this.partNameColumn.OptionsFilter.AllowFilter = false;
            this.partNameColumn.Visible = true;
            this.partNameColumn.VisibleIndex = 0;
            this.partNameColumn.Width = 171;
            // 
            // partMaterialNoColumn
            // 
            this.partMaterialNoColumn.AppearanceCell.Font = new System.Drawing.Font("Arial", 9F);
            this.partMaterialNoColumn.AppearanceCell.Options.UseFont = true;
            this.partMaterialNoColumn.AppearanceCell.Options.UseTextOptions = true;
            this.partMaterialNoColumn.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.partMaterialNoColumn.AppearanceHeader.Font = new System.Drawing.Font("Arial", 9F);
            this.partMaterialNoColumn.AppearanceHeader.Options.UseFont = true;
            this.partMaterialNoColumn.AppearanceHeader.Options.UseTextOptions = true;
            this.partMaterialNoColumn.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.partMaterialNoColumn.Caption = "Material No";
            this.partMaterialNoColumn.FieldName = "materialno";
            this.partMaterialNoColumn.MaxWidth = 92;
            this.partMaterialNoColumn.MinWidth = 92;
            this.partMaterialNoColumn.Name = "partMaterialNoColumn";
            this.partMaterialNoColumn.OptionsColumn.AllowEdit = false;
            this.partMaterialNoColumn.OptionsColumn.AllowFocus = false;
            this.partMaterialNoColumn.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.partMaterialNoColumn.OptionsColumn.AllowIncrementalSearch = false;
            this.partMaterialNoColumn.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.partMaterialNoColumn.OptionsColumn.AllowMove = false;
            this.partMaterialNoColumn.OptionsColumn.AllowShowHide = false;
            this.partMaterialNoColumn.OptionsColumn.AllowSize = false;
            this.partMaterialNoColumn.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.partMaterialNoColumn.OptionsColumn.ImmediateUpdateRowPosition = DevExpress.Utils.DefaultBoolean.False;
            this.partMaterialNoColumn.OptionsColumn.Printable = DevExpress.Utils.DefaultBoolean.False;
            this.partMaterialNoColumn.OptionsColumn.ReadOnly = true;
            this.partMaterialNoColumn.OptionsFilter.AllowAutoFilter = false;
            this.partMaterialNoColumn.OptionsFilter.AllowFilter = false;
            this.partMaterialNoColumn.Visible = true;
            this.partMaterialNoColumn.VisibleIndex = 1;
            this.partMaterialNoColumn.Width = 92;
            // 
            // partJobNoColumn
            // 
            this.partJobNoColumn.AppearanceCell.Font = new System.Drawing.Font("Arial", 9F);
            this.partJobNoColumn.AppearanceCell.Options.UseFont = true;
            this.partJobNoColumn.AppearanceHeader.Font = new System.Drawing.Font("Arial", 9F);
            this.partJobNoColumn.AppearanceHeader.Options.UseFont = true;
            this.partJobNoColumn.Caption = "Job No";
            this.partJobNoColumn.FieldName = "jobno";
            this.partJobNoColumn.MaxWidth = 92;
            this.partJobNoColumn.MinWidth = 92;
            this.partJobNoColumn.Name = "partJobNoColumn";
            this.partJobNoColumn.OptionsColumn.AllowEdit = false;
            this.partJobNoColumn.OptionsColumn.AllowFocus = false;
            this.partJobNoColumn.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.partJobNoColumn.OptionsColumn.AllowIncrementalSearch = false;
            this.partJobNoColumn.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.partJobNoColumn.OptionsColumn.AllowMove = false;
            this.partJobNoColumn.OptionsColumn.AllowShowHide = false;
            this.partJobNoColumn.OptionsColumn.AllowSize = false;
            this.partJobNoColumn.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.partJobNoColumn.OptionsColumn.FixedWidth = true;
            this.partJobNoColumn.OptionsColumn.ReadOnly = true;
            this.partJobNoColumn.OptionsFilter.AllowAutoFilter = false;
            this.partJobNoColumn.OptionsFilter.AllowFilter = false;
            this.partJobNoColumn.Visible = true;
            this.partJobNoColumn.VisibleIndex = 2;
            this.partJobNoColumn.Width = 92;
            // 
            // partMaterialNameColumn
            // 
            this.partMaterialNameColumn.AppearanceCell.Font = new System.Drawing.Font("Arial", 9F);
            this.partMaterialNameColumn.AppearanceCell.Options.UseFont = true;
            this.partMaterialNameColumn.AppearanceHeader.Font = new System.Drawing.Font("Arial", 9F);
            this.partMaterialNameColumn.AppearanceHeader.Options.UseFont = true;
            this.partMaterialNameColumn.Caption = "Material Name";
            this.partMaterialNameColumn.FieldName = "materialname";
            this.partMaterialNameColumn.MinWidth = 140;
            this.partMaterialNameColumn.Name = "partMaterialNameColumn";
            this.partMaterialNameColumn.OptionsColumn.AllowEdit = false;
            this.partMaterialNameColumn.OptionsColumn.AllowFocus = false;
            this.partMaterialNameColumn.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.partMaterialNameColumn.OptionsColumn.AllowIncrementalSearch = false;
            this.partMaterialNameColumn.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.partMaterialNameColumn.OptionsColumn.AllowMove = false;
            this.partMaterialNameColumn.OptionsColumn.AllowShowHide = false;
            this.partMaterialNameColumn.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.True;
            this.partMaterialNameColumn.OptionsColumn.ReadOnly = true;
            this.partMaterialNameColumn.OptionsFilter.AllowAutoFilter = false;
            this.partMaterialNameColumn.OptionsFilter.AllowFilter = false;
            this.partMaterialNameColumn.Visible = true;
            this.partMaterialNameColumn.VisibleIndex = 3;
            this.partMaterialNameColumn.Width = 171;
            // 
            // bomExcelPage
            // 
            this.bomExcelPage.Controls.Add(this.bomExcelSheet);
            this.bomExcelPage.Location = new System.Drawing.Point(4, 26);
            this.bomExcelPage.Name = "bomExcelPage";
            this.bomExcelPage.Size = new System.Drawing.Size(548, 538);
            this.bomExcelPage.TabIndex = 3;
            this.bomExcelPage.Text = "  Excel  ";
            this.bomExcelPage.UseVisualStyleBackColor = true;
            // 
            // bomExcelSheet
            // 
            this.bomExcelSheet.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bomExcelSheet.Location = new System.Drawing.Point(0, 0);
            this.bomExcelSheet.LookAndFeel.SkinName = "DevExpress Style";
            this.bomExcelSheet.Margin = new System.Windows.Forms.Padding(0);
            this.bomExcelSheet.Name = "bomExcelSheet";
            this.bomExcelSheet.Options.Behavior.Selection.AllowExtendSelection = false;
            this.bomExcelSheet.Options.Behavior.Selection.AllowMultiSelection = false;
            this.bomExcelSheet.Options.Behavior.Selection.MoveActiveCellMode = DevExpress.XtraSpreadsheet.MoveActiveCellModeOnEnterPress.None;
            this.bomExcelSheet.Options.Behavior.Selection.ShowSelectionMode = DevExpress.XtraSpreadsheet.ShowSelectionMode.Focused;
            this.bomExcelSheet.Options.ZoomMode = DevExpress.Spreadsheet.WorksheetZoomMode.ActiveView;
            this.bomExcelSheet.ReadOnly = true;
            this.bomExcelSheet.Size = new System.Drawing.Size(548, 538);
            this.bomExcelSheet.TabIndex = 2;
            // 
            // bomMessgaePage
            // 
            this.bomMessgaePage.Controls.Add(this.totalLogEdit);
            this.bomMessgaePage.Location = new System.Drawing.Point(4, 26);
            this.bomMessgaePage.Name = "bomMessgaePage";
            this.bomMessgaePage.Padding = new System.Windows.Forms.Padding(3);
            this.bomMessgaePage.Size = new System.Drawing.Size(548, 538);
            this.bomMessgaePage.TabIndex = 4;
            this.bomMessgaePage.Text = "  Message  ";
            this.bomMessgaePage.UseVisualStyleBackColor = true;
            // 
            // totalLogEdit
            // 
            this.totalLogEdit.BackColor = System.Drawing.Color.FloralWhite;
            this.totalLogEdit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.totalLogEdit.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalLogEdit.Location = new System.Drawing.Point(3, 3);
            this.totalLogEdit.MaxLength = 131071;
            this.totalLogEdit.Multiline = true;
            this.totalLogEdit.Name = "totalLogEdit";
            this.totalLogEdit.ReadOnly = true;
            this.totalLogEdit.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.totalLogEdit.Size = new System.Drawing.Size(542, 532);
            this.totalLogEdit.TabIndex = 6;
            this.totalLogEdit.TabStop = false;
            // 
            // viewSplit
            // 
            this.viewSplit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.viewSplit.Location = new System.Drawing.Point(0, 0);
            this.viewSplit.Name = "viewSplit";
            // 
            // viewSplit.Panel1
            // 
            this.viewSplit.Panel1.Controls.Add(this.gridPanel);
            this.viewSplit.Panel1MinSize = 260;
            // 
            // viewSplit.Panel2
            // 
            this.viewSplit.Panel2.Controls.Add(this.reportPanel);
            this.viewSplit.Panel2MinSize = 260;
            this.viewSplit.Size = new System.Drawing.Size(820, 568);
            this.viewSplit.SplitterDistance = 260;
            this.viewSplit.TabIndex = 0;
            this.viewSplit.TabStop = false;
            // 
            // gridPanel
            // 
            this.gridPanel.BevelInner = Ulee.Controls.EUlBevelStyle.None;
            this.gridPanel.BevelOuter = Ulee.Controls.EUlBevelStyle.None;
            this.gridPanel.Controls.Add(this.bomToDateEdit);
            this.gridPanel.Controls.Add(this.label3);
            this.gridPanel.Controls.Add(this.bomDateCheck);
            this.gridPanel.Controls.Add(this.bomFromDateEdit);
            this.gridPanel.Controls.Add(this.bomAreaCombo);
            this.gridPanel.Controls.Add(this.bomResetButton);
            this.gridPanel.Controls.Add(this.label19);
            this.gridPanel.Controls.Add(this.bomGrid);
            this.gridPanel.Controls.Add(this.bomFindButton);
            this.gridPanel.Controls.Add(this.bomNameEdit);
            this.gridPanel.Controls.Add(this.label4);
            this.gridPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridPanel.InnerColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(160)))), ((int)(((byte)(160)))));
            this.gridPanel.InnerColor2 = System.Drawing.Color.White;
            this.gridPanel.Location = new System.Drawing.Point(0, 0);
            this.gridPanel.Name = "gridPanel";
            this.gridPanel.OuterColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(160)))), ((int)(((byte)(160)))));
            this.gridPanel.OuterColor2 = System.Drawing.Color.White;
            this.gridPanel.Size = new System.Drawing.Size(260, 568);
            this.gridPanel.Spacing = 0;
            this.gridPanel.TabIndex = 0;
            this.gridPanel.TabStop = true;
            this.gridPanel.TextHAlign = Ulee.Controls.EUlHoriAlign.Center;
            this.gridPanel.TextVAlign = Ulee.Controls.EUlVertAlign.Middle;
            this.gridPanel.Resize += new System.EventHandler(this.gridPanel_Resize);
            // 
            // bomToDateEdit
            // 
            this.bomToDateEdit.CustomFormat = "yyyy-MM-dd";
            this.bomToDateEdit.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bomToDateEdit.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.bomToDateEdit.Location = new System.Drawing.Point(56, 29);
            this.bomToDateEdit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.bomToDateEdit.Name = "bomToDateEdit";
            this.bomToDateEdit.Size = new System.Drawing.Size(102, 21);
            this.bomToDateEdit.TabIndex = 2;
            this.bomToDateEdit.ValueChanged += new System.EventHandler(this.bomToDateEdit_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Malgun Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.Location = new System.Drawing.Point(37, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(15, 15);
            this.label3.TabIndex = 100;
            this.label3.Text = "~";
            // 
            // bomDateCheck
            // 
            this.bomDateCheck.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bomDateCheck.Location = new System.Drawing.Point(4, 5);
            this.bomDateCheck.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.bomDateCheck.Name = "bomDateCheck";
            this.bomDateCheck.Size = new System.Drawing.Size(52, 19);
            this.bomDateCheck.TabIndex = 0;
            this.bomDateCheck.Tag = "";
            this.bomDateCheck.Text = "Date";
            this.bomDateCheck.UseVisualStyleBackColor = true;
            // 
            // bomFromDateEdit
            // 
            this.bomFromDateEdit.CustomFormat = "yyyy-MM-dd";
            this.bomFromDateEdit.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bomFromDateEdit.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.bomFromDateEdit.Location = new System.Drawing.Point(56, 3);
            this.bomFromDateEdit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.bomFromDateEdit.Name = "bomFromDateEdit";
            this.bomFromDateEdit.Size = new System.Drawing.Size(102, 21);
            this.bomFromDateEdit.TabIndex = 1;
            this.bomFromDateEdit.ValueChanged += new System.EventHandler(this.bomFromDateEdit_ValueChanged);
            // 
            // bomAreaCombo
            // 
            this.bomAreaCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.bomAreaCombo.FormattingEnabled = true;
            this.bomAreaCombo.Location = new System.Drawing.Point(56, 55);
            this.bomAreaCombo.Name = "bomAreaCombo";
            this.bomAreaCombo.Size = new System.Drawing.Size(102, 23);
            this.bomAreaCombo.TabIndex = 3;
            // 
            // bomResetButton
            // 
            this.bomResetButton.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bomResetButton.Image = ((System.Drawing.Image)(resources.GetObject("bomResetButton.Image")));
            this.bomResetButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bomResetButton.Location = new System.Drawing.Point(174, 28);
            this.bomResetButton.Name = "bomResetButton";
            this.bomResetButton.Padding = new System.Windows.Forms.Padding(2, 0, 0, 0);
            this.bomResetButton.Size = new System.Drawing.Size(86, 24);
            this.bomResetButton.TabIndex = 6;
            this.bomResetButton.Text = "     Reset";
            this.bomResetButton.UseVisualStyleBackColor = true;
            this.bomResetButton.Click += new System.EventHandler(this.bomResetButton_Click);
            // 
            // label19
            // 
            this.label19.Location = new System.Drawing.Point(2, 54);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(41, 22);
            this.label19.TabIndex = 96;
            this.label19.Text = "Area";
            this.label19.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // bomGrid
            // 
            this.bomGrid.Location = new System.Drawing.Point(0, 110);
            this.bomGrid.MainView = this.bomGridView;
            this.bomGrid.Name = "bomGrid";
            this.bomGrid.Size = new System.Drawing.Size(260, 458);
            this.bomGrid.TabIndex = 7;
            this.bomGrid.TabStop = false;
            this.bomGrid.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.bomGridView});
            // 
            // bomGridView
            // 
            this.bomGridView.Appearance.FixedLine.Font = new System.Drawing.Font("Arial", 9F);
            this.bomGridView.Appearance.FixedLine.Options.UseFont = true;
            this.bomGridView.Appearance.FocusedCell.Font = new System.Drawing.Font("Arial", 9F);
            this.bomGridView.Appearance.FocusedCell.Options.UseFont = true;
            this.bomGridView.Appearance.FocusedRow.Font = new System.Drawing.Font("Arial", 9F);
            this.bomGridView.Appearance.FocusedRow.Options.UseFont = true;
            this.bomGridView.Appearance.HeaderPanel.Font = new System.Drawing.Font("Arial", 9F);
            this.bomGridView.Appearance.HeaderPanel.Options.UseFont = true;
            this.bomGridView.Appearance.HideSelectionRow.Font = new System.Drawing.Font("Arial", 9F);
            this.bomGridView.Appearance.HideSelectionRow.Options.UseFont = true;
            this.bomGridView.Appearance.OddRow.Font = new System.Drawing.Font("Arial", 9F);
            this.bomGridView.Appearance.OddRow.Options.UseFont = true;
            this.bomGridView.Appearance.Preview.Font = new System.Drawing.Font("Arial", 9F);
            this.bomGridView.Appearance.Preview.Options.UseFont = true;
            this.bomGridView.Appearance.Row.Font = new System.Drawing.Font("Arial", 9F);
            this.bomGridView.Appearance.Row.Options.UseFont = true;
            this.bomGridView.Appearance.SelectedRow.Font = new System.Drawing.Font("Arial", 9F);
            this.bomGridView.Appearance.SelectedRow.Options.UseFont = true;
            this.bomGridView.Appearance.ViewCaption.Font = new System.Drawing.Font("Arial", 9F);
            this.bomGridView.Appearance.ViewCaption.Options.UseFont = true;
            this.bomGridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.bomRegTimeColumn,
            this.bomAreaColumn,
            this.bomFNameColumn});
            this.bomGridView.CustomizationFormBounds = new System.Drawing.Rectangle(2884, 580, 210, 186);
            this.bomGridView.GridControl = this.bomGrid;
            this.bomGridView.Name = "bomGridView";
            this.bomGridView.OptionsBehavior.Editable = false;
            this.bomGridView.OptionsBehavior.ReadOnly = true;
            this.bomGridView.OptionsFilter.AllowAutoFilterConditionChange = DevExpress.Utils.DefaultBoolean.False;
            this.bomGridView.OptionsFilter.AllowFilterEditor = false;
            this.bomGridView.OptionsView.ColumnAutoWidth = false;
            this.bomGridView.OptionsView.ShowGroupPanel = false;
            this.bomGridView.OptionsView.ShowIndicator = false;
            this.bomGridView.Tag = 1;
            this.bomGridView.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.bomGridView_FocusedRowChanged);
            // 
            // bomRegTimeColumn
            // 
            this.bomRegTimeColumn.AppearanceCell.Font = new System.Drawing.Font("Arial", 9F);
            this.bomRegTimeColumn.AppearanceCell.Options.UseFont = true;
            this.bomRegTimeColumn.AppearanceCell.Options.UseTextOptions = true;
            this.bomRegTimeColumn.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.bomRegTimeColumn.AppearanceHeader.Font = new System.Drawing.Font("Arial", 9F);
            this.bomRegTimeColumn.AppearanceHeader.Options.UseFont = true;
            this.bomRegTimeColumn.AppearanceHeader.Options.UseTextOptions = true;
            this.bomRegTimeColumn.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.bomRegTimeColumn.Caption = "DateTime";
            this.bomRegTimeColumn.FieldName = "regtime";
            this.bomRegTimeColumn.MaxWidth = 110;
            this.bomRegTimeColumn.MinWidth = 110;
            this.bomRegTimeColumn.Name = "bomRegTimeColumn";
            this.bomRegTimeColumn.OptionsColumn.AllowEdit = false;
            this.bomRegTimeColumn.OptionsColumn.AllowFocus = false;
            this.bomRegTimeColumn.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.bomRegTimeColumn.OptionsColumn.AllowIncrementalSearch = false;
            this.bomRegTimeColumn.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.bomRegTimeColumn.OptionsColumn.AllowMove = false;
            this.bomRegTimeColumn.OptionsColumn.AllowShowHide = false;
            this.bomRegTimeColumn.OptionsColumn.AllowSize = false;
            this.bomRegTimeColumn.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.True;
            this.bomRegTimeColumn.OptionsColumn.FixedWidth = true;
            this.bomRegTimeColumn.OptionsColumn.ImmediateUpdateRowPosition = DevExpress.Utils.DefaultBoolean.False;
            this.bomRegTimeColumn.OptionsColumn.Printable = DevExpress.Utils.DefaultBoolean.False;
            this.bomRegTimeColumn.OptionsColumn.ReadOnly = true;
            this.bomRegTimeColumn.OptionsColumn.TabStop = false;
            this.bomRegTimeColumn.OptionsFilter.AllowAutoFilter = false;
            this.bomRegTimeColumn.OptionsFilter.AllowFilter = false;
            this.bomRegTimeColumn.Visible = true;
            this.bomRegTimeColumn.VisibleIndex = 0;
            this.bomRegTimeColumn.Width = 110;
            // 
            // bomAreaColumn
            // 
            this.bomAreaColumn.AppearanceCell.Font = new System.Drawing.Font("Arial", 9F);
            this.bomAreaColumn.AppearanceCell.Options.UseFont = true;
            this.bomAreaColumn.AppearanceCell.Options.UseTextOptions = true;
            this.bomAreaColumn.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.bomAreaColumn.AppearanceHeader.Font = new System.Drawing.Font("Arial", 9F);
            this.bomAreaColumn.AppearanceHeader.Options.UseFont = true;
            this.bomAreaColumn.AppearanceHeader.Options.UseTextOptions = true;
            this.bomAreaColumn.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.bomAreaColumn.Caption = "Area";
            this.bomAreaColumn.FieldName = "areano";
            this.bomAreaColumn.MaxWidth = 48;
            this.bomAreaColumn.MinWidth = 48;
            this.bomAreaColumn.Name = "bomAreaColumn";
            this.bomAreaColumn.OptionsColumn.AllowEdit = false;
            this.bomAreaColumn.OptionsColumn.AllowFocus = false;
            this.bomAreaColumn.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.bomAreaColumn.OptionsColumn.AllowIncrementalSearch = false;
            this.bomAreaColumn.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.bomAreaColumn.OptionsColumn.AllowMove = false;
            this.bomAreaColumn.OptionsColumn.AllowShowHide = false;
            this.bomAreaColumn.OptionsColumn.AllowSize = false;
            this.bomAreaColumn.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.True;
            this.bomAreaColumn.OptionsColumn.FixedWidth = true;
            this.bomAreaColumn.OptionsColumn.ImmediateUpdateRowPosition = DevExpress.Utils.DefaultBoolean.False;
            this.bomAreaColumn.OptionsColumn.Printable = DevExpress.Utils.DefaultBoolean.False;
            this.bomAreaColumn.OptionsColumn.ReadOnly = true;
            this.bomAreaColumn.OptionsFilter.AllowAutoFilter = false;
            this.bomAreaColumn.OptionsFilter.AllowFilter = false;
            this.bomAreaColumn.Visible = true;
            this.bomAreaColumn.VisibleIndex = 1;
            this.bomAreaColumn.Width = 48;
            // 
            // bomFNameColumn
            // 
            this.bomFNameColumn.AppearanceCell.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bomFNameColumn.AppearanceCell.Options.UseFont = true;
            this.bomFNameColumn.AppearanceHeader.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bomFNameColumn.AppearanceHeader.Options.UseFont = true;
            this.bomFNameColumn.Caption = "File Name";
            this.bomFNameColumn.FieldName = "fname";
            this.bomFNameColumn.MinWidth = 300;
            this.bomFNameColumn.Name = "bomFNameColumn";
            this.bomFNameColumn.OptionsColumn.AllowEdit = false;
            this.bomFNameColumn.OptionsColumn.AllowFocus = false;
            this.bomFNameColumn.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.bomFNameColumn.OptionsColumn.AllowIncrementalSearch = false;
            this.bomFNameColumn.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.bomFNameColumn.OptionsColumn.AllowMove = false;
            this.bomFNameColumn.OptionsColumn.AllowShowHide = false;
            this.bomFNameColumn.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.True;
            this.bomFNameColumn.OptionsColumn.ReadOnly = true;
            this.bomFNameColumn.OptionsFilter.AllowAutoFilter = false;
            this.bomFNameColumn.OptionsFilter.AllowFilter = false;
            this.bomFNameColumn.Visible = true;
            this.bomFNameColumn.VisibleIndex = 2;
            this.bomFNameColumn.Width = 400;
            // 
            // bomFindButton
            // 
            this.bomFindButton.Image = ((System.Drawing.Image)(resources.GetObject("bomFindButton.Image")));
            this.bomFindButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bomFindButton.Location = new System.Drawing.Point(174, 2);
            this.bomFindButton.Name = "bomFindButton";
            this.bomFindButton.Padding = new System.Windows.Forms.Padding(2, 0, 0, 0);
            this.bomFindButton.Size = new System.Drawing.Size(86, 24);
            this.bomFindButton.TabIndex = 5;
            this.bomFindButton.Text = "     Find";
            this.bomFindButton.UseVisualStyleBackColor = true;
            this.bomFindButton.Click += new System.EventHandler(this.bomFindButton_Click);
            // 
            // bomNameEdit
            // 
            this.bomNameEdit.EditValue = "";
            this.bomNameEdit.Location = new System.Drawing.Point(56, 83);
            this.bomNameEdit.Name = "bomNameEdit";
            this.bomNameEdit.Properties.Appearance.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bomNameEdit.Properties.Appearance.Options.UseFont = true;
            this.bomNameEdit.Properties.MaxLength = 200;
            this.bomNameEdit.Size = new System.Drawing.Size(204, 22);
            this.bomNameEdit.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(2, 82);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 22);
            this.label4.TabIndex = 83;
            this.label4.Text = "Name";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // CtrlEditBom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Name = "CtrlEditBom";
            this.Size = new System.Drawing.Size(820, 568);
            this.Load += new System.EventHandler(this.CtrlEditBom_Load);
            this.Enter += new System.EventHandler(this.CtrlEditBom_Enter);
            this.Resize += new System.EventHandler(this.CtrlEditBom_Resize);
            this.bgPanel.ResumeLayout(false);
            this.reportPanel.ResumeLayout(false);
            this.bomTab.ResumeLayout(false);
            this.bomProductPage.ResumeLayout(false);
            this.bomSplit.Panel1.ResumeLayout(false);
            this.bomSplit.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bomSplit)).EndInit();
            this.bomSplit.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.productGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productValidCheckEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.partGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.partGridView)).EndInit();
            this.bomExcelPage.ResumeLayout(false);
            this.bomMessgaePage.ResumeLayout(false);
            this.bomMessgaePage.PerformLayout();
            this.viewSplit.Panel1.ResumeLayout(false);
            this.viewSplit.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.viewSplit)).EndInit();
            this.viewSplit.ResumeLayout(false);
            this.gridPanel.ResumeLayout(false);
            this.gridPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bomGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bomGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bomNameEdit.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Ulee.Controls.UlPanel reportPanel;
        private System.Windows.Forms.SplitContainer viewSplit;
        private Ulee.Controls.UlPanel gridPanel;
        private System.Windows.Forms.Label label19;
        private DevExpress.XtraGrid.GridControl bomGrid;
        private DevExpress.XtraGrid.Views.Grid.GridView bomGridView;
        private DevExpress.XtraGrid.Columns.GridColumn bomRegTimeColumn;
        private DevExpress.XtraGrid.Columns.GridColumn bomAreaColumn;
        private DevExpress.XtraGrid.Columns.GridColumn bomFNameColumn;
        private System.Windows.Forms.Button bomFindButton;
        public DevExpress.XtraEditors.TextEdit bomNameEdit;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button bomResetButton;
        private System.Windows.Forms.ComboBox bomAreaCombo;
        private System.Windows.Forms.DateTimePicker bomToDateEdit;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox bomDateCheck;
        private System.Windows.Forms.DateTimePicker bomFromDateEdit;
        private System.Windows.Forms.TabControl bomTab;
        private System.Windows.Forms.TabPage bomProductPage;
        private System.Windows.Forms.SplitContainer bomSplit;
        private DevExpress.XtraGrid.GridControl productGrid;
        private DevExpress.XtraGrid.Views.Grid.GridView productGridView;
        private DevExpress.XtraGrid.Columns.GridColumn productCodeColumn;
        private DevExpress.XtraGrid.Columns.GridColumn productNameColumn;
        private DevExpress.XtraGrid.Columns.GridColumn productImageColumn;
        private DevExpress.XtraGrid.GridControl partGrid;
        private DevExpress.XtraGrid.Views.Grid.GridView partGridView;
        private DevExpress.XtraGrid.Columns.GridColumn partNameColumn;
        private DevExpress.XtraGrid.Columns.GridColumn partMaterialNoColumn;
        private DevExpress.XtraGrid.Columns.GridColumn partMaterialNameColumn;
        private System.Windows.Forms.TabPage bomExcelPage;
        private DevExpress.XtraSpreadsheet.SpreadsheetControl bomExcelSheet;
        private DevExpress.XtraGrid.Columns.GridColumn productJobNoColumn;
        private DevExpress.XtraGrid.Columns.GridColumn productValidColumn;
        private DevExpress.XtraGrid.Columns.GridColumn partJobNoColumn;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit productValidCheckEdit;
        private System.Windows.Forms.TabPage bomMessgaePage;
        private System.Windows.Forms.TextBox totalLogEdit;
    }
}
