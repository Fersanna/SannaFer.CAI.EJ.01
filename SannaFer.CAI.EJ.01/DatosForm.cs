namespace SannaFer.CAI.EJ._01
{
    public partial class DatosForm : Form
    {
        DatosFormModel model;

        public DatosForm()
        {
            InitializeComponent();
        }



        private void DatosForm_Load(object sender, EventArgs e)
        {
            model = new DatosFormModel();

          



        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void DocText_TextChanged(object sender, EventArgs e)
        {

        }

        private void NombreText_TextChanged(object sender, EventArgs e)
        {

        }

        private void ApellidoText_TextChanged(object sender, EventArgs e)
        {

        }

        private void FechaText_TextChanged(object sender, EventArgs e)
        {

        }



        private void AceptarBtn_Click(object sender, EventArgs e)
        {
            model.Documento = (String)DocumentoText.Text;
            model.Nombre = NombreText.Text;
            model.Apellido = ApellidoText.Text;
            model.FechaNacimiento = FechaText.Text;

            string mensaje = model.validar();
            MessageBox.Show(mensaje);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            var mensaje = "Esta seguro que desea cancelar la edision?";
            var resultado = MessageBox.Show(mensaje, "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resultado == DialogResult.Yes)
            {
                this.Close();
            }



        }
    }
}