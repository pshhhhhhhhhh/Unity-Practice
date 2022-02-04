using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; //씬불러오기 사용할때 입력

// Endscene -> SampleScene 불러오기
public class Restart : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("r")) //r버튼 눌렀을때 
        {
            SceneManager.LoadScene("SampleScene"); //SampleScene 불러오기
        }
    }
}
