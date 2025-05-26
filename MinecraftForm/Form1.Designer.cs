namespace MinecraftForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            buttonBuscar = new Button();
            label1 = new Label();
            textBoxId = new TextBox();
            label2 = new Label();
            textBoxNombre = new TextBox();
            textBoxNivel = new TextBox();
            label3 = new Label();
            label4 = new Label();
            textBoxFecha = new TextBox();
            buttonCrear = new Button();
            buttonEliminar = new Button();
            buttonActualizar = new Button();
            dataGridView1 = new DataGridView();
            buttonBuscarinventario = new Button();
            comboBoxRareza = new ComboBox();
            comboBoxTipo = new ComboBox();
            button1 = new Button();
            pictureBoxImagen = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxImagen).BeginInit();
            SuspendLayout();
            // 
            // buttonBuscar
            // 
            buttonBuscar.BackColor = SystemColors.ControlDark;
            buttonBuscar.Location = new Point(181, 3);
            buttonBuscar.Name = "buttonBuscar";
            buttonBuscar.Size = new Size(75, 23);
            buttonBuscar.TabIndex = 0;
            buttonBuscar.Text = "Buscar";
            buttonBuscar.UseVisualStyleBackColor = false;
            buttonBuscar.Click += buttonBuscar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ButtonShadow;
            label1.Location = new Point(12, 67);
            label1.Name = "label1";
            label1.Size = new Size(21, 15);
            label1.TabIndex = 1;
            label1.Text = "ID:";
            // 
            // textBoxId
            // 
            textBoxId.BackColor = SystemColors.InactiveCaption;
            textBoxId.Location = new Point(72, 67);
            textBoxId.Name = "textBoxId";
            textBoxId.Size = new Size(100, 23);
            textBoxId.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.ControlDark;
            label2.Location = new Point(12, 116);
            label2.Name = "label2";
            label2.Size = new Size(54, 15);
            label2.TabIndex = 3;
            label2.Text = "Nombre:";
            // 
            // textBoxNombre
            // 
            textBoxNombre.BackColor = SystemColors.InactiveCaption;
            textBoxNombre.Location = new Point(72, 108);
            textBoxNombre.Name = "textBoxNombre";
            textBoxNombre.Size = new Size(100, 23);
            textBoxNombre.TabIndex = 4;
            // 
            // textBoxNivel
            // 
            textBoxNivel.BackColor = SystemColors.InactiveCaption;
            textBoxNivel.Location = new Point(72, 152);
            textBoxNivel.Name = "textBoxNivel";
            textBoxNivel.Size = new Size(100, 23);
            textBoxNivel.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = SystemColors.ControlDark;
            label3.Location = new Point(12, 160);
            label3.Name = "label3";
            label3.Size = new Size(37, 15);
            label3.TabIndex = 6;
            label3.Text = "Nivel:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = SystemColors.ControlDark;
            label4.Location = new Point(12, 201);
            label4.Name = "label4";
            label4.Size = new Size(105, 15);
            label4.TabIndex = 7;
            label4.Text = "Fecha de creacion:";
            // 
            // textBoxFecha
            // 
            textBoxFecha.BackColor = SystemColors.InactiveCaption;
            textBoxFecha.Location = new Point(139, 198);
            textBoxFecha.Name = "textBoxFecha";
            textBoxFecha.Size = new Size(133, 23);
            textBoxFecha.TabIndex = 8;
            // 
            // buttonCrear
            // 
            buttonCrear.BackColor = SystemColors.ControlDark;
            buttonCrear.Location = new Point(262, 3);
            buttonCrear.Name = "buttonCrear";
            buttonCrear.Size = new Size(89, 23);
            buttonCrear.TabIndex = 9;
            buttonCrear.Text = "Crear Jugador";
            buttonCrear.UseVisualStyleBackColor = false;
            buttonCrear.Click += buttonCrear_Click;
            // 
            // buttonEliminar
            // 
            buttonEliminar.BackColor = SystemColors.ControlDark;
            buttonEliminar.Location = new Point(361, 3);
            buttonEliminar.Name = "buttonEliminar";
            buttonEliminar.Size = new Size(113, 23);
            buttonEliminar.TabIndex = 10;
            buttonEliminar.Text = "Eliminar Jugador";
            buttonEliminar.UseVisualStyleBackColor = false;
            buttonEliminar.Click += buttonEliminar_Click;
            // 
            // buttonActualizar
            // 
            buttonActualizar.BackColor = SystemColors.ControlDark;
            buttonActualizar.Location = new Point(490, 3);
            buttonActualizar.Name = "buttonActualizar";
            buttonActualizar.Size = new Size(125, 23);
            buttonActualizar.TabIndex = 11;
            buttonActualizar.Text = "Actualizar Jugador";
            buttonActualizar.UseVisualStyleBackColor = false;
            buttonActualizar.Click += buttonActualizar_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(423, 165);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(337, 205);
            dataGridView1.TabIndex = 12;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // buttonBuscarinventario
            // 
            buttonBuscarinventario.Location = new Point(516, 376);
            buttonBuscarinventario.Name = "buttonBuscarinventario";
            buttonBuscarinventario.Size = new Size(157, 23);
            buttonBuscarinventario.TabIndex = 13;
            buttonBuscarinventario.Text = "Buscar Inventario por ID";
            buttonBuscarinventario.UseVisualStyleBackColor = true;
            buttonBuscarinventario.Click += buttonBuscarinventario_Click;
            // 
            // comboBoxRareza
            // 
            comboBoxRareza.BackColor = SystemColors.InactiveCaption;
            comboBoxRareza.FormattingEnabled = true;
            comboBoxRareza.Location = new Point(622, 136);
            comboBoxRareza.Name = "comboBoxRareza";
            comboBoxRareza.Size = new Size(121, 23);
            comboBoxRareza.TabIndex = 15;
            // 
            // comboBoxTipo
            // 
            comboBoxTipo.BackColor = SystemColors.InactiveCaption;
            comboBoxTipo.FormattingEnabled = true;
            comboBoxTipo.Location = new Point(466, 136);
            comboBoxTipo.Name = "comboBoxTipo";
            comboBoxTipo.Size = new Size(121, 23);
            comboBoxTipo.TabIndex = 16;
            comboBoxTipo.SelectedIndexChanged += comboBoxTipo_SelectedIndexChanged;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.AppWorkspace;
            button1.Location = new Point(490, 107);
            button1.Name = "button1";
            button1.Size = new Size(215, 23);
            button1.TabIndex = 20;
            button1.Text = "Seleccione la opcion que deseas";
            button1.UseVisualStyleBackColor = false;
            // 
            // pictureBoxImagen
            // 
            pictureBoxImagen.BackColor = Color.Transparent;
            pictureBoxImagen.Location = new Point(310, 265);
            pictureBoxImagen.Name = "pictureBoxImagen";
            pictureBoxImagen.Size = new Size(107, 94);
            pictureBoxImagen.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxImagen.TabIndex = 21;
            pictureBoxImagen.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Info;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(800, 450);
            Controls.Add(pictureBoxImagen);
            Controls.Add(button1);
            Controls.Add(comboBoxTipo);
            Controls.Add(comboBoxRareza);
            Controls.Add(buttonBuscarinventario);
            Controls.Add(dataGridView1);
            Controls.Add(buttonActualizar);
            Controls.Add(buttonEliminar);
            Controls.Add(buttonCrear);
            Controls.Add(textBoxFecha);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(textBoxNivel);
            Controls.Add(textBoxNombre);
            Controls.Add(label2);
            Controls.Add(textBoxId);
            Controls.Add(label1);
            Controls.Add(buttonBuscar);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxImagen).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label label1;
        private TextBox textBoxId;
        private Label label2;
        private TextBox textBoxNombre;
        private TextBox textBoxNivel;
        private Label label3;
        private Label label4;
        private TextBox textBoxFecha;
        private Button button2;
        private Button buttonBuscar;
        private Button buttonCrear;
        private Button buttonEliminar;
        private Button buttonActualizar;
        private DataGridView dataGridView1;
        private Button buttonBuscarinventario;
        private ComboBox comboBoxRareza;
        private ComboBox comboBoxTipo;
        private PictureBox pictureBoxImagen;
    }
}
