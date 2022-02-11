using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; // UI사용시 반드시 입력
using UnityEngine.SceneManagement; //씬불러오기 사용할때 입력


//체력관련스크립트
public class HpControll : MonoBehaviour
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

    public void DecreaseHP() //Hp감소 함수를 만듦
    {
        this.HpGauge.GetComponent<Image>().fillAmount -= 0.1f;
        if (this.HpGauge.GetComponent<Image>().fillAmount == 0) // 체력이 0이되면 게임오버
        {       
            SceneManager.LoadScene("GameOverScene"); //GameOverScene 불러오기
        }
    }
}