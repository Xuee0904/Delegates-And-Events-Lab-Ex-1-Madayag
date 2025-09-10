using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Account_Registration
{
    public partial class FrmRegistration : Form
    {
        public FrmRegistration()
        {
            InitializeComponent();
            ProgramComboBox();

            NextButton.BackColor = ColorTranslator.FromHtml("#3A5A40");
            NextButton.ForeColor = ColorTranslator.FromHtml("#DFE6DA");

            label1.ForeColor = ColorTranslator.FromHtml("#000907");
            label3.ForeColor = ColorTranslator.FromHtml("#222021");
            label4.ForeColor = ColorTranslator.FromHtml("#222021");
            StudentNoLabel.ForeColor = ColorTranslator.FromHtml("#363636");
            ProgramLabel.ForeColor = ColorTranslator.FromHtml("#363636");
            FirstNameLabel.ForeColor = ColorTranslator.FromHtml("#363636");
            LastNameLabel.ForeColor = ColorTranslator.FromHtml("#363636");
            MiddleNameLabel.ForeColor = ColorTranslator.FromHtml("#363636");
            AgeLabel.ForeColor = ColorTranslator.FromHtml("#363636");
            GenderLabel.ForeColor = ColorTranslator.FromHtml("#363636");
            ContactNoLabel.ForeColor = ColorTranslator.FromHtml("#363636");
            BirthdayLabel.ForeColor = ColorTranslator.FromHtml("#363636");
            AddressLabel.ForeColor = ColorTranslator.FromHtml("#363636");
        }

        public void ProgramComboBox()
        {
            ProgramCombo.Items.Add("Bachelor of Science in Accountancy (BSA)");
            ProgramCombo.Items.Add("Bachelor of Science in Business Administration (BSBA)");
            ProgramCombo.Items.Add("Bachelor of Science in Computer Science (BSCS)");
            ProgramCombo.Items.Add("Bachelor of Science in Computer Engineering (BSCPE)");
            ProgramCombo.Items.Add("Bachelor of Science in Hospitality Management (BSHM)");
            ProgramCombo.Items.Add("Bachelor of Science in Information Technology (BSIT)");
            ProgramCombo.Items.Add("Bachelor of Science in Nursing (BSN)");
            ProgramCombo.Items.Add("Bachelor of Science in Psychology (BS Psychology)");
            ProgramCombo.Items.Add("Bachelor of Science in Tourism Management (BSTM)");
        }

        private void FrmRegistration_Load(object sender, EventArgs e)
        {
            this.BackColor = ColorTranslator.FromHtml("#F3F3F3");
        }

        private void NextButton_Click(object sender, EventArgs e)
        {
            StudentInfoClass.FirstName = FirstNameText.Text;
            StudentInfoClass.LastName = LastNameText.Text;
            StudentInfoClass.MiddleName = MiddleNameText.Text;
            StudentInfoClass.Address = AddressText.Text;
            StudentInfoClass.Program = ProgramCombo.Text;
            StudentInfoClass.Birthday = (BirthdayPicker.Value).ToString();
            StudentInfoClass.Age = long.Parse(AgeText.Text);
            StudentInfoClass.StudentNo = long.Parse(StudentNoText.Text);
            StudentInfoClass.ContactNo = long.Parse(ContactNoText.Text);

            if (MaleRB.Checked)
            {
                StudentInfoClass.Gender = "Male";
            }
            else if (FemaleRB.Checked)
            {
                StudentInfoClass.Gender = "Female";
            }
            else if (UnspecifiedRB.Checked)
            {
                StudentInfoClass.Gender = "Unspecified";
            }

            FrmConfirm studentConfirm = new FrmConfirm();

            if (studentConfirm.ShowDialog() == DialogResult.OK)
            {
                FirstNameText.Clear();
                MiddleNameText.Clear();
                LastNameText.Clear();
                AddressText.Clear();
                AgeText.Clear();
                ContactNoText.Clear();
                StudentNoText.Clear();

                ProgramCombo.SelectedIndex = -1;

                MaleRB.Checked = false;
                FemaleRB.Checked = false;
                UnspecifiedRB.Checked = false;
            }
            studentConfirm.Show();
            this.Hide();
        }

        private void AgeLabel_Click(object sender, EventArgs e)
        {

        }

    }
}
