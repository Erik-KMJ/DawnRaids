using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ResourceManager : MonoBehaviour
{
    public Image bar;
    
    public float amount;
    public float carryOverAmount;



    public Image timeBar;
    public float timeAmount = 100f;

    // Start is called before the first frame update
    void Start()
    {
        amount = carryOverAmount;
    }

    // Update is called once per frame
    void Update()
    {
        LoseGame();

        if (timeAmount <= 0)
        {
            
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
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
        carryOverAmount = amount;
    }

    public void TimeReduce(float reduceAmount)
    {
        timeAmount -= reduceAmount;
        timeBar.fillAmount = timeAmount / 100f;
    }

    public void WinGame()
    {
        SceneManager.LoadScene(16);
    }

    public void LoseGame()
    {
        if (amount >= 100)
        {
            SceneManager.LoadScene(17);
        }
    }
}
