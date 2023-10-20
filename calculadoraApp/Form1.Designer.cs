
namespace calculadoraApp
{
    partial class FrmCalculadora
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCalculadora));
            this.panel1 = new System.Windows.Forms.Panel();
            this.BtnIgual = new System.Windows.Forms.Button();
            this.BtnGuardar = new System.Windows.Forms.Button();
            this.BtnRecuperarMemoria = new System.Windows.Forms.Button();
            this.BtnBorrarMemoria = new System.Windows.Forms.Button();
            this.Btn7 = new System.Windows.Forms.Button();
            this.BtnClear = new System.Windows.Forms.Button();
            this.BtnClearEntry = new System.Windows.Forms.Button();
            this.BtnMas = new System.Windows.Forms.Button();
            this.BtnComa = new System.Windows.Forms.Button();
            this.Btn0 = new System.Windows.Forms.Button();
            this.BtnMenos = new System.Windows.Forms.Button();
            this.BtnMult = new System.Windows.Forms.Button();
            this.BtnInvertir = new System.Windows.Forms.Button();
            this.Btn3 = new System.Windows.Forms.Button();
            this.Btn2 = new System.Windows.Forms.Button();
            this.Btn1 = new System.Windows.Forms.Button();
            this.Btn6 = new System.Windows.Forms.Button();
            this.Btn5 = new System.Windows.Forms.Button();
            this.Btn4 = new System.Windows.Forms.Button();
            this.BtnDiv = new System.Windows.Forms.Button();
            this.Btn9 = new System.Windows.Forms.Button();
            this.Btn8 = new System.Windows.Forms.Button();
            this.BtnSumarMemoria = new System.Windows.Forms.Button();
            this.TxtResultado = new System.Windows.Forms.TextBox();
            this.TxtAux = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.BtnIgual);
            this.panel1.Controls.Add(this.BtnGuardar);
            this.panel1.Controls.Add(this.BtnRecuperarMemoria);
            this.panel1.Controls.Add(this.BtnBorrarMemoria);
            this.panel1.Controls.Add(this.Btn7);
            this.panel1.Controls.Add(this.BtnClear);
            this.panel1.Controls.Add(this.BtnClearEntry);
            this.panel1.Controls.Add(this.BtnMas);
            this.panel1.Controls.Add(this.BtnComa);
            this.panel1.Controls.Add(this.Btn0);
            this.panel1.Controls.Add(this.BtnMenos);
            this.panel1.Controls.Add(this.BtnMult);
            this.panel1.Controls.Add(this.BtnInvertir);
            this.panel1.Controls.Add(this.Btn3);
            this.panel1.Controls.Add(this.Btn2);
            this.panel1.Controls.Add(this.Btn1);
            this.panel1.Controls.Add(this.Btn6);
            this.panel1.Controls.Add(this.Btn5);
            this.panel1.Controls.Add(this.Btn4);
            this.panel1.Controls.Add(this.BtnDiv);
            this.panel1.Controls.Add(this.Btn9);
            this.panel1.Controls.Add(this.Btn8);
            this.panel1.Controls.Add(this.BtnSumarMemoria);
            this.panel1.Location = new System.Drawing.Point(-2, 105);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(337, 320);
            this.panel1.TabIndex = 0;
            // 
            // BtnIgual
            // 
            this.BtnIgual.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.BtnIgual.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnIgual.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnIgual.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.BtnIgual.Location = new System.Drawing.Point(196, 255);
            this.BtnIgual.Name = "BtnIgual";
            this.BtnIgual.Size = new System.Drawing.Size(116, 52);
            this.BtnIgual.TabIndex = 22;
            this.BtnIgual.Text = "=";
            this.BtnIgual.UseVisualStyleBackColor = false;
            this.BtnIgual.Click += new System.EventHandler(this.BtnIgual_Click);
            // 
            // BtnGuardar
            // 
            this.BtnGuardar.BackColor = System.Drawing.Color.PaleTurquoise;
            this.BtnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnGuardar.ForeColor = System.Drawing.Color.Red;
            this.BtnGuardar.Location = new System.Drawing.Point(257, 134);
            this.BtnGuardar.Name = "BtnGuardar";
            this.BtnGuardar.Size = new System.Drawing.Size(55, 55);
            this.BtnGuardar.TabIndex = 21;
            this.BtnGuardar.Text = "MS";
            this.BtnGuardar.UseVisualStyleBackColor = false;
            this.BtnGuardar.Click += new System.EventHandler(this.BtnGuardar_Click);
            // 
            // BtnRecuperarMemoria
            // 
            this.BtnRecuperarMemoria.BackColor = System.Drawing.Color.PaleTurquoise;
            this.BtnRecuperarMemoria.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnRecuperarMemoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnRecuperarMemoria.ForeColor = System.Drawing.Color.Red;
            this.BtnRecuperarMemoria.Location = new System.Drawing.Point(257, 73);
            this.BtnRecuperarMemoria.Name = "BtnRecuperarMemoria";
            this.BtnRecuperarMemoria.Size = new System.Drawing.Size(55, 55);
            this.BtnRecuperarMemoria.TabIndex = 20;
            this.BtnRecuperarMemoria.Text = "MR";
            this.BtnRecuperarMemoria.UseVisualStyleBackColor = false;
            this.BtnRecuperarMemoria.Click += new System.EventHandler(this.BtnRecuperarMemoria_Click);
            // 
            // BtnBorrarMemoria
            // 
            this.BtnBorrarMemoria.BackColor = System.Drawing.Color.PaleTurquoise;
            this.BtnBorrarMemoria.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnBorrarMemoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnBorrarMemoria.ForeColor = System.Drawing.Color.Red;
            this.BtnBorrarMemoria.Location = new System.Drawing.Point(257, 11);
            this.BtnBorrarMemoria.Name = "BtnBorrarMemoria";
            this.BtnBorrarMemoria.Size = new System.Drawing.Size(55, 55);
            this.BtnBorrarMemoria.TabIndex = 19;
            this.BtnBorrarMemoria.Text = "MC";
            this.BtnBorrarMemoria.UseVisualStyleBackColor = false;
            this.BtnBorrarMemoria.Click += new System.EventHandler(this.BtnBorrarMemoria_Click);
            // 
            // Btn7
            // 
            this.Btn7.BackColor = System.Drawing.SystemColors.HotTrack;
            this.Btn7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn7.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Btn7.Location = new System.Drawing.Point(13, 72);
            this.Btn7.Name = "Btn7";
            this.Btn7.Size = new System.Drawing.Size(55, 55);
            this.Btn7.TabIndex = 18;
            this.Btn7.Text = "7";
            this.Btn7.UseVisualStyleBackColor = false;
            this.Btn7.Click += new System.EventHandler(this.BtnNumber_Click);
            // 
            // BtnClear
            // 
            this.BtnClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.BtnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnClear.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BtnClear.Location = new System.Drawing.Point(104, 11);
            this.BtnClear.Name = "BtnClear";
            this.BtnClear.Size = new System.Drawing.Size(85, 55);
            this.BtnClear.TabIndex = 17;
            this.BtnClear.Text = "C";
            this.BtnClear.UseVisualStyleBackColor = false;
            this.BtnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // BtnClearEntry
            // 
            this.BtnClearEntry.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.BtnClearEntry.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnClearEntry.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnClearEntry.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BtnClearEntry.Location = new System.Drawing.Point(13, 11);
            this.BtnClearEntry.Name = "BtnClearEntry";
            this.BtnClearEntry.Size = new System.Drawing.Size(85, 55);
            this.BtnClearEntry.TabIndex = 16;
            this.BtnClearEntry.Text = "CE";
            this.BtnClearEntry.UseVisualStyleBackColor = false;
            this.BtnClearEntry.Click += new System.EventHandler(this.BtnClearEntry_Click);
            // 
            // BtnMas
            // 
            this.BtnMas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.BtnMas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnMas.ForeColor = System.Drawing.Color.Snow;
            this.BtnMas.Location = new System.Drawing.Point(196, 193);
            this.BtnMas.Name = "BtnMas";
            this.BtnMas.Size = new System.Drawing.Size(55, 55);
            this.BtnMas.TabIndex = 15;
            this.BtnMas.Text = "+";
            this.BtnMas.UseVisualStyleBackColor = false;
            this.BtnMas.Click += new System.EventHandler(this.BtnOperacion_Click);
            // 
            // BtnComa
            // 
            this.BtnComa.BackColor = System.Drawing.SystemColors.HotTrack;
            this.BtnComa.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnComa.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.BtnComa.Location = new System.Drawing.Point(135, 255);
            this.BtnComa.Name = "BtnComa";
            this.BtnComa.Size = new System.Drawing.Size(55, 55);
            this.BtnComa.TabIndex = 14;
            this.BtnComa.Text = ",";
            this.BtnComa.UseVisualStyleBackColor = false;
            this.BtnComa.Click += new System.EventHandler(this.BtnComa_Click);
            // 
            // Btn0
            // 
            this.Btn0.BackColor = System.Drawing.SystemColors.HotTrack;
            this.Btn0.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn0.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Btn0.Location = new System.Drawing.Point(74, 255);
            this.Btn0.Name = "Btn0";
            this.Btn0.Size = new System.Drawing.Size(55, 55);
            this.Btn0.TabIndex = 13;
            this.Btn0.Text = "0";
            this.Btn0.UseVisualStyleBackColor = false;
            this.Btn0.Click += new System.EventHandler(this.BtnNumber_Click);
            // 
            // BtnMenos
            // 
            this.BtnMenos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.BtnMenos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnMenos.ForeColor = System.Drawing.Color.Snow;
            this.BtnMenos.Location = new System.Drawing.Point(196, 132);
            this.BtnMenos.Name = "BtnMenos";
            this.BtnMenos.Size = new System.Drawing.Size(55, 55);
            this.BtnMenos.TabIndex = 12;
            this.BtnMenos.Text = "-";
            this.BtnMenos.UseVisualStyleBackColor = false;
            this.BtnMenos.Click += new System.EventHandler(this.BtnOperacion_Click);
            // 
            // BtnMult
            // 
            this.BtnMult.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.BtnMult.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnMult.ForeColor = System.Drawing.Color.Snow;
            this.BtnMult.Location = new System.Drawing.Point(196, 72);
            this.BtnMult.Name = "BtnMult";
            this.BtnMult.Size = new System.Drawing.Size(55, 55);
            this.BtnMult.TabIndex = 11;
            this.BtnMult.Text = "*";
            this.BtnMult.UseVisualStyleBackColor = false;
            this.BtnMult.Click += new System.EventHandler(this.BtnOperacion_Click);
            // 
            // BtnInvertir
            // 
            this.BtnInvertir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.BtnInvertir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnInvertir.ForeColor = System.Drawing.Color.Snow;
            this.BtnInvertir.Location = new System.Drawing.Point(13, 255);
            this.BtnInvertir.Name = "BtnInvertir";
            this.BtnInvertir.Size = new System.Drawing.Size(55, 55);
            this.BtnInvertir.TabIndex = 10;
            this.BtnInvertir.Text = "1/X";
            this.BtnInvertir.UseVisualStyleBackColor = false;
            this.BtnInvertir.Click += new System.EventHandler(this.BtnInvert_Click);
            // 
            // Btn3
            // 
            this.Btn3.BackColor = System.Drawing.SystemColors.HotTrack;
            this.Btn3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Btn3.Location = new System.Drawing.Point(135, 195);
            this.Btn3.Name = "Btn3";
            this.Btn3.Size = new System.Drawing.Size(55, 55);
            this.Btn3.TabIndex = 9;
            this.Btn3.Text = "3";
            this.Btn3.UseVisualStyleBackColor = false;
            this.Btn3.Click += new System.EventHandler(this.BtnNumber_Click);
            // 
            // Btn2
            // 
            this.Btn2.BackColor = System.Drawing.SystemColors.HotTrack;
            this.Btn2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Btn2.Location = new System.Drawing.Point(74, 195);
            this.Btn2.Name = "Btn2";
            this.Btn2.Size = new System.Drawing.Size(55, 55);
            this.Btn2.TabIndex = 8;
            this.Btn2.Text = "2";
            this.Btn2.UseVisualStyleBackColor = false;
            this.Btn2.Click += new System.EventHandler(this.BtnNumber_Click);
            // 
            // Btn1
            // 
            this.Btn1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.Btn1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Btn1.Location = new System.Drawing.Point(13, 195);
            this.Btn1.Name = "Btn1";
            this.Btn1.Size = new System.Drawing.Size(55, 55);
            this.Btn1.TabIndex = 7;
            this.Btn1.Text = "1";
            this.Btn1.UseVisualStyleBackColor = false;
            this.Btn1.Click += new System.EventHandler(this.BtnNumber_Click);
            // 
            // Btn6
            // 
            this.Btn6.BackColor = System.Drawing.SystemColors.HotTrack;
            this.Btn6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn6.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Btn6.Location = new System.Drawing.Point(135, 133);
            this.Btn6.Name = "Btn6";
            this.Btn6.Size = new System.Drawing.Size(55, 55);
            this.Btn6.TabIndex = 6;
            this.Btn6.Text = "6";
            this.Btn6.UseVisualStyleBackColor = false;
            this.Btn6.Click += new System.EventHandler(this.BtnNumber_Click);
            // 
            // Btn5
            // 
            this.Btn5.BackColor = System.Drawing.SystemColors.HotTrack;
            this.Btn5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn5.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Btn5.Location = new System.Drawing.Point(74, 133);
            this.Btn5.Name = "Btn5";
            this.Btn5.Size = new System.Drawing.Size(55, 55);
            this.Btn5.TabIndex = 5;
            this.Btn5.Text = "5";
            this.Btn5.UseVisualStyleBackColor = false;
            this.Btn5.Click += new System.EventHandler(this.BtnNumber_Click);
            // 
            // Btn4
            // 
            this.Btn4.BackColor = System.Drawing.SystemColors.HotTrack;
            this.Btn4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Btn4.Location = new System.Drawing.Point(13, 133);
            this.Btn4.Name = "Btn4";
            this.Btn4.Size = new System.Drawing.Size(55, 55);
            this.Btn4.TabIndex = 4;
            this.Btn4.Text = "4";
            this.Btn4.UseVisualStyleBackColor = false;
            this.Btn4.Click += new System.EventHandler(this.BtnNumber_Click);
            // 
            // BtnDiv
            // 
            this.BtnDiv.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.BtnDiv.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDiv.ForeColor = System.Drawing.Color.Snow;
            this.BtnDiv.Location = new System.Drawing.Point(196, 11);
            this.BtnDiv.Name = "BtnDiv";
            this.BtnDiv.Size = new System.Drawing.Size(55, 55);
            this.BtnDiv.TabIndex = 3;
            this.BtnDiv.Text = "/";
            this.BtnDiv.UseVisualStyleBackColor = false;
            this.BtnDiv.Click += new System.EventHandler(this.BtnOperacion_Click);
            // 
            // Btn9
            // 
            this.Btn9.BackColor = System.Drawing.SystemColors.HotTrack;
            this.Btn9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn9.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Btn9.Location = new System.Drawing.Point(135, 72);
            this.Btn9.Name = "Btn9";
            this.Btn9.Size = new System.Drawing.Size(55, 55);
            this.Btn9.TabIndex = 2;
            this.Btn9.Text = "9";
            this.Btn9.UseVisualStyleBackColor = false;
            this.Btn9.Click += new System.EventHandler(this.BtnNumber_Click);
            // 
            // Btn8
            // 
            this.Btn8.BackColor = System.Drawing.SystemColors.HotTrack;
            this.Btn8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn8.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Btn8.Location = new System.Drawing.Point(74, 72);
            this.Btn8.Name = "Btn8";
            this.Btn8.Size = new System.Drawing.Size(55, 55);
            this.Btn8.TabIndex = 1;
            this.Btn8.Text = "8";
            this.Btn8.UseVisualStyleBackColor = false;
            this.Btn8.Click += new System.EventHandler(this.BtnNumber_Click);
            // 
            // BtnSumarMemoria
            // 
            this.BtnSumarMemoria.BackColor = System.Drawing.Color.PaleTurquoise;
            this.BtnSumarMemoria.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSumarMemoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSumarMemoria.ForeColor = System.Drawing.Color.Red;
            this.BtnSumarMemoria.Location = new System.Drawing.Point(257, 194);
            this.BtnSumarMemoria.Name = "BtnSumarMemoria";
            this.BtnSumarMemoria.Size = new System.Drawing.Size(55, 55);
            this.BtnSumarMemoria.TabIndex = 0;
            this.BtnSumarMemoria.Text = "M+";
            this.BtnSumarMemoria.UseVisualStyleBackColor = false;
            this.BtnSumarMemoria.Click += new System.EventHandler(this.BtnSumarMemoria_Click);
            // 
            // TxtResultado
            // 
            this.TxtResultado.BackColor = System.Drawing.Color.White;
            this.TxtResultado.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtResultado.Enabled = false;
            this.TxtResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtResultado.ForeColor = System.Drawing.Color.Black;
            this.TxtResultado.Location = new System.Drawing.Point(12, 68);
            this.TxtResultado.MaxLength = 12;
            this.TxtResultado.Name = "TxtResultado";
            this.TxtResultado.Size = new System.Drawing.Size(299, 25);
            this.TxtResultado.TabIndex = 1;
            this.TxtResultado.Text = "0";
            this.TxtResultado.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // TxtAux
            // 
            this.TxtAux.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.TxtAux.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtAux.Cursor = System.Windows.Forms.Cursors.Default;
            this.TxtAux.Enabled = false;
            this.TxtAux.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtAux.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.TxtAux.Location = new System.Drawing.Point(13, 13);
            this.TxtAux.Multiline = true;
            this.TxtAux.Name = "TxtAux";
            this.TxtAux.ReadOnly = true;
            this.TxtAux.Size = new System.Drawing.Size(298, 49);
            this.TxtAux.TabIndex = 2;
            this.TxtAux.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // FrmCalculadora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(322, 423);
            this.Controls.Add(this.TxtAux);
            this.Controls.Add(this.TxtResultado);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmCalculadora";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculadora";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button BtnGuardar;
        private System.Windows.Forms.Button BtnRecuperarMemoria;
        private System.Windows.Forms.Button BtnBorrarMemoria;
        private System.Windows.Forms.Button Btn7;
        private System.Windows.Forms.Button BtnClear;
        private System.Windows.Forms.Button BtnClearEntry;
        private System.Windows.Forms.Button BtnMas;
        private System.Windows.Forms.Button BtnComa;
        private System.Windows.Forms.Button Btn0;
        private System.Windows.Forms.Button BtnMenos;
        private System.Windows.Forms.Button BtnMult;
        private System.Windows.Forms.Button BtnInvertir;
        private System.Windows.Forms.Button Btn3;
        private System.Windows.Forms.Button Btn2;
        private System.Windows.Forms.Button Btn1;
        private System.Windows.Forms.Button Btn6;
        private System.Windows.Forms.Button Btn5;
        private System.Windows.Forms.Button Btn4;
        private System.Windows.Forms.Button BtnDiv;
        private System.Windows.Forms.Button Btn9;
        private System.Windows.Forms.Button Btn8;
        private System.Windows.Forms.Button BtnSumarMemoria;
        private System.Windows.Forms.Button BtnIgual;
        private System.Windows.Forms.TextBox TxtResultado;
        private System.Windows.Forms.TextBox TxtAux;
    }
}

