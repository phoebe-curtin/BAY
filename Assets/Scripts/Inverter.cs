using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inverter : MonoBehaviour
{
    [Header("INVERT")]
    public bool isInverted;

    [Header("MATERIALS")]
    public Material invertMaterial;
    public Material reverseInvertMaterial;

    void Update()
    {
        // testing //
        if (Input.GetKeyDown(KeyCode.Space))
            isInverted = !isInverted;
        // testing //

        invertMaterial.SetFloat("_InvertColors", isInverted ? 1 : 0);
        reverseInvertMaterial.SetFloat("_InvertColors", isInverted ? 0 : 1);
    }
}
