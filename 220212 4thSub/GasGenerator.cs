using System.Collections;
using System.Collections.Generic;
using UnityEngine;


//에너지 회복생성 스크립트
public class GasGenerator : MonoBehaviour
{
    public GameObject copyedGas;
    float respawn = 1.0f; //복제된 오브젝트가 나타나는시간(리스폰시간)
    float delta = 0; //시간을 비교하기 위한 시간 변수
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        this.delta = this.delta + Time.deltaTime;
        if (this.delta > this.respawn)
        {
            this.delta = 0;         
                GameObject showGas = Instantiate(copyedGas) as GameObject;
                float range = Random.Range(-9.0f, 9.0f);//Random.Range(최소값,최대값)
                showGas.transform.position = new Vector3(range, 6, 0);
        }       
    }
}
