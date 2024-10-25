using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "DefaultQuestSO", menuName = "Quests/Default", order = 0)]
public class QuestDataSO : ScriptableObject
{
    [Header("Quest Info")]
    public string QuestName; // - ����Ʈ�� �̸�
    public int QuestRequiredLevel; // - ����Ʈ�� �ּҷ���
    public int QuestNPC; // - ����Ʈ�� �ִ� NPC�� id(int)
    public List<int> QuestPrerequisites; //- ���� ����Ʈ�� id���� ����Ʈ
    //[�������� 1]
}