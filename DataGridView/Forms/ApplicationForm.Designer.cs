namespace DataGridView
{
    partial class ApplicationForm
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
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.ResultBox = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.RussianNumeric = new System.Windows.Forms.NumericUpDown();
            this.MathNumeric = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.CSNumeric = new System.Windows.Forms.NumericUpDown();
            this.EducationBox = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.DateBox = new System.Windows.Forms.DateTimePicker();
            this.GenderBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.NameBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.RussianNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MathNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CSNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button2.Location = new System.Drawing.Point(179, 285);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 24);
            this.button2.TabIndex = 3;
            this.button2.Text = "Отмена";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(48, 285);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 24);
            this.button1.TabIndex = 2;
            this.button1.Text = "ОК";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.OkButton_Click);
            // 
            // ResultBox
            // 
            this.ResultBox.Enabled = false;
            this.ResultBox.Location = new System.Drawing.Point(108, 233);
            this.ResultBox.Name = "ResultBox";
            this.ResultBox.Size = new System.Drawing.Size(203, 20);
            this.ResultBox.TabIndex = 8;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(8, 236);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(80, 13);
            this.label10.TabIndex = 47;
            this.label10.Text = "Сумма баллов";
            // 
            // RussianNumeric
            // 
            this.RussianNumeric.Location = new System.Drawing.Point(108, 181);
            this.RussianNumeric.Name = "RussianNumeric";
            this.RussianNumeric.Size = new System.Drawing.Size(203, 20);
            this.RussianNumeric.TabIndex = 6;
            this.RussianNumeric.ValueChanged += new System.EventHandler(this.resultScores);
            // 
            // MathNumeric
            // 
            this.MathNumeric.Location = new System.Drawing.Point(108, 155);
            this.MathNumeric.Name = "MathNumeric";
            this.MathNumeric.Size = new System.Drawing.Size(203, 20);
            this.MathNumeric.TabIndex = 5;
            this.MathNumeric.ValueChanged += new System.EventHandler(this.resultScores);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(8, 209);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(78, 13);
            this.label9.TabIndex = 46;
            this.label9.Text = "Информатика";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(8, 183);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(49, 13);
            this.label8.TabIndex = 45;
            this.label8.Text = "Русский";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(8, 157);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 13);
            this.label7.TabIndex = 44;
            this.label7.Text = "Математика";
            // 
            // CSNumeric
            // 
            this.CSNumeric.Location = new System.Drawing.Point(108, 207);
            this.CSNumeric.Name = "CSNumeric";
            this.CSNumeric.Size = new System.Drawing.Size(203, 20);
            this.CSNumeric.TabIndex = 7;
            this.CSNumeric.ValueChanged += new System.EventHandler(this.resultScores);
            // 
            // EducationBox
            // 
            this.EducationBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.EducationBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.EducationBox.FormattingEnabled = true;
            this.EducationBox.Location = new System.Drawing.Point(108, 128);
            this.EducationBox.Name = "EducationBox";
            this.EducationBox.Size = new System.Drawing.Size(203, 21);
            this.EducationBox.TabIndex = 4;
            this.EducationBox.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.materialCB_DrawItem);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 131);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 13);
            this.label4.TabIndex = 39;
            this.label4.Text = "Форма обучения";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 13);
            this.label3.TabIndex = 38;
            this.label3.Text = "Дата рождения";
            // 
            // DateBox
            // 
            this.DateBox.Location = new System.Drawing.Point(108, 104);
            this.DateBox.Name = "DateBox";
            this.DateBox.Size = new System.Drawing.Size(203, 20);
            this.DateBox.TabIndex = 3;
            // 
            // GenderBox
            // 
            this.GenderBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.GenderBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.GenderBox.FormattingEnabled = true;
            this.GenderBox.Location = new System.Drawing.Point(108, 76);
            this.GenderBox.Name = "GenderBox";
            this.GenderBox.Size = new System.Drawing.Size(203, 21);
            this.GenderBox.TabIndex = 2;
            this.GenderBox.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.GenderBox_DrawItem);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 13);
            this.label2.TabIndex = 35;
            this.label2.Text = "Пол";
            // 
            // NameBox
            // 
            this.NameBox.Location = new System.Drawing.Point(108, 49);
            this.NameBox.Name = "NameBox";
            this.NameBox.Size = new System.Drawing.Size(203, 20);
            this.NameBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 33;
            this.label1.Text = "ФИО";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(6, 15);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(169, 20);
            this.label5.TabIndex = 49;
            this.label5.Text = "Данные абитуриента";
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // ApplicationAddForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(322, 321);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.ResultBox);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.RussianNumeric);
            this.Controls.Add(this.MathNumeric);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.CSNumeric);
            this.Controls.Add(this.EducationBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.DateBox);
            this.Controls.Add(this.GenderBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.NameBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "ApplicationAddForm";
            this.Text = "Добавление абитуриента";
            ((System.ComponentModel.ISupportInitialize)(this.RussianNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MathNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CSNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox ResultBox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.NumericUpDown RussianNumeric;
        private System.Windows.Forms.NumericUpDown MathNumeric;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown CSNumeric;
        private System.Windows.Forms.ComboBox EducationBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker DateBox;
        private System.Windows.Forms.ComboBox GenderBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox NameBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ErrorProvider errorProvider;
    }
}