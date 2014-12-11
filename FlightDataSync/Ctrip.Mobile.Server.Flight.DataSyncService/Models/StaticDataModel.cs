namespace Ctrip.Mobile.Server.Flight.DataSyncService.Models
{
    internal class StaticDataModel
    {
        public bool Disabled { get; set; }
        public int DataVersion { get; set; }
        public int DataKey { get; set; }
        public string CityName { get; set; }
        public string CityId { get; set; }
    }
}