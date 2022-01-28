using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    float speed = 0; //변수 선언
    Vector2 startPos; //마우스를 클릭했을 때 좌표값
    Vector2 endPos; // 마우스를 눌렀다 뗐을때의 좌표값
    public float little = 1000.0f;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0)) //마우스 왼쪽클릭시 상호작용
        {
            this.startPos = Input.mousePosition; //마우스버튼 클릭했을때의 위치값

                
        }
       else if (Input.GetMouseButtonUp(0))
        {
             this.endPos = Input.mousePosition; //마우스버튼 클릭했다가 떼었을 때 위치값
            float length = (this.endPos.x - this.startPos.x); //마지막 좌표값 - 처음 좌표값을 빼줌
            this.speed = length / little;
            this.GetComponent<AudioSource>().Play();

        } 


        //if (Input.GetMouseButton(1)) //마우스 오른쪽쪽클릭시 상호작용
        //{
        //    this.speed = -0.1f; // 시작속도 설정         
        //}
        transform.Translate(this.speed*Time.deltaTime, 0, 0); // x+방향으로 이동시킴 , Time.deltaTime -> 기기 사양에 상관없이 이동 속도를 같게 함
        this.speed *= 0.98f; //0에 가깝도록 감속시킴
    }
}
