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
            this.comboRepos = new System.Windows.Forms.ComboBox();
            this.btnConsultastatus = new System.Windows.Forms.Button();
            this.btnsincronizar = new System.Windows.Forms.Button();
            this.txtramaorigen = new System.Windows.Forms.TextBox();
            this.txtramadestino = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.listaBranches = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnClean = new System.Windows.Forms.Button();
            this.btneliminarcambioslocales = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtResult
            // 
            this.txtResult.BackColor = System.Drawing.Color.Black;
            this.txtResult.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.txtResult.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.txtResult.Location = new System.Drawing.Point(0, 357);
            this.txtResult.Multiline = true;
            this.txtResult.Name = "txtResult";
            this.txtResult.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtResult.Size = new System.Drawing.Size(848, 289);
            this.txtResult.TabIndex = 0;
            this.txtResult.WordWrap = false;
            // 
            // comboRepos
            // 
            this.comboRepos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboRepos.FormattingEnabled = true;
            this.comboRepos.Location = new System.Drawing.Point(12, 34);
            this.comboRepos.Name = "comboRepos";
            this.comboRepos.Size = new System.Drawing.Size(256, 28);
            this.comboRepos.TabIndex = 5;
            this.comboRepos.SelectedIndexChanged += new System.EventHandler(this.comboRepos_SelectedIndexChanged);
            // 
            // btnConsultastatus
            // 
            this.btnConsultastatus.Location = new System.Drawing.Point(373, 291);
            this.btnConsultastatus.Name = "btnConsultastatus";
            this.btnConsultastatus.Size = new System.Drawing.Size(243, 29);
            this.btnConsultastatus.TabIndex = 6;
            this.btnConsultastatus.Text = "¿Tiene cambios pendientes?";
            this.btnConsultastatus.UseVisualStyleBackColor = true;
            this.btnConsultastatus.Click += new System.EventHandler(this.btnConsultastatus_Click);
            // 
            // btnsincronizar
            // 
            this.btnsincronizar.Location = new System.Drawing.Point(12, 236);
            this.btnsincronizar.Name = "btnsincronizar";
            this.btnsincronizar.Size = new System.Drawing.Size(243, 29);
            this.btnsincronizar.TabIndex = 7;
            this.btnsincronizar.Text = "Sicronizar ramas";
            this.btnsincronizar.UseVisualStyleBackColor = true;
            this.btnsincronizar.Click += new System.EventHandler(this.btnsincronizar_Click);
            // 
            // txtramaorigen
            // 
            this.txtramaorigen.Location = new System.Drawing.Point(278, 238);
            this.txtramaorigen.Name = "txtramaorigen";
            this.txtramaorigen.Size = new System.Drawing.Size(125, 27);
            this.txtramaorigen.TabIndex = 8;
            // 
            // txtramadestino
            // 
            this.txtramadestino.Location = new System.Drawing.Point(444, 237);
            this.txtramadestino.Name = "txtramadestino";
            this.txtramadestino.Size = new System.Drawing.Size(125, 27);
            this.txtramadestino.TabIndex = 9;
            this.txtramadestino.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(409, 244);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 20);
            this.label1.TabIndex = 10;
            this.label1.Text = "=>";
            // 
            // listaBranches
            // 
            this.listaBranches.FormattingEnabled = true;
            this.listaBranches.ItemHeight = 20;
            this.listaBranches.Items.AddRange(new object[] {
            "master",
            "demo-sandbox",
            "uat",
            "dev"});
            this.listaBranches.Location = new System.Drawing.Point(323, 34);
            this.listaBranches.Name = "listaBranches";
            this.listaBranches.Size = new System.Drawing.Size(143, 104);
            this.listaBranches.TabIndex = 11;
            this.listaBranches.SelectedIndexChanged += new System.EventHandler(this.listaBranches_SelectedIndexChanged);
            this.listaBranches.DoubleClick += new System.EventHandler(this.listaBranches_DoubleClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(323, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 20);
            this.label2.TabIndex = 12;
            this.label2.Text = "Cambiarse de rama";
            // 
            // btnClean
            // 
            this.btnClean.Location = new System.Drawing.Point(773, 236);
            this.btnClean.Name = "btnClean";
            this.btnClean.Size = new System.Drawing.Size(69, 29);
            this.btnClean.TabIndex = 13;
            this.btnClean.Text = "Limpiar";
            this.btnClean.UseVisualStyleBackColor = true;
            this.btnClean.Click += new System.EventHandler(this.btnClean_Click);
            // 
            // btneliminarcambioslocales
            // 
            this.btneliminarcambioslocales.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btneliminarcambioslocales.Location = new System.Drawing.Point(-1, 291);
            this.btneliminarcambioslocales.Name = "btneliminarcambioslocales";
            this.btneliminarcambioslocales.Size = new System.Drawing.Size(225, 29);
            this.btneliminarcambioslocales.TabIndex = 14;
            this.btneliminarcambioslocales.Text = "Eliminar todos los cambios";
            this.btneliminarcambioslocales.UseVisualStyleBackColor = true;
            this.btneliminarcambioslocales.Click += new System.EventHandler(this.btneliminarcambioslocales_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(848, 646);
            this.Controls.Add(this.btneliminarcambioslocales);
            this.Controls.Add(this.btnClean);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listaBranches);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtramadestino);
            this.Controls.Add(this.txtramaorigen);
            this.Controls.Add(this.btnsincronizar);
            this.Controls.Add(this.btnConsultastatus);
            this.Controls.Add(this.comboRepos);
            this.Controls.Add(this.txtResult);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txtResult;
        private ComboBox comboRepos;
        private Button btnConsultastatus;
        private Button btnsincronizar;
        private TextBox txtramaorigen;
        private TextBox txtramadestino;
        private Label label1;
        private ListBox listaBranches;
        private Label label2;
        private Button btnClean;
        private Button btneliminarcambioslocales;
    }
}