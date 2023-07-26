using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    
    private void Awake()
    {
    }
    void Start()
    {

    }
    void Update()
    {
        transform.Translate(Vector2.right * Time.deltaTime);
    }
    private void OnBecameInvisible()
    {
        Destroy(this.gameObject);
    }
    void OnDrawGizmos()
    {
    }
    private void OnEnable()
    {
        print("OnEnable call");
    }
    private void OnDisable()
    {
        print("OnDisable call");
    }
    private void OnApplicationPause(bool pauseStatus) {
        if(pauseStatus)
        {
            print("isPause");
        }else
        {
           print("Resuming....."); 
        }
    }
}
