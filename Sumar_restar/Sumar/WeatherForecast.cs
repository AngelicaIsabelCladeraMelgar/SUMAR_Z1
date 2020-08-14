using System;
//ES EL MODELO QUE VA A PASARSE ENTRE LA VISTA
//Y EL CONTROLADOR
//ES LA API?
namespace Sumar
{
    public class WeatherForecast
    {
        public DateTime Date { get; set; }

        public int TemperatureC { get; set; }

        public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);

        public string Summary { get; set; }
    }
}
