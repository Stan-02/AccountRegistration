namespace ED_Lab1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void ShowDialog()
        {
            FrmConfirm confirm = new FrmConfirm();

            if (confirm.ShowDialog() == DialogResult.OK)
            {
                txtStudentNo.ResetText();
                txtFirst.ResetText();
                txtLast.ResetText();
                txtMiddle.ResetText();
                txtAge.ResetText();
                txtContact.ResetText();
                txtAddress.ResetText();
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            StudentInfoClass.FirstName = txtFirst.Text.ToString();
            StudentInfoClass.MiddleName = txtMiddle.Text.ToString();
            StudentInfoClass.LastName = txtLast.Text.ToString();
            StudentInfoClass.Address = txtAddress.Text.ToString();
            StudentInfoClass.Age = long.Parse(txtAge.Text);
            StudentInfoClass.ContactNo = long.Parse(txtContact.Text);
            StudentInfoClass.StudentNo = long.Parse(txtStudentNo.Text);
            StudentInfoClass.Program = cbProg.Text.ToString();
            ShowDialog();
        }
    }
}