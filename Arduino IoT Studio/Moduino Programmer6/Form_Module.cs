using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Moduino_Programmer6
{
    public partial class Form_Module : Form
    {
        public Module Selected;
        WorkObject workObject;
        public Form_Module(List<Module> f_moduleList, WorkObject workObject)
        {
            InitializeComponent();
            this.workObject = workObject;
            foreach (Module module in f_moduleList)
            {
                Button f_btCurrentModule = new Button();
                f_btCurrentModule.Name = module.m_strName;
                f_btCurrentModule.Size = new System.Drawing.Size(200, 200);
                f_btCurrentModule.Text = module.m_strName;
                f_btCurrentModule.UseVisualStyleBackColor = true;
                f_btCurrentModule.TextAlign = ContentAlignment.BottomCenter;
                CommonClass.ResizeInsert(f_btCurrentModule, module.m_bmImage);
                m_flpModuleList.Controls.Add(f_btCurrentModule);
                f_btCurrentModule.Click += new System.EventHandler((object sender, EventArgs e) =>
                {
                    Selected = module.Clone();
                    m_flpLabelPin.Controls.Clear();
                    m_flpEditPin.Controls.Clear();

                    Label f_lbName = new Label();
                    f_lbName.Font = new Font("한컴 윤고딕 230", 13F);
                    f_lbName.Name = "Name";
                    f_lbName.Text = "장치 이름";
                    f_lbName.ForeColor = Color.White;
                    f_lbName.Size = new System.Drawing.Size(60, 30);
                    f_lbName.Margin = new System.Windows.Forms.Padding(10);
                    m_flpLabelPin.Controls.Add(f_lbName);

                    TextBox f_tbName = new TextBox();
                    f_tbName.Font = new Font("한컴 윤고딕 230", 13F);
                    f_tbName.Text = Selected.m_strName;
                    f_tbName.Name = "Name";
                    
                    f_tbName.Size = new System.Drawing.Size(140, 30);
                    f_tbName.Margin = new System.Windows.Forms.Padding(5);
                    f_tbName.TextChanged += new System.EventHandler((object sender2, EventArgs e2) =>
                    {
                        Selected.m_strName = f_tbName.Text;
                    });
                    m_flpEditPin.Controls.Add(f_tbName);


                    foreach (Pin pin in Selected.m_pinList)
                    {
                        Label f_lbPin = new Label();
                        f_lbPin.Font = new Font("한컴 윤고딕 230", 13F);
                        f_lbPin.Name = pin.m_strName;
                        f_lbPin.Text = pin.m_strName;
                        f_lbPin.ForeColor = Color.White;
                        f_lbPin.Size = new System.Drawing.Size(140, 30);
                        f_lbPin.Margin = new System.Windows.Forms.Padding(5);
                        m_flpLabelPin.Controls.Add(f_lbPin);

                        TextBox f_tbPin = new TextBox();
                        f_tbPin.Font = new Font("한컴 윤고딕 230", 13F);
                        f_tbPin.Name = pin.m_strName;
                        f_tbPin.Size = new System.Drawing.Size(140, 30);
                        f_tbPin.Margin = new System.Windows.Forms.Padding(5);
                        f_tbPin.TextChanged += new System.EventHandler((object sender2, EventArgs e2) =>
                        {
                            pin.m_strPin = ((TextBox)sender2).Text;
                        });
                        m_flpEditPin.Controls.Add(f_tbPin);
                    }

                    m_flpLabelParam.Controls.Clear();
                    m_flpEditParam.Controls.Clear();
                    foreach (Param param in Selected.m_paramList)
                    {
                        Label f_lbParam = new Label();
                        f_lbParam.Font = new Font("한컴 윤고딕 230", 13F);
                        f_lbParam.Name = param.m_strName;
                        f_lbParam.Text = param.m_strName;
                       
                        f_lbParam.Size = new System.Drawing.Size(140, 30);
                        f_lbParam.Margin = new System.Windows.Forms.Padding(10);
                        m_flpLabelParam.Controls.Add(f_lbParam);

                        TextBox f_tbParam = new TextBox();
                        f_tbParam.Font = new Font("한컴 윤고딕 230", 13F);
                        f_tbParam.Name = param.m_strName;
                        f_tbParam.Size = new System.Drawing.Size(140, 30);
                        f_tbParam.Margin = new System.Windows.Forms.Padding(5);
                        f_tbParam.TextChanged += new System.EventHandler((object sender2, EventArgs e2) =>
                        {
                            param.m_strValue = ((TextBox)sender2).Text;
                        });
                        m_flpEditParam.Controls.Add(f_tbParam);
                    }
                });
            }
        }

        private void m_btOK_Click(object sender, EventArgs e)
        {
            if(workObject.m_listModule.Find(obj => obj.m_strName == Selected.m_strName ) != null)
            {
                MessageBox.Show("동일한 이름의 모듈이 존재합니다!");
                return;
            }


            foreach (Pin t_pin in Selected.m_pinList)
            {
                if (Selected.m_strCondition != null)
                    Selected.m_strCondition = Selected.m_strCondition.Replace(t_pin.m_strSign, t_pin.m_strPin);
                if (Selected.m_strDeclarationCode != null)
                    Selected.m_strDeclarationCode = Selected.m_strDeclarationCode.Replace(t_pin.m_strSign, t_pin.m_strPin);
                if (Selected.m_strInitializationCode != null)
                    Selected.m_strInitializationCode = Selected.m_strInitializationCode.Replace(t_pin.m_strSign, t_pin.m_strPin);
                if (Selected.m_strOperation != null)
                    Selected.m_strOperation =  Selected.m_strOperation.Replace(t_pin.m_strSign, t_pin.m_strPin);
                if (Selected.m_strPrethreadedCode != null)
                    Selected.m_strPrethreadedCode = Selected.m_strPrethreadedCode.Replace(t_pin.m_strSign, t_pin.m_strPin);
                if (Selected.m_strRuntimeCode != null)
                    Selected.m_strRuntimeCode = Selected.m_strRuntimeCode.Replace(t_pin.m_strSign, t_pin.m_strPin);
            }

            foreach (Param t_param in Selected.m_paramList)
            {
                if (Selected.m_strCondition != null)
                    Selected.m_strCondition = Selected.m_strCondition.Replace(t_param.m_strSign, t_param.m_strValue);
                if (Selected.m_strDeclarationCode != null)
                    Selected.m_strDeclarationCode = Selected.m_strDeclarationCode.Replace(t_param.m_strSign, t_param.m_strValue);
                if (Selected.m_strInitializationCode != null)
                    Selected.m_strInitializationCode = Selected.m_strInitializationCode.Replace(t_param.m_strSign, t_param.m_strValue);
                if (Selected.m_strOperation != null)
                    Selected.m_strOperation = Selected.m_strOperation.Replace(t_param.m_strSign, t_param.m_strValue);
                if (Selected.m_strPrethreadedCode != null)
                    Selected.m_strPrethreadedCode = Selected.m_strPrethreadedCode.Replace(t_param.m_strSign, t_param.m_strValue);
                if (Selected.m_strRuntimeCode != null)
                    Selected.m_strRuntimeCode = Selected.m_strRuntimeCode.Replace(t_param.m_strSign, t_param.m_strValue);
            }

            if (Selected.m_strCondition != null)
                Selected.m_strCondition = Selected.m_strCondition.Replace("#NAME#", Selected.m_strName);
            if (Selected.m_strDeclarationCode != null)
                Selected.m_strDeclarationCode = Selected.m_strDeclarationCode.Replace("#NAME#", Selected.m_strName);
            if (Selected.m_strInitializationCode != null)
                Selected.m_strInitializationCode = Selected.m_strInitializationCode.Replace("#NAME#", Selected.m_strName);
            if (Selected.m_strOperation != null)
                Selected.m_strOperation = Selected.m_strOperation.Replace("#NAME#", Selected.m_strName);
            if (Selected.m_strPrethreadedCode != null)
                Selected.m_strPrethreadedCode = Selected.m_strPrethreadedCode.Replace("#NAME#", Selected.m_strName);
            if (Selected.m_strRuntimeCode != null)
                Selected.m_strRuntimeCode = Selected.m_strRuntimeCode.Replace("#NAME#", Selected.m_strName);

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void m_btCancle_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void Form_Module_Load(object sender, EventArgs e)
        {
            CommonClass.ResizeInsert(m_btOK, Properties.Resources.확인);
            m_btOK.FlatStyle = FlatStyle.Flat;
            m_btOK.FlatAppearance.BorderSize = 0;
            m_btOK.FlatAppearance.MouseOverBackColor = Color.Transparent;
            m_btOK.FlatAppearance.MouseDownBackColor = Color.Transparent;

            CommonClass.ResizeInsert(m_btCancle, Properties.Resources.취소);
            m_btCancle.FlatStyle = FlatStyle.Flat;
            m_btCancle.FlatAppearance.BorderSize = 0;
            m_btCancle.FlatAppearance.MouseOverBackColor = Color.Transparent;
            m_btCancle.FlatAppearance.MouseDownBackColor = Color.Transparent;

        }

        private void m_btOK_MouseEnter(object sender, EventArgs e)
        {
            CommonClass.ResizeInsert(m_btOK, Properties.Resources.확인_EnterBT);

        }

        private void m_btOK_MouseLeave(object sender, EventArgs e)
        {
            CommonClass.ResizeInsert(m_btOK, Properties.Resources.확인);
        }



        private void m_btOK_MouseUp(object sender, MouseEventArgs e)
        {
            CommonClass.ResizeInsert(m_btOK, Properties.Resources.확인);

        }

        private void m_btOK_MouseDown(object sender, MouseEventArgs e)
        {
            CommonClass.ResizeInsert(m_btOK, Properties.Resources.확인_EnterBT);

        }

//
        private void m_btCancle_MouseEnter(object sender, EventArgs e)
        {
            CommonClass.ResizeInsert(m_btCancle, Properties.Resources.취소_EnterBT);

        }

        private void m_btCancle_MouseLeave(object sender, EventArgs e)
        {
            CommonClass.ResizeInsert(m_btCancle, Properties.Resources.취소);
        }



        private void m_btCancle_MouseUp(object sender, MouseEventArgs e)
        {
            CommonClass.ResizeInsert(m_btCancle, Properties.Resources.취소);

        }

        private void m_btCancle_MouseDown(object sender, MouseEventArgs e)
        {
            CommonClass.ResizeInsert(m_btCancle, Properties.Resources.취소_EnterBT);

        }

    }
}
