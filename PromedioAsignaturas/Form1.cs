using System;
using System.Drawing;
using System.Windows.Forms;

namespace PromedioAsignaturas
{
    public partial class Form1 : Form
    {
        Label lblNombre, lblNota1, lblNota2, lblSupletorio, lblResultado;
        TextBox txtNombre, txtNota1, txtNota2, txtSupletorio;
        Button btnCalcular, btnSalir;

        public Form1()
        {
            InitializeComponent();
            CrearControles();
        }

        private void CrearControles()
        {
            this.Text = "Cálculo de Promedio de Asignaturas";
            this.WindowState = FormWindowState.Maximized;
            this.BackColor = Color.FromArgb(245, 255, 250); // Color suave bonito

            lblNombre = new Label() { Text = "Nombre Asignatura:", Left = 500, Top = 150, Font = new Font("Arial", 12), AutoSize = true };
            txtNombre = new TextBox() { Left = 750, Top = 150, Width = 200 };

            lblNota1 = new Label() { Text = "Nota Primer Parcial:", Left = 500, Top = 200, Font = new Font("Arial", 12), AutoSize = true };
            txtNota1 = new TextBox() { Left = 750, Top = 200, Width = 200 };

            lblNota2 = new Label() { Text = "Nota Segundo Parcial:", Left = 500, Top = 250, Font = new Font("Arial", 12), AutoSize = true };
            txtNota2 = new TextBox() { Left = 750, Top = 250, Width = 200 };

            lblSupletorio = new Label() { Text = "Nota Supletorio (solo si aplica):", Left = 500, Top = 300, Font = new Font("Arial", 12), AutoSize = true };
            txtSupletorio = new TextBox() { Left = 750, Top = 300, Width = 200, Enabled = false };

            btnCalcular = new Button() { Text = "Calcular", Left = 600, Top = 380, Width = 120, Height = 40, BackColor = Color.LightGreen, Font = new Font("Arial", 12, FontStyle.Bold) };
            btnCalcular.Click += BtnCalcular_Click;

            btnSalir = new Button() { Text = "Salir", Left = 750, Top = 380, Width = 120, Height = 40, BackColor = Color.LightCoral, Font = new Font("Arial", 12, FontStyle.Bold) };
            btnSalir.Click += BtnSalir_Click;

            lblResultado = new Label() { Text = "", Left = 500, Top = 450, Width = 600, Height = 200, Font = new Font("Arial", 12), AutoSize = false };

            this.Controls.Add(lblNombre);
            this.Controls.Add(txtNombre);
            this.Controls.Add(lblNota1);
            this.Controls.Add(txtNota1);
            this.Controls.Add(lblNota2);
            this.Controls.Add(txtNota2);
            this.Controls.Add(lblSupletorio);
            this.Controls.Add(txtSupletorio);
            this.Controls.Add(btnCalcular);
            this.Controls.Add(btnSalir);
            this.Controls.Add(lblResultado);
        }

        private void BtnCalcular_Click(object sender, EventArgs e)
        {
            try
            {
                string nombre = txtNombre.Text;
                double nota1 = double.Parse(txtNota1.Text); // sobre 10
                double nota2 = double.Parse(txtNota2.Text); // sobre 10

                double promedio = nota1 + nota2; // ✅ Ya es sobre 20
                lblResultado.Text = $"Asignatura: {nombre}\nPromedio: {promedio:F2}\n";

                if (promedio >= 14)
                {
                    lblResultado.Text += "✅ No necesita supletorio. ¡Aprobado!";
                    txtSupletorio.Enabled = false;
                    txtSupletorio.Text = ""; // Limpiar
                }
                else
                {
                    lblResultado.Text += "⚠️ Debe rendir supletorio.\nIngrese la nota del supletorio.";
                    txtSupletorio.Enabled = true;
                }

                if (txtSupletorio.Enabled && !string.IsNullOrEmpty(txtSupletorio.Text))
                {
                    double notaSupletorio = double.Parse(txtSupletorio.Text);
                    if (notaSupletorio >= 7)
                    {
                        lblResultado.Text += "\n✅ ¡Aprobó el supletorio!";
                    }
                    else
                    {
                        lblResultado.Text += "\n❌ No aprobó el supletorio. Perdió la materia.";
                    }
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Por favor, ingrese valores numéricos válidos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void BtnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
