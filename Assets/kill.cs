using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class kill : MonoBehaviour
{
    // Start is called before the first frame update
    private bool isCool = false;
    public Transform Character;
    Vector2 direction = Vector2.right;
    float distance = 2f;
    int killCount = 0;
    public List<string> SceneList = new List<string>();
    int index = 0;
    public SpriteRenderer sq;
    public Button bt;
    public void Start()
    {
        bt = GetComponent<Button>();
    }
    public void killEnemy() 
    {
        if (isCool == true) return;
        isCool = true;
        Vector2 origin = Character.position;
        RaycastHit2D hit = Physics2D.Raycast(origin, direction, distance);
        ColorBlock colorBlock = bt.colors;
        colorBlock.selectedColor = new Color(150f / 255f, 150f / 255f, 150f / 255f, 255f / 255f);
        bt.colors = colorBlock;
        sq.color = new Color(1f, 1f, 1f, 1f);
        StartCoroutine("Invincibility");

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
            Debug.Log("利阑 磷看促!");
        }
    }
    
    //Destroy(Monster);
        }
        Debug.Log("利阑 磷看促!");
    }
    IEnumerator Invincibility()
    {
        yield return new WaitForSeconds(1f);
        sq.color = new Color(1f, 1f, 1f, 0f);
        ColorBlock colorBlock = bt.colors;
        isCool = false;
        colorBlock.selectedColor = new Color(1f, 1f, 1f, 1f);
        bt.colors = colorBlock;


        //Destroy(Monster);

    }
   
}

