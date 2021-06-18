using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallGeneratorC : MonoBehaviour
{
    public GameObject busyuball;//BusyuBallプレハブの保存用変数
    public GameObject kangiball;//KangeBallプレハブの保存用変数
    GameObject[] busyuballs = new GameObject[5];//生成したBusyuBallを保存する配列
    Vector3[] KangiPoss=new Vector3[5];
    BusyuBallController BBc;
    //private bool 
    //Vector3 busyuPos;
    void busyuBallController()
    {
        if (busyuballs[0] == null)//busyuballを撃ち終わったとき
        {
            Debug.Log("無い");
            float busyuPosx = 2;
            for (int i = 1; busyuballs.Length > i; i++)
            {
                busyuballs[i - 1] = busyuballs[i];
                Vector3 busyuP = busyuballs[i - 1].transform.position;
                busyuballs[i - 1].transform.position = new Vector3(busyuP.x - busyuPosx, 0, 0);
            }
            busyuballs[4] = Instantiate(busyuball) as GameObject;
            busyuballs[4].transform.position = new Vector3(8, 0, 0);
            for (int i = 0; busyuballs.Length > i; i++)
            {
                BBc = busyuballs[i].GetComponent<BusyuBallController>();
                if (i <= 0)
                {
                    BBc.suwipSwitch = true;
                }
                else
                {
                    BBc.suwipSwitch = false;
                }
                //Debug.Log(BBc.suwipSwitch);
            }
        }

    }
    // Start is called before the first frame update
    void Start()
    {
        BusyuBallController BBC = null;
        //busyuPos = new Vector3(0, 0, 0);
        float busyuPosx = 0;
        //busyuballs = new GameObject[5];
        for (int i = 0; busyuballs.Length > i; i++)
        {
            Debug.Log(i);
            busyuballs[i] = Instantiate(busyuball) as GameObject;
            BBc = busyuballs[i].GetComponent<BusyuBallController>();
            if (i <= 0)
            {
                BBc.suwipSwitch = true;
                //Debug.Log(BBC.suwipSwitch);
            }
            else
            {
                BBc.suwipSwitch = false;
            }
            Debug.Log(BBc.suwipSwitch);
            busyuballs[i].transform.position = new Vector3(busyuPosx, 0, 0);         
            busyuPosx += 2f;
        }

        for (int i=0;i<5;i++)
        {

        }
    }

    // Update is called once per frame
    void Update()
    {
        busyuBallController();
    }
}
