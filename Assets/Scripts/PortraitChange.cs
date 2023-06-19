using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PortraitChange : MonoBehaviour
{
    // Start is called before the first frame update
    public ResourceManager resourceManager;
    public Image characterPortrait;
    public Sprite Angry;
    public Sprite Bored;
    public Sprite Happy;
    public Sprite Neutral;
    public Sprite Sad;


    // Update is called once per frame
    private void Update()
    {
        //ImageChange();
    }

    public void ImageChange()
    {
        if (resourceManager.amount >= 50f|| resourceManager.amount <= 75f)
        {
            characterPortrait.sprite = Neutral;
        }
        if (resourceManager.amount <= 25f)
        {
            characterPortrait.sprite = Happy;
        }
        if (resourceManager.amount >= 75f)
        {
            characterPortrait.sprite = Bored;
        }
    }
}
