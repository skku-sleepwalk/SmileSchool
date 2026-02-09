using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class GoToTitle : MonoBehaviour
{
    public void Go()
    {
        Time.timeScale = 1.0f;
        SceneManager.LoadScene("out");
    }
}
