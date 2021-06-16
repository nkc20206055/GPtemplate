using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gamedirctor : MonoBehaviour
{
    public GameObject busyuBoll;
    GameObject[] busyuPrefab;
    // Start is called before the first frame update
    void Start()
    {
        busyuPrefab = new GameObject[5];
        for (int i=0;busyuPrefab.Length>i;i++)
        {
            Debug.Log(i);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
