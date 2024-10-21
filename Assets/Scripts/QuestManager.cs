using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuestManager : MonoBehaviour
{
    private static QuestManager instance;
    //[�������� 1] ���� �ʵ� ����

    public static QuestManager Instance
    {
        get
        {
            if (instance == null)
                instance = FindObjectOfType<QuestManager>();

            if (instance == null)
                instance = new GameObject("QuestManager").AddComponent<QuestManager>();

            return instance;
        }
    }
    // [�������� 2] ���� ������Ƽ ����
}
