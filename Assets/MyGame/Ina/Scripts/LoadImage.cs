using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LoadImage : MonoBehaviour
{
    public Image Image01;
    public Image Image02;
    public Image Image03;
    public Image Image04;

    public Sprite[] Sprites;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //random Sprite aus Sprites Array wird Image zugewiesen
    public void LoadSprites()
    {
        Image01.sprite = Sprites[Random.Range(0, Sprites.Length)];
    }
}
