using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class killAfterDistance : MonoBehaviour
{
    
    private float playerPosZ;
    void Start()
    {

        if(playerPosZ > GameObject.Find("Player").transform.position.z + 250)
        {
            kill();
        }
    }
        

    private void Update()
    {
        playerPosZ = GameObject.Find("Player").transform.position.z;
        if(playerPosZ > transform.position.z + 210)
        {
            kill();
        }
    }
    void kill()
    {
        Destroy(gameObject);
    }

}
