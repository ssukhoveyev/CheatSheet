val buttonNewAct = findViewById<Button>(R.id.buttonNewAct);

buttonNewAct.setOnClickListener {
    val intent = Intent(this@MainActivity, MainActivity2::class.java)
    startActivity(intent);
}