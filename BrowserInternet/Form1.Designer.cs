namespace BrowserInternet
{
    partial class frmBrowser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBrowser));
            this.Voltar = new System.Windows.Forms.Button();
            this.Avancar = new System.Windows.Forms.Button();
            this.Home = new System.Windows.Forms.Button();
            this.Pesquisar = new System.Windows.Forms.Button();
            this.Parar = new System.Windows.Forms.Button();
            this.Atualizar = new System.Windows.Forms.Button();
            this.Ir = new System.Windows.Forms.Button();
            this.txtUrl = new System.Windows.Forms.ComboBox();
            this.panel = new System.Windows.Forms.Panel();
            this.Browser = new System.Windows.Forms.WebBrowser();
            this.panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // Voltar
            // 
            this.Voltar.Image = ((System.Drawing.Image)(resources.GetObject("Voltar.Image")));
            this.Voltar.Location = new System.Drawing.Point(12, 24);
            this.Voltar.Name = "Voltar";
            this.Voltar.Size = new System.Drawing.Size(47, 42);
            this.Voltar.TabIndex = 0;
            this.Voltar.UseVisualStyleBackColor = true;
            this.Voltar.Click += new System.EventHandler(this.voltar_Click);
            // 
            // Avancar
            // 
            this.Avancar.Image = ((System.Drawing.Image)(resources.GetObject("Avancar.Image")));
            this.Avancar.Location = new System.Drawing.Point(88, 24);
            this.Avancar.Name = "Avancar";
            this.Avancar.Size = new System.Drawing.Size(47, 42);
            this.Avancar.TabIndex = 1;
            this.Avancar.UseVisualStyleBackColor = true;
            this.Avancar.Click += new System.EventHandler(this.avancar_Click);
            // 
            // Home
            // 
            this.Home.Image = ((System.Drawing.Image)(resources.GetObject("Home.Image")));
            this.Home.Location = new System.Drawing.Point(163, 24);
            this.Home.Name = "Home";
            this.Home.Size = new System.Drawing.Size(47, 42);
            this.Home.TabIndex = 2;
            this.Home.UseVisualStyleBackColor = true;
            this.Home.Click += new System.EventHandler(this.home_Click);
            // 
            // Pesquisar
            // 
            this.Pesquisar.Image = ((System.Drawing.Image)(resources.GetObject("Pesquisar.Image")));
            this.Pesquisar.Location = new System.Drawing.Point(243, 24);
            this.Pesquisar.Name = "Pesquisar";
            this.Pesquisar.Size = new System.Drawing.Size(47, 42);
            this.Pesquisar.TabIndex = 3;
            this.Pesquisar.UseVisualStyleBackColor = true;
            this.Pesquisar.Click += new System.EventHandler(this.pesquisar_Click);
            // 
            // Parar
            // 
            this.Parar.Image = ((System.Drawing.Image)(resources.GetObject("Parar.Image")));
            this.Parar.Location = new System.Drawing.Point(328, 24);
            this.Parar.Name = "Parar";
            this.Parar.Size = new System.Drawing.Size(47, 42);
            this.Parar.TabIndex = 4;
            this.Parar.UseVisualStyleBackColor = true;
            this.Parar.Click += new System.EventHandler(this.parar_Click);
            // 
            // Atualizar
            // 
            this.Atualizar.Image = ((System.Drawing.Image)(resources.GetObject("Atualizar.Image")));
            this.Atualizar.Location = new System.Drawing.Point(411, 24);
            this.Atualizar.Name = "Atualizar";
            this.Atualizar.Size = new System.Drawing.Size(47, 42);
            this.Atualizar.TabIndex = 5;
            this.Atualizar.UseVisualStyleBackColor = true;
            this.Atualizar.Click += new System.EventHandler(this.atualizar_Click);
            // 
            // Ir
            // 
            this.Ir.Image = ((System.Drawing.Image)(resources.GetObject("Ir.Image")));
            this.Ir.Location = new System.Drawing.Point(818, 24);
            this.Ir.Name = "Ir";
            this.Ir.Size = new System.Drawing.Size(47, 42);
            this.Ir.TabIndex = 6;
            this.Ir.UseVisualStyleBackColor = true;
            this.Ir.Click += new System.EventHandler(this.ir_Click);
            // 
            // txtUrl
            // 
            this.txtUrl.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUrl.FormattingEnabled = true;
            this.txtUrl.Location = new System.Drawing.Point(475, 33);
            this.txtUrl.Name = "txtUrl";
            this.txtUrl.Size = new System.Drawing.Size(322, 24);
            this.txtUrl.TabIndex = 7;
            this.txtUrl.Text = "http://";
            // 
            // panel
            // 
            this.panel.Controls.Add(this.Voltar);
            this.panel.Controls.Add(this.Avancar);
            this.panel.Controls.Add(this.txtUrl);
            this.panel.Controls.Add(this.Home);
            this.panel.Controls.Add(this.Ir);
            this.panel.Controls.Add(this.Pesquisar);
            this.panel.Controls.Add(this.Atualizar);
            this.panel.Controls.Add(this.Parar);
            this.panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel.Location = new System.Drawing.Point(0, 0);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(877, 100);
            this.panel.TabIndex = 8;
            // 
            // Browser
            // 
            this.Browser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Browser.Location = new System.Drawing.Point(0, 100);
            this.Browser.MinimumSize = new System.Drawing.Size(20, 20);
            this.Browser.Name = "Browser";
            this.Browser.Size = new System.Drawing.Size(877, 347);
            this.Browser.TabIndex = 9;
            // 
            // frmBrowser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(877, 447);
            this.Controls.Add(this.Browser);
            this.Controls.Add(this.panel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmBrowser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Browser de Internet";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button Avancar;
        private System.Windows.Forms.Button Home;
        private System.Windows.Forms.Button Pesquisar;
        private System.Windows.Forms.Button Parar;
        private System.Windows.Forms.Button Atualizar;
        private System.Windows.Forms.Button Ir;
        private System.Windows.Forms.ComboBox txtUrl;
        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.WebBrowser Browser;
        private System.Windows.Forms.Button Voltar;
    }
}

