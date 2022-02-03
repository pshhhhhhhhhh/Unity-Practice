using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; //UI사용시 반드시 입력
using UnityEngine.SceneManagement; //씬불러오기 사용할때 입력


public class Win : MonoBehaviour
{

    GameObject Player; //플레이어 오브젝트를 대입할 변수 데이터형 GameObject
    GameObject gem; //목표물 오브젝트를 대입할 변수 데이터형 GameObjcet
    GameObject distance; //플레이어 오브젝트와 목표물 오브젝트 사이의 거리를 표시할 UI 오브젝트를 대입할 변수
    // Start is called before the first frame update
    void Start()
    {
        this.Player = GameObject.Find("Player");
        this.gem = GameObject.Find("gem");
        this.distance = GameObject.Find("Text");
    }

    // Update is called once per frame
    void Update()
    {
        float lengthDis = this.gem.transform.position.x - this.Player.transform.position.x; // 젬 변수
        float lengthDis2 = this.gem.transform.position.y - this.Player.transform.position.y; // 젬 변수
       
        if (lengthDis >= 0)
        {
            this.distance.GetComponent<Text>().text = "Gem!" + " : " + lengthDis.ToString("F2") + "m";
            //ToString("D숫자") -> D는 정수형 숫자는 자리수   ToString("F숫자) -> 소수점이하 자릿수
        }
        else //lengthDi가 0보다 작다면 -로 거리 나타냄
        {
            this.distance.GetComponent<Text>().text = "Gem!" + " : " + lengthDis.ToString("F2") + "m";
        }        
        if (lengthDis <= 0 && lengthDis2 <= 0) //보석에 닿으면 endScene 불러옴
        {           
            SceneManager.LoadScene("EndScene");
        }
    }
}
