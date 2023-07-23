using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayernotificationSystem : MonoBehaviour
{
    [SerializeField] GameObject notificationBox;
    void Update()
    {
        if(PlayerColiderController.instance.isColided())
        {
            notificationBox.SetActive(true);
        }else
        {
            notificationBox.SetActive(false);
        }
    }
}
