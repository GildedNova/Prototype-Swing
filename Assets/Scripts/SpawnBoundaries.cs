using System;
using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEditorInternal;
using UnityEngine;

public class SpawnBoundaries : MonoBehaviour
{
    private int YCONST = -150;

    public GameObject[] prefabs;
    public Transform playerPos;
    private int tempZ;
    // Start is called before the first frame update
    void Start()
    {
        for(int i = 0; i < 15; i++)
        {
            spawnRandom(20 + UnityEngine.Random.Range(-5, 6) , YCONST, 20 * i);
        }


    }

    // Update is called once per frame
    void Update()
    {
        float zPos = playerPos.position.z;
        if(zPos > tempZ)
        {
            spawnRandom(20 + UnityEngine.Random.Range(-5, 6), YCONST, tempZ + 300);
            tempZ = (int)playerPos.position.z + 20;
        }
    }


    private void spawnRandom(float xPos, float yPos, float zPos)
    {
        Vector3 finalPos = new Vector3(xPos, yPos, zPos);
        int randNum = UnityEngine.Random.Range(0, 3);
        Instantiate(prefabs[randNum], finalPos, prefabs[randNum].transform.rotation);
        Vector3 finalPosRevrs = new Vector3(xPos * -1, yPos, zPos);
        Instantiate(prefabs[randNum], finalPosRevrs, prefabs[randNum].transform.rotation * Quaternion.Euler(0f,180f,0f));

    }
}
