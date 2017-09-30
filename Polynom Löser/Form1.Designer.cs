namespace Polynom_Löser
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lb_vertexp = new System.Windows.Forms.Label();
            this.lb_verx = new System.Windows.Forms.Label();
            this.lb_very = new System.Windows.Forms.Label();
            this.txt_c = new System.Windows.Forms.TextBox();
            this.txt_ax = new System.Windows.Forms.TextBox();
            this.txt_bx = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lb_lös1 = new System.Windows.Forms.Label();
            this.lb_lös2 = new System.Windows.Forms.Label();
            this.bt_lösen = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mainToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.infoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bt_showGraph = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lb_vertexp);
            this.groupBox2.Controls.Add(this.lb_verx);
            this.groupBox2.Controls.Add(this.lb_very);
            this.groupBox2.ForeColor = System.Drawing.Color.Black;
            this.groupBox2.Location = new System.Drawing.Point(12, 177);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(307, 112);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "vertex";
            // 
            // lb_vertexp
            // 
            this.lb_vertexp.AutoSize = true;
            this.lb_vertexp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_vertexp.ForeColor = System.Drawing.Color.Black;
            this.lb_vertexp.Location = new System.Drawing.Point(6, 79);
            this.lb_vertexp.Name = "lb_vertexp";
            this.lb_vertexp.Size = new System.Drawing.Size(22, 16);
            this.lb_vertexp.TabIndex = 9;
            this.lb_vertexp.Text = "P:";
            // 
            // lb_verx
            // 
            this.lb_verx.AutoSize = true;
            this.lb_verx.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_verx.ForeColor = System.Drawing.Color.Black;
            this.lb_verx.Location = new System.Drawing.Point(6, 23);
            this.lb_verx.Name = "lb_verx";
            this.lb_verx.Size = new System.Drawing.Size(19, 16);
            this.lb_verx.TabIndex = 7;
            this.lb_verx.Text = "x:";
            // 
            // lb_very
            // 
            this.lb_very.AutoSize = true;
            this.lb_very.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_very.ForeColor = System.Drawing.Color.Black;
            this.lb_very.Location = new System.Drawing.Point(6, 50);
            this.lb_very.Name = "lb_very";
            this.lb_very.Size = new System.Drawing.Size(20, 16);
            this.lb_very.TabIndex = 8;
            this.lb_very.Text = "y:";
            // 
            // txt_c
            // 
            this.txt_c.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.txt_c.Location = new System.Drawing.Point(238, 63);
            this.txt_c.Name = "txt_c";
            this.txt_c.Size = new System.Drawing.Size(81, 20);
            this.txt_c.TabIndex = 2;
            this.txt_c.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_ax
            // 
            this.txt_ax.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.txt_ax.Location = new System.Drawing.Point(26, 63);
            this.txt_ax.Name = "txt_ax";
            this.txt_ax.Size = new System.Drawing.Size(81, 20);
            this.txt_ax.TabIndex = 0;
            this.txt_ax.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_bx
            // 
            this.txt_bx.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.txt_bx.Location = new System.Drawing.Point(132, 63);
            this.txt_bx.Name = "txt_bx";
            this.txt_bx.Size = new System.Drawing.Size(81, 20);
            this.txt_bx.TabIndex = 1;
            this.txt_bx.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lb_lös1);
            this.groupBox1.Controls.Add(this.lb_lös2);
            this.groupBox1.ForeColor = System.Drawing.Color.Black;
            this.groupBox1.Location = new System.Drawing.Point(12, 89);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(307, 82);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "roots";
            // 
            // lb_lös1
            // 
            this.lb_lös1.AutoSize = true;
            this.lb_lös1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_lös1.ForeColor = System.Drawing.Color.Black;
            this.lb_lös1.Location = new System.Drawing.Point(6, 24);
            this.lb_lös1.Name = "lb_lös1";
            this.lb_lös1.Size = new System.Drawing.Size(20, 16);
            this.lb_lös1.TabIndex = 5;
            this.lb_lös1.Text = "1:";
            // 
            // lb_lös2
            // 
            this.lb_lös2.AutoSize = true;
            this.lb_lös2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_lös2.ForeColor = System.Drawing.Color.Black;
            this.lb_lös2.Location = new System.Drawing.Point(6, 53);
            this.lb_lös2.Name = "lb_lös2";
            this.lb_lös2.Size = new System.Drawing.Size(20, 16);
            this.lb_lös2.TabIndex = 6;
            this.lb_lös2.Text = "2:";
            // 
            // bt_lösen
            // 
            this.bt_lösen.Location = new System.Drawing.Point(100, 295);
            this.bt_lösen.Name = "bt_lösen";
            this.bt_lösen.Size = new System.Drawing.Size(219, 26);
            this.bt_lösen.TabIndex = 3;
            this.bt_lösen.Text = "solve";
            this.bt_lösen.UseVisualStyleBackColor = true;
            this.bt_lösen.Click += new System.EventHandler(this.bt_lösen_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(9, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 18);
            this.label1.TabIndex = 4;
            this.label1.Text = "f(x) = ax²+bx+c";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(9, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(16, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "a:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(115, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(16, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "b:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(221, 66);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(16, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "c:";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mainToolStripMenuItem,
            this.settingsToolStripMenuItem,
            this.infoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(333, 24);
            this.menuStrip1.TabIndex = 18;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mainToolStripMenuItem
            // 
            this.mainToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.loadToolStripMenuItem});
            this.mainToolStripMenuItem.Name = "mainToolStripMenuItem";
            this.mainToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            this.mainToolStripMenuItem.Text = "Main";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.settingsToolStripMenuItem.Text = "Settings";
            // 
            // infoToolStripMenuItem
            // 
            this.infoToolStripMenuItem.Name = "infoToolStripMenuItem";
            this.infoToolStripMenuItem.Size = new System.Drawing.Size(40, 20);
            this.infoToolStripMenuItem.Text = "Info";
            this.infoToolStripMenuItem.Click += new System.EventHandler(this.infoToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.saveToolStripMenuItem.Text = "Save";
            // 
            // loadToolStripMenuItem
            // 
            this.loadToolStripMenuItem.Name = "loadToolStripMenuItem";
            this.loadToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.loadToolStripMenuItem.Text = "Load";
            // 
            // bt_showGraph
            // 
            this.bt_showGraph.Location = new System.Drawing.Point(12, 295);
            this.bt_showGraph.Name = "bt_showGraph";
            this.bt_showGraph.Size = new System.Drawing.Size(82, 25);
            this.bt_showGraph.TabIndex = 19;
            this.bt_showGraph.Text = "Graph";
            this.bt_showGraph.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(333, 329);
            this.Controls.Add(this.bt_showGraph);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.txt_c);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_ax);
            this.Controls.Add(this.bt_lösen);
            this.Controls.Add(this.txt_bx);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "x2solve";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lb_verx;
        private System.Windows.Forms.Label lb_very;
        private System.Windows.Forms.TextBox txt_c;
        private System.Windows.Forms.TextBox txt_ax;
        private System.Windows.Forms.TextBox txt_bx;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lb_lös1;
        private System.Windows.Forms.Label lb_lös2;
        private System.Windows.Forms.Button bt_lösen;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mainToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem infoToolStripMenuItem;
        private System.Windows.Forms.Label lb_vertexp;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadToolStripMenuItem;
        private System.Windows.Forms.Button bt_showGraph;
    }
}

