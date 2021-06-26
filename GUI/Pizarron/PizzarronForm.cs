using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Corvus_Proyecto.GUI.Pizarron
{
    public partial class PizzarronForm : Form
    {
        Graphics g; //Objeto para interactuar con la clase Graphics
        int? X = null; //Valor X respecto al mouse
        int? Y = null; //Valor Y respecto al mouse
        Color color = Color.Black; //Color que tendrá el lapiz por default
        int ancho; //variable que contendrá el valor del ancho de pixeles de las líneas
        bool dibujar = false; //Varibale que permite dibujar o no
        FontStyle font = new FontStyle(); //Objeto para poder modificar el font de cada textbox     

        public PizzarronForm()
        {
            InitializeComponent();
            g = pbxlienzo.CreateGraphics();
            tsLapiz.Enabled = false;
            font = FontStyle.Regular;
        }

        //Metodo que reconoce si se va a dibujar o borrar dependiendo del boton que se seleccionó
        private void pbxlienzo_MouseDown(object sender, MouseEventArgs e)
        {
            if (tsLapiz.Enabled == false)
                dibujar = true;
            else if (tsBorrador.Enabled == false)
                dibujar = true;
        }

        //Le asigna valores nulos a las variables si no se mantiene el clic en el picture box
        private void pbxlienzo_MouseUp(object sender, MouseEventArgs e)
        {
            dibujar = false;
            X = null;
            Y = null;
        }

        private void pbxlienzo_MouseMove(object sender, MouseEventArgs e)
        {
            //Corrobora que el valor del ancho sea un valor numerico, y si no lo es muestra una ventana emergente de error
            try
            {
                ancho = Convert.ToInt32(txtTamano.Text);
            }
            catch
            {
                MessageBox.Show("Ingrese solo valores numericos", "Error");
                txtTamano.Text = "2";
                ancho = 2;
            }

            //Permite unir puntos mediante se desliza el mouse cuando se da clic al botón del lapiz, con el color seleccionado o pinta blanco, para borrar
            if (dibujar == true && tsLapiz.Enabled == false)
            {
                g.DrawLine(new Pen(color, ancho), new Point(X ?? e.X, Y ?? e.Y), new Point(e.X, e.Y));
                X = e.X;
                Y = e.Y;
            }
            else if (dibujar == true && tsBorrador.Enabled == false)
            {
                g.DrawLine(new Pen(Color.White, ancho), new Point(X ?? e.X, Y ?? e.Y), new Point(e.X, e.Y));
                X = e.X;
                Y = e.Y;
            }
        }

        private void tsLapiz_Click(object sender, EventArgs e)
        {
            tsLapiz.Enabled = false;
            tsBorrador.Enabled = true;
        }

        private void tsBorrador_Click(object sender, EventArgs e)
        {
            tsBorrador.Enabled = false;
            tsLapiz.Enabled = true;
        }

        //Generar textbox en el lienzo
        private void pbxlienzo_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            TextBox txt = new TextBox();
            this.Controls.Add(txt);
            txt.Location = new Point(e.X, e.Y);
            txt.ForeColor = color;

            if (cbStyles.SelectedIndex >= 0 && txtFuente.Text != "")
                txt.Font = new Font(cbStyles.SelectedItem.ToString(), Convert.ToSingle(txtFuente.Text), font, GraphicsUnit.Point, ((byte)(0)));
            else
                txt.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));

            if (txtAncho.Text != "" && txtLargo.Text != "")
                txt.Size = new Size(Convert.ToInt32(txtLargo.Text), Convert.ToInt32(txtAncho.Text));
            else
                txt.Size = new Size(120, 30);

            txt.Multiline = Enabled;
            txt.BringToFront();

            this.Controls.OfType<Control>().Where(ctr => ctr is TextBox).ToList().ForEach(ctrl =>
            {
                ctrl.MouseDown += Ctrl_MouseDown;
                ctrl.MouseUp += Ctrl_MouseUp;
                ctrl.MouseMove += Ctrl_MouseMove;
            });
        }

        bool down = false;
        Point inicial;

        private void Ctrl_MouseMove(object sender, MouseEventArgs e)
        {
            Control ctr = (Control)sender;
            if (down)
            {
                ctr.Left = e.X + ctr.Left - inicial.X;
                ctr.Top = e.Y + ctr.Top - inicial.Y;
            }
        }

        private void Ctrl_MouseUp(object sender, MouseEventArgs e) => down = false;

        private void Ctrl_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                down = true;
                inicial = e.Location;
            }
        }

        //Metodos para el tipo de fuente del textbox
        private void Bold_Click(object sender, EventArgs e)
        {
            if (font != FontStyle.Bold)
                font = FontStyle.Bold;
            else
                font = FontStyle.Regular;
        }

        private void Italica_Click(object sender, EventArgs e)
        {
            if (font != FontStyle.Italic)
                font = FontStyle.Italic;
            else
                font = FontStyle.Regular;
        }

        private void Under_Click(object sender, EventArgs e)
        {
            if (font != FontStyle.Underline)
                font = FontStyle.Underline;
            else
                font = FontStyle.Regular;
        }

        private void Strike_Click(object sender, EventArgs e)
        {
            if (font != FontStyle.Strikeout)
                font = FontStyle.Strikeout;
            else
                font = FontStyle.Regular;
        }

        //Metodos para asignar colores al lapiz y el texto en los textbox

        private void btn_Black_Click(object sender, EventArgs e)
        {

            if (color != Color.Black)
                color = btn_Black.BackColor;

        }

        private void btn_Red_Click(object sender, EventArgs e)
        {
            if (color != Color.Red)
                color = btn_Red.BackColor;
            else
                color = Color.Black;
        }

        private void btn_Green_Click(object sender, EventArgs e)
        {
            if (color != Color.Green)
                color = btn_Green.BackColor;
            else
                color = Color.Black;
        }

        private void btn_Blue_Click(object sender, EventArgs e)
        {
            if (color != Color.Blue)
                color = btn_Blue.BackColor;
            else
                color = Color.Black;
        }

        private void btn_Purple_Click(object sender, EventArgs e)
        {
            if (color != Color.Purple)
                color = btn_Purple.BackColor;
            else
                color = Color.Black;
        }

        private void btn_Brown_Click(object sender, EventArgs e)
        {
            if (color != Color.Brown)
                color = btn_Brown.BackColor;
            else
                color = Color.Black;
        }

        private void btn_Aqua_Click(object sender, EventArgs e)
        {
            if (color != Color.Aqua)
                color = btn_Aqua.BackColor;
            else
                color = Color.Black;
        }

        private void btn_Yellow_Click(object sender, EventArgs e)
        {
            if (color != Color.Yellow)
                color = btn_Yellow.BackColor;
            else
                color = Color.Black;
        }

        private void btn_Orange_Click(object sender, EventArgs e)
        {
            if (color != Color.Orange)
                color = btn_Orange.BackColor;
            else
                color = Color.Black;
        }

        //Metodo para guardar la captura de la ventana
        private void tsGuardar_Click(object sender, EventArgs e)
        {
            //Capturar la ventana
            Bitmap FormScreenShot = new Bitmap(this.Width, this.Height);
            Graphics G = Graphics.FromImage(FormScreenShot);
            G.CopyFromScreen(this.Location, new Point(0, 0), this.Size);
            Clipboard.SetImage(FormScreenShot);

            //Guardar la captura
            try
            {
                SaveFileDialog Guardar = new SaveFileDialog();
                Guardar.Filter = "JPEG(*.JPG)|*.JPG|BMP(*.BMP)|*.BMP";
                Guardar.ShowDialog();
                FormScreenShot.Save(Guardar.FileName);
            }
            catch { }
        }

        //Abrir el archivo de ayuda en una ventana emergente
        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string path = Environment.GetFolderPath(Environment.SpecialFolder.MyComputer) + @"Help.txt";

            string existingContent = File.ReadAllText(path);

            MessageBox.Show(existingContent, "Help");
        }
    }
}