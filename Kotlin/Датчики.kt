//Получить список датчиков
List<Sensor> sensors = sensorManager.getSensorList(Sensor.TYPE_ALL);
List<Sensor> pressureList = sensorManager.getSensorList(Sensor.TYPE_PRESSURE);