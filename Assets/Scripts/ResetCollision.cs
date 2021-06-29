using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor.PackageManager;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ResetCollision : MonoBehaviour
{

    public GameObject player;
    public Transform posP;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(0, transform.position.y, posP.position.z);
    }

    private void OnTriggerEnter(Collider ground)
    {
        if(ground.tag == "Player")
        {
                Debug.Log("Collided");
                SceneManager.LoadScene("Menu");
           
        }
    }

}
