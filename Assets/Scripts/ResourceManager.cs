using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ResourceManager : MonoBehaviour
{
    public Image bar;
    public float amount = 0f;

    public Image timeBar;
    public float timeAmount = 100f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(timeAmount <= 0)
        {
            SceneManager.LoadScene(0);
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            ResourceRefill(20);
            TimeReduce(10);
        }


    }

    //public void ResourceReduce(float reduceAmount)
    //{
    //    amount -= reduceAmount;
    //    bar.fillAmount = amount / 100f;
    //}

    public void ResourceRefill(float refillAmount)
    {
        amount += refillAmount;
        //amount = Mathf.Clamp(amount, 0, 100);
        bar.fillAmount = amount / 100f;
    }

    public void TimeReduce(float reduceAmount)
    {
        timeAmount -= reduceAmount;
        timeAmount = Mathf.Clamp(timeAmount, 0, 100);

        timeBar.fillAmount = amount / 100f;
    }
}
