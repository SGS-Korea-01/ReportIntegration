namespace Sgs.ReportIntegration
{
    partial class CtrlEditPhysical
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CtrlEditPhysical));
            this.viewSplit = new System.Windows.Forms.SplitContainer();
            this.gridPanel = new Ulee.Controls.UlPanel();
            this.toDateEdit = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.dateCheck = new System.Windows.Forms.CheckBox();
            this.fromDateEdit = new System.Windows.Forms.DateTimePicker();
            this.areaCombo = new System.Windows.Forms.ComboBox();
            this.resetButton = new System.Windows.Forms.Button();
            this.label19 = new System.Windows.Forms.Label();
            this.physicalGrid = new DevExpress.XtraGrid.GridControl();
            this.physicalGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.physicalRegTimeColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.physicalAreaColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.physicalItemNoColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.physicalProductColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.findButton = new System.Windows.Forms.Button();
            this.itemNoEdit = new DevExpress.XtraEditors.TextEdit();
            this.label4 = new System.Windows.Forms.Label();
            this.reportPanel = new Ulee.Controls.UlPanel();
            this.bgPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.viewSplit)).BeginInit();
            this.viewSplit.Panel1.SuspendLayout();
            this.viewSplit.Panel2.SuspendLayout();
            this.viewSplit.SuspendLayout();
            this.gridPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.physicalGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.physicalGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemNoEdit.Properties)).BeginInit();
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
            this.viewSplit.TabIndex = 91;
            // 
            // gridPanel
            // 
            this.gridPanel.BevelInner = Ulee.Controls.EUlBevelStyle.None;
            this.gridPanel.BevelOuter = Ulee.Controls.EUlBevelStyle.None;
            this.gridPanel.Controls.Add(this.toDateEdit);
            this.gridPanel.Controls.Add(this.label3);
            this.gridPanel.Controls.Add(this.dateCheck);
            this.gridPanel.Controls.Add(this.fromDateEdit);
            this.gridPanel.Controls.Add(this.areaCombo);
            this.gridPanel.Controls.Add(this.resetButton);
            this.gridPanel.Controls.Add(this.label19);
            this.gridPanel.Controls.Add(this.physicalGrid);
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
            // toDateEdit
            // 
            this.toDateEdit.CustomFormat = "yyyy-MM-dd";
            this.toDateEdit.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toDateEdit.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.toDateEdit.Location = new System.Drawing.Point(56, 29);
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
            this.fromDateEdit.Location = new System.Drawing.Point(56, 3);
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
            this.areaCombo.Location = new System.Drawing.Point(56, 55);
            this.areaCombo.Name = "areaCombo";
            this.areaCombo.Size = new System.Drawing.Size(54, 23);
            this.areaCombo.TabIndex = 3;
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
            this.resetButton.TabIndex = 6;
            this.resetButton.Text = "     Reset";
            this.resetButton.UseVisualStyleBackColor = true;
            this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
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
            // physicalGrid
            // 
            this.physicalGrid.Location = new System.Drawing.Point(0, 84);
            this.physicalGrid.MainView = this.physicalGridView;
            this.physicalGrid.Name = "physicalGrid";
            this.physicalGrid.Size = new System.Drawing.Size(260, 484);
            this.physicalGrid.TabIndex = 7;
            this.physicalGrid.TabStop = false;
            this.physicalGrid.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.physicalGridView});
            // 
            // physicalGridView
            // 
            this.physicalGridView.Appearance.FixedLine.Font = new System.Drawing.Font("Arial", 9F);
            this.physicalGridView.Appearance.FixedLine.Options.UseFont = true;
            this.physicalGridView.Appearance.FocusedCell.Font = new System.Drawing.Font("Arial", 9F);
            this.physicalGridView.Appearance.FocusedCell.Options.UseFont = true;
            this.physicalGridView.Appearance.FocusedRow.Font = new System.Drawing.Font("Arial", 9F);
            this.physicalGridView.Appearance.FocusedRow.Options.UseFont = true;
            this.physicalGridView.Appearance.HeaderPanel.Font = new System.Drawing.Font("Arial", 9F);
            this.physicalGridView.Appearance.HeaderPanel.Options.UseFont = true;
            this.physicalGridView.Appearance.HideSelectionRow.Font = new System.Drawing.Font("Arial", 9F);
            this.physicalGridView.Appearance.HideSelectionRow.Options.UseFont = true;
            this.physicalGridView.Appearance.OddRow.Font = new System.Drawing.Font("Arial", 9F);
            this.physicalGridView.Appearance.OddRow.Options.UseFont = true;
            this.physicalGridView.Appearance.Preview.Font = new System.Drawing.Font("Arial", 9F);
            this.physicalGridView.Appearance.Preview.Options.UseFont = true;
            this.physicalGridView.Appearance.Row.Font = new System.Drawing.Font("Arial", 9F);
            this.physicalGridView.Appearance.Row.Options.UseFont = true;
            this.physicalGridView.Appearance.SelectedRow.Font = new System.Drawing.Font("Arial", 9F);
            this.physicalGridView.Appearance.SelectedRow.Options.UseFont = true;
            this.physicalGridView.Appearance.ViewCaption.Font = new System.Drawing.Font("Arial", 9F);
            this.physicalGridView.Appearance.ViewCaption.Options.UseFont = true;
            this.physicalGridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.physicalRegTimeColumn,
            this.physicalAreaColumn,
            this.physicalItemNoColumn,
            this.physicalProductColumn});
            this.physicalGridView.CustomizationFormBounds = new System.Drawing.Rectangle(2884, 580, 210, 186);
            this.physicalGridView.GridControl = this.physicalGrid;
            this.physicalGridView.Name = "physicalGridView";
            this.physicalGridView.OptionsBehavior.Editable = false;
            this.physicalGridView.OptionsBehavior.ReadOnly = true;
            this.physicalGridView.OptionsFilter.AllowAutoFilterConditionChange = DevExpress.Utils.DefaultBoolean.False;
            this.physicalGridView.OptionsFilter.AllowFilterEditor = false;
            this.physicalGridView.OptionsView.ColumnAutoWidth = false;
            this.physicalGridView.OptionsView.ShowGroupPanel = false;
            this.physicalGridView.OptionsView.ShowIndicator = false;
            this.physicalGridView.Tag = 1;
            this.physicalGridView.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.physicalGridView_FocusedRowChanged);
            // 
            // physicalRegTimeColumn
            // 
            this.physicalRegTimeColumn.AppearanceCell.Font = new System.Drawing.Font("Arial", 9F);
            this.physicalRegTimeColumn.AppearanceCell.Options.UseFont = true;
            this.physicalRegTimeColumn.AppearanceCell.Options.UseTextOptions = true;
            this.physicalRegTimeColumn.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.physicalRegTimeColumn.AppearanceHeader.Font = new System.Drawing.Font("Arial", 9F);
            this.physicalRegTimeColumn.AppearanceHeader.Options.UseFont = true;
            this.physicalRegTimeColumn.AppearanceHeader.Options.UseTextOptions = true;
            this.physicalRegTimeColumn.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.physicalRegTimeColumn.Caption = "DateTime";
            this.physicalRegTimeColumn.FieldName = "regtime";
            this.physicalRegTimeColumn.MaxWidth = 148;
            this.physicalRegTimeColumn.MinWidth = 100;
            this.physicalRegTimeColumn.Name = "physicalRegTimeColumn";
            this.physicalRegTimeColumn.OptionsColumn.AllowEdit = false;
            this.physicalRegTimeColumn.OptionsColumn.AllowFocus = false;
            this.physicalRegTimeColumn.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.physicalRegTimeColumn.OptionsColumn.AllowIncrementalSearch = false;
            this.physicalRegTimeColumn.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.physicalRegTimeColumn.OptionsColumn.AllowMove = false;
            this.physicalRegTimeColumn.OptionsColumn.AllowShowHide = false;
            this.physicalRegTimeColumn.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.True;
            this.physicalRegTimeColumn.OptionsColumn.ImmediateUpdateRowPosition = DevExpress.Utils.DefaultBoolean.False;
            this.physicalRegTimeColumn.OptionsColumn.Printable = DevExpress.Utils.DefaultBoolean.False;
            this.physicalRegTimeColumn.OptionsColumn.ReadOnly = true;
            this.physicalRegTimeColumn.OptionsColumn.TabStop = false;
            this.physicalRegTimeColumn.OptionsFilter.AllowAutoFilter = false;
            this.physicalRegTimeColumn.OptionsFilter.AllowFilter = false;
            this.physicalRegTimeColumn.Visible = true;
            this.physicalRegTimeColumn.VisibleIndex = 0;
            this.physicalRegTimeColumn.Width = 148;
            // 
            // physicalAreaColumn
            // 
            this.physicalAreaColumn.AppearanceCell.Font = new System.Drawing.Font("Arial", 9F);
            this.physicalAreaColumn.AppearanceCell.Options.UseFont = true;
            this.physicalAreaColumn.AppearanceCell.Options.UseTextOptions = true;
            this.physicalAreaColumn.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.physicalAreaColumn.AppearanceHeader.Font = new System.Drawing.Font("Arial", 9F);
            this.physicalAreaColumn.AppearanceHeader.Options.UseFont = true;
            this.physicalAreaColumn.AppearanceHeader.Options.UseTextOptions = true;
            this.physicalAreaColumn.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.physicalAreaColumn.Caption = "Area";
            this.physicalAreaColumn.FieldName = "areano";
            this.physicalAreaColumn.MaxWidth = 48;
            this.physicalAreaColumn.MinWidth = 48;
            this.physicalAreaColumn.Name = "physicalAreaColumn";
            this.physicalAreaColumn.OptionsColumn.AllowEdit = false;
            this.physicalAreaColumn.OptionsColumn.AllowFocus = false;
            this.physicalAreaColumn.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.physicalAreaColumn.OptionsColumn.AllowIncrementalSearch = false;
            this.physicalAreaColumn.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.physicalAreaColumn.OptionsColumn.AllowMove = false;
            this.physicalAreaColumn.OptionsColumn.AllowShowHide = false;
            this.physicalAreaColumn.OptionsColumn.AllowSize = false;
            this.physicalAreaColumn.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.True;
            this.physicalAreaColumn.OptionsColumn.FixedWidth = true;
            this.physicalAreaColumn.OptionsColumn.ImmediateUpdateRowPosition = DevExpress.Utils.DefaultBoolean.False;
            this.physicalAreaColumn.OptionsColumn.Printable = DevExpress.Utils.DefaultBoolean.False;
            this.physicalAreaColumn.OptionsColumn.ReadOnly = true;
            this.physicalAreaColumn.OptionsFilter.AllowAutoFilter = false;
            this.physicalAreaColumn.OptionsFilter.AllowFilter = false;
            this.physicalAreaColumn.Visible = true;
            this.physicalAreaColumn.VisibleIndex = 1;
            this.physicalAreaColumn.Width = 48;
            // 
            // physicalItemNoColumn
            // 
            this.physicalItemNoColumn.AppearanceCell.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.physicalItemNoColumn.AppearanceCell.Options.UseFont = true;
            this.physicalItemNoColumn.AppearanceHeader.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.physicalItemNoColumn.AppearanceHeader.Options.UseFont = true;
            this.physicalItemNoColumn.Caption = "Item No.";
            this.physicalItemNoColumn.FieldName = "productno";
            this.physicalItemNoColumn.MinWidth = 80;
            this.physicalItemNoColumn.Name = "physicalItemNoColumn";
            this.physicalItemNoColumn.OptionsColumn.AllowEdit = false;
            this.physicalItemNoColumn.OptionsColumn.AllowFocus = false;
            this.physicalItemNoColumn.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.physicalItemNoColumn.OptionsColumn.AllowIncrementalSearch = false;
            this.physicalItemNoColumn.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.physicalItemNoColumn.OptionsColumn.AllowMove = false;
            this.physicalItemNoColumn.OptionsColumn.AllowShowHide = false;
            this.physicalItemNoColumn.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.True;
            this.physicalItemNoColumn.OptionsColumn.ReadOnly = true;
            this.physicalItemNoColumn.OptionsFilter.AllowAutoFilter = false;
            this.physicalItemNoColumn.OptionsFilter.AllowFilter = false;
            this.physicalItemNoColumn.Visible = true;
            this.physicalItemNoColumn.VisibleIndex = 2;
            this.physicalItemNoColumn.Width = 80;
            // 
            // physicalProductColumn
            // 
            this.physicalProductColumn.AppearanceCell.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.physicalProductColumn.AppearanceCell.Options.UseFont = true;
            this.physicalProductColumn.AppearanceHeader.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.physicalProductColumn.AppearanceHeader.Options.UseFont = true;
            this.physicalProductColumn.Caption = "Product Name";
            this.physicalProductColumn.FieldName = "sampledesc";
            this.physicalProductColumn.MinWidth = 80;
            this.physicalProductColumn.Name = "physicalProductColumn";
            this.physicalProductColumn.OptionsColumn.AllowEdit = false;
            this.physicalProductColumn.OptionsColumn.AllowFocus = false;
            this.physicalProductColumn.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.physicalProductColumn.OptionsColumn.AllowIncrementalSearch = false;
            this.physicalProductColumn.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.physicalProductColumn.OptionsColumn.AllowMove = false;
            this.physicalProductColumn.OptionsColumn.AllowShowHide = false;
            this.physicalProductColumn.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.True;
            this.physicalProductColumn.OptionsColumn.ReadOnly = true;
            this.physicalProductColumn.OptionsFilter.AllowAutoFilter = false;
            this.physicalProductColumn.OptionsFilter.AllowFilter = false;
            this.physicalProductColumn.Visible = true;
            this.physicalProductColumn.VisibleIndex = 3;
            this.physicalProductColumn.Width = 100;
            // 
            // findButton
            // 
            this.findButton.Image = ((System.Drawing.Image)(resources.GetObject("findButton.Image")));
            this.findButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.findButton.Location = new System.Drawing.Point(174, 2);
            this.findButton.Name = "findButton";
            this.findButton.Padding = new System.Windows.Forms.Padding(2, 0, 0, 0);
            this.findButton.Size = new System.Drawing.Size(86, 24);
            this.findButton.TabIndex = 5;
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
            this.itemNoEdit.Properties.MaxLength = 20;
            this.itemNoEdit.Size = new System.Drawing.Size(86, 22);
            this.itemNoEdit.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(121, 54);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 22);
            this.label4.TabIndex = 83;
            this.label4.Text = "Item No";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // reportPanel
            // 
            this.reportPanel.BevelInner = Ulee.Controls.EUlBevelStyle.None;
            this.reportPanel.BevelOuter = Ulee.Controls.EUlBevelStyle.None;
            this.reportPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reportPanel.Font = new System.Drawing.Font("Arial", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reportPanel.InnerColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(160)))), ((int)(((byte)(160)))));
            this.reportPanel.InnerColor2 = System.Drawing.Color.White;
            this.reportPanel.Location = new System.Drawing.Point(0, 0);
            this.reportPanel.Name = "reportPanel";
            this.reportPanel.OuterColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(160)))), ((int)(((byte)(160)))));
            this.reportPanel.OuterColor2 = System.Drawing.Color.White;
            this.reportPanel.Size = new System.Drawing.Size(556, 568);
            this.reportPanel.Spacing = 0;
            this.reportPanel.TabIndex = 1;
            this.reportPanel.Text = "None";
            this.reportPanel.TextHAlign = Ulee.Controls.EUlHoriAlign.Center;
            this.reportPanel.TextVAlign = Ulee.Controls.EUlVertAlign.Middle;
            // 
            // CtrlEditPhysical
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Name = "CtrlEditPhysical";
            this.Size = new System.Drawing.Size(820, 568);
            this.Load += new System.EventHandler(this.CtrlEditPhysical_Load);
            this.Enter += new System.EventHandler(this.CtrlEditPhysical_Enter);
            this.Resize += new System.EventHandler(this.CtrlEditPhysical_Resize);
            this.bgPanel.ResumeLayout(false);
            this.viewSplit.Panel1.ResumeLayout(false);
            this.viewSplit.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.viewSplit)).EndInit();
            this.viewSplit.ResumeLayout(false);
            this.gridPanel.ResumeLayout(false);
            this.gridPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.physicalGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.physicalGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemNoEdit.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.SplitContainer viewSplit;
        private Ulee.Controls.UlPanel gridPanel;
        private System.Windows.Forms.DateTimePicker toDateEdit;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox dateCheck;
        private System.Windows.Forms.DateTimePicker fromDateEdit;
        private System.Windows.Forms.ComboBox areaCombo;
        private System.Windows.Forms.Button resetButton;
        private System.Windows.Forms.Label label19;
        private DevExpress.XtraGrid.GridControl physicalGrid;
        private DevExpress.XtraGrid.Views.Grid.GridView physicalGridView;
        private DevExpress.XtraGrid.Columns.GridColumn physicalRegTimeColumn;
        private DevExpress.XtraGrid.Columns.GridColumn physicalAreaColumn;
        private DevExpress.XtraGrid.Columns.GridColumn physicalItemNoColumn;
        private System.Windows.Forms.Button findButton;
        public DevExpress.XtraEditors.TextEdit itemNoEdit;
        private System.Windows.Forms.Label label4;
        private Ulee.Controls.UlPanel reportPanel;
        private DevExpress.XtraGrid.Columns.GridColumn physicalProductColumn;
    }
}
