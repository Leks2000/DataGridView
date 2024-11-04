using Library.Contracts;
using System;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace DataGridView
{
    public partial class ApplicantData : Form
    {
        private IApplicantManager applicantManager;
        private BindingSource bindingSource;
        public ApplicantData()
        {
            InitializeComponent();
        }
        private void toolStripBtn_Add_Click(object sender, EventArgs e)
        {
            var applicantsForm = new ApplicationAdd();
            if (applicantsForm.ShowDialog(this) == DialogResult.OK)
            {
                //applicantManager.AddApplicant());
                bindingSource.ResetBindings(false);
                SetStatus();
            }
        }
        public void SetStatus()
        {
            var result = applicantManager.GetStatsApplicant();
            toolStripStatusLabel1.Text = $"Всего: {result.Result.Count}";
            toolStripStatusLabel2.Text = $"{result.Result.FemaleCount} Ж/{result.Result.MaleCount} М";
            toolStripStatusLabel3.Text = $"Студенты, набравшие больше 150 баллов в сумме: {result.Result.TotalScoreCount}";
        }
    }
}