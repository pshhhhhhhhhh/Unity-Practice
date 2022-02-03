using System.Collections;
using System.Collections.Generic;
using UnityEngine;


//물체 회전 스크립트
public class Rcon : MonoBehaviour
{


    public float rotSpeed = 1; //회전속도 초기값
    float rot_Z = 0;
    void Update()
    {

        rot_Z = rotSpeed;

        transform.Rotate(0, 0, rot_Z); //+방향으로 회전
        this.rot_Z *= 0.96f; //값을 0에 수렴하도록 함
    }   
}
