using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Ctrip.Mobile.Server.Flight.DataSyncService.Test
{
    [TestClass]
    public class StaticRepositoryTest
    {
        [TestMethod, TestCategory("从数据源加载数据")]
        public void LoadSourceData()
        {
            var data = Repository.StaticDataRepository.GetSourceData();  
            Assert.IsNotNull(data);
            Assert.IsTrue(data.Count > 0, "从源数据库中加载数据0条");
            Assert.IsTrue(data[0].CityName == "迈阿密", "从源数据库中加载数据0条");
        }
    }
}
