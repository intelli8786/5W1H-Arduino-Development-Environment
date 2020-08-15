namespace Butler3
{
    partial class Form_Main
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다.
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마십시오.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Main));
            this.m_ctrlTrayIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.m_ctrlTrayMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.설정ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.종료ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.m_ctrlTrayMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // m_ctrlTrayIcon
            // 
            this.m_ctrlTrayIcon.ContextMenuStrip = this.m_ctrlTrayMenu;
            this.m_ctrlTrayIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("m_ctrlTrayIcon.Icon")));
            this.m_ctrlTrayIcon.Text = "Butler";
            this.m_ctrlTrayIcon.Visible = true;
            // 
            // m_ctrlTrayMenu
            // 
            this.m_ctrlTrayMenu.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.m_ctrlTrayMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.설정ToolStripMenuItem,
            this.종료ToolStripMenuItem});
            this.m_ctrlTrayMenu.Name = "m_ctrlTrayMenu";
            this.m_ctrlTrayMenu.Size = new System.Drawing.Size(164, 80);
            // 
            // 설정ToolStripMenuItem
            // 
            this.설정ToolStripMenuItem.Name = "설정ToolStripMenuItem";
            this.설정ToolStripMenuItem.Size = new System.Drawing.Size(269, 38);
            this.설정ToolStripMenuItem.Text = "설정";
            this.설정ToolStripMenuItem.Click += new System.EventHandler(this.설정ToolStripMenuItem_Click);
            // 
            // 종료ToolStripMenuItem
            // 
            this.종료ToolStripMenuItem.Name = "종료ToolStripMenuItem";
            this.종료ToolStripMenuItem.Size = new System.Drawing.Size(269, 38);
            this.종료ToolStripMenuItem.Text = "종료";
            this.종료ToolStripMenuItem.Click += new System.EventHandler(this.종료ToolStripMenuItem_Click);
            // 
            // Form_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(274, 229);
            this.Name = "Form_Main";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form_Main_FormClosing);
            this.Load += new System.EventHandler(this.Form_Main_Load);
            this.m_ctrlTrayMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.NotifyIcon m_ctrlTrayIcon;
        private System.Windows.Forms.ContextMenuStrip m_ctrlTrayMenu;
        private System.Windows.Forms.ToolStripMenuItem 설정ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 종료ToolStripMenuItem;
    }
}

