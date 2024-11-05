using Library.Contracts.Models;
using System;
using System.Drawing;
using System.Windows.Forms;


namespace DataGridView
{
    public partial class ApplicationForm : Form
    {
        private readonly ValidatableApplicant applicant;

        public ValidatableApplicant ValidateApplicant => applicant;
        public ApplicationForm(ValidatableApplicant outApplicant = null)
        {
            InitializeComponent();
            applicant = outApplicant == null ?
                new ValidatableApplicant()
                {
                    Id = Guid.NewGuid(),
                    Name = "ФИО",
                    Gender = Gender.Male,
                    Birthday = DateTime.Now.AddYears(-12),
                    Education = Education.FullTime,
                    Math = 50,
                    Russian = 50,
                    ComputerScience = 50,
                }
                : new ValidatableApplicant()
                {
                    Id = outApplicant.Id,
                    Name = outApplicant.Name,
                    Gender = outApplicant.Gender,
                    Birthday = outApplicant.Birthday,
                    Education = outApplicant.Education,
                    Math = outApplicant.Math,
                    Russian = outApplicant.Russian,
                    ComputerScience = outApplicant.ComputerScience,
                };


            NameBox.AddBinding(x => x.Text, applicant, x => x.Name, errorProvider);
            GenderBox.DataSource = Enum.GetValues(typeof(Gender));
            DateBox.AddBinding(x => x.Value, applicant, x => x.Birthday, errorProvider);
            EducationBox.DataSource = Enum.GetValues(typeof(Education));
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

        private void resultScores(object sender, EventArgs e)
        {
            ResultBox.Text = (MathNumeric.Value + RussianNumeric.Value + CSNumeric.Value).ToString();
        }

        private void OkButton_Click(object sender, EventArgs e)
        {
            if (applicant.ValidateApplicant())
            {
                DialogResult = DialogResult.OK;
                Close();
            }
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
