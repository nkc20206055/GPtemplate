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
                        break;
                    case 5:
                        Debug.Log("当たった"+kangeRandom);
                        break;
                }
                break;
            case 1:
                switch (kangeRandom)
                {
                    case 1:
                        Debug.Log("当たった 1");
                        break;
                    case 6:
                        Debug.Log("当たった" + kangeRandom);
                        break;
                }
                break;
            case 2:
                switch (kangeRandom)
                {
                    case 2:
                        Debug.Log("当たった 2");
                        break;
                    case 7:
                        Debug.Log("当たった" + kangeRandom);
                        break;
                }
                break;
            case 3:
                switch (kangeRandom)
                {
                    case 3:
                        Debug.Log("当たった 3");
                        break;
                    case 8:
                        Debug.Log("当たった" + kangeRandom);
                        break;
                }
                break;
            case 4:
                switch (kangeRandom)
                {
                    case 4:
                        Debug.Log("当たった 4");
                        break;
                    case 9:
                        Debug.Log("当たった" + kangeRandom);
                        break;
                }
                break;
        }
            
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
