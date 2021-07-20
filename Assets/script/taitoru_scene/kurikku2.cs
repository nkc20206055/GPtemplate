using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;


public class kurikku2 : MonoBehaviour, IPointerClickHandler
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void OnPointerClick(PointerEventData eventData)
    {
        Debug.Log("やり方");
        //FadeManager.Instance.LoadScene("momeryScene", 1.0f);

        SceneManager.LoadScene("SampleScene2"); //説明のページへ



    }


    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.LeftShift))
        {
            SceneManager.LoadScene("RankingScreen");
        }
    }
}
