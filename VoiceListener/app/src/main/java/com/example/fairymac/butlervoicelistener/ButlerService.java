package com.example.fairymac.butlervoicelistener;

import android.app.Notification;
import android.app.NotificationManager;
import android.app.PendingIntent;
import android.app.Service;
import android.content.Context;
import android.content.Intent;
import android.content.pm.PackageManager;
import android.media.Ringtone;
import android.media.RingtoneManager;
import android.net.Uri;
import android.net.wifi.WifiManager;
import android.os.AsyncTask;
import android.os.Bundle;
import android.os.Handler;
import android.os.IBinder;
import android.os.PowerManager;
import android.os.Vibrator;
import android.speech.RecognitionListener;
import android.speech.RecognizerIntent;
import android.speech.SpeechRecognizer;
import android.support.annotation.Nullable;
import android.util.Log;
import android.widget.Toast;

import java.io.IOException;
import java.net.DatagramPacket;
import java.net.DatagramSocket;
import java.net.InetAddress;
import java.net.SocketException;
import java.util.ArrayList;

/**
 * Created by FairyMac on 2016-10-27.
 */
public class ButlerService extends Service {

    //음성인식객체
    SpeechRecognizer recognizer;
    Intent speechIntent;
    InetAddress address;
    DatagramSocket socket;
    Handler handler;
    Runnable runn;

    static String msg;

    @Nullable
    @Override
    public IBinder onBind(Intent intent) {
        return null;
    }

    @Override
    public void onCreate() {
        recognizer = SpeechRecognizer.createSpeechRecognizer(this);
        recognizer.setRecognitionListener(new VoiceRecognitionListener());


        speechIntent = new Intent(RecognizerIntent.ACTION_RECOGNIZE_SPEECH);
        speechIntent.putExtra(RecognizerIntent.EXTRA_LANGUAGE_MODEL, RecognizerIntent.LANGUAGE_MODEL_FREE_FORM);
        speechIntent.putExtra(RecognizerIntent.EXTRA_CALLING_PACKAGE, "org.androidtown.voice.recognizer");

        handler = new Handler();

        runn = new Runnable() {
            @Override
            public void run() {
                recognizer.startListening(speechIntent);
            }
        };

        WifiManager.WifiLock wifiLock = null;
        //등록
        if (wifiLock == null) {
            WifiManager wifiManager = (WifiManager)getSystemService(Context.WIFI_SERVICE);
            wifiLock = wifiManager.createWifiLock("wifilock");
            wifiLock.setReferenceCounted(true);
            wifiLock.acquire();
        }
        //해제
        if (wifiLock != null) {
            wifiLock.release();
        }


        PowerManager.WakeLock wakeLock = null;
        //등록
        if (wakeLock == null) {
            PowerManager powerManager = (PowerManager)getSystemService(Context.POWER_SERVICE);
            wakeLock = powerManager.newWakeLock(PowerManager.PARTIAL_WAKE_LOCK, "wakelock");
            wakeLock.acquire();
        }
        //해제
        if (wakeLock != null) {
            wakeLock.release();
        }


        final Vibrator vib = (Vibrator)getSystemService(Context.VIBRATOR_SERVICE);

        new Thread(new Runnable() {
            public void run() {


                try {
                    socket = new DatagramSocket(8792);
                } catch (SocketException e) {
                    e.printStackTrace();
                }
                while(true)
                {
                    byte[] buf = new byte[1024];
                    DatagramPacket packet = new DatagramPacket(buf,buf.length);
                    try {
                        socket.receive(packet);
                    } catch (IOException e) {
                        e.printStackTrace();
                    }

                    if(packet != null)
                        address = packet.getAddress();

                    msg = new String(packet.getData(),0,packet.getLength());
                    if(msg.compareTo("1")==0)
                    {
                        handler.post(runn);
                    }
                    else if(msg.compareTo("2")==0)
                    {

                    }
                }

            }
        }).start();


    }



    @Override
    public int onStartCommand(Intent intent, int flags, int startId) {
        Toast.makeText(getApplicationContext(),"스타트",Toast.LENGTH_SHORT).show();
        return super.onStartCommand(intent, flags, startId);
    }

