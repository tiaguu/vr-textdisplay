using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Checkout : MonoBehaviour
{
    //public Collider checkoutZone;
    public SpriteRenderer item1;
    public SpriteRenderer item2;
    public Sprite checkmark;
    public Sprite uncheckedCheckmark;
    private int item1Counter;
    private int item2Counter;

    private void Start()
    {
        item1Counter = 0;
        item2Counter = 0;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "MeatCan")
        {
            item1.sprite = checkmark;
            item1Counter++;
        }
        if (other.gameObject.tag == "Juice")
        {
            item2.sprite = checkmark;
            item2Counter++;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "MeatCan")
        {
            item1Counter--;
            if (item1Counter == 0) item1.sprite = uncheckedCheckmark;
        }
        if (other.gameObject.tag == "Juice")
        {
            item2Counter--;
            if (item2Counter == 0) item2.sprite = uncheckedCheckmark;
        }
    }

    private void Update()
    {
        if(item1Counter > 0 && item2Counter > 0)
        {
            Debug.Log("Complete");
        }
    }
}
