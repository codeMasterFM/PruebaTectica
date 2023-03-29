using Db;
using Newtonsoft.Json;
namespace Services
{
    public class ServiceInstrument : IServiceinstrument
    {
        private BitmexContext _context;
        public ServiceInstrument(BitmexContext context)
        {
            _context = context;
        }
        public async Task SaveData(List<Instrument> instrument)
        {
            await _context.Set<Instrument>().AddRangeAsync(instrument);
            await _context.SaveChangesAsync();
        }

        public async Task<object> GetData()
        {
            string url = "https://www.bitmex.com/api/v1/instrument";
            HttpClient httpClient = new HttpClient();
            var result = await httpClient.GetAsync(url);
            if (result.IsSuccessStatusCode)
            {
                var body = await result.Content.ReadAsStringAsync();
                
                 var data = JsonConvert.DeserializeObject<List<Instrument>>(body);
                await SaveData(data);
                return data;
               
            }
            return "No se encontro ningun resultado";
        }
    }

  
}