    @Override
    public void onDestroy() {
        Toast.makeText(getApplicationContext(),"디스트로이",Toast.LENGTH_SHORT).show();
        super.onDestroy();
    }

    //음성인식 콜백클래스
    class VoiceRecognitionListener implements RecognitionListener
    {
        @Override
        public void onBeginningOfSpeech() {
        }
        @Override
        public void onBufferReceived(byte[] buffer) {
        }
        @Override
        public void onEndOfSpeech() {
        }
        @Override
        public void onError(int error) {
            switch (error) {
                case SpeechRecognizer.ERROR_AUDIO:
                    Toast.makeText(getApplicationContext(), "오디오 입력중 에러가 발생했어요.", Toast.LENGTH_SHORT).show();
                    Log.d("Fairy", "오디오 입력중 에러가 발생했어요.");
                    break;
                case SpeechRecognizer.ERROR_CLIENT:
                    Toast.makeText(getApplicationContext(), "단말기 에러인것같아요.", Toast.LENGTH_SHORT).show();
                    Log.d("Fairy", "단말기 에러인것같아요.");
                    break;
                case SpeechRecognizer.ERROR_INSUFFICIENT_PERMISSIONS:
                    Toast.makeText(getApplicationContext(), "권한이 없네요...", Toast.LENGTH_SHORT).show();
                    Log.d("Fairy", "권한이 없네요...");
                    break;
                case SpeechRecognizer.ERROR_NETWORK:
                case SpeechRecognizer.ERROR_NETWORK_TIMEOUT:
                    Toast.makeText(getApplicationContext(), "네트워크 에러인것같아요", Toast.LENGTH_SHORT).show();
                    Log.d("Fairy", "네트워크 에러인것같아요");
                    break;
                case SpeechRecognizer.ERROR_NO_MATCH:
                    Toast.makeText(getApplicationContext(), "무슨말씀인지 잘 모르겠어요.", Toast.LENGTH_SHORT).show();
                    Log.d("Fairy", "무슨말씀인지 잘 모르겠어요.");
                    recognizer.startListening(speechIntent);
                    break;
                case SpeechRecognizer.ERROR_RECOGNIZER_BUSY:
                    Toast.makeText(getApplicationContext(), "음성인식서비스가 과부하되었어요.", Toast.LENGTH_SHORT).show();
                    Log.d("Fairy", "음성인식서비스가 과부하되었어요.");
                    break;
                case SpeechRecognizer.ERROR_SERVER:
                    Toast.makeText(getApplicationContext(), "구글서버에서 오류가 발생했어요", Toast.LENGTH_SHORT).show();
                    Log.d("Fairy",  "구글서버에서 오류가 발생했어요");
                    break;
                case SpeechRecognizer.ERROR_SPEECH_TIMEOUT:
                    Toast.makeText(getApplicationContext(), "입력이 없는것같아요.", Toast.LENGTH_SHORT).show();
                    Log.d("Fairy", "입력이 없는것같아요.");
                    recognizer.startListening(speechIntent);
                    break;
            }
        }
        @Override
        public void onEvent(int eventType, Bundle params) {
        }
        @Override
        public void onPartialResults(Bundle partialResults) {
        }
        @Override
        public void onReadyForSpeech(Bundle params) {
        }
        @Override
        public void onResults(Bundle results) {
            ArrayList<String> outStringList = results.getStringArrayList(SpeechRecognizer.RESULTS_RECOGNITION);
            if (outStringList != null)
            {
                String voiceList = "";
                for (int i = 0; i < outStringList.size(); i++)
                {
                    voiceList += outStringList.get(i);
                    voiceList += ",";
                }
                SendMessage("SPEECH:COMMAND:"+voiceList);
                Log.d("Fairy", voiceList);
            }
        }
        @Override
        public void onRmsChanged(float rmsdB) {
        }
    }



    public void SendMessage(final String m_strMessage)
    {
        AsyncTask.execute(new Runnable() {
            @Override
            public void run() {
                byte[] buf = m_strMessage.getBytes();
                try {
                    InetAddress IPAddress = address;
                    DatagramPacket packet = new DatagramPacket(buf, buf.length,IPAddress, 8791);
                    socket.send(packet);
                } catch (IOException e) {
                    e.printStackTrace();
                }
            }
        });
    }
}
