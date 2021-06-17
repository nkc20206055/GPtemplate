using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallGeneratorC : MonoBehaviour
{
    public GameObject busyuball;//BusyuBallプレハブの保存用変数
    GameObject[] busyuballs = new GameObject[5];//
    //Vector3 busyuPos;
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
            GameObject Savebusyu = Instantiate(busyuball) as GameObject;
            BBC = Savebusyu.GetComponent<BusyuBallController>();
            Debug.Log(BBC);
            if (i <= 0)
            {
                BBC.suwipSwitch = true;
                //Debug.Log(BBC.suwipSwitch);
            }
            else
            {
                BBC.suwipSwitch = false;
            }
            busyuballs[i] = Savebusyu;
            BusyuBallController BBc = busyuballs[i].GetComponent<BusyuBallController>();
            BBc.suwipSwitch = true;
            Debug.Log(BBc.suwipSwitch);
            busyuballs[i].transform.position = new Vector3(busyuPosx, 0, 0);         
            busyuPosx += 2f;
        }
    }

    // Update is called once per frame
    void Update()
    {
        //if (Input.GetKeyDown(KeyCode.B))
        //{
        //    Instantiate(busyuball);
        //}
    }
}
