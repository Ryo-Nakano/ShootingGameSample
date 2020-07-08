using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerScript : MonoBehaviour
{

    float speedHorizontal = 5.0f; //Playerの左右移動スピード

    float attackTimer;
    float attackInterval = 0.5f; //Playerの攻撃間隔

    public GameObject bulletPrefab; //BulletをUnityからアタッチ
    
    void Update()
    {
        MoveHorizontal(); //PLayerの左右移動
        Attack(); ///攻撃
    }

    //Playerの左右移動
    void MoveHorizontal()
    {
        float x = Input.GetAxis("Horizontal"); //左右のキー入力を取得(-1 ~ 1の間の値)
        this.transform.position += new Vector3(x * speedHorizontal * Time.deltaTime, 0, 0);
    }

    //攻撃
    void Attack()
    {
        attackTimer += Time.deltaTime;
        if (attackTimer > attackInterval)
        {
            Vector3 diff = new Vector3(0, 1.0f, 0); //Playerの座標よりも少し上にBulletを生成する為
            Instantiate(bulletPrefab, this.transform.position + diff, Quaternion.identity);

            attackTimer = 0;
        }
    }

    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "Enemy")
        {
            SceneManager.LoadScene("GameOver");
        }        
    }
}
