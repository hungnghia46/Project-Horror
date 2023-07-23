using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInteractSystem : MonoBehaviour
{
    [SerializeField] GameObject bookOpenBtn;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (PlayerColiderController.instance.isColided() && Input.GetKeyDown(KeyCode.F))
        {
            bookOpenBtn.SetActive(true);
        }
    }
}
