using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public Text scoreText; //スコア表示に用いるText

    int score;

    //GameManagerをシングルトン化→どこからでもアクセス可能に
    public static GameManager instance;

    void Awake()
    {
        if (instance == null) //instance変数の中身がカラの時
        {
            instance = this; //自分自身をinstance変数の中にブチ込み
        }  
    }

    void Start()
    {
        score = 0;
        RefreshUI(); //UIの表示更新
    }

    //スコア加算
    public void AddScore(int point) //引数の分だけスコア加算
    {
        score += point;
        Debug.Log("スコア" + point.ToString() + "加算");

        RefreshUI(); //UIの表示更新
    }

    //UIの表示を更新する関数
    void RefreshUI()
    {
        scoreText.text = score.ToString();
    }
}
