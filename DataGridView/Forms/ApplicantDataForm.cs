using DataGridView.Standart.Contracts.Interfaces;
using DataGridView.Standart.Contracts.Models;
using System;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataGridView.Forms
{
    public partial class ApplicantDataForm : Form
    {
        private readonly IApplicantManager applicantManager;
        private readonly BindingSource bindingSource;
        public ApplicantDataForm(IApplicantManager manager)
        {
            applicantManager = manager;
            bindingSource = new BindingSource();

            InitializeComponent();

            dataGridView.AutoGenerateColumns = false;
            dataGridView.DataSource = bindingSource;
        }
        private async void toolStripBtn_Add_Click(object sender, EventArgs e)
        {
            var applicantsForm = new ApplicationForm();
            if (applicantsForm.ShowDialog(this) == DialogResult.OK)
            {
                await applicantManager.AddAsync(ValidateConvert.ToValidateApplicant(applicantsForm.ValidateApplicant));
                await SetStatus();
            }
        }
        public async Task SetStatus()
        {
            bindingSource.ResetBindings(false);
            var result = await applicantManager.GetStatsAsync();
            toolStripStatusLabel1.Text = $"Всего абитуриентов: {result.Count}";
            toolStripStatusLabel2.Text = $"Ж {result.FemaleCount} /М {result.MaleCount}";
            toolStripStatusLabel3.Text = $"Студенты, набравшие больше 150 баллов в сумме: {result.TotalScoreCount}";
            toolStripStatusLabel4.Text = $"Очный {result.FullTimeCount} / Oчно-Заочный {result.FullTimePartTimeCount} / Заочный {result.СorrespondenceCount}";

        }

        private async void toolStripBtn_Edit_Click(object sender, EventArgs e)
        {
            if (dataGridView.SelectedRows.Count != 0)
            {
                var data = GetSelectedApplication();
                var applicantsForm = new ApplicationForm(ValidateConvert.ToApplicant(data));
                if (applicantsForm.ShowDialog(this) == DialogResult.OK)
                {
                    await applicantManager.EditAsync(ValidateConvert.ToValidateApplicant(applicantsForm.ValidateApplicant));
                    await SetStatus();
                }
            }
        }
        private Applicant GetSelectedApplication()
        {
            return (Applicant)dataGridView.Rows[dataGridView.SelectedRows[0].Index].DataBoundItem;
        }

        private async void toolStripBtn_Delete_Click(object sender, EventArgs e)
        {
            if (dataGridView.SelectedRows.Count != 0)
            {
                var data = GetSelectedApplication();
                if (MessageBox.Show($"Вы действительно хотите удалить абитуриента '{data.Name}'?", "Удаление записи", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    await applicantManager.DeleteAsync(data.Id);
                    await SetStatus();
                }
            }
        }

        private async void ApplicantDataForm_Load(object sender, EventArgs e)
        {
            bindingSource.DataSource = await applicantManager.GetAllAsync();
            await SetStatus();
        }
    }
}