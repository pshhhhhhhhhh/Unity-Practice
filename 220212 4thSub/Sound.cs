using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; // UI사용시 반드시 입력

// 아이템 획득시 소리재생 스크립트
public class Sound : MonoBehaviour
{
    GameObject Soundplayer;

    // Start is called before the first frame update
    void Start()
    {
        this.Soundplayer = GameObject.Find("Sound");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void playsound() //소리 재생 함수 
    {
        this.Soundplayer.GetComponent<AudioSource>().Play();
    }
}
