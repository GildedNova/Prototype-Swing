using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstantiateRandom : MonoBehaviour
{


    public Transform pos;
    public Transform player;
    public GameObject[] prefabs;
    private int tempZ;
    // Start is called before the first frame update
    void Start()
    {


        for(int i=2; i<10; i++)
        {
            spawnGrapple(pos.position.x, pos.position.y + Random.Range(-40, 40), 25 * i);
        }


    }

    // Update is called once per frame
    void Update()
    {
        float zPos = player.position.z;
        
        if (zPos > tempZ)
        {
            spawnGrapple(pos.position.x, pos.position.y + Random.Range(-20, 40), tempZ + 200);
            tempZ = (int)player.position.z + 20;
        }
    }

    

    private void spawnGrapple(float xPos, float yPos, float zPos)
    {
        Vector3 finalPos = new Vector3(xPos, yPos, zPos);
        int randNum = UnityEngine.Random.Range(0, 3);
        Instantiate(prefabs[randNum], finalPos, prefabs[randNum].transform.rotation);
    }
}
