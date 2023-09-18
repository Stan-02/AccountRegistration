using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ED_Lab1
{
    public partial class FrmConfirm : Form
    {
        private DelegateText DelProgram, DelLastName, DelFirstName, DelMiddleName, DelAddress;
        private DelegateNumber DelNumAge, DelNumContact, DelNumSudentNo;

        public FrmConfirm()
        {
            InitializeComponent();

            DelProgram = new DelegateText(StudentInfoClass.GetProgram);
            DelLastName = new DelegateText(StudentInfoClass.GetLastName);
            DelFirstName = new DelegateText(StudentInfoClass.GetFirstName);
            DelMiddleName = new DelegateText(StudentInfoClass.GetMiddleName);
            DelAddress = new DelegateText(StudentInfoClass.GetAddress);
            DelNumAge = new DelegateNumber(StudentInfoClass.GetAge);
            DelNumContact = new DelegateNumber(StudentInfoClass.GetContact);
            DelNumSudentNo = new DelegateNumber(StudentInfoClass.GetStudentNo);
        }

        private void FrmConfirm_Load(object sender, EventArgs e)
        {
            lblStudentNo.Text = DelNumSudentNo(StudentInfoClass.StudentNo).ToString();
            lblProg.Text = DelProgram(StudentInfoClass.Program);
            lblFirst.Text = DelFirstName(StudentInfoClass.FirstName);
            lblMiddle.Text = DelMiddleName(StudentInfoClass.MiddleName);
            lblLast.Text = DelLastName(StudentInfoClass.LastName);
            lblAge.Text = DelNumAge(StudentInfoClass.Age).ToString();
            lblContact.Text = DelNumContact(StudentInfoClass.ContactNo).ToString();
            lblAddress.Text = DelAddress(StudentInfoClass.Address);
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
