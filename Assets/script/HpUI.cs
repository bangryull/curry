using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HpUI : MonoBehaviour
{
    public Image[] hpImage;
    public PlayerHp player;

    private void Start()
    {
        player.onTakeDamage.AddListener(OnTakeDamage);
    }

    public void OnTakeDamage()
    {
        for (int i = 0; i < hpImage.Length; i++)
        {
            hpImage[i].gameObject.SetActive(i < player.hp);
        }
    }
}
