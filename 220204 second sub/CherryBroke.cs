using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CherryBroke : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter2D(Collision2D collision) //�ݶ��̴�,������ٵ� ����� ������Ʈ�� �浹�ϸ� ����
    {
        
        Destroy(this.gameObject); //������Ʈ �����ϱ�
        
    }
}