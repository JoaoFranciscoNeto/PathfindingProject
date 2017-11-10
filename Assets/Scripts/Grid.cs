using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Pathfinding
{

    public class Grid : MonoBehaviour
    {
        Node[,,] grid;
        public Vector3 gridWorldSize;
        public float nodeRadius;

        public List<Terrain> gridTerrains = new List<Terrain>();

        // Use this for initialization
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {

        }

        private void OnDrawGizmos()
        {
            Gizmos.DrawWireCube(transform.position, gridWorldSize);
        }
    }
}

