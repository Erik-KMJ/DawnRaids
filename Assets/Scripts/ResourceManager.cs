using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ResourceManager : MonoBehaviour
{
    public Image bar;
    public float amount = 100f;



    public Image timeBar;
    public float timeAmount = 100f;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (timeAmount <= 0)
        {
            SceneManager.LoadScene(0);
        }
        

        if (Input.GetKeyDown(KeyCode.Space))
        {
            ResourceRefill(20);
            TimeReduce(10);
        }

    }

    public void ResourceRefill(float amountChange)
    { 
        amount += amountChange;
        bar.fillAmount = amount / 100f;
    }

    public void TimeReduce(float reduceAmount)
    {
        timeAmount -= reduceAmount;
        timeBar.fillAmount = timeAmount / 100f;
    }
}
