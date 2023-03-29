using Db;

namespace Services
{
    public interface IServiceinstrument
    {
        public Task<object> GetData();
        public Task SaveData(List<Instrument> instrument);

    }
}
