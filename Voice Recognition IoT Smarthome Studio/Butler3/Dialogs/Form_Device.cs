using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Butler3
{
    public partial class Form_Device : Form
    {
        LogicManager.Task currentTask;
        public LogicManager.Module selected;
        public Form_Device(ref LogicManager.Task currentTask)
        {
            this.currentTask = currentTask;
            InitializeComponent();

            ControlManager.SetupButton(m_ctrlClose, Properties.Resources.closeButton_default, Properties.Resources.closeButton_enter, Properties.Resources.closeButton_down);
            ControlManager.SetupButton(m_ctrlOK, Properties.Resources.button_default, Properties.Resources.button_enter, Properties.Resources.button_down);
            ControlManager.SetupButton(m_ctrlCancel, Properties.Resources.button_default, Properties.Resources.button_enter, Properties.Resources.button_down);

            string[] ports = SerialPort.GetPortNames();
            foreach (string port in ports)
            {
                m_ctrlPort.Items.Add(port);
            }

            if(m_ctrlPort.Items.Count>0)
                m_ctrlPort.SelectedIndex = 0;
        }

        private void m_ctrlClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void m_ctrlOK_Click(object sender, EventArgs e)
        {
            if (m_ctrlName.Text == "")
            {
                MessageBox.Show("장치의 이름을 입력해주세요!");
                return;
            }
            selected = new LogicManager.Module();
            selected.name = m_ctrlName.Text;
            selected.port = m_ctrlPort.Text;

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void m_ctrlCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
