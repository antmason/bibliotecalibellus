namespace MyLlibellus
{
    partial class frm_llibreriaPersonal
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario, false.</param>
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
            this.components = new System.ComponentModel.Container();
            this.gb_mostraLlibres = new System.Windows.Forms.GroupBox();
            this.dgw_taulaLlibres = new System.Windows.Forms.DataGridView();
            this.bt_Modificar = new System.Windows.Forms.Button();
            this.bt_afegir = new System.Windows.Forms.Button();
            this.bt_eliminar = new System.Windows.Forms.Button();
            this.bibliotecaDataSet = new MyLlibellus.BibliotecaDataSet();
            this.llibreBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.llibreTableAdapter1 = new MyLlibellus.BibliotecaDataSetTableAdapters.LlibreTableAdapter();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gb_mostraLlibres.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgw_taulaLlibres)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bibliotecaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.llibreBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // gb_mostraLlibres
            // 
            this.gb_mostraLlibres.Controls.Add(this.dgw_taulaLlibres);
            this.gb_mostraLlibres.Location = new System.Drawing.Point(12, 12);
            this.gb_mostraLlibres.Name = "gb_mostraLlibres";
            this.gb_mostraLlibres.Size = new System.Drawing.Size(525, 283);
            this.gb_mostraLlibres.TabIndex = 0;
            this.gb_mostraLlibres.TabStop = false;
            this.gb_mostraLlibres.Text = "Mostra llibres";
            // 
            // dgw_taulaLlibres
            // 
            this.dgw_taulaLlibres.AutoGenerateColumns = false;
            this.dgw_taulaLlibres.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgw_taulaLlibres.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7});
            this.dgw_taulaLlibres.DataSource = this.llibreBindingSource;
            this.dgw_taulaLlibres.Location = new System.Drawing.Point(15, 19);
            this.dgw_taulaLlibres.Name = "dgw_taulaLlibres";
            this.dgw_taulaLlibres.Size = new System.Drawing.Size(495, 202);
            this.dgw_taulaLlibres.TabIndex = 0;
            // 
            // bt_Modificar
            // 
            this.bt_Modificar.Location = new System.Drawing.Point(81, 256);
            this.bt_Modificar.Name = "bt_Modificar";
            this.bt_Modificar.Size = new System.Drawing.Size(75, 23);
            this.bt_Modificar.TabIndex = 1;
            this.bt_Modificar.Text = "Modificar";
            this.bt_Modificar.UseVisualStyleBackColor = true;
            // 
            // bt_afegir
            // 
            this.bt_afegir.Location = new System.Drawing.Point(222, 256);
            this.bt_afegir.Name = "bt_afegir";
            this.bt_afegir.Size = new System.Drawing.Size(99, 23);
            this.bt_afegir.TabIndex = 2;
            this.bt_afegir.Text = "Afegir";
            this.bt_afegir.UseVisualStyleBackColor = true;
            // 
            // bt_eliminar
            // 
            this.bt_eliminar.Location = new System.Drawing.Point(388, 256);
            this.bt_eliminar.Name = "bt_eliminar";
            this.bt_eliminar.Size = new System.Drawing.Size(75, 23);
            this.bt_eliminar.TabIndex = 3;
            this.bt_eliminar.Text = "Eliminar";
            this.bt_eliminar.UseVisualStyleBackColor = true;
            // 
            // bibliotecaDataSet
            // 
            this.bibliotecaDataSet.DataSetName = "BibliotecaDataSet";
            this.bibliotecaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // llibreBindingSource
            // 
            this.llibreBindingSource.DataMember = "Llibre";
            this.llibreBindingSource.DataSource = this.bibliotecaDataSet;
            // 
            // llibreTableAdapter1
            // 
            this.llibreTableAdapter1.ClearBeforeFill = true;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "isbn";
            this.dataGridViewTextBoxColumn1.HeaderText = "isbn";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "titol_curt";
            this.dataGridViewTextBoxColumn2.HeaderText = "titol_curt";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "titol_llarg";
            this.dataGridViewTextBoxColumn3.HeaderText = "titol_llarg";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "id_publicador";
            this.dataGridViewTextBoxColumn4.HeaderText = "id_publicador";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "resum";
            this.dataGridViewTextBoxColumn5.HeaderText = "resum";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "premis";
            this.dataGridViewTextBoxColumn6.HeaderText = "premis";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "pvp";
            this.dataGridViewTextBoxColumn7.HeaderText = "pvp";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // frm_llibreriaPersonal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(549, 307);
            this.Controls.Add(this.bt_eliminar);
            this.Controls.Add(this.bt_afegir);
            this.Controls.Add(this.bt_Modificar);
            this.Controls.Add(this.gb_mostraLlibres);
            this.Name = "frm_llibreriaPersonal";
            this.Text = "Llibreria personal";
            this.Load += new System.EventHandler(this.frm_llibreriaPersonal_Load);
            this.gb_mostraLlibres.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgw_taulaLlibres)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bibliotecaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.llibreBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gb_mostraLlibres;
        private System.Windows.Forms.DataGridView dgw_taulaLlibres;
        private System.Windows.Forms.Button bt_Modificar;
        private System.Windows.Forms.Button bt_afegir;
        private System.Windows.Forms.Button bt_eliminar;
        private BibliotecaDataSet1 bibliotecaDataSet1;
        private MyLlibellus.BibliotecaDataSet1TableAdapters.LlibreTableAdapter llibreTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn isbnDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn titolcurtDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn titolllargDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idpublicadorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn resumDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn premisDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pvpDataGridViewTextBoxColumn;
        private BibliotecaDataSet bibliotecaDataSet;
        private System.Windows.Forms.BindingSource llibreBindingSource;
        private MyLlibellus.BibliotecaDataSetTableAdapters.LlibreTableAdapter llibreTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
    }
}

