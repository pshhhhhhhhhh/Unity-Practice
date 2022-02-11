using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//적 생성 스크립트
public class EnemyGenerator : MonoBehaviour
{
    public GameObject copyedEnemy;
    float respawn = 0.3f; //복제된 오브젝트가 나타나는시간(리스폰시간)
    float delta = 0; //시간을 비교하기 위한 시간 변수
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        this.delta = this.delta + Time.deltaTime;
        if(this.delta > this.respawn)
        {
            this.delta = 0;
            GameObject showEnemy = Instantiate(copyedEnemy) as GameObject;
            float range = Random.Range(-9.0f, 9.0f);//Random.Range(최소값,최대값)
            showEnemy.transform.position = new Vector3(range, 6, 0);
        }
    }
}
