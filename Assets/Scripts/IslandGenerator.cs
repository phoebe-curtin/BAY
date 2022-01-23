using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IslandGenerator : MonoBehaviour
{
    public float numberOfIslands;
    public Transform bottomLeftTrans;
    public Transform topRightTrans;
    public GameObject islandPrefab;

    public Vector3 smallIslandScale;
    public Vector3 mediumIslandScale;
    public Vector3 largeIslandScale;

    void Start ()
    {
        SpawnIslands();
    }

    void SpawnIslands()
    {
        while (numberOfIslands > 0)
        {
            Vector3 spawnPos = new Vector3(Random.Range(bottomLeftTrans.position.x, topRightTrans.position.x), 0.5f, Random.Range(bottomLeftTrans.position.z, topRightTrans.position.z));
            Vector3 spawnScale = Vector3.zero;

            int randomNumber = Random.Range(0, 10);

            if (randomNumber < 3.33f)
                spawnScale = smallIslandScale;
            else if (randomNumber > 3.33f && randomNumber < 7.66f)
                spawnScale = mediumIslandScale;
            else
                spawnScale = largeIslandScale;

            GameObject islandObj = Instantiate(islandPrefab, spawnPos, transform.rotation);

            islandObj.transform.parent = transform.parent;
            islandObj.GetComponent<CapsuleCollider>().radius = Random.Range(0.25f, 0.75f);
            islandObj.GetComponent<Island>().RandomizeSprites();
            islandObj.transform.localScale = spawnScale;
            numberOfIslands--;
        }
    }
}
