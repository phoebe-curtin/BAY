using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inverter : MonoBehaviour
{
    public bool invert;
    public Material invertMaterial;
    public Material reverseInvertMaterial;

    void Update()
    {
        invertMaterial.SetFloat("_InvertColors", invert ? 1 : 0);
        reverseInvertMaterial.SetFloat("_InvertColors", invert ? 0 : 1);
    }
}
