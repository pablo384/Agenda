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
            this.components = new System.ComponentModel.Container();
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
            this.button1 = new System.Windows.Forms.Button();
            this.tbdescription = new System.Windows.Forms.RichTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.checkSUNDAY = new System.Windows.Forms.CheckBox();
            this.checkSATURDAY = new System.Windows.Forms.CheckBox();
            this.checkFRIDAY = new System.Windows.Forms.CheckBox();
            this.checkTHURSDAY = new System.Windows.Forms.CheckBox();
            this.checkWEDNESDAY = new System.Windows.Forms.CheckBox();
            this.checkTUESDAY = new System.Windows.Forms.CheckBox();
            this.checkMONDAY = new System.Windows.Forms.CheckBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateEventDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.songDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.repeatDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eVENTOSBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.dBagendaDataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dBagendaDataSet1 = new primeraAplicacion.DBagendaDataSet();
            this.label4 = new System.Windows.Forms.Label();
            this.eVENTOSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.eventoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.agendaDataSetFinal = new primeraAplicacion.agendaDataSetFinal();
            this.eventoTableAdapter = new primeraAplicacion.agendaDataSetFinalTableAdapters.eventoTableAdapter();
            this.eVENTOSTableAdapter1 = new primeraAplicacion.DBagendaDataSetTableAdapters.EVENTOSTableAdapter();
            this.eVENTOSBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabControl2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eVENTOSBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBagendaDataSet1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBagendaDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eVENTOSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eventoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.agendaDataSetFinal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eVENTOSBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(429, 248);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 0;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.button1_Click);
            // 
            // datePicker
            // 
            this.datePicker.Location = new System.Drawing.Point(6, 17);
            this.datePicker.Name = "datePicker";
            this.datePicker.Size = new System.Drawing.Size(200, 20);
            this.datePicker.TabIndex = 1;
            this.datePicker.ValueChanged += new System.EventHandler(this.datePicker_ValueChanged);
            // 
            // textTitle
            // 
            this.textTitle.Location = new System.Drawing.Point(13, 31);
            this.textTitle.Name = "textTitle";
            this.textTitle.Size = new System.Drawing.Size(200, 20);
            this.textTitle.TabIndex = 2;
            this.textTitle.TextChanged += new System.EventHandler(this.textTitle_TextChanged);
            // 
            // dateHourPicker
            // 
            this.dateHourPicker.Location = new System.Drawing.Point(325, 203);
            this.dateHourPicker.Mask = "00:00:00";
            this.dateHourPicker.Name = "dateHourPicker";
            this.dateHourPicker.Size = new System.Drawing.Size(50, 20);
            this.dateHourPicker.TabIndex = 3;
            this.dateHourPicker.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskedTextBox1_MaskInputRejected);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(219, 203);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Hora de evento";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(8, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Titulo de evento";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(222, 227);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(94, 23);
            this.btnSave.TabIndex = 6;
            this.btnSave.Text = "Guardar evento";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // btnEventView
            // 
            this.btnEventView.Location = new System.Drawing.Point(6, 227);
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
            this.songSelected.Location = new System.Drawing.Point(273, 44);
            this.songSelected.Name = "songSelected";
            this.songSelected.Size = new System.Drawing.Size(120, 30);
            this.songSelected.TabIndex = 8;
            this.songSelected.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(270, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(133, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Elija el sonido que prefiera:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(429, 203);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 11;
            this.button1.Text = "Acerca de";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_3);
            // 
            // tbdescription
            // 
            this.tbdescription.Location = new System.Drawing.Point(13, 87);
            this.tbdescription.Name = "tbdescription";
            this.tbdescription.Size = new System.Drawing.Size(200, 96);
            this.tbdescription.TabIndex = 12;
            this.tbdescription.Text = "";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(8, 59);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 20);
            this.label5.TabIndex = 13;
            this.label5.Text = "Descripcion";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(3, 31);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(518, 303);
            this.tabControl1.TabIndex = 14;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.tabControl2);
            this.tabPage1.Controls.Add(this.btnSalir);
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.tbdescription);
            this.tabPage1.Controls.Add(this.btnSave);
            this.tabPage1.Controls.Add(this.btnEventView);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.textTitle);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.songSelected);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.dateHourPicker);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(510, 277);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Registro";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabControl2
            // 
            this.tabControl2.Controls.Add(this.tabPage3);
            this.tabControl2.Controls.Add(this.tabPage4);
            this.tabControl2.Location = new System.Drawing.Point(273, 87);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(231, 100);
            this.tabControl2.TabIndex = 14;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.datePicker);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(223, 74);
            this.tabPage3.TabIndex = 0;
            this.tabPage3.Text = "Evento Unico";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.checkSUNDAY);
            this.tabPage4.Controls.Add(this.checkSATURDAY);
            this.tabPage4.Controls.Add(this.checkFRIDAY);
            this.tabPage4.Controls.Add(this.checkTHURSDAY);
            this.tabPage4.Controls.Add(this.checkWEDNESDAY);
            this.tabPage4.Controls.Add(this.checkTUESDAY);
            this.tabPage4.Controls.Add(this.checkMONDAY);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(223, 74);
            this.tabPage4.TabIndex = 1;
            this.tabPage4.Text = "Repetido";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // checkSUNDAY
            // 
            this.checkSUNDAY.AutoSize = true;
            this.checkSUNDAY.Location = new System.Drawing.Point(155, 6);
            this.checkSUNDAY.Name = "checkSUNDAY";
            this.checkSUNDAY.Size = new System.Drawing.Size(68, 17);
            this.checkSUNDAY.TabIndex = 6;
            this.checkSUNDAY.Text = "Domingo";
            this.checkSUNDAY.UseVisualStyleBackColor = true;
            // 
            // checkSATURDAY
            // 
            this.checkSATURDAY.AutoSize = true;
            this.checkSATURDAY.Location = new System.Drawing.Point(80, 50);
            this.checkSATURDAY.Name = "checkSATURDAY";
            this.checkSATURDAY.Size = new System.Drawing.Size(63, 17);
            this.checkSATURDAY.TabIndex = 5;
            this.checkSATURDAY.Text = "Sabado";
            this.checkSATURDAY.UseVisualStyleBackColor = true;
            // 
            // checkFRIDAY
            // 
            this.checkFRIDAY.AutoSize = true;
            this.checkFRIDAY.Location = new System.Drawing.Point(80, 27);
            this.checkFRIDAY.Name = "checkFRIDAY";
            this.checkFRIDAY.Size = new System.Drawing.Size(61, 17);
            this.checkFRIDAY.TabIndex = 4;
            this.checkFRIDAY.Text = "Viernes";
            this.checkFRIDAY.UseVisualStyleBackColor = true;
            // 
            // checkTHURSDAY
            // 
            this.checkTHURSDAY.AutoSize = true;
            this.checkTHURSDAY.Location = new System.Drawing.Point(80, 6);
            this.checkTHURSDAY.Name = "checkTHURSDAY";
            this.checkTHURSDAY.Size = new System.Drawing.Size(60, 17);
            this.checkTHURSDAY.TabIndex = 3;
            this.checkTHURSDAY.Text = "Jueves";
            this.checkTHURSDAY.UseVisualStyleBackColor = true;
            this.checkTHURSDAY.CheckedChanged += new System.EventHandler(this.checkBox4_CheckedChanged);
            // 
            // checkWEDNESDAY
            // 
            this.checkWEDNESDAY.AutoSize = true;
            this.checkWEDNESDAY.Location = new System.Drawing.Point(3, 50);
            this.checkWEDNESDAY.Name = "checkWEDNESDAY";
            this.checkWEDNESDAY.Size = new System.Drawing.Size(71, 17);
            this.checkWEDNESDAY.TabIndex = 2;
            this.checkWEDNESDAY.Text = "Miercoles";
            this.checkWEDNESDAY.UseVisualStyleBackColor = true;
            // 
            // checkTUESDAY
            // 
            this.checkTUESDAY.AutoSize = true;
            this.checkTUESDAY.Location = new System.Drawing.Point(3, 27);
            this.checkTUESDAY.Name = "checkTUESDAY";
            this.checkTUESDAY.Size = new System.Drawing.Size(58, 17);
            this.checkTUESDAY.TabIndex = 1;
            this.checkTUESDAY.Text = "Martes";
            this.checkTUESDAY.UseVisualStyleBackColor = true;
            // 
            // checkMONDAY
            // 
            this.checkMONDAY.AutoSize = true;
            this.checkMONDAY.Location = new System.Drawing.Point(4, 4);
            this.checkMONDAY.Name = "checkMONDAY";
            this.checkMONDAY.Size = new System.Drawing.Size(55, 17);
            this.checkMONDAY.TabIndex = 0;
            this.checkMONDAY.Text = "Lunes";
            this.checkMONDAY.UseVisualStyleBackColor = true;
            this.checkMONDAY.CheckedChanged += new System.EventHandler(this.checkMONDAY_CheckedChanged);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dataGridView1);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(510, 277);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Eventos Guardados";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.dateEventDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.songDataGridViewTextBoxColumn,
            this.descriptionDataGridViewTextBoxColumn,
            this.repeatDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.eVENTOSBindingSource2;
            this.dataGridView1.Location = new System.Drawing.Point(33, 98);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(444, 150);
            this.dataGridView1.TabIndex = 3;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dateEventDataGridViewTextBoxColumn
            // 
            this.dateEventDataGridViewTextBoxColumn.DataPropertyName = "dateEvent";
            this.dateEventDataGridViewTextBoxColumn.HeaderText = "dateEvent";
            this.dateEventDataGridViewTextBoxColumn.Name = "dateEventDataGridViewTextBoxColumn";
            this.dateEventDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // songDataGridViewTextBoxColumn
            // 
            this.songDataGridViewTextBoxColumn.DataPropertyName = "song";
            this.songDataGridViewTextBoxColumn.HeaderText = "song";
            this.songDataGridViewTextBoxColumn.Name = "songDataGridViewTextBoxColumn";
            this.songDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            this.descriptionDataGridViewTextBoxColumn.DataPropertyName = "description";
            this.descriptionDataGridViewTextBoxColumn.HeaderText = "description";
            this.descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            this.descriptionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // repeatDataGridViewTextBoxColumn
            // 
            this.repeatDataGridViewTextBoxColumn.DataPropertyName = "repeat";
            this.repeatDataGridViewTextBoxColumn.HeaderText = "repeat";
            this.repeatDataGridViewTextBoxColumn.Name = "repeatDataGridViewTextBoxColumn";
            this.repeatDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // eVENTOSBindingSource2
            // 
            this.eVENTOSBindingSource2.DataMember = "EVENTOS";
            this.eVENTOSBindingSource2.DataSource = this.dBagendaDataSet1BindingSource;
            // 
            // dBagendaDataSet1BindingSource
            // 
            this.dBagendaDataSet1BindingSource.DataSource = this.dBagendaDataSet1;
            this.dBagendaDataSet1BindingSource.Position = 0;
            // 
            // dBagendaDataSet1
            // 
            this.dBagendaDataSet1.DataSetName = "DBagendaDataSet";
            this.dBagendaDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(65, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(372, 46);
            this.label4.TabIndex = 2;
            this.label4.Text = "Eventos Guardados";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // eVENTOSBindingSource
            // 
            this.eVENTOSBindingSource.DataMember = "EVENTOS";
            this.eVENTOSBindingSource.DataSource = this.dBagendaDataSet1BindingSource;
            // 
            // eventoBindingSource
            // 
            this.eventoBindingSource.DataMember = "evento";
            this.eventoBindingSource.DataSource = this.agendaDataSetFinal;
            // 
            // agendaDataSetFinal
            // 
            this.agendaDataSetFinal.DataSetName = "agendaDataSetFinal";
            this.agendaDataSetFinal.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // eventoTableAdapter
            // 
            this.eventoTableAdapter.ClearBeforeFill = true;
            // 
            // eVENTOSTableAdapter1
            // 
            this.eVENTOSTableAdapter1.ClearBeforeFill = true;
            // 
            // eVENTOSBindingSource1
            // 
            this.eVENTOSBindingSource1.DataMember = "EVENTOS";
            this.eVENTOSBindingSource1.DataSource = this.dBagendaDataSet1BindingSource;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 338);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Agenda de eventos";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabControl2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eVENTOSBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBagendaDataSet1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBagendaDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eVENTOSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eventoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.agendaDataSetFinal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eVENTOSBindingSource1)).EndInit();
            this.ResumeLayout(false);

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
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RichTextBox tbdescription;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TabControl tabControl2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.CheckBox checkSUNDAY;
        private System.Windows.Forms.CheckBox checkSATURDAY;
        private System.Windows.Forms.CheckBox checkFRIDAY;
        private System.Windows.Forms.CheckBox checkTHURSDAY;
        private System.Windows.Forms.CheckBox checkWEDNESDAY;
        private System.Windows.Forms.CheckBox checkTUESDAY;
        private System.Windows.Forms.CheckBox checkMONDAY;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource eVENTOSBindingSource;
        private System.Windows.Forms.BindingSource dBagendaDataSet1BindingSource;
        private DBagendaDataSet dBagendaDataSet1;
        private System.Windows.Forms.BindingSource eventoBindingSource;
        private agendaDataSetFinal agendaDataSetFinal;
        private agendaDataSetFinalTableAdapters.eventoTableAdapter eventoTableAdapter;
        private DBagendaDataSetTableAdapters.EVENTOSTableAdapter eVENTOSTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateEventDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn songDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn repeatDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource eVENTOSBindingSource2;
        private System.Windows.Forms.BindingSource eVENTOSBindingSource1;
    }
}

