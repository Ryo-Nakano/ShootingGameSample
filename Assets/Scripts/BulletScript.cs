using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletScript : MonoBehaviour
{
    Rigidbody rb; //取得したRigidbodyを格納しておく為の変数
    float speed = 10.0f; //Bulletの飛ぶ速さ
    
    void Start()
    {
        rb = this.gameObject.GetComponent<Rigidbody>(); //Rigidbodyを取得→変数rbに格納
        rb.velocity = transform.up * speed; //y軸の正方向にspeedの大きさだけ速さを加える
    }

    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "Enemy_A")
        {
            GameManager.instance.AddScore(10); //スコアを10加算
            Destroy(col.gameObject); //当たった相手をDestroy
            Destroy(this.gameObject); //自身をDestroy
        }
        else if (col.gameObject.tag == "Enemy_B")
        {
            GameManager.instance.AddScore(20); //スコアを20加算
            Destroy(col.gameObject); //当たった相手をDestroy
            Destroy(this.gameObject); //自身をDestroy
        }
    }
}
