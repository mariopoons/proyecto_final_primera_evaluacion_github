using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collectables : MonoBehaviour
{
    // when you touch a coin it will desapear!! (o eso espero!!)
    public int num;

    private void Update()
    {
        if (num == 30)
        {
            Destroy(gameObject);
            Debug.Log("You have found all coins, congratulations!");

            
            Time.timeScale = 0;

        }
    }
    private void OnTriggerEnter (Collider other)
    {
        if (other.gameObject.name.Contains("Coin"))
        {
            other.gameObject.SetActive(false);
            num++;
            Debug.Log($" You have {num} coins!, you need {30-num} more.");
        }
    }

  
}
