using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;


public class n2 : MonoBehaviour, IPointerClickHandler
{

    //保存から記録をやろうとしたscript

    int b;

    public Text scoreText;

    public GameObject score_object = null; // Textオブジェクト
    public int score_num = 0; // スコア変数



    // Start is called before the first frame update
    void Start()
    {
        b = n1.getA();  //n1から拾ってくる
                        //print(b);
        scoreText.text = "1. " + b;


        score_num = PlayerPrefs.GetInt ("SCORE", 0);

    }

    // Update is called once per frame
    void Update()
    {
        //PlayerPrefs.SetInt("SCORE", score_num);
        //PlayerPrefs.Save();


        //score_num.text = "1. " + score_num;
        //scoreText.text = "1. " + score_num;

    }


    public void OnPointerClick(PointerEventData eventData)//button作っていれる
    {
        PlayerPrefs.Save();
        SceneManager.LoadScene("SampleScene"); //タイトルへ
    }




}
