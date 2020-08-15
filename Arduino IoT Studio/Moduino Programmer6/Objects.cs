using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Moduino_Programmer6
{
    public class Arduino
    {
        public String m_strName;
        public Bitmap m_bmImage;
    }

    public class Pin
    {
        public String m_strName;
        public String m_strPin;
        public String m_strSign;
    }

    public class Param
    {
        public String m_strName;
        public String m_strValue;
        public String m_strSign;
    }

    public class Module
    {
        //객체 정보
        public String m_strName;
        public Bitmap m_bmImage;
        public List<Pin> m_pinList = new List<Pin>();
        public List<Param> m_paramList = new List<Param>();

        //객체 특성 코드
        public String m_strPrethreadedCode; 
        public String m_strInitializationCode;
        public String m_strDeclarationCode;

        //루프 필수 코드
        public String m_strRuntimeCode;

        //조건 정보
        public String m_strCondition;
        public String m_strCondition_Type;

        //명령 정보
        public String m_strOperation;
        public String m_strOperation_Type;

        public Module Clone()
        {
            return (Module)this.MemberwiseClone();
        }
    }

    public class Condition
    {
        public Module m_strWho;
        public String m_strWhen;
        public String Logic;
        public String m_strAddOperator;
    }

    public class Operation
    {
        public Module m_strWhat;
        public String m_strHow;
        public String Logic;
    }

    public class Trigger
    {
        public String m_strName;
        public List<Condition> m_listCondition = new List<Condition>();
        public List<Operation> m_listOperation = new List<Operation>();
    }

    //사용자 작업 객체(무결성을 위해 반환결과만 적용)

    public class WorkObject
    {
        public String m_strFileName;
        public String m_strPort;
        public Arduino m_arduinoSelect;

        public List<Module> m_listModule = new List<Module>();
        public List<Trigger> m_listTrigger = new List<Trigger>();
    }

    //본 시스템이 제공하는 선택리스트(각 폼에 모두 공유)
    public class SystemObjects
    {
        public List<Arduino> m_listArduino = new List<Arduino>();
        public List<Module> m_listModule = new List<Module>();
    }

    public class CommonClass
    {
        public static void ResizeInsert(Button f_btTarget, Bitmap f_bmSource)
        {
            //float Ratio = f_bmSource.Width > f_bmSource.Height ? (float)f_btTarget.Width / f_bmSource.Width : (float)f_btTarget.Height / f_bmSource.Height;

            float Ratio1 = (float)f_btTarget.Width / f_bmSource.Width;
            float Ratio2 = (float)f_btTarget.Height / f_bmSource.Height;
            float RatioResult = Ratio1 < Ratio2 ? Ratio1 : Ratio2;

            f_btTarget.Image = new Bitmap(f_bmSource, (int)(f_bmSource.Width * RatioResult), (int)(f_bmSource.Height * RatioResult));
        }

        public static String Transrate(WorkObject f_workObject)
        {
            String Result = "";

            //전처리부
            foreach(Module t_module in f_workObject.m_listModule)
            {
                if (t_module.m_strPrethreadedCode != "" && t_module.m_strPrethreadedCode != null)
                    Result += t_module.m_strPrethreadedCode + "\n";
            }
            Result += "\n";

             foreach (Module t_module in f_workObject.m_listModule)
            {
                if (t_module.m_strDeclarationCode != "" && t_module.m_strDeclarationCode != null)
                    Result += t_module.m_strDeclarationCode + "\n";
            }
            Result += "\n";

            //초기화부
            Result += "void setup()";
            Result += "\n{\n";

            foreach (Module t_module in f_workObject.m_listModule)
            {
                Result += "\t"+t_module.m_strInitializationCode + "\n";
            }
            Result += "\n}\n";

            //슈퍼루프
            Result += "void loop()";
            Result += "\n{\n";

            //런타임코드 실행부
            foreach (Module t_module in f_workObject.m_listModule)
            {
                if (t_module.m_strRuntimeCode != "" && t_module.m_strRuntimeCode != null)
                    Result += "\t" + t_module.m_strRuntimeCode + "\n";
            }

            //트리거
            foreach(Trigger t_triger in f_workObject.m_listTrigger)
            {
                Result += "\t//" + t_triger.m_strName + "\n";
                Result += "\tif(";
                //조건부
                foreach(Condition t_condition in t_triger.m_listCondition)
                {
                    Result += t_condition.m_strWho.m_strCondition.Replace("#VALUE#", t_condition.m_strWhen).Replace("#LOGIC#", t_condition.Logic);
                    Result += t_condition.m_strAddOperator;
                }
                Result += ")";
                //실행부
                Result += "\n\t{\n";
                foreach (Operation t_operation in t_triger.m_listOperation)
                {
                    Result += "\t\t" + t_operation.m_strWhat.m_strOperation.Replace("#VALUE#", t_operation.m_strHow).Replace("#LOGIC#", t_operation.Logic) + "\n";
                }
                Result += "\t}\n";
            }
            Result += "}\n";

            return Result;
        }
    }
}
