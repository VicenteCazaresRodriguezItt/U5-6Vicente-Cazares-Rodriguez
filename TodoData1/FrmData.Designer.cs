namespace TodoData1
{
    partial class FrmData
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
            this.LblUser = new System.Windows.Forms.Label();
            this.LblDate = new System.Windows.Forms.Label();
            this.LblName = new System.Windows.Forms.Label();
            this.LblDescription = new System.Windows.Forms.Label();
            this.LblHour = new System.Windows.Forms.Label();
            this.LblStatus = new System.Windows.Forms.Label();
            this.TxtUser = new System.Windows.Forms.TextBox();
            this.TxtDate = new System.Windows.Forms.TextBox();
            this.TxtName = new System.Windows.Forms.TextBox();
            this.TxtDesc = new System.Windows.Forms.TextBox();
            this.TxtHour = new System.Windows.Forms.TextBox();
            this.TxtStatus = new System.Windows.Forms.TextBox();
            this.BtnEnter = new System.Windows.Forms.Button();
            this.BtnFinish = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LblUser
            // 
            this.LblUser.AutoSize = true;
            this.LblUser.Location = new System.Drawing.Point(0, 44);
            this.LblUser.Name = "LblUser";
            this.LblUser.Size = new System.Drawing.Size(38, 17);
            this.LblUser.TabIndex = 1;
            this.LblUser.Text = "&User";
            // 
            // LblDate
            // 
            this.LblDate.AutoSize = true;
            this.LblDate.Location = new System.Drawing.Point(0, 77);
            this.LblDate.Name = "LblDate";
            this.LblDate.Size = new System.Drawing.Size(38, 17);
            this.LblDate.TabIndex = 1;
            this.LblDate.Text = "&Date";
            // 
            // LblName
            // 
            this.LblName.AutoSize = true;
            this.LblName.Location = new System.Drawing.Point(-3, 100);
            this.LblName.Name = "LblName";
            this.LblName.Size = new System.Drawing.Size(45, 17);
            this.LblName.TabIndex = 2;
            this.LblName.Text = "&Name";
            // 
            // LblDescription
            // 
            this.LblDescription.AutoSize = true;
            this.LblDescription.Location = new System.Drawing.Point(-3, 130);
            this.LblDescription.Name = "LblDescription";
            this.LblDescription.Size = new System.Drawing.Size(79, 17);
            this.LblDescription.TabIndex = 3;
            this.LblDescription.Text = "D&escription";
            // 
            // LblHour
            // 
            this.LblHour.AutoSize = true;
            this.LblHour.Location = new System.Drawing.Point(-3, 161);
            this.LblHour.Name = "LblHour";
            this.LblHour.Size = new System.Drawing.Size(39, 17);
            this.LblHour.TabIndex = 4;
            this.LblHour.Text = "&Hour";
            // 
            // LblStatus
            // 
            this.LblStatus.AutoSize = true;
            this.LblStatus.Location = new System.Drawing.Point(-3, 194);
            this.LblStatus.Name = "LblStatus";
            this.LblStatus.Size = new System.Drawing.Size(48, 17);
            this.LblStatus.TabIndex = 5;
            this.LblStatus.Text = "&Status";
            // 
            // TxtUser
            // 
            this.TxtUser.Location = new System.Drawing.Point(82, 41);
            this.TxtUser.Name = "TxtUser";
            this.TxtUser.Size = new System.Drawing.Size(100, 22);
            this.TxtUser.TabIndex = 0;
            // 
            // TxtDate
            // 
            this.TxtDate.Location = new System.Drawing.Point(82, 69);
            this.TxtDate.Name = "TxtDate";
            this.TxtDate.Size = new System.Drawing.Size(100, 22);
            this.TxtDate.TabIndex = 2;
            // 
            // TxtName
            // 
            this.TxtName.Location = new System.Drawing.Point(82, 97);
            this.TxtName.Name = "TxtName";
            this.TxtName.Size = new System.Drawing.Size(100, 22);
            this.TxtName.TabIndex = 3;
            // 
            // TxtDesc
            // 
            this.TxtDesc.Location = new System.Drawing.Point(82, 125);
            this.TxtDesc.Name = "TxtDesc";
            this.TxtDesc.Size = new System.Drawing.Size(100, 22);
            this.TxtDesc.TabIndex = 4;
            // 
            // TxtHour
            // 
            this.TxtHour.Location = new System.Drawing.Point(82, 153);
            this.TxtHour.Name = "TxtHour";
            this.TxtHour.Size = new System.Drawing.Size(100, 22);
            this.TxtHour.TabIndex = 5;
            // 
            // TxtStatus
            // 
            this.TxtStatus.Location = new System.Drawing.Point(82, 188);
            this.TxtStatus.Name = "TxtStatus";
            this.TxtStatus.Size = new System.Drawing.Size(100, 22);
            this.TxtStatus.TabIndex = 6;
            // 
            // BtnEnter
            // 
            this.BtnEnter.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.BtnEnter.Location = new System.Drawing.Point(3, 283);
            this.BtnEnter.Name = "BtnEnter";
            this.BtnEnter.Size = new System.Drawing.Size(75, 45);
            this.BtnEnter.TabIndex = 12;
            this.BtnEnter.Text = "En&ter";
            this.BtnEnter.UseVisualStyleBackColor = true;
            // 
            // BtnFinish
            // 
            this.BtnFinish.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BtnFinish.Location = new System.Drawing.Point(107, 283);
            this.BtnFinish.Name = "BtnFinish";
            this.BtnFinish.Size = new System.Drawing.Size(75, 45);
            this.BtnFinish.TabIndex = 13;
            this.BtnFinish.Text = "&Finish";
            this.BtnFinish.UseVisualStyleBackColor = true;
            // 
            // FrmData
            // 
            this.AcceptButton = this.BtnEnter;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.BtnFinish;
            this.ClientSize = new System.Drawing.Size(208, 359);
            this.Controls.Add(this.BtnFinish);
            this.Controls.Add(this.BtnEnter);
            this.Controls.Add(this.TxtStatus);
            this.Controls.Add(this.TxtHour);
            this.Controls.Add(this.TxtDesc);
            this.Controls.Add(this.TxtName);
            this.Controls.Add(this.TxtDate);
            this.Controls.Add(this.TxtUser);
            this.Controls.Add(this.LblStatus);
            this.Controls.Add(this.LblHour);
            this.Controls.Add(this.LblDescription);
            this.Controls.Add(this.LblName);
            this.Controls.Add(this.LblDate);
            this.Controls.Add(this.LblUser);
            this.Name = "FrmData";
            this.Text = "FrmData";
            this.Load += new System.EventHandler(this.FrmData_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblUser;
        private System.Windows.Forms.Label LblDate;
        private System.Windows.Forms.Label LblName;
        private System.Windows.Forms.Label LblDescription;
        private System.Windows.Forms.Label LblHour;
        private System.Windows.Forms.Label LblStatus;
        public System.Windows.Forms.TextBox TxtUser;
        public System.Windows.Forms.TextBox TxtDate;
        public System.Windows.Forms.TextBox TxtName;
        public System.Windows.Forms.TextBox TxtDesc;
        public System.Windows.Forms.TextBox TxtHour;
        public System.Windows.Forms.TextBox TxtStatus;
        private System.Windows.Forms.Button BtnEnter;
        private System.Windows.Forms.Button BtnFinish;
    }
}