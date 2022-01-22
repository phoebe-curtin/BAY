using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IslandGenerator : MonoBehaviour
{
    public float numberOfIslands;
    public Transform bottomLeftTrans;
    public Transform topRightTrans;
    public GameObject islandPrefab;

    void Start ()
    {
        SpawnIslands();
    }

    void SpawnIslands()
    {
        while (numberOfIslands > 0)
        {
            Vector3 spawnPos = new Vector3(Random.Range(bottomLeftTrans.position.x, topRightTrans.position.x), 0.5f, Random.Range(bottomLeftTrans.position.z, topRightTrans.position.z));
            GameObject islandObj = Instantiate(islandPrefab, spawnPos, transform.rotation);
            islandObj.transform.parent = transform.parent;
            islandObj.GetComponent<Island>().RandomizeSprites();
            numberOfIslands--;
        }
    }
}
