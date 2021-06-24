
namespace WindowsFormsApp1
{
    partial class orden_btn
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
            this.Semana_listbox = new System.Windows.Forms.ListBox();
            this.dias_listBox = new System.Windows.Forms.ListBox();
            this.ejecutara_btn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.ordenarlistbox = new System.Windows.Forms.ListBox();
            this.max_min_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Semana_listbox
            // 
            this.Semana_listbox.FormattingEnabled = true;
            this.Semana_listbox.Location = new System.Drawing.Point(297, 118);
            this.Semana_listbox.Name = "Semana_listbox";
            this.Semana_listbox.Size = new System.Drawing.Size(157, 251);
            this.Semana_listbox.TabIndex = 8;
            // 
            // dias_listBox
            // 
            this.dias_listBox.FormattingEnabled = true;
            this.dias_listBox.Location = new System.Drawing.Point(94, 118);
            this.dias_listBox.Name = "dias_listBox";
            this.dias_listBox.Size = new System.Drawing.Size(148, 251);
            this.dias_listBox.TabIndex = 7;
            // 
            // ejecutara_btn
            // 
            this.ejecutara_btn.Location = new System.Drawing.Point(79, 27);
            this.ejecutara_btn.Name = "ejecutara_btn";
            this.ejecutara_btn.Size = new System.Drawing.Size(173, 48);
            this.ejecutara_btn.TabIndex = 6;
            this.ejecutara_btn.Text = "Ejecutar";
            this.ejecutara_btn.UseVisualStyleBackColor = true;
            this.ejecutara_btn.Click += new System.EventHandler(this.ejecutara_btn_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(356, 27);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(173, 48);
            this.button1.TabIndex = 9;
            this.button1.Text = "Ordenar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ordenarlistbox
            // 
            this.ordenarlistbox.FormattingEnabled = true;
            this.ordenarlistbox.Location = new System.Drawing.Point(513, 118);
            this.ordenarlistbox.Name = "ordenarlistbox";
            this.ordenarlistbox.Size = new System.Drawing.Size(157, 251);
            this.ordenarlistbox.TabIndex = 10;
            // 
            // max_min_btn
            // 
            this.max_min_btn.Location = new System.Drawing.Point(615, 27);
            this.max_min_btn.Name = "max_min_btn";
            this.max_min_btn.Size = new System.Drawing.Size(173, 48);
            this.max_min_btn.TabIndex = 11;
            this.max_min_btn.Text = "Max-Min";
            this.max_min_btn.UseVisualStyleBackColor = true;
            this.max_min_btn.Click += new System.EventHandler(this.max_min_btn_Click);
            // 
            // orden_btn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.max_min_btn);
            this.Controls.Add(this.ordenarlistbox);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Semana_listbox);
            this.Controls.Add(this.dias_listBox);
            this.Controls.Add(this.ejecutara_btn);
            this.Name = "orden_btn";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox Semana_listbox;
        private System.Windows.Forms.ListBox dias_listBox;
        private System.Windows.Forms.Button ejecutara_btn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox ordenarlistbox;
        private System.Windows.Forms.Button max_min_btn;
    }
}

