using System.Collections.Generic;
using OsmSharp.UI.Renderer;
using OsmSharp.UI.Renderer.Primitives;

namespace OsmSharp.UI.Map.Layers
{
    class LayerVectorTile : Layer
    {
        public LayerVectorTile(string location, int tileCacheSize)
        {

        }

        protected internal override IEnumerable<Primitive2D> Get(float zoomFactor, View2D view)
        {
            return null;
        }
    }
}
