using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KangeBallController : MonoBehaviour,Interface
{
    public Sprite[] kangis;
    public Sprite[] Completekanges;
    SpriteRenderer sr;
    gamedirctor gd;
    BallGeneratorC BGc;
    public int kangeRandom;
    public bool spriteChange,DestroySwithc;
    float Count, MaxCount;
    void Interface.Dameg(int i)
    {
        //Debug.Log(i);
        switch (i) 
        {
            case 0:
                if (kangeRandom==0|| kangeRandom==5)//ぎょうにんべん（せい(びょうにんべん＋西)、徨）
                {
                    //Debug.Log("当たった" + kangeRandom);
                    GamePoint();
                    DestroySwithc = true;
                }
                break;
            case 1:
                if (kangeRandom == 1 || kangeRandom == 6)//にんべん（們、做）
                {
                    //Debug.Log("当たった" + kangeRandom);
                    GamePoint(); 
                    DestroySwithc = true;
                }
                break;
            case 2:
                if (kangeRandom == 2 || kangeRandom == 7)//こざとへん（陣、険）
                {
                    //Debug.Log("当たった" + kangeRandom);
                    GamePoint();
                    DestroySwithc = true;
                }
                break;
            case 3:
                if (kangeRandom == 3 || kangeRandom == 8)//つちへん（在、坤）
                {
                    //Debug.Log("当たった" + kangeRandom);
                    GamePoint();
                    DestroySwithc = true;
                }
                break;
            case 4:
                if (kangeRandom == 4 || kangeRandom == 9)//にすい（凍、凉）
                {
                    //Debug.Log("当たった" + kangeRandom);
                    GamePoint();
                    DestroySwithc = true;
                }
                break;
        }
    }
    void GamePoint()
    {
        Vector3 i = transform.position;
        gd.SavePoint += 50*i.y;
        //Debug.Log(gd.SavePoint);
    }
    void Randmukangi()
    {
        if (spriteChange == true)
        {
            int o;
            while (BGc.SaveKangiNumber == kangeRandom)
            {
                o = Random.Range(0, 10);
                //Debug.Log(o);
                kangeRandom = o;
            }
            BGc.SaveKangiNumber = kangeRandom;
            //Debug.Log(BGc.SaveKangiNumber);
            spriteChange = false;
        }
    }
    public void spriteChangeS(int i)
    {
        kangeRandom = i;
        sr.sprite = kangis[i];
    }
    void GODestroy()
    {
        Debug.Log("死んだ");
        sr.sprite = Completekanges[kangeRandom];     
        Count+=1*Time.deltaTime;
        if (Count>=MaxCount) {
            Destroy(gameObject);
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        MaxCount = 2;
        DestroySwithc = false;
        sr = gameObject.GetComponent<SpriteRenderer>();
        gd = GameObject.Find("GameDirector").GetComponent<gamedirctor>();
        BGc = GameObject.Find("BallGenerator").GetComponent<BallGeneratorC>();
        kangeRandom = Random.Range(0, 10);
        //Debug.Log(kangeRandom);
        //Randmukangi();
        sr.sprite = kangis[kangeRandom];
        //Debug.Log(kangeRandom);
    }

    // Update is called once per frame
    void Update()
    {
        if (DestroySwithc == true)
        {
            GODestroy();
        }
    }
}
