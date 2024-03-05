namespace Uni4._1
{
    public partial class Form1 : Form
    {
        Employee myEmployee = new Employee();
        Nominating myNominating = new Nominating();
        public Form1()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnGetOut_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        //Almacen de registros
        private void btnStorageRegistration_Click(object sender, EventArgs e)
        {
            if(txtName.Text == "")
            {
                error1.SetError(txtName, "You need to enter a name");
                txtName.Focus();
                return;
            }
            error1.SetError(txtName, "");
            // Validar que solo permita ingresar datos numericos
            decimal asignacionDia;
            if (!Decimal.TryParse(txtDayAsign.Text, out asignacionDia))
            {
                error1.SetError(txtDayAsign, "You need to enter a numbre");
                txtName.Focus();
                return;
            }
            error1.SetError(txtDayAsign, "");

            myEmployee.Name = txtName.Text;
            myEmployee.Identification = txtIdentification.Text;
            myEmployee.DayAssignment = Convert.ToDecimal(txtDayAsign.Text);
            myNominating.Workingdays = Convert.ToInt32(txtDaysWorking.Text);
            MessageBox.Show("Record was saved successfully");
        }




        private void txtName_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCalculateSalary_Click(object sender, EventArgs e)
        {
            txtTotalDevengado.Text = myNominating.CalculateNom(Convert.ToInt32(myNominating.Workingdays), Convert.ToDecimal(myEmployee.DayAssignment)).ToString();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            txtName.Clear();
            txtIdentification.Clear();
            txtDayAsign.Clear();
            txtDaysWorking.Clear(); 
            txtTotalDevengado.Clear();
        }
    }
}

