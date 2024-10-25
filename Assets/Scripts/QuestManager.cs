using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuestManager : MonoBehaviour
{
    private static QuestManager instance;
    //[구현사항 1] 정적 필드 정의

    public QuestDataSO[] Quests;

    private void OnEnable()
    {
        for (int i = 0; i < Quests.Length; i++)
        {
            Debug.Log(Quest(i));
        }
    }

    string Quest(int inQuestNumber)
    {
        return $"Quist {inQuestNumber + 1} - " +
            $"{Quests[inQuestNumber].QuestName}" +
            $" (최소레벨 {Quests[inQuestNumber].QuestRequiredLevel})";
    }
    // [구현사항 3?]
    public static QuestManager Instance
    {
        get
        {
            if (instance == null)
            {
                instance = FindObjectOfType<QuestManager>();

                if (instance == null)
                    instance = new GameObject("QuestManager").AddComponent<QuestManager>();
            }

            return instance;
        }
    }
    // [구현사항 2] 정적 프로퍼티 정의

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(this.gameObject);
        }
        else
        {
            Destroy(this.gameObject);
        }
    }
    // [구현사항 3] 인스턴스 검사 로직
}
