using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;


public class kurikku : MonoBehaviour, IPointerClickHandler
{
    // Start is called before the first frame update
    void Start()
    {
        
    }


    public void OnPointerClick(PointerEventData eventData)
    {
        Debug.Log("ゲームへ");
        //FadeManager.Instance.LoadScene("SampleScene2", 1.0f);
        //SceneManager.LoadScene(SampleScene2);

        //SceneManager.LoadScene("memoryScene");  //ゲームへ
        SceneManager.LoadScene("GameScene");  //ゲームへ

    }





    // Update is called once per frame
    void Update()
    {
        
    }
}
