namespace EU_Auction_Calculator
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            labelQuantity = new Label();
            labelValue = new Label();
            labelTargetMarkupP = new Label();
            labelTolerancePt = new Label();
            numericQuantity = new NumericUpDown();
            numericValue = new NumericUpDown();
            numericTargetMarkupP = new NumericUpDown();
            numericTolerancePt = new NumericUpDown();
            numericToleranceP = new NumericUpDown();
            labelToleranceP = new Label();
            labelQuantityComment = new Label();
            labelTargetMarkupComment = new Label();
            labelSuggestions = new Label();
            dataGridView1 = new DataGridView();
            Quantity = new DataGridViewTextBoxColumn();
            Markup = new DataGridViewTextBoxColumn();
            Diff = new DataGridViewTextBoxColumn();
            SellFor = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)numericQuantity).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericValue).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericTargetMarkupP).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericTolerancePt).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericToleranceP).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // labelQuantity
            // 
            labelQuantity.AutoSize = true;
            labelQuantity.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            labelQuantity.Location = new Point(12, 9);
            labelQuantity.Name = "labelQuantity";
            labelQuantity.Size = new Size(56, 17);
            labelQuantity.TabIndex = 0;
            labelQuantity.Text = "Quantity";
            // 
            // labelValue
            // 
            labelValue.AutoSize = true;
            labelValue.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            labelValue.Location = new Point(12, 57);
            labelValue.Name = "labelValue";
            labelValue.Size = new Size(74, 17);
            labelValue.TabIndex = 1;
            labelValue.Text = "Value (PED)";
            // 
            // labelTargetMarkupP
            // 
            labelTargetMarkupP.AutoSize = true;
            labelTargetMarkupP.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            labelTargetMarkupP.Location = new Point(12, 105);
            labelTargetMarkupP.Name = "labelTargetMarkupP";
            labelTargetMarkupP.Size = new Size(109, 17);
            labelTargetMarkupP.TabIndex = 2;
            labelTargetMarkupP.Text = "Target Markup %";
            // 
            // labelTolerancePt
            // 
            labelTolerancePt.AutoSize = true;
            labelTolerancePt.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            labelTolerancePt.Location = new Point(138, 105);
            labelTolerancePt.Name = "labelTolerancePt";
            labelTolerancePt.Size = new Size(91, 17);
            labelTolerancePt.TabIndex = 3;
            labelTolerancePt.Text = "Tolerance %pt";
            // 
            // numericQuantity
            // 
            numericQuantity.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            numericQuantity.Location = new Point(12, 29);
            numericQuantity.Maximum = new decimal(new int[] { -727379969, 232, 0, 0 });
            numericQuantity.Name = "numericQuantity";
            numericQuantity.Size = new Size(120, 25);
            numericQuantity.TabIndex = 4;
            numericQuantity.Value = new decimal(new int[] { 1000, 0, 0, 0 });
            numericQuantity.ValueChanged += numericUpDown1_ValueChanged;
            // 
            // numericValue
            // 
            numericValue.DecimalPlaces = 2;
            numericValue.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            numericValue.Location = new Point(12, 77);
            numericValue.Maximum = new decimal(new int[] { -727379969, 232, 0, 0 });
            numericValue.Name = "numericValue";
            numericValue.Size = new Size(120, 25);
            numericValue.TabIndex = 5;
            numericValue.Value = new decimal(new int[] { 100, 0, 0, 0 });
            numericValue.ValueChanged += numericValue_ValueChanged;
            // 
            // numericTargetMarkupP
            // 
            numericTargetMarkupP.DecimalPlaces = 2;
            numericTargetMarkupP.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            numericTargetMarkupP.Location = new Point(12, 125);
            numericTargetMarkupP.Maximum = new decimal(new int[] { -727379969, 232, 0, 0 });
            numericTargetMarkupP.Name = "numericTargetMarkupP";
            numericTargetMarkupP.Size = new Size(120, 25);
            numericTargetMarkupP.TabIndex = 6;
            numericTargetMarkupP.Value = new decimal(new int[] { 100, 0, 0, 0 });
            numericTargetMarkupP.ValueChanged += numericTargetMarkupP_ValueChanged;
            // 
            // numericTolerancePt
            // 
            numericTolerancePt.DecimalPlaces = 1;
            numericTolerancePt.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            numericTolerancePt.Increment = new decimal(new int[] { 1, 0, 0, 65536 });
            numericTolerancePt.Location = new Point(138, 125);
            numericTolerancePt.Maximum = new decimal(new int[] { 50, 0, 0, 0 });
            numericTolerancePt.Name = "numericTolerancePt";
            numericTolerancePt.Size = new Size(120, 25);
            numericTolerancePt.TabIndex = 7;
            numericTolerancePt.Value = new decimal(new int[] { 5, 0, 0, 65536 });
            numericTolerancePt.ValueChanged += numericTolerancePt_ValueChanged;
            // 
            // numericToleranceP
            // 
            numericToleranceP.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            numericToleranceP.Location = new Point(138, 29);
            numericToleranceP.Maximum = new decimal(new int[] { 50, 0, 0, 0 });
            numericToleranceP.Name = "numericToleranceP";
            numericToleranceP.Size = new Size(120, 25);
            numericToleranceP.TabIndex = 8;
            numericToleranceP.Value = new decimal(new int[] { 10, 0, 0, 0 });
            numericToleranceP.ValueChanged += numericToleranceP_ValueChanged;
            // 
            // labelToleranceP
            // 
            labelToleranceP.AutoSize = true;
            labelToleranceP.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            labelToleranceP.Location = new Point(138, 9);
            labelToleranceP.Name = "labelToleranceP";
            labelToleranceP.Size = new Size(79, 17);
            labelToleranceP.TabIndex = 9;
            labelToleranceP.Text = "Tolerance %";
            // 
            // labelQuantityComment
            // 
            labelQuantityComment.AutoSize = true;
            labelQuantityComment.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            labelQuantityComment.Location = new Point(264, 31);
            labelQuantityComment.Name = "labelQuantityComment";
            labelQuantityComment.Size = new Size(140, 17);
            labelQuantityComment.TabIndex = 10;
            labelQuantityComment.Text = "labelQuantityComment";
            // 
            // labelTargetMarkupComment
            // 
            labelTargetMarkupComment.AutoSize = true;
            labelTargetMarkupComment.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            labelTargetMarkupComment.Location = new Point(264, 127);
            labelTargetMarkupComment.Name = "labelTargetMarkupComment";
            labelTargetMarkupComment.Size = new Size(174, 17);
            labelTargetMarkupComment.TabIndex = 12;
            labelTargetMarkupComment.Text = "labelTargetMarkupComment";
            // 
            // labelSuggestions
            // 
            labelSuggestions.AutoSize = true;
            labelSuggestions.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            labelSuggestions.Location = new Point(12, 153);
            labelSuggestions.Name = "labelSuggestions";
            labelSuggestions.Size = new Size(79, 17);
            labelSuggestions.TabIndex = 13;
            labelSuggestions.Text = "Suggestions";
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToResizeColumns = false;
            dataGridView1.AllowUserToResizeRows = false;
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Quantity, Markup, Diff, SellFor });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            dataGridView1.Location = new Point(12, 173);
            dataGridView1.MultiSelect = false;
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(486, 182);
            dataGridView1.TabIndex = 14;
            // 
            // Quantity
            // 
            Quantity.HeaderText = "Quantity";
            Quantity.Name = "Quantity";
            Quantity.ReadOnly = true;
            // 
            // Markup
            // 
            Markup.HeaderText = "Markup";
            Markup.Name = "Markup";
            Markup.ReadOnly = true;
            // 
            // Diff
            // 
            Diff.HeaderText = "Diff";
            Diff.Name = "Diff";
            Diff.ReadOnly = true;
            // 
            // SellFor
            // 
            SellFor.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            SellFor.HeaderText = "Sell for";
            SellFor.Name = "SellFor";
            SellFor.ReadOnly = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Silver;
            ClientSize = new Size(510, 367);
            Controls.Add(dataGridView1);
            Controls.Add(labelSuggestions);
            Controls.Add(labelTargetMarkupComment);
            Controls.Add(labelQuantityComment);
            Controls.Add(labelToleranceP);
            Controls.Add(numericToleranceP);
            Controls.Add(numericTolerancePt);
            Controls.Add(numericTargetMarkupP);
            Controls.Add(numericValue);
            Controls.Add(numericQuantity);
            Controls.Add(labelTolerancePt);
            Controls.Add(labelTargetMarkupP);
            Controls.Add(labelValue);
            Controls.Add(labelQuantity);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Form1";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "EU Auction Calculator";
            TopMost = true;
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)numericQuantity).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericValue).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericTargetMarkupP).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericTolerancePt).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericToleranceP).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelQuantity;
        private Label labelValue;
        private Label labelTargetMarkupP;
        private Label labelTolerancePt;
        private NumericUpDown numericQuantity;
        private NumericUpDown numericValue;
        private NumericUpDown numericTargetMarkupP;
        private NumericUpDown numericTolerancePt;
        private NumericUpDown numericToleranceP;
        private Label labelToleranceP;
        private Label labelQuantityComment;
        private Label labelTargetMarkupComment;
        private Label labelSuggestions;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Quantity;
        private DataGridViewTextBoxColumn Markup;
        private DataGridViewTextBoxColumn Diff;
        private DataGridViewTextBoxColumn SellFor;
    }
}
