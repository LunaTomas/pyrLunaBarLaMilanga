using System.Text.Encodings.Web;

namespace pyrLunaBarLaMilanga
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }
        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            //agregar columnas por codigo
            /*string[] columnas = { "Comidas", "Bebidas sin alcohol", "Bebidas con alcohol", "Postres" };
            dgvVentas.ColumnCount = columnas.Length;
            for (int i = 0; i < columnas.Length; i++)
            {
                dgvVentas.Columns[i].Name = columnas[i];
                dgvVentas.Columns[i].HeaderText = columnas[i];
            }*/ //este si me anda

            //agregar mozos 
            /*dgvVentas.Rows.Add("Julio");
            dgvVentas.Rows.Add("Esteban");
            dgvVentas.Rows.Add("Javier");
            dgvVentas.Rows.Add("Gonzalo");
            dgvVentas.Rows.Add("Alberto");*/ //esto da error pq mete el nombre del mozo en la columna y no en el encabezado
            string[] mozos = { "Julio", "Esteban", "Javier", "Gonzalo", "Alberto" };
            foreach (string mozo in mozos)
            {
                int index = dgvVentas.Rows.Add();
                dgvVentas.Rows[index].HeaderCell.Value = mozo;
            }
            //cosas visuales
            dgvVentas.DefaultCellStyle.Font = new Font("Segoe UI", 12F, FontStyle.Regular);
            dgvVentas.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            dgvVentas.RowHeadersDefaultCellStyle.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            dgvVentas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvVentas.AllowUserToAddRows = false;
            dgvVentas.AllowUserToDeleteRows = false;
            dgvVentas.RowHeadersWidth = 100;
            btnMozoDelDia.Enabled = false;
            btnTotales.Enabled = false;
            //inicializar la grilla con ceros
            for (int i = 0; i < dgvVentas.Rows.Count; i++)
            {
                for (int j = 0; j < dgvVentas.Columns.Count; j++)
                {
                    dgvVentas.Rows[i].Cells[j].Value = "0";
                }
            }
        }
        private void btnValidar_Click(object sender, EventArgs e)
        {
            bool datosValidos = true;
            //recorrer la grilla
            for (int i = 0; i < dgvVentas.Rows.Count; i++)
            {
                for (int j = 0; j < dgvVentas.Columns.Count; j++)
                {
                    object valor = dgvVentas.Rows[i].Cells[j].Value;
                    //validar que no este vacio
                    if (valor == null || string.IsNullOrWhiteSpace(valor.ToString()))
                    {
                        datosValidos = false;
                        break;
                    }
                    //validar que sean numeros
                    if (!float.TryParse(valor.ToString(), out _))
                    {
                        datosValidos = false;
                        break;
                    }//esto ya no sirve porque no se pueden poner letras en la grilla
                }
                if (!datosValidos)
                    break;
            }
            //muestro el resultado
            if (!datosValidos)
            {
                MessageBox.Show("Error: todas las celdas deben contener valores numéricos (puede ser 0).",
                                "Datos inválidos",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                btnMozoDelDia.Enabled = false;
                btnTotales.Enabled = false;
            }
            else
            {
                MessageBox.Show("Datos validados correctamente.",
                                "Éxito",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
                btnMozoDelDia.Enabled = true;
                btnTotales.Enabled = true;
            }
        }
        private void btnMozoDelDia_Click(object sender, EventArgs e)
        {
            string[] mozos = { "Julio", "Esteban", "Javier", "Gonzalo", "Alberto" };
            float[,] ventas = new float[5, 4];
            //cargo los valores de la grilla en una matriz
            for (int i = 0; i < dgvVentas.Rows.Count; i++)
            {
                for (int j = 0; j < dgvVentas.Columns.Count; j++)
                {
                    ventas[i, j] = float.Parse(dgvVentas.Rows[i].Cells[j].Value.ToString());
                }
            }
            //calculo el total para cada mozo
            float[] totalPorMozo = new float[5];
            for (int i = 0; i < 5; i++)
            {
                float total = 0;
                for (int j = 0; j < 4; j++)
                    total += ventas[i, j];
                totalPorMozo[i] = total;
            }
            //busco el numero maximo
            float maxTotal = totalPorMozo.Max();
            //busco los mozos con ese numero para ver si hay empate
            var mozosEmpatados = new List<string>();
            for (int i = 0; i < mozos.Length; i++)
            {
                if (totalPorMozo[i] == maxTotal)
                    mozosEmpatados.Add(mozos[i]);
            }
            //muestro resultado
            txtImporteMozo.Text = maxTotal.ToString("0.00");
            if (mozosEmpatados.Count == 1)
            {
                txtMozoDelDia.Text = mozosEmpatados[0];
            }
            else
            {
                txtMozoDelDia.Text = string.Join(", ", mozosEmpatados);
            }
        }
        private void btnTotales_Click(object sender, EventArgs e)
        {
            float[,] ventas = new float[5, 4];
            //cargo los valores de la grilla en una matriz
            for (int i = 0; i < dgvVentas.Rows.Count; i++)
            {
                for (int j = 0; j < dgvVentas.Columns.Count; j++)
                {
                    ventas[i, j] = float.Parse(dgvVentas.Rows[i].Cells[j].Value.ToString());
                }
            }
            //calculo totales por categoria
            float[] totalesCategoria = new float[4];
            float totalGeneral = 0;
            for (int j = 0; j < 4; j++)
            {
                for (int i = 0; i < 5; i++)
                {
                    totalesCategoria[j] += ventas[i, j];
                }
                totalGeneral += totalesCategoria[j];
            }
            //mostrar en las textbox el resultado
            txtTotalComidas.Text = totalesCategoria[0].ToString("0.00");
            txtTotalBebidasSin.Text = totalesCategoria[1].ToString("0.00");
            txtTotalBebidasCon.Text = totalesCategoria[2].ToString("0.00");
            txtTotalPostres.Text = totalesCategoria[3].ToString("0.00");
            txtTotalGeneral.Text = totalGeneral.ToString("0.00");
        }
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void dgvVentas_KeyPress(object sender, KeyPressEventArgs e)
        {
            //hacer que no se pueda poner letras
            /*if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }*/ //esto no anda nose pq
        }
        private void dgvVentas_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            //hacer que no se pueda poner letras
        }
        private void dgvVentas_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            //detectar si el control es un TextBox
            if (e.Control is TextBox textBox)
            {
                // Quitar posibles manejadores anteriores para evitar duplicados
                textBox.KeyPress -= TextBox_KeyPress_Numeros;
                // Agregar el nuevo manejador de eventos
                textBox.KeyPress += TextBox_KeyPress_Numeros;
            }
        }
        private void TextBox_KeyPress_Numeros(object sender, KeyPressEventArgs e)
        {
            //hacer que no se pueda poner letras
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != ',')
            {
                e.Handled = true;
            }
            //solo permitir una coma
            TextBox textBox = sender as TextBox;
            if (e.KeyChar == ',' && textBox.Text.Contains(","))
            {
                e.Handled = true;
            }
        }
    }
}
