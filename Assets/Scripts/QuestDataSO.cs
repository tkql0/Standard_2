using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "DefaultQuestSO", menuName = "Quests/Default", order = 0)]
public class QuestDataSO : ScriptableObject
{
    [Header("Quest Info")]
    public string QuestName; // - 퀘스트의 이름
    public int QuestRequiredLevel; // - 퀘스트의 최소레벨
    public int QuestNPC; // - 퀘스트를 주는 NPC의 id(int)
    public List<int> QuestPrerequisites; //- 선행 퀘스트의 id들의 리스트
    //[구현사항 1]
}
//**[구현사항 2]**

//`QuestDataSO`를 상속받는 `MonsterQuestDataSO`와 `EncounterQuestDataSO`를 정의하고, 각각에 필드를 한 개씩 정의한 뒤(본인이 임의로 넣어보면 됩니다.) 이를 생성해봅시다.

//**[구현사항 3]**

//Q1에서 정의한 `QuestManager`에 퀘스트 데이터들을 다양하게 생성하여 `Quests` 필드를 정의하여 인스펙터창에 넣고, 시작하면 모든 퀘스트의 이름과 최소레벨을 아래와 같이 출력하세요.

//- Quest `1` - `유니티 마스터가 되는 길` (최소 레벨 `70`)
//- Quest `2` - `스파르타에 입성했다` (최소 레벨 `10`)

//(단, `코드처리`된 부분은 목록으로 출력되면서 변하는 부분임.)

//**[선택 구현사항]**

//[구현사항 3]의 Quest의 정보를 출력할 때 퀘스트의 내용을 `MonsterQuestDataSO`인지, `EncounterQuestDataSO`인지에 따라 다르게 출력하세요. 아래는 예시입니다.

//- Quest `1` - `유니티 마스터가 되는 길` (최소 레벨 `70`)

//    `*안혜린 매니저님의 꾸준과제`를* `*50마리` 소탕*

//- Quest `2` - `스파르타에 입성했다` (최소 레벨 `10`)

//    `*한효승 매니저님`과* *대화하기*


//(단, *이탤릭체*된 부분은 상속받은 클래스의 하위 클래스에 따라 달라지는 내용임.)**[구현사항 1]**

//퀘스트의 정보를 저장하는 스크립터블 오브젝트 **`QuestDataSO`**를 정의하세요.
//**`QuestDataSO`**에는 아래와 같은 필드를 정의하세요. 

//- `QuestName` - 퀘스트의 이름
//- `QuestRequiredLevel` - 퀘스트의 최소레벨
//- `QuestNPC` - 퀘스트를 주는 NPC의 id (int)
//- `QuestPrerequisites` - 선행 퀘스트의 id들의 리스트

//**[구현사항 2]**

//`QuestDataSO`를 상속받는 `MonsterQuestDataSO`와 `EncounterQuestDataSO`를 정의하고, 각각에 필드를 한 개씩 정의한 뒤(본인이 임의로 넣어보면 됩니다.) 이를 생성해봅시다.

//**[구현사항 3]**

//Q1에서 정의한 `QuestManager`에 퀘스트 데이터들을 다양하게 생성하여 `Quests` 필드를 정의하여 인스펙터창에 넣고, 시작하면 모든 퀘스트의 이름과 최소레벨을 아래와 같이 출력하세요.

//- Quest `1` - `유니티 마스터가 되는 길` (최소 레벨 `70`)
//- Quest `2` - `스파르타에 입성했다` (최소 레벨 `10`)

//(단, `코드처리`된 부분은 목록으로 출력되면서 변하는 부분임.)

//**[선택 구현사항]**

//[구현사항 3]의 Quest의 정보를 출력할 때 퀘스트의 내용을 `MonsterQuestDataSO`인지, `EncounterQuestDataSO`인지에 따라 다르게 출력하세요. 아래는 예시입니다.

//- Quest `1` - `유니티 마스터가 되는 길` (최소 레벨 `70`)

//    `*안혜린 매니저님의 꾸준과제`를* `*50마리` 소탕*

//- Quest `2` - `스파르타에 입성했다` (최소 레벨 `10`)

//    `*한효승 매니저님`과* *대화하기*


//(단, *이탤릭체*된 부분은 상속받은 클래스의 하위 클래스에 따라 달라지는 내용임.)