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
    public partial class FrmConfirm : Form
    {
        //private StudentInfoClass.DelegateText delegateFirstName, delegateMiddleName, delegateLastName, delegateAddress, delegateProgram, delegateGender, delegateBirthday;

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void FrmConfirm_Load(object sender, EventArgs e)
        {
            this.BackColor = ColorTranslator.FromHtml("#F3F3F3");
        }

        //private StudentInfoClass.DelegateNumber delegateAge, delegateStudentNumber, delegateContactNumber;

        public FrmConfirm()
        {
            InitializeComponent();

            SubmitButton.BackColor = ColorTranslator.FromHtml("#3A5A40");
            SubmitButton.ForeColor = ColorTranslator.FromHtml("#DFE6DA");

            //delegateFirstName = new StudentInfoClass.DelegateText(StudentInfoClass.GetFirstName);
            //delegateMiddleName = new StudentInfoClass.DelegateText(StudentInfoClass.GetMiddleName);
            //delegateLastName = new StudentInfoClass.DelegateText(StudentInfoClass.GetLastName);
            //delegateAddress = new StudentInfoClass.DelegateText(StudentInfoClass.GetAddress);
            //delegateProgram = new StudentInfoClass.DelegateText(StudentInfoClass.GetProgram);
            //delegateGender = new StudentInfoClass.DelegateText(StudentInfoClass.GetGender);
            //delegateBirthday = new StudentInfoClass.DelegateText(StudentInfoClass.GetBirthday);
            /*delegateAge = new StudentInfoClass.DelegateNumber(StudentInfoClass.GetAge);
            delegateStudentNumber = new StudentInfoClass.DelegateNumber(StudentInfoClass.GetStudentNo);
            delegateContactNumber = new StudentInfoClass.DelegateNumber(StudentInfoClass.GetContactNo);*/

            //StudentNoResult.Text = delegateStudentNumber(StudentInfoClass.StudentNo).ToString();
            //ProgramResult.Text = delegateProgram(StudentInfoClass.Program);
            //NameResult.Text = delegateLastName(StudentInfoClass.LastName + " , " + StudentInfoClass.FirstName + " , " + StudentInfoClass.MiddleName);
            //GenderResult.Text = delegateGender(StudentInfoClass.Gender);
            //BirthdayResult.Text = delegateBirthday(StudentInfoClass.Birthday);
            //AgeResult.Text = delegateAge(StudentInfoClass.Age).ToString();
            //ContactNoResult.Text = delegateContactNumber(StudentInfoClass.ContactNo).ToString();
            //AddressResult.Text = delegateAddress(StudentInfoClass.Address);
        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            MessageBox.Show("Registration done! ^^");
            this.Close();
        }
    }
}
