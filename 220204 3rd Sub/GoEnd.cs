using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; //씬불러오기 사용할때 입력

public class GoEnd : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision) //콜라이더,리지드바디가 적용된 오브젝트와 충돌하면 적용
    {

        SceneManager.LoadScene("EndScene"); //endScene 불러오기

    }
}
