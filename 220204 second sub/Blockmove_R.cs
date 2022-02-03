using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Blockmove_R : MonoBehaviour
{
    //블록 오른쪽으로만 움직이기   
    public float speed = 0.1f; //블록 속도 변수
    float x_Speed = 0; //x축 방향 변수
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        //this.transform.Translate(speed / 25, 0, 0); //오른쪽방향으로 이동
        x_Speed = speed;

    }
    private void FixedUpdate()
    {

        this.transform.Translate(x_Speed,0,0); //오브젝트 이동

    }
}
