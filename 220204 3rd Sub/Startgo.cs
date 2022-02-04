using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; //씬불러오기 사용할때 입력

public class Startgo : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("space")) //스페이스 바 눌렀을때
        {
            SceneManager.LoadScene("SampleScene"); //SampleScene 불러오기
        }
    }
}
