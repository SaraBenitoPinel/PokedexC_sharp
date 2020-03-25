namespace PokedexC_sharp
{
    partial class VentanaPrincipal
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
            this.fondo = new System.Windows.Forms.PictureBox();
            this.izquierda = new System.Windows.Forms.Button();
            this.derecha = new System.Windows.Forms.Button();
            this.nombrePokemon = new System.Windows.Forms.Label();
            this.imagenpokemon = new System.Windows.Forms.PictureBox();
            this.nombre = new System.Windows.Forms.Label();
            this.altura = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.habilidad = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.especie = new System.Windows.Forms.Label();
            this.habitat = new System.Windows.Forms.Label();
            this.peso = new System.Windows.Forms.Label();
            this.tipo1 = new System.Windows.Forms.Label();
            this.tipo2 = new System.Windows.Forms.Label();
            this.pre = new System.Windows.Forms.Label();
            this.pos = new System.Windows.Forms.Label();
            this.mov1 = new System.Windows.Forms.Label();
            this.mov2 = new System.Windows.Forms.Label();
            this.mov3 = new System.Windows.Forms.Label();
            this.mov4 = new System.Windows.Forms.Label();
            this.descripcion = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.entrenador = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.fondo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imagenpokemon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // fondo
            // 
            this.fondo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fondo.Image = global::PokedexC_sharp.Properties.Resources.fondo;
            this.fondo.Location = new System.Drawing.Point(0, 0);
            this.fondo.Name = "fondo";
            this.fondo.Size = new System.Drawing.Size(618, 430);
            this.fondo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.fondo.TabIndex = 0;
            this.fondo.TabStop = false;
            // 
            // izquierda
            // 
            this.izquierda.BackColor = System.Drawing.Color.Yellow;
            this.izquierda.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.izquierda.ForeColor = System.Drawing.Color.Red;
            this.izquierda.Location = new System.Drawing.Point(102, 362);
            this.izquierda.Name = "izquierda";
            this.izquierda.Size = new System.Drawing.Size(34, 33);
            this.izquierda.TabIndex = 1;
            this.izquierda.Text = "<";
            this.izquierda.UseVisualStyleBackColor = false;
            this.izquierda.Click += new System.EventHandler(this.izquierda_Click);
            // 
            // derecha
            // 
            this.derecha.BackColor = System.Drawing.Color.Yellow;
            this.derecha.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.derecha.ForeColor = System.Drawing.Color.Red;
            this.derecha.Location = new System.Drawing.Point(142, 362);
            this.derecha.Name = "derecha";
            this.derecha.Size = new System.Drawing.Size(34, 33);
            this.derecha.TabIndex = 2;
            this.derecha.Text = ">";
            this.derecha.UseVisualStyleBackColor = false;
            this.derecha.Click += new System.EventHandler(this.derecha_Click);
            // 
            // nombrePokemon
            // 
            this.nombrePokemon.BackColor = System.Drawing.Color.Red;
            this.nombrePokemon.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nombrePokemon.ForeColor = System.Drawing.SystemColors.Control;
            this.nombrePokemon.Location = new System.Drawing.Point(355, 133);
            this.nombrePokemon.Name = "nombrePokemon";
            this.nombrePokemon.Size = new System.Drawing.Size(97, 26);
            this.nombrePokemon.TabIndex = 3;
            this.nombrePokemon.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // imagenpokemon
            // 
            this.imagenpokemon.Location = new System.Drawing.Point(36, 113);
            this.imagenpokemon.Name = "imagenpokemon";
            this.imagenpokemon.Size = new System.Drawing.Size(240, 185);
            this.imagenpokemon.TabIndex = 4;
            this.imagenpokemon.TabStop = false;
            // 
            // nombre
            // 
            this.nombre.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.nombre.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nombre.ForeColor = System.Drawing.Color.Black;
            this.nombre.Location = new System.Drawing.Point(355, 111);
            this.nombre.Name = "nombre";
            this.nombre.Size = new System.Drawing.Size(72, 22);
            this.nombre.TabIndex = 5;
            this.nombre.Text = "Nombre";
            this.nombre.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // altura
            // 
            this.altura.BackColor = System.Drawing.Color.Red;
            this.altura.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.altura.ForeColor = System.Drawing.SystemColors.Control;
            this.altura.Location = new System.Drawing.Point(458, 133);
            this.altura.Name = "altura";
            this.altura.Size = new System.Drawing.Size(38, 26);
            this.altura.TabIndex = 6;
            this.altura.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(442, 111);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 22);
            this.label1.TabIndex = 7;
            this.label1.Tag = "";
            this.label1.Text = "Altura";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // habilidad
            // 
            this.habilidad.BackColor = System.Drawing.Color.Red;
            this.habilidad.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.habilidad.ForeColor = System.Drawing.SystemColors.Control;
            this.habilidad.Location = new System.Drawing.Point(502, 133);
            this.habilidad.Name = "habilidad";
            this.habilidad.Size = new System.Drawing.Size(84, 26);
            this.habilidad.TabIndex = 8;
            this.habilidad.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(502, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 22);
            this.label3.TabIndex = 9;
            this.label3.Text = "Habilidad";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(355, 159);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 25);
            this.label4.TabIndex = 10;
            this.label4.Text = "Especie";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(458, 159);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 25);
            this.label5.TabIndex = 11;
            this.label5.Text = "Habitat";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label6.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(527, 159);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 25);
            this.label6.TabIndex = 12;
            this.label6.Text = "Peso";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label7.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(398, 210);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 22);
            this.label7.TabIndex = 13;
            this.label7.Text = "Tipo";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label8.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(487, 210);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(103, 22);
            this.label8.TabIndex = 14;
            this.label8.Text = "Pre y Pos /Evl";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label9.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(415, 258);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(106, 23);
            this.label9.TabIndex = 15;
            this.label9.Text = "Movimientos";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label10
            // 
            this.label10.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label10.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(355, 342);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(113, 20);
            this.label10.TabIndex = 16;
            this.label10.Text = "Descripcion";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // especie
            // 
            this.especie.BackColor = System.Drawing.Color.Red;
            this.especie.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.especie.ForeColor = System.Drawing.SystemColors.Control;
            this.especie.Location = new System.Drawing.Point(355, 184);
            this.especie.Name = "especie";
            this.especie.Size = new System.Drawing.Size(97, 26);
            this.especie.TabIndex = 17;
            this.especie.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // habitat
            // 
            this.habitat.BackColor = System.Drawing.Color.Red;
            this.habitat.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.habitat.ForeColor = System.Drawing.SystemColors.Control;
            this.habitat.Location = new System.Drawing.Point(458, 184);
            this.habitat.Name = "habitat";
            this.habitat.Size = new System.Drawing.Size(81, 26);
            this.habitat.TabIndex = 18;
            this.habitat.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // peso
            // 
            this.peso.BackColor = System.Drawing.Color.Red;
            this.peso.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.peso.ForeColor = System.Drawing.SystemColors.Control;
            this.peso.Location = new System.Drawing.Point(545, 184);
            this.peso.Name = "peso";
            this.peso.Size = new System.Drawing.Size(41, 26);
            this.peso.TabIndex = 19;
            this.peso.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tipo1
            // 
            this.tipo1.BackColor = System.Drawing.Color.Red;
            this.tipo1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tipo1.ForeColor = System.Drawing.SystemColors.Control;
            this.tipo1.Location = new System.Drawing.Point(355, 232);
            this.tipo1.Name = "tipo1";
            this.tipo1.Size = new System.Drawing.Size(72, 26);
            this.tipo1.TabIndex = 20;
            this.tipo1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tipo2
            // 
            this.tipo2.BackColor = System.Drawing.Color.Red;
            this.tipo2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tipo2.ForeColor = System.Drawing.SystemColors.Control;
            this.tipo2.Location = new System.Drawing.Point(433, 232);
            this.tipo2.Name = "tipo2";
            this.tipo2.Size = new System.Drawing.Size(72, 26);
            this.tipo2.TabIndex = 21;
            this.tipo2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pre
            // 
            this.pre.BackColor = System.Drawing.Color.Red;
            this.pre.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pre.ForeColor = System.Drawing.SystemColors.Control;
            this.pre.Location = new System.Drawing.Point(514, 232);
            this.pre.Name = "pre";
            this.pre.Size = new System.Drawing.Size(25, 26);
            this.pre.TabIndex = 22;
            this.pre.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pos
            // 
            this.pos.BackColor = System.Drawing.Color.Red;
            this.pos.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pos.ForeColor = System.Drawing.SystemColors.Control;
            this.pos.Location = new System.Drawing.Point(545, 232);
            this.pos.Name = "pos";
            this.pos.Size = new System.Drawing.Size(25, 26);
            this.pos.TabIndex = 23;
            this.pos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // mov1
            // 
            this.mov1.BackColor = System.Drawing.Color.Red;
            this.mov1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mov1.ForeColor = System.Drawing.SystemColors.Control;
            this.mov1.Location = new System.Drawing.Point(355, 281);
            this.mov1.Name = "mov1";
            this.mov1.Size = new System.Drawing.Size(113, 26);
            this.mov1.TabIndex = 24;
            this.mov1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // mov2
            // 
            this.mov2.BackColor = System.Drawing.Color.Red;
            this.mov2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mov2.ForeColor = System.Drawing.SystemColors.Control;
            this.mov2.Location = new System.Drawing.Point(473, 281);
            this.mov2.Name = "mov2";
            this.mov2.Size = new System.Drawing.Size(113, 26);
            this.mov2.TabIndex = 25;
            this.mov2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // mov3
            // 
            this.mov3.BackColor = System.Drawing.Color.Red;
            this.mov3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mov3.ForeColor = System.Drawing.SystemColors.Control;
            this.mov3.Location = new System.Drawing.Point(355, 316);
            this.mov3.Name = "mov3";
            this.mov3.Size = new System.Drawing.Size(113, 26);
            this.mov3.TabIndex = 26;
            this.mov3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // mov4
            // 
            this.mov4.BackColor = System.Drawing.Color.Red;
            this.mov4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mov4.ForeColor = System.Drawing.SystemColors.Control;
            this.mov4.Location = new System.Drawing.Point(474, 316);
            this.mov4.Name = "mov4";
            this.mov4.Size = new System.Drawing.Size(113, 26);
            this.mov4.TabIndex = 27;
            this.mov4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // descripcion
            // 
            this.descripcion.BackColor = System.Drawing.Color.Red;
            this.descripcion.Font = new System.Drawing.Font("Arial Rounded MT Bold", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descripcion.ForeColor = System.Drawing.SystemColors.Control;
            this.descripcion.Location = new System.Drawing.Point(355, 362);
            this.descripcion.Name = "descripcion";
            this.descripcion.Size = new System.Drawing.Size(231, 33);
            this.descripcion.TabIndex = 28;
            this.descripcion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::PokedexC_sharp.Properties.Resources.pokeball;
            this.pictureBox1.Location = new System.Drawing.Point(24, 316);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(59, 57);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 29;
            this.pictureBox1.TabStop = false;
            // 
            // entrenador
            // 
            this.entrenador.BackColor = System.Drawing.Color.White;
            this.entrenador.Font = new System.Drawing.Font("Arial Rounded MT Bold", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.entrenador.Location = new System.Drawing.Point(24, 371);
            this.entrenador.Name = "entrenador";
            this.entrenador.Size = new System.Drawing.Size(59, 24);
            this.entrenador.TabIndex = 30;
            this.entrenador.Text = "Entrenador";
            this.entrenador.UseVisualStyleBackColor = false;
            this.entrenador.Click += new System.EventHandler(this.entrenador_Click);
            // 
            // VentanaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(618, 430);
            this.Controls.Add(this.entrenador);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.descripcion);
            this.Controls.Add(this.mov4);
            this.Controls.Add(this.mov3);
            this.Controls.Add(this.mov2);
            this.Controls.Add(this.mov1);
            this.Controls.Add(this.pos);
            this.Controls.Add(this.pre);
            this.Controls.Add(this.tipo2);
            this.Controls.Add(this.tipo1);
            this.Controls.Add(this.peso);
            this.Controls.Add(this.habitat);
            this.Controls.Add(this.especie);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.habilidad);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.altura);
            this.Controls.Add(this.nombre);
            this.Controls.Add(this.imagenpokemon);
            this.Controls.Add(this.nombrePokemon);
            this.Controls.Add(this.derecha);
            this.Controls.Add(this.izquierda);
            this.Controls.Add(this.fondo);
            this.Name = "VentanaPrincipal";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.fondo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imagenpokemon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox fondo;
        private System.Windows.Forms.Button izquierda;
        private System.Windows.Forms.Button derecha;
        private System.Windows.Forms.Label nombrePokemon;
        private System.Windows.Forms.PictureBox imagenpokemon;
        private System.Windows.Forms.Label nombre;
        private System.Windows.Forms.Label altura;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label habilidad;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label especie;
        private System.Windows.Forms.Label habitat;
        private System.Windows.Forms.Label peso;
        private System.Windows.Forms.Label tipo1;
        private System.Windows.Forms.Label tipo2;
        private System.Windows.Forms.Label pre;
        private System.Windows.Forms.Label pos;
        private System.Windows.Forms.Label mov1;
        private System.Windows.Forms.Label mov2;
        private System.Windows.Forms.Label mov3;
        private System.Windows.Forms.Label mov4;
        private System.Windows.Forms.Label descripcion;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button entrenador;
    }
}

