val button = findViewById<Button>(R.id.button);
val textView = findViewById<TextView>(R.id.textview);

button.setOnClickListener {
    textView.text = "Hello Kitty!"
}