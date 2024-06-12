using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LoadImage : MonoBehaviour
{
    public Image image01;
    public Image image02;
    public Image image03;
    public Image image04;

    public Sprite[] Sprites;

    public GameObject module01;
    public GameObject module02;
    public GameObject module03;
    public GameObject module04;

    //public bool moduleSelected = module01.image02;
    // Start is called before the first frame update
    void Start()
    {
        LoadSprites();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //random Sprite aus Sprites Array wird Image zugewiesen
    public void LoadSprites()
    {
        image01.sprite = Sprites[Random.Range(0, Sprites.Length)];
        image02.sprite = Sprites[Random.Range(0, Sprites.Length)];
        image03.sprite = Sprites[Random.Range(0, Sprites.Length)];
        image04.sprite = Sprites[Random.Range(0, Sprites.Length)];
    }

    // ein Modul wird aus der Liste ausgew�hlt
    public void SelectModule()
    {

    }

    // die Module werden neu geladen, wenn davor eines ausgew�hlt wurde
    public void ResetImages()
    {
        if (moduleSelected == true)
        {
            LoadSprites();
        }
    }
}