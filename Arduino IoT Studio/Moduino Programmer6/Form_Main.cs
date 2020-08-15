using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Moduino_Programmer6
{
    public partial class Form_Main : Form
    {
        public SystemObjects systemObject = new SystemObjects();
        public WorkObject workObject = new WorkObject();
        public Form_Main()
        {
            Arduino m_arduinoUno = new Arduino();
            m_arduinoUno.m_strName = "Uno";
            m_arduinoUno.m_bmImage = Properties.Resources.Arduino_Uno;
            systemObject.m_listArduino.Add(m_arduinoUno);

            Arduino m_arduinoNano = new Arduino();
            m_arduinoNano.m_strName = "Nano";
            m_arduinoNano.m_bmImage = Properties.Resources.Arduino_Nano;
            systemObject.m_listArduino.Add(m_arduinoNano);

            Arduino m_arduinoMicro = new Arduino();
            m_arduinoMicro.m_strName = "Micro";
            m_arduinoMicro.m_bmImage = Properties.Resources.Arduino_Micro;
            systemObject.m_listArduino.Add(m_arduinoMicro);

            Arduino m_arduinoLeonardo = new Arduino();
            m_arduinoLeonardo.m_strName = "Leonardo";
            m_arduinoLeonardo.m_bmImage = Properties.Resources.Arduino_Leonardo;
            systemObject.m_listArduino.Add(m_arduinoLeonardo);

            Arduino m_arduinoLilyPad = new Arduino();
            m_arduinoLilyPad.m_strName = "LilyPad";
            m_arduinoLilyPad.m_bmImage = Properties.Resources.Arduino_LilyPad;
            systemObject.m_listArduino.Add(m_arduinoLilyPad);

            Arduino m_arduinoMega = new Arduino();
            m_arduinoMega.m_strName = "Mega";
            m_arduinoMega.m_bmImage = Properties.Resources.Arduino_Mega;
            systemObject.m_listArduino.Add(m_arduinoMega);

            Arduino m_arduinoPromini = new Arduino();
            m_arduinoPromini.m_strName = "Promini";
            m_arduinoPromini.m_bmImage = Properties.Resources.Arduino_Promini;
            systemObject.m_listArduino.Add(m_arduinoPromini);




            //LED
            Module m_moduleLED = new Module();
            m_moduleLED.m_strName = "LED";
            m_moduleLED.m_bmImage = Properties.Resources.Module_LED;
            Pin m_pinLED1 = new Pin();
            m_pinLED1.m_strSign = "#PIN1#";
            m_pinLED1.m_strName = "양극 핀";
            m_moduleLED.m_pinList.Add(m_pinLED1);
            m_moduleLED.m_strDeclarationCode = "";
            m_moduleLED.m_strInitializationCode = "pinMode(#PIN1#,OUTPUT);";
            m_moduleLED.m_strOperation = "digitalWrite(#PIN1#,#VALUE#);";
            m_moduleLED.m_strOperation_Type = "HIGH/LOW";
            systemObject.m_listModule.Add(m_moduleLED);

            //Button
            Module m_moduleButton = new Module();
            m_moduleButton.m_strName = "Button";
            m_moduleButton.m_bmImage = Properties.Resources.Module_Button;
            Pin m_pinButton1 = new Pin();
            m_pinButton1.m_strSign = "#PIN1#";
            m_pinButton1.m_strName = "음극 핀";
            m_moduleButton.m_pinList.Add(m_pinButton1);
            m_moduleButton.m_strDeclarationCode = "";
            m_moduleButton.m_strInitializationCode = "pinMode(#PIN1#,INPUT);";
            m_moduleButton.m_strCondition = "digitalRead(#PIN1#) #LOGIC# #VALUE#";
            m_moduleButton.m_strCondition_Type = "HIGH/LOW";
            systemObject.m_listModule.Add(m_moduleButton);


            //릴레이
            Module m_moduleRelay = new Module();
            m_moduleRelay.m_strName = "Relay";
            m_moduleRelay.m_bmImage = Properties.Resources.Module_Relay;
            Pin m_pinRelay1 = new Pin();
            m_pinRelay1.m_strSign = "#PIN1#";
            m_pinRelay1.m_strName = "양극 핀";
            m_moduleRelay.m_pinList.Add(m_pinRelay1);
            m_moduleRelay.m_strDeclarationCode = "";
            m_moduleRelay.m_strInitializationCode = "pinMode(#PIN1#,OUTPUT);";
            m_moduleRelay.m_strOperation = "digitalWrite(#PIN1#,#VALUE#);";
            m_moduleRelay.m_strOperation_Type = "HIGH/LOW";
            systemObject.m_listModule.Add(m_moduleRelay);


            //스텝모터
            Module m_moduleStepMoter = new Module();
            m_moduleStepMoter.m_strName = "StepMoter";
            m_moduleStepMoter.m_bmImage = Properties.Resources.Module_StepMoter;
            Param m_paramStepMoter1 = new Param();
            m_paramStepMoter1.m_strSign = "#STEP#";
            m_paramStepMoter1.m_strName = "모터 스텝 수";
            m_moduleStepMoter.m_paramList.Add(m_paramStepMoter1);
            Pin m_pinStepMoter1 = new Pin();
            m_pinStepMoter1.m_strName = "핀1";
            m_pinStepMoter1.m_strSign = "#Pin1#";
            m_moduleStepMoter.m_pinList.Add(m_pinStepMoter1);
            Pin m_pinStepMoter2 = new Pin();
            m_pinStepMoter2.m_strName = "핀2";
            m_pinStepMoter2.m_strSign = "#Pin2#";
            m_moduleStepMoter.m_pinList.Add(m_pinStepMoter2);
            Pin m_pinStepMoter3 = new Pin();
            m_pinStepMoter3.m_strName = "핀3";
            m_pinStepMoter3.m_strSign = "#Pin3#";
            m_moduleStepMoter.m_pinList.Add(m_pinStepMoter3);
            Pin m_pinStepMoter4 = new Pin();
            m_pinStepMoter4.m_strName = "핀4";
            m_pinStepMoter4.m_strSign = "#Pin4#";
            m_moduleStepMoter.m_pinList.Add(m_pinStepMoter4);
            m_moduleStepMoter.m_strDeclarationCode = "#include <Stepper.h>";
            m_moduleStepMoter.m_strInitializationCode = "Stepper Moter1 (#STEP#,#Pin1#,#Pin2#,#Pin3#,#Pin4#);";
            m_moduleStepMoter.m_strOperation = "Moter1.step(#VALUE#);";
            m_moduleStepMoter.m_strOperation_Type = "int";
            systemObject.m_listModule.Add(m_moduleStepMoter);

            //블루투스
            Module m_moduleBluetooth = new Module();
            m_moduleBluetooth.m_strName = "Bluetooth";
            m_moduleBluetooth.m_bmImage = Properties.Resources.Module_Bluetooth;

            Pin m_pinBluetoothTx = new Pin();
            m_pinBluetoothTx.m_strName = "통신핀 - Tx";
            m_pinBluetoothTx.m_strSign = "#Pin1#";
            m_moduleBluetooth.m_pinList.Add(m_pinBluetoothTx);
            Pin m_pinBluetoothRx = new Pin();
            m_pinBluetoothRx.m_strName = "통신핀 - Rx";
            m_pinBluetoothRx.m_strSign = "#Pin2#";
            m_moduleBluetooth.m_pinList.Add(m_pinBluetoothRx);

            m_moduleBluetooth.m_strPrethreadedCode = "#include <SoftwareSerial.h>";
            m_moduleBluetooth.m_strDeclarationCode = "SoftwareSerial blueSerial(#Pin1#, #Pin2#);\nString blueInputStr;";
            m_moduleBluetooth.m_strInitializationCode = "blueSerial.begin(9600);";
            m_moduleBluetooth.m_strRuntimeCode = "while(blueSerial.available())\n\t{\n \t\tchar blueChar = (char)blueSerial.read();\n\t\tif(blueChar == '#')\n\t\t{\n\t\t\tblueInputStr = \"\";\n\t\t\treturn;\n\t\t} \n \t\tblueInputStr+=blueChar;\n\t}";
            m_moduleBluetooth.m_strCondition = "blueInputStr.equals(\"#VALUE#\")";
            m_moduleBluetooth.m_strCondition_Type = "String";
            m_moduleBluetooth.m_strOperation = "blueSerial.print(#VALUE#)";
            m_moduleBluetooth.m_strOperation_Type = "String";
            systemObject.m_listModule.Add(m_moduleBluetooth);

            //7Segment
            Module m_module7Segment = new Module();
            m_module7Segment.m_strName = "7Segment";
            m_module7Segment.m_bmImage = Properties.Resources.Module_7Segment;

            Pin m_pin7Segment_a = new Pin();
            m_pin7Segment_a.m_strName = "음극 핀 - a";
            m_pin7Segment_a.m_strSign = "#Pin1#";
            m_module7Segment.m_pinList.Add(m_pin7Segment_a);
            Pin m_pin7Segment_b = new Pin();
            m_pin7Segment_b.m_strName = "음극 핀 - b";
            m_pin7Segment_b.m_strSign = "#Pin2#";
            m_module7Segment.m_pinList.Add(m_pin7Segment_b);
            Pin m_pin7Segment_c = new Pin();
            m_pin7Segment_c.m_strName = "음극 핀 - c";
            m_pin7Segment_c.m_strSign = "#Pin2#";
            m_module7Segment.m_pinList.Add(m_pin7Segment_c);
            Pin m_pin7Segment_e = new Pin();
            m_pin7Segment_e.m_strName = "음극 핀 - e";
            m_pin7Segment_e.m_strSign = "#Pin2#";
            m_module7Segment.m_pinList.Add(m_pin7Segment_e);
            Param m_pin7Segment_d = new Param();
            m_pin7Segment_d.m_strName = "음극 핀 - d";
            m_pin7Segment_d.m_strSign = "#Pin2#";
            m_module7Segment.m_paramList.Add(m_pin7Segment_d);
            Param m_pin7Segment_f = new Param();
            m_pin7Segment_f.m_strName = "음극 핀 - f";
            m_pin7Segment_f.m_strSign = "#Pin2#";
            m_module7Segment.m_paramList.Add(m_pin7Segment_f);
            Param m_pin7Segment_g = new Param();
            m_pin7Segment_g.m_strName = "음극 핀 - g";
            m_pin7Segment_g.m_strSign = "#Pin2#";
            m_module7Segment.m_paramList.Add(m_pin7Segment_g);
            Param m_pin7Segment_dp = new Param();
            m_pin7Segment_dp.m_strName = "음극 핀 - dp";
            m_pin7Segment_dp.m_strSign = "#Pin2#";
            m_module7Segment.m_paramList.Add(m_pin7Segment_dp);

            systemObject.m_listModule.Add(m_module7Segment);
            

            //시리얼
            Module m_moduleSerial = new Module();
            m_moduleSerial.m_strName = "Serial";
            m_moduleSerial.m_bmImage = Properties.Resources.Module_Serial;
            m_moduleSerial.m_strDeclarationCode = "String serialInputStr;";
            m_moduleSerial.m_strInitializationCode = "Serial.begin(9600);";
            m_moduleSerial.m_strRuntimeCode = "while(Serial.available())\n\t{\n \t\tchar serialChar = (char)Serial.read(); \n \t\tserialInputStr+=serialChar;\n\t}";
            m_moduleSerial.m_strCondition = "serialInputStr.equals(\"#VALUE#\")";
            m_moduleSerial.m_strCondition_Type = "String";
            m_moduleSerial.m_strOperation = "Serial.print(#VALUE#)";
            m_moduleSerial.m_strOperation_Type = "String";
            systemObject.m_listModule.Add(m_moduleSerial);

            //변수
            Module m_moduleInt = new Module();
            m_moduleInt.m_strName = "INT";
            m_moduleInt.m_bmImage = Properties.Resources.Module_Variable;
            m_moduleInt.m_strDeclarationCode = "int #NAME# = 0;";
            m_moduleInt.m_strCondition = "#NAME# #LOGIC# #VALUE#";
            m_moduleInt.m_strCondition_Type = "int";
            m_moduleInt.m_strOperation = "#NAME# #LOGIC# #VALUE#";
            m_moduleInt.m_strOperation_Type = "int";
            systemObject.m_listModule.Add(m_moduleInt);

            //딜레이
            Module m_moduleDelay = new Module();
            m_moduleDelay.m_strName = "Delay";
            m_moduleDelay.m_bmImage = Properties.Resources.Module_Delay;
            m_moduleDelay.m_strOperation = "delay(#VALUE#);";
            m_moduleDelay.m_strOperation_Type = "int";
            systemObject.m_listModule.Add(m_moduleDelay);


            //조도센서
            Module m_modulePhotoResistor = new Module();
            m_modulePhotoResistor.m_strName = "PhotoResistor";
            m_modulePhotoResistor.m_bmImage = Properties.Resources.Module_PhothResister;
            Pin m_pinphotoResistor = new Pin();
            m_pinphotoResistor.m_strSign = "#PIN1#";
            m_pinphotoResistor.m_strName = "아날로그 핀";
            m_modulePhotoResistor.m_pinList.Add(m_pinphotoResistor);
            m_modulePhotoResistor.m_strInitializationCode = "";
            m_modulePhotoResistor.m_strCondition = "analogRead(#PIN1#)#LOGIC##VALUE#";
            m_modulePhotoResistor.m_strCondition_Type = "int";
            systemObject.m_listModule.Add(m_modulePhotoResistor);

            //토양습도센서
            Module m_moduleSoilHumidity = new Module();
            m_moduleSoilHumidity.m_strName = "SoilHumidity";
            m_moduleSoilHumidity.m_bmImage = Properties.Resources.Module_SoilHumidity;
            Pin m_pinsoilHumidity = new Pin();
            m_pinsoilHumidity.m_strSign = "#PIN1#";
            m_pinsoilHumidity.m_strName = "아날로그 핀";
            m_moduleSoilHumidity.m_pinList.Add(m_pinsoilHumidity);
            m_moduleSoilHumidity.m_strInitializationCode = "";
            m_moduleSoilHumidity.m_strCondition = "analogRead(#PIN1#)#LOGIC##VALUE#";
            m_moduleSoilHumidity.m_strCondition_Type = "int";
            systemObject.m_listModule.Add(m_moduleSoilHumidity);

            //Servo
            Module m_moduleServo = new Module();
            m_moduleServo.m_strName = "Servo";
            m_moduleServo.m_bmImage = Properties.Resources.Module_Servo;
            Pin m_pinServo = new Pin();
            m_pinServo.m_strSign = "#PIN1#";
            m_pinServo.m_strName = "음극 핀";
            m_moduleServo.m_pinList.Add(m_pinServo);
            m_moduleServo.m_strPrethreadedCode = "#include <Servo.h>";
            m_moduleServo.m_strDeclarationCode = "Servo myservo;";
            m_moduleServo.m_strInitializationCode = "myservo.attach(#PIN1#,544,2400);";
            m_moduleServo.m_strOperation = "myservo.write(#VALUE#);";
            m_moduleServo.m_strOperation_Type = "int";
            systemObject.m_listModule.Add(m_moduleServo);

            //Pressure -[Fixed:03:42]
            Module m_modulePressure = new Module();
            m_modulePressure.m_strName = "Pressure";
            m_modulePressure.m_bmImage = Properties.Resources.Module_Pressure;
            Pin m_pinPessure = new Pin();
            m_pinPessure.m_strSign = "#PIN1#";
            m_pinPessure.m_strName = "아날로그 핀";
            m_modulePressure.m_pinList.Add(m_pinPessure);
            m_modulePressure.m_strDeclarationCode = "";
            m_modulePressure.m_strInitializationCode = "";
            m_modulePressure.m_strCondition = "analogRead(#PIN1#)#LOGIC##VALUE#";
            m_modulePressure.m_strCondition_Type = "int";
            systemObject.m_listModule.Add(m_modulePressure);

            //Temperature
            Module m_moduleTemperature = new Module();
            m_moduleTemperature.m_strName = "Temperature";
            m_moduleTemperature.m_bmImage = Properties.Resources.Module_Temperature;
            Pin m_pinTemperature = new Pin();
            m_pinTemperature.m_strSign = "#PIN1#";
            m_pinTemperature.m_strName = "VOUT";
            m_moduleTemperature.m_pinList.Add(m_pinTemperature);
            m_moduleTemperature.m_strDeclarationCode = "";
            m_moduleTemperature.m_strInitializationCode = "Serial.begin(9600);";
            m_moduleTemperature.m_strCondition = "TEMPERATURE #LOGIC# #VALUE#";
            m_moduleTemperature.m_strRuntimeCode = "int TEMPERATURE = ((5.0*(analogRead(#PIN1#))*100.0)/1024.0);";
            m_moduleTemperature.m_strCondition_Type = "int";
            systemObject.m_listModule.Add(m_moduleTemperature);

            //Touch Sensor
            Module m_moduleTouch = new Module();
            m_moduleTouch.m_strName = "Touch Sensor";
            m_moduleTouch.m_bmImage = Properties.Resources.Module_Touch;
            Pin m_pinTouch1 = new Pin();
            m_pinTouch1.m_strSign = "#PIN1#";
            m_pinTouch1.m_strName = "핀";
            m_moduleTouch.m_pinList.Add(m_pinTouch1);
            m_moduleTouch.m_strDeclarationCode = "";
            m_moduleTouch.m_strInitializationCode = "pinMode(#PIN1#,INPUT);";
            m_moduleTouch.m_strCondition = "digitalRead(#PIN1#) #LOGIC# #VALUE#";
            m_moduleTouch.m_strCondition_Type = "HIGH/LOW";
            systemObject.m_listModule.Add(m_moduleTouch);

            //Vibration Sensor
            Module m_moduleVibration = new Module();
            m_moduleVibration.m_strName = "Vibration Sensor";
            m_moduleVibration.m_bmImage = Properties.Resources.Module_Vibration;
            Pin m_pinVibration1 = new Pin();
            m_pinVibration1.m_strSign = "#PIN1#";
            m_pinVibration1.m_strName = "핀";
            m_moduleVibration.m_pinList.Add(m_pinVibration1);
            m_moduleVibration.m_strDeclarationCode = "";
            m_moduleVibration.m_strInitializationCode = "pinMode(#PIN1#,INPUT);";
            m_moduleVibration.m_strCondition = "pulseIn(#PIN1#, HIGH) #LOGIC# #VALUE#";
            m_moduleVibration.m_strCondition_Type = "int";
            systemObject.m_listModule.Add(m_moduleVibration);

            //ULTRASONIC SENSOR
            Module m_moduleUltrasonic = new Module();
            m_moduleUltrasonic.m_strName = "Ultra Sensor";
            m_moduleUltrasonic.m_bmImage = Properties.Resources.Module_Ultrasonic;
            Pin m_pinUltrasonic1 = new Pin();
            m_pinUltrasonic1.m_strSign = "#PIN1#";
            m_pinUltrasonic1.m_strName = "echo핀";
            Pin m_pinUltrasonic2 = new Pin();
            m_pinUltrasonic2.m_strSign = "#PIN2#";
            m_pinUltrasonic2.m_strName = "trig핀";
            m_moduleUltrasonic.m_pinList.Add(m_pinUltrasonic1);
            m_moduleUltrasonic.m_pinList.Add(m_pinUltrasonic2);

            m_moduleUltrasonic.m_strDeclarationCode = "float distance = 0;";
            m_moduleUltrasonic.m_strRuntimeCode = "digitalWrite(#PIN2#, HIGH);\n\tdelay(10);\n\tdigitalWrite(#PIN2#, LOW);\n\tdistance = ((float)(340*pulseIn(#PIN1#,HIGH))/10000)/2;";
            m_moduleUltrasonic.m_strInitializationCode = "pinMode(#PIN1#,INPUT);\n\tpinMode(#PIN2#,OUTPUT);";
            m_moduleUltrasonic.m_strCondition = "distance #LOGIC# #VALUE#";
            m_moduleUltrasonic.m_strCondition_Type = "int";
            systemObject.m_listModule.Add(m_moduleUltrasonic);

            //CO2 Sensor
            Module m_moduleCO2 = new Module();
            m_moduleCO2.m_strName = "CO2 Sensor";
            m_moduleCO2.m_bmImage = Properties.Resources.Module_CO2;
            Pin m_pinCO2 = new Pin();
            m_pinCO2.m_strSign = "#PIN1#";
            m_pinCO2.m_strName = "핀";
            m_moduleCO2.m_pinList.Add(m_pinCO2);
            m_moduleCO2.m_strDeclarationCode = "";
            m_moduleCO2.m_strInitializationCode = "Serial.begin(9600);";
            m_moduleCO2.m_strCondition = "analogRead(0) #LOGIC# #VALUE#";
            m_moduleCO2.m_strCondition_Type = "int";
            systemObject.m_listModule.Add(m_moduleCO2);

            //Sound
            Module m_moduleSound = new Module();
            m_moduleSound.m_strName = "Sound";
            m_moduleSound.m_bmImage = Properties.Resources.Module_Sound;
            Pin m_pinSound = new Pin();
            m_pinSound.m_strSign = "#PIN1#";
            m_pinSound.m_strName = "아날로그 핀";
            m_moduleSound.m_pinList.Add(m_pinSound);
            m_moduleSound.m_strInitializationCode = "";
            m_moduleSound.m_strCondition = "analogRead(#PIN1#)#LOGIC##VALUE#";
            m_moduleSound.m_strCondition_Type = "int";
            systemObject.m_listModule.Add(m_moduleSound);


            InitializeComponent();
        }

        private void m_btSelectArduino_Click(object sender, EventArgs e)
        {
            Form_Arduino f_formArduino = new Form_Arduino(systemObject.m_listArduino);
            if(f_formArduino.ShowDialog() == DialogResult.OK)
            {
                workObject.m_arduinoSelect = f_formArduino.Selected;
                CommonClass.ResizeInsert(m_btSelectArduino, workObject.m_arduinoSelect.m_bmImage);
                m_lbInfo_Arduino.Text = "아두이노 타입 : " + f_formArduino.Selected.m_strName;
            }
        }

        private void m_btNewModule_Click(object sender, EventArgs e)
        {
            Form_Module f_formModule = new Form_Module(systemObject.m_listModule,workObject);
            if(f_formModule.ShowDialog() == DialogResult.OK)
            {
                workObject.m_listModule.Add(f_formModule.Selected);
                m_lbModuleList.Items.Add(f_formModule.Selected.m_strName);

                m_tbResult.Text = CommonClass.Transrate(workObject).Replace("\n", "\r\n");
                m_lbInfo_Module.Text = "등록된 모듈 개수 : " + m_lbModuleList.Items.Count;
            }
        }

        private void m_btNewFunction_Click(object sender, EventArgs e)
        {
            Form_Function f_formFunction = new Form_Function(workObject.m_listModule);
            if(f_formFunction.ShowDialog() == DialogResult.OK)
            {
                workObject.m_listTrigger.Add(f_formFunction.Result);
                m_lbFunctionList.Items.Add(f_formFunction.Result.m_strName);

                m_tbResult.Text = CommonClass.Transrate(workObject).Replace("\n","\r\n");
                m_lbInfo_Operation.Text = "등록된 기능 개수 : " + m_lbFunctionList.Items.Count;
            }
        }

        private void m_btDeleteModule_Click(object sender, EventArgs e)
        {
            Module Selected = workObject.m_listModule.Find(obj => obj.m_strName == m_lbModuleList.SelectedItem.ToString());
            workObject.m_listModule.Remove(Selected);
            m_lbModuleList.Items.Remove(m_lbModuleList.SelectedItem);

            m_tbResult.Text = CommonClass.Transrate(workObject).Replace("\n", "\r\n");
            m_lbInfo_Module.Text = "등록된 모듈 개수 : " + m_lbModuleList.Items.Count;
        }

        private void m_btDeleteFunction_Click(object sender, EventArgs e)
        {
            Trigger Selected = workObject.m_listTrigger.Find(obj => obj.m_strName == m_lbFunctionList.SelectedItem.ToString());
            workObject.m_listTrigger.Remove(Selected);
            m_lbFunctionList.Items.Remove(m_lbFunctionList.SelectedItem);

            m_tbResult.Text = CommonClass.Transrate(workObject).Replace("\n", "\r\n");
            m_lbInfo_Operation.Text = "등록된 기능 개수 : " + m_lbFunctionList.Items.Count;
        }

        private void m_btUpload_Click(object sender, EventArgs e)
        {
            StreamWriter sw = new StreamWriter("C:/Users/FairyMac/Desktop/sketch_nov01c/sketch_nov01c.ino");
            sw.Write(CommonClass.Transrate(workObject));
            sw.Close();

            String ArduinoTempDir = "";
            System.IO.DirectoryInfo Info = new System.IO.DirectoryInfo("C:/Users/FairyMac/AppData/Local/Temp");
            if (Info.Exists)
            {
                System.IO.DirectoryInfo[] CInfo = Info.GetDirectories("*", System.IO.SearchOption.AllDirectories);

                foreach (System.IO.DirectoryInfo info in CInfo)
                {
                    if (info.Name.Contains("arduino_build"))
                    {
                        ArduinoTempDir = info.Name;
                    }
                }
            }
            
            Thread.Sleep(300);
            System.Diagnostics.Process.Start(@"C:\Program Files (x86)\Arduino\arduino-builder", "-compile -logger=machine -hardware \"C:/Program Files (x86)/Arduino/hardware\" -tools \"C:/Program Files (x86)/Arduino/tools-builder\" -tools \"C:/Program Files (x86)/Arduino/hardware/tools/avr\" -built-in-libraries \"C:/Program Files (x86)/Arduino/libraries\" -libraries \"C:/Users/FairyMac/Documents/Arduino/libraries\" -fqbn=arduino:avr:uno -vid-pid=0X2A03_0X0043 -ide-version=10609 -build-path \"C:/Users/FairyMac/AppData/Local/Temp/"+ArduinoTempDir+"\" -warnings=all -prefs=build.warn_data_percentage=75 -verbose C:/Users/FairyMac/Desktop/sketch_nov01c/sketch_nov01c.ino");
            
            Thread.Sleep(3300);
            System.Diagnostics.Process.Start(@"C:\Program Files (x86)\Arduino\hardware\tools\avr\bin\avrdude.exe", " -CC:\"/Program Files (x86)/Arduino/hardware/tools/avr/etc/avrdude.conf\" -v -patmega328p -carduino -PCOM3 -b115200 -D -Uflash:w:\"C:/Users/FairyMac/AppData/Local/Temp/" + ArduinoTempDir + "/sketch_nov01c.ino.hex:i\"");
            
            
        }

        private void Form_Main_Load(object sender, EventArgs e)
        {
            
            CommonClass.ResizeInsert(m_btNewModule, Properties.Resources.Black_DefaultBT);
            m_btNewModule.FlatStyle = FlatStyle.Flat;
            m_btNewModule.FlatAppearance.BorderSize = 0;
            m_btNewModule.FlatAppearance.MouseOverBackColor = Color.Transparent;
            m_btNewModule.FlatAppearance.MouseDownBackColor = Color.Transparent;

            CommonClass.ResizeInsert(m_btEditModule, Properties.Resources.Black_DefaultBT);
            m_btEditModule.FlatStyle = FlatStyle.Flat;
            m_btEditModule.FlatAppearance.BorderSize = 0;
            m_btEditModule.FlatAppearance.MouseOverBackColor = Color.Transparent;
            m_btEditModule.FlatAppearance.MouseDownBackColor = Color.Transparent;

            CommonClass.ResizeInsert(m_btDeleteModule, Properties.Resources.Black_DefaultBT);
            m_btDeleteModule.FlatStyle = FlatStyle.Flat;
            m_btDeleteModule.FlatAppearance.BorderSize = 0;
            m_btDeleteModule.FlatAppearance.MouseOverBackColor = Color.Transparent;
            m_btDeleteModule.FlatAppearance.MouseDownBackColor = Color.Transparent;

            CommonClass.ResizeInsert(m_btNewFunction, Properties.Resources.Black_DefaultBT);
            m_btNewFunction.FlatStyle = FlatStyle.Flat;
            m_btNewFunction.FlatAppearance.BorderSize = 0;
            m_btNewFunction.FlatAppearance.MouseOverBackColor = Color.Transparent;
            m_btNewFunction.FlatAppearance.MouseDownBackColor = Color.Transparent;

            CommonClass.ResizeInsert(m_btDeleteFunction, Properties.Resources.Black_DefaultBT);
            m_btDeleteFunction.FlatStyle = FlatStyle.Flat;
            m_btDeleteFunction.FlatAppearance.BorderSize = 0;
            m_btDeleteFunction.FlatAppearance.MouseOverBackColor = Color.Transparent;
            m_btDeleteFunction.FlatAppearance.MouseDownBackColor = Color.Transparent;

            CommonClass.ResizeInsert(m_btEditFunction, Properties.Resources.Black_DefaultBT);
            m_btEditFunction.FlatStyle = FlatStyle.Flat;
            m_btEditFunction.FlatAppearance.BorderSize = 0;
            m_btEditFunction.FlatAppearance.MouseOverBackColor = Color.Transparent;
            m_btEditFunction.FlatAppearance.MouseDownBackColor = Color.Transparent;

            CommonClass.ResizeInsert(m_btUpload, Properties.Resources.업로드);
            m_btUpload.FlatStyle = FlatStyle.Flat;
            m_btUpload.FlatAppearance.BorderSize = 0;
            m_btUpload.FlatAppearance.MouseOverBackColor = Color.Transparent;
            m_btUpload.FlatAppearance.MouseDownBackColor = Color.Transparent;

        }

        private void m_btNewModule_MouseEnter(object sender, EventArgs e)
        {
            CommonClass.ResizeInsert(m_btNewModule, Properties.Resources.Black_EnterBT);  
            
        }

        private void m_btNewModule_MouseLeave(object sender, EventArgs e)
        {
            CommonClass.ResizeInsert(m_btNewModule, Properties.Resources.Black_DefaultBT);
        }



        private void m_btNewModule_MouseUp(object sender, MouseEventArgs e)
        {
            CommonClass.ResizeInsert(m_btNewModule, Properties.Resources.Black_DefaultBT);
           
        }

        private void m_btNewModule_MouseDown(object sender, MouseEventArgs e)
        {
            CommonClass.ResizeInsert(m_btNewModule, Properties.Resources.Black_ClickBT);
            
        }

 //
        private void m_btEditModule_MouseEnter(object sender, EventArgs e)
        {
            CommonClass.ResizeInsert(m_btEditModule, Properties.Resources.Black_EnterBT);

        }

        private void m_btEditModule_MouseLeave(object sender, EventArgs e)
        {
            CommonClass.ResizeInsert(m_btEditModule, Properties.Resources.Black_DefaultBT);
        }



        private void m_btEditModule_MouseUp(object sender, MouseEventArgs e)
        {
            CommonClass.ResizeInsert(m_btEditModule, Properties.Resources.Black_DefaultBT);

        }

        private void m_btEditModule_MouseDown(object sender, MouseEventArgs e)
        {
            CommonClass.ResizeInsert(m_btEditModule, Properties.Resources.Black_ClickBT);

        }
//
        private void m_btDeleteModule_MouseEnter(object sender, EventArgs e)
        {
            CommonClass.ResizeInsert(m_btDeleteModule, Properties.Resources.Black_EnterBT);

        }

        private void m_btDeleteModule_MouseLeave(object sender, EventArgs e)
        {
            CommonClass.ResizeInsert(m_btDeleteModule, Properties.Resources.Black_DefaultBT);
        }



        private void m_btDeleteModule_MouseUp(object sender, MouseEventArgs e)
        {
            CommonClass.ResizeInsert(m_btDeleteModule, Properties.Resources.Black_DefaultBT);

        }

        private void m_btDeleteModule_MouseDown(object sender, MouseEventArgs e)
        {
            CommonClass.ResizeInsert(m_btDeleteModule, Properties.Resources.Black_ClickBT);

        }

//
        private void m_btDeleteFunction_MouseEnter(object sender, EventArgs e)
        {
            CommonClass.ResizeInsert(m_btDeleteFunction, Properties.Resources.Black_EnterBT);

        }

        private void m_btDeleteFunction_MouseLeave(object sender, EventArgs e)
        {
            CommonClass.ResizeInsert(m_btDeleteFunction, Properties.Resources.Black_DefaultBT);
        }



        private void m_btDeleteFunction_MouseUp(object sender, MouseEventArgs e)
        {
            CommonClass.ResizeInsert(m_btDeleteFunction, Properties.Resources.Black_DefaultBT);

        }

        private void m_btDeleteFunction_MouseDown(object sender, MouseEventArgs e)
        {
            CommonClass.ResizeInsert(m_btDeleteFunction, Properties.Resources.Black_ClickBT);

        }

//
        private void m_btEditFunction_MouseEnter(object sender, EventArgs e)
        {
            CommonClass.ResizeInsert(m_btEditFunction, Properties.Resources.Black_EnterBT);

        }

        private void m_btEditFunction_MouseLeave(object sender, EventArgs e)
        {
            CommonClass.ResizeInsert(m_btEditFunction, Properties.Resources.Black_DefaultBT);
        }



        private void m_btEditFunction_MouseUp(object sender, MouseEventArgs e)
        {
            CommonClass.ResizeInsert(m_btEditFunction, Properties.Resources.Black_DefaultBT);

        }

        private void m_btEditFunction_MouseDown(object sender, MouseEventArgs e)
        {
            CommonClass.ResizeInsert(m_btEditFunction, Properties.Resources.Black_ClickBT);

        }

//
        private void m_btNewFunction_MouseEnter(object sender, EventArgs e)
        {
            CommonClass.ResizeInsert(m_btNewFunction, Properties.Resources.Black_EnterBT);

        }

        private void m_btNewFunction_MouseLeave(object sender, EventArgs e)
        {
            CommonClass.ResizeInsert(m_btNewFunction, Properties.Resources.Black_DefaultBT);
        }



        private void m_btNewFunction_MouseUp(object sender, MouseEventArgs e)
        {
            CommonClass.ResizeInsert(m_btNewFunction, Properties.Resources.Black_DefaultBT);

        }

        private void m_btNewFunction_MouseDown(object sender, MouseEventArgs e)
        {
            CommonClass.ResizeInsert(m_btNewFunction, Properties.Resources.Black_ClickBT);

        }

        private void m_tbResult_TextChanged(object sender, EventArgs e)
        {

        }



    }
}
