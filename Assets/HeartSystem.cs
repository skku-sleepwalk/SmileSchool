using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HeartSystem : MonoBehaviour
{
    private int nowHeart = 5;
    public List<Image> HeartList;

    public void GetDamage(int dmg)
    {
        nowHeart -= dmg;
        if (nowHeart <= 0)
        {
            nowHeart= 0;
        }
        
        for (int i = 0; i < nowHeart; i++) {
            HeartList[i].color = new Color(1, 1, 1, 1);
        }
        for (int i = nowHeart;i<5;i++)
        {
            HeartList[i].color = new Color(1, 1, 1, 0);

        }

    }
    public void RegenHeart(int reg)
    {
        nowHeart += reg;
        if (nowHeart > 5) nowHeart=5;
        
        for (int i = 0; i < nowHeart; i++)
        {
            HeartList[i].color = new Color(1, 1, 1, 1);
        }
        for (int i = nowHeart; i < 5; i++)
        {
            HeartList[i].color = new Color(1, 1, 1, 0);

        }
    }
}
