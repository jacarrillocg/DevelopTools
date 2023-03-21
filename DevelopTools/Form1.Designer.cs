namespace DevelopTools
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
            this.txtResult = new System.Windows.Forms.TextBox();
            this.txtRuta = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.btnAplicar = new System.Windows.Forms.Button();
            this.txtComentario = new System.Windows.Forms.TextBox();
            this.comboRepos = new System.Windows.Forms.ComboBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // txtResult
            // 
            this.txtResult.Location = new System.Drawing.Point(10, 318);
            this.txtResult.Multiline = true;
            this.txtResult.Name = "txtResult";
            this.txtResult.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtResult.Size = new System.Drawing.Size(778, 129);
            this.txtResult.TabIndex = 0;
            this.txtResult.WordWrap = false;
            // 
            // txtRuta
            // 
            this.txtRuta.Location = new System.Drawing.Point(23, 34);
            this.txtRuta.Name = "txtRuta";
            this.txtRuta.Size = new System.Drawing.Size(186, 27);
            this.txtRuta.TabIndex = 1;
            this.txtRuta.Text = "C:\\Users\\jose.carrillo\\source\\repos\\web_sivu_frontoffice";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(23, 67);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(186, 27);
            this.textBox3.TabIndex = 2;
            // 
            // btnAplicar
            // 
            this.btnAplicar.Location = new System.Drawing.Point(543, 266);
            this.btnAplicar.Name = "btnAplicar";
            this.btnAplicar.Size = new System.Drawing.Size(94, 29);
            this.btnAplicar.TabIndex = 3;
            this.btnAplicar.Text = "Aplicar";
            this.btnAplicar.UseVisualStyleBackColor = true;
            this.btnAplicar.Click += new System.EventHandler(this.btnAplicar_Click);
            // 
            // txtComentario
            // 
            this.txtComentario.Location = new System.Drawing.Point(414, 34);
            this.txtComentario.Multiline = true;
            this.txtComentario.Name = "txtComentario";
            this.txtComentario.Size = new System.Drawing.Size(245, 150);
            this.txtComentario.TabIndex = 4;
            // 
            // comboRepos
            // 
            this.comboRepos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboRepos.FormattingEnabled = true;
            this.comboRepos.Location = new System.Drawing.Point(23, 127);
            this.comboRepos.Name = "comboRepos";
            this.comboRepos.Size = new System.Drawing.Size(256, 28);
            this.comboRepos.TabIndex = 5;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(41, 190);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(151, 28);
            this.comboBox1.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.comboRepos);
            this.Controls.Add(this.txtComentario);
            this.Controls.Add(this.btnAplicar);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.txtRuta);
            this.Controls.Add(this.txtResult);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txtResult;
        private TextBox txtRuta;
        private TextBox textBox3;
        private Button btnAplicar;
        private TextBox txtComentario;
        private ComboBox comboRepos;
        private ComboBox comboBox1;
    }
}