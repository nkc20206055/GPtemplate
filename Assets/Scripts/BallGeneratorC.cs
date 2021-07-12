using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallGeneratorC : MonoBehaviour
{
    public GameObject busyuball;//BusyuBallプレハブの保存用変数
    public GameObject kangiball;//KangeBallプレハブの保存用変数
    public int[] kangeNamebers = new int[5];
    GameObject[] busyuballs = new GameObject[5];//生成したBusyuBallを保存する配列
    GameObject[] kangiballs = new GameObject[5];
    Vector3[] KangiPoss=new Vector3[5];
    BusyuBallController BBc;
    KangeBallController KBC;
    Transform parentTransform;
    public int SaveBusyuNumber, SaveKangiNumber;
    public bool kangeN, spriteR,changeSwithc;
    int t, Coutkange, saveCout, Notkange;
    int[] Savekange = new int[5];
    //private bool 
    //Vector3 busyuPos;
    void busyuBallController()
    {
        if (busyuballs[0] == null)//busyuballを撃ち終わったとき
        {
            //Debug.Log("無い");
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

    void kangeBallController()//KangeBallが消えた場合
    {
        {
            //GameObject Savekangi;
            //t = 0;
            //int[] SaveNumber=new int[5];//kangeNamebersを保存する変数
            ////for (int i=0;i<SaveNumber.Length;i++)
            ////{
            ////    GameObject k = kangiballs[i];
            ////    if (k != null)
            ////    {
            ////        k = new GameObject();
            ////        Debug.Log(k.name); // 名前を出力
            ////    }
            ////    KangeBallController KBC = k.GetComponent<KangeBallController>();
            ////    kangeNamebers[i] = KBC.kangeRandom;
            ////    SaveNumber[i] = kangeNamebers[i];
            ////}
            //for (int i=0;i<kangiballs.Length;i++) {
            //    //Debug.Log(kangiballs[i]);
            //    float Px, Py;
            //    if (kangiballs[i] == null)
            //    {
            //        //for (int c = 0; c < SaveNumber.Length; c++)
            //        //{
            //        //    Savekangi = kangiballs[i];
            //        //    if (Savekangi == null)
            //        //    {
            //        //        Savekangi = new GameObject();
            //        //        Debug.Log(Savekangi.name); // 名前を出力
            //        //    }
            //        //    KangeBallController KBC = Savekangi.GetComponent<KangeBallController>();
            //        //    kangeNamebers[i] = KBC.kangeRandom;
            //        //    SaveNumber[i] = kangeNamebers[i];
            //        //}

            //        Savekange[t] = i;//どの番号のKangeBallがないかを番号で保存
            //        t++;

            //        //m = true;
            //        //Debug.Log("なくなった " + i);
            //        Px = Random.Range(-7, 8);
            //        Py = Random.Range(6, 15);
            //        Savekangi = Instantiate(kangiball);
            //        KangeBallController KBC = Savekangi.GetComponent<KangeBallController>();
            //        //Savekange[t] = KBC.kangeRandom;
            //        //t = i;
            //        //Debug.Log(KBC.kangeRandom);
            //        Savekangi.transform.position = new Vector3(Px, Py, 0);
            //        kangeNamebers[i] = KBC.kangeRandom;
            //        kangiballs[i] = Savekangi;
            //        KangiPoss[i] = Savekangi.transform.position;
            //        spriteR = true;
            //    }
            //    //Debug.Log(KangiPoss[i]);

            //    //if (spriteR == true)
            //    //{

            //    //    //kBallNamberandPosSave();
            //    //    //newChangeKangeball();
            //    //    //kBallNamberandPosSave();
            //    //    //Savekangi = kangiballs[i];
            //    //    //Debug.Log(Savekangi+" "+i);

            //    //    //for (int l = 0; l < KangiPoss.Length; l++)
            //    //    //{
            //    //    //    Debug.Log(kangiballs[l] + " " + kangeNamebers[l] + " " + KangiPoss[l]);
            //    //    //}

            //    //    spriteR = false;
            //    //}

            //}
        }
        { 
        //for (int i = 0; i < kangiballs.Length; i++)
        //{
        //    if (i == t&&m==true)
        //    {
        //        KangeBallController KBC = kangiballs[t].GetComponent<KangeBallController>();
        //        Debug.Log(KBC.kangeRandom);
        //        m = false;
        //    }
        //}
        }

        //新しいほう
        Coutkange = parentTransform.transform.childCount;//子オブジェクトの数を数える
        if (Coutkange<5)
        {
            Notkange = 5;
            saveCout = 5 - Coutkange;//kangeballが何個無いかを取得
            float IPx, IPy;
            for (int i =0;i<saveCout;i++)
            {
                GameObject Inskange=Instantiate(kangiball);
                IPx = Mathf.Floor(Random.Range(-7, 8));
                IPy = Mathf.Floor(Random.Range(6, 15));
                Inskange.transform.position = new Vector3(IPx, IPy, 0);
                Notkange--;
            }
            Debug.Log(saveCout);
            spriteR = true;
        }
    }
    void kBallNamberandPosSave()//KangeBallの座標と変化したときの番号を再設定
    {
        if (spriteR == true)
        {
            {
                //for (int v = 0; v < kangiballs.Length; v++)
                //{
                //    GameObject go = kangiballs[v];
                //    KangiPoss[v] = go.transform.position;
                //    //Debug.Log(KangiPoss[v]);
                //    KangeBallController kbc = go.GetComponent<KangeBallController>();
                //    kangeNamebers[v] = kbc.kangeRandom;
                //    //Debug.Log(kangeNamebers[v]);
                //    Debug.Log(/*kangiballs[v] */v+ " " + kangeNamebers[v] + " " + KangiPoss[v]);
                //}
            }

            Vector3 InsPsaveP = Vector3.zero;
            for (int i=0;i< saveCout; i++)//新しく作ったkangeballのkangeRandomを被らないように再設定
            {
                int NamberCout=0,PosCout=0;
                Transform Ikange= parentTransform.GetChild(Notkange);//子オブジェクを取得
                KBC = Ikange.GetComponent<KangeBallController>();//取得した子オブジェクトのC＃スクリプトを取得

                while (NamberCout < 4)//作った漢字が被らないようにする処理
                {
                    for (int c = 0; c < 5; c++)
                    {
                        KangeBallController subK = parentTransform.GetChild(c).GetComponent<KangeBallController>();
                        if (Notkange != c && KBC.kangeRandom != subK.kangeRandom)
                        {
                            NamberCout++;
                        }                    
                    }
                    if (NamberCout < 4)
                    {
                        int changeK = Random.Range(0, 10);
                        KBC.spriteChangeS(changeK);
                        NamberCout = 0;
                    }
                }//作った漢字が被らないようにする処理

                float InsRX, InsRY;
                Vector3 InsP;
                InsRX = Ikange.transform.position.x;
                InsRY = Ikange.transform.position.y;
                while (PosCout<4)
                {
                    for (int l = 0; l < 5; l++)
                    {
                        Transform Kkange = parentTransform.GetChild(l);
                        InsP = Kkange.transform.position;

                        if (i != l)
                        {
                            if (InsP.x != InsRX && InsP.y != InsRY)
                            {
                                PosCout++;
                                if (PosCout >= 4)
                                {
                                    InsPsaveP = new Vector3(InsRX, InsRY, 0);
                                }
                            }
                            else
                            {
                                PosCout = 0;
                            }
                        }
                    }
                    if (PosCout < 4)
                    {
                        InsRX = Mathf.Floor(Random.Range(-7, 8));
                        InsRY = Mathf.Floor(Random.Range(6, 15));
                        InsPsaveP = new Vector3(InsRX, InsRY, 0);
                        PosCout = 0;
                    }
                }//作った漢字の位置が被らないようにする処理
                Ikange.transform.position = InsPsaveP;

                Notkange++;
            }

            spriteR = false;
        }

        {
            //changeSwithc = true;
            //int tt = 0,savek=0;
            //for (int i=0;i<kangiballs.Length;i++)
            //{
            //    GameObject tyngeGO = kangiballs[i];
            //    //漢字を調べる
            //    KangeBallController KBC = tyngeGO.GetComponent<KangeBallController>();
            //    while (changeSwithc==true)
            //    {
            //        for (int o=0;o<kangeNamebers.Length;o++)
            //        {
            //            if (KBC.kangeRandom!=kangeNamebers[o])
            //            {
            //                tt++;
            //            }
            //        }
            //        if (tt>=5)
            //        {
            //            changeSwithc = false;
            //        }
            //        else if (tt<5)
            //        {
            //            KBC.kangeRandom = Random.Range(0, 10);
            //            tt = 0;
            //        }
            //    }
            //    Debug.Log(KBC.kangeRandom);
            //    KBC.spriteChangeS(KBC.kangeRandom);
            //    //kangeNamebers[i] = KBC.kangeRandom;
            //}

            //for (int v = 0; v < kangiballs.Length; v++)
            //{
            //    GameObject go = kangiballs[v];
            //    KangiPoss[v] = go.transform.position;
            //    //Debug.Log(KangiPoss[v]);
            //    KangeBallController kbc = go.GetComponent<KangeBallController>();
            //    kangeNamebers[v] = kbc.kangeRandom;
            //    Debug.Log(kangeNamebers[v]);
            //}
        }
    }
    void newChangeKangeball()//追加したkangeballが他とかぶっていないか確認
    {
        changeSwithc = true;
        int tm = 0,saveK=0,savuK=0;
        for (int i=0;i<t;i++)
        {
            GameObject go = kangiballs[Savekange[i]];
            KangeBallController kbC = go.GetComponent<KangeBallController>();
            Debug.Log(Savekange[i]+" "+kbC.kangeRandom);
            saveK = kbC.kangeRandom;
            savuK = kbC.kangeRandom;
            while (changeSwithc == true)
            {
                for(int s = 0; s < kangeNamebers.Length; s++)
                {
                    if (kangeNamebers[i]!=saveK&&savuK!=saveK)
                    {
                        tm++;
                    }
                }
                if (tm>=5)
                {
                    changeSwithc = false;
                }
                else if (tm<5)
                {
                    saveK = Random.Range(0, 10);
                    tm = 0;
                }
            }
            kbC.spriteChangeS(saveK);
            Debug.Log(Savekange[i] + " " + kbC.kangeRandom);
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        spriteR = false; 
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
                Rx = Mathf.Floor(Random.Range(-7, 8));
                Ry = Mathf.Floor(Random.Range(6, 15));
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
            //KangeBallController KBC = Savekangi.GetComponent<KangeBallController>();
            //kangeNamebers[i] = KBC.kangeRandom;
            //Debug.Log(KBC.kangeRandom);
            Savekangi.transform.position = new Vector3(Rx, Ry, 0);
            Debug.Log(Savekangi.transform.position);
            kangiballs[i] = Savekangi;
            KangiPoss[i] = Savekangi.transform.position;
            //Debug.Log(KangiPoss[i]);
        }

        kangeN = true;

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
        if (kangeN == true)//kangiballsのkangeRandom番号と座標を保存
        {
            //新しく作る方
            Vector3 PsavePos = Vector3.zero;
             parentTransform = GameObject.Find("KangeBallGroup").transform;//親オブジェクト取得
            for (int i = 1; i < 5; i++)//※最初のkangeballは変更しなくていいので4回処理をする
            {
                int namberC = 0, PosC = 0;
                Transform childTf = parentTransform.GetChild(i);//子オブジェクを取得
                KBC = childTf.GetComponent<KangeBallController>();
                while (namberC < 4)//kangeballの番号が被らないように変更する
                {
                        for (int l = 0; l < 5; l++)
                        {
                            Transform Kkange = parentTransform.GetChild(l);
                            KangeBallController kbc = Kkange.GetComponent<KangeBallController>();
                            if (i != l && KBC.kangeRandom != kbc.kangeRandom)
                            {
                                namberC++;
                            }
                        }
                        if (namberC < 4)
                        {
                            int changeK = Random.Range(0, 10);
                            KBC.spriteChangeS(changeK);
                            namberC = 0;
                        }
                }//kangeballの番号が被らないように変更する

                float Rx, Ry;
                Vector3 savP;
                Rx = childTf.transform.position.x;
                Ry = childTf.transform.position.y;
                while (PosC < 4)//kangeballの位置が被らないように変更する
                {
                        for (int l = 0; l < 5; l++)
                        {
                            Transform Kkange = parentTransform.GetChild(l);
                            savP = Kkange.transform.position;

                            if (i != l)
                            {
                                if (savP.x != Rx&& savP.y != Ry)
                                {
                                    //if (savP.y != Ry)
                                    //{
                                        PosC++;
                                        if (PosC >= 4)
                                        {
                                          PsavePos = new Vector3(Rx, Ry, 0);
                                          //Debug.Log(savP + " " + Rx + " "+Ry);
                                        }
                                    //}
                                    //else
                                    //{
                                    //    PosC = 0;
                                    //}
                                }
                                else
                                {
                                    PosC = 0;
                                }
                            }
                        }
                        if (PosC < 4)
                        {
                            Rx = Mathf.Floor(Random.Range(-7, 8));
                            Ry = Mathf.Floor(Random.Range(6, 15));
                            PsavePos = new Vector3(Rx, Ry, 0);
                            PosC = 0;
                        }
                }//kangeballの位置が被らないように変更する
                childTf.transform.position = PsavePos;
            }

           for (int i=0;i<5;i++)
           {
              Transform p = parentTransform.GetChild(i);
              Debug.Log(i + " " + p.transform.position);
           }

            kangeN = false;
        }
        kBallNamberandPosSave();

        busyuBallController();
        kangeBallController();
        //kBallNamberandPosSave();

    }
}
