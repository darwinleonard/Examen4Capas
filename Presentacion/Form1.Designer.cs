namespace Presentacion
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dgv_Regions = new DataGridView();
            RegionId = new DataGridViewTextBoxColumn();
            RegionName = new DataGridViewTextBoxColumn();
            btn_Crear = new Button();
            btn_Editar = new Button();
            btn_Eliminar = new Button();
            txt_Id = new TextBox();
            txt_Nombre = new TextBox();
            label1 = new Label();
            label2 = new Label();
            btn_Buscar = new Button();
            btn_Actualizar = new Button();
            ((System.ComponentModel.ISupportInitialize)dgv_Regions).BeginInit();
            SuspendLayout();
            // 
            // dgv_Regions
            // 
            dgv_Regions.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_Regions.Columns.AddRange(new DataGridViewColumn[] { RegionId, RegionName });
            dgv_Regions.Location = new Point(140, 233);
            dgv_Regions.Name = "dgv_Regions";
            dgv_Regions.Size = new Size(478, 178);
            dgv_Regions.TabIndex = 0;
            // 
            // RegionId
            // 
            RegionId.DataPropertyName = "RegionId";
            RegionId.HeaderText = "ID";
            RegionId.Name = "RegionId";
            // 
            // RegionName
            // 
            RegionName.DataPropertyName = "RegionName";
            RegionName.HeaderText = "Nombre";
            RegionName.Name = "RegionName";
            // 
            // btn_Crear
            // 
            btn_Crear.Location = new Point(478, 80);
            btn_Crear.Name = "btn_Crear";
            btn_Crear.Size = new Size(140, 49);
            btn_Crear.TabIndex = 1;
            btn_Crear.Text = "Crear";
            btn_Crear.UseVisualStyleBackColor = true;
            btn_Crear.Click += btn_Crear_Click;
            // 
            // btn_Editar
            // 
            btn_Editar.Location = new Point(478, 129);
            btn_Editar.Name = "btn_Editar";
            btn_Editar.Size = new Size(140, 49);
            btn_Editar.TabIndex = 2;
            btn_Editar.Text = "Editar";
            btn_Editar.UseVisualStyleBackColor = true;
            btn_Editar.Click += btn_Editar_Click;
            // 
            // btn_Eliminar
            // 
            btn_Eliminar.Location = new Point(478, 178);
            btn_Eliminar.Name = "btn_Eliminar";
            btn_Eliminar.Size = new Size(140, 49);
            btn_Eliminar.TabIndex = 3;
            btn_Eliminar.Text = "Eliminar";
            btn_Eliminar.UseVisualStyleBackColor = true;
            btn_Eliminar.Click += btn_Eliminar_Click;
            // 
            // txt_Id
            // 
            txt_Id.Location = new Point(281, 129);
            txt_Id.Name = "txt_Id";
            txt_Id.Size = new Size(100, 23);
            txt_Id.TabIndex = 4;
            // 
            // txt_Nombre
            // 
            txt_Nombre.Location = new Point(281, 81);
            txt_Nombre.Name = "txt_Nombre";
            txt_Nombre.Size = new Size(100, 23);
            txt_Nombre.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(140, 84);
            label1.Name = "label1";
            label1.Size = new Size(96, 15);
            label1.TabIndex = 6;
            label1.Text = "Nombre Regions";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(140, 132);
            label2.Name = "label2";
            label2.Size = new Size(63, 15);
            label2.TabIndex = 7;
            label2.Text = "ID Regions";
            // 
            // btn_Buscar
            // 
            btn_Buscar.Location = new Point(478, 35);
            btn_Buscar.Name = "btn_Buscar";
            btn_Buscar.Size = new Size(140, 49);
            btn_Buscar.TabIndex = 8;
            btn_Buscar.Text = "Buscar";
            btn_Buscar.UseVisualStyleBackColor = true;
            // 
            // btn_Actualizar
            // 
            btn_Actualizar.Location = new Point(624, 288);
            btn_Actualizar.Name = "btn_Actualizar";
            btn_Actualizar.Size = new Size(114, 67);
            btn_Actualizar.TabIndex = 9;
            btn_Actualizar.Text = "Listar Todo";
            btn_Actualizar.UseVisualStyleBackColor = true;
            btn_Actualizar.Click += btn_Actualizar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btn_Actualizar);
            Controls.Add(btn_Buscar);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txt_Nombre);
            Controls.Add(txt_Id);
            Controls.Add(btn_Eliminar);
            Controls.Add(btn_Editar);
            Controls.Add(btn_Crear);
            Controls.Add(dgv_Regions);
            Name = "Form1";
            Text = "Formulario Regions";
            ((System.ComponentModel.ISupportInitialize)dgv_Regions).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgv_Regions;
        private Button btn_Crear;
        private Button btn_Editar;
        private Button btn_Eliminar;
        private TextBox txt_Id;
        private TextBox txt_Nombre;
        private Label label1;
        private Label label2;
        private DataGridViewTextBoxColumn RegionId;
        private DataGridViewTextBoxColumn RegionName;
        private Button btn_Buscar;
        private Button btn_Actualizar;
    }
}
