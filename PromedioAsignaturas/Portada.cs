using System;
using System.Drawing;
using System.Windows.Forms;

namespace PromedioAsignaturas
{
    public partial class Portada : Form
    {
        Label lblTitulo, lblIntegrantes, lblIntegrante1, lblIntegrante2, lblIntegrante3, lblIntegrante4, lblAPE, lblTema;
        Button btnIniciar, btnSalir;
        Panel panelFondo;

        public Portada()
        {
            InitializeComponent();
            CrearControles();
        }

        private void CrearControles()
        {
            this.Text = "Portada - Promedio Asignaturas";
            this.WindowState = FormWindowState.Maximized;
            this.BackColor = Color.FromArgb(240, 248, 255); // Fondo azul clarito

            panelFondo = new Panel()
            {
                Dock = DockStyle.Fill,
                BackgroundImageLayout = ImageLayout.Stretch,
                BackColor = Color.FromArgb(230, 255, 250) // Verde muy clarito
            };
            this.Controls.Add(panelFondo);

            lblTitulo = new Label()
            {
                Text = "UNIVERSIDAD TÉCNICA DE AMBATO\nFACULTAD DE INGENIERÍA EN SISTEMAS ELECTRÓNICA E INDUSTRIAL\nCARRERA DE TECNOLOGÍAS DE LA INFORMACIÓN\nCICLO ACADÉMICO: MARZO – JULIO 2025",
                Font = new Font("Arial", 18, FontStyle.Bold),
                AutoSize = true,
                TextAlign = ContentAlignment.MiddleCenter,
                Location = new Point(300, 80)
            };
            panelFondo.Controls.Add(lblTitulo);

            lblIntegrantes = new Label()
            {
                Text = "Integrantes:",
                Font = new Font("Arial", 14, FontStyle.Bold),
                Location = new Point(550, 300),
                AutoSize = true
            };
            panelFondo.Controls.Add(lblIntegrantes);

            lblIntegrante1 = new Label()
            {
                Text = "Laura Laura Stalin Alejandro",
                Font = new Font("Arial", 12, FontStyle.Regular),
                Location = new Point(550, 330),
                AutoSize = true
            };
            panelFondo.Controls.Add(lblIntegrante1);

            lblIntegrante2 = new Label()
            {
                Text = "Raza Guerrero Benjamín Alejandro",
                Font = new Font("Arial", 12, FontStyle.Regular),
                Location = new Point(550, 360),
                AutoSize = true
            };
            panelFondo.Controls.Add(lblIntegrante2);

            lblIntegrante3 = new Label()
            {
                Text = "Sánchez Yauli Iván Alexander",
                Font = new Font("Arial", 12, FontStyle.Regular),
                Location = new Point(550, 390),
                AutoSize = true
            };
            panelFondo.Controls.Add(lblIntegrante3);

            lblIntegrante4 = new Label()
            {
                Text = "Rios Guato Lizbeth Rosario",
                Font = new Font("Arial", 12, FontStyle.Regular),
                Location = new Point(550, 420),
                AutoSize = true
            };
            panelFondo.Controls.Add(lblIntegrante4);

            lblAPE = new Label()
            {
                Text = "APE N.- 4",
                Font = new Font("Arial", 16, FontStyle.Bold),
                Location = new Point(650, 470),
                AutoSize = true
            };
            panelFondo.Controls.Add(lblAPE);

            lblTema = new Label()
            {
                Text = "Tema: Modelamiento y creación de clases para representar objetos del mundo real",
                Font = new Font("Arial", 14, FontStyle.Bold),
                Location = new Point(300, 510),
                AutoSize = true,
                TextAlign = ContentAlignment.MiddleCenter
            };
            panelFondo.Controls.Add(lblTema);

            btnIniciar = new Button()
            {
                Text = "INICIAR",
                Location = new Point(500, 600),
                Size = new Size(120, 50),
                BackColor = Color.LightSkyBlue,
                Font = new Font("Arial", 12, FontStyle.Bold)
            };
            btnIniciar.Click += BtnIniciar_Click;
            panelFondo.Controls.Add(btnIniciar);

            btnSalir = new Button()
            {
                Text = "SALIR",
                Location = new Point(650, 600),
                Size = new Size(120, 50),
                BackColor = Color.LightCoral,
                Font = new Font("Arial", 12, FontStyle.Bold)
            };
            btnSalir.Click += BtnSalir_Click;
            panelFondo.Controls.Add(btnSalir);
        }

        private void BtnIniciar_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.WindowState = FormWindowState.Maximized;
            form.Show();
            this.Hide();
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
