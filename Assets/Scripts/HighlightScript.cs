using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class HighlightScript : MonoBehaviour
{
    public Color startColor;
    public SpriteRenderer object2D;

    public ResourceManager resourceManager;
    bool used = false;

    public bool increaseResource;
    public float amountChange;

    private void Start()
    {
        object2D = GetComponent<SpriteRenderer>();
    }

    private void Update()
    {
        object2D = GetComponent<SpriteRenderer>();
    }
    public void OnMouseEnter()
    {
       
        if(used == false)
        {
            startColor = object2D.color;
            object2D.color = Color.blue;
            print("hover");
        }
        else
        {
            startColor = object2D.color;
            object2D.color = Color.grey;
            print("hover");
        }
       
    }
    public void OnMouseDown()
    {
       
        if (used == false && increaseResource == true)
        {
            object2D.color = Color.black;
            resourceManager.ResourceRefill(amountChange);
            print("clicked");
            used = true;
        }
        else if(used == false && increaseResource == false) //decrease amount
        {
            if(amountChange < resourceManager.amount)
            {
                object2D.color = Color.green;
                resourceManager.ResourceRefill(-amountChange);
                print("clicked");
                used = true;
            }
            else
            {
                resourceManager.amount = 0;
                resourceManager.bar.fillAmount = 0;
            }
        }
       
      
    }
    public void OnMouseUp()
    {
        object2D.color = startColor;
        print("unclicked");
    }
    public void OnMouseExit()
    {
        object2D.color = startColor;
        print("exit");
    }
}
