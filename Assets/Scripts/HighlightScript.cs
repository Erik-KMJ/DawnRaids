using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class HighlightScript : MonoBehaviour
{
    public Color startColor;
    public SpriteRenderer object2D;
    bool used = false;

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
        object2D.color = Color.black;
        print("clicked");
        used = true;
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
