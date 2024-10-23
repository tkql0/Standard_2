using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectPool : MonoBehaviour
{
    public GameObject prefab;
    private List<GameObject> pool = new List<GameObject>();
    public int poolSize = 300;
    
    void Start()
    {
        // 미리 poolSize만큼 게임오브젝트를 생성한다.
        for (int i = 0; i < poolSize; i++)
        {
            Release(Instantiate(prefab, transform));
        }
    }

    public GameObject Get()
    {
        if (pool[0] != null)
        {
            return null;
        }
        pool[0].SetActive(true);
        // 꺼져있는 게임오브젝트를 찾아 active한 상태로 변경하고 return 한다.

        return pool[0];
    }

    public void Release(GameObject obj)
    {
        // 게임오브젝트를 deactive한다.
        obj.SetActive(false);

        pool.Add(obj);
    }

    // [구현사항 1]
}
