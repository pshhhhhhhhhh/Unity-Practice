using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PlayerController : MonoBehaviour
{
   
    float speed2 = 0; //변수 선언
    Vector2 startPos; //마우스를 클릭했을 때 좌표값
    Vector2 endPos; // 마우스를 눌렀다 뗐을때의 좌표값
    public float littley = 1000.0f;
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
           
            float length2 = (this.endPos.y - this.startPos.y); //마지막 좌표값 - 처음 좌표값을 빼줌
          
            this.speed2 = length2 / littley;
            this.GetComponent<AudioSource>().Play(); //클릭할때마다 소리 나오기

        } 


        
        transform.Translate(0.02f, this.speed2 * Time.deltaTime, 0); // y+방향으로 이동시킴 , Time.deltaTime -> 기기 사양에 상관없이 이동 속도를 같게 함
        this.speed2 *= 0.5f; //0에 가깝도록 감속시킴
    }

    
}
