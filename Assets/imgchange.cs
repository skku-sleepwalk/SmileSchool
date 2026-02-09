using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class imgchange : MonoBehaviour
{
    public List<Sprite> sprites;
    void Start()
    {
        GetComponent<SpriteRenderer>().sprite = sprites[SceneManager.GetActiveScene().buildIndex];
    }


}
