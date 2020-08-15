package com.example.fairymac.butlervoicelistener;

import android.content.Intent;
import android.support.v7.app.AppCompatActivity;
import android.os.Bundle;

public class MainActivity extends AppCompatActivity {

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);

        Intent intent = new Intent(
                getApplicationContext(),//현재제어권자
                ButlerService.class); // 이동할 컴포넌트
        startService(intent); // 서비스 시작


    }
}
