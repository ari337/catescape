using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameDirector : MonoBehaviour
{
    GameObject hpGauage;
    private void Start()
    {
        this.hpGauage = GameObject.Find("hpGauge");
    }

    public void DecreaseHp()
    {
        this.hpGauage.GetComponent<Image>().fillAmount -= 0.1f;
    }
}
