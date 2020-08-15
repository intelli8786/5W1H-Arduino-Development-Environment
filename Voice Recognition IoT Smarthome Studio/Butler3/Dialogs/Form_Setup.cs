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
    public partial class Form_Setup : Form
    {
        LogicManager.Task currentTask;
        public Form_Setup(ref LogicManager.Task currentTask)
        {
            this.currentTask = currentTask;
            InitializeComponent();

            ControlManager.SetupButton(m_ctrlClose, Properties.Resources.closeButton_default, Properties.Resources.closeButton_enter, Properties.Resources.closeButton_down);
            ControlManager.SetupButton(m_ctrlAddModule, Properties.Resources.button_default, Properties.Resources.button_enter, Properties.Resources.button_down);
            ControlManager.SetupButton(m_ctrlDeleteModule, Properties.Resources.button_default, Properties.Resources.button_enter, Properties.Resources.button_down);
            ControlManager.SetupButton(m_ctrlAddTrigger, Properties.Resources.button_default, Properties.Resources.button_enter, Properties.Resources.button_down);
            ControlManager.SetupButton(m_ctrlDeleteTrigger, Properties.Resources.button_default, Properties.Resources.button_enter, Properties.Resources.button_down);

            /*
            foreach (LogicManager.Module f_module in currentTask.moduleList)
            {
                m_ctrlModuleList.Items.Add(f_module.name);
            }*/



            m_ctrlModuleList.DataSource = currentTask.moduleList;
            m_ctrlModuleList.DisplayMember = "name";
            m_ctrlTriggerList.DataSource = currentTask.triggerList;
            m_ctrlTriggerList.DisplayMember = "name";
            UpdateList();
            //m_ctrlModuleList.ValueMember = "port";
        }

        private void Form_Setup_Load(object sender, EventArgs e)
        {
            m_ctrlAccuracy.Value = currentTask.recognitionLevel;
            m_ctrlCallName.Text = currentTask.recognitionName;
            m_ctrlVoiceIP.Text = currentTask.voiceModuleIP;
        }

        private void m_ctrlClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void m_ctrlAddModule_Click(object sender, EventArgs e)
        {
            
            Form_Device f_formModule = new Form_Device(ref currentTask);
            if (f_formModule.ShowDialog() == DialogResult.OK)
            {
                currentTask.moduleList.Add(f_formModule.selected);
                f_formModule.selected.Open();
                UpdateList();
            }
        }

        private void m_ctrlDeleteModule_Click(object sender, EventArgs e)
        {
            LogicManager.Module seleted = (LogicManager.Module)m_ctrlModuleList.SelectedItem;
            seleted.Close();
            currentTask.moduleList.Remove(seleted);
            UpdateList();

            //LogicManager.Module seleted = currentTask.moduleList.Find(obj => obj.name == m_ctrlModuleList.SelectedItem.ToString());
            //seleted.Close();
            //currentTask.moduleList.Remove(seleted);
            //m_ctrlModuleList.Items.Remove(m_ctrlModuleList.SelectedItem);
        }

        private void m_ctrlAddTrigger_Click(object sender, EventArgs e)
        {
            Form_Trigger f_formTrigger = new Form_Trigger(ref currentTask);
            if (f_formTrigger.ShowDialog() == DialogResult.OK)
            {
                currentTask.triggerList.Add(f_formTrigger.selected);
                UpdateList();
            }
        }

        private void m_ctrlDeleteTrigger_Click(object sender, EventArgs e)
        {
            LogicManager.Trigger seleted = (LogicManager.Trigger)m_ctrlTriggerList.SelectedItem;
            currentTask.triggerList.Remove(seleted);
            UpdateList();
        }

        private void UpdateList()
        {
            m_ctrlModuleList.DataSource = null;
            m_ctrlModuleList.DataSource = currentTask.moduleList;
            m_ctrlModuleList.DisplayMember = "name";

            m_ctrlTriggerList.DataSource = null;
            m_ctrlTriggerList.DataSource = currentTask.triggerList;
            m_ctrlTriggerList.DisplayMember = "name";
        }

        private void m_ctrlAccuracy_Scroll(object sender, EventArgs e)
        {
            currentTask.recognitionLevel = m_ctrlAccuracy.Value;
        }

        private void m_ctrlCallName_TextChanged(object sender, EventArgs e)
        {
            currentTask.recognitionName = m_ctrlCallName.Text;
        }

        private void m_ctrlVoiceIP_TextChanged(object sender, EventArgs e)
        {
            currentTask.voiceModuleIP = m_ctrlVoiceIP.Text;
        }

        private void Form_Setup_MouseDown(object sender, MouseEventArgs e)
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
