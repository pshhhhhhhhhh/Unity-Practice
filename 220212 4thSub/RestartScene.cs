using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; //씬불러오기 사용할때 입력
public class RestartScene : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("r")) //r키를 눌렀을때
        {
            this.GetComponent<AudioSource>().Play(); // 소리재생
            SceneManager.LoadScene("SampleScene"); //SampleScene 불러오기
        }
    }
}
