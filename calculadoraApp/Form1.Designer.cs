
namespace calculadoraApp
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
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
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnIgual = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnRecuperarMemoria = new System.Windows.Forms.Button();
            this.btnBorrarMemoria = new System.Windows.Forms.Button();
            this.btn7 = new System.Windows.Forms.Button();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.btnBorrarOperando = new System.Windows.Forms.Button();
            this.btnMas = new System.Windows.Forms.Button();
            this.btnComa = new System.Windows.Forms.Button();
            this.btn0 = new System.Windows.Forms.Button();
            this.btnMenos = new System.Windows.Forms.Button();
            this.btnMult = new System.Windows.Forms.Button();
            this.btnInvert = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn1 = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btnDiv = new System.Windows.Forms.Button();
            this.btn9 = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btnSumarMemoria = new System.Windows.Forms.Button();
            this.textAreaResultado = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.btnIgual);
            this.panel1.Controls.Add(this.btnGuardar);
            this.panel1.Controls.Add(this.btnRecuperarMemoria);
            this.panel1.Controls.Add(this.btnBorrarMemoria);
            this.panel1.Controls.Add(this.btn7);
            this.panel1.Controls.Add(this.btnBorrar);
            this.panel1.Controls.Add(this.btnBorrarOperando);
            this.panel1.Controls.Add(this.btnMas);
            this.panel1.Controls.Add(this.btnComa);
            this.panel1.Controls.Add(this.btn0);
            this.panel1.Controls.Add(this.btnMenos);
            this.panel1.Controls.Add(this.btnMult);
            this.panel1.Controls.Add(this.btnInvert);
            this.panel1.Controls.Add(this.btn3);
            this.panel1.Controls.Add(this.btn2);
            this.panel1.Controls.Add(this.btn1);
            this.panel1.Controls.Add(this.btn6);
            this.panel1.Controls.Add(this.btn5);
            this.panel1.Controls.Add(this.btn4);
            this.panel1.Controls.Add(this.btnDiv);
            this.panel1.Controls.Add(this.btn9);
            this.panel1.Controls.Add(this.btn8);
            this.panel1.Controls.Add(this.btnSumarMemoria);
            this.panel1.Location = new System.Drawing.Point(-2, 105);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(337, 320);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // btnIgual
            // 
            this.btnIgual.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnIgual.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIgual.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIgual.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnIgual.Location = new System.Drawing.Point(196, 255);
            this.btnIgual.Name = "btnIgual";
            this.btnIgual.Size = new System.Drawing.Size(116, 52);
            this.btnIgual.TabIndex = 22;
            this.btnIgual.Text = "=";
            this.btnIgual.UseVisualStyleBackColor = false;
            this.btnIgual.Click += new System.EventHandler(this.btnIgual_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.ForeColor = System.Drawing.Color.Red;
            this.btnGuardar.Location = new System.Drawing.Point(257, 134);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(55, 55);
            this.btnGuardar.TabIndex = 21;
            this.btnGuardar.Text = "MS";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnRecuperarMemoria
            // 
            this.btnRecuperarMemoria.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btnRecuperarMemoria.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRecuperarMemoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRecuperarMemoria.ForeColor = System.Drawing.Color.Red;
            this.btnRecuperarMemoria.Location = new System.Drawing.Point(257, 73);
            this.btnRecuperarMemoria.Name = "btnRecuperarMemoria";
            this.btnRecuperarMemoria.Size = new System.Drawing.Size(55, 55);
            this.btnRecuperarMemoria.TabIndex = 20;
            this.btnRecuperarMemoria.Text = "MR";
            this.btnRecuperarMemoria.UseVisualStyleBackColor = false;
            this.btnRecuperarMemoria.Click += new System.EventHandler(this.btnRecuperarMemoria_Click);
            // 
            // btnBorrarMemoria
            // 
            this.btnBorrarMemoria.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btnBorrarMemoria.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBorrarMemoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBorrarMemoria.ForeColor = System.Drawing.Color.Red;
            this.btnBorrarMemoria.Location = new System.Drawing.Point(257, 11);
            this.btnBorrarMemoria.Name = "btnBorrarMemoria";
            this.btnBorrarMemoria.Size = new System.Drawing.Size(55, 55);
            this.btnBorrarMemoria.TabIndex = 19;
            this.btnBorrarMemoria.Text = "MC";
            this.btnBorrarMemoria.UseVisualStyleBackColor = false;
            this.btnBorrarMemoria.Click += new System.EventHandler(this.btnBorrarMemoria_Click);
            // 
            // btn7
            // 
            this.btn7.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btn7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn7.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn7.Location = new System.Drawing.Point(13, 72);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(55, 55);
            this.btn7.TabIndex = 18;
            this.btn7.Text = "7";
            this.btn7.UseVisualStyleBackColor = false;
            this.btn7.Click += new System.EventHandler(this.btnNumber_Click);
            // 
            // btnBorrar
            // 
            this.btnBorrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnBorrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBorrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBorrar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnBorrar.Location = new System.Drawing.Point(104, 11);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(85, 55);
            this.btnBorrar.TabIndex = 17;
            this.btnBorrar.Text = "C";
            this.btnBorrar.UseVisualStyleBackColor = false;
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
            // 
            // btnBorrarOperando
            // 
            this.btnBorrarOperando.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnBorrarOperando.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBorrarOperando.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBorrarOperando.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnBorrarOperando.Location = new System.Drawing.Point(13, 11);
            this.btnBorrarOperando.Name = "btnBorrarOperando";
            this.btnBorrarOperando.Size = new System.Drawing.Size(85, 55);
            this.btnBorrarOperando.TabIndex = 16;
            this.btnBorrarOperando.Text = "CE";
            this.btnBorrarOperando.UseVisualStyleBackColor = false;
            this.btnBorrarOperando.Click += new System.EventHandler(this.btnBorrarOperando_Click);
            // 
            // btnMas
            // 
            this.btnMas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnMas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMas.ForeColor = System.Drawing.Color.Snow;
            this.btnMas.Location = new System.Drawing.Point(196, 193);
            this.btnMas.Name = "btnMas";
            this.btnMas.Size = new System.Drawing.Size(55, 55);
            this.btnMas.TabIndex = 15;
            this.btnMas.Text = "+";
            this.btnMas.UseVisualStyleBackColor = false;
            this.btnMas.Click += new System.EventHandler(this.btnOperacion_Click);
            // 
            // btnComa
            // 
            this.btnComa.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnComa.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnComa.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnComa.Location = new System.Drawing.Point(135, 255);
            this.btnComa.Name = "btnComa";
            this.btnComa.Size = new System.Drawing.Size(55, 55);
            this.btnComa.TabIndex = 14;
            this.btnComa.Text = ",";
            this.btnComa.UseVisualStyleBackColor = false;
            this.btnComa.Click += new System.EventHandler(this.btnComa_Click);
            // 
            // btn0
            // 
            this.btn0.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btn0.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn0.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn0.Location = new System.Drawing.Point(74, 255);
            this.btn0.Name = "btn0";
            this.btn0.Size = new System.Drawing.Size(55, 55);
            this.btn0.TabIndex = 13;
            this.btn0.Text = "0";
            this.btn0.UseVisualStyleBackColor = false;
            this.btn0.Click += new System.EventHandler(this.btnNumber_Click);
            // 
            // btnMenos
            // 
            this.btnMenos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnMenos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenos.ForeColor = System.Drawing.Color.Snow;
            this.btnMenos.Location = new System.Drawing.Point(196, 132);
            this.btnMenos.Name = "btnMenos";
            this.btnMenos.Size = new System.Drawing.Size(55, 55);
            this.btnMenos.TabIndex = 12;
            this.btnMenos.Text = "-";
            this.btnMenos.UseVisualStyleBackColor = false;
            this.btnMenos.Click += new System.EventHandler(this.btnOperacion_Click);
            // 
            // btnMult
            // 
            this.btnMult.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnMult.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMult.ForeColor = System.Drawing.Color.Snow;
            this.btnMult.Location = new System.Drawing.Point(196, 72);
            this.btnMult.Name = "btnMult";
            this.btnMult.Size = new System.Drawing.Size(55, 55);
            this.btnMult.TabIndex = 11;
            this.btnMult.Text = "*";
            this.btnMult.UseVisualStyleBackColor = false;
            this.btnMult.Click += new System.EventHandler(this.btnOperacion_Click);
            // 
            // btnInvert
            // 
            this.btnInvert.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnInvert.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInvert.ForeColor = System.Drawing.Color.Snow;
            this.btnInvert.Location = new System.Drawing.Point(13, 255);
            this.btnInvert.Name = "btnInvert";
            this.btnInvert.Size = new System.Drawing.Size(55, 55);
            this.btnInvert.TabIndex = 10;
            this.btnInvert.Text = "1/X";
            this.btnInvert.UseVisualStyleBackColor = false;
            this.btnInvert.Click += new System.EventHandler(this.btnInvert_Click);
            // 
            // btn3
            // 
            this.btn3.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btn3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn3.Location = new System.Drawing.Point(135, 195);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(55, 55);
            this.btn3.TabIndex = 9;
            this.btn3.Text = "3";
            this.btn3.UseVisualStyleBackColor = false;
            this.btn3.Click += new System.EventHandler(this.btnNumber_Click);
            // 
            // btn2
            // 
            this.btn2.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btn2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn2.Location = new System.Drawing.Point(74, 195);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(55, 55);
            this.btn2.TabIndex = 8;
            this.btn2.Text = "2";
            this.btn2.UseVisualStyleBackColor = false;
            this.btn2.Click += new System.EventHandler(this.btnNumber_Click);
            // 
            // btn1
            // 
            this.btn1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btn1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn1.Location = new System.Drawing.Point(13, 195);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(55, 55);
            this.btn1.TabIndex = 7;
            this.btn1.Text = "1";
            this.btn1.UseVisualStyleBackColor = false;
            this.btn1.Click += new System.EventHandler(this.btnNumber_Click);
            // 
            // btn6
            // 
            this.btn6.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btn6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn6.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn6.Location = new System.Drawing.Point(135, 133);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(55, 55);
            this.btn6.TabIndex = 6;
            this.btn6.Text = "6";
            this.btn6.UseVisualStyleBackColor = false;
            this.btn6.Click += new System.EventHandler(this.btnNumber_Click);
            // 
            // btn5
            // 
            this.btn5.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btn5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn5.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn5.Location = new System.Drawing.Point(74, 133);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(55, 55);
            this.btn5.TabIndex = 5;
            this.btn5.Text = "5";
            this.btn5.UseVisualStyleBackColor = false;
            this.btn5.Click += new System.EventHandler(this.btnNumber_Click);
            // 
            // btn4
            // 
            this.btn4.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btn4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn4.Location = new System.Drawing.Point(13, 133);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(55, 55);
            this.btn4.TabIndex = 4;
            this.btn4.Text = "4";
            this.btn4.UseVisualStyleBackColor = false;
            this.btn4.Click += new System.EventHandler(this.btnNumber_Click);
            // 
            // btnDiv
            // 
            this.btnDiv.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnDiv.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDiv.ForeColor = System.Drawing.Color.Snow;
            this.btnDiv.Location = new System.Drawing.Point(196, 11);
            this.btnDiv.Name = "btnDiv";
            this.btnDiv.Size = new System.Drawing.Size(55, 55);
            this.btnDiv.TabIndex = 3;
            this.btnDiv.Text = "/";
            this.btnDiv.UseVisualStyleBackColor = false;
            this.btnDiv.Click += new System.EventHandler(this.btnOperacion_Click);
            // 
            // btn9
            // 
            this.btn9.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btn9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn9.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn9.Location = new System.Drawing.Point(135, 72);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(55, 55);
            this.btn9.TabIndex = 2;
            this.btn9.Text = "9";
            this.btn9.UseVisualStyleBackColor = false;
            this.btn9.Click += new System.EventHandler(this.btnNumber_Click);
            // 
            // btn8
            // 
            this.btn8.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btn8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn8.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn8.Location = new System.Drawing.Point(74, 72);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(55, 55);
            this.btn8.TabIndex = 1;
            this.btn8.Text = "8";
            this.btn8.UseVisualStyleBackColor = false;
            this.btn8.Click += new System.EventHandler(this.btnNumber_Click);
            // 
            // btnSumarMemoria
            // 
            this.btnSumarMemoria.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btnSumarMemoria.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSumarMemoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSumarMemoria.ForeColor = System.Drawing.Color.Red;
            this.btnSumarMemoria.Location = new System.Drawing.Point(257, 194);
            this.btnSumarMemoria.Name = "btnSumarMemoria";
            this.btnSumarMemoria.Size = new System.Drawing.Size(55, 55);
            this.btnSumarMemoria.TabIndex = 0;
            this.btnSumarMemoria.Text = "M+";
            this.btnSumarMemoria.UseVisualStyleBackColor = false;
            this.btnSumarMemoria.Click += new System.EventHandler(this.btnSumarMemoria_Click);
            // 
            // textAreaResultado
            // 
            this.textAreaResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textAreaResultado.Location = new System.Drawing.Point(12, 68);
            this.textAreaResultado.Name = "textAreaResultado";
            this.textAreaResultado.Size = new System.Drawing.Size(299, 31);
            this.textAreaResultado.TabIndex = 1;
            this.textAreaResultado.Text = "0";
            this.textAreaResultado.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(322, 423);
            this.Controls.Add(this.textAreaResultado);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculadora";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnRecuperarMemoria;
        private System.Windows.Forms.Button btnBorrarMemoria;
        private System.Windows.Forms.Button btn7;
        private System.Windows.Forms.Button btnBorrar;
        private System.Windows.Forms.Button btnBorrarOperando;
        private System.Windows.Forms.Button btnMas;
        private System.Windows.Forms.Button btnComa;
        private System.Windows.Forms.Button btn0;
        private System.Windows.Forms.Button btnMenos;
        private System.Windows.Forms.Button btnMult;
        private System.Windows.Forms.Button btnInvert;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btnDiv;
        private System.Windows.Forms.Button btn9;
        private System.Windows.Forms.Button btn8;
        private System.Windows.Forms.Button btnSumarMemoria;
        private System.Windows.Forms.Button btnIgual;
        private System.Windows.Forms.TextBox textAreaResultado;
    }
}

