using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Pool;
using static ObjectPool;

public class ObjectPool : MonoBehaviour
{
    [System.Serializable]
    public class Pool
    {
        public string tag;
        public GameObject prefab;
        public int size;
        public Transform objectGroup;
    }

    public List<Pool> pools = new List<Pool>();
    private Dictionary<string, List<GameObject>> poolDictionary =
        new Dictionary<string, List<GameObject>>();
    
    void Start()
    {
        foreach (var pool in pools)
        {
            List<GameObject> spawnPool = new List<GameObject>();

            // 미리 poolSize만큼 게임오브젝트를 생성한다.
            for (int i = 0; i < pool.size; i++)
            {
                GameObject newObject = Instantiate(pool.prefab, pool.objectGroup);
                Release(spawnPool, newObject);
            }

            poolDictionary.Add(pool.tag, spawnPool);
        }
    }

    public void SpawnObject(string InTag)
    {
        Get(InTag);
    }

    public GameObject Get(string InTag)
    {
        if (!poolDictionary.ContainsKey(InTag))
        {
            return null;
        }
        List<GameObject> spawnObject = poolDictionary[InTag];

        foreach (GameObject outSpawnObj in spawnObject)
        {
            if (!outSpawnObj.activeSelf)
            {
                outSpawnObj.SetActive(true);
                // 꺼져있는 게임오브젝트를 찾아 active한 상태로 변경하고 return 한다.

                return outSpawnObj;
            }
        }

        if (spawnObject[spawnObject.Count].activeSelf)
        {
            for(int i = 0; i < poolDictionary.Count; i++)
            {
                if(poolDictionary.ContainsKey(InTag))
                {
                    GameObject outNewObject =
                        Instantiate(pools[i].prefab, pools[i].objectGroup);
                    Release(spawnObject, outNewObject);

                    outNewObject.SetActive(true);

                    return outNewObject;
                }
            }
        }

        return null;
    }

    public void Release(List<GameObject> inPoolList, GameObject InObj)
    {
        // 게임오브젝트를 deactive한다.
        InObj.SetActive(false);

        inPoolList.Add(InObj);
    }

    // [구현사항 1]
}
