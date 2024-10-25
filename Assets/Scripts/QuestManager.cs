using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuestManager : MonoBehaviour
{
    private static QuestManager instance;
    //[�������� 1] ���� �ʵ� ����

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
            $" (�ּҷ��� {Quests[inQuestNumber].QuestRequiredLevel})";
    }
    // [�������� 3?]
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
    // [�������� 2] ���� ������Ƽ ����

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
    // [�������� 3] �ν��Ͻ� �˻� ����
}
