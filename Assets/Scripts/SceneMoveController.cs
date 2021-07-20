using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneMoveController : MonoBehaviour
{
    public void TitleMoveButton()
    {
        SceneManager.LoadScene("SampleScene");
    }
    public void GameMoveButton()
    {
        SceneManager.LoadScene("GameScene");
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
