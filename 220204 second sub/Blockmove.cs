using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Blockmove : MonoBehaviour
{
    //블록 양옆으로 반복해서 움직이기
    
    public float maxCount = 1700.0f; //되돌아올때의 지점 변수
    int count = 0; 
    public float speed = 0.1f; //블록 속도 변수

    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        // maxCount의 절반을 기준으로 count가 maxcount의 절반보다 작을땐 왼쪽으로 클땐 오른쪽으로 이동
        if (count < maxCount / 2)
        {
            this.transform.Translate(-speed/25, 0, 0); //-쪽방향으로 이동
            count++;
        }
        if (count >= maxCount / 2)
        {
            this.transform.Translate(speed/25,0, 0); //+쪽방향으로 이동
            count++;
            if (count == maxCount)
            {
                count = 0;
            }
        }
    }
}
