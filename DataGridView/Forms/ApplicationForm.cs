using DataGridView.Standart.Contracts.Models;
using System;
using System.Drawing;
using System.Windows.Forms;


namespace DataGridView.Forms
{
    /// <summary>
    /// Форма для заполнения данных абитуриента
    /// </summary>
    public partial class ApplicationForm : Form
    {
        private ValidatableApplicant applicant;
        public ValidatableApplicant Applicant => applicant;

        public ApplicationForm(ValidatableApplicant data)
        {
            InitializeComponent();
            if (data == null)
            {
                applicant = new ValidatableApplicant();
            }
            else
            {
                applicant = data;
            }
            BindControls();
        }
        /// <summary>
        /// Привязка элементов к свойствам
        /// </summary>
        private void BindControls()
        {
            GenderBox.DataSource = Enum.GetValues(typeof(Gender));
            EducationBox.DataSource = Enum.GetValues(typeof(Education));

            NameBox.AddBinding(x => x.Text, applicant, x => x.Name, errorProvider);
            GenderBox.AddBinding(x => x.SelectedItem, applicant, x => x.Gender, errorProvider);
            DateBox.AddBinding(x => x.Value, applicant, x => x.Birthday, errorProvider);
            EducationBox.AddBinding(x => x.SelectedItem, applicant, x => x.Education, errorProvider);
            MathNumeric.AddBinding(x => x.Value, applicant, x => x.Math, errorProvider);
            RussianNumeric.AddBinding(x => x.Value, applicant, x => x.Russian, errorProvider);
            CSNumeric.AddBinding(x => x.Value, applicant, x => x.ComputerScience, errorProvider);
        }
        private void materialCB_DrawItem(object sender, DrawItemEventArgs e)
        {
            e.DrawBackground();

            var value = (Education)(sender as ComboBox).Items[e.Index];

            e.Graphics.DrawString(value.GetDisplay(),
                e.Font,
                new SolidBrush(e.ForeColor),
                e.Bounds.X,
                e.Bounds.Y);
        }
        private void UpdateResultScore(object sender, EventArgs e)
        {
            try
            {
                ResultBox.Text = (MathNumeric.Value + RussianNumeric.Value + CSNumeric.Value).ToString();
            }
            catch(Exception ex)
            {
                errorProvider.SetError(ResultBox, "Ошибка при подсчёте результата: " + ex.Message);
            }
        }

        private void OkButton_Click(object sender, EventArgs e)
        {
            if (!applicant.ValidateApplicant())
            {
                MessageBox.Show("Проверьте введенные данные.");
                return;
            }
            DialogResult = DialogResult.OK;
            Close();
        }

        private void GenderBox_DrawItem(object sender, DrawItemEventArgs e)
        {
            e.DrawBackground();

            var value = (Gender)(sender as ComboBox).Items[e.Index];

            e.Graphics.DrawString(value.GetDisplay(),
                e.Font,
                new SolidBrush(e.ForeColor),
                e.Bounds.X,
                e.Bounds.Y);
        }
    }
}
