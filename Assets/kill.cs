using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class kill : MonoBehaviour
{
    // Start is called before the first frame update

    public Transform Character;
    Vector2 direction = Vector2.right;
    float distance = 2f;
    int killCount = 0;
    public List<string> SceneList = new List<string>();
    int index = 0;
    public void killEnemy() 
    {
        Vector2 origin = Character.position;
        RaycastHit2D hit = Physics2D.Raycast(origin, direction, distance);

        if (hit.collider.gameObject.tag == "monster")
        {
            killCount += 1;
            Destroy(hit.collider.gameObject);
            Debug.Log(killCount);

            if (killCount >= 3)
            {
                index = SceneManager.GetActiveScene().buildIndex + 1;
                SceneManager.LoadScene(SceneList[index]);
                
                killCount = 0;
            }
            Debug.Log("ÀûÀ» Á×¿´´Ù!");
        }
    }
    
    //Destroy(Monster);

}
