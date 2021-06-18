using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KangeBallController : MonoBehaviour,Interface
{
    public Sprite[] kangis;
    SpriteRenderer sr;
    private int kangeRandom;
    void Interface.Dameg(int i)
    {
        //Debug.Log(i);
        switch (i) 
        {
            case 0:
                switch (kangeRandom)
                {
                    case 0:
                        Debug.Log("当たった 0");
                        GODestroy();
                        break;
                    case 5:
                        Debug.Log("当たった"+kangeRandom);
                        GODestroy();
                        break;
                }
                break;
            case 1:
                switch (kangeRandom)
                {
                    case 1:
                        Debug.Log("当たった 1");
                        GODestroy();
                        break;
                    case 6:
                        Debug.Log("当たった" + kangeRandom); 
                        GODestroy();

                        break;
                }
                break;
            case 2:
                switch (kangeRandom)
                {
                    case 2:
                        Debug.Log("当たった 2");
                        GODestroy();

                        break;
                    case 7:
                        GODestroy();
                        Debug.Log("当たった" + kangeRandom);
                        break;
                }
                break;
            case 3:
                switch (kangeRandom)
                {
                    case 3:
                        Debug.Log("当たった 3");
                        GODestroy();
                        break;
                    case 8:
                        Debug.Log("当たった" + kangeRandom);
                        GODestroy();
                        break;
                }
                break;
            case 4:
                switch (kangeRandom)
                {
                    case 4:
                        Debug.Log("当たった 4");
                        GODestroy();
                        break;
                    case 9:
                        Debug.Log("当たった" + kangeRandom);
                        GODestroy();
                        break;
                }
                break;
        }
    }
    void GODestroy()
    {
        Destroy(gameObject);
    }
    // Start is called before the first frame update
    void Start()
    {
        sr = gameObject.GetComponent<SpriteRenderer>();
        kangeRandom = Random.Range(0, 10);
        sr.sprite = kangis[kangeRandom];
        Debug.Log(kangeRandom);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
