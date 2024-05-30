namespace Personas
{
    partial class Form2
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
            this.label2 = new System.Windows.Forms.Label();
            this.Registro1 = new System.Windows.Forms.DataGridView();
            this.labelNombre = new System.Windows.Forms.Label();
            this.labelPersona = new System.Windows.Forms.Label();
            this.labelApellido = new System.Windows.Forms.Label();
            this.labelAsociasion = new System.Windows.Forms.Label();
            this.labelJuego = new System.Windows.Forms.Label();
            this.labelArma = new System.Windows.Forms.Label();
            this.labelEstado = new System.Windows.Forms.Label();
            this.textBoxNombre = new System.Windows.Forms.TextBox();
            this.textBoxEstado = new System.Windows.Forms.TextBox();
            this.textBoxPersona = new System.Windows.Forms.TextBox();
            this.textBoxApellido = new System.Windows.Forms.TextBox();
            this.textBoxArma = new System.Windows.Forms.TextBox();
            this.textBoxJuego = new System.Windows.Forms.TextBox();
            this.textBoxAsociacion = new System.Windows.Forms.TextBox();
            this.buttonActualizar = new System.Windows.Forms.Button();
            this.buttonLimpiar = new System.Windows.Forms.Button();
            this.buttonEliminar = new System.Windows.Forms.Button();
            this.buttonVerconfidentes = new System.Windows.Forms.Button();
            this.textBoxId = new System.Windows.Forms.TextBox();
            this.labelId = new System.Windows.Forms.Label();
            this.buttonInsertarmodel = new System.Windows.Forms.Button();
            this.buttonSorpresa = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Registro1)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Red;
            this.label2.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(519, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(241, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "LISTA DE CONFIDENTES";
            // 
            // Registro1
            // 
            this.Registro1.BackgroundColor = System.Drawing.Color.Red;
            this.Registro1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Registro1.Location = new System.Drawing.Point(482, 37);
            this.Registro1.Name = "Registro1";
            this.Registro1.Size = new System.Drawing.Size(317, 197);
            this.Registro1.TabIndex = 3;
            this.Registro1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Registro_CellContentClick);
            // 
            // labelNombre
            // 
            this.labelNombre.AutoSize = true;
            this.labelNombre.BackColor = System.Drawing.Color.Black;
            this.labelNombre.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNombre.ForeColor = System.Drawing.Color.White;
            this.labelNombre.Location = new System.Drawing.Point(279, 3);
            this.labelNombre.Name = "labelNombre";
            this.labelNombre.Size = new System.Drawing.Size(72, 19);
            this.labelNombre.TabIndex = 4;
            this.labelNombre.Text = "NOMBRE";
            // 
            // labelPersona
            // 
            this.labelPersona.AutoSize = true;
            this.labelPersona.BackColor = System.Drawing.Color.Black;
            this.labelPersona.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPersona.ForeColor = System.Drawing.Color.White;
            this.labelPersona.Location = new System.Drawing.Point(252, 117);
            this.labelPersona.Name = "labelPersona";
            this.labelPersona.Size = new System.Drawing.Size(76, 19);
            this.labelPersona.TabIndex = 11;
            this.labelPersona.Text = "PERSONA";
            // 
            // labelApellido
            // 
            this.labelApellido.AutoSize = true;
            this.labelApellido.BackColor = System.Drawing.Color.Black;
            this.labelApellido.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelApellido.ForeColor = System.Drawing.Color.White;
            this.labelApellido.Location = new System.Drawing.Point(279, 59);
            this.labelApellido.Name = "labelApellido";
            this.labelApellido.Size = new System.Drawing.Size(81, 19);
            this.labelApellido.TabIndex = 12;
            this.labelApellido.Text = "APELLIDO";
            // 
            // labelAsociasion
            // 
            this.labelAsociasion.AutoSize = true;
            this.labelAsociasion.BackColor = System.Drawing.Color.Black;
            this.labelAsociasion.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAsociasion.ForeColor = System.Drawing.Color.White;
            this.labelAsociasion.Location = new System.Drawing.Point(237, 246);
            this.labelAsociasion.Name = "labelAsociasion";
            this.labelAsociasion.Size = new System.Drawing.Size(96, 19);
            this.labelAsociasion.TabIndex = 13;
            this.labelAsociasion.Text = "ASOCIACION";
            // 
            // labelJuego
            // 
            this.labelJuego.BackColor = System.Drawing.Color.Black;
            this.labelJuego.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelJuego.ForeColor = System.Drawing.Color.White;
            this.labelJuego.Location = new System.Drawing.Point(237, 369);
            this.labelJuego.Name = "labelJuego";
            this.labelJuego.Size = new System.Drawing.Size(67, 19);
            this.labelJuego.TabIndex = 14;
            this.labelJuego.Text = "JUEGO";
            // 
            // labelArma
            // 
            this.labelArma.BackColor = System.Drawing.Color.Black;
            this.labelArma.Cursor = System.Windows.Forms.Cursors.No;
            this.labelArma.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelArma.ForeColor = System.Drawing.Color.White;
            this.labelArma.Location = new System.Drawing.Point(241, 310);
            this.labelArma.Name = "labelArma";
            this.labelArma.Size = new System.Drawing.Size(76, 20);
            this.labelArma.TabIndex = 15;
            this.labelArma.Text = "ARMA";
            this.labelArma.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelEstado
            // 
            this.labelEstado.AutoSize = true;
            this.labelEstado.BackColor = System.Drawing.Color.Black;
            this.labelEstado.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEstado.ForeColor = System.Drawing.Color.White;
            this.labelEstado.Location = new System.Drawing.Point(252, 183);
            this.labelEstado.Name = "labelEstado";
            this.labelEstado.Size = new System.Drawing.Size(65, 19);
            this.labelEstado.TabIndex = 16;
            this.labelEstado.Text = "ESTADO";
            // 
            // textBoxNombre
            // 
            this.textBoxNombre.BackColor = System.Drawing.Color.Black;
            this.textBoxNombre.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNombre.ForeColor = System.Drawing.Color.Red;
            this.textBoxNombre.Location = new System.Drawing.Point(284, 25);
            this.textBoxNombre.Name = "textBoxNombre";
            this.textBoxNombre.Size = new System.Drawing.Size(100, 26);
            this.textBoxNombre.TabIndex = 17;
            // 
            // textBoxEstado
            // 
            this.textBoxEstado.BackColor = System.Drawing.Color.Black;
            this.textBoxEstado.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxEstado.ForeColor = System.Drawing.Color.Red;
            this.textBoxEstado.Location = new System.Drawing.Point(272, 205);
            this.textBoxEstado.Name = "textBoxEstado";
            this.textBoxEstado.Size = new System.Drawing.Size(193, 26);
            this.textBoxEstado.TabIndex = 18;
            // 
            // textBoxPersona
            // 
            this.textBoxPersona.AllowDrop = true;
            this.textBoxPersona.BackColor = System.Drawing.Color.Black;
            this.textBoxPersona.CausesValidation = false;
            this.textBoxPersona.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPersona.ForeColor = System.Drawing.Color.Red;
            this.textBoxPersona.Location = new System.Drawing.Point(283, 139);
            this.textBoxPersona.Name = "textBoxPersona";
            this.textBoxPersona.Size = new System.Drawing.Size(141, 26);
            this.textBoxPersona.TabIndex = 19;
            // 
            // textBoxApellido
            // 
            this.textBoxApellido.BackColor = System.Drawing.Color.Black;
            this.textBoxApellido.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxApellido.ForeColor = System.Drawing.Color.Red;
            this.textBoxApellido.Location = new System.Drawing.Point(303, 81);
            this.textBoxApellido.Name = "textBoxApellido";
            this.textBoxApellido.Size = new System.Drawing.Size(121, 26);
            this.textBoxApellido.TabIndex = 20;
            // 
            // textBoxArma
            // 
            this.textBoxArma.BackColor = System.Drawing.Color.Red;
            this.textBoxArma.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxArma.ForeColor = System.Drawing.Color.Black;
            this.textBoxArma.Location = new System.Drawing.Point(272, 333);
            this.textBoxArma.Name = "textBoxArma";
            this.textBoxArma.Size = new System.Drawing.Size(175, 26);
            this.textBoxArma.TabIndex = 21;
            // 
            // textBoxJuego
            // 
            this.textBoxJuego.BackColor = System.Drawing.Color.Black;
            this.textBoxJuego.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxJuego.ForeColor = System.Drawing.Color.Red;
            this.textBoxJuego.Location = new System.Drawing.Point(251, 391);
            this.textBoxJuego.Name = "textBoxJuego";
            this.textBoxJuego.Size = new System.Drawing.Size(133, 26);
            this.textBoxJuego.TabIndex = 22;
            // 
            // textBoxAsociacion
            // 
            this.textBoxAsociacion.BackColor = System.Drawing.Color.Black;
            this.textBoxAsociacion.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxAsociacion.ForeColor = System.Drawing.Color.Red;
            this.textBoxAsociacion.Location = new System.Drawing.Point(256, 268);
            this.textBoxAsociacion.Name = "textBoxAsociacion";
            this.textBoxAsociacion.Size = new System.Drawing.Size(128, 26);
            this.textBoxAsociacion.TabIndex = 24;
            // 
            // buttonActualizar
            // 
            this.buttonActualizar.BackColor = System.Drawing.Color.Red;
            this.buttonActualizar.Font = new System.Drawing.Font("Cambria", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonActualizar.Location = new System.Drawing.Point(514, 340);
            this.buttonActualizar.Name = "buttonActualizar";
            this.buttonActualizar.Size = new System.Drawing.Size(108, 41);
            this.buttonActualizar.TabIndex = 30;
            this.buttonActualizar.Text = "ACTUALIZAR CONFIDENTE";
            this.buttonActualizar.UseVisualStyleBackColor = false;
            this.buttonActualizar.Click += new System.EventHandler(this.buttonActualizar_Click);
            // 
            // buttonLimpiar
            // 
            this.buttonLimpiar.BackColor = System.Drawing.Color.Red;
            this.buttonLimpiar.Font = new System.Drawing.Font("Cambria", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLimpiar.Location = new System.Drawing.Point(668, 293);
            this.buttonLimpiar.Name = "buttonLimpiar";
            this.buttonLimpiar.Size = new System.Drawing.Size(120, 41);
            this.buttonLimpiar.TabIndex = 31;
            this.buttonLimpiar.Text = "LIMPIAR CASILLAS";
            this.buttonLimpiar.UseVisualStyleBackColor = false;
            this.buttonLimpiar.Click += new System.EventHandler(this.buttonLimpiar_Click);
            // 
            // buttonEliminar
            // 
            this.buttonEliminar.BackColor = System.Drawing.Color.Red;
            this.buttonEliminar.Font = new System.Drawing.Font("Cambria", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEliminar.Location = new System.Drawing.Point(668, 246);
            this.buttonEliminar.Name = "buttonEliminar";
            this.buttonEliminar.Size = new System.Drawing.Size(120, 41);
            this.buttonEliminar.TabIndex = 32;
            this.buttonEliminar.Text = "ELIMINAR CONFIDENTES";
            this.buttonEliminar.UseVisualStyleBackColor = false;
            this.buttonEliminar.Click += new System.EventHandler(this.buttonEliminar_Click);
            // 
            // buttonVerconfidentes
            // 
            this.buttonVerconfidentes.BackColor = System.Drawing.Color.Red;
            this.buttonVerconfidentes.Font = new System.Drawing.Font("Cambria", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonVerconfidentes.Location = new System.Drawing.Point(514, 237);
            this.buttonVerconfidentes.Name = "buttonVerconfidentes";
            this.buttonVerconfidentes.Size = new System.Drawing.Size(108, 42);
            this.buttonVerconfidentes.TabIndex = 33;
            this.buttonVerconfidentes.Text = "VER LSITA DE CONFIDENTES";
            this.buttonVerconfidentes.UseVisualStyleBackColor = false;
            this.buttonVerconfidentes.Click += new System.EventHandler(this.buttonVerconfidentes_Click);
            // 
            // textBoxId
            // 
            this.textBoxId.BackColor = System.Drawing.Color.Black;
            this.textBoxId.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxId.ForeColor = System.Drawing.Color.Red;
            this.textBoxId.Location = new System.Drawing.Point(4, 176);
            this.textBoxId.Name = "textBoxId";
            this.textBoxId.Size = new System.Drawing.Size(128, 26);
            this.textBoxId.TabIndex = 36;
            // 
            // labelId
            // 
            this.labelId.BackColor = System.Drawing.Color.Black;
            this.labelId.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelId.ForeColor = System.Drawing.Color.White;
            this.labelId.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.labelId.Location = new System.Drawing.Point(32, 133);
            this.labelId.Name = "labelId";
            this.labelId.Size = new System.Drawing.Size(76, 36);
            this.labelId.TabIndex = 37;
            this.labelId.Text = "ID";
            this.labelId.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonInsertarmodel
            // 
            this.buttonInsertarmodel.BackColor = System.Drawing.Color.Red;
            this.buttonInsertarmodel.Font = new System.Drawing.Font("Cambria", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonInsertarmodel.Location = new System.Drawing.Point(514, 293);
            this.buttonInsertarmodel.Name = "buttonInsertarmodel";
            this.buttonInsertarmodel.Size = new System.Drawing.Size(108, 41);
            this.buttonInsertarmodel.TabIndex = 38;
            this.buttonInsertarmodel.Text = "INGRESAR CONFIDENTE";
            this.buttonInsertarmodel.UseVisualStyleBackColor = false;
            this.buttonInsertarmodel.Click += new System.EventHandler(this.buttonInsertarmodel_Click);
            // 
            // buttonSorpresa
            // 
            this.buttonSorpresa.BackColor = System.Drawing.Color.Red;
            this.buttonSorpresa.Font = new System.Drawing.Font("Cambria", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSorpresa.Location = new System.Drawing.Point(589, 391);
            this.buttonSorpresa.Name = "buttonSorpresa";
            this.buttonSorpresa.Size = new System.Drawing.Size(120, 41);
            this.buttonSorpresa.TabIndex = 39;
            this.buttonSorpresa.Text = "TERMINADO";
            this.buttonSorpresa.UseVisualStyleBackColor = false;
            this.buttonSorpresa.Click += new System.EventHandler(this.buttonSorpresa_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Red;
            this.button1.Font = new System.Drawing.Font("Cambria", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(668, 344);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(120, 41);
            this.button1.TabIndex = 40;
            this.button1.Text = "Buscar id";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.BackgroundImage = global::Personas.Properties.Resources._60ab58b00541d;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttonSorpresa);
            this.Controls.Add(this.buttonInsertarmodel);
            this.Controls.Add(this.labelId);
            this.Controls.Add(this.textBoxId);
            this.Controls.Add(this.buttonVerconfidentes);
            this.Controls.Add(this.buttonEliminar);
            this.Controls.Add(this.buttonLimpiar);
            this.Controls.Add(this.buttonActualizar);
            this.Controls.Add(this.textBoxAsociacion);
            this.Controls.Add(this.textBoxJuego);
            this.Controls.Add(this.textBoxArma);
            this.Controls.Add(this.textBoxApellido);
            this.Controls.Add(this.textBoxPersona);
            this.Controls.Add(this.textBoxEstado);
            this.Controls.Add(this.textBoxNombre);
            this.Controls.Add(this.labelEstado);
            this.Controls.Add(this.labelArma);
            this.Controls.Add(this.labelJuego);
            this.Controls.Add(this.labelAsociasion);
            this.Controls.Add(this.labelApellido);
            this.Controls.Add(this.labelPersona);
            this.Controls.Add(this.labelNombre);
            this.Controls.Add(this.Registro1);
            this.Controls.Add(this.label2);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "Form2";
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.Registro1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView Registro1;
        private System.Windows.Forms.Label labelNombre;
        private System.Windows.Forms.Label labelPersona;
        private System.Windows.Forms.Label labelApellido;
        private System.Windows.Forms.Label labelAsociasion;
        private System.Windows.Forms.Label labelJuego;
        private System.Windows.Forms.Label labelArma;
        private System.Windows.Forms.Label labelEstado;
        private System.Windows.Forms.TextBox textBoxNombre;
        private System.Windows.Forms.TextBox textBoxEstado;
        private System.Windows.Forms.TextBox textBoxPersona;
        private System.Windows.Forms.TextBox textBoxApellido;
        private System.Windows.Forms.TextBox textBoxArma;
        private System.Windows.Forms.TextBox textBoxJuego;
        private System.Windows.Forms.TextBox textBoxAsociacion;
        private System.Windows.Forms.Button buttonActualizar;
        private System.Windows.Forms.Button buttonLimpiar;
        private System.Windows.Forms.Button buttonEliminar;
        private System.Windows.Forms.Button buttonVerconfidentes;
        private System.Windows.Forms.TextBox textBoxId;
        private System.Windows.Forms.Label labelId;
        private System.Windows.Forms.Button buttonInsertarmodel;
        private System.Windows.Forms.Button buttonSorpresa;
        private System.Windows.Forms.Button button1;
    }
}