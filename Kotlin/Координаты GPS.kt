//Добавить в манифест
//<uses-permission android:name="android.permission.ACCESS_FINE_LOCATION" />

class MainActivity : AppCompatActivity() {

    @RequiresApi(Build.VERSION_CODES.M)
    override fun onCreate(savedInstanceState: Bundle?) {

        val buttonGps = findViewById<Button>(R.id.buttonGps);
        val textViewG1 = findViewById<TextView>(R.id.textViewG1);
        val textViewG2 = findViewById<TextView>(R.id.textViewG2);

        val manager = getSystemService(Context.LOCATION_SERVICE) as LocationManager

        buttonGps.setOnClickListener {
            if (ActivityCompat.checkSelfPermission(this, Manifest.permission.ACCESS_FINE_LOCATION) != PackageManager.PERMISSION_GRANTED) {
                // Проверка наличия разрешений
                // Если нет разрешения на использование соответсвующих разркешений выполняем какие-то действия
                textViewG1.text = "Нет доступа!"
            }
            else {
                manager.requestLocationUpdates(LocationManager.GPS_PROVIDER,0,0.1f,listener)
            }
        }

    }


val listener: LocationListener = object : LocationListener {
        override fun onLocationChanged(location: Location?) {
            //изменение местоположения. Именно он используется
            // для определения текущих географических координат
            val textViewG1 = findViewById<TextView>(R.id.textViewG1);
            val textViewG2 = findViewById<TextView>(R.id.textViewG2);

            if (location!=null) {
                textViewG1.text = location.getLatitude().toString();
                textViewG2.text = location.getLongitude().toString();
            }
            else{
                textViewG1.text = "Sorry, location";
                textViewG2.text = "unavailable";
            }
        }
        override fun onStatusChanged(provider: String, status: Int, extras: Bundle) {
            //изменение состояния поставщика данных о местоположении. В частности приёмника GPS
        }
        override fun onProviderEnabled(provider: String) {
            //получение доступа к поставщику данных о местоположении
        }
        override fun onProviderDisabled(provider: String) {
            //потеря доступа к поставщику данных о местоположении
        }
    }

}