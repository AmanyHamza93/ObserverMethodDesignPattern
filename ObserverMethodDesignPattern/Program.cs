using ObserverMethodDesignPattern;

WeatherStation weatherStation = new WeatherStation();

DisplayDevice mobileApp = new DisplayDevice("Mobile App");
DisplayDevice website = new DisplayDevice("Website");
DisplayDevice dedicatedDevice = new DisplayDevice("Dedicated Device");

weatherStation.AddObserver(mobileApp);
weatherStation.AddObserver(website);
weatherStation.AddObserver(dedicatedDevice);

weatherStation.SetWeather("Sunny");
weatherStation.SetWeather("Rainy");
