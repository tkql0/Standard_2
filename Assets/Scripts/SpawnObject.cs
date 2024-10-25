using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnObject : MonoBehaviour
{
    private void OnEnable()
    {
        Invoke("GameObjectDeSpawn", 3f);
    }

    void GameObjectDeSpawn()
    {
        gameObject.SetActive(false);
    }
}
