using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class Form1 : Form
    {
        bool sigue = true;
        string operacion;
        double numero1;
        double solucion;
        double numero2;

        public Form1()
        {
            InitializeComponent();
        }

        private void num1_Click(object sender, EventArgs e)
        {
            if (sigue)
            {
                pantalla.Text = "";
                pantalla.Text = "1";
                sigue = false;
            }
            else{
                pantalla.Text = pantalla.Text + "1";
            }
        }

        private void num2_Click(object sender, EventArgs e)
        {
            if (sigue)
            {
                pantalla.Text = "";
                pantalla.Text = "2";
                sigue = false;
            }
            else
            {
                pantalla.Text = pantalla.Text + "2";
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (sigue)
            {
                pantalla.Text = "";
                pantalla.Text = "3";
                sigue = false;
            }
            else
            {
                pantalla.Text = pantalla.Text + "3";
            }
        }

        private void num4_Click(object sender, EventArgs e)
        {
            if (sigue)
            {
                pantalla.Text = "";
                pantalla.Text = "4";
                sigue = false;
            }
            else
            {
                pantalla.Text = pantalla.Text + "4";
            }
        }

        private void num5_Click(object sender, EventArgs e)
        {
            if (sigue)
            {
                pantalla.Text = "";
                pantalla.Text = "5";
                sigue = false;
            }
            else
            {
                pantalla.Text = pantalla.Text + "5";
            }
        }

        private void num6_Click(object sender, EventArgs e)
        {
            if (sigue)
            {
                pantalla.Text = "";
                pantalla.Text = "6";
                sigue = false;
            }
            else
            {
                pantalla.Text = pantalla.Text + "6";
            }
        }

        private void num7_Click(object sender, EventArgs e)
        {
            if (sigue)
            {
                pantalla.Text = "";
                pantalla.Text = "7";
                sigue = false;
            }
            else
            {
                pantalla.Text = pantalla.Text + "7";
            }
        }

        private void num8_Click(object sender, EventArgs e)
        {
            if (sigue)
            {
                pantalla.Text = "";
                pantalla.Text = "8";
                sigue = false;
            }
            else
            {
                pantalla.Text = pantalla.Text + "8";
            }
        }

        private void num9_Click(object sender, EventArgs e)
        {
            if (sigue)
            {
                pantalla.Text = "";
                pantalla.Text = "9";
                sigue = false;
            }
            else
            {
                pantalla.Text = pantalla.Text + "9";
            }
        }

        private void num0_Click(object sender, EventArgs e)
        {
            if (sigue)
            {
                pantalla.Text = "";
                pantalla.Text = "0";
                sigue = false;
            }
            else
            {
                pantalla.Text = pantalla.Text + "0";
            }
        }

        private void suma_Click(object sender, EventArgs e)
        {
            operacion = "+";
            sigue = true;
            numero1 = double.Parse(pantalla.Text);
            
        }

        private void resta_Click(object sender, EventArgs e)
        {
            operacion = "-";
            sigue = true;
            numero1 = double.Parse(pantalla.Text);
            
        }

        private void multiplicacion_Click(object sender, EventArgs e)
        {
            operacion = "*";
            sigue = true;
            numero1 = double.Parse(pantalla.Text);
            
        }

        private void division_Click(object sender, EventArgs e)
        {
            operacion = "/";
            sigue = true;
            numero1 = double.Parse(pantalla.Text);
            
        }

        private void Raiz_Click(object sender, EventArgs e)
        {
            numero1 = double.Parse(pantalla.Text);
            solucion = Math.Sqrt(numero1);
            pantalla.Text = solucion.ToString();
            sigue = true;
           
        }

        private void Cuadrado_Click(object sender, EventArgs e)
        {
            numero1 = double.Parse(pantalla.Text);
            solucion = numero1 * numero1;
            pantalla.Text = solucion.ToString();
            sigue = true;
            
        }

        private void resultado_Click(object sender, EventArgs e)
        {
            
            numero2 = double.Parse(pantalla.Text);
            sigue = true;

            switch (operacion)
            {
                case "+":
                    
                    solucion = numero1 + numero2;
                    pantalla.Text = solucion.ToString();
                    
                    break;
 
                case "-":
                    
                    solucion = numero1 - numero2;
                    pantalla.Text = solucion.ToString();
                   
                    break;

                case "*":
                    
                    solucion = numero1 * numero2;
                    pantalla.Text = solucion.ToString();
                    
                    break;

                case "/":
                    
                    solucion = numero1 / numero2;
                    pantalla.Text = solucion.ToString();
               
                    break;          
               
            }
        }

        private void Borrar_Click(object sender, EventArgs e)
        {
            pantalla.Text = "0";
            numero1 = 0;
            numero2 = 0;
            sigue = true;

        }



    }
}
