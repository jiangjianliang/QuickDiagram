﻿using System;
using System.Collections.Generic;

namespace Codartis.SoftVis.Diagramming.Layout.Incremental
{
    /// <summary>
    /// Comparer used to sort sibling vertices in layers.
    /// </summary>
    internal class VerticesInLayerComparer : IComparer<LayoutVertexBase>
    {
        private readonly IReadOnlyLayoutGraph _layoutGraph;

        public VerticesInLayerComparer(IReadOnlyLayoutGraph layoutGraph)
        {
            _layoutGraph = layoutGraph;
        }

        public int Compare(LayoutVertexBase vertex1, LayoutVertexBase vertex2)
        {
            if (vertex1 == null) throw new ArgumentNullException(nameof(vertex1));
            if (vertex2 == null) throw new ArgumentNullException(nameof(vertex2));

            return string.Compare(GetNameForComparison(vertex1), GetNameForComparison(vertex2),
                StringComparison.InvariantCultureIgnoreCase);
        }

        private string GetNameForComparison(LayoutVertexBase vertex)
        {
            var dummyVertex = vertex as DummyLayoutVertex;
            if (dummyVertex != null)
            {
                var inEdge = _layoutGraph.GetInEdge(dummyVertex);
                if (inEdge == null)
                    throw new InvalidOperationException("Dummy vertex with no in-edge cannot be compared.");
                return GetNameForComparison(inEdge.Source);
            }
            return vertex.Name;
        }
    }
}
