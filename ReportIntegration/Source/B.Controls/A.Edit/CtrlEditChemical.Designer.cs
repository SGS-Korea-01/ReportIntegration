namespace Sgs.ReportIntegration
{
    partial class CtrlEditChemical
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CtrlEditChemical));
            this.chemicalCheckEdit = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.viewSplit = new System.Windows.Forms.SplitContainer();
            this.gridPanel = new Ulee.Controls.UlPanel();
            this.jobNoEdit = new DevExpress.XtraEditors.TextEdit();
            this.label6 = new System.Windows.Forms.Label();
            this.approvalCombo = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.toDateEdit = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.dateCheck = new System.Windows.Forms.CheckBox();
            this.fromDateEdit = new System.Windows.Forms.DateTimePicker();
            this.areaCombo = new System.Windows.Forms.ComboBox();
            this.resetButton = new System.Windows.Forms.Button();
            this.label19 = new System.Windows.Forms.Label();
            this.chemicalGrid = new DevExpress.XtraGrid.GridControl();
            this.chemicalGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.chemicalApprovalColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.chemicalItemCheckEdit = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.chemicalRegTimeColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.chemicalAreaColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.chemicalItemNoColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.chemicalJobNoColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.chemicalProductColumn = new DevExpress.XtraGrid.Columns.GridColumn();
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
            ((System.ComponentModel.ISupportInitialize)(this.chemicalCheckEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewSplit)).BeginInit();
            this.viewSplit.Panel1.SuspendLayout();
            this.viewSplit.Panel2.SuspendLayout();
            this.viewSplit.SuspendLayout();
            this.gridPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.jobNoEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chemicalGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chemicalGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chemicalItemCheckEdit)).BeginInit();
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
            // chemicalCheckEdit
            // 
            this.chemicalCheckEdit.Appearance.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chemicalCheckEdit.Appearance.Options.UseFont = true;
            this.chemicalCheckEdit.Appearance.Options.UseTextOptions = true;
            this.chemicalCheckEdit.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.chemicalCheckEdit.AppearanceFocused.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chemicalCheckEdit.AppearanceFocused.Options.UseFont = true;
            this.chemicalCheckEdit.AppearanceFocused.Options.UseTextOptions = true;
            this.chemicalCheckEdit.AppearanceFocused.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.chemicalCheckEdit.AppearanceReadOnly.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chemicalCheckEdit.AppearanceReadOnly.Options.UseFont = true;
            this.chemicalCheckEdit.AppearanceReadOnly.Options.UseTextOptions = true;
            this.chemicalCheckEdit.AppearanceReadOnly.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.chemicalCheckEdit.AutoHeight = false;
            this.chemicalCheckEdit.Name = "chemicalCheckEdit";
            this.chemicalCheckEdit.ReadOnly = true;
            this.chemicalCheckEdit.ValueChecked = 1;
            this.chemicalCheckEdit.ValueUnchecked = 0;
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
            this.gridPanel.Controls.Add(this.approvalCombo);
            this.gridPanel.Controls.Add(this.label5);
            this.gridPanel.Controls.Add(this.toDateEdit);
            this.gridPanel.Controls.Add(this.label3);
            this.gridPanel.Controls.Add(this.dateCheck);
            this.gridPanel.Controls.Add(this.fromDateEdit);
            this.gridPanel.Controls.Add(this.areaCombo);
            this.gridPanel.Controls.Add(this.resetButton);
            this.gridPanel.Controls.Add(this.label19);
            this.gridPanel.Controls.Add(this.chemicalGrid);
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
            this.jobNoEdit.Location = new System.Drawing.Point(174, 84);
            this.jobNoEdit.Name = "jobNoEdit";
            this.jobNoEdit.Properties.Appearance.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.jobNoEdit.Properties.Appearance.Options.UseFont = true;
            this.jobNoEdit.Properties.AppearanceFocused.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.jobNoEdit.Properties.AppearanceFocused.Options.UseFont = true;
            this.jobNoEdit.Properties.AppearanceReadOnly.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.jobNoEdit.Properties.AppearanceReadOnly.Options.UseFont = true;
            this.jobNoEdit.Properties.MaxLength = 20;
            this.jobNoEdit.Size = new System.Drawing.Size(86, 22);
            this.jobNoEdit.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(124, 83);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 22);
            this.label6.TabIndex = 106;
            this.label6.Text = "Job No.";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // approvalCombo
            // 
            this.approvalCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.approvalCombo.FormattingEnabled = true;
            this.approvalCombo.Location = new System.Drawing.Point(64, 55);
            this.approvalCombo.Name = "approvalCombo";
            this.approvalCombo.Size = new System.Drawing.Size(54, 23);
            this.approvalCombo.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(2, 83);
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
            this.toDateEdit.Location = new System.Drawing.Point(64, 29);
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
            this.fromDateEdit.Location = new System.Drawing.Point(64, 3);
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
            this.areaCombo.Location = new System.Drawing.Point(64, 84);
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
            // label19
            // 
            this.label19.Location = new System.Drawing.Point(2, 54);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(56, 22);
            this.label19.TabIndex = 96;
            this.label19.Text = "Approval";
            this.label19.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // chemicalGrid
            // 
            this.chemicalGrid.Location = new System.Drawing.Point(0, 113);
            this.chemicalGrid.MainView = this.chemicalGridView;
            this.chemicalGrid.Name = "chemicalGrid";
            this.chemicalGrid.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.chemicalItemCheckEdit});
            this.chemicalGrid.Size = new System.Drawing.Size(260, 455);
            this.chemicalGrid.TabIndex = 9;
            this.chemicalGrid.TabStop = false;
            this.chemicalGrid.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.chemicalGridView});
            // 
            // chemicalGridView
            // 
            this.chemicalGridView.Appearance.FixedLine.Font = new System.Drawing.Font("Arial", 9F);
            this.chemicalGridView.Appearance.FixedLine.Options.UseFont = true;
            this.chemicalGridView.Appearance.FocusedCell.Font = new System.Drawing.Font("Arial", 9F);
            this.chemicalGridView.Appearance.FocusedCell.Options.UseFont = true;
            this.chemicalGridView.Appearance.FocusedRow.Font = new System.Drawing.Font("Arial", 9F);
            this.chemicalGridView.Appearance.FocusedRow.Options.UseFont = true;
            this.chemicalGridView.Appearance.HeaderPanel.Font = new System.Drawing.Font("Arial", 9F);
            this.chemicalGridView.Appearance.HeaderPanel.Options.UseFont = true;
            this.chemicalGridView.Appearance.HideSelectionRow.Font = new System.Drawing.Font("Arial", 9F);
            this.chemicalGridView.Appearance.HideSelectionRow.Options.UseFont = true;
            this.chemicalGridView.Appearance.OddRow.Font = new System.Drawing.Font("Arial", 9F);
            this.chemicalGridView.Appearance.OddRow.Options.UseFont = true;
            this.chemicalGridView.Appearance.Preview.Font = new System.Drawing.Font("Arial", 9F);
            this.chemicalGridView.Appearance.Preview.Options.UseFont = true;
            this.chemicalGridView.Appearance.Row.Font = new System.Drawing.Font("Arial", 9F);
            this.chemicalGridView.Appearance.Row.Options.UseFont = true;
            this.chemicalGridView.Appearance.SelectedRow.Font = new System.Drawing.Font("Arial", 9F);
            this.chemicalGridView.Appearance.SelectedRow.Options.UseFont = true;
            this.chemicalGridView.Appearance.ViewCaption.Font = new System.Drawing.Font("Arial", 9F);
            this.chemicalGridView.Appearance.ViewCaption.Options.UseFont = true;
            this.chemicalGridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.chemicalApprovalColumn,
            this.chemicalRegTimeColumn,
            this.chemicalAreaColumn,
            this.chemicalItemNoColumn,
            this.chemicalJobNoColumn,
            this.chemicalProductColumn});
            this.chemicalGridView.CustomizationFormBounds = new System.Drawing.Rectangle(2884, 580, 210, 186);
            this.chemicalGridView.GridControl = this.chemicalGrid;
            this.chemicalGridView.Name = "chemicalGridView";
            this.chemicalGridView.OptionsBehavior.Editable = false;
            this.chemicalGridView.OptionsBehavior.ReadOnly = true;
            this.chemicalGridView.OptionsFilter.AllowAutoFilterConditionChange = DevExpress.Utils.DefaultBoolean.False;
            this.chemicalGridView.OptionsFilter.AllowFilterEditor = false;
            this.chemicalGridView.OptionsView.ColumnAutoWidth = false;
            this.chemicalGridView.OptionsView.ShowGroupPanel = false;
            this.chemicalGridView.OptionsView.ShowIndicator = false;
            this.chemicalGridView.Tag = 1;
            this.chemicalGridView.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.chemicalGridView_FocusedRowChanged);
            // 
            // chemicalApprovalColumn
            // 
            this.chemicalApprovalColumn.AppearanceCell.Font = new System.Drawing.Font("Arial", 9F);
            this.chemicalApprovalColumn.AppearanceCell.Options.UseFont = true;
            this.chemicalApprovalColumn.AppearanceCell.Options.UseTextOptions = true;
            this.chemicalApprovalColumn.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.chemicalApprovalColumn.AppearanceHeader.Font = new System.Drawing.Font("Arial", 9F);
            this.chemicalApprovalColumn.AppearanceHeader.Options.UseFont = true;
            this.chemicalApprovalColumn.AppearanceHeader.Options.UseTextOptions = true;
            this.chemicalApprovalColumn.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.chemicalApprovalColumn.Caption = "A";
            this.chemicalApprovalColumn.ColumnEdit = this.chemicalItemCheckEdit;
            this.chemicalApprovalColumn.FieldName = "approval";
            this.chemicalApprovalColumn.MaxWidth = 24;
            this.chemicalApprovalColumn.MinWidth = 24;
            this.chemicalApprovalColumn.Name = "chemicalApprovalColumn";
            this.chemicalApprovalColumn.OptionsColumn.AllowEdit = false;
            this.chemicalApprovalColumn.OptionsColumn.AllowFocus = false;
            this.chemicalApprovalColumn.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.chemicalApprovalColumn.OptionsColumn.AllowIncrementalSearch = false;
            this.chemicalApprovalColumn.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.chemicalApprovalColumn.OptionsColumn.AllowMove = false;
            this.chemicalApprovalColumn.OptionsColumn.AllowShowHide = false;
            this.chemicalApprovalColumn.OptionsColumn.AllowSize = false;
            this.chemicalApprovalColumn.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.chemicalApprovalColumn.OptionsColumn.FixedWidth = true;
            this.chemicalApprovalColumn.OptionsColumn.ReadOnly = true;
            this.chemicalApprovalColumn.OptionsFilter.AllowAutoFilter = false;
            this.chemicalApprovalColumn.OptionsFilter.AllowFilter = false;
            this.chemicalApprovalColumn.Visible = true;
            this.chemicalApprovalColumn.VisibleIndex = 0;
            this.chemicalApprovalColumn.Width = 24;
            // 
            // chemicalItemCheckEdit
            // 
            this.chemicalItemCheckEdit.AutoHeight = false;
            this.chemicalItemCheckEdit.Name = "chemicalItemCheckEdit";
            this.chemicalItemCheckEdit.ValueChecked = 1;
            this.chemicalItemCheckEdit.ValueUnchecked = 0;
            // 
            // chemicalRegTimeColumn
            // 
            this.chemicalRegTimeColumn.AppearanceCell.Font = new System.Drawing.Font("Arial", 9F);
            this.chemicalRegTimeColumn.AppearanceCell.Options.UseFont = true;
            this.chemicalRegTimeColumn.AppearanceCell.Options.UseTextOptions = true;
            this.chemicalRegTimeColumn.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.chemicalRegTimeColumn.AppearanceHeader.Font = new System.Drawing.Font("Arial", 9F);
            this.chemicalRegTimeColumn.AppearanceHeader.Options.UseFont = true;
            this.chemicalRegTimeColumn.AppearanceHeader.Options.UseTextOptions = true;
            this.chemicalRegTimeColumn.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.chemicalRegTimeColumn.Caption = "DateTime";
            this.chemicalRegTimeColumn.FieldName = "regtime";
            this.chemicalRegTimeColumn.MaxWidth = 110;
            this.chemicalRegTimeColumn.MinWidth = 110;
            this.chemicalRegTimeColumn.Name = "chemicalRegTimeColumn";
            this.chemicalRegTimeColumn.OptionsColumn.AllowEdit = false;
            this.chemicalRegTimeColumn.OptionsColumn.AllowFocus = false;
            this.chemicalRegTimeColumn.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.chemicalRegTimeColumn.OptionsColumn.AllowIncrementalSearch = false;
            this.chemicalRegTimeColumn.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.chemicalRegTimeColumn.OptionsColumn.AllowMove = false;
            this.chemicalRegTimeColumn.OptionsColumn.AllowShowHide = false;
            this.chemicalRegTimeColumn.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.True;
            this.chemicalRegTimeColumn.OptionsColumn.ImmediateUpdateRowPosition = DevExpress.Utils.DefaultBoolean.False;
            this.chemicalRegTimeColumn.OptionsColumn.Printable = DevExpress.Utils.DefaultBoolean.False;
            this.chemicalRegTimeColumn.OptionsColumn.ReadOnly = true;
            this.chemicalRegTimeColumn.OptionsColumn.TabStop = false;
            this.chemicalRegTimeColumn.OptionsFilter.AllowAutoFilter = false;
            this.chemicalRegTimeColumn.OptionsFilter.AllowFilter = false;
            this.chemicalRegTimeColumn.Visible = true;
            this.chemicalRegTimeColumn.VisibleIndex = 1;
            this.chemicalRegTimeColumn.Width = 110;
            // 
            // chemicalAreaColumn
            // 
            this.chemicalAreaColumn.AppearanceCell.Font = new System.Drawing.Font("Arial", 9F);
            this.chemicalAreaColumn.AppearanceCell.Options.UseFont = true;
            this.chemicalAreaColumn.AppearanceCell.Options.UseTextOptions = true;
            this.chemicalAreaColumn.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.chemicalAreaColumn.AppearanceHeader.Font = new System.Drawing.Font("Arial", 9F);
            this.chemicalAreaColumn.AppearanceHeader.Options.UseFont = true;
            this.chemicalAreaColumn.AppearanceHeader.Options.UseTextOptions = true;
            this.chemicalAreaColumn.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.chemicalAreaColumn.Caption = "Area";
            this.chemicalAreaColumn.FieldName = "areano";
            this.chemicalAreaColumn.MaxWidth = 48;
            this.chemicalAreaColumn.MinWidth = 48;
            this.chemicalAreaColumn.Name = "chemicalAreaColumn";
            this.chemicalAreaColumn.OptionsColumn.AllowEdit = false;
            this.chemicalAreaColumn.OptionsColumn.AllowFocus = false;
            this.chemicalAreaColumn.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.chemicalAreaColumn.OptionsColumn.AllowIncrementalSearch = false;
            this.chemicalAreaColumn.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.chemicalAreaColumn.OptionsColumn.AllowMove = false;
            this.chemicalAreaColumn.OptionsColumn.AllowShowHide = false;
            this.chemicalAreaColumn.OptionsColumn.AllowSize = false;
            this.chemicalAreaColumn.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.True;
            this.chemicalAreaColumn.OptionsColumn.FixedWidth = true;
            this.chemicalAreaColumn.OptionsColumn.ImmediateUpdateRowPosition = DevExpress.Utils.DefaultBoolean.False;
            this.chemicalAreaColumn.OptionsColumn.Printable = DevExpress.Utils.DefaultBoolean.False;
            this.chemicalAreaColumn.OptionsColumn.ReadOnly = true;
            this.chemicalAreaColumn.OptionsFilter.AllowAutoFilter = false;
            this.chemicalAreaColumn.OptionsFilter.AllowFilter = false;
            this.chemicalAreaColumn.Visible = true;
            this.chemicalAreaColumn.VisibleIndex = 2;
            this.chemicalAreaColumn.Width = 48;
            // 
            // chemicalItemNoColumn
            // 
            this.chemicalItemNoColumn.AppearanceCell.Font = new System.Drawing.Font("Arial", 9F);
            this.chemicalItemNoColumn.AppearanceCell.Options.UseFont = true;
            this.chemicalItemNoColumn.AppearanceHeader.Font = new System.Drawing.Font("Arial", 9F);
            this.chemicalItemNoColumn.AppearanceHeader.Options.UseFont = true;
            this.chemicalItemNoColumn.Caption = "Item No.";
            this.chemicalItemNoColumn.FieldName = "productno";
            this.chemicalItemNoColumn.MaxWidth = 160;
            this.chemicalItemNoColumn.MinWidth = 92;
            this.chemicalItemNoColumn.Name = "chemicalItemNoColumn";
            this.chemicalItemNoColumn.OptionsColumn.AllowEdit = false;
            this.chemicalItemNoColumn.OptionsColumn.AllowFocus = false;
            this.chemicalItemNoColumn.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.chemicalItemNoColumn.OptionsColumn.AllowIncrementalSearch = false;
            this.chemicalItemNoColumn.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.chemicalItemNoColumn.OptionsColumn.AllowMove = false;
            this.chemicalItemNoColumn.OptionsColumn.AllowShowHide = false;
            this.chemicalItemNoColumn.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.True;
            this.chemicalItemNoColumn.OptionsColumn.ReadOnly = true;
            this.chemicalItemNoColumn.OptionsFilter.AllowAutoFilter = false;
            this.chemicalItemNoColumn.OptionsFilter.AllowFilter = false;
            this.chemicalItemNoColumn.Visible = true;
            this.chemicalItemNoColumn.VisibleIndex = 3;
            this.chemicalItemNoColumn.Width = 92;
            // 
            // chemicalJobNoColumn
            // 
            this.chemicalJobNoColumn.AppearanceCell.Font = new System.Drawing.Font("Arial", 9F);
            this.chemicalJobNoColumn.AppearanceCell.Options.UseFont = true;
            this.chemicalJobNoColumn.AppearanceHeader.Font = new System.Drawing.Font("Arial", 9F);
            this.chemicalJobNoColumn.AppearanceHeader.Options.UseFont = true;
            this.chemicalJobNoColumn.Caption = "Job No.";
            this.chemicalJobNoColumn.FieldName = "pk_recno";
            this.chemicalJobNoColumn.MaxWidth = 160;
            this.chemicalJobNoColumn.MinWidth = 92;
            this.chemicalJobNoColumn.Name = "chemicalJobNoColumn";
            this.chemicalJobNoColumn.OptionsColumn.AllowEdit = false;
            this.chemicalJobNoColumn.OptionsColumn.AllowFocus = false;
            this.chemicalJobNoColumn.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.chemicalJobNoColumn.OptionsColumn.AllowIncrementalSearch = false;
            this.chemicalJobNoColumn.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.chemicalJobNoColumn.OptionsColumn.AllowMove = false;
            this.chemicalJobNoColumn.OptionsColumn.AllowShowHide = false;
            this.chemicalJobNoColumn.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.True;
            this.chemicalJobNoColumn.OptionsColumn.ReadOnly = true;
            this.chemicalJobNoColumn.OptionsFilter.AllowAutoFilter = false;
            this.chemicalJobNoColumn.OptionsFilter.AllowFilter = false;
            this.chemicalJobNoColumn.Visible = true;
            this.chemicalJobNoColumn.VisibleIndex = 4;
            this.chemicalJobNoColumn.Width = 92;
            // 
            // chemicalProductColumn
            // 
            this.chemicalProductColumn.AppearanceCell.Font = new System.Drawing.Font("Arial", 9F);
            this.chemicalProductColumn.AppearanceCell.Options.UseFont = true;
            this.chemicalProductColumn.AppearanceHeader.Font = new System.Drawing.Font("Arial", 9F);
            this.chemicalProductColumn.AppearanceHeader.Options.UseFont = true;
            this.chemicalProductColumn.Caption = "Product Name";
            this.chemicalProductColumn.FieldName = "sampledesc";
            this.chemicalProductColumn.MinWidth = 80;
            this.chemicalProductColumn.Name = "chemicalProductColumn";
            this.chemicalProductColumn.OptionsColumn.AllowEdit = false;
            this.chemicalProductColumn.OptionsColumn.AllowFocus = false;
            this.chemicalProductColumn.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.chemicalProductColumn.OptionsColumn.AllowIncrementalSearch = false;
            this.chemicalProductColumn.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.chemicalProductColumn.OptionsColumn.AllowMove = false;
            this.chemicalProductColumn.OptionsColumn.AllowShowHide = false;
            this.chemicalProductColumn.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.True;
            this.chemicalProductColumn.OptionsColumn.ReadOnly = true;
            this.chemicalProductColumn.OptionsFilter.AllowAutoFilter = false;
            this.chemicalProductColumn.OptionsFilter.AllowFilter = false;
            this.chemicalProductColumn.Visible = true;
            this.chemicalProductColumn.VisibleIndex = 5;
            this.chemicalProductColumn.Width = 100;
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
            this.label4.Location = new System.Drawing.Point(124, 54);
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
            // CtrlEditChemical
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Name = "CtrlEditChemical";
            this.Size = new System.Drawing.Size(820, 568);
            this.Load += new System.EventHandler(this.CtrlEditChemical_Load);
            this.Enter += new System.EventHandler(this.CtrlEditChemical_Enter);
            this.bgPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chemicalCheckEdit)).EndInit();
            this.viewSplit.Panel1.ResumeLayout(false);
            this.viewSplit.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.viewSplit)).EndInit();
            this.viewSplit.ResumeLayout(false);
            this.gridPanel.ResumeLayout(false);
            this.gridPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.jobNoEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chemicalGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chemicalGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chemicalItemCheckEdit)).EndInit();
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
        private System.Windows.Forms.ComboBox approvalCombo;
        private System.Windows.Forms.DateTimePicker toDateEdit;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox dateCheck;
        private System.Windows.Forms.DateTimePicker fromDateEdit;
        private System.Windows.Forms.Button resetButton;
        private System.Windows.Forms.Label label19;
        private DevExpress.XtraGrid.GridControl chemicalGrid;
        private DevExpress.XtraGrid.Views.Grid.GridView chemicalGridView;
        private DevExpress.XtraGrid.Columns.GridColumn chemicalApprovalColumn;
        private DevExpress.XtraGrid.Columns.GridColumn chemicalRegTimeColumn;
        private DevExpress.XtraGrid.Columns.GridColumn chemicalAreaColumn;
        private DevExpress.XtraGrid.Columns.GridColumn chemicalItemNoColumn;
        private DevExpress.XtraGrid.Columns.GridColumn chemicalProductColumn;
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
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox areaCombo;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit chemicalCheckEdit;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit chemicalItemCheckEdit;
        public DevExpress.XtraEditors.TextEdit jobNoEdit;
        private System.Windows.Forms.Label label6;
        private DevExpress.XtraGrid.Columns.GridColumn chemicalJobNoColumn;
    }
}
