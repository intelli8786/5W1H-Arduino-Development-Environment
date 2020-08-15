namespace Moduino_Programmer6
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Main));
            this.m_btSelectArduino = new System.Windows.Forms.Button();
            this.m_lbModuleList = new System.Windows.Forms.ListBox();
            this.m_lbFunctionList = new System.Windows.Forms.ListBox();
            this.m_btNewModule = new System.Windows.Forms.Button();
            this.m_btEditModule = new System.Windows.Forms.Button();
            this.m_btDeleteModule = new System.Windows.Forms.Button();
            this.m_btDeleteFunction = new System.Windows.Forms.Button();
            this.m_btEditFunction = new System.Windows.Forms.Button();
            this.m_btNewFunction = new System.Windows.Forms.Button();
            this.m_tbResult = new System.Windows.Forms.TextBox();
            this.m_lbInfo_Arduino = new System.Windows.Forms.Label();
            this.m_lbInfo_Module = new System.Windows.Forms.Label();
            this.m_lbInfo_Operation = new System.Windows.Forms.Label();
            this.m_btUpload = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // m_btSelectArduino
            // 
            this.m_btSelectArduino.Location = new System.Drawing.Point(18, 20);
            this.m_btSelectArduino.Name = "m_btSelectArduino";
            this.m_btSelectArduino.Size = new System.Drawing.Size(306, 190);
            this.m_btSelectArduino.TabIndex = 0;
            this.m_btSelectArduino.UseVisualStyleBackColor = true;
            this.m_btSelectArduino.Click += new System.EventHandler(this.m_btSelectArduino_Click);
            // 
            // m_lbModuleList
            // 
            this.m_lbModuleList.Font = new System.Drawing.Font("한컴 윤고딕 230", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.m_lbModuleList.FormattingEnabled = true;
            this.m_lbModuleList.ItemHeight = 32;
            this.m_lbModuleList.Location = new System.Drawing.Point(18, 257);
            this.m_lbModuleList.Name = "m_lbModuleList";
            this.m_lbModuleList.Size = new System.Drawing.Size(303, 228);
            this.m_lbModuleList.TabIndex = 1;
            // 
            // m_lbFunctionList
            // 
            this.m_lbFunctionList.Font = new System.Drawing.Font("한컴 윤고딕 230", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.m_lbFunctionList.FormattingEnabled = true;
            this.m_lbFunctionList.ItemHeight = 32;
            this.m_lbFunctionList.Location = new System.Drawing.Point(18, 513);
            this.m_lbFunctionList.Name = "m_lbFunctionList";
            this.m_lbFunctionList.Size = new System.Drawing.Size(303, 228);
            this.m_lbFunctionList.TabIndex = 2;
            // 
            // m_btNewModule
            // 
            this.m_btNewModule.BackColor = System.Drawing.Color.Transparent;
            this.m_btNewModule.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.m_btNewModule.Font = new System.Drawing.Font("한컴 윤고딕 230", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.m_btNewModule.ForeColor = System.Drawing.Color.White;
            this.m_btNewModule.Location = new System.Drawing.Point(339, 257);
            this.m_btNewModule.Name = "m_btNewModule";
            this.m_btNewModule.Size = new System.Drawing.Size(130, 55);
            this.m_btNewModule.TabIndex = 3;
            this.m_btNewModule.Text = "장치 추가하기";
            this.m_btNewModule.UseVisualStyleBackColor = false;
            this.m_btNewModule.BackColorChanged += new System.EventHandler(this.m_btNewModule_MouseEnter);
            this.m_btNewModule.Click += new System.EventHandler(this.m_btNewModule_Click);
            this.m_btNewModule.MouseDown += new System.Windows.Forms.MouseEventHandler(this.m_btNewModule_MouseDown);
            this.m_btNewModule.MouseEnter += new System.EventHandler(this.m_btNewModule_MouseEnter);
            this.m_btNewModule.MouseLeave += new System.EventHandler(this.m_btNewModule_MouseLeave);
            this.m_btNewModule.MouseUp += new System.Windows.Forms.MouseEventHandler(this.m_btNewModule_MouseUp);
            // 
            // m_btEditModule
            // 
            this.m_btEditModule.BackColor = System.Drawing.Color.Transparent;
            this.m_btEditModule.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.m_btEditModule.Font = new System.Drawing.Font("한컴 윤고딕 230", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.m_btEditModule.ForeColor = System.Drawing.Color.White;
            this.m_btEditModule.Location = new System.Drawing.Point(339, 330);
            this.m_btEditModule.Name = "m_btEditModule";
            this.m_btEditModule.Size = new System.Drawing.Size(130, 55);
            this.m_btEditModule.TabIndex = 4;
            this.m_btEditModule.Text = "장치 수정하기";
            this.m_btEditModule.UseVisualStyleBackColor = false;
            this.m_btEditModule.MouseDown += new System.Windows.Forms.MouseEventHandler(this.m_btEditModule_MouseDown);
            this.m_btEditModule.MouseEnter += new System.EventHandler(this.m_btEditModule_MouseEnter);
            this.m_btEditModule.MouseLeave += new System.EventHandler(this.m_btEditModule_MouseLeave);
            this.m_btEditModule.MouseUp += new System.Windows.Forms.MouseEventHandler(this.m_btEditModule_MouseUp);
            // 
            // m_btDeleteModule
            // 
            this.m_btDeleteModule.BackColor = System.Drawing.Color.Transparent;
            this.m_btDeleteModule.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.m_btDeleteModule.Font = new System.Drawing.Font("한컴 윤고딕 230", 8.999999F);
            this.m_btDeleteModule.ForeColor = System.Drawing.Color.White;
            this.m_btDeleteModule.Location = new System.Drawing.Point(339, 402);
            this.m_btDeleteModule.Name = "m_btDeleteModule";
            this.m_btDeleteModule.Size = new System.Drawing.Size(130, 55);
            this.m_btDeleteModule.TabIndex = 5;
            this.m_btDeleteModule.Text = "장치 삭제하기";
            this.m_btDeleteModule.UseVisualStyleBackColor = false;
            this.m_btDeleteModule.Click += new System.EventHandler(this.m_btDeleteModule_Click);
            this.m_btDeleteModule.MouseDown += new System.Windows.Forms.MouseEventHandler(this.m_btDeleteModule_MouseDown);
            this.m_btDeleteModule.MouseEnter += new System.EventHandler(this.m_btDeleteModule_MouseEnter);
            this.m_btDeleteModule.MouseLeave += new System.EventHandler(this.m_btDeleteModule_MouseLeave);
            this.m_btDeleteModule.MouseUp += new System.Windows.Forms.MouseEventHandler(this.m_btDeleteModule_MouseUp);
            // 
            // m_btDeleteFunction
            // 
            this.m_btDeleteFunction.BackColor = System.Drawing.Color.Transparent;
            this.m_btDeleteFunction.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.m_btDeleteFunction.Font = new System.Drawing.Font("한컴 윤고딕 230", 9F);
            this.m_btDeleteFunction.ForeColor = System.Drawing.Color.White;
            this.m_btDeleteFunction.Location = new System.Drawing.Point(339, 658);
            this.m_btDeleteFunction.Name = "m_btDeleteFunction";
            this.m_btDeleteFunction.Size = new System.Drawing.Size(130, 55);
            this.m_btDeleteFunction.TabIndex = 8;
            this.m_btDeleteFunction.Text = "기능 삭제하기";
            this.m_btDeleteFunction.UseVisualStyleBackColor = false;
            this.m_btDeleteFunction.Click += new System.EventHandler(this.m_btDeleteFunction_Click);
            this.m_btDeleteFunction.MouseDown += new System.Windows.Forms.MouseEventHandler(this.m_btDeleteFunction_MouseDown);
            this.m_btDeleteFunction.MouseEnter += new System.EventHandler(this.m_btDeleteFunction_MouseEnter);
            this.m_btDeleteFunction.MouseLeave += new System.EventHandler(this.m_btDeleteFunction_MouseLeave);
            this.m_btDeleteFunction.MouseUp += new System.Windows.Forms.MouseEventHandler(this.m_btDeleteFunction_MouseUp);
            // 
            // m_btEditFunction
            // 
            this.m_btEditFunction.BackColor = System.Drawing.Color.Transparent;
            this.m_btEditFunction.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.m_btEditFunction.Font = new System.Drawing.Font("한컴 윤고딕 230", 9F);
            this.m_btEditFunction.ForeColor = System.Drawing.Color.White;
            this.m_btEditFunction.Location = new System.Drawing.Point(339, 587);
            this.m_btEditFunction.Name = "m_btEditFunction";
            this.m_btEditFunction.Size = new System.Drawing.Size(130, 55);
            this.m_btEditFunction.TabIndex = 7;
            this.m_btEditFunction.Text = "기능 수정하기";
            this.m_btEditFunction.UseVisualStyleBackColor = false;
            this.m_btEditFunction.MouseDown += new System.Windows.Forms.MouseEventHandler(this.m_btEditFunction_MouseDown);
            this.m_btEditFunction.MouseEnter += new System.EventHandler(this.m_btEditFunction_MouseEnter);
            this.m_btEditFunction.MouseLeave += new System.EventHandler(this.m_btEditFunction_MouseLeave);
            this.m_btEditFunction.MouseUp += new System.Windows.Forms.MouseEventHandler(this.m_btEditFunction_MouseUp);
            // 
            // m_btNewFunction
            // 
            this.m_btNewFunction.BackColor = System.Drawing.Color.Transparent;
            this.m_btNewFunction.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.m_btNewFunction.Font = new System.Drawing.Font("한컴 윤고딕 230", 9F);
            this.m_btNewFunction.ForeColor = System.Drawing.Color.White;
            this.m_btNewFunction.Location = new System.Drawing.Point(339, 513);
            this.m_btNewFunction.Name = "m_btNewFunction";
            this.m_btNewFunction.Size = new System.Drawing.Size(130, 55);
            this.m_btNewFunction.TabIndex = 6;
            this.m_btNewFunction.Text = "기능 추가하기";
            this.m_btNewFunction.UseVisualStyleBackColor = false;
            this.m_btNewFunction.Click += new System.EventHandler(this.m_btNewFunction_Click);
            this.m_btNewFunction.MouseDown += new System.Windows.Forms.MouseEventHandler(this.m_btNewFunction_MouseDown);
            this.m_btNewFunction.MouseEnter += new System.EventHandler(this.m_btNewFunction_MouseEnter);
            this.m_btNewFunction.MouseLeave += new System.EventHandler(this.m_btNewFunction_MouseLeave);
            this.m_btNewFunction.MouseUp += new System.Windows.Forms.MouseEventHandler(this.m_btNewFunction_MouseUp);
            // 
            // m_tbResult
            // 
            this.m_tbResult.Location = new System.Drawing.Point(586, 20);
            this.m_tbResult.Margin = new System.Windows.Forms.Padding(2);
            this.m_tbResult.Multiline = true;
            this.m_tbResult.Name = "m_tbResult";
            this.m_tbResult.ReadOnly = true;
            this.m_tbResult.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.m_tbResult.Size = new System.Drawing.Size(446, 655);
            this.m_tbResult.TabIndex = 9;
            this.m_tbResult.TextChanged += new System.EventHandler(this.m_tbResult_TextChanged);
            // 
            // m_lbInfo_Arduino
            // 
            this.m_lbInfo_Arduino.AutoSize = true;
            this.m_lbInfo_Arduino.BackColor = System.Drawing.Color.Transparent;
            this.m_lbInfo_Arduino.Font = new System.Drawing.Font("한컴 윤고딕 230", 9F);
            this.m_lbInfo_Arduino.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.m_lbInfo_Arduino.Location = new System.Drawing.Point(351, 36);
            this.m_lbInfo_Arduino.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.m_lbInfo_Arduino.Name = "m_lbInfo_Arduino";
            this.m_lbInfo_Arduino.Size = new System.Drawing.Size(164, 22);
            this.m_lbInfo_Arduino.TabIndex = 10;
            this.m_lbInfo_Arduino.Text = "아두이노를 선택해주세요!";
            // 
            // m_lbInfo_Module
            // 
            this.m_lbInfo_Module.AutoSize = true;
            this.m_lbInfo_Module.BackColor = System.Drawing.Color.Transparent;
            this.m_lbInfo_Module.Font = new System.Drawing.Font("한컴 윤고딕 230", 9F);
            this.m_lbInfo_Module.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.m_lbInfo_Module.Location = new System.Drawing.Point(351, 71);
            this.m_lbInfo_Module.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.m_lbInfo_Module.Name = "m_lbInfo_Module";
            this.m_lbInfo_Module.Size = new System.Drawing.Size(155, 22);
            this.m_lbInfo_Module.TabIndex = 11;
            this.m_lbInfo_Module.Text = "등록된 모듈이 없습니다.";
            // 
            // m_lbInfo_Operation
            // 
            this.m_lbInfo_Operation.AutoSize = true;
            this.m_lbInfo_Operation.BackColor = System.Drawing.Color.Transparent;
            this.m_lbInfo_Operation.Font = new System.Drawing.Font("한컴 윤고딕 230", 9F);
            this.m_lbInfo_Operation.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.m_lbInfo_Operation.Location = new System.Drawing.Point(351, 107);
            this.m_lbInfo_Operation.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.m_lbInfo_Operation.Name = "m_lbInfo_Operation";
            this.m_lbInfo_Operation.Size = new System.Drawing.Size(155, 22);
            this.m_lbInfo_Operation.TabIndex = 12;
            this.m_lbInfo_Operation.Text = "등록된 기능이 없습니다.";
            // 
            // m_btUpload
            // 
            this.m_btUpload.BackColor = System.Drawing.Color.Transparent;
            this.m_btUpload.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.m_btUpload.Location = new System.Drawing.Point(586, 693);
            this.m_btUpload.Margin = new System.Windows.Forms.Padding(2);
            this.m_btUpload.Name = "m_btUpload";
            this.m_btUpload.Size = new System.Drawing.Size(445, 50);
            this.m_btUpload.TabIndex = 13;
            this.m_btUpload.UseVisualStyleBackColor = false;
            this.m_btUpload.Click += new System.EventHandler(this.m_btUpload_Click);
            // 
            // Form_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1060, 756);
            this.Controls.Add(this.m_btUpload);
            this.Controls.Add(this.m_lbInfo_Operation);
            this.Controls.Add(this.m_lbInfo_Module);
            this.Controls.Add(this.m_lbInfo_Arduino);
            this.Controls.Add(this.m_tbResult);
            this.Controls.Add(this.m_btDeleteFunction);
            this.Controls.Add(this.m_btEditFunction);
            this.Controls.Add(this.m_btNewFunction);
            this.Controls.Add(this.m_btDeleteModule);
            this.Controls.Add(this.m_btEditModule);
            this.Controls.Add(this.m_btNewModule);
            this.Controls.Add(this.m_lbFunctionList);
            this.Controls.Add(this.m_lbModuleList);
            this.Controls.Add(this.m_btSelectArduino);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form_Main";
            this.Text = "Moduino Programmer";
            this.Load += new System.EventHandler(this.Form_Main_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button m_btSelectArduino;
        private System.Windows.Forms.ListBox m_lbModuleList;
        private System.Windows.Forms.ListBox m_lbFunctionList;
        private System.Windows.Forms.Button m_btNewModule;
        private System.Windows.Forms.Button m_btEditModule;
        private System.Windows.Forms.Button m_btDeleteModule;
        private System.Windows.Forms.Button m_btDeleteFunction;
        private System.Windows.Forms.Button m_btEditFunction;
        private System.Windows.Forms.Button m_btNewFunction;
        private System.Windows.Forms.TextBox m_tbResult;
        private System.Windows.Forms.Label m_lbInfo_Arduino;
        private System.Windows.Forms.Label m_lbInfo_Module;
        private System.Windows.Forms.Label m_lbInfo_Operation;
        private System.Windows.Forms.Button m_btUpload;
    }
}

