using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class HighlightScript : MonoBehaviour
{
    public Color startColor;
    public SpriteRenderer object2D;
    public Sprite object2DClean;

    public ResourceManager resourceManager;
    public bool used = false;

    public bool increaseResource;
    public float amountChange;
    public float reduceTime;

    private void Start()
    {
        object2D = GetComponent<SpriteRenderer>();
        
        if (used==true)
        {
            this.gameObject.GetComponent<SpriteRenderer>().sprite = object2DClean;
        }
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
            resourceManager.TimeReduce(reduceTime);
            resourceManager.ResourceRefill(amountChange);
            this.gameObject.GetComponent<SpriteRenderer>().sprite = object2DClean;
            print("clicked");
            used = true;
        }
        else if(used == false && increaseResource == false) //decrease amount
        {
            resourceManager.TimeReduce(reduceTime);
            if (amountChange < resourceManager.amount)
            {
                object2D.color = Color.green;
                resourceManager.ResourceRefill(-amountChange);
                this.gameObject.GetComponent<SpriteRenderer>().sprite = object2DClean;
                print("clicked");
                used = true;
            }
            else
            {
                this.gameObject.GetComponent<SpriteRenderer>().sprite = object2DClean;
                resourceManager.amount = 0;
                resourceManager.bar.fillAmount = 0;
                used = true;
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
