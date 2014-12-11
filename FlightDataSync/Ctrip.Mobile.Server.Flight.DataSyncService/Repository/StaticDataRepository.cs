using System;
using System.Collections.Generic;
using System.Linq;
using Ctrip.Mobile.Server.Flight.DataSyncService.Models;

namespace Ctrip.Mobile.Server.Flight.DataSyncService.Repository
{
    internal class StaticDataRepository
    {
        public static List<StaticDataModel> GetSourceData()
        {
            var list = LoadLastestData().Where(a => !a.Disabled).ToList();
            return list;
        }

        private static List<StaticDataModel> LoadLastestData()
        {
            List<StaticDataModel> list = new List<StaticDataModel>();
            list.Add(new StaticDataModel()
            {
                Disabled = false,
                DataVersion = 4,
                DataKey = 32,
                CityName = "迈阿密",
                CityId = "92"
            });
            if (list.Count == 0) throw new Exception("从数据库中加载数据失败！！");
            return list;
        }
    }
}