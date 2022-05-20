namespace Calculadora
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.pantalla = new System.Windows.Forms.TextBox();
            this.num0 = new System.Windows.Forms.Button();
            this.resultado = new System.Windows.Forms.Button();
            this.suma = new System.Windows.Forms.Button();
            this.num1 = new System.Windows.Forms.Button();
            this.num2 = new System.Windows.Forms.Button();
            this.num3 = new System.Windows.Forms.Button();
            this.resta = new System.Windows.Forms.Button();
            this.num4 = new System.Windows.Forms.Button();
            this.num5 = new System.Windows.Forms.Button();
            this.num6 = new System.Windows.Forms.Button();
            this.multiplicacion = new System.Windows.Forms.Button();
            this.num7 = new System.Windows.Forms.Button();
            this.num8 = new System.Windows.Forms.Button();
            this.num9 = new System.Windows.Forms.Button();
            this.division = new System.Windows.Forms.Button();
            this.Borrar = new System.Windows.Forms.Button();
            this.Cuadrado = new System.Windows.Forms.Button();
            this.Raiz = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // pantalla
            // 
            this.pantalla.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pantalla.Location = new System.Drawing.Point(39, 44);
            this.pantalla.Multiline = true;
            this.pantalla.Name = "pantalla";
            this.pantalla.Size = new System.Drawing.Size(323, 58);
            this.pantalla.TabIndex = 1;
            this.pantalla.Text = "0\r\n";
            this.pantalla.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // num0
            // 
            this.num0.BackColor = System.Drawing.Color.LightSteelBlue;
            this.num0.Location = new System.Drawing.Point(39, 307);
            this.num0.Name = "num0";
            this.num0.Size = new System.Drawing.Size(148, 44);
            this.num0.TabIndex = 2;
            this.num0.Text = "0";
            this.num0.UseVisualStyleBackColor = false;
            this.num0.Click += new System.EventHandler(this.num0_Click);
            // 
            // resultado
            // 
            this.resultado.BackColor = System.Drawing.Color.LightSteelBlue;
            this.resultado.Location = new System.Drawing.Point(193, 307);
            this.resultado.Name = "resultado";
            this.resultado.Size = new System.Drawing.Size(73, 44);
            this.resultado.TabIndex = 3;
            this.resultado.Text = "=";
            this.resultado.UseVisualStyleBackColor = false;
            this.resultado.Click += new System.EventHandler(this.resultado_Click);
            // 
            // suma
            // 
            this.suma.BackColor = System.Drawing.Color.MediumAquamarine;
            this.suma.Location = new System.Drawing.Point(272, 307);
            this.suma.Name = "suma";
            this.suma.Size = new System.Drawing.Size(88, 44);
            this.suma.TabIndex = 4;
            this.suma.Text = "+";
            this.suma.UseVisualStyleBackColor = false;
            this.suma.Click += new System.EventHandler(this.suma_Click);
            // 
            // num1
            // 
            this.num1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.num1.Location = new System.Drawing.Point(39, 261);
            this.num1.Name = "num1";
            this.num1.Size = new System.Drawing.Size(73, 44);
            this.num1.TabIndex = 5;
            this.num1.Text = "1";
            this.num1.UseVisualStyleBackColor = false;
            this.num1.Click += new System.EventHandler(this.num1_Click);
            // 
            // num2
            // 
            this.num2.BackColor = System.Drawing.Color.LightSteelBlue;
            this.num2.Location = new System.Drawing.Point(116, 261);
            this.num2.Name = "num2";
            this.num2.Size = new System.Drawing.Size(73, 44);
            this.num2.TabIndex = 6;
            this.num2.Text = "2";
            this.num2.UseVisualStyleBackColor = false;
            this.num2.Click += new System.EventHandler(this.num2_Click);
            // 
            // num3
            // 
            this.num3.BackColor = System.Drawing.Color.LightSteelBlue;
            this.num3.Location = new System.Drawing.Point(193, 261);
            this.num3.Name = "num3";
            this.num3.Size = new System.Drawing.Size(73, 44);
            this.num3.TabIndex = 7;
            this.num3.Text = "3";
            this.num3.UseVisualStyleBackColor = false;
            this.num3.Click += new System.EventHandler(this.button7_Click);
            // 
            // resta
            // 
            this.resta.BackColor = System.Drawing.Color.MediumAquamarine;
            this.resta.Location = new System.Drawing.Point(272, 261);
            this.resta.Name = "resta";
            this.resta.Size = new System.Drawing.Size(88, 44);
            this.resta.TabIndex = 8;
            this.resta.Text = "-";
            this.resta.UseVisualStyleBackColor = false;
            this.resta.Click += new System.EventHandler(this.resta_Click);
            // 
            // num4
            // 
            this.num4.BackColor = System.Drawing.Color.LightSteelBlue;
            this.num4.Location = new System.Drawing.Point(39, 215);
            this.num4.Name = "num4";
            this.num4.Size = new System.Drawing.Size(73, 44);
            this.num4.TabIndex = 9;
            this.num4.Text = "4";
            this.num4.UseVisualStyleBackColor = false;
            this.num4.Click += new System.EventHandler(this.num4_Click);
            // 
            // num5
            // 
            this.num5.BackColor = System.Drawing.Color.LightSteelBlue;
            this.num5.Location = new System.Drawing.Point(116, 215);
            this.num5.Name = "num5";
            this.num5.Size = new System.Drawing.Size(73, 44);
            this.num5.TabIndex = 10;
            this.num5.Text = "5";
            this.num5.UseVisualStyleBackColor = false;
            this.num5.Click += new System.EventHandler(this.num5_Click);
            // 
            // num6
            // 
            this.num6.BackColor = System.Drawing.Color.LightSteelBlue;
            this.num6.Location = new System.Drawing.Point(193, 215);
            this.num6.Name = "num6";
            this.num6.Size = new System.Drawing.Size(73, 44);
            this.num6.TabIndex = 11;
            this.num6.Text = "6";
            this.num6.UseVisualStyleBackColor = false;
            this.num6.Click += new System.EventHandler(this.num6_Click);
            // 
            // multiplicacion
            // 
            this.multiplicacion.BackColor = System.Drawing.Color.MediumAquamarine;
            this.multiplicacion.Location = new System.Drawing.Point(272, 215);
            this.multiplicacion.Name = "multiplicacion";
            this.multiplicacion.Size = new System.Drawing.Size(88, 44);
            this.multiplicacion.TabIndex = 12;
            this.multiplicacion.Text = "*";
            this.multiplicacion.UseVisualStyleBackColor = false;
            this.multiplicacion.Click += new System.EventHandler(this.multiplicacion_Click);
            // 
            // num7
            // 
            this.num7.BackColor = System.Drawing.Color.LightSteelBlue;
            this.num7.Location = new System.Drawing.Point(39, 169);
            this.num7.Name = "num7";
            this.num7.Size = new System.Drawing.Size(73, 44);
            this.num7.TabIndex = 13;
            this.num7.Text = "7";
            this.num7.UseVisualStyleBackColor = false;
            this.num7.Click += new System.EventHandler(this.num7_Click);
            // 
            // num8
            // 
            this.num8.BackColor = System.Drawing.Color.LightSteelBlue;
            this.num8.Location = new System.Drawing.Point(116, 169);
            this.num8.Name = "num8";
            this.num8.Size = new System.Drawing.Size(73, 44);
            this.num8.TabIndex = 14;
            this.num8.Text = "8";
            this.num8.UseVisualStyleBackColor = false;
            this.num8.Click += new System.EventHandler(this.num8_Click);
            // 
            // num9
            // 
            this.num9.BackColor = System.Drawing.Color.LightSteelBlue;
            this.num9.Location = new System.Drawing.Point(193, 169);
            this.num9.Name = "num9";
            this.num9.Size = new System.Drawing.Size(73, 44);
            this.num9.TabIndex = 15;
            this.num9.Text = "9";
            this.num9.UseVisualStyleBackColor = false;
            this.num9.Click += new System.EventHandler(this.num9_Click);
            // 
            // division
            // 
            this.division.BackColor = System.Drawing.Color.MediumAquamarine;
            this.division.Location = new System.Drawing.Point(272, 169);
            this.division.Name = "division";
            this.division.Size = new System.Drawing.Size(88, 44);
            this.division.TabIndex = 16;
            this.division.Text = "÷";
            this.division.UseVisualStyleBackColor = false;
            this.division.Click += new System.EventHandler(this.division_Click);
            // 
            // Borrar
            // 
            this.Borrar.BackColor = System.Drawing.Color.MediumAquamarine;
            this.Borrar.Location = new System.Drawing.Point(259, 119);
            this.Borrar.Name = "Borrar";
            this.Borrar.Size = new System.Drawing.Size(101, 44);
            this.Borrar.TabIndex = 17;
            this.Borrar.Text = "C";
            this.Borrar.UseVisualStyleBackColor = false;
            this.Borrar.Click += new System.EventHandler(this.Borrar_Click);
            // 
            // Cuadrado
            // 
            this.Cuadrado.BackColor = System.Drawing.Color.MediumAquamarine;
            this.Cuadrado.Location = new System.Drawing.Point(39, 119);
            this.Cuadrado.Name = "Cuadrado";
            this.Cuadrado.Size = new System.Drawing.Size(102, 44);
            this.Cuadrado.TabIndex = 18;
            this.Cuadrado.Text = "x²";
            this.Cuadrado.UseVisualStyleBackColor = false;
            this.Cuadrado.Click += new System.EventHandler(this.Cuadrado_Click);
            // 
            // Raiz
            // 
            this.Raiz.BackColor = System.Drawing.Color.MediumAquamarine;
            this.Raiz.Location = new System.Drawing.Point(147, 119);
            this.Raiz.Name = "Raiz";
            this.Raiz.Size = new System.Drawing.Size(106, 44);
            this.Raiz.TabIndex = 19;
            this.Raiz.Text = "√";
            this.Raiz.UseVisualStyleBackColor = false;
            this.Raiz.Click += new System.EventHandler(this.Raiz_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(405, 380);
            this.Controls.Add(this.Raiz);
            this.Controls.Add(this.Cuadrado);
            this.Controls.Add(this.Borrar);
            this.Controls.Add(this.division);
            this.Controls.Add(this.num9);
            this.Controls.Add(this.num8);
            this.Controls.Add(this.num7);
            this.Controls.Add(this.multiplicacion);
            this.Controls.Add(this.num6);
            this.Controls.Add(this.num5);
            this.Controls.Add(this.num4);
            this.Controls.Add(this.resta);
            this.Controls.Add(this.num3);
            this.Controls.Add(this.num2);
            this.Controls.Add(this.num1);
            this.Controls.Add(this.suma);
            this.Controls.Add(this.resultado);
            this.Controls.Add(this.num0);
            this.Controls.Add(this.pantalla);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox pantalla;
        private System.Windows.Forms.Button num0;
        private System.Windows.Forms.Button resultado;
        private System.Windows.Forms.Button suma;
        private System.Windows.Forms.Button num1;
        private System.Windows.Forms.Button num2;
        private System.Windows.Forms.Button num3;
        private System.Windows.Forms.Button resta;
        private System.Windows.Forms.Button num4;
        private System.Windows.Forms.Button num5;
        private System.Windows.Forms.Button num6;
        private System.Windows.Forms.Button multiplicacion;
        private System.Windows.Forms.Button num7;
        private System.Windows.Forms.Button num8;
        private System.Windows.Forms.Button num9;
        private System.Windows.Forms.Button division;
        private System.Windows.Forms.Button Borrar;
        private System.Windows.Forms.Button Cuadrado;
        private System.Windows.Forms.Button Raiz;
    }
}

