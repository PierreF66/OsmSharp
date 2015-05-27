using NUnit.Framework;

namespace OsmSharp.Samples.Test
{
    [TestFixture]
    public class SampleDataLoaderTests
    {
        [Test]
        public void LoadVectorTilesTest()
        {
            // act
            var vectorTiles = SampleDataLoader.LoadVectorTiles();

            // assert
            Assert.AreEqual(vectorTiles.Count, 13);

        }
    }
}
