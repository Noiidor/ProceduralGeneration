using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu()]
public class ShapeSettings : ScriptableObject
{
    public float planetRadius = 10f;
    public NoiseLayer[] noiseLayers;

    [System.Serializable]
    public class NoiseLayer
    {
        public string name;
        public bool enabled = true;
        public bool useFirstLayerAsMask;
        public NoiseSettingsOld noiseSettingsOld;
    }
}
