using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; // UI사용시 반드시 입력


//체력관련스크립트
public class Hpplus : MonoBehaviour
{
    GameObject HpGauge;
    // Start is called before the first frame update
    void Start()
    {
        this.HpGauge = GameObject.Find("HpUi");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void IncreaseHP() //Hp증가 함수를 만듦
    {
        this.HpGauge.GetComponent<Image>().fillAmount += 0.1f;
    }
}
