using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyScript : MonoBehaviour
{

    Rigidbody rb; //取得したRigidbodyを格納しておく為の変数
    float speed = 3.0f; //Enemyの移動速度

    void Start()
    {
        rb = this.gameObject.GetComponent<Rigidbody>(); //Rigidbodyを取得→変数rbに格納
        rb.velocity = - transform.up * speed; //y軸の負方向にspeedの大きさだけ速さを加える
    }

}
