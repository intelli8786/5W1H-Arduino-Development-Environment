using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Butler3
{
    public partial class Form_Trigger : Form
    {
        LogicManager.Task currentTask;
        public LogicManager.Trigger selected;
        public Form_Trigger(ref LogicManager.Task currentTask)
        {
            this.currentTask = currentTask;
            InitializeComponent();

            ControlManager.SetupButton(m_ctrlClose, Properties.Resources.closeButton_default, Properties.Resources.closeButton_enter, Properties.Resources.closeButton_down);
            ControlManager.SetupButton(m_ctrlOK, Properties.Resources.button_default, Properties.Resources.button_enter, Properties.Resources.button_down);
            ControlManager.SetupButton(m_ctrlCancel, Properties.Resources.button_default, Properties.Resources.button_enter, Properties.Resources.button_down);

            m_ctrlWho.Items.Add("음성인식");
            m_ctrlWhat.Items.Add("실행");

            foreach (LogicManager.Module f_device in currentTask.moduleList)
            {
                m_ctrlWho.Items.Add(f_device.name);
                m_ctrlWhat.Items.Add(f_device.name);
            }

            if (m_ctrlWho.Items.Count > 0)
                m_ctrlWho.SelectedIndex = 0;
            if (m_ctrlWhat.Items.Count > 0)
                m_ctrlWhat.SelectedIndex = 0;
        }

        private void m_ctrlOK_Click(object sender, EventArgs e)
        {
            if (m_ctrlName.Text == "")
            {
                MessageBox.Show("장치의 이름을 입력해주세요!");
                return;
            }

            selected = new LogicManager.Trigger();
            selected.name = m_ctrlName.Text;

            selected.m_condition.who = m_ctrlWho.Text;
            selected.m_condition.when = m_ctrlWhen.Text;
            selected.m_operation.what = m_ctrlWhat.Text;
            selected.m_operation.how = m_ctrlHow.Text;

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void m_ctrlCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void m_ctrlClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form_Trigger_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                // 다른 컨트롤에 묶여있을 수 있을 수 있으므로 마우스캡쳐 해제
                Win32API.ReleaseCapture();
                // 타이틀 바의 다운 이벤트처럼 보냄
                Win32API.SendMessage(this.Handle, 0xA1, 0x2, 0);
            }
        }
    }
}
