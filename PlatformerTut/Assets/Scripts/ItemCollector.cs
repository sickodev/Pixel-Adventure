using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemCollector : MonoBehaviour
{
    private int countCherry = 0;

    [SerializeField] private Text cherriesText;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.CompareTag("Cherry"))
        {
            Destroy(collision.gameObject);
            countCherry++;
            cherriesText.text = "Cherries : " + countCherry;
        }
    }
}
