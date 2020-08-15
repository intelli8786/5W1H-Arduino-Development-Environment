namespace Moduino_Programmer6
{
    partial class Form_Function
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Function));
            this.m_btCancle = new System.Windows.Forms.Button();
            this.m_btOK = new System.Windows.Forms.Button();
            this.m_flpCondition = new System.Windows.Forms.FlowLayoutPanel();
            this.m_flpOperation = new System.Windows.Forms.FlowLayoutPanel();
            this.m_tbName = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // m_btCancle
            // 
            this.m_btCancle.BackColor = System.Drawing.Color.Transparent;
            this.m_btCancle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.m_btCancle.Location = new System.Drawing.Point(460, 1385);
            this.m_btCancle.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.m_btCancle.Name = "m_btCancle";
            this.m_btCancle.Size = new System.Drawing.Size(185, 117);
            this.m_btCancle.TabIndex = 7;
            this.m_btCancle.UseVisualStyleBackColor = false;
            this.m_btCancle.Click += new System.EventHandler(this.m_btCancle_Click);
            this.m_btCancle.MouseDown += new System.Windows.Forms.MouseEventHandler(this.m_btCancle_MouseDown);
            this.m_btCancle.MouseEnter += new System.EventHandler(this.m_btCancle_MouseEnter);
            this.m_btCancle.MouseLeave += new System.EventHandler(this.m_btCancle_MouseLeave);
            this.m_btCancle.MouseUp += new System.Windows.Forms.MouseEventHandler(this.m_btCancle_MouseUp);
            // 
            // m_btOK
            // 
            this.m_btOK.BackColor = System.Drawing.Color.Transparent;
            this.m_btOK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.m_btOK.Location = new System.Drawing.Point(250, 1385);
            this.m_btOK.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.m_btOK.Name = "m_btOK";
            this.m_btOK.Size = new System.Drawing.Size(185, 117);
            this.m_btOK.TabIndex = 6;
            this.m_btOK.UseVisualStyleBackColor = false;
            this.m_btOK.Click += new System.EventHandler(this.m_btOK_Click);
            this.m_btOK.MouseDown += new System.Windows.Forms.MouseEventHandler(this.m_btOK_MouseDown);
            this.m_btOK.MouseEnter += new System.EventHandler(this.m_btOK_MouseEnter);
            this.m_btOK.MouseLeave += new System.EventHandler(this.m_btOK_MouseLeave);
            this.m_btOK.MouseUp += new System.Windows.Forms.MouseEventHandler(this.m_btOK_MouseUp);
            // 
            // m_flpCondition
            // 
            this.m_flpCondition.AutoScroll = true;
            this.m_flpCondition.BackColor = System.Drawing.Color.Transparent;
            this.m_flpCondition.Location = new System.Drawing.Point(36, 241);
            this.m_flpCondition.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.m_flpCondition.Name = "m_flpCondition";
            this.m_flpCondition.Size = new System.Drawing.Size(829, 552);
            this.m_flpCondition.TabIndex = 11;
            // 
            // m_flpOperation
            // 
            this.m_flpOperation.AutoScroll = true;
            this.m_flpOperation.BackColor = System.Drawing.Color.Transparent;
            this.m_flpOperation.Location = new System.Drawing.Point(36, 823);
            this.m_flpOperation.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.m_flpOperation.Name = "m_flpOperation";
            this.m_flpOperation.Size = new System.Drawing.Size(829, 552);
            this.m_flpOperation.TabIndex = 12;
            // 
            // m_tbName
            // 
            this.m_tbName.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.m_tbName.Location = new System.Drawing.Point(51, 73);
            this.m_tbName.Name = "m_tbName";
            this.m_tbName.Size = new System.Drawing.Size(751, 68);
            this.m_tbName.TabIndex = 13;
            // 
            // Form_Function
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(885, 1523);
            this.Controls.Add(this.m_tbName);
            this.Controls.Add(this.m_flpOperation);
            this.Controls.Add(this.m_flpCondition);
            this.Controls.Add(this.m_btCancle);
            this.Controls.Add(this.m_btOK);
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "Form_Function";
            this.Text = "Form_Function";
            this.Load += new System.EventHandler(this.Form_Function_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button m_btCancle;
        private System.Windows.Forms.Button m_btOK;
        private System.Windows.Forms.FlowLayoutPanel m_flpCondition;
        private System.Windows.Forms.FlowLayoutPanel m_flpOperation;
        private System.Windows.Forms.TextBox m_tbName;


    }
}