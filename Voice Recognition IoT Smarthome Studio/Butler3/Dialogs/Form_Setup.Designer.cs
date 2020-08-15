namespace Butler3
{
    partial class Form_Setup
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
            this.m_ctrlAccuracy = new System.Windows.Forms.TrackBar();
            this.m_ctrlCallName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.m_ctrlDeleteTrigger = new System.Windows.Forms.Button();
            this.m_ctrlAddTrigger = new System.Windows.Forms.Button();
            this.m_ctrlTriggerList = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.m_ctrlDeleteModule = new System.Windows.Forms.Button();
            this.m_ctrlAddModule = new System.Windows.Forms.Button();
            this.m_ctrlModuleList = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.m_ctrlClose = new System.Windows.Forms.Button();
            this.m_ctrlVoiceIP = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.m_ctrlAccuracy)).BeginInit();
            this.SuspendLayout();
            // 
            // m_ctrlAccuracy
            // 
            this.m_ctrlAccuracy.Location = new System.Drawing.Point(915, 180);
            this.m_ctrlAccuracy.Margin = new System.Windows.Forms.Padding(6);
            this.m_ctrlAccuracy.Maximum = 100;
            this.m_ctrlAccuracy.Name = "m_ctrlAccuracy";
            this.m_ctrlAccuracy.Size = new System.Drawing.Size(546, 90);
            this.m_ctrlAccuracy.TabIndex = 27;
            this.m_ctrlAccuracy.TickFrequency = 10;
            this.m_ctrlAccuracy.Value = 1;
            this.m_ctrlAccuracy.Scroll += new System.EventHandler(this.m_ctrlAccuracy_Scroll);
            // 
            // m_ctrlCallName
            // 
            this.m_ctrlCallName.BackColor = System.Drawing.Color.DimGray;
            this.m_ctrlCallName.Font = new System.Drawing.Font("한컴 윤고딕 230", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.m_ctrlCallName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.m_ctrlCallName.Location = new System.Drawing.Point(47, 180);
            this.m_ctrlCallName.Margin = new System.Windows.Forms.Padding(4);
            this.m_ctrlCallName.Name = "m_ctrlCallName";
            this.m_ctrlCallName.Size = new System.Drawing.Size(310, 67);
            this.m_ctrlCallName.TabIndex = 26;
            this.m_ctrlCallName.TextChanged += new System.EventHandler(this.m_ctrlCallName_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("한컴 윤고딕 230", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.label4.Location = new System.Drawing.Point(926, 122);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(181, 60);
            this.label4.TabIndex = 25;
            this.label4.Text = "인식수준";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("한컴 윤고딕 230", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.label3.Location = new System.Drawing.Point(56, 122);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(142, 60);
            this.label3.TabIndex = 24;
            this.label3.Text = "호출명";
            // 
            // m_ctrlDeleteTrigger
            // 
            this.m_ctrlDeleteTrigger.Font = new System.Drawing.Font("한컴 윤고딕 230", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.m_ctrlDeleteTrigger.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.m_ctrlDeleteTrigger.Location = new System.Drawing.Point(1503, 594);
            this.m_ctrlDeleteTrigger.Margin = new System.Windows.Forms.Padding(4);
            this.m_ctrlDeleteTrigger.Name = "m_ctrlDeleteTrigger";
            this.m_ctrlDeleteTrigger.Size = new System.Drawing.Size(206, 94);
            this.m_ctrlDeleteTrigger.TabIndex = 23;
            this.m_ctrlDeleteTrigger.Text = "명령 삭제";
            this.m_ctrlDeleteTrigger.UseVisualStyleBackColor = true;
            this.m_ctrlDeleteTrigger.Click += new System.EventHandler(this.m_ctrlDeleteTrigger_Click);
            // 
            // m_ctrlAddTrigger
            // 
            this.m_ctrlAddTrigger.Font = new System.Drawing.Font("한컴 윤고딕 230", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.m_ctrlAddTrigger.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.m_ctrlAddTrigger.Location = new System.Drawing.Point(1503, 456);
            this.m_ctrlAddTrigger.Margin = new System.Windows.Forms.Padding(4);
            this.m_ctrlAddTrigger.Name = "m_ctrlAddTrigger";
            this.m_ctrlAddTrigger.Size = new System.Drawing.Size(206, 94);
            this.m_ctrlAddTrigger.TabIndex = 22;
            this.m_ctrlAddTrigger.Text = "명령 추가";
            this.m_ctrlAddTrigger.UseVisualStyleBackColor = true;
            this.m_ctrlAddTrigger.Click += new System.EventHandler(this.m_ctrlAddTrigger_Click);
            // 
            // m_ctrlTriggerList
            // 
            this.m_ctrlTriggerList.BackColor = System.Drawing.Color.DimGray;
            this.m_ctrlTriggerList.Font = new System.Drawing.Font("한컴 윤고딕 230", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.m_ctrlTriggerList.FormattingEnabled = true;
            this.m_ctrlTriggerList.ItemHeight = 52;
            this.m_ctrlTriggerList.Location = new System.Drawing.Point(946, 382);
            this.m_ctrlTriggerList.Margin = new System.Windows.Forms.Padding(4);
            this.m_ctrlTriggerList.Name = "m_ctrlTriggerList";
            this.m_ctrlTriggerList.Size = new System.Drawing.Size(505, 368);
            this.m_ctrlTriggerList.TabIndex = 21;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("한컴 윤고딕 230", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.label2.Location = new System.Drawing.Point(955, 305);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(196, 60);
            this.label2.TabIndex = 20;
            this.label2.Text = "명령 목록";
            // 
            // m_ctrlDeleteModule
            // 
            this.m_ctrlDeleteModule.Font = new System.Drawing.Font("한컴 윤고딕 230", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.m_ctrlDeleteModule.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.m_ctrlDeleteModule.Location = new System.Drawing.Point(602, 594);
            this.m_ctrlDeleteModule.Margin = new System.Windows.Forms.Padding(4);
            this.m_ctrlDeleteModule.Name = "m_ctrlDeleteModule";
            this.m_ctrlDeleteModule.Size = new System.Drawing.Size(206, 94);
            this.m_ctrlDeleteModule.TabIndex = 19;
            this.m_ctrlDeleteModule.Text = "장치 삭제";
            this.m_ctrlDeleteModule.UseVisualStyleBackColor = true;
            this.m_ctrlDeleteModule.Click += new System.EventHandler(this.m_ctrlDeleteModule_Click);
            // 
            // m_ctrlAddModule
            // 
            this.m_ctrlAddModule.Font = new System.Drawing.Font("한컴 윤고딕 230", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.m_ctrlAddModule.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.m_ctrlAddModule.Location = new System.Drawing.Point(602, 456);
            this.m_ctrlAddModule.Margin = new System.Windows.Forms.Padding(4);
            this.m_ctrlAddModule.Name = "m_ctrlAddModule";
            this.m_ctrlAddModule.Size = new System.Drawing.Size(206, 94);
            this.m_ctrlAddModule.TabIndex = 18;
            this.m_ctrlAddModule.Text = "장치 추가";
            this.m_ctrlAddModule.UseVisualStyleBackColor = true;
            this.m_ctrlAddModule.Click += new System.EventHandler(this.m_ctrlAddModule_Click);
            // 
            // m_ctrlModuleList
            // 
            this.m_ctrlModuleList.BackColor = System.Drawing.Color.DimGray;
            this.m_ctrlModuleList.Font = new System.Drawing.Font("한컴 윤고딕 230", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.m_ctrlModuleList.FormattingEnabled = true;
            this.m_ctrlModuleList.ItemHeight = 52;
            this.m_ctrlModuleList.Location = new System.Drawing.Point(47, 382);
            this.m_ctrlModuleList.Margin = new System.Windows.Forms.Padding(4);
            this.m_ctrlModuleList.Name = "m_ctrlModuleList";
            this.m_ctrlModuleList.Size = new System.Drawing.Size(505, 368);
            this.m_ctrlModuleList.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("한컴 윤고딕 230", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.label1.Location = new System.Drawing.Point(56, 305);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(352, 60);
            this.label1.TabIndex = 16;
            this.label1.Text = "블루투스장치 목록";
            // 
            // m_ctrlClose
            // 
            this.m_ctrlClose.Location = new System.Drawing.Point(1635, 23);
            this.m_ctrlClose.Margin = new System.Windows.Forms.Padding(4);
            this.m_ctrlClose.Name = "m_ctrlClose";
            this.m_ctrlClose.Size = new System.Drawing.Size(80, 78);
            this.m_ctrlClose.TabIndex = 15;
            this.m_ctrlClose.UseVisualStyleBackColor = true;
            this.m_ctrlClose.Click += new System.EventHandler(this.m_ctrlClose_Click);
            // 
            // m_ctrlVoiceIP
            // 
            this.m_ctrlVoiceIP.BackColor = System.Drawing.Color.DimGray;
            this.m_ctrlVoiceIP.Font = new System.Drawing.Font("한컴 윤고딕 230", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.m_ctrlVoiceIP.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.m_ctrlVoiceIP.Location = new System.Drawing.Point(426, 180);
            this.m_ctrlVoiceIP.Margin = new System.Windows.Forms.Padding(4);
            this.m_ctrlVoiceIP.Name = "m_ctrlVoiceIP";
            this.m_ctrlVoiceIP.Size = new System.Drawing.Size(417, 67);
            this.m_ctrlVoiceIP.TabIndex = 29;
            this.m_ctrlVoiceIP.TextChanged += new System.EventHandler(this.m_ctrlVoiceIP_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("한컴 윤고딕 230", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.label5.Location = new System.Drawing.Point(435, 122);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(316, 60);
            this.label5.TabIndex = 28;
            this.label5.Text = "음성인식모듈 IP";
            // 
            // Form_Setup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.ClientSize = new System.Drawing.Size(1746, 792);
            this.Controls.Add(this.m_ctrlVoiceIP);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.m_ctrlAccuracy);
            this.Controls.Add(this.m_ctrlCallName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.m_ctrlDeleteTrigger);
            this.Controls.Add(this.m_ctrlAddTrigger);
            this.Controls.Add(this.m_ctrlTriggerList);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.m_ctrlDeleteModule);
            this.Controls.Add(this.m_ctrlAddModule);
            this.Controls.Add(this.m_ctrlModuleList);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.m_ctrlClose);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_Setup";
            this.Padding = new System.Windows.Forms.Padding(20);
            this.Text = "Form_Setup";
            this.Load += new System.EventHandler(this.Form_Setup_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form_Setup_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.m_ctrlAccuracy)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TrackBar m_ctrlAccuracy;
        private System.Windows.Forms.TextBox m_ctrlCallName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button m_ctrlDeleteTrigger;
        private System.Windows.Forms.Button m_ctrlAddTrigger;
        private System.Windows.Forms.ListBox m_ctrlTriggerList;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button m_ctrlDeleteModule;
        private System.Windows.Forms.Button m_ctrlAddModule;
        private System.Windows.Forms.ListBox m_ctrlModuleList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button m_ctrlClose;
        private System.Windows.Forms.TextBox m_ctrlVoiceIP;
        private System.Windows.Forms.Label label5;
    }
}