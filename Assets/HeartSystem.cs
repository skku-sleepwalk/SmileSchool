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
        if (nowHeart <= 0) return;
        nowHeart -= dmg;
        for (int i = 0; i < nowHeart; i++) {
            HeartList[i].color = new Color(1, 1, 1, 1);
        }
        for (int i = nowHeart;i<5;i++)
        {
            HeartList[i].color = new Color(1, 1, 1, 0);

        }

    }
}
