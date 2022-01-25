using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Island : MonoBehaviour
{
    [Header("SPRITES")]
    public Sprite[] mainSprites;
    public Sprite[] secondarySprites;
    public Sprite[] detailSprites;

    public SpriteRenderer mainRenderer;
    public SpriteRenderer secondaryRenderer;
    public SpriteRenderer detailRenderer;

    public GameObject islandNameParent;

    void Awake()
    {
        MakeRandomName();
        islandNameParent.SetActive(false);
    }

    public void RandomizeSprites ()
    {
        mainRenderer.sprite = mainSprites[Random.Range(0, mainSprites.Length)];
        secondaryRenderer.sprite = secondarySprites[Random.Range(0, secondarySprites.Length)];
        detailRenderer.sprite = detailSprites[Random.Range(0, detailSprites.Length)];
    }

    [Header("NAMES")]
    public string[] firstParts;
    public string[] secondParts;

    public Text nameText;

    void MakeRandomName () 
    {
        nameText.text = secondParts[Random.Range(0, secondParts.Length)] + " " + firstParts[Random.Range(0, firstParts.Length)];
    }

        void OnMouseEnter ()
    {
        print("i feel the mouse and its hard cock");
        islandNameParent.SetActive(true);
    }

    void OnMouseExit ()
    {
        islandNameParent.SetActive(false);
    }
}