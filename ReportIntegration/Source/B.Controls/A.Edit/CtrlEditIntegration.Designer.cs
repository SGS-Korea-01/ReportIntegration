namespace Sgs.ReportIntegration
{
    partial class CtrlEditIntegration
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CtrlEditIntegration));
            this.viewSplit = new System.Windows.Forms.SplitContainer();
            this.gridPanel = new Ulee.Controls.UlPanel();
            this.jobNoEdit = new DevExpress.XtraEditors.TextEdit();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.toDateEdit = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.dateCheck = new System.Windows.Forms.CheckBox();
            this.fromDateEdit = new System.Windows.Forms.DateTimePicker();
            this.areaCombo = new System.Windows.Forms.ComboBox();
            this.resetButton = new System.Windows.Forms.Button();
            this.integrationGrid = new DevExpress.XtraGrid.GridControl();
            this.integrationGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.integRegTimeColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.integAreaColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.integItemNoColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.integJobNoColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.integProductColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.physicalCheckEdit = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.findButton = new System.Windows.Forms.Button();
            this.itemNoEdit = new DevExpress.XtraEditors.TextEdit();
            this.label4 = new System.Windows.Forms.Label();
            this.reportPanel = new Ulee.Controls.UlPanel();
            this.ulPanel1 = new Ulee.Controls.UlPanel();
            this.areaPanel = new Ulee.Controls.UlPanel();
            this.reportPagePanel = new Ulee.Controls.UlPanel();
            this.issuedDateEdit = new DevExpress.XtraEditors.TextEdit();
            this.label2 = new System.Windows.Forms.Label();
            this.reportNoEdit = new DevExpress.XtraEditors.TextEdit();
            this.label1 = new System.Windows.Forms.Label();
            this.bgPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.viewSplit)).BeginInit();
            this.viewSplit.Panel1.SuspendLayout();
            this.viewSplit.Panel2.SuspendLayout();
            this.viewSplit.SuspendLayout();
            this.gridPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.jobNoEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.integrationGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.integrationGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.physicalCheckEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemNoEdit.Properties)).BeginInit();
            this.reportPanel.SuspendLayout();
            this.ulPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.issuedDateEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reportNoEdit.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // bgPanel
            // 
            this.bgPanel.BevelOuter = Ulee.Controls.EUlBevelStyle.None;
            this.bgPanel.Controls.Add(this.viewSplit);
            this.bgPanel.Size = new System.Drawing.Size(820, 568);
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
            this.viewSplit.Panel2MinSize = 400;
            this.viewSplit.Size = new System.Drawing.Size(820, 568);
            this.viewSplit.SplitterDistance = 260;
            this.viewSplit.TabIndex = 1;
            this.viewSplit.TabStop = false;
            // 
            // gridPanel
            // 
            this.gridPanel.BevelInner = Ulee.Controls.EUlBevelStyle.None;
            this.gridPanel.BevelOuter = Ulee.Controls.EUlBevelStyle.None;
            this.gridPanel.Controls.Add(this.jobNoEdit);
            this.gridPanel.Controls.Add(this.label6);
            this.gridPanel.Controls.Add(this.label5);
            this.gridPanel.Controls.Add(this.toDateEdit);
            this.gridPanel.Controls.Add(this.label3);
            this.gridPanel.Controls.Add(this.dateCheck);
            this.gridPanel.Controls.Add(this.fromDateEdit);
            this.gridPanel.Controls.Add(this.areaCombo);
            this.gridPanel.Controls.Add(this.resetButton);
            this.gridPanel.Controls.Add(this.integrationGrid);
            this.gridPanel.Controls.Add(this.findButton);
            this.gridPanel.Controls.Add(this.itemNoEdit);
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
            // jobNoEdit
            // 
            this.jobNoEdit.EditValue = "";
            this.jobNoEdit.Location = new System.Drawing.Point(60, 84);
            this.jobNoEdit.Name = "jobNoEdit";
            this.jobNoEdit.Properties.Appearance.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.jobNoEdit.Properties.Appearance.Options.UseFont = true;
            this.jobNoEdit.Properties.AppearanceFocused.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.jobNoEdit.Properties.AppearanceFocused.Options.UseFont = true;
            this.jobNoEdit.Properties.AppearanceReadOnly.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.jobNoEdit.Properties.AppearanceReadOnly.Options.UseFont = true;
            this.jobNoEdit.Properties.MaxLength = 20;
            this.jobNoEdit.Size = new System.Drawing.Size(200, 22);
            this.jobNoEdit.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(1, 83);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 22);
            this.label6.TabIndex = 104;
            this.label6.Text = "Job No.";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(2, 54);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 22);
            this.label5.TabIndex = 102;
            this.label5.Text = "Area";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // toDateEdit
            // 
            this.toDateEdit.CustomFormat = "yyyy-MM-dd";
            this.toDateEdit.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toDateEdit.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.toDateEdit.Location = new System.Drawing.Point(60, 29);
            this.toDateEdit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.toDateEdit.Name = "toDateEdit";
            this.toDateEdit.Size = new System.Drawing.Size(102, 21);
            this.toDateEdit.TabIndex = 2;
            this.toDateEdit.ValueChanged += new System.EventHandler(this.toDateEdit_ValueChanged);
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
            // dateCheck
            // 
            this.dateCheck.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateCheck.Location = new System.Drawing.Point(4, 5);
            this.dateCheck.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dateCheck.Name = "dateCheck";
            this.dateCheck.Size = new System.Drawing.Size(52, 19);
            this.dateCheck.TabIndex = 0;
            this.dateCheck.Tag = "";
            this.dateCheck.Text = "Date";
            this.dateCheck.UseVisualStyleBackColor = true;
            // 
            // fromDateEdit
            // 
            this.fromDateEdit.CustomFormat = "yyyy-MM-dd";
            this.fromDateEdit.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fromDateEdit.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.fromDateEdit.Location = new System.Drawing.Point(60, 3);
            this.fromDateEdit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.fromDateEdit.Name = "fromDateEdit";
            this.fromDateEdit.Size = new System.Drawing.Size(102, 21);
            this.fromDateEdit.TabIndex = 1;
            this.fromDateEdit.ValueChanged += new System.EventHandler(this.fromDateEdit_ValueChanged);
            // 
            // areaCombo
            // 
            this.areaCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.areaCombo.FormattingEnabled = true;
            this.areaCombo.Location = new System.Drawing.Point(60, 55);
            this.areaCombo.Name = "areaCombo";
            this.areaCombo.Size = new System.Drawing.Size(54, 23);
            this.areaCombo.TabIndex = 4;
            // 
            // resetButton
            // 
            this.resetButton.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resetButton.Image = ((System.Drawing.Image)(resources.GetObject("resetButton.Image")));
            this.resetButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.resetButton.Location = new System.Drawing.Point(174, 28);
            this.resetButton.Name = "resetButton";
            this.resetButton.Padding = new System.Windows.Forms.Padding(2, 0, 0, 0);
            this.resetButton.Size = new System.Drawing.Size(86, 24);
            this.resetButton.TabIndex = 8;
            this.resetButton.Text = "     Reset";
            this.resetButton.UseVisualStyleBackColor = true;
            this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
            // 
            // integrationGrid
            // 
            this.integrationGrid.Location = new System.Drawing.Point(0, 113);
            this.integrationGrid.MainView = this.integrationGridView;
            this.integrationGrid.Name = "integrationGrid";
            this.integrationGrid.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.physicalCheckEdit});
            this.integrationGrid.Size = new System.Drawing.Size(260, 455);
            this.integrationGrid.TabIndex = 9;
            this.integrationGrid.TabStop = false;
            this.integrationGrid.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.integrationGridView});
            // 
            // integrationGridView
            // 
            this.integrationGridView.Appearance.FixedLine.Font = new System.Drawing.Font("Arial", 9F);
            this.integrationGridView.Appearance.FixedLine.Options.UseFont = true;
            this.integrationGridView.Appearance.FocusedCell.Font = new System.Drawing.Font("Arial", 9F);
            this.integrationGridView.Appearance.FocusedCell.Options.UseFont = true;
            this.integrationGridView.Appearance.FocusedRow.Font = new System.Drawing.Font("Arial", 9F);
            this.integrationGridView.Appearance.FocusedRow.Options.UseFont = true;
            this.integrationGridView.Appearance.HeaderPanel.Font = new System.Drawing.Font("Arial", 9F);
            this.integrationGridView.Appearance.HeaderPanel.Options.UseFont = true;
            this.integrationGridView.Appearance.HideSelectionRow.Font = new System.Drawing.Font("Arial", 9F);
            this.integrationGridView.Appearance.HideSelectionRow.Options.UseFont = true;
            this.integrationGridView.Appearance.OddRow.Font = new System.Drawing.Font("Arial", 9F);
            this.integrationGridView.Appearance.OddRow.Options.UseFont = true;
            this.integrationGridView.Appearance.Preview.Font = new System.Drawing.Font("Arial", 9F);
            this.integrationGridView.Appearance.Preview.Options.UseFont = true;
            this.integrationGridView.Appearance.Row.Font = new System.Drawing.Font("Arial", 9F);
            this.integrationGridView.Appearance.Row.Options.UseFont = true;
            this.integrationGridView.Appearance.SelectedRow.Font = new System.Drawing.Font("Arial", 9F);
            this.integrationGridView.Appearance.SelectedRow.Options.UseFont = true;
            this.integrationGridView.Appearance.ViewCaption.Font = new System.Drawing.Font("Arial", 9F);
            this.integrationGridView.Appearance.ViewCaption.Options.UseFont = true;
            this.integrationGridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.integRegTimeColumn,
            this.integAreaColumn,
            this.integItemNoColumn,
            this.integJobNoColumn,
            this.integProductColumn});
            this.integrationGridView.CustomizationFormBounds = new System.Drawing.Rectangle(2884, 580, 210, 186);
            this.integrationGridView.GridControl = this.integrationGrid;
            this.integrationGridView.Name = "integrationGridView";
            this.integrationGridView.OptionsBehavior.Editable = false;
            this.integrationGridView.OptionsBehavior.ReadOnly = true;
            this.integrationGridView.OptionsFilter.AllowAutoFilterConditionChange = DevExpress.Utils.DefaultBoolean.False;
            this.integrationGridView.OptionsFilter.AllowFilterEditor = false;
            this.integrationGridView.OptionsView.ColumnAutoWidth = false;
            this.integrationGridView.OptionsView.ShowGroupPanel = false;
            this.integrationGridView.OptionsView.ShowIndicator = false;
            this.integrationGridView.Tag = 1;
            this.integrationGridView.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.integrationGridView_FocusedRowChanged);
            // 
            // integRegTimeColumn
            // 
            this.integRegTimeColumn.AppearanceCell.Font = new System.Drawing.Font("Arial", 9F);
            this.integRegTimeColumn.AppearanceCell.Options.UseFont = true;
            this.integRegTimeColumn.AppearanceCell.Options.UseTextOptions = true;
            this.integRegTimeColumn.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.integRegTimeColumn.AppearanceHeader.Font = new System.Drawing.Font("Arial", 9F);
            this.integRegTimeColumn.AppearanceHeader.Options.UseFont = true;
            this.integRegTimeColumn.AppearanceHeader.Options.UseTextOptions = true;
            this.integRegTimeColumn.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.integRegTimeColumn.Caption = "DateTime";
            this.integRegTimeColumn.FieldName = "regtime";
            this.integRegTimeColumn.MaxWidth = 110;
            this.integRegTimeColumn.MinWidth = 110;
            this.integRegTimeColumn.Name = "integRegTimeColumn";
            this.integRegTimeColumn.OptionsColumn.AllowEdit = false;
            this.integRegTimeColumn.OptionsColumn.AllowFocus = false;
            this.integRegTimeColumn.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.integRegTimeColumn.OptionsColumn.AllowIncrementalSearch = false;
            this.integRegTimeColumn.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.integRegTimeColumn.OptionsColumn.AllowMove = false;
            this.integRegTimeColumn.OptionsColumn.AllowShowHide = false;
            this.integRegTimeColumn.OptionsColumn.AllowSize = false;
            this.integRegTimeColumn.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.True;
            this.integRegTimeColumn.OptionsColumn.ImmediateUpdateRowPosition = DevExpress.Utils.DefaultBoolean.False;
            this.integRegTimeColumn.OptionsColumn.Printable = DevExpress.Utils.DefaultBoolean.False;
            this.integRegTimeColumn.OptionsColumn.ReadOnly = true;
            this.integRegTimeColumn.OptionsColumn.TabStop = false;
            this.integRegTimeColumn.OptionsFilter.AllowAutoFilter = false;
            this.integRegTimeColumn.OptionsFilter.AllowFilter = false;
            this.integRegTimeColumn.Visible = true;
            this.integRegTimeColumn.VisibleIndex = 0;
            this.integRegTimeColumn.Width = 110;
            // 
            // integAreaColumn
            // 
            this.integAreaColumn.AppearanceCell.Font = new System.Drawing.Font("Arial", 9F);
            this.integAreaColumn.AppearanceCell.Options.UseFont = true;
            this.integAreaColumn.AppearanceCell.Options.UseTextOptions = true;
            this.integAreaColumn.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.integAreaColumn.AppearanceHeader.Font = new System.Drawing.Font("Arial", 9F);
            this.integAreaColumn.AppearanceHeader.Options.UseFont = true;
            this.integAreaColumn.AppearanceHeader.Options.UseTextOptions = true;
            this.integAreaColumn.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.integAreaColumn.Caption = "Area";
            this.integAreaColumn.FieldName = "areano";
            this.integAreaColumn.MaxWidth = 48;
            this.integAreaColumn.MinWidth = 48;
            this.integAreaColumn.Name = "integAreaColumn";
            this.integAreaColumn.OptionsColumn.AllowEdit = false;
            this.integAreaColumn.OptionsColumn.AllowFocus = false;
            this.integAreaColumn.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.integAreaColumn.OptionsColumn.AllowIncrementalSearch = false;
            this.integAreaColumn.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.integAreaColumn.OptionsColumn.AllowMove = false;
            this.integAreaColumn.OptionsColumn.AllowShowHide = false;
            this.integAreaColumn.OptionsColumn.AllowSize = false;
            this.integAreaColumn.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.True;
            this.integAreaColumn.OptionsColumn.FixedWidth = true;
            this.integAreaColumn.OptionsColumn.ImmediateUpdateRowPosition = DevExpress.Utils.DefaultBoolean.False;
            this.integAreaColumn.OptionsColumn.Printable = DevExpress.Utils.DefaultBoolean.False;
            this.integAreaColumn.OptionsColumn.ReadOnly = true;
            this.integAreaColumn.OptionsFilter.AllowAutoFilter = false;
            this.integAreaColumn.OptionsFilter.AllowFilter = false;
            this.integAreaColumn.Visible = true;
            this.integAreaColumn.VisibleIndex = 1;
            this.integAreaColumn.Width = 48;
            // 
            // integItemNoColumn
            // 
            this.integItemNoColumn.AppearanceCell.Font = new System.Drawing.Font("Arial", 9F);
            this.integItemNoColumn.AppearanceCell.Options.UseFont = true;
            this.integItemNoColumn.AppearanceHeader.Font = new System.Drawing.Font("Arial", 9F);
            this.integItemNoColumn.AppearanceHeader.Options.UseFont = true;
            this.integItemNoColumn.Caption = "Item No.";
            this.integItemNoColumn.FieldName = "itemno";
            this.integItemNoColumn.MaxWidth = 92;
            this.integItemNoColumn.MinWidth = 92;
            this.integItemNoColumn.Name = "integItemNoColumn";
            this.integItemNoColumn.OptionsColumn.AllowEdit = false;
            this.integItemNoColumn.OptionsColumn.AllowFocus = false;
            this.integItemNoColumn.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.integItemNoColumn.OptionsColumn.AllowIncrementalSearch = false;
            this.integItemNoColumn.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.integItemNoColumn.OptionsColumn.AllowMove = false;
            this.integItemNoColumn.OptionsColumn.AllowShowHide = false;
            this.integItemNoColumn.OptionsColumn.AllowSize = false;
            this.integItemNoColumn.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.True;
            this.integItemNoColumn.OptionsColumn.FixedWidth = true;
            this.integItemNoColumn.OptionsColumn.ReadOnly = true;
            this.integItemNoColumn.OptionsFilter.AllowAutoFilter = false;
            this.integItemNoColumn.OptionsFilter.AllowFilter = false;
            this.integItemNoColumn.Visible = true;
            this.integItemNoColumn.VisibleIndex = 2;
            this.integItemNoColumn.Width = 92;
            // 
            // integJobNoColumn
            // 
            this.integJobNoColumn.AppearanceCell.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.integJobNoColumn.AppearanceCell.Options.UseFont = true;
            this.integJobNoColumn.AppearanceHeader.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.integJobNoColumn.AppearanceHeader.Options.UseFont = true;
            this.integJobNoColumn.Caption = "Job No.";
            this.integJobNoColumn.FieldName = "jobno";
            this.integJobNoColumn.MaxWidth = 92;
            this.integJobNoColumn.MinWidth = 92;
            this.integJobNoColumn.Name = "integJobNoColumn";
            this.integJobNoColumn.OptionsColumn.AllowEdit = false;
            this.integJobNoColumn.OptionsColumn.AllowFocus = false;
            this.integJobNoColumn.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.integJobNoColumn.OptionsColumn.AllowIncrementalSearch = false;
            this.integJobNoColumn.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.integJobNoColumn.OptionsColumn.AllowMove = false;
            this.integJobNoColumn.OptionsColumn.AllowShowHide = false;
            this.integJobNoColumn.OptionsColumn.AllowSize = false;
            this.integJobNoColumn.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.True;
            this.integJobNoColumn.OptionsColumn.FixedWidth = true;
            this.integJobNoColumn.OptionsColumn.ReadOnly = true;
            this.integJobNoColumn.OptionsFilter.AllowAutoFilter = false;
            this.integJobNoColumn.OptionsFilter.AllowFilter = false;
            this.integJobNoColumn.Visible = true;
            this.integJobNoColumn.VisibleIndex = 3;
            this.integJobNoColumn.Width = 92;
            // 
            // integProductColumn
            // 
            this.integProductColumn.AppearanceCell.Font = new System.Drawing.Font("Arial", 9F);
            this.integProductColumn.AppearanceCell.Options.UseFont = true;
            this.integProductColumn.AppearanceHeader.Font = new System.Drawing.Font("Arial", 9F);
            this.integProductColumn.AppearanceHeader.Options.UseFont = true;
            this.integProductColumn.Caption = "Name";
            this.integProductColumn.FieldName = "name";
            this.integProductColumn.MinWidth = 100;
            this.integProductColumn.Name = "integProductColumn";
            this.integProductColumn.OptionsColumn.AllowEdit = false;
            this.integProductColumn.OptionsColumn.AllowFocus = false;
            this.integProductColumn.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.integProductColumn.OptionsColumn.AllowIncrementalSearch = false;
            this.integProductColumn.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.integProductColumn.OptionsColumn.AllowMove = false;
            this.integProductColumn.OptionsColumn.AllowShowHide = false;
            this.integProductColumn.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.True;
            this.integProductColumn.OptionsColumn.ReadOnly = true;
            this.integProductColumn.OptionsFilter.AllowAutoFilter = false;
            this.integProductColumn.OptionsFilter.AllowFilter = false;
            this.integProductColumn.Visible = true;
            this.integProductColumn.VisibleIndex = 4;
            this.integProductColumn.Width = 160;
            // 
            // physicalCheckEdit
            // 
            this.physicalCheckEdit.Appearance.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.physicalCheckEdit.Appearance.Options.UseFont = true;
            this.physicalCheckEdit.Appearance.Options.UseTextOptions = true;
            this.physicalCheckEdit.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.physicalCheckEdit.AppearanceFocused.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.physicalCheckEdit.AppearanceFocused.Options.UseFont = true;
            this.physicalCheckEdit.AppearanceFocused.Options.UseTextOptions = true;
            this.physicalCheckEdit.AppearanceFocused.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.physicalCheckEdit.AppearanceReadOnly.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.physicalCheckEdit.AppearanceReadOnly.Options.UseFont = true;
            this.physicalCheckEdit.AppearanceReadOnly.Options.UseTextOptions = true;
            this.physicalCheckEdit.AppearanceReadOnly.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.physicalCheckEdit.AutoHeight = false;
            this.physicalCheckEdit.Name = "physicalCheckEdit";
            this.physicalCheckEdit.ReadOnly = true;
            this.physicalCheckEdit.ValueChecked = 1;
            this.physicalCheckEdit.ValueUnchecked = 0;
            // 
            // findButton
            // 
            this.findButton.Image = ((System.Drawing.Image)(resources.GetObject("findButton.Image")));
            this.findButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.findButton.Location = new System.Drawing.Point(174, 2);
            this.findButton.Name = "findButton";
            this.findButton.Padding = new System.Windows.Forms.Padding(2, 0, 0, 0);
            this.findButton.Size = new System.Drawing.Size(86, 24);
            this.findButton.TabIndex = 7;
            this.findButton.Text = "     Find";
            this.findButton.UseVisualStyleBackColor = true;
            this.findButton.Click += new System.EventHandler(this.findButton_Click);
            // 
            // itemNoEdit
            // 
            this.itemNoEdit.EditValue = "";
            this.itemNoEdit.Location = new System.Drawing.Point(174, 55);
            this.itemNoEdit.Name = "itemNoEdit";
            this.itemNoEdit.Properties.Appearance.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itemNoEdit.Properties.Appearance.Options.UseFont = true;
            this.itemNoEdit.Properties.AppearanceFocused.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itemNoEdit.Properties.AppearanceFocused.Options.UseFont = true;
            this.itemNoEdit.Properties.AppearanceReadOnly.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itemNoEdit.Properties.AppearanceReadOnly.Options.UseFont = true;
            this.itemNoEdit.Properties.MaxLength = 20;
            this.itemNoEdit.Size = new System.Drawing.Size(86, 22);
            this.itemNoEdit.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(120, 54);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 22);
            this.label4.TabIndex = 83;
            this.label4.Text = "Item No.";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // reportPanel
            // 
            this.reportPanel.BevelInner = Ulee.Controls.EUlBevelStyle.None;
            this.reportPanel.BevelOuter = Ulee.Controls.EUlBevelStyle.None;
            this.reportPanel.Controls.Add(this.ulPanel1);
            this.reportPanel.Controls.Add(this.reportPagePanel);
            this.reportPanel.Controls.Add(this.issuedDateEdit);
            this.reportPanel.Controls.Add(this.label2);
            this.reportPanel.Controls.Add(this.reportNoEdit);
            this.reportPanel.Controls.Add(this.label1);
            this.reportPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reportPanel.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.reportPanel.Resize += new System.EventHandler(this.reportPanel_Resize);
            // 
            // ulPanel1
            // 
            this.ulPanel1.BackColor = System.Drawing.Color.Black;
            this.ulPanel1.BevelInner = Ulee.Controls.EUlBevelStyle.None;
            this.ulPanel1.BevelOuter = Ulee.Controls.EUlBevelStyle.Lowered;
            this.ulPanel1.Controls.Add(this.areaPanel);
            this.ulPanel1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ulPanel1.ForeColor = System.Drawing.Color.White;
            this.ulPanel1.InnerColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(160)))), ((int)(((byte)(160)))));
            this.ulPanel1.InnerColor2 = System.Drawing.Color.White;
            this.ulPanel1.Location = new System.Drawing.Point(0, 0);
            this.ulPanel1.Name = "ulPanel1";
            this.ulPanel1.OuterColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(160)))), ((int)(((byte)(160)))));
            this.ulPanel1.OuterColor2 = System.Drawing.Color.White;
            this.ulPanel1.Size = new System.Drawing.Size(70, 26);
            this.ulPanel1.Spacing = 0;
            this.ulPanel1.TabIndex = 90;
            this.ulPanel1.TextHAlign = Ulee.Controls.EUlHoriAlign.Center;
            this.ulPanel1.TextVAlign = Ulee.Controls.EUlVertAlign.Middle;
            // 
            // areaPanel
            // 
            this.areaPanel.BackColor = System.Drawing.Color.Black;
            this.areaPanel.BevelInner = Ulee.Controls.EUlBevelStyle.None;
            this.areaPanel.BevelOuter = Ulee.Controls.EUlBevelStyle.None;
            this.areaPanel.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.areaPanel.ForeColor = System.Drawing.Color.White;
            this.areaPanel.InnerColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(160)))), ((int)(((byte)(160)))));
            this.areaPanel.InnerColor2 = System.Drawing.Color.White;
            this.areaPanel.Location = new System.Drawing.Point(2, 2);
            this.areaPanel.Name = "areaPanel";
            this.areaPanel.OuterColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(160)))), ((int)(((byte)(160)))));
            this.areaPanel.OuterColor2 = System.Drawing.Color.White;
            this.areaPanel.Size = new System.Drawing.Size(66, 22);
            this.areaPanel.Spacing = 0;
            this.areaPanel.TabIndex = 89;
            this.areaPanel.Text = "None";
            this.areaPanel.TextHAlign = Ulee.Controls.EUlHoriAlign.Center;
            this.areaPanel.TextVAlign = Ulee.Controls.EUlVertAlign.Middle;
            // 
            // reportPagePanel
            // 
            this.reportPagePanel.BevelInner = Ulee.Controls.EUlBevelStyle.None;
            this.reportPagePanel.BevelOuter = Ulee.Controls.EUlBevelStyle.None;
            this.reportPagePanel.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reportPagePanel.InnerColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(160)))), ((int)(((byte)(160)))));
            this.reportPagePanel.InnerColor2 = System.Drawing.Color.White;
            this.reportPagePanel.Location = new System.Drawing.Point(0, 30);
            this.reportPagePanel.Name = "reportPagePanel";
            this.reportPagePanel.OuterColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(160)))), ((int)(((byte)(160)))));
            this.reportPagePanel.OuterColor2 = System.Drawing.Color.White;
            this.reportPagePanel.Size = new System.Drawing.Size(556, 538);
            this.reportPagePanel.Spacing = 0;
            this.reportPagePanel.TabIndex = 88;
            this.reportPagePanel.Text = "None";
            this.reportPagePanel.TextHAlign = Ulee.Controls.EUlHoriAlign.Center;
            this.reportPagePanel.TextVAlign = Ulee.Controls.EUlVertAlign.Middle;
            // 
            // issuedDateEdit
            // 
            this.issuedDateEdit.EditValue = "";
            this.issuedDateEdit.Location = new System.Drawing.Point(476, 2);
            this.issuedDateEdit.Name = "issuedDateEdit";
            this.issuedDateEdit.Properties.Appearance.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.issuedDateEdit.Properties.Appearance.Options.UseFont = true;
            this.issuedDateEdit.Properties.AppearanceDisabled.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.issuedDateEdit.Properties.AppearanceDisabled.Options.UseFont = true;
            this.issuedDateEdit.Properties.AppearanceFocused.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.issuedDateEdit.Properties.AppearanceFocused.Options.UseFont = true;
            this.issuedDateEdit.Properties.AppearanceReadOnly.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.issuedDateEdit.Properties.AppearanceReadOnly.Options.UseFont = true;
            this.issuedDateEdit.Properties.ReadOnly = true;
            this.issuedDateEdit.Size = new System.Drawing.Size(80, 22);
            this.issuedDateEdit.TabIndex = 86;
            this.issuedDateEdit.TabStop = false;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(398, 1);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 22);
            this.label2.TabIndex = 87;
            this.label2.Text = "Issued Date";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // reportNoEdit
            // 
            this.reportNoEdit.EditValue = "";
            this.reportNoEdit.Location = new System.Drawing.Point(181, 2);
            this.reportNoEdit.Name = "reportNoEdit";
            this.reportNoEdit.Properties.Appearance.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reportNoEdit.Properties.Appearance.Options.UseFont = true;
            this.reportNoEdit.Properties.AppearanceDisabled.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reportNoEdit.Properties.AppearanceDisabled.Options.UseFont = true;
            this.reportNoEdit.Properties.AppearanceFocused.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reportNoEdit.Properties.AppearanceFocused.Options.UseFont = true;
            this.reportNoEdit.Properties.AppearanceReadOnly.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reportNoEdit.Properties.AppearanceReadOnly.Options.UseFont = true;
            this.reportNoEdit.Properties.ReadOnly = true;
            this.reportNoEdit.Size = new System.Drawing.Size(200, 22);
            this.reportNoEdit.TabIndex = 0;
            this.reportNoEdit.TabStop = false;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(85, 1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 22);
            this.label1.TabIndex = 85;
            this.label1.Text = "Test Report No.";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // CtrlEditIntegration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.Name = "CtrlEditIntegration";
            this.Size = new System.Drawing.Size(820, 568);
            this.Load += new System.EventHandler(this.CtrlEditIntegration_Load);
            this.Enter += new System.EventHandler(this.CtrlEditIntegration_Enter);
            this.bgPanel.ResumeLayout(false);
            this.viewSplit.Panel1.ResumeLayout(false);
            this.viewSplit.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.viewSplit)).EndInit();
            this.viewSplit.ResumeLayout(false);
            this.gridPanel.ResumeLayout(false);
            this.gridPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.jobNoEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.integrationGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.integrationGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.physicalCheckEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemNoEdit.Properties)).EndInit();
            this.reportPanel.ResumeLayout(false);
            this.ulPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.issuedDateEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reportNoEdit.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.SplitContainer viewSplit;
        private Ulee.Controls.UlPanel gridPanel;
        public DevExpress.XtraEditors.TextEdit jobNoEdit;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker toDateEdit;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox dateCheck;
        private System.Windows.Forms.DateTimePicker fromDateEdit;
        private System.Windows.Forms.ComboBox areaCombo;
        private System.Windows.Forms.Button resetButton;
        private DevExpress.XtraGrid.GridControl integrationGrid;
        private DevExpress.XtraGrid.Views.Grid.GridView integrationGridView;
        private DevExpress.XtraGrid.Columns.GridColumn integRegTimeColumn;
        private DevExpress.XtraGrid.Columns.GridColumn integAreaColumn;
        private DevExpress.XtraGrid.Columns.GridColumn integItemNoColumn;
        private DevExpress.XtraGrid.Columns.GridColumn integJobNoColumn;
        private DevExpress.XtraGrid.Columns.GridColumn integProductColumn;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit physicalCheckEdit;
        private System.Windows.Forms.Button findButton;
        public DevExpress.XtraEditors.TextEdit itemNoEdit;
        private System.Windows.Forms.Label label4;
        private Ulee.Controls.UlPanel reportPanel;
        private Ulee.Controls.UlPanel ulPanel1;
        private Ulee.Controls.UlPanel areaPanel;
        private Ulee.Controls.UlPanel reportPagePanel;
        public DevExpress.XtraEditors.TextEdit issuedDateEdit;
        private System.Windows.Forms.Label label2;
        public DevExpress.XtraEditors.TextEdit reportNoEdit;
        private System.Windows.Forms.Label label1;
    }
}
