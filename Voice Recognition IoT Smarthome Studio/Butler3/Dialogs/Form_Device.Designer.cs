namespace Butler3
{
    partial class Form_Device
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
            this.m_ctrlCancel = new System.Windows.Forms.Button();
            this.m_ctrlOK = new System.Windows.Forms.Button();
            this.m_ctrlName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.m_ctrlPort = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.m_ctrlClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // m_ctrlCancel
            // 
            this.m_ctrlCancel.Font = new System.Drawing.Font("한컴 윤고딕 230", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.m_ctrlCancel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.m_ctrlCancel.Location = new System.Drawing.Point(365, 481);
            this.m_ctrlCancel.Margin = new System.Windows.Forms.Padding(4);
            this.m_ctrlCancel.Name = "m_ctrlCancel";
            this.m_ctrlCancel.Size = new System.Drawing.Size(206, 94);
            this.m_ctrlCancel.TabIndex = 15;
            this.m_ctrlCancel.Text = "취소";
            this.m_ctrlCancel.UseVisualStyleBackColor = true;
            this.m_ctrlCancel.Click += new System.EventHandler(this.m_ctrlCancel_Click);
            // 
            // m_ctrlOK
            // 
            this.m_ctrlOK.Font = new System.Drawing.Font("한컴 윤고딕 230", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.m_ctrlOK.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.m_ctrlOK.Location = new System.Drawing.Point(124, 481);
            this.m_ctrlOK.Margin = new System.Windows.Forms.Padding(4);
            this.m_ctrlOK.Name = "m_ctrlOK";
            this.m_ctrlOK.Size = new System.Drawing.Size(206, 94);
            this.m_ctrlOK.TabIndex = 14;
            this.m_ctrlOK.Text = "확인";
            this.m_ctrlOK.UseVisualStyleBackColor = true;
            this.m_ctrlOK.Click += new System.EventHandler(this.m_ctrlOK_Click);
            // 
            // m_ctrlName
            // 
            this.m_ctrlName.BackColor = System.Drawing.Color.DimGray;
            this.m_ctrlName.Font = new System.Drawing.Font("한컴 윤고딕 230", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.m_ctrlName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.m_ctrlName.Location = new System.Drawing.Point(78, 334);
            this.m_ctrlName.Margin = new System.Windows.Forms.Padding(4);
            this.m_ctrlName.Name = "m_ctrlName";
            this.m_ctrlName.Size = new System.Drawing.Size(310, 67);
            this.m_ctrlName.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("한컴 윤고딕 230", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.label2.Location = new System.Drawing.Point(66, 270);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(196, 60);
            this.label2.TabIndex = 12;
            this.label2.Text = "장치 이름";
            // 
            // m_ctrlPort
            // 
            this.m_ctrlPort.BackColor = System.Drawing.Color.DimGray;
            this.m_ctrlPort.Font = new System.Drawing.Font("한컴 윤고딕 230", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.m_ctrlPort.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.m_ctrlPort.FormattingEnabled = true;
            this.m_ctrlPort.Location = new System.Drawing.Point(80, 151);
            this.m_ctrlPort.Margin = new System.Windows.Forms.Padding(4);
            this.m_ctrlPort.Name = "m_ctrlPort";
            this.m_ctrlPort.Size = new System.Drawing.Size(310, 68);
            this.m_ctrlPort.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("한컴 윤고딕 230", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.label1.Location = new System.Drawing.Point(68, 87);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 60);
            this.label1.TabIndex = 10;
            this.label1.Text = "포트";
            // 
            // m_ctrlClose
            // 
            this.m_ctrlClose.Location = new System.Drawing.Point(547, 28);
            this.m_ctrlClose.Margin = new System.Windows.Forms.Padding(4);
            this.m_ctrlClose.Name = "m_ctrlClose";
            this.m_ctrlClose.Size = new System.Drawing.Size(80, 78);
            this.m_ctrlClose.TabIndex = 9;
            this.m_ctrlClose.UseVisualStyleBackColor = true;
            this.m_ctrlClose.Click += new System.EventHandler(this.m_ctrlClose_Click);
            // 
            // Form_Device
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(63)))));
            this.ClientSize = new System.Drawing.Size(656, 620);
            this.Controls.Add(this.m_ctrlCancel);
            this.Controls.Add(this.m_ctrlOK);
            this.Controls.Add(this.m_ctrlName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.m_ctrlPort);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.m_ctrlClose);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_Device";
            this.Text = "Form_Device";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button m_ctrlCancel;
        private System.Windows.Forms.Button m_ctrlOK;
        private System.Windows.Forms.TextBox m_ctrlName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox m_ctrlPort;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button m_ctrlClose;
    }
}