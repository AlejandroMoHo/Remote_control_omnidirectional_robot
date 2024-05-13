
namespace AppControlRobot
{
    partial class Form1
    {


        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label_titulo_motores = new System.Windows.Forms.Label();
            this.label_titulo_servos = new System.Windows.Forms.Label();
            this.Btn_arriba_motores = new System.Windows.Forms.Button();
            this.Btn_izquierda_motores = new System.Windows.Forms.Button();
            this.Btn_derecha_motores = new System.Windows.Forms.Button();
            this.Btn_abajo_motores = new System.Windows.Forms.Button();
            this.Btn_arriba_servos = new System.Windows.Forms.Button();
            this.Btn_izquierda_servos = new System.Windows.Forms.Button();
            this.Btn_derecha_servos = new System.Windows.Forms.Button();
            this.Btn_abajo_servos = new System.Windows.Forms.Button();
            this.DiagonalSI = new System.Windows.Forms.Button();
            this.DiagonalSD = new System.Windows.Forms.Button();
            this.DiagonalII = new System.Windows.Forms.Button();
            this.DiagonalID = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.RotacionD = new System.Windows.Forms.Button();
            this.Restablecer = new System.Windows.Forms.Button();
            this.camara = new System.Windows.Forms.PictureBox();
            this.btn_raw = new System.Windows.Forms.Button();
            this.btn_red = new System.Windows.Forms.Button();
            this.btn_green = new System.Windows.Forms.Button();
            this.btn_blue = new System.Windows.Forms.Button();
            this.label_detectando = new System.Windows.Forms.Label();
            this.pictureBox_color_detect = new System.Windows.Forms.PictureBox();
            this.label_battery = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.camara)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_color_detect)).BeginInit();
            this.SuspendLayout();
            // 
            // label_titulo_motores
            // 
            this.label_titulo_motores.AutoSize = true;
            this.label_titulo_motores.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_titulo_motores.Location = new System.Drawing.Point(81, 51);
            this.label_titulo_motores.Name = "label_titulo_motores";
            this.label_titulo_motores.Size = new System.Drawing.Size(132, 37);
            this.label_titulo_motores.TabIndex = 7;
            this.label_titulo_motores.Text = "Motores";
            // 
            // label_titulo_servos
            // 
            this.label_titulo_servos.AutoSize = true;
            this.label_titulo_servos.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_titulo_servos.Location = new System.Drawing.Point(1000, 51);
            this.label_titulo_servos.Name = "label_titulo_servos";
            this.label_titulo_servos.Size = new System.Drawing.Size(115, 37);
            this.label_titulo_servos.TabIndex = 8;
            this.label_titulo_servos.Text = "Servos";
            // 
            // Btn_arriba_motores
            // 
            this.Btn_arriba_motores.Location = new System.Drawing.Point(106, 175);
            this.Btn_arriba_motores.Name = "Btn_arriba_motores";
            this.Btn_arriba_motores.Size = new System.Drawing.Size(75, 75);
            this.Btn_arriba_motores.TabIndex = 10;
            this.Btn_arriba_motores.Tag = "0";
            this.Btn_arriba_motores.Text = "Arriba";
            this.Btn_arriba_motores.UseVisualStyleBackColor = true;
            this.Btn_arriba_motores.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Btn_MouseDown);
            this.Btn_arriba_motores.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Btn_MouseUp);
            // 
            // Btn_izquierda_motores
            // 
            this.Btn_izquierda_motores.Location = new System.Drawing.Point(25, 256);
            this.Btn_izquierda_motores.Name = "Btn_izquierda_motores";
            this.Btn_izquierda_motores.Size = new System.Drawing.Size(75, 75);
            this.Btn_izquierda_motores.TabIndex = 11;
            this.Btn_izquierda_motores.Tag = "1";
            this.Btn_izquierda_motores.Text = "Izquierda";
            this.Btn_izquierda_motores.UseVisualStyleBackColor = true;
            this.Btn_izquierda_motores.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Btn_MouseDown);
            this.Btn_izquierda_motores.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Btn_MouseUp);
            // 
            // Btn_derecha_motores
            // 
            this.Btn_derecha_motores.Location = new System.Drawing.Point(187, 256);
            this.Btn_derecha_motores.Name = "Btn_derecha_motores";
            this.Btn_derecha_motores.Size = new System.Drawing.Size(75, 75);
            this.Btn_derecha_motores.TabIndex = 12;
            this.Btn_derecha_motores.Tag = "2";
            this.Btn_derecha_motores.Text = "Derecha";
            this.Btn_derecha_motores.UseVisualStyleBackColor = true;
            this.Btn_derecha_motores.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Btn_MouseDown);
            this.Btn_derecha_motores.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Btn_MouseUp);
            // 
            // Btn_abajo_motores
            // 
            this.Btn_abajo_motores.Location = new System.Drawing.Point(106, 337);
            this.Btn_abajo_motores.Name = "Btn_abajo_motores";
            this.Btn_abajo_motores.Size = new System.Drawing.Size(75, 75);
            this.Btn_abajo_motores.TabIndex = 13;
            this.Btn_abajo_motores.Tag = "3";
            this.Btn_abajo_motores.Text = "Abajo";
            this.Btn_abajo_motores.UseVisualStyleBackColor = true;
            this.Btn_abajo_motores.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Btn_MouseDown);
            this.Btn_abajo_motores.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Btn_MouseUp);
            // 
            // Btn_arriba_servos
            // 
            this.Btn_arriba_servos.Location = new System.Drawing.Point(1022, 175);
            this.Btn_arriba_servos.Name = "Btn_arriba_servos";
            this.Btn_arriba_servos.Size = new System.Drawing.Size(75, 75);
            this.Btn_arriba_servos.TabIndex = 14;
            this.Btn_arriba_servos.Tag = "10";
            this.Btn_arriba_servos.Text = "Arriba";
            this.Btn_arriba_servos.UseVisualStyleBackColor = true;
            this.Btn_arriba_servos.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Btn_MouseDown);
            this.Btn_arriba_servos.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Btn_MouseUp);
            // 
            // Btn_izquierda_servos
            // 
            this.Btn_izquierda_servos.Location = new System.Drawing.Point(946, 256);
            this.Btn_izquierda_servos.Name = "Btn_izquierda_servos";
            this.Btn_izquierda_servos.Size = new System.Drawing.Size(75, 75);
            this.Btn_izquierda_servos.TabIndex = 15;
            this.Btn_izquierda_servos.Tag = "11";
            this.Btn_izquierda_servos.Text = "Izquierda";
            this.Btn_izquierda_servos.UseVisualStyleBackColor = true;
            this.Btn_izquierda_servos.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Btn_MouseDown);
            this.Btn_izquierda_servos.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Btn_MouseUp);
            // 
            // Btn_derecha_servos
            // 
            this.Btn_derecha_servos.Location = new System.Drawing.Point(1099, 256);
            this.Btn_derecha_servos.Name = "Btn_derecha_servos";
            this.Btn_derecha_servos.Size = new System.Drawing.Size(75, 75);
            this.Btn_derecha_servos.TabIndex = 16;
            this.Btn_derecha_servos.Tag = "12";
            this.Btn_derecha_servos.Text = "Derecha";
            this.Btn_derecha_servos.UseVisualStyleBackColor = true;
            this.Btn_derecha_servos.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Btn_MouseDown);
            this.Btn_derecha_servos.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Btn_MouseUp);
            // 
            // Btn_abajo_servos
            // 
            this.Btn_abajo_servos.Location = new System.Drawing.Point(1022, 337);
            this.Btn_abajo_servos.Name = "Btn_abajo_servos";
            this.Btn_abajo_servos.Size = new System.Drawing.Size(75, 75);
            this.Btn_abajo_servos.TabIndex = 17;
            this.Btn_abajo_servos.Tag = "13";
            this.Btn_abajo_servos.Text = "Abajo";
            this.Btn_abajo_servos.UseVisualStyleBackColor = true;
            this.Btn_abajo_servos.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Btn_MouseDown);
            this.Btn_abajo_servos.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Btn_MouseUp);
            // 
            // DiagonalSI
            // 
            this.DiagonalSI.Location = new System.Drawing.Point(25, 175);
            this.DiagonalSI.Name = "DiagonalSI";
            this.DiagonalSI.Size = new System.Drawing.Size(75, 75);
            this.DiagonalSI.TabIndex = 18;
            this.DiagonalSI.Tag = "4";
            this.DiagonalSI.Text = "DiagonalSI";
            this.DiagonalSI.UseVisualStyleBackColor = true;
            this.DiagonalSI.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Btn_MouseDown);
            this.DiagonalSI.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Btn_MouseUp);
            // 
            // DiagonalSD
            // 
            this.DiagonalSD.Location = new System.Drawing.Point(187, 175);
            this.DiagonalSD.Name = "DiagonalSD";
            this.DiagonalSD.Size = new System.Drawing.Size(75, 75);
            this.DiagonalSD.TabIndex = 19;
            this.DiagonalSD.Tag = "5";
            this.DiagonalSD.Text = "DiagonalSD";
            this.DiagonalSD.UseVisualStyleBackColor = true;
            this.DiagonalSD.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Btn_MouseDown);
            this.DiagonalSD.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Btn_MouseUp);
            // 
            // DiagonalII
            // 
            this.DiagonalII.Location = new System.Drawing.Point(25, 337);
            this.DiagonalII.Name = "DiagonalII";
            this.DiagonalII.Size = new System.Drawing.Size(75, 75);
            this.DiagonalII.TabIndex = 20;
            this.DiagonalII.Tag = "6";
            this.DiagonalII.Text = "DiagonalII";
            this.DiagonalII.UseVisualStyleBackColor = true;
            this.DiagonalII.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Btn_MouseDown);
            this.DiagonalII.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Btn_MouseUp);
            // 
            // DiagonalID
            // 
            this.DiagonalID.Location = new System.Drawing.Point(187, 337);
            this.DiagonalID.Name = "DiagonalID";
            this.DiagonalID.Size = new System.Drawing.Size(75, 75);
            this.DiagonalID.TabIndex = 21;
            this.DiagonalID.Tag = "7";
            this.DiagonalID.Text = "DiagonalID";
            this.DiagonalID.UseVisualStyleBackColor = true;
            this.DiagonalID.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Btn_MouseDown);
            this.DiagonalID.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Btn_MouseUp);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(25, 122);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 40);
            this.button5.TabIndex = 22;
            this.button5.Tag = "8";
            this.button5.Text = "RotacionI";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Btn_MouseDown);
            this.button5.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Btn_MouseUp);
            // 
            // RotacionD
            // 
            this.RotacionD.Location = new System.Drawing.Point(187, 122);
            this.RotacionD.Name = "RotacionD";
            this.RotacionD.Size = new System.Drawing.Size(75, 40);
            this.RotacionD.TabIndex = 23;
            this.RotacionD.Tag = "9";
            this.RotacionD.Text = "RotacionD";
            this.RotacionD.UseVisualStyleBackColor = true;
            this.RotacionD.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Btn_MouseDown);
            this.RotacionD.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Btn_MouseUp);
            // 
            // Restablecer
            // 
            this.Restablecer.Location = new System.Drawing.Point(1022, 256);
            this.Restablecer.Name = "Restablecer";
            this.Restablecer.Size = new System.Drawing.Size(75, 75);
            this.Restablecer.TabIndex = 24;
            this.Restablecer.Tag = "14";
            this.Restablecer.Text = "Restablecer";
            this.Restablecer.UseVisualStyleBackColor = true;
            this.Restablecer.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Btn_MouseDown);
            this.Restablecer.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Btn_MouseUp);
            // 
            // camara
            // 
            this.camara.Location = new System.Drawing.Point(290, 51);
            this.camara.Name = "camara";
            this.camara.Size = new System.Drawing.Size(640, 480);
            this.camara.TabIndex = 25;
            this.camara.TabStop = false;
            // 
            // btn_raw
            // 
            this.btn_raw.Location = new System.Drawing.Point(348, 564);
            this.btn_raw.Name = "btn_raw";
            this.btn_raw.Size = new System.Drawing.Size(100, 50);
            this.btn_raw.TabIndex = 26;
            this.btn_raw.Text = "Sin detección";
            this.btn_raw.UseVisualStyleBackColor = true;
            this.btn_raw.Click += new System.EventHandler(this.btn_raw_Click);
            // 
            // btn_red
            // 
            this.btn_red.Location = new System.Drawing.Point(480, 564);
            this.btn_red.Name = "btn_red";
            this.btn_red.Size = new System.Drawing.Size(100, 50);
            this.btn_red.TabIndex = 27;
            this.btn_red.Text = "Rojo";
            this.btn_red.UseVisualStyleBackColor = true;
            this.btn_red.Click += new System.EventHandler(this.btn_red_Click);
            // 
            // btn_green
            // 
            this.btn_green.Location = new System.Drawing.Point(617, 564);
            this.btn_green.Name = "btn_green";
            this.btn_green.Size = new System.Drawing.Size(100, 50);
            this.btn_green.TabIndex = 28;
            this.btn_green.Text = "Verde";
            this.btn_green.UseVisualStyleBackColor = true;
            this.btn_green.Click += new System.EventHandler(this.btn_green_Click);
            // 
            // btn_blue
            // 
            this.btn_blue.Location = new System.Drawing.Point(754, 564);
            this.btn_blue.Name = "btn_blue";
            this.btn_blue.Size = new System.Drawing.Size(100, 50);
            this.btn_blue.TabIndex = 29;
            this.btn_blue.Text = "Azul";
            this.btn_blue.UseVisualStyleBackColor = true;
            this.btn_blue.Click += new System.EventHandler(this.btn_blue_Click);
            // 
            // label_detectando
            // 
            this.label_detectando.AutoSize = true;
            this.label_detectando.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_detectando.Location = new System.Drawing.Point(967, 571);
            this.label_detectando.Name = "label_detectando";
            this.label_detectando.Size = new System.Drawing.Size(148, 29);
            this.label_detectando.TabIndex = 30;
            this.label_detectando.Text = "Detectando: ";
            // 
            // pictureBox_color_detect
            // 
            this.pictureBox_color_detect.Location = new System.Drawing.Point(1124, 564);
            this.pictureBox_color_detect.Name = "pictureBox_color_detect";
            this.pictureBox_color_detect.Size = new System.Drawing.Size(50, 50);
            this.pictureBox_color_detect.TabIndex = 31;
            this.pictureBox_color_detect.TabStop = false;
            // 
            // label_battery
            // 
            this.label_battery.AutoSize = true;
            this.label_battery.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_battery.Location = new System.Drawing.Point(20, 571);
            this.label_battery.Name = "label_battery";
            this.label_battery.Size = new System.Drawing.Size(101, 29);
            this.label_battery.TabIndex = 32;
            this.label_battery.Text = "Batería: ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1208, 639);
            this.Controls.Add(this.label_battery);
            this.Controls.Add(this.pictureBox_color_detect);
            this.Controls.Add(this.label_detectando);
            this.Controls.Add(this.btn_blue);
            this.Controls.Add(this.btn_green);
            this.Controls.Add(this.btn_red);
            this.Controls.Add(this.btn_raw);
            this.Controls.Add(this.camara);
            this.Controls.Add(this.Restablecer);
            this.Controls.Add(this.RotacionD);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.DiagonalID);
            this.Controls.Add(this.DiagonalII);
            this.Controls.Add(this.DiagonalSD);
            this.Controls.Add(this.DiagonalSI);
            this.Controls.Add(this.Btn_abajo_servos);
            this.Controls.Add(this.Btn_derecha_servos);
            this.Controls.Add(this.Btn_izquierda_servos);
            this.Controls.Add(this.Btn_arriba_servos);
            this.Controls.Add(this.Btn_abajo_motores);
            this.Controls.Add(this.Btn_derecha_motores);
            this.Controls.Add(this.Btn_izquierda_motores);
            this.Controls.Add(this.Btn_arriba_motores);
            this.Controls.Add(this.label_titulo_servos);
            this.Controls.Add(this.label_titulo_motores);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Btn_MouseUp);
            ((System.ComponentModel.ISupportInitialize)(this.camara)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_color_detect)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label_titulo_motores;
        private System.Windows.Forms.Label label_titulo_servos;
        private System.Windows.Forms.Button Btn_arriba_motores;
        private System.Windows.Forms.Button Btn_izquierda_motores;
        private System.Windows.Forms.Button Btn_derecha_motores;
        private System.Windows.Forms.Button Btn_abajo_motores;
        private System.Windows.Forms.Button Btn_arriba_servos;
        private System.Windows.Forms.Button Btn_izquierda_servos;
        private System.Windows.Forms.Button Btn_derecha_servos;
        private System.Windows.Forms.Button Btn_abajo_servos;
        private System.Windows.Forms.Button DiagonalSI;
        private System.Windows.Forms.Button DiagonalSD;
        private System.Windows.Forms.Button DiagonalII;
        private System.Windows.Forms.Button DiagonalID;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button RotacionD;
        private System.Windows.Forms.Button Restablecer;
        private System.Windows.Forms.PictureBox camara;
        private System.Windows.Forms.Button btn_raw;
        private System.Windows.Forms.Button btn_red;
        private System.Windows.Forms.Button btn_green;
        private System.Windows.Forms.Button btn_blue;
        private System.Windows.Forms.Label label_detectando;
        private System.Windows.Forms.PictureBox pictureBox_color_detect;
        private System.Windows.Forms.Label label_battery;
    }
}

