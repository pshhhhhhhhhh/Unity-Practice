using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//캐릭터 움직이기
public class Player_move : MonoBehaviour
{
    public float move_Speed = 0.1f; //속도초기값
    float x_Speed = 0; //x축 방향 변수
    float y_Speed = 0; //y축 방향 변수
   
    // Start is called before the first frame update
    void Start()
    {
      
    }
    // Update is called once per frame
    void Update()
    {  
        x_Speed = 0;
        y_Speed = 0;
         
        if (Input.GetKey("right")) //오른쪽으로 이동
        {           
            x_Speed = move_Speed;                   
        }
        if (Input.GetKey("left")) //왼쪽으로 이동
        {          
            x_Speed = -move_Speed;           
        }
        if (Input.GetKey("up"))//위로 이동
        {
            y_Speed = move_Speed;
        }
        if (Input.GetKey("down"))//아래로 이동
        {
            y_Speed = -move_Speed;
        }
    }
    private void FixedUpdate()
    {      
        this.transform.Translate(x_Speed, y_Speed, 0); //오브젝트 이동       
    }   
}

