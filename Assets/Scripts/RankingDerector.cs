using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RankingDerector : MonoBehaviour
{
    const string SaveRanking = "Ranking";
    const int RankingCount = 3;
    int[] RankingSaves = new int[RankingCount];
    public Text Text, Text1, Text2;
    int SaveScore;
    private bool StartSwithc = true;
    // Start is called before the first frame update
    void Start()
    {
        SaveScore = n1.getA();//HierarchyにないC#スクリプト　n1から
    }

    // Update is called once per frame
    void Update()
    {
        if (StartSwithc==true)//ランキング表示
        {
            Text1.text = "2.";
            int[] RankingHiretu = new int[RankingCount];//値として一時保存用
            string[] RankingString = new string[RankingCount];//string型に書き換える用
            string scoreRanking = PlayerPrefs.GetString(SaveRanking);
            if (PlayerPrefs.HasKey(SaveRanking))//保存データRankingがある場合
            {
                Debug.Log("dateは存在している");
                RankingString = scoreRanking.Split(',');//一列になっている文字列を配列RankingStringに代入
                for (int i=0;i< RankingCount;i++)//int型に変換して代入
                {
                    RankingHiretu[i] = int.Parse(RankingString[i]);
                }
                int mainasuCount = 2;
                for (int s=0;s<RankingCount;s++)
                {
                    if (RankingHiretu[mainasuCount] <SaveScore)
                    {
                        if (mainasuCount == 2)
                        {
                            RankingHiretu[mainasuCount] = SaveScore;
                        }
                        else
                        {
                            int t = RankingHiretu[mainasuCount + 1];
                            RankingHiretu[mainasuCount + 1] = RankingHiretu[mainasuCount];
                            RankingHiretu[mainasuCount] = t;
                        }
                        mainasuCount--;
                    }
                }
            }
            else
            {
                //データが無い場合
                Debug.Log("dateは存在していない");
                RankingHiretu[0] = SaveScore;
                Text.text = "1." + SaveScore.ToString();
            }
            for (int r=0;r<RankingCount;r++)//textに表示
            {
                switch (r) {
                    case 0:
                        Text.text = "1." + RankingHiretu[0];
                        break;
                    case 1:
                        Text1.text = "2." + RankingHiretu[1];
                        break;
                    case 2:
                        Text2.text = "3." + RankingHiretu[2];
                        break;
                }

            }
            for (int i=0;i< RankingCount; i++)//
            {
                RankingString[i] = RankingHiretu[i].ToString();
            }
            string RankingSummarize = string.Join(",", RankingString);//一列の文字列に変換する
            Debug.Log(RankingSummarize);
            PlayerPrefs.SetString(SaveRanking, RankingSummarize);
            PlayerPrefs.Save();//セーブを実行する
            StartSwithc = false;
        }

        if (Input.GetKeyDown(KeyCode.D))
        {
            PlayerPrefs.DeleteKey(SaveRanking);
        }
    }
}
