using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameConto : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }
    public static GameConto Instance{get; private set; }
    public int score { get; private set; }

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }
    //スタートメソッド
    public void StartGame()
    {
        //SceneData.score = 0;
        SceneManager.LoadScene("GameScenes");
    }

    //エンドメソッド
    public void EndGame()
    {
        //獲得したスコアとリザルト画面へ遷移
        //SceneData.score = ScoreScript.instance.GetCurrentScore();

        SceneManager.LoadScene("ResultScenes");
    }
}
