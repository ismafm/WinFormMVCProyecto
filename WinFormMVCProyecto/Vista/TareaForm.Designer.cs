namespace WinFormMVCProyecto.Vista
{
    partial class TareaForm
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
            tareaNombre = new TextBox();
            guardarTarea = new Button();
            tareaCompletada = new CheckBox();
            TareaFechaCreacion = new DateTimePicker();
            label1 = new Label();
            listaTareas = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)listaTareas).BeginInit();
            SuspendLayout();
            // 
            // tareaNombre
            // 
            tareaNombre.Location = new Point(95, 100);
            tareaNombre.Name = "tareaNombre";
            tareaNombre.Size = new Size(125, 27);
            tareaNombre.TabIndex = 0;
            // 
            // guardarTarea
            // 
            guardarTarea.Location = new Point(399, 194);
            guardarTarea.Name = "guardarTarea";
            guardarTarea.Size = new Size(94, 29);
            guardarTarea.TabIndex = 1;
            guardarTarea.Text = "Guardar";
            guardarTarea.UseVisualStyleBackColor = true;
            // 
            // tareaCompletada
            // 
            tareaCompletada.AutoSize = true;
            tareaCompletada.Location = new Point(97, 151);
            tareaCompletada.Name = "tareaCompletada";
            tareaCompletada.Size = new Size(156, 24);
            tareaCompletada.TabIndex = 2;
            tareaCompletada.Text = "¿Está completada?";
            tareaCompletada.UseVisualStyleBackColor = true;
            // 
            // TareaFechaCreacion
            // 
            TareaFechaCreacion.Location = new Point(89, 196);
            TareaFechaCreacion.Name = "TareaFechaCreacion";
            TareaFechaCreacion.Size = new Size(295, 27);
            TareaFechaCreacion.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(99, 67);
            label1.Name = "label1";
            label1.Size = new Size(102, 20);
            label1.TabIndex = 4;
            label1.Text = "Nombre tarea";
            // 
            // listaTareas
            // 
            listaTareas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            listaTareas.Location = new Point(23, 250);
            listaTareas.Name = "listaTareas";
            listaTareas.RowHeadersWidth = 51;
            listaTareas.Size = new Size(747, 188);
            listaTareas.TabIndex = 5;
            listaTareas.CellContentClick += dataGridView1_CellContentClick;
            // 
            // TareaForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(listaTareas);
            Controls.Add(label1);
            Controls.Add(TareaFechaCreacion);
            Controls.Add(tareaCompletada);
            Controls.Add(guardarTarea);
            Controls.Add(tareaNombre);
            Name = "TareaForm";
            Text = "TareaForm";
            Load += TareaForm_Load;
            ((System.ComponentModel.ISupportInitialize)listaTareas).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tareaNombre;
        private Button guardarTarea;
        private CheckBox tareaCompletada;
        private DateTimePicker TareaFechaCreacion;
        private Label label1;
        private DataGridView listaTareas;
    }
}