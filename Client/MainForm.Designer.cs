namespace Client
{
    partial class MainForm
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
            this.ClientMenuStrip = new System.Windows.Forms.MenuStrip();
            this.ClientStatusStrip = new System.Windows.Forms.StatusStrip();
            this.CompanyLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.sp_1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.Sys_Time_Label = new System.Windows.Forms.ToolStripStatusLabel();
            this.Sys_User_Label = new System.Windows.Forms.ToolStripStatusLabel();
            this.sp_2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.ClientStatusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // ClientMenuStrip
            // 
            this.ClientMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.ClientMenuStrip.Name = "ClientMenuStrip";
            this.ClientMenuStrip.Size = new System.Drawing.Size(1330, 24);
            this.ClientMenuStrip.TabIndex = 0;
            this.ClientMenuStrip.Text = "POS端菜单";
            // 
            // ClientStatusStrip
            // 
            this.ClientStatusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Sys_User_Label,
            this.sp_1,
            this.Sys_Time_Label,
            this.sp_2,
            this.CompanyLabel});
            this.ClientStatusStrip.Location = new System.Drawing.Point(0, 765);
            this.ClientStatusStrip.Name = "ClientStatusStrip";
            this.ClientStatusStrip.Size = new System.Drawing.Size(1330, 22);
            this.ClientStatusStrip.TabIndex = 1;
            this.ClientStatusStrip.Text = "statusStrip1";
            // 
            // CompanyLabel
            // 
            this.CompanyLabel.Name = "CompanyLabel";
            this.CompanyLabel.Size = new System.Drawing.Size(152, 17);
            this.CompanyLabel.Text = "沈阳凯悦软件科技有限公司";
            // 
            // sp_1
            // 
            this.sp_1.Name = "sp_1";
            this.sp_1.Size = new System.Drawing.Size(11, 17);
            this.sp_1.Text = "|";
            // 
            // Sys_Time_Label
            // 
            this.Sys_Time_Label.Name = "Sys_Time_Label";
            this.Sys_Time_Label.Size = new System.Drawing.Size(169, 17);
            this.Sys_Time_Label.Text = "当前时间：2019-06-01 10:22";
            // 
            // Sys_User_Label
            // 
            this.Sys_User_Label.Name = "Sys_User_Label";
            this.Sys_User_Label.Size = new System.Drawing.Size(68, 17);
            this.Sys_User_Label.Text = "登陆人员：";
            // 
            // sp_2
            // 
            this.sp_2.Name = "sp_2";
            this.sp_2.Size = new System.Drawing.Size(11, 17);
            this.sp_2.Text = "|";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1330, 787);
            this.Controls.Add(this.ClientStatusStrip);
            this.Controls.Add(this.ClientMenuStrip);
            this.MainMenuStrip = this.ClientMenuStrip;
            this.Name = "MainForm";
            this.Text = "凯悦云餐饮管理系统POS端";
            this.ClientStatusStrip.ResumeLayout(false);
            this.ClientStatusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip ClientMenuStrip;
        private System.Windows.Forms.StatusStrip ClientStatusStrip;
        private System.Windows.Forms.ToolStripStatusLabel Sys_User_Label;
        private System.Windows.Forms.ToolStripStatusLabel sp_1;
        private System.Windows.Forms.ToolStripStatusLabel Sys_Time_Label;
        private System.Windows.Forms.ToolStripStatusLabel sp_2;
        private System.Windows.Forms.ToolStripStatusLabel CompanyLabel;
    }
}