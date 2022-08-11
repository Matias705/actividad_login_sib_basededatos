namespace Login
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

   
        private void Form1_Click(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "") 
            {
                MessageBox.Show("Se debe ingresar un usuario.");
                return;
            }

            if (txtPassword.Text == "")
            {
                MessageBox.Show("Se debe ingresar una constrsena.");
                return;
            }


        }

        private void btn_IngresarClick(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "")
            {
                MessageBox.Show("Se debe ingresar un usuario.");
                return;
            }

            if (txtPassword.Text == "")
            {
                MessageBox.Show("Se debe ingresar una constrsena.");
                return;
            }

            MessageBox.Show("Usted ha ingresado al sistema");
            this.Close();
        }

            

    }
}