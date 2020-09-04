namespace Sgs.ReportIntegration
{
    partial class DialogProductView
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
            this.label1 = new System.Windows.Forms.Label();
            this.itemNoEdit = new DevExpress.XtraEditors.TextEdit();
            this.productEdit = new DevExpress.XtraEditors.TextEdit();
            this.label3 = new System.Windows.Forms.Label();
            this.imagePanel = new Ulee.Controls.UlPanel();
            this.imageBox = new System.Windows.Forms.PictureBox();
            this.closeButton = new System.Windows.Forms.Button();
            this.bgPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.itemNoEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productEdit.Properties)).BeginInit();
            this.imagePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox)).BeginInit();
            this.SuspendLayout();
            // 
            // bgPanel
            // 
            this.bgPanel.Controls.Add(this.closeButton);
            this.bgPanel.Controls.Add(this.imagePanel);
            this.bgPanel.Controls.Add(this.label3);
            this.bgPanel.Controls.Add(this.productEdit);
            this.bgPanel.Controls.Add(this.label1);
            this.bgPanel.Controls.Add(this.itemNoEdit);
            this.bgPanel.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bgPanel.Size = new System.Drawing.Size(344, 361);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 15);
            this.label1.TabIndex = 83;
            this.label1.Text = "Item Number";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // itemNoEdit
            // 
            this.itemNoEdit.EditValue = "";
            this.itemNoEdit.Location = new System.Drawing.Point(132, 12);
            this.itemNoEdit.Name = "itemNoEdit";
            this.itemNoEdit.Properties.Appearance.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itemNoEdit.Properties.Appearance.Options.UseFont = true;
            this.itemNoEdit.Properties.AppearanceDisabled.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itemNoEdit.Properties.AppearanceDisabled.Options.UseFont = true;
            this.itemNoEdit.Properties.AppearanceFocused.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itemNoEdit.Properties.AppearanceFocused.Options.UseFont = true;
            this.itemNoEdit.Properties.AppearanceReadOnly.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itemNoEdit.Properties.AppearanceReadOnly.Options.UseFont = true;
            this.itemNoEdit.Properties.ReadOnly = true;
            this.itemNoEdit.Size = new System.Drawing.Size(200, 22);
            this.itemNoEdit.TabIndex = 0;
            this.itemNoEdit.TabStop = false;
            // 
            // productEdit
            // 
            this.productEdit.EditValue = "";
            this.productEdit.Location = new System.Drawing.Point(132, 44);
            this.productEdit.Name = "productEdit";
            this.productEdit.Properties.Appearance.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productEdit.Properties.Appearance.Options.UseFont = true;
            this.productEdit.Properties.AppearanceDisabled.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productEdit.Properties.AppearanceDisabled.Options.UseFont = true;
            this.productEdit.Properties.AppearanceFocused.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productEdit.Properties.AppearanceFocused.Options.UseFont = true;
            this.productEdit.Properties.AppearanceReadOnly.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productEdit.Properties.AppearanceReadOnly.Options.UseFont = true;
            this.productEdit.Properties.ReadOnly = true;
            this.productEdit.Size = new System.Drawing.Size(200, 22);
            this.productEdit.TabIndex = 1;
            this.productEdit.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 15);
            this.label3.TabIndex = 86;
            this.label3.Text = "Product Description";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // imagePanel
            // 
            this.imagePanel.BevelInner = Ulee.Controls.EUlBevelStyle.None;
            this.imagePanel.BevelOuter = Ulee.Controls.EUlBevelStyle.None;
            this.imagePanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.imagePanel.Controls.Add(this.imageBox);
            this.imagePanel.InnerColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(160)))), ((int)(((byte)(160)))));
            this.imagePanel.InnerColor2 = System.Drawing.Color.White;
            this.imagePanel.Location = new System.Drawing.Point(12, 76);
            this.imagePanel.Name = "imagePanel";
            this.imagePanel.OuterColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(160)))), ((int)(((byte)(160)))));
            this.imagePanel.OuterColor2 = System.Drawing.Color.White;
            this.imagePanel.Size = new System.Drawing.Size(320, 240);
            this.imagePanel.Spacing = 0;
            this.imagePanel.TabIndex = 2;
            this.imagePanel.TextHAlign = Ulee.Controls.EUlHoriAlign.Center;
            this.imagePanel.TextVAlign = Ulee.Controls.EUlVertAlign.Middle;
            // 
            // imageBox
            // 
            this.imageBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.imageBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.imageBox.Location = new System.Drawing.Point(0, 0);
            this.imageBox.Name = "imageBox";
            this.imageBox.Size = new System.Drawing.Size(318, 238);
            this.imageBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.imageBox.TabIndex = 0;
            this.imageBox.TabStop = false;
            // 
            // closeButton
            // 
            this.closeButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.closeButton.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closeButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.closeButton.Location = new System.Drawing.Point(232, 322);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(100, 32);
            this.closeButton.TabIndex = 0;
            this.closeButton.Text = "CLOSE";
            this.closeButton.UseVisualStyleBackColor = true;
            // 
            // DialogProductView
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.CancelButton = this.closeButton;
            this.ClientSize = new System.Drawing.Size(344, 361);
            this.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DialogProductView";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Product Viewer";
            this.bgPanel.ResumeLayout(false);
            this.bgPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.itemNoEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productEdit.Properties)).EndInit();
            this.imagePanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.imageBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public DevExpress.XtraEditors.TextEdit productEdit;
        private System.Windows.Forms.Label label1;
        public DevExpress.XtraEditors.TextEdit itemNoEdit;
        private Ulee.Controls.UlPanel imagePanel;
        private System.Windows.Forms.PictureBox imageBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button closeButton;
    }
}