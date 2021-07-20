using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class gamedirctor : MonoBehaviour
{
    [SerializeField] GameObject owariText;
    [SerializeField] GameObject EndScores;
    public GameObject yarinaosiBottan;
    GameObject GameUI,ScoreBackGround,StratGO;
    Text t,EndScore,StratText;
    Slider Timeslider;
    public float puraspoint,SavePoint,time,Scoretime,StratTime;
    public bool GameSwicth = true,StratSwicth=true;
    public void OnClickTitle()
    {
        SceneManager.LoadScene("RankingScreen");
    }
    public void OnClickOnceAgainGameScene()
    {
        SceneManager.LoadScene("GameScene");
    }
    public void purasPoint()
    {
        t.text = SavePoint.ToString();
        //if (time<50) {
        //    time += 10;
        //}
    }
    // Start is called before the first frame update
    void Start()
    {
        GameUI = GameObject.Find("GameUI");
        ScoreBackGround = GameObject.Find("ScoreBackGround");
        StratGO = GameObject.Find("StratBackgrund");
        EndScore = EndScores.GetComponent<Text>();
        //float MaxS = 100;
        time = 60;
        SavePoint = 0;
        t = GameObject.Find("PointText").GetComponent<Text>();
        StratText = GameObject.Find("StratText").GetComponent<Text>();
        Timeslider = GameObject.Find("TimeSlider").GetComponent<Slider>();
        //Timeslider.maxValue = MaxS;
        //Timeslider.value = MaxS;
    }

    // Update is called once per frame
    void Update()
    {
        if (StratSwicth == true)//スタートの合図
        {
            StratTime += 1 * Time.deltaTime;
            if (StratTime>=2&&StratTime<3) {
                StratText.text = "初め！";
            }
            else if (StratTime >= 3)
            {
                StratGO.SetActive(false);
                StratSwicth = false;
            }
        }
        if (time >= 0 && StratSwicth == false) {
            time -= 1f * Time.deltaTime;
            Timeslider.value = time;
            if (time<55)
            {
                yarinaosiBottan.SetActive(false);
            }
            //t.text = SavePoint.ToString();
        }else if (time<=0)
        {
            //Debug.Log("ゲームオーバー");
            GameSwicth = false;
            Scoretime += 1f * Time.deltaTime;
            owariText.SetActive(true);
            if (Scoretime>=3)
            {
                owariText.SetActive(false);
                GameUI.SetActive(false);
                if (ScoreBackGround.transform.position.y>=7.2)
                {
                    ScoreBackGround.transform.position-= new Vector3(0,20f*Time.deltaTime,0);
                }
                else
                {
                    EndScores.SetActive(true);
                    EndScore.text= SavePoint.ToString();
                    n1.a = (int)SavePoint;
                }

            }
        }
    }
}
