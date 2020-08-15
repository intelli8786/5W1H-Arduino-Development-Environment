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
    public partial class Form_Function : Form
    {
        public Trigger Result = new Trigger();
        public List<Module> m_moduleList;

        public void Conditions()
        {
            ComboBox f_cbWho = new ComboBox();
            Label f_lbMent = new Label();
            ComboBox f_cbWhen = new ComboBox();
            ComboBox f_cbLogic = new ComboBox();
            ComboBox f_cbAdd = new ComboBox();

            f_cbWho.Size = new System.Drawing.Size(200, 50);
            f_lbMent.Size = new System.Drawing.Size(200, 50);
            f_cbWhen.Size = new System.Drawing.Size(133, 50);
            f_cbLogic.Size = new System.Drawing.Size(133, 50);
            f_cbAdd.Size = new System.Drawing.Size(133, 50);

            f_cbWho.Margin = new System.Windows.Forms.Padding(5);
            f_lbMent.Margin = new System.Windows.Forms.Padding(5);
            f_cbWhen.Margin = new System.Windows.Forms.Padding(5);
            f_cbLogic.Margin = new System.Windows.Forms.Padding(5);
            f_cbAdd.Margin = new System.Windows.Forms.Padding(5);

            f_cbWho.Font = new Font("한컴 윤고딕 230", 20F);
            f_lbMent.Font = new Font("한컴 윤고딕 230", 20F);
            f_cbWhen.Font = new Font("한컴 윤고딕 230", 20F);
            f_cbLogic.Font = new Font("한컴 윤고딕 230", 20F);
            f_cbAdd.Font = new Font("한컴 윤고딕 230", 20F);

            f_cbWho.Location = new System.Drawing.Point(10, 83);
            f_lbMent.Location = new System.Drawing.Point(10, 83);
            f_cbWhen.Location = new System.Drawing.Point(10, 83);
            f_cbLogic.Location = new System.Drawing.Point(10, 83);
            f_cbAdd.Location = new System.Drawing.Point(10, 83);

            f_cbAdd.DropDownStyle = ComboBoxStyle.DropDownList;
            f_cbLogic.DropDownStyle = ComboBoxStyle.DropDownList;
            foreach (Module module in m_moduleList)
            {
                if (module.m_strCondition != null)
                {
                    f_cbWho.Items.Add(module.m_strName);
                }
            }
            f_lbMent.ForeColor = Color.White;
            f_lbMent.Text = "모듈이";
       

            f_cbWho.SelectedIndexChanged += new EventHandler((object sender, EventArgs e) =>
            {
                f_cbWhen.Items.Clear();
                f_cbLogic.Items.Clear();

                foreach (Module module in m_moduleList)
                {
                    if (module.m_strName.Equals(f_cbWho.Text))
                    {
                        if (module.m_strCondition_Type.Equals("HIGH/LOW"))
                        {
                            f_cbWhen.DropDownStyle = ComboBoxStyle.DropDownList;
                            f_cbWhen.Items.Add("HIGH");
                            f_cbWhen.Items.Add("LOW");
                            f_cbWhen.SelectedIndex = 0;

                            
                            f_cbLogic.Items.Add("같은 값");
                            f_cbLogic.Items.Add("다른 값");
                            f_cbLogic.SelectedIndex = 0;
                        }
                        if (module.m_strCondition_Type.Equals("int"))
                        {
                            f_cbWhen.DropDownStyle = ComboBoxStyle.Simple;

                            f_cbLogic.Items.Add("같은 값");
                            f_cbLogic.Items.Add("다른 값");
                            f_cbLogic.Items.Add("이상인 값");
                            f_cbLogic.Items.Add("초과인 값");
                            f_cbLogic.Items.Add("이하인 값");
                            f_cbLogic.Items.Add("미만인 값");
                            f_cbLogic.SelectedIndex = 0;
                        }
                        if (module.m_strCondition_Type.Equals("String"))
                        {
                            f_cbWhen.DropDownStyle = ComboBoxStyle.Simple;
                            f_cbLogic.Items.Add("같은 값");
                            f_cbLogic.Items.Add("다른 값");
                            f_cbLogic.SelectedIndex = 0;
                        }
                    }
                }
            });

            f_cbAdd.Items.Add("일 때");
            f_cbAdd.Items.Add("이거나");
            f_cbAdd.Items.Add("이고");
            f_cbAdd.SelectedIndex = 0;
            f_cbAdd.SelectedIndexChanged += new EventHandler((object sender, EventArgs e) =>
            {
                if (((ComboBox)sender).Text.Equals("이거나") || ((ComboBox)sender).Text.Equals("이고"))
                {
                    int count = m_flpCondition.Controls.Count;
                    int select = m_flpCondition.Controls.IndexOf((ComboBox)sender);

                    if(count == select+1)
                        Conditions();
                  
                }
                if (((ComboBox)sender).Text.Equals("일 때"))
                {
                    int count = m_flpCondition.Controls.Count;
                    int select = m_flpCondition.Controls.IndexOf((ComboBox)sender);
                    for (int i = 0; i < count-select -1; i++)
                    {
                        m_flpCondition.Controls.RemoveAt(select+1);
                    }
                }
            });

            m_flpCondition.Controls.Add(f_cbWho);
            m_flpCondition.Controls.Add(f_lbMent);
            m_flpCondition.Controls.Add(f_cbWhen);
            m_flpCondition.Controls.Add(f_cbLogic);
            m_flpCondition.Controls.Add(f_cbAdd);
        }


        public void Operations()
        {
            ComboBox f_cbWhat = new ComboBox();
            Label f_lbMent = new Label();
            ComboBox f_cbHow = new ComboBox();
            ComboBox f_cbLogic = new ComboBox();
            ComboBox f_cbAdd = new ComboBox();

            f_cbWhat.Size = new System.Drawing.Size(200, 50);
            f_lbMent.Size = new System.Drawing.Size(200, 50);
            f_cbHow.Size = new System.Drawing.Size(133, 50);
            f_cbLogic.Size = new System.Drawing.Size(133, 50);
            f_cbAdd.Size = new System.Drawing.Size(133, 50);

            f_cbWhat.Margin = new System.Windows.Forms.Padding(5);
            f_lbMent.Margin = new System.Windows.Forms.Padding(5);
            f_cbHow.Margin = new System.Windows.Forms.Padding(5);
            f_cbLogic.Margin = new System.Windows.Forms.Padding(5);
            f_cbAdd.Margin = new System.Windows.Forms.Padding(5);

            f_cbWhat.Font = new Font("한컴 윤고딕 230", 20F);
            f_lbMent.Font = new Font("한컴 윤고딕 230", 20F);
            f_cbHow.Font = new Font("한컴 윤고딕 230", 20F);
            f_cbLogic.Font = new Font("한컴 윤고딕 230", 20F);
            f_cbAdd.Font = new Font("한컴 윤고딕 230", 20F);

            f_cbWhat.Location = new System.Drawing.Point(10, 83);
            f_lbMent.Location = new System.Drawing.Point(10, 83);
            f_cbHow.Location = new System.Drawing.Point(10, 83);
            f_cbLogic.Location = new System.Drawing.Point(10, 83);
            f_cbAdd.Location = new System.Drawing.Point(10, 83);

            f_cbAdd.DropDownStyle = ComboBoxStyle.DropDownList;
            f_cbLogic.DropDownStyle = ComboBoxStyle.DropDownList;

            foreach (Module module in m_moduleList)
            {
                if (module.m_strOperation != null)
                {
                    f_cbWhat.Items.Add(module.m_strName);
                }
            }

            f_lbMent.ForeColor = Color.White;
            f_lbMent.Text = "모듈을";
          

            f_cbWhat.SelectedIndexChanged += new EventHandler((object sender, EventArgs e) =>
            {
                f_cbHow.Items.Clear();
                f_cbLogic.Items.Clear();

                foreach (Module module in m_moduleList)
                {
                    if (module.m_strName.Equals(f_cbWhat.Text))
                    {
                        if (module.m_strOperation_Type.Equals("HIGH/LOW"))
                        {
                            f_cbHow.DropDownStyle = ComboBoxStyle.DropDownList;
                            f_cbHow.Items.Add("HIGH");
                            f_cbHow.Items.Add("LOW");
                            f_cbHow.SelectedIndex = 0;

                            f_cbLogic.Items.Add("설정");
                            f_cbLogic.SelectedIndex = 0;
                        }

                        if (module.m_strOperation_Type.Equals("int"))
                        {
                            f_cbHow.DropDownStyle = ComboBoxStyle.Simple;

                            f_cbLogic.Items.Add("설정");
                            f_cbLogic.Items.Add("더하기");
                            f_cbLogic.Items.Add("빼기");
                            f_cbLogic.Items.Add("곱하기");
                            f_cbLogic.Items.Add("나누기");
                            f_cbLogic.SelectedIndex = 0;
                        }

                        if (module.m_strOperation_Type.Equals("String"))
                        {
                            f_cbHow.DropDownStyle = ComboBoxStyle.Simple;
                            f_cbLogic.Items.Add("설정");
                            f_cbLogic.SelectedIndex = 0;
                        }
                    }
                }
            });


            f_cbAdd.Items.Add("한다.");
            f_cbAdd.Items.Add("하고,");
            f_cbAdd.SelectedIndex = 0;
            f_cbAdd.SelectedIndexChanged += new EventHandler((object sender, EventArgs e) =>
            {
                if (((ComboBox)sender).Text.Equals("하고,"))
                {
                    int count = m_flpOperation.Controls.Count;
                    int select = m_flpOperation.Controls.IndexOf((ComboBox)sender);

                    if (count == select + 1)
                        Operations();

                }
                if (((ComboBox)sender).Text.Equals("한다"))
                {
                    int count = m_flpOperation.Controls.Count;
                    int select = m_flpOperation.Controls.IndexOf((ComboBox)sender);

                    for (int i = 0; i < count - select - 1; i++)
                    {
                        m_flpOperation.Controls.RemoveAt(select + 1);
                    }
                }
            });

            m_flpOperation.Controls.Add(f_cbWhat);
            m_flpOperation.Controls.Add(f_lbMent);
            m_flpOperation.Controls.Add(f_cbHow);
            m_flpOperation.Controls.Add(f_cbLogic);
            m_flpOperation.Controls.Add(f_cbAdd);
        }

        public Form_Function(List<Module> f_moduleList)
        {
            m_moduleList = f_moduleList;
            InitializeComponent();
            Conditions();
            Operations();
        }

        private void m_btOK_Click(object sender, EventArgs e)
        {
            if (m_tbName.Text == "")
            {
                MessageBox.Show("기능의 이름을 입력해주세요!");
                return;
            }

            Result.m_strName = m_tbName.Text;

            for (int i = 0 ; i < m_flpCondition.Controls.Count / 5 ; i++ )
            {
                Condition f_condition = new Condition();

                f_condition.m_strWho = m_moduleList.Find(obj => obj.m_strName == m_flpCondition.Controls[0 + 5 * i].Text);
                if (f_condition.m_strWho == null)
                {
                    MessageBox.Show("모듈을 선택해주세요!");
                    return;
                }
                f_condition.m_strWhen = m_flpCondition.Controls[2 + 5 * i].Text;
                if (f_condition.m_strWhen == null)
                {
                    MessageBox.Show("모듈의 행동조건(언제)을 입력해주세요!");
                    return;
                }


                if (m_flpCondition.Controls[3 + 5 * i].Text.Equals("같은 값"))
                    f_condition.Logic = " == ";
                else if (m_flpCondition.Controls[3 + 5 * i].Text.Equals("다른 값"))
                    f_condition.Logic = " != ";
                else if (m_flpCondition.Controls[3 + 5 * i].Text.Equals("이상인 값"))
                    f_condition.Logic = " >= ";
                else if (m_flpCondition.Controls[3 + 5 * i].Text.Equals("이하인 값"))
                    f_condition.Logic = " <= ";
                else if (m_flpCondition.Controls[3 + 5 * i].Text.Equals("초과인 값"))
                    f_condition.Logic = " > ";
                else if (m_flpCondition.Controls[3 + 5 * i].Text.Equals("미만인 값"))
                    f_condition.Logic = " < ";


                if (m_flpCondition.Controls[4 + 5 * i].Text.Equals("이고"))
                    f_condition.m_strAddOperator = " && ";
                else if(m_flpCondition.Controls[4 + 5 * i].Text.Equals("이거나"))
                    f_condition.m_strAddOperator = " || ";
                else 
                    f_condition.m_strAddOperator = " ";

                Result.m_listCondition.Add(f_condition);
            }

            for (int i = 0; i < m_flpOperation.Controls.Count / 5; i++ )
            {
                Operation f_operation = new Operation();

                f_operation.m_strWhat = m_moduleList.Find(obj => obj.m_strName == m_flpOperation.Controls[0 + 5 * i].Text);
                if (f_operation.m_strWhat == null)
                {
                    MessageBox.Show("모듈을 선택해주세요!");
                    return;
                }
                f_operation.m_strHow = m_flpOperation.Controls[2 + 5 * i].Text;
                if (f_operation.m_strHow == null)
                {
                    MessageBox.Show("모듈의 행동조건(어떻게)을 입력해주세요!");
                    return;
                }

                if (m_flpOperation.Controls[3 + 5 * i].Text.Equals("설정"))
                    f_operation.Logic = " = ";
                else if (m_flpOperation.Controls[3 + 5 * i].Text.Equals("더하기"))
                    f_operation.Logic = " += ";
                else if (m_flpOperation.Controls[3 + 5 * i].Text.Equals("빼기"))
                    f_operation.Logic = " -= ";
                else if (m_flpOperation.Controls[3 + 5 * i].Text.Equals("곱하기"))
                    f_operation.Logic = " *= ";
                else if (m_flpOperation.Controls[3 + 5 * i].Text.Equals("나누기"))
                    f_operation.Logic = " /= ";

                Result.m_listOperation.Add(f_operation);
            }

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void m_btCancle_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void Form_Function_Load(object sender, EventArgs e)
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
