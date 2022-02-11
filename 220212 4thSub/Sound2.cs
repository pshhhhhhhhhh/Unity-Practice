using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; // UI사용시 반드시 입력

//피격시 소리재생 스크립트
public class Sound2 : MonoBehaviour
{
    GameObject Soundplayer2;
    // Start is called before the first frame update
    void Start()
    {
        this.Soundplayer2 = GameObject.Find("Sound2");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void playsound2() //소리 재생 함수 
    {
        this.Soundplayer2.GetComponent<AudioSource>().Play();
    }
}
