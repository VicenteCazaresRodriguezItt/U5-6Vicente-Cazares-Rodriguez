namespace TodoData1
{
    partial class FrmMain
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
            this.DgvData = new System.Windows.Forms.DataGridView();
            this.Cuser = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cfecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cdescripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Chour = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cstatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LblOption = new System.Windows.Forms.Label();
            this.textBox11 = new System.Windows.Forms.TextBox();
            this.BtnEnter1 = new System.Windows.Forms.Button();
            this.BtnEnd = new System.Windows.Forms.Button();
            this.BtnMenu = new System.Windows.Forms.Button();
            this.TxtMenu = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtStatusUpdate = new System.Windows.Forms.TextBox();
            this.BrnUpdate = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DgvData)).BeginInit();
            this.SuspendLayout();
            // 
            // DgvData
            // 
            this.DgvData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Cuser,
            this.Cfecha,
            this.Cname,
            this.Cdescripcion,
            this.Chour,
            this.Cstatus});
            this.DgvData.Location = new System.Drawing.Point(0, 0);
            this.DgvData.Name = "DgvData";
            this.DgvData.ReadOnly = true;
            this.DgvData.RowHeadersWidth = 49;
            this.DgvData.RowTemplate.Height = 24;
            this.DgvData.Size = new System.Drawing.Size(767, 211);
            this.DgvData.TabIndex = 2;
            this.DgvData.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvData_CellClick);
            this.DgvData.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvData_CellContentClick_1);
            // 
            // Cuser
            // 
            this.Cuser.HeaderText = "User";
            this.Cuser.MinimumWidth = 6;
            this.Cuser.Name = "Cuser";
            this.Cuser.Width = 120;
            // 
            // Cfecha
            // 
            this.Cfecha.HeaderText = "Date";
            this.Cfecha.MinimumWidth = 6;
            this.Cfecha.Name = "Cfecha";
            this.Cfecha.Width = 120;
            // 
            // Cname
            // 
            this.Cname.HeaderText = "Name";
            this.Cname.MinimumWidth = 6;
            this.Cname.Name = "Cname";
            this.Cname.Width = 120;
            // 
            // Cdescripcion
            // 
            this.Cdescripcion.HeaderText = "Descripcion";
            this.Cdescripcion.MinimumWidth = 6;
            this.Cdescripcion.Name = "Cdescripcion";
            this.Cdescripcion.Width = 120;
            // 
            // Chour
            // 
            this.Chour.HeaderText = "Hour";
            this.Chour.MinimumWidth = 6;
            this.Chour.Name = "Chour";
            this.Chour.Width = 120;
            // 
            // Cstatus
            // 
            this.Cstatus.HeaderText = "Status";
            this.Cstatus.MinimumWidth = 6;
            this.Cstatus.Name = "Cstatus";
            this.Cstatus.Width = 120;
            // 
            // LblOption
            // 
            this.LblOption.AutoSize = true;
            this.LblOption.Location = new System.Drawing.Point(280, 254);
            this.LblOption.Name = "LblOption";
            this.LblOption.Size = new System.Drawing.Size(50, 17);
            this.LblOption.TabIndex = 1;
            this.LblOption.Text = "&Option";
            // 
            // textBox11
            // 
            this.textBox11.Location = new System.Drawing.Point(371, 254);
            this.textBox11.Name = "textBox11";
            this.textBox11.Size = new System.Drawing.Size(100, 22);
            this.textBox11.TabIndex = 0;
            // 
            // BtnEnter1
            // 
            this.BtnEnter1.Location = new System.Drawing.Point(194, 329);
            this.BtnEnter1.Name = "BtnEnter1";
            this.BtnEnter1.Size = new System.Drawing.Size(99, 39);
            this.BtnEnter1.TabIndex = 3;
            this.BtnEnter1.Text = "&Enter";
            this.BtnEnter1.UseVisualStyleBackColor = true;
            this.BtnEnter1.Click += new System.EventHandler(this.button1_Click);
            // 
            // BtnEnd
            // 
            this.BtnEnd.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BtnEnd.Location = new System.Drawing.Point(532, 329);
            this.BtnEnd.Name = "BtnEnd";
            this.BtnEnd.Size = new System.Drawing.Size(99, 39);
            this.BtnEnd.TabIndex = 4;
            this.BtnEnd.Text = "&End";
            this.BtnEnd.UseVisualStyleBackColor = true;
            this.BtnEnd.Click += new System.EventHandler(this.BtnEnd_Click);
            // 
            // BtnMenu
            // 
            this.BtnMenu.Location = new System.Drawing.Point(372, 329);
            this.BtnMenu.Name = "BtnMenu";
            this.BtnMenu.Size = new System.Drawing.Size(99, 39);
            this.BtnMenu.TabIndex = 5;
            this.BtnMenu.Text = "&Menu";
            this.BtnMenu.UseVisualStyleBackColor = true;
            this.BtnMenu.Click += new System.EventHandler(this.BtnMenu_Click);
            // 
            // TxtMenu
            // 
            this.TxtMenu.Enabled = false;
            this.TxtMenu.Location = new System.Drawing.Point(660, 217);
            this.TxtMenu.Multiline = true;
            this.TxtMenu.Name = "TxtMenu";
            this.TxtMenu.Size = new System.Drawing.Size(92, 151);
            this.TxtMenu.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 259);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 17);
            this.label1.TabIndex = 7;
            this.label1.Text = "Status:";
            // 
            // txtStatusUpdate
            // 
            this.txtStatusUpdate.Location = new System.Drawing.Point(78, 254);
            this.txtStatusUpdate.Name = "txtStatusUpdate";
            this.txtStatusUpdate.Size = new System.Drawing.Size(100, 22);
            this.txtStatusUpdate.TabIndex = 8;
            // 
            // BrnUpdate
            // 
            this.BrnUpdate.Location = new System.Drawing.Point(32, 329);
            this.BrnUpdate.Name = "BrnUpdate";
            this.BrnUpdate.Size = new System.Drawing.Size(99, 39);
            this.BrnUpdate.TabIndex = 9;
            this.BrnUpdate.Text = "&Update";
            this.BrnUpdate.UseVisualStyleBackColor = true;
            this.BrnUpdate.Click += new System.EventHandler(this.BrnUpdate_Click);
            // 
            // FrmMain
            // 
            this.AcceptButton = this.BtnEnter1;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.BtnEnd;
            this.ClientSize = new System.Drawing.Size(783, 399);
            this.Controls.Add(this.BrnUpdate);
            this.Controls.Add(this.txtStatusUpdate);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxtMenu);
            this.Controls.Add(this.BtnMenu);
            this.Controls.Add(this.BtnEnd);
            this.Controls.Add(this.BtnEnter1);
            this.Controls.Add(this.textBox11);
            this.Controls.Add(this.LblOption);
            this.Controls.Add(this.DgvData);
            this.Name = "FrmMain";
            this.Text = "Data";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.DataGridView DgvData;
        private System.Windows.Forms.Label LblOption;
        private System.Windows.Forms.TextBox textBox11;
        private System.Windows.Forms.Button BtnEnter1;
        private System.Windows.Forms.Button BtnEnd;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cuser;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cfecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cname;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cdescripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Chour;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cstatus;
        private System.Windows.Forms.Button BtnMenu;
        private System.Windows.Forms.TextBox TxtMenu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtStatusUpdate;
        private System.Windows.Forms.Button BrnUpdate;
    }
}

