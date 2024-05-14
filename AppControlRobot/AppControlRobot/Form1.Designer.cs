
namespace AppControlRobot
{
    partial class MainApp
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
            this.Btn_up_motors = new System.Windows.Forms.Button();
            this.Btn_left_motors = new System.Windows.Forms.Button();
            this.Btn_right_motors = new System.Windows.Forms.Button();
            this.Btn_abajo_motores = new System.Windows.Forms.Button();
            this.Btn_arriba_servos = new System.Windows.Forms.Button();
            this.Btn_left_servos = new System.Windows.Forms.Button();
            this.Btn_right_servos = new System.Windows.Forms.Button();
            this.Btn_down_servos = new System.Windows.Forms.Button();
            this.DiagonalUL = new System.Windows.Forms.Button();
            this.DiagonalUR = new System.Windows.Forms.Button();
            this.DiagonalBL = new System.Windows.Forms.Button();
            this.DiagonalBR = new System.Windows.Forms.Button();
            this.RotationL = new System.Windows.Forms.Button();
            this.RotationR = new System.Windows.Forms.Button();
            this.Reset_servos = new System.Windows.Forms.Button();
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
            // Btn_up_motors
            // 
            this.Btn_up_motors.Location = new System.Drawing.Point(106, 175);
            this.Btn_up_motors.Name = "Btn_up_motors";
            this.Btn_up_motors.Size = new System.Drawing.Size(75, 75);
            this.Btn_up_motors.TabIndex = 10;
            this.Btn_up_motors.Tag = "0";
            this.Btn_up_motors.Text = "Arriba";
            this.Btn_up_motors.UseVisualStyleBackColor = true;
            this.Btn_up_motors.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Btn_MouseDown);
            this.Btn_up_motors.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Btn_MouseUp);
            // 
            // Btn_left_motors
            // 
            this.Btn_left_motors.Location = new System.Drawing.Point(25, 256);
            this.Btn_left_motors.Name = "Btn_left_motors";
            this.Btn_left_motors.Size = new System.Drawing.Size(75, 75);
            this.Btn_left_motors.TabIndex = 11;
            this.Btn_left_motors.Tag = "1";
            this.Btn_left_motors.Text = "Izquierda";
            this.Btn_left_motors.UseVisualStyleBackColor = true;
            this.Btn_left_motors.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Btn_MouseDown);
            this.Btn_left_motors.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Btn_MouseUp);
            // 
            // Btn_right_motors
            // 
            this.Btn_right_motors.Location = new System.Drawing.Point(187, 256);
            this.Btn_right_motors.Name = "Btn_right_motors";
            this.Btn_right_motors.Size = new System.Drawing.Size(75, 75);
            this.Btn_right_motors.TabIndex = 12;
            this.Btn_right_motors.Tag = "2";
            this.Btn_right_motors.Text = "Derecha";
            this.Btn_right_motors.UseVisualStyleBackColor = true;
            this.Btn_right_motors.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Btn_MouseDown);
            this.Btn_right_motors.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Btn_MouseUp);
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
            // Btn_left_servos
            // 
            this.Btn_left_servos.Location = new System.Drawing.Point(946, 256);
            this.Btn_left_servos.Name = "Btn_left_servos";
            this.Btn_left_servos.Size = new System.Drawing.Size(75, 75);
            this.Btn_left_servos.TabIndex = 15;
            this.Btn_left_servos.Tag = "11";
            this.Btn_left_servos.Text = "Izquierda";
            this.Btn_left_servos.UseVisualStyleBackColor = true;
            this.Btn_left_servos.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Btn_MouseDown);
            this.Btn_left_servos.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Btn_MouseUp);
            // 
            // Btn_right_servos
            // 
            this.Btn_right_servos.Location = new System.Drawing.Point(1099, 256);
            this.Btn_right_servos.Name = "Btn_right_servos";
            this.Btn_right_servos.Size = new System.Drawing.Size(75, 75);
            this.Btn_right_servos.TabIndex = 16;
            this.Btn_right_servos.Tag = "12";
            this.Btn_right_servos.Text = "Derecha";
            this.Btn_right_servos.UseVisualStyleBackColor = true;
            this.Btn_right_servos.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Btn_MouseDown);
            this.Btn_right_servos.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Btn_MouseUp);
            // 
            // Btn_down_servos
            // 
            this.Btn_down_servos.Location = new System.Drawing.Point(1022, 337);
            this.Btn_down_servos.Name = "Btn_down_servos";
            this.Btn_down_servos.Size = new System.Drawing.Size(75, 75);
            this.Btn_down_servos.TabIndex = 17;
            this.Btn_down_servos.Tag = "13";
            this.Btn_down_servos.Text = "Abajo";
            this.Btn_down_servos.UseVisualStyleBackColor = true;
            this.Btn_down_servos.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Btn_MouseDown);
            this.Btn_down_servos.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Btn_MouseUp);
            // 
            // DiagonalUL
            // 
            this.DiagonalUL.Location = new System.Drawing.Point(25, 175);
            this.DiagonalUL.Name = "DiagonalUL";
            this.DiagonalUL.Size = new System.Drawing.Size(75, 75);
            this.DiagonalUL.TabIndex = 18;
            this.DiagonalUL.Tag = "4";
            this.DiagonalUL.Text = "DiagonalUL";
            this.DiagonalUL.UseVisualStyleBackColor = true;
            this.DiagonalUL.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Btn_MouseDown);
            this.DiagonalUL.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Btn_MouseUp);
            // 
            // DiagonalUR
            // 
            this.DiagonalUR.Location = new System.Drawing.Point(187, 175);
            this.DiagonalUR.Name = "DiagonalUR";
            this.DiagonalUR.Size = new System.Drawing.Size(75, 75);
            this.DiagonalUR.TabIndex = 19;
            this.DiagonalUR.Tag = "5";
            this.DiagonalUR.Text = "DiagonalUR";
            this.DiagonalUR.UseVisualStyleBackColor = true;
            this.DiagonalUR.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Btn_MouseDown);
            this.DiagonalUR.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Btn_MouseUp);
            // 
            // DiagonalBL
            // 
            this.DiagonalBL.Location = new System.Drawing.Point(25, 337);
            this.DiagonalBL.Name = "DiagonalBL";
            this.DiagonalBL.Size = new System.Drawing.Size(75, 75);
            this.DiagonalBL.TabIndex = 20;
            this.DiagonalBL.Tag = "6";
            this.DiagonalBL.Text = "DiagonalBL";
            this.DiagonalBL.UseVisualStyleBackColor = true;
            this.DiagonalBL.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Btn_MouseDown);
            this.DiagonalBL.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Btn_MouseUp);
            // 
            // DiagonalBR
            // 
            this.DiagonalBR.Location = new System.Drawing.Point(187, 337);
            this.DiagonalBR.Name = "DiagonalBR";
            this.DiagonalBR.Size = new System.Drawing.Size(75, 75);
            this.DiagonalBR.TabIndex = 21;
            this.DiagonalBR.Tag = "7";
            this.DiagonalBR.Text = "DiagonalBR";
            this.DiagonalBR.UseVisualStyleBackColor = true;
            this.DiagonalBR.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Btn_MouseDown);
            this.DiagonalBR.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Btn_MouseUp);
            // 
            // RotationL
            // 
            this.RotationL.Location = new System.Drawing.Point(25, 122);
            this.RotationL.Name = "RotationL";
            this.RotationL.Size = new System.Drawing.Size(75, 40);
            this.RotationL.TabIndex = 22;
            this.RotationL.Tag = "8";
            this.RotationL.Text = "RotacionI";
            this.RotationL.UseVisualStyleBackColor = true;
            this.RotationL.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Btn_MouseDown);
            this.RotationL.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Btn_MouseUp);
            // 
            // RotationR
            // 
            this.RotationR.Location = new System.Drawing.Point(187, 122);
            this.RotationR.Name = "RotationR";
            this.RotationR.Size = new System.Drawing.Size(75, 40);
            this.RotationR.TabIndex = 23;
            this.RotationR.Tag = "9";
            this.RotationR.Text = "RotationR";
            this.RotationR.UseVisualStyleBackColor = true;
            this.RotationR.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Btn_MouseDown);
            this.RotationR.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Btn_MouseUp);
            // 
            // Reset_servos
            // 
            this.Reset_servos.Location = new System.Drawing.Point(1022, 256);
            this.Reset_servos.Name = "Reset_servos";
            this.Reset_servos.Size = new System.Drawing.Size(75, 75);
            this.Reset_servos.TabIndex = 24;
            this.Reset_servos.Tag = "14";
            this.Reset_servos.Text = "Reset_servos";
            this.Reset_servos.UseVisualStyleBackColor = true;
            this.Reset_servos.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Btn_MouseDown);
            this.Reset_servos.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Btn_MouseUp);
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
            // MainApp
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
            this.Controls.Add(this.Reset_servos);
            this.Controls.Add(this.RotationR);
            this.Controls.Add(this.RotationL);
            this.Controls.Add(this.DiagonalBR);
            this.Controls.Add(this.DiagonalBL);
            this.Controls.Add(this.DiagonalUR);
            this.Controls.Add(this.DiagonalUL);
            this.Controls.Add(this.Btn_down_servos);
            this.Controls.Add(this.Btn_right_servos);
            this.Controls.Add(this.Btn_left_servos);
            this.Controls.Add(this.Btn_arriba_servos);
            this.Controls.Add(this.Btn_abajo_motores);
            this.Controls.Add(this.Btn_right_motors);
            this.Controls.Add(this.Btn_left_motors);
            this.Controls.Add(this.Btn_up_motors);
            this.Controls.Add(this.label_titulo_servos);
            this.Controls.Add(this.label_titulo_motores);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainApp";
            this.Text = "Control remoto";
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
        private System.Windows.Forms.Button Btn_up_motors;
        private System.Windows.Forms.Button Btn_left_motors;
        private System.Windows.Forms.Button Btn_right_motors;
        private System.Windows.Forms.Button Btn_abajo_motores;
        private System.Windows.Forms.Button Btn_arriba_servos;
        private System.Windows.Forms.Button Btn_left_servos;
        private System.Windows.Forms.Button Btn_right_servos;
        private System.Windows.Forms.Button Btn_down_servos;
        private System.Windows.Forms.Button DiagonalUL;
        private System.Windows.Forms.Button DiagonalUR;
        private System.Windows.Forms.Button DiagonalBL;
        private System.Windows.Forms.Button DiagonalBR;
        private System.Windows.Forms.Button RotationL;
        private System.Windows.Forms.Button RotationR;
        private System.Windows.Forms.Button Reset_servos;
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

