using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

namespace Pathfinding
{
    [Serializable]
    public class Terrain
    {
        public string name;
        public Material associatedMaterial;
        public Color debugColor;

        public Terrain(string _name, Material _material, Color _color)
        {
            name = _name;
            associatedMaterial = _material;
            debugColor = _color;
        }
    }

}