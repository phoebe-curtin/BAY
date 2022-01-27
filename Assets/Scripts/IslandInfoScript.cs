using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IslandInfoScript : MonoBehaviour
{

    public GameObject islandInfoSprite;

    public void TurnOnInfoSprite()
    {
        islandInfoSprite.SetActive(true);
    }
}
