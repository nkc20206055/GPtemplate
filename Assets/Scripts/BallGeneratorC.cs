using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallGeneratorC : MonoBehaviour
{
    public GameObject busyuball;//BusyuBallプレハブの保存用変数
    public GameObject kangiball;//KangeBallプレハブの保存用変数
    int[] kangeNamebers = new int[5];
    GameObject[] busyuballs = new GameObject[5];//生成したBusyuBallを保存する配列
    GameObject[] kangiballs = new GameObject[5];
    Vector3[] KangiPoss=new Vector3[5];
    BusyuBallController BBc;
    public int SaveBusyuNumber, SaveKangiNumber;
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

    void kangeBallController()
    {
        for (int i=0;i<kangiballs.Length;i++) {
            //Debug.Log(kangiballs[i]);
            float Px, Py;
            if (kangiballs[i] == null)
            {
                Debug.Log("なくなった " + i);
                Px = Random.Range(-7, 8);
                Py = Random.Range(6, 15);
                GameObject Savekangi = Instantiate(kangiball);
                Savekangi.transform.position = new Vector3(Px, Py, 0);
                kangiballs[i] = Savekangi;
                KangiPoss[i] = Savekangi.transform.position;
            }
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        //BusyuBallController BBC = null;
        //busyuPos = new Vector3(0, 0, 0);
        float busyuPosx = 0;
        //busyuballs = new GameObject[5];
        for (int i = 0; busyuballs.Length > i; i++)
        {
            //Debug.Log(i);
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
            //Debug.Log(BBc.suwipSwitch);
            busyuballs[i].transform.position = new Vector3(busyuPosx, 0, 0);         
            busyuPosx += 2f;
        }

        int t;
        float Rx, Ry;
        for (int i=0;i<KangiPoss.Length;i++)
        {
            //Rx = Random.Range(-7, 8);
            //Ry = Random.Range(6, 15);
            do
            {
                t = 0;
                Rx = Random.Range(-7, 8);
                Ry = Random.Range(6, 15);
                for (int L = 0; L < KangiPoss.Length; L++)
                {
                    if (KangiPoss[L].x - 2f > Rx || KangiPoss[L].x + 2f < Rx||KangiPoss[L].x!=Rx)
                    {
                        if (KangiPoss[L].y - 2f > Ry || KangiPoss[L].y + 2f < Ry || KangiPoss[L].y != Ry)
                        {
                            t++;
                            //Debug.Log(KangiPoss[L]);
                        }
                        else
                        {
                            t = 0;
                        }
                    }
                    else
                    {
                        t = 0;
                    }
                    //t = -10;
                    //t = t + -2;
                    //Debug.Log(t);
                }
                //t = 4;
            } while (t >= 4);
            GameObject Savekangi = Instantiate(kangiball);
            KangeBallController KBC = Savekangi.GetComponent<KangeBallController>();
            kangeNamebers[i] = KBC.kangeRandom;
            Debug.Log(KBC.kangeRandom);
            Savekangi.transform.position = new Vector3(Rx, Ry, 0);
            kangiballs[i] = Savekangi;
            KangiPoss[i] = Savekangi.transform.position;
            //Debug.Log(KangiPoss[i]);
        }

        //Object[] allGameObject = Resources.FindObjectsOfTypeAll(typeof(GameObject));
        //// 取得したオブジェクトの名前を表示
        //foreach (GameObject obj in allGameObject)
        //{
        //    Debug.Log(obj.name);
        //}

        //// typeで指定した型の全てのオブジェクトを配列で取得し,その要素数分繰り返す.
        //foreach (GameObject obj in UnityEngine.Object.FindObjectsOfType(typeof(GameObject)))
        //{
        //    // シーン上に存在するオブジェクトならば処理.
        //    if (obj.activeInHierarchy)
        //    {
        //        // GameObjectの名前を表示.
        //        Debug.Log(obj.name);
        //    }
        //}
    }

    // Update is called once per frame
    void Update()
    {
        busyuBallController();
        kangeBallController();
    }
}
