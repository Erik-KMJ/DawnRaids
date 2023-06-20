using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class HoverOver : MonoBehaviour
{
    public GameObject HoverPanel;
    public void OnMouseEnter()
    {
        HoverPanel.SetActive(true);
    }
    public void OnMouseExit()
    {
        HoverPanel.SetActive(false);
    }
}
