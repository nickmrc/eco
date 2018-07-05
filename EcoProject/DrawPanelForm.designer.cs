namespace EcoProject
{
    partial class DrawPanelForm
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DrawPanelForm));
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.panel1 = new System.Windows.Forms.Panel();
            this.sheet = new System.Windows.Forms.PictureBox();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.ScaleNUD = new System.Windows.Forms.NumericUpDown();
            this.addEmptyVertex_btn = new System.Windows.Forms.Button();
            this.TriangleInfo_dgv = new System.Windows.Forms.DataGridView();
            this.drawVertexButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.deleteALLButton = new System.Windows.Forms.Button();
            this.selectButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.example_button = new System.Windows.Forms.Button();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coordinatesTable = new System.Windows.Forms.DataGridView();
            this.mainTab_dataGridView = new System.Windows.Forms.DataGridView();
            this.zoomX_label = new System.Windows.Forms.Label();
            this.scale_groupBox = new System.Windows.Forms.GroupBox();
            this.zoomPercent_label = new System.Windows.Forms.Label();
            this.zoomX_toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.zoomPerCent_toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.addVertex_toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.triangulate_toolTip = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sheet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ScaleNUD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TriangleInfo_dgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.coordinatesTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainTab_dataGridView)).BeginInit();
            this.scale_groupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(32, 27);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDown1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(106, 24);
            this.numericUpDown1.TabIndex = 31;
            this.numericUpDown1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.sheet);
            this.panel1.Location = new System.Drawing.Point(14, 23);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(545, 405);
            this.panel1.TabIndex = 30;
            // 
            // sheet
            // 
            this.sheet.BackColor = System.Drawing.Color.White;
            this.sheet.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.sheet.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.sheet.Image = global::EcoProject.Properties.Resources.cursor;
            this.sheet.Location = new System.Drawing.Point(3, 3);
            this.sheet.Name = "sheet";
            this.sheet.Size = new System.Drawing.Size(540, 400);
            this.sheet.TabIndex = 0;
            this.sheet.TabStop = false;
            this.sheet.MouseClick += new System.Windows.Forms.MouseEventHandler(this.sheet_MouseClick);
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(9, 98);
            this.trackBar1.Maximum = 500;
            this.trackBar1.Minimum = 1;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(129, 45);
            this.trackBar1.TabIndex = 29;
            this.trackBar1.Value = 100;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // ScaleNUD
            // 
            this.ScaleNUD.Location = new System.Drawing.Point(32, 70);
            this.ScaleNUD.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.ScaleNUD.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.ScaleNUD.Name = "ScaleNUD";
            this.ScaleNUD.Size = new System.Drawing.Size(106, 24);
            this.ScaleNUD.TabIndex = 28;
            this.ScaleNUD.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.ScaleNUD.ValueChanged += new System.EventHandler(this.ScaleNUD_ValueChanged_1);
            // 
            // addEmptyVertex_btn
            // 
            this.addEmptyVertex_btn.BackColor = System.Drawing.Color.SpringGreen;
            this.addEmptyVertex_btn.Font = new System.Drawing.Font("Castellar", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addEmptyVertex_btn.Location = new System.Drawing.Point(1186, 387);
            this.addEmptyVertex_btn.Name = "addEmptyVertex_btn";
            this.addEmptyVertex_btn.Size = new System.Drawing.Size(45, 45);
            this.addEmptyVertex_btn.TabIndex = 26;
            this.addEmptyVertex_btn.Text = "+";
            this.addVertex_toolTip.SetToolTip(this.addEmptyVertex_btn, "Добавить вершину");
            this.addEmptyVertex_btn.UseVisualStyleBackColor = false;
            this.addEmptyVertex_btn.Click += new System.EventHandler(this.addEmptyVertex_btn_Click);
            // 
            // TriangleInfo_dgv
            // 
            this.TriangleInfo_dgv.AllowUserToAddRows = false;
            this.TriangleInfo_dgv.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.TriangleInfo_dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TriangleInfo_dgv.Location = new System.Drawing.Point(14, 449);
            this.TriangleInfo_dgv.Name = "TriangleInfo_dgv";
            this.TriangleInfo_dgv.Size = new System.Drawing.Size(1166, 247);
            this.TriangleInfo_dgv.TabIndex = 27;
            // 
            // drawVertexButton
            // 
            this.drawVertexButton.Enabled = false;
            this.drawVertexButton.Image = global::EcoProject.Properties.Resources.vertex;
            this.drawVertexButton.Location = new System.Drawing.Point(1307, 225);
            this.drawVertexButton.Name = "drawVertexButton";
            this.drawVertexButton.Size = new System.Drawing.Size(45, 52);
            this.drawVertexButton.TabIndex = 1;
            this.drawVertexButton.UseVisualStyleBackColor = true;
            this.drawVertexButton.Visible = false;
            this.drawVertexButton.Click += new System.EventHandler(this.drawVertexButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.Image = global::EcoProject.Properties.Resources.delete;
            this.deleteButton.Location = new System.Drawing.Point(1307, 352);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(45, 52);
            this.deleteButton.TabIndex = 3;
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Visible = false;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // deleteALLButton
            // 
            this.deleteALLButton.Image = global::EcoProject.Properties.Resources.deleteAll;
            this.deleteALLButton.Location = new System.Drawing.Point(1307, 167);
            this.deleteALLButton.Name = "deleteALLButton";
            this.deleteALLButton.Size = new System.Drawing.Size(45, 52);
            this.deleteALLButton.TabIndex = 5;
            this.deleteALLButton.UseVisualStyleBackColor = true;
            this.deleteALLButton.Visible = false;
            this.deleteALLButton.Click += new System.EventHandler(this.deleteALLButton_Click);
            // 
            // selectButton
            // 
            this.selectButton.Image = global::EcoProject.Properties.Resources.cursor;
            this.selectButton.Location = new System.Drawing.Point(1307, 294);
            this.selectButton.Name = "selectButton";
            this.selectButton.Size = new System.Drawing.Size(45, 52);
            this.selectButton.TabIndex = 9;
            this.selectButton.UseVisualStyleBackColor = true;
            this.selectButton.Visible = false;
            this.selectButton.Click += new System.EventHandler(this.selectButton_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.MediumTurquoise;
            this.button1.Font = new System.Drawing.Font("Castellar", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(1186, 449);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(45, 45);
            this.button1.TabIndex = 15;
            this.button1.Text = "▽";
            this.triangulate_toolTip.SetToolTip(this.button1, "Триангулировать");
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // example_button
            // 
            this.example_button.BackColor = System.Drawing.Color.DarkCyan;
            this.example_button.Font = new System.Drawing.Font("Arial Unicode MS", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.example_button.Location = new System.Drawing.Point(1237, 418);
            this.example_button.Name = "example_button";
            this.example_button.Size = new System.Drawing.Size(45, 45);
            this.example_button.TabIndex = 21;
            this.example_button.Text = "Пример";
            this.example_button.UseVisualStyleBackColor = false;
            this.example_button.Click += new System.EventHandler(this.example_button_Click);
            // 
            // Column4
            // 
            this.Column4.HeaderText = "y";
            this.Column4.Name = "Column4";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "x";
            this.Column3.Name = "Column3";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Координаты вершины";
            this.Column2.Name = "Column2";
            // 
            // Column1
            // 
            this.Column1.HeaderText = "№ вершины";
            this.Column1.Name = "Column1";
            // 
            // coordinatesTable
            // 
            this.coordinatesTable.AllowUserToAddRows = false;
            this.coordinatesTable.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.coordinatesTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.coordinatesTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.coordinatesTable.Location = new System.Drawing.Point(822, 338);
            this.coordinatesTable.Name = "coordinatesTable";
            this.coordinatesTable.Size = new System.Drawing.Size(28, 46);
            this.coordinatesTable.TabIndex = 17;
            this.coordinatesTable.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.coordinatesTable_CellContentClick);
            // 
            // mainTab_dataGridView
            // 
            this.mainTab_dataGridView.AllowUserToAddRows = false;
            this.mainTab_dataGridView.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.mainTab_dataGridView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.mainTab_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.mainTab_dataGridView.Location = new System.Drawing.Point(573, 24);
            this.mainTab_dataGridView.Name = "mainTab_dataGridView";
            this.mainTab_dataGridView.Size = new System.Drawing.Size(607, 408);
            this.mainTab_dataGridView.TabIndex = 25;
            this.mainTab_dataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.mainTab_dataGridView_CellContentClick);
            this.mainTab_dataGridView.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.mainTab_dataGridView_CellValueChanged);
            // 
            // zoomX_label
            // 
            this.zoomX_label.AutoSize = true;
            this.zoomX_label.Location = new System.Drawing.Point(15, 30);
            this.zoomX_label.Name = "zoomX_label";
            this.zoomX_label.Size = new System.Drawing.Size(16, 16);
            this.zoomX_label.TabIndex = 32;
            this.zoomX_label.Text = "X";
            this.zoomX_toolTip.SetToolTip(this.zoomX_label, "Выставить по умолчанию - 1X");
            this.zoomX_label.Click += new System.EventHandler(this.zoomX_label_Click_1);
            // 
            // scale_groupBox
            // 
            this.scale_groupBox.BackColor = System.Drawing.Color.SandyBrown;
            this.scale_groupBox.Controls.Add(this.zoomPercent_label);
            this.scale_groupBox.Controls.Add(this.zoomX_label);
            this.scale_groupBox.Controls.Add(this.numericUpDown1);
            this.scale_groupBox.Controls.Add(this.trackBar1);
            this.scale_groupBox.Controls.Add(this.ScaleNUD);
            this.scale_groupBox.Font = new System.Drawing.Font("Arial Unicode MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.scale_groupBox.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.scale_groupBox.Location = new System.Drawing.Point(1186, 23);
            this.scale_groupBox.Name = "scale_groupBox";
            this.scale_groupBox.Size = new System.Drawing.Size(150, 172);
            this.scale_groupBox.TabIndex = 33;
            this.scale_groupBox.TabStop = false;
            this.scale_groupBox.Text = "Масштаб";
            // 
            // zoomPercent_label
            // 
            this.zoomPercent_label.AutoSize = true;
            this.zoomPercent_label.Location = new System.Drawing.Point(12, 73);
            this.zoomPercent_label.Name = "zoomPercent_label";
            this.zoomPercent_label.Size = new System.Drawing.Size(19, 16);
            this.zoomPercent_label.TabIndex = 33;
            this.zoomPercent_label.Text = "%";
            this.zoomPerCent_toolTip.SetToolTip(this.zoomPercent_label, "Выставить по умолчанию - 100%");
            this.zoomPercent_label.Click += new System.EventHandler(this.zoomPercent_label_Click_1);
            // 
            // DrawPanelForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.Bisque;
            this.ClientSize = new System.Drawing.Size(1362, 729);
            this.Controls.Add(this.scale_groupBox);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.TriangleInfo_dgv);
            this.Controls.Add(this.addEmptyVertex_btn);
            this.Controls.Add(this.mainTab_dataGridView);
            this.Controls.Add(this.example_button);
            this.Controls.Add(this.coordinatesTable);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.selectButton);
            this.Controls.Add(this.deleteALLButton);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.drawVertexButton);
            this.Font = new System.Drawing.Font("Arial Unicode MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DrawPanelForm";
            this.Text = "Конвективный перенос, СамГТУ 2018";
            this.Load += new System.EventHandler(this.DrawPanelForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.sheet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ScaleNUD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TriangleInfo_dgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.coordinatesTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainTab_dataGridView)).EndInit();
            this.scale_groupBox.ResumeLayout(false);
            this.scale_groupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox sheet;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.NumericUpDown ScaleNUD;
        private System.Windows.Forms.Button addEmptyVertex_btn;
        private System.Windows.Forms.DataGridView TriangleInfo_dgv;
        private System.Windows.Forms.Button drawVertexButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button deleteALLButton;
        private System.Windows.Forms.Button selectButton;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button example_button;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridView coordinatesTable;
        private System.Windows.Forms.DataGridView mainTab_dataGridView;
        private System.Windows.Forms.Label zoomX_label;
        private System.Windows.Forms.GroupBox scale_groupBox;
        private System.Windows.Forms.Label zoomPercent_label;
        private System.Windows.Forms.ToolTip zoomX_toolTip;
        private System.Windows.Forms.ToolTip zoomPerCent_toolTip;
        private System.Windows.Forms.ToolTip addVertex_toolTip;
        private System.Windows.Forms.ToolTip triangulate_toolTip;
    }
}

