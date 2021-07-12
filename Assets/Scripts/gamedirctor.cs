using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class gamedirctor : MonoBehaviour
{
    Text t;
    Slider Timeslider;
    public float puraspoint,SavePoint,time;
    public void purasPoint()
    {
        t.text = SavePoint.ToString();
        if (time<90) {
            time += 10;
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        float MaxS = 100;
        time = 100;
        SavePoint = 0;
        t = GameObject.Find("PointText").GetComponent<Text>();
        Timeslider = GameObject.Find("TimeSlider").GetComponent<Slider>();
        //Timeslider.maxValue = MaxS;
        //Timeslider.value = MaxS;
    }

    // Update is called once per frame
    void Update()
    {
        time -= 1f* Time.deltaTime;
        Timeslider.value = time;
        //t.text = SavePoint.ToString();
    }
}
