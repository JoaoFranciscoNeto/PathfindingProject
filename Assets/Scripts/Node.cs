using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Pathfinding
{
    public class Node
    {
        public Terrain terrain;
        public Vector3 worldPosition;

        public Node(Terrain _terrain, Vector3 _worldPosition)
        {
            terrain = _terrain;
            worldPosition = _worldPosition;
        }
    }
}
