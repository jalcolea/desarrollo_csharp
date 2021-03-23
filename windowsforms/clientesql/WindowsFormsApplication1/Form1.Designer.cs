namespace WindowsFormsApplication1
{
    partial class Form1
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
            this.sqlinput = new System.Windows.Forms.TextBox();
            this.sqlexecute = new System.Windows.Forms.Button();
            this.gridoutput = new System.Windows.Forms.DataGridView();
            this.outnumresults = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.sqlhistory = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.sqllog = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.gridoutput)).BeginInit();
            this.SuspendLayout();
            // 
            // sqlinput
            // 
            this.sqlinput.Location = new System.Drawing.Point(12, 28);
            this.sqlinput.Multiline = true;
            this.sqlinput.Name = "sqlinput";
            this.sqlinput.Size = new System.Drawing.Size(598, 90);
            this.sqlinput.TabIndex = 0;
            this.sqlinput.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.sqlinput_KeyPress);
            // 
            // sqlexecute
            // 
            this.sqlexecute.Location = new System.Drawing.Point(528, 124);
            this.sqlexecute.Name = "sqlexecute";
            this.sqlexecute.Size = new System.Drawing.Size(82, 25);
            this.sqlexecute.TabIndex = 2;
            this.sqlexecute.Text = "Execute";
            this.sqlexecute.UseVisualStyleBackColor = true;
            this.sqlexecute.Click += new System.EventHandler(this.sqlexecute_Click);
            // 
            // gridoutput
            // 
            this.gridoutput.AllowUserToAddRows = false;
            this.gridoutput.AllowUserToOrderColumns = true;
            this.gridoutput.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridoutput.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridoutput.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridoutput.Location = new System.Drawing.Point(12, 156);
            this.gridoutput.Name = "gridoutput";
            this.gridoutput.ReadOnly = true;
            this.gridoutput.Size = new System.Drawing.Size(1229, 237);
            this.gridoutput.TabIndex = 3;
            this.gridoutput.Tag = "";
            this.gridoutput.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridoutput_CellContentClick);
            // 
            // outnumresults
            // 
            this.outnumresults.Location = new System.Drawing.Point(79, 127);
            this.outnumresults.Name = "outnumresults";
            this.outnumresults.ReadOnly = true;
            this.outnumresults.Size = new System.Drawing.Size(100, 20);
            this.outnumresults.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 130);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Resultados";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // sqlhistory
            // 
            this.sqlhistory.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.sqlhistory.Location = new System.Drawing.Point(643, 29);
            this.sqlhistory.Multiline = true;
            this.sqlhistory.Name = "sqlhistory";
            this.sqlhistory.ReadOnly = true;
            this.sqlhistory.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.sqlhistory.Size = new System.Drawing.Size(598, 90);
            this.sqlhistory.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(440, 125);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(82, 25);
            this.button1.TabIndex = 7;
            this.button1.Text = "Clear";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // sqllog
            // 
            this.sqllog.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.sqllog.Location = new System.Drawing.Point(12, 399);
            this.sqllog.Multiline = true;
            this.sqllog.Name = "sqllog";
            this.sqllog.Size = new System.Drawing.Size(1229, 90);
            this.sqllog.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1253, 501);
            this.Controls.Add(this.sqllog);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.sqlhistory);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.outnumresults);
            this.Controls.Add(this.gridoutput);
            this.Controls.Add(this.sqlexecute);
            this.Controls.Add(this.sqlinput);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridoutput)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox sqlinput;
        private System.Windows.Forms.Button sqlexecute;
        private System.Windows.Forms.DataGridView gridoutput;
        private System.Windows.Forms.TextBox outnumresults;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox sqlhistory;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox sqllog;
    }
}

