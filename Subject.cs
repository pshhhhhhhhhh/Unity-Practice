using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Subject : MonoBehaviour
{
    public float speed = 0.1f;
    public float angle = 90f;
    public float maxCount = 50;
    int count = 0;
    // Start is called before the first frame update
    void Start()
    {
        count = 0; //카운터를 리셋
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("z")) //z를 눌렀을때 회전시키기
        {
            count = count + 1;
            if (count >= maxCount)
            {
                this.transform.Rotate(0, 0, angle);
                count = 0;
            }
        }



        if (Input.GetKey("right")) //개체 이동시키기
        {
            transform.Translate(speed, 0, 0);
        }
        else if (Input.GetKey("left"))
        {
            transform.Translate(-speed, 0, 0);
        }
        if (Input.GetKey("up"))
        {
            transform.Translate(0, speed, 0);
        }
        else if (Input.GetKey("down"))
        {
            transform.Translate(0, -speed, 0);
        }
    }
}

