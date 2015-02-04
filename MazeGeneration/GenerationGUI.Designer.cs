namespace MazeGeneration
{
    partial class GenerationGUI
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
            this.MainTable = new System.Windows.Forms.TableLayoutPanel();
            this.GridTable = new System.Windows.Forms.TableLayoutPanel();
            this.GridLabel = new System.Windows.Forms.Label();
            this.ButtonTable = new System.Windows.Forms.TableLayoutPanel();
            this.Reset = new System.Windows.Forms.Button();
            this.GenerateToggle = new System.Windows.Forms.Button();
            this.GridSettingsTable = new System.Windows.Forms.TableLayoutPanel();
            this.GridSettingsLabel = new System.Windows.Forms.Label();
            this.GenerationSettingsLabel = new System.Windows.Forms.Label();
            this.IntervalSelect = new System.Windows.Forms.TrackBar();
            this.TypeLabel = new System.Windows.Forms.Label();
            this.TypeSelect = new System.Windows.Forms.DomainUpDown();
            this.IntervalLabel = new System.Windows.Forms.Label();
            this.HeightSelection = new System.Windows.Forms.NumericUpDown();
            this.HeightLabel = new System.Windows.Forms.Label();
            this.WidthSelection = new System.Windows.Forms.NumericUpDown();
            this.WidthLabel = new System.Windows.Forms.Label();
            this.GridCanvas = new MazeGeneration.Canvas();
            this.MainTable.SuspendLayout();
            this.GridTable.SuspendLayout();
            this.ButtonTable.SuspendLayout();
            this.GridSettingsTable.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.IntervalSelect)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HeightSelection)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.WidthSelection)).BeginInit();
            this.SuspendLayout();
            // 
            // MainTable
            // 
            this.MainTable.AutoSize = true;
            this.MainTable.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.MainTable.ColumnCount = 2;
            this.MainTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.MainTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.MainTable.Controls.Add(this.GridTable, 1, 0);
            this.MainTable.Controls.Add(this.GridSettingsTable, 0, 0);
            this.MainTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainTable.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.FixedSize;
            this.MainTable.Location = new System.Drawing.Point(0, 0);
            this.MainTable.Name = "MainTable";
            this.MainTable.RowCount = 1;
            this.MainTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.MainTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 398F));
            this.MainTable.Size = new System.Drawing.Size(428, 398);
            this.MainTable.TabIndex = 0;
            // 
            // GridTable
            // 
            this.GridTable.AutoSize = true;
            this.GridTable.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.GridTable.ColumnCount = 1;
            this.GridTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.GridTable.Controls.Add(this.GridCanvas, 0, 1);
            this.GridTable.Controls.Add(this.GridLabel, 0, 0);
            this.GridTable.Controls.Add(this.ButtonTable, 0, 2);
            this.GridTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GridTable.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.FixedSize;
            this.GridTable.Location = new System.Drawing.Point(103, 3);
            this.GridTable.Name = "GridTable";
            this.GridTable.RowCount = 3;
            this.GridTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.GridTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.GridTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.GridTable.Size = new System.Drawing.Size(322, 392);
            this.GridTable.TabIndex = 0;
            // 
            // GridLabel
            // 
            this.GridLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.GridLabel.AutoSize = true;
            this.GridLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.GridLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.GridLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GridLabel.ForeColor = System.Drawing.SystemColors.Window;
            this.GridLabel.Location = new System.Drawing.Point(3, 0);
            this.GridLabel.Name = "GridLabel";
            this.GridLabel.Size = new System.Drawing.Size(316, 50);
            this.GridLabel.TabIndex = 2;
            this.GridLabel.Text = "Maze View";
            this.GridLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ButtonTable
            // 
            this.ButtonTable.ColumnCount = 2;
            this.ButtonTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.ButtonTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.ButtonTable.Controls.Add(this.Reset, 0, 0);
            this.ButtonTable.Controls.Add(this.GenerateToggle, 0, 0);
            this.ButtonTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ButtonTable.Location = new System.Drawing.Point(3, 355);
            this.ButtonTable.Name = "ButtonTable";
            this.ButtonTable.RowCount = 1;
            this.ButtonTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.ButtonTable.Size = new System.Drawing.Size(316, 34);
            this.ButtonTable.TabIndex = 5;
            this.ButtonTable.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel2_Paint);
            // 
            // Reset
            // 
            this.Reset.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Reset.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Reset.Location = new System.Drawing.Point(199, 5);
            this.Reset.Name = "Reset";
            this.Reset.Size = new System.Drawing.Size(75, 23);
            this.Reset.TabIndex = 7;
            this.Reset.Text = "Reset";
            this.Reset.UseVisualStyleBackColor = true;
            this.Reset.Click += new System.EventHandler(this.TypeChange);
            // 
            // GenerateToggle
            // 
            this.GenerateToggle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.GenerateToggle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GenerateToggle.Location = new System.Drawing.Point(41, 5);
            this.GenerateToggle.Name = "GenerateToggle";
            this.GenerateToggle.Size = new System.Drawing.Size(75, 23);
            this.GenerateToggle.TabIndex = 6;
            this.GenerateToggle.Text = "Start";
            this.GenerateToggle.UseVisualStyleBackColor = true;
            this.GenerateToggle.Click += new System.EventHandler(this.ToggleGenerate);
            // 
            // GridSettingsTable
            // 
            this.GridSettingsTable.AutoSize = true;
            this.GridSettingsTable.ColumnCount = 1;
            this.GridSettingsTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.GridSettingsTable.Controls.Add(this.GridSettingsLabel, 0, 6);
            this.GridSettingsTable.Controls.Add(this.GenerationSettingsLabel, 0, 0);
            this.GridSettingsTable.Controls.Add(this.IntervalSelect, 0, 4);
            this.GridSettingsTable.Controls.Add(this.TypeLabel, 0, 1);
            this.GridSettingsTable.Controls.Add(this.TypeSelect, 0, 2);
            this.GridSettingsTable.Controls.Add(this.IntervalLabel, 0, 3);
            this.GridSettingsTable.Controls.Add(this.HeightSelection, 0, 10);
            this.GridSettingsTable.Controls.Add(this.HeightLabel, 0, 9);
            this.GridSettingsTable.Controls.Add(this.WidthSelection, 0, 8);
            this.GridSettingsTable.Controls.Add(this.WidthLabel, 0, 7);
            this.GridSettingsTable.Dock = System.Windows.Forms.DockStyle.Top;
            this.GridSettingsTable.Location = new System.Drawing.Point(3, 3);
            this.GridSettingsTable.Name = "GridSettingsTable";
            this.GridSettingsTable.RowCount = 11;
            this.GridSettingsTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.GridSettingsTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.GridSettingsTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.GridSettingsTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.GridSettingsTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.GridSettingsTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.GridSettingsTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.GridSettingsTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.GridSettingsTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.GridSettingsTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.GridSettingsTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.GridSettingsTable.Size = new System.Drawing.Size(94, 345);
            this.GridSettingsTable.TabIndex = 3;
            // 
            // GridSettingsLabel
            // 
            this.GridSettingsLabel.AutoSize = true;
            this.GridSettingsLabel.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.GridSettingsLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GridSettingsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GridSettingsLabel.ForeColor = System.Drawing.SystemColors.Window;
            this.GridSettingsLabel.Location = new System.Drawing.Point(3, 205);
            this.GridSettingsLabel.Name = "GridSettingsLabel";
            this.GridSettingsLabel.Size = new System.Drawing.Size(88, 50);
            this.GridSettingsLabel.TabIndex = 5;
            this.GridSettingsLabel.Text = "Grid Settings";
            this.GridSettingsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // GenerationSettingsLabel
            // 
            this.GenerationSettingsLabel.AutoSize = true;
            this.GenerationSettingsLabel.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.GenerationSettingsLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.GenerationSettingsLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GenerationSettingsLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GenerationSettingsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GenerationSettingsLabel.ForeColor = System.Drawing.SystemColors.Window;
            this.GenerationSettingsLabel.Location = new System.Drawing.Point(3, 0);
            this.GenerationSettingsLabel.Name = "GenerationSettingsLabel";
            this.GenerationSettingsLabel.Size = new System.Drawing.Size(88, 50);
            this.GenerationSettingsLabel.TabIndex = 4;
            this.GenerationSettingsLabel.Text = "Generation Settings";
            this.GenerationSettingsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // IntervalSelect
            // 
            this.IntervalSelect.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.IntervalSelect.Location = new System.Drawing.Point(3, 158);
            this.IntervalSelect.Name = "IntervalSelect";
            this.IntervalSelect.Size = new System.Drawing.Size(88, 19);
            this.IntervalSelect.TabIndex = 3;
            this.IntervalSelect.ValueChanged += new System.EventHandler(this.IntervalChange);
            // 
            // TypeLabel
            // 
            this.TypeLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.TypeLabel.AutoSize = true;
            this.TypeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TypeLabel.Location = new System.Drawing.Point(3, 64);
            this.TypeLabel.Name = "TypeLabel";
            this.TypeLabel.Size = new System.Drawing.Size(73, 26);
            this.TypeLabel.TabIndex = 0;
            this.TypeLabel.Text = "Generation Algorithm";
            // 
            // TypeSelect
            // 
            this.TypeSelect.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.TypeSelect.ImeMode = System.Windows.Forms.ImeMode.On;
            this.TypeSelect.Location = new System.Drawing.Point(3, 93);
            this.TypeSelect.Name = "TypeSelect";
            this.TypeSelect.Size = new System.Drawing.Size(88, 20);
            this.TypeSelect.TabIndex = 1;
            this.TypeSelect.SelectedItemChanged += new System.EventHandler(this.TypeChange);
            // 
            // IntervalLabel
            // 
            this.IntervalLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.IntervalLabel.AutoSize = true;
            this.IntervalLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IntervalLabel.Location = new System.Drawing.Point(3, 129);
            this.IntervalLabel.Name = "IntervalLabel";
            this.IntervalLabel.Size = new System.Drawing.Size(73, 26);
            this.IntervalLabel.TabIndex = 2;
            this.IntervalLabel.Text = "Generation Interval";
            // 
            // HeightSelection
            // 
            this.HeightSelection.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.HeightSelection.Location = new System.Drawing.Point(3, 323);
            this.HeightSelection.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.HeightSelection.Name = "HeightSelection";
            this.HeightSelection.Size = new System.Drawing.Size(88, 20);
            this.HeightSelection.TabIndex = 3;
            this.HeightSelection.Tag = "height";
            this.HeightSelection.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.HeightSelection.ValueChanged += new System.EventHandler(this.HeightChange);
            // 
            // HeightLabel
            // 
            this.HeightLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.HeightLabel.AutoSize = true;
            this.HeightLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HeightLabel.Location = new System.Drawing.Point(3, 307);
            this.HeightLabel.Name = "HeightLabel";
            this.HeightLabel.Size = new System.Drawing.Size(44, 13);
            this.HeightLabel.TabIndex = 1;
            this.HeightLabel.Text = "Height";
            // 
            // WidthSelection
            // 
            this.WidthSelection.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.WidthSelection.Location = new System.Drawing.Point(3, 278);
            this.WidthSelection.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.WidthSelection.Name = "WidthSelection";
            this.WidthSelection.Size = new System.Drawing.Size(88, 20);
            this.WidthSelection.TabIndex = 2;
            this.WidthSelection.Tag = "width";
            this.WidthSelection.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.WidthSelection.ValueChanged += new System.EventHandler(this.WidthChange);
            // 
            // WidthLabel
            // 
            this.WidthLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.WidthLabel.AutoSize = true;
            this.WidthLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WidthLabel.Location = new System.Drawing.Point(3, 262);
            this.WidthLabel.Name = "WidthLabel";
            this.WidthLabel.Size = new System.Drawing.Size(40, 13);
            this.WidthLabel.TabIndex = 0;
            this.WidthLabel.Text = "Width";
            // 
            // GridCanvas
            // 
            this.GridCanvas.BackColor = System.Drawing.SystemColors.Window;
            this.GridCanvas.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.GridCanvas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GridCanvas.Location = new System.Drawing.Point(3, 53);
            this.GridCanvas.Name = "GridCanvas";
            this.GridCanvas.Size = new System.Drawing.Size(316, 296);
            this.GridCanvas.TabIndex = 4;
            this.GridCanvas.Paint += new System.Windows.Forms.PaintEventHandler(this.PaintGrid);
            // 
            // GenerationGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.ClientSize = new System.Drawing.Size(428, 398);
            this.Controls.Add(this.MainTable);
            this.DoubleBuffered = true;
            this.Name = "GenerationGUI";
            this.Text = "Maze Generation";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.GUIClosing);
            this.Load += new System.EventHandler(this.GUI_Load);
            this.MainTable.ResumeLayout(false);
            this.MainTable.PerformLayout();
            this.GridTable.ResumeLayout(false);
            this.GridTable.PerformLayout();
            this.ButtonTable.ResumeLayout(false);
            this.GridSettingsTable.ResumeLayout(false);
            this.GridSettingsTable.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.IntervalSelect)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HeightSelection)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.WidthSelection)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel MainTable;
        private System.Windows.Forms.Label WidthLabel;
        private System.Windows.Forms.Label HeightLabel;
        private System.Windows.Forms.NumericUpDown WidthSelection;
        private System.Windows.Forms.NumericUpDown HeightSelection;
        private System.Windows.Forms.Label GridLabel;
        private System.Windows.Forms.Label TypeLabel;
        private System.Windows.Forms.DomainUpDown TypeSelect;
        private System.Windows.Forms.Label IntervalLabel;
        private System.Windows.Forms.TrackBar IntervalSelect;
        private System.Windows.Forms.TableLayoutPanel GridSettingsTable;
        private System.Windows.Forms.Label GenerationSettingsLabel;
        private System.Windows.Forms.TableLayoutPanel GridTable;
        private System.Windows.Forms.Label GridSettingsLabel;
        private Canvas GridCanvas;
        private System.Windows.Forms.TableLayoutPanel ButtonTable;
        private System.Windows.Forms.Button GenerateToggle;
        private System.Windows.Forms.Button Reset;
    }
}