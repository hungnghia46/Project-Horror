using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerColiderController : MonoBehaviour
{
    public static PlayerColiderController instance;
    private bool isColider;
    private void Awake()
    {
        instance = this;
    }
    public bool isColided()
    {
        return isColider;
    }
    private void OnTriggerStay2D(Collider2D other)
    {
        if (other.gameObject.tag == "interactObj")
        {
            isColider = true;
        }
    }
    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject.tag == "interactObj")
        {
            isColider = false;
        }
    }
}
