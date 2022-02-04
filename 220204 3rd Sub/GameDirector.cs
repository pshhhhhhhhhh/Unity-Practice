using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; //UI사용시 반드시 입력

public class GameDirector : MonoBehaviour
{
    GameObject player; //플레이어 오브젝트를 대입할 변수 데이터형 GameObject
    GameObject FInish; //목표물 오브젝트를 대입할 변수 데이터형 GameObjcet
    GameObject distance; //플레이어 오브젝트와 목표물 오브젝트 사이의 거리를 표시할 UI 오브젝트를 대입할 변수
    // Start is called before the first frame update
    void Start()
    {
        this.player = GameObject.Find("Player");
        this.FInish = GameObject.Find("Finish");
        this.distance = GameObject.Find("Text");
    }

    // Update is called once per frame
    void Update()
    {
        float lengthDis = this.FInish.transform.position.x - this.player.transform.position.x;
        if (lengthDis >= 0)
        {
            this.distance.GetComponent<Text>().text = "목표까지!" + ":" + lengthDis.ToString("F2") + "m";
            //ToString("D숫자") -> D는 정수형 숫자는 자리수   ToString("F숫자) -> 소수점이하 자릿수
        }
        else //lengthDi가 0보다 작다면
        {
            this.distance.GetComponent<Text>().text = "목표까지!" + ":" + lengthDis.ToString("F2") + "m";
            //ToString("D숫자") -> D는 정수형 숫자는 자리수   ToString("F숫자) -> 소수점이하 자릿수
        }
    }
}
