package com.example.mobilna;

import android.os.Bundle;
import android.widget.Button;
import android.widget.EditText;
import android.widget.TextView;

import androidx.activity.EdgeToEdge;
import androidx.appcompat.app.AppCompatActivity;
import androidx.core.graphics.Insets;
import androidx.core.view.ViewCompat;
import androidx.core.view.WindowInsetsCompat;

import java.util.concurrent.atomic.AtomicBoolean;

public class MainActivity extends AppCompatActivity {

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        EdgeToEdge.enable(this);
        setContentView(R.layout.activity_main);
        ViewCompat.setOnApplyWindowInsetsListener(findViewById(R.id.main), (v, insets) -> {
            Insets systemBars = insets.getInsets(WindowInsetsCompat.Type.systemBars());
            v.setPadding(systemBars.left, systemBars.top, systemBars.right, systemBars.bottom);
            return insets;
        });


        EditText nrPraniaEditText = findViewById(R.id.nrPraniaEditText);
        Button zatwierdzButton = findViewById(R.id.zatwierdzButton);
        TextView nrPraniaText = findViewById(R.id.numer_prania);


        Button wlaczWylaczButton = findViewById(R.id.wlaczWylaczButton);
        TextView odkurzaczWlaczony = findViewById(R.id.odkurzaczWlaczonyWylaczony);
        AtomicBoolean wlaczony = new AtomicBoolean(true);

        zatwierdzButton.setOnClickListener(v -> {
            int nrPrania = Integer.parseInt(nrPraniaEditText.getText().toString());

            if(nrPrania >= 1 && nrPrania <= 12){
                nrPraniaText.setText("Numer prania: " + nrPrania);
            }
        });

        wlaczWylaczButton.setOnClickListener(v -> {
            wlaczony.set(!wlaczony.get());
            if(!wlaczony.get()){
                wlaczWylaczButton.setText("Wyłącz");
                odkurzaczWlaczony.setText("Odkurzacz Włączony");
            }else{
                wlaczWylaczButton.setText("Włącz");
                odkurzaczWlaczony.setText("Odkurzacz wyłączony");
            }
        });
    }
}