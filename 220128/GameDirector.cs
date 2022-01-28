using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; //UI사용시 반드시 입력

public class GameDirector : MonoBehaviour
{
    GameObject player; //플레이어 오브젝트를 대입할 변수 데이터형 GameObject
    GameObject bomb; //목표물 오브젝트를 대입할 변수 데이터형 GameObjcet
    GameObject distance; //플레이어 오브젝트와 목표물 오브젝트 사이의 거리를 표시할 UI 오브젝트를 대입할 변수
    // Start is called before the first frame update
    void Start()
    {
        this.player = GameObject.Find("man");
        this.bomb = GameObject.Find("bomb");
        this.distance = GameObject.Find("Move");
    }

    // Update is called once per frame
    void Update()
    {
        float lengthDis = this.bomb.transform.position.x - this.player.transform.position.x;
        if (lengthDis >= 0)
        {
            this.distance.GetComponent<Text>().text = "목표지점" + ":" + lengthDis.ToString("F5") + "m";
            //ToString("D숫자") -> D는 정수형 숫자는 자리수   ToString("F숫자) -> 소수점이하 자릿수
        }
        else //lengthDi가 0보다 작다면
        {
            this.distance.GetComponent<Text>().text = "Game Over"; // Game Over 메시지 출력
        }
    }
}
