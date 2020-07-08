using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawnerScript : MonoBehaviour
{
    public GameObject[] enemyPrefabs; //EnemyのPrefabをUnityからアタッチ

    float timer;
    float interval = 1.5f; //Enemyの生成間隔
    
    void Update()
    {
        timer += Time.deltaTime;
        if (timer > interval)
        {
            SpawnEnemy(); //Enemyを生成

            timer = 0;
        }
    }

    //Enemyを生成する関数
    void SpawnEnemy()
    {
        int randomNum = Random.RandomRange(0, 2); //[0, 1]のどちらかの数字をランダムで取得
        GameObject enemy = enemyPrefabs[randomNum];

        float diffX = Random.RandomRange(-2.0f, 2.0f); //[-2 ~ 2]の値をランダムで取得
        Vector3 diff = new Vector3(diffX, 0, 0);
        Instantiate(enemy, this.transform.position + diff, Quaternion.identity);
    }
}
