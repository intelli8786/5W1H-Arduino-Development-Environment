namespace Moduino_Programmer6
{
    partial class Form_Arduino
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
            this.m_flpArduinoList = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // m_flpArduinoList
            // 
            this.m_flpArduinoList.BackColor = System.Drawing.Color.White;
            this.m_flpArduinoList.Location = new System.Drawing.Point(-2, 0);
            this.m_flpArduinoList.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.m_flpArduinoList.Name = "m_flpArduinoList";
            this.m_flpArduinoList.Size = new System.Drawing.Size(1223, 647);
            this.m_flpArduinoList.TabIndex = 0;
            // 
            // Form_Arduino
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1178, 632);
            this.Controls.Add(this.m_flpArduinoList);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form_Arduino";
            this.Text = "Form_SelectArduino";
            this.Load += new System.EventHandler(this.Form_Arduino_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel m_flpArduinoList;
    }
}