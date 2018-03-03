namespace primeraAplicacion
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
            this.btnSalir = new System.Windows.Forms.Button();
            this.datePicker = new System.Windows.Forms.DateTimePicker();
            this.textTitle = new System.Windows.Forms.TextBox();
            this.dateHourPicker = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnEventView = new System.Windows.Forms.Button();
            this.songSelected = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(283, 295);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 0;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.button1_Click);
            // 
            // datePicker
            // 
            this.datePicker.Location = new System.Drawing.Point(87, 179);
            this.datePicker.Name = "datePicker";
            this.datePicker.Size = new System.Drawing.Size(200, 20);
            this.datePicker.TabIndex = 1;
            this.datePicker.ValueChanged += new System.EventHandler(this.datePicker_ValueChanged);
            // 
            // textTitle
            // 
            this.textTitle.Location = new System.Drawing.Point(87, 104);
            this.textTitle.Name = "textTitle";
            this.textTitle.Size = new System.Drawing.Size(200, 20);
            this.textTitle.TabIndex = 2;
            // 
            // dateHourPicker
            // 
            this.dateHourPicker.Location = new System.Drawing.Point(188, 215);
            this.dateHourPicker.Mask = "00:00:00";
            this.dateHourPicker.Name = "dateHourPicker";
            this.dateHourPicker.Size = new System.Drawing.Size(50, 20);
            this.dateHourPicker.TabIndex = 3;
            this.dateHourPicker.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskedTextBox1_MaskInputRejected);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(101, 218);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Hora de evento";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(106, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(151, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "Titulo de evento";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(140, 242);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(94, 23);
            this.btnSave.TabIndex = 6;
            this.btnSave.Text = "Guardar evento";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // btnEventView
            // 
            this.btnEventView.Location = new System.Drawing.Point(12, 295);
            this.btnEventView.Name = "btnEventView";
            this.btnEventView.Size = new System.Drawing.Size(139, 23);
            this.btnEventView.TabIndex = 7;
            this.btnEventView.Text = "Ver Eventos guardados";
            this.btnEventView.UseVisualStyleBackColor = true;
            this.btnEventView.Click += new System.EventHandler(this.btnEventView_Click);
            // 
            // songSelected
            // 
            this.songSelected.FormattingEnabled = true;
            this.songSelected.Items.AddRange(new object[] {
            "1",
            "2"});
            this.songSelected.Location = new System.Drawing.Point(127, 143);
            this.songSelected.Name = "songSelected";
            this.songSelected.Size = new System.Drawing.Size(120, 30);
            this.songSelected.TabIndex = 8;
            this.songSelected.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(124, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(133, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Elija la alarma que prefiera:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(4, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(362, 44);
            this.label4.TabIndex = 10;
            this.label4.Text = "Agenda de eventos";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(283, 266);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 11;
            this.button1.Text = "Acerca de";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_3);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(370, 330);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.songSelected);
            this.Controls.Add(this.btnEventView);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateHourPicker);
            this.Controls.Add(this.textTitle);
            this.Controls.Add(this.datePicker);
            this.Controls.Add(this.btnSalir);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.DateTimePicker datePicker;
        private System.Windows.Forms.TextBox textTitle;
        private System.Windows.Forms.MaskedTextBox dateHourPicker;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnEventView;
        private System.Windows.Forms.ListBox songSelected;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
    }
}

