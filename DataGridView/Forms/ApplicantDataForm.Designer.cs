namespace DataGridView.Forms
{
    partial class ApplicantDataForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
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
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ApplicantDataForm));
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripBtn_Add = new System.Windows.Forms.ToolStripButton();
            this.toolStripBtn_Edit = new System.Windows.Forms.ToolStripButton();
            this.toolStripBtn_Delete = new System.Windows.Forms.ToolStripButton();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel4 = new System.Windows.Forms.ToolStripStatusLabel();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GenderColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BirthdayColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EducationColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MathColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RussianColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ComputerScienceColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalScoreColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AllowUserToDeleteRows = false;
            this.dataGridView.BackgroundColor = System.Drawing.Color.DarkGray;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.NameColumn,
            this.GenderColumn,
            this.BirthdayColumn,
            this.EducationColumn,
            this.MathColumn,
            this.RussianColumn,
            this.ComputerScienceColumn,
            this.TotalScoreColumn});
            this.dataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView.Location = new System.Drawing.Point(0, 25);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.Size = new System.Drawing.Size(800, 403);
            this.dataGridView.TabIndex = 12;
            this.dataGridView.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataGridView_CellFormatting);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripBtn_Add,
            this.toolStripBtn_Edit,
            this.toolStripBtn_Delete});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 25);
            this.toolStrip1.TabIndex = 10;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripBtn_Add
            // 
            this.toolStripBtn_Add.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripBtn_Add.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripBtn_Add.Name = "toolStripBtn_Add";
            this.toolStripBtn_Add.Size = new System.Drawing.Size(23, 22);
            this.toolStripBtn_Add.Text = "toolStripAdd";
            this.toolStripBtn_Add.Click += new System.EventHandler(this.toolStripBtn_Add_Click);
            // 
            // toolStripBtn_Edit
            // 
            this.toolStripBtn_Edit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripBtn_Edit.Image = ((System.Drawing.Image)(resources.GetObject("toolStripBtn_Edit.Image")));
            this.toolStripBtn_Edit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripBtn_Edit.Name = "toolStripBtn_Edit";
            this.toolStripBtn_Edit.Size = new System.Drawing.Size(23, 22);
            this.toolStripBtn_Edit.Text = "toolStripEdit";
            this.toolStripBtn_Edit.Click += new System.EventHandler(this.toolStripBtn_Edit_Click);
            // 
            // toolStripBtn_Delete
            // 
            this.toolStripBtn_Delete.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripBtn_Delete.Image = ((System.Drawing.Image)(resources.GetObject("toolStripBtn_Delete.Image")));
            this.toolStripBtn_Delete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripBtn_Delete.Name = "toolStripBtn_Delete";
            this.toolStripBtn_Delete.Size = new System.Drawing.Size(23, 22);
            this.toolStripBtn_Delete.Text = "toolStripDelete";
            this.toolStripBtn_Delete.Click += new System.EventHandler(this.toolStripBtn_Delete_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripStatusLabel2,
            this.toolStripStatusLabel3,
            this.toolStripStatusLabel4});
            this.statusStrip1.Location = new System.Drawing.Point(0, 428);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(800, 22);
            this.statusStrip1.TabIndex = 11;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(118, 17);
            this.toolStripStatusLabel1.Text = "toolStripStatusLabel1";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(118, 17);
            this.toolStripStatusLabel2.Text = "toolStripStatusLabel2";
            // 
            // toolStripStatusLabel3
            // 
            this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            this.toolStripStatusLabel3.Size = new System.Drawing.Size(118, 17);
            this.toolStripStatusLabel3.Text = "toolStripStatusLabel3";
            // 
            // toolStripStatusLabel4
            // 
            this.toolStripStatusLabel4.Name = "toolStripStatusLabel4";
            this.toolStripStatusLabel4.Size = new System.Drawing.Size(118, 17);
            this.toolStripStatusLabel4.Text = "toolStripStatusLabel4";
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Visible = false;
            // 
            // NameColumn
            // 
            this.NameColumn.DataPropertyName = "Name";
            this.NameColumn.HeaderText = "ФИО";
            this.NameColumn.Name = "NameColumn";
            this.NameColumn.ReadOnly = true;
            // 
            // GenderColumn
            // 
            this.GenderColumn.DataPropertyName = "Gender";
            this.GenderColumn.HeaderText = "Пол";
            this.GenderColumn.Name = "GenderColumn";
            this.GenderColumn.ReadOnly = true;
            // 
            // BirthdayColumn
            // 
            this.BirthdayColumn.DataPropertyName = "Birthday";
            this.BirthdayColumn.HeaderText = "Дата рождения";
            this.BirthdayColumn.Name = "BirthdayColumn";
            this.BirthdayColumn.ReadOnly = true;
            // 
            // EducationColumn
            // 
            this.EducationColumn.DataPropertyName = "Education";
            this.EducationColumn.HeaderText = "Форма обучения";
            this.EducationColumn.Name = "EducationColumn";
            this.EducationColumn.ReadOnly = true;
            this.EducationColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.EducationColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // MathColumn
            // 
            this.MathColumn.DataPropertyName = "Math";
            this.MathColumn.HeaderText = "Математика";
            this.MathColumn.Name = "MathColumn";
            this.MathColumn.ReadOnly = true;
            this.MathColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.MathColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // RussianColumn
            // 
            this.RussianColumn.DataPropertyName = "Russian";
            this.RussianColumn.HeaderText = "Русский";
            this.RussianColumn.Name = "RussianColumn";
            this.RussianColumn.ReadOnly = true;
            this.RussianColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.RussianColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // ComputerScienceColumn
            // 
            this.ComputerScienceColumn.DataPropertyName = "ComputerScience";
            this.ComputerScienceColumn.HeaderText = "Информатика";
            this.ComputerScienceColumn.Name = "ComputerScienceColumn";
            this.ComputerScienceColumn.ReadOnly = true;
            this.ComputerScienceColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // TotalScoreColumn
            // 
            this.TotalScoreColumn.DataPropertyName = "TotalScore";
            this.TotalScoreColumn.HeaderText = "Сумма баллов";
            this.TotalScoreColumn.Name = "TotalScoreColumn";
            this.TotalScoreColumn.ReadOnly = true;
            this.TotalScoreColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // ApplicantDataForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.statusStrip1);
            this.Name = "ApplicantDataForm";
            this.Text = "Данные абитуриента";
            this.Load += new System.EventHandler(this.ApplicantDataForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripBtn_Add;
        private System.Windows.Forms.ToolStripButton toolStripBtn_Edit;
        private System.Windows.Forms.ToolStripButton toolStripBtn_Delete;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel3;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn GenderColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn BirthdayColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn EducationColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn MathColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn RussianColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ComputerScienceColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalScoreColumn;
    }
}

