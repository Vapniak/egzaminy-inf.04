package com.example.mobilna

import android.os.Bundle
import android.widget.ArrayAdapter
import android.widget.Button
import android.widget.EditText
import android.widget.ListView
import androidx.activity.enableEdgeToEdge
import androidx.appcompat.app.AppCompatActivity
import androidx.core.view.ViewCompat
import androidx.core.view.WindowInsetsCompat

class MainActivity : AppCompatActivity() {
    override fun onCreate(savedInstanceState: Bundle?) {
        super.onCreate(savedInstanceState)
        enableEdgeToEdge()
        setContentView(R.layout.activity_main)
        ViewCompat.setOnApplyWindowInsetsListener(findViewById(R.id.main)) { v, insets ->
            val systemBars = insets.getInsets(WindowInsetsCompat.Type.systemBars())
            v.setPadding(systemBars.left, systemBars.top, systemBars.right, systemBars.bottom)
            insets
        }

        val nowyElementText = findViewById<EditText>(R.id.nowyElementText)
        val dodajButton = findViewById<Button>(R.id.dodajPrzycisk);
        val lista = findViewById<ListView>(R.id.lista);

        var elementy = arrayListOf(
            "Zakupy: chleb, masło, ser",
            "Do zrobienia: obiad, umyć podłogi",
            "weekend: kino, spacer z psem")
        val adapter = ArrayAdapter(this, android.R.layout.simple_list_item_1, elementy);

        lista.adapter = adapter

        dodajButton.setOnClickListener {
            elementy.add(nowyElementText.text.toString())
            adapter.notifyDataSetChanged()
            nowyElementText.text.clear()
        }
    }
}