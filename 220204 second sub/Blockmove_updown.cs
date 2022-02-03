using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Blockmove_updown : MonoBehaviour
{
   // 블록 위아래로 반복해서 움직이기
    public float maxCount = 1000.0f; //되돌아올 값을 설정해주는 변수
    int count = 0;
    public float speed = 0.1f; // 블록 속도 변수

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(count);
        // maxCount의 절반을 기준으로 count가 maxcount의 절반보다 작을땐 위로 클땐 아래로 이동
        if (count < maxCount/2)
        {
            this.transform.Translate(0, speed / 25, 0); //위방향으로 이동
            count++;
        }
        if(count >= maxCount/2 )
        {
            this.transform.Translate(0, -speed / 25, 0); //아랫방향으로 이동
            count++;
            if(count == maxCount)
            {
                count = 0;
            }
        }
    }   
}
