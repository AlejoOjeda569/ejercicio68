using Microsoft.VisualBasic.Devices;

namespace WinFormsEjecicio68
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (validarDatos())
            {
                var numero = int.Parse(txtNumero.Text);
                DataGridViewRow r = construirfila();
                setearfila(r, numero);
                Agregarfila(r);

            }
        }

        private void inicializarcontroles()
        {
            txtNumero.Clear();
            txtNumero.Focus();
        }

        private void Agregarfila(DataGridViewRow r)
        {
            dgvfactor.Rows.Add(r);
        }

        private int calcularfactor(int numero)
        {
            int contador = 1;
            int factor = 1;
            do
            {
                factor = factor * contador;
                contador++;
            } while (contador <= numero);
            return factor;
        }

        private void setearfila(DataGridViewRow r, int numero)
        {
            r.Cells[ColNumero.Index].Value = numero;
            r.Cells[ColFactor.Index].Value = calcularfactor(numero);
        }

        private DataGridViewRow construirfila()
        {
            DataGridViewRow r = new DataGridViewRow();
            r.CreateCells(dgvfactor);
            return r;
        }

        private bool validarDatos()
        {
            bool Esvalido = true;
            errorProvider1.Clear();
            if (!int.TryParse(txtNumero.Text, out int nro))
            {
                Esvalido = false;
                errorProvider1.SetError(txtNumero, "Nro fuera de la linea");
            }
            return Esvalido;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            inicializarcontroles();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("¿Estas seguro?", "Confirmación",
               MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resultado == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}