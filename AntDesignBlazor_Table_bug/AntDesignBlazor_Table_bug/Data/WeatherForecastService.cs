namespace AntDesignBlazor_Table_bug.Data
{
    public class WeatherForecastService
    {
        private static readonly string[] Summaries = new[]
        {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private static readonly string[] Columns1 = new[]
        {
            "lict",
            "clearlytic",
            "emesisibility",
            "pango",
            "falcior",
            "greenard",
            "power",
            "shoot",
            "answerance",
            "contretrouble"
        };

        private static readonly string[] Columns2 = new[]
        {
            "budgetion",
            "archaion",
            "civilacle",
            "significantous",
            "capt",
            "aboveaneity",
            "oligoade",
            "allel",
            "plagiise",
            "technologyor",
        };
        private static readonly string[] Columns3 = new[]
        {
            "bissome",
            "mixtful",
            "publicupon",
            "customeratory",
            "floorite",
            "meterfication",
            "tactward",
            "scandster",
            "cacoing",
            "meritery",
        };
        private static readonly string[] Columns4 = new[]
        {
            "pathetlet",
            "tepling",
            "nonagenitious",
            "fundhood",
            "studentture",
            "ostracsmallfaction",
            "mollate",
            "heliserviceitious",
            "velleur",
            "menfaction",
        };
        public Task<WeatherForecast[]> GetForecastAsync(DateTime startDate)
        {
            return Task.FromResult(Enumerable.Range(1, 50).Select(index => new WeatherForecast
            {
                Date = startDate.AddDays(index),
                TemperatureC = Random.Shared.Next(-20, 55),
                TemperatureF = Random.Shared.Next(-40, 88),
                Column1 = Columns1[Random.Shared.Next(Columns1.Length)],
                Column2 = Columns2[Random.Shared.Next(Columns2.Length)],
                Column3 = Columns3[Random.Shared.Next(Columns3.Length)],
                Column4 = Columns4[Random.Shared.Next(Columns4.Length)],
                Summary = Summaries[Random.Shared.Next(Summaries.Length)]
            }).ToArray());
        }
    }
}