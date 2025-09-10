using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Account_Registration
{
    public partial class FrmRegistration : Form
    {
        StudentInfoClass studentInfoClass;

        private string _FullName;
        private int _Age;
        private long _ContactNo;
        private long _StudentNo;

        public FrmRegistration()
        {
            InitializeComponent();
            ProgramComboBox();

            studentInfoClass = new StudentInfoClass();

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

            string[] ListOfPrograms = new string[]
            {
                "Bachelor of Science in Accountancy (BSA)",
                "Bachelor of Science in Business Administration (BSBA)",
                "Bachelor of Science in Computer Science (BSCS)",
                "Bachelor of Science in Computer Engineering (BSCPE)",
                "Bachelor of Science in Hospitality Management (BSHM)",
                "Bachelor of Science in Information Technology (BSIT)",
                "Bachelor of Science in Nursing (BSN)",
                "Bachelor of Science in Psychology (BS Psychology)",
                "Bachelor of Science in Tourism Management (BSTM)"
        };
            for (int i = 0; i < 9; i++)
            {
                ProgramCombo.Items.Add(ListOfPrograms[i].ToString());
            }
        }

        public void ProgramComboBox()
        {
       
        }

        private void FrmRegistration_Load(object sender, EventArgs e)
        {
            this.BackColor = ColorTranslator.FromHtml("#F3F3F3");
        }

        private void NextButton_Click(object sender, EventArgs e)
        {
            StudentInfoClass.SetFullName = FullName(LastNameText.Text,FirstNameText.Text, MiddleNameText.Text);
            StudentInfoClass.SetStudentNo = (int)StudentNumber(StudentNoText.Text);
            StudentInfoClass.SetProgram = ProgramCombo.Text;
            StudentInfoClass.SetContactNo = (int)ContactNo(ContactNoText.Text);
            StudentInfoClass.SetAge = Age(AgeText.Text);
            StudentInfoClass.SetBirthday = BirthdayPicker.Value.ToString("yyyyMM-dd");

            if (MaleRB.Checked)
            {
                StudentInfoClass.SetGender = "Male";
            }
            else if (FemaleRB.Checked)
            {
                StudentInfoClass.SetGender = "Female";
            }
            else if (UnspecifiedRB.Checked)
            {
                StudentInfoClass.SetGender = "Unspecified";
            }


            FrmConfirm studentConfirm = new FrmConfirm();
            studentConfirm.ShowDialog();

            //StudentInfoClass.FirstName = FirstNameText.Text;
            //StudentInfoClass.LastName = LastNameText.Text;
            //StudentInfoClass.MiddleName = MiddleNameText.Text;
            
            //StudentInfoClass.Program = ProgramCombo.Text;
            //StudentInfoClass.Birthday = (BirthdayPicker.Value).ToString();
            //StudentInfoClass.Age = long.Parse(AgeText.Text);
            //StudentInfoClass.StudentNo = long.Parse(StudentNoText.Text);
            //StudentInfoClass.ContactNo = long.Parse(ContactNoText.Text);

            


            if (studentConfirm.ShowDialog() == DialogResult.OK)
            {
                FirstNameText.Clear();
                MiddleNameText.Clear();
                LastNameText.Clear();
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

        /////return methods 
        public long StudentNumber(string studNum)
        {

            _StudentNo = long.Parse(studNum);

            return _StudentNo;
        }

        public long ContactNo(string Contact)
        {
            if (Regex.IsMatch(Contact, @"^[0-9]{10,11}$"))
            {
                _ContactNo = long.Parse(Contact);
            }

            return _ContactNo;
        }

        public string FullName(string LastName, string FirstName, string MiddleInitial)
        {
            if (Regex.IsMatch(LastName, @"^[a-zA-Z]+$") || Regex.IsMatch(FirstName, @"^[a-zA-Z]+$") || Regex.IsMatch(MiddleInitial, @"^[a-zA-Z]+$"))
            {
                _FullName = LastName + ", " + FirstName + ", " + MiddleInitial;
            }

            return _FullName;
        }

        public int Age(string age)
        {
            if (Regex.IsMatch(age, @"^[0-9]{1,3}$"))
            {
                _Age = Int32.Parse(age);
            }

            return _Age;
        }

    }
}
