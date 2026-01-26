using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class kill : MonoBehaviour
{
    // Start is called before the first frame update

    public Transform Character;
    Vector2 direction = Vector2.right;
    float distance = 2f;

    public void killEnemy() 
    {
        Vector2 origin = Character.position;
        RaycastHit2D hit = Physics2D.Raycast(origin, direction, distance);
        Debug.Log(hit.collider.gameObject);
        if (hit.collider.gameObject.tag == "monster")
        {
            Destroy(hit.collider.gameObject);
        }
        Debug.Log("ÀûÀ» Á×¿´´Ù!");
    }
    
    //Destroy(Monster);

}
