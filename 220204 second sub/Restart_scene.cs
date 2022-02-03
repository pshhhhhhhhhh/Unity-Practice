using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; //씬불러오기 사용할때 입력

public class Restart_scene : MonoBehaviour
    // R눌러서 재시작하기
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("r") || Input.GetKey("space")) //r키 혹은 스페이스를 누르면 samplescene 불러와서 재시작하기
        {
            SceneManager.LoadScene("SampleScene");
        }
    }
}
