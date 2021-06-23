using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class gamedirctor : MonoBehaviour
{
    Text t;
    public float puraspoint,SavePoint;
    // Start is called before the first frame update
    void Start()
    {
        SavePoint = 0;
        t = GameObject.Find("PointText").GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        t.text = SavePoint.ToString();
    }
}
