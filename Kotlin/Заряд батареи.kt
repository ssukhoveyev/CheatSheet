fun getBatteryLevel(): Float {
	val batteryIntent = registerReceiver(null, IntentFilter(Intent.ACTION_BATTERY_CHANGED))
	val level = batteryIntent!!.getIntExtra(BatteryManager.EXTRA_LEVEL, -1)
	val scale = batteryIntent.getIntExtra(BatteryManager.EXTRA_SCALE, -1)

	// Error checking that probably isn't needed but I added just in case.
	return if (level == -1 || scale == -1) {
		50.0f
	} else level.toFloat() / scale.toFloat() * 100.0f
}