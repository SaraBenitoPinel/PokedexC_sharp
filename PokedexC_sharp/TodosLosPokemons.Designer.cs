namespace PokedexC_sharp
{
    partial class TodosLosPokemons
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
            this.todos = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.todos)).BeginInit();
            this.SuspendLayout();
            // 
            // todos
            // 
            this.todos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.todos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.todos.Location = new System.Drawing.Point(0, 0);
            this.todos.Name = "todos";
            this.todos.Size = new System.Drawing.Size(649, 413);
            this.todos.TabIndex = 0;
            this.todos.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.todos_CellClick);
            // 
            // TodosLosPokemons
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(649, 413);
            this.Controls.Add(this.todos);
            this.Name = "TodosLosPokemons";
            this.Text = "TodosLosPokemons";
            ((System.ComponentModel.ISupportInitialize)(this.todos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.DataGridView todos;
    }
}