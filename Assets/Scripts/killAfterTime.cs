using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class killAfterTime : MonoBehaviour
{
    void Start()
    {
        Invoke("kill", 10);
         }

    void kill()
    {
        Destroy(gameObject);
    }

}
