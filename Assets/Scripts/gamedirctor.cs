using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class gamedirctor : MonoBehaviour
{
    [SerializeField] GameObject owariText;
    [SerializeField] GameObject EndScores;
    GameObject GameUI,ScoreBackGround;
    Text t,EndScore;
    Slider Timeslider;
    public float puraspoint,SavePoint,time,Scoretime;
    public bool GameSwicth = true;
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
        EndScore = EndScores.GetComponent<Text>();
        float MaxS = 100;
        time = 10;
        SavePoint = 0;
        t = GameObject.Find("PointText").GetComponent<Text>();
        Timeslider = GameObject.Find("TimeSlider").GetComponent<Slider>();
        //Timeslider.maxValue = MaxS;
        //Timeslider.value = MaxS;
    }

    // Update is called once per frame
    void Update()
    {
        if (time>= 0) {
            time -= 1f * Time.deltaTime;
            Timeslider.value = time;
            //t.text = SavePoint.ToString();
        }else if (time<=0)
        {
            Debug.Log("ゲームオーバー");
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
                }

            }
        }
    }
}
