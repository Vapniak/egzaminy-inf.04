package com.example.mobilna;

import android.os.Bundle;
import android.widget.Button;
import android.widget.ImageView;
import android.widget.TextView;

import androidx.activity.EdgeToEdge;
import androidx.appcompat.app.AppCompatActivity;
import androidx.core.graphics.Insets;
import androidx.core.view.ViewCompat;
import androidx.core.view.WindowInsetsCompat;

import java.util.Random;
import java.util.concurrent.atomic.AtomicInteger;

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

        Button throwDicesButton = findViewById(R.id.throwDicesButton);
        Button resetScoreButton = findViewById(R.id.resetScoreButton);

        int[] diceImages = {
                R.id.dice1,
                R.id.dice2,
                R.id.dice3,
                R.id.dice4,
                R.id.dice5
        };

        int[] diceDrawables = {
                R.drawable.k1,
                R.drawable.k2,
                R.drawable.k3,
                R.drawable.k4,
                R.drawable.k5,
                R.drawable.k6,
        };

        TextView currentScoreText = findViewById(R.id.currentThrowScore);
        TextView currentGameScoreText = findViewById(R.id.currentGameScore);

        AtomicInteger gameScore = new AtomicInteger();


        throwDicesButton.setOnClickListener(v -> {
            Random rand = new Random();

            int[] scores = new int[diceImages.length];

            for (int i = 0; i < diceImages.length; i++) {
                int diceThrow = rand.nextInt(6) + 1;
                scores[i] = diceThrow;

                ImageView image = findViewById(diceImages[i]);
                image.setImageResource(diceDrawables[diceThrow - 1]);
            }

            int[] occurences = new int[7];

            for (int i = 0; i < scores.length; i++) {
                occurences[scores[i]]++;
            }

            int score = 0;
            for (int i = 0; i < occurences.length; i++) {
                if (occurences[i] >= 2) {
                    score += occurences[i] * i;
                }
            }

            gameScore.addAndGet(score);
            currentScoreText.setText("Wynik tego losowania: " + score);
            currentGameScoreText.setText("Wynik gry: " + gameScore.get());
        });


        resetScoreButton.setOnClickListener(v -> {
            gameScore.set(0);

            for(int i = 0; i < diceImages.length; i++){
                ImageView image = findViewById(diceImages[i]);
                image.setImageResource(R.drawable.question);
            }

            currentScoreText.setText("Wynik tego losowania: " + 0);
            currentGameScoreText.setText("Wynik gry: " + 0);
        });
    }
}