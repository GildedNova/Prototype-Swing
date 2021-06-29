using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Play : MonoBehaviour
{
    public void btnscene(string scenename)
    {
        SceneManager.LoadScene(scenename);
    }
}
