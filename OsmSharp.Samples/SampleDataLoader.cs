using System.Collections.Generic;
using mapnik.vector;
using ProtoBuf;

namespace OsmSharp.Samples
{
    public class SampleDataLoader
    {
        public static List<tile> LoadVectorTiles()
        {
            var result = new List<tile>();

            foreach (var tileFile in GetTileFiles())
            {
                var resource = string.Format("OsmSharp.Samples.Resources.vectortiles.{0}", tileFile);
                var vectorTileStream = typeof(SampleDataLoader).Assembly.GetManifestResourceStream(resource);
                result.Add( Serializer.Deserialize<tile>(vectorTileStream));
            }

            return result;
        }

        private static string[] GetTileFiles()
        {
            return new[]
            {
                "0_0_0_vector.pbf",
                "1_0_0_vector.pbf",
                "1_0_1_vector.pbf",
                "1_1_0_vector.pbf",
                "1_1_1_vector.pbf",
                "2_0_0_vector.pbf",
                "2_0_1_vector.pbf",
                "2_1_0_vector.pbf",
                "2_1_1_vector.pbf",
                "2_2_0_vector.pbf",
                "2_2_1_vector.pbf",
                "2_3_0_vector.pbf",
                "2_3_1_vector.pbf"
            };
        }
    }
}
