using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class n1 : MonoBehaviour
{

    public static int a = 100;
    //public static int a;
    
    //↑スコアの
    //



    // Start is called before the first frame update
    void Start()
    {
        DontDestroyOnLoad(this);

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public static int getA()    //スコア移動
    {
        return a;
    }


}

