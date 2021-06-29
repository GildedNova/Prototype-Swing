using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Scoring : MonoBehaviour
{


    public Text label;
    private float distance;
    public Transform player;
    


    private void Update()
    {
        score();
    }
    void score()
    {
        distance = (int)player.position.z;
        if(distance < 0)
        {
            label.text = "Score: 0";
        } else
        {
            label.text = "Score: " + distance.ToString();
        }


    }

}
