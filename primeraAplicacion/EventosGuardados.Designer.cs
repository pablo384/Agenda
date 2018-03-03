namespace primeraAplicacion
{
    partial class EventosGuardados
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.eventoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.agendaDataSetFinal = new primeraAplicacion.agendaDataSetFinal();
            this.eventoTableAdapter = new primeraAplicacion.agendaDataSetFinalTableAdapters.eventoTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.dBagendaDataSet1 = new primeraAplicacion.DBagendaDataSet();
            this.dBagendaDataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.eVENTOSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.eVENTOSTableAdapter1 = new primeraAplicacion.DBagendaDataSetTableAdapters.EVENTOSTableAdapter();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateEventDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.songDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.repeatDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eventoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.agendaDataSetFinal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBagendaDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBagendaDataSet1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eVENTOSBindingSource)).BeginInit();
            this.SuspendLayout();
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
            this.dataGridView1.DataSource = this.eVENTOSBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(81, 89);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(444, 150);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(120, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(372, 46);
            this.label1.TabIndex = 1;
            this.label1.Text = "Eventos Guardados";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // dBagendaDataSet1
            // 
            this.dBagendaDataSet1.DataSetName = "DBagendaDataSet";
            this.dBagendaDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dBagendaDataSet1BindingSource
            // 
            this.dBagendaDataSet1BindingSource.DataSource = this.dBagendaDataSet1;
            this.dBagendaDataSet1BindingSource.Position = 0;
            // 
            // eVENTOSBindingSource
            // 
            this.eVENTOSBindingSource.DataMember = "EVENTOS";
            this.eVENTOSBindingSource.DataSource = this.dBagendaDataSet1BindingSource;
            // 
            // eVENTOSTableAdapter1
            // 
            this.eVENTOSTableAdapter1.ClearBeforeFill = true;
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
            // EventosGuardados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(631, 261);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "EventosGuardados";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EventosGuardados";
            this.Load += new System.EventHandler(this.EventosGuardados_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eventoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.agendaDataSetFinal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBagendaDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBagendaDataSet1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eVENTOSBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private agendaDataSetFinal agendaDataSetFinal;
      //  private DBagendaDataSet DBagendaDataSet;
        private System.Windows.Forms.BindingSource eventoBindingSource;
        private agendaDataSetFinalTableAdapters.eventoTableAdapter eventoTableAdapter;
       // private DBagendaDataSetTableAdapters.EVENTOSTableAdapter EVENTOSTableAdapter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource dBagendaDataSet1BindingSource;
        private DBagendaDataSet dBagendaDataSet1;
        private System.Windows.Forms.BindingSource eVENTOSBindingSource;
        private DBagendaDataSetTableAdapters.EVENTOSTableAdapter eVENTOSTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateEventDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn songDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn repeatDataGridViewTextBoxColumn;
    }
}