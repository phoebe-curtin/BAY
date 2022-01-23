using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IslandMouseTrigger : MonoBehaviour
{
    public GameObject islandNameParent;

    void OnMouseEnter ()
    {
        islandNameParent.SetActive(true);
    }

    void OnMouseExit ()
    {
        islandNameParent.SetActive(false);
    }
}
