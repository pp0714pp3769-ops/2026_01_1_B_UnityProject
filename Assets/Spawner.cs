using NUnit.Framework;
using UnityEngine;
using UnityEngine.Experimental.GlobalIllumination;

public class Spawner : MonoBehaviour
{
    public GameObject coinPrefabs;
    public GameObject MissilePrefabs;

    [Header("스폰 타이밍 설정")]
    public float minSpawnlnterval = 0.5f;
    public float maxSpawnlnterval = 2.0f;

    public float timer = 0.0f;
    public float nextSpawnTime;

    [Header("동전 스폰 확률 설정")]
    [UnityEngine.Range(0, 100)]
    public int coinSpawnChance = 50;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        SetNextSpawnTime();
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;

        if (timer > nextSpawnTime)
        {
            SpawnObjexct();
            timer = 0.0f;
            SetNextSpawnTime();
        }
      
    }
    void SpawnObjexct()
    {
        Transform spawnTransform = transform;

        int randomValue = Random.Range(0, 100);

        if (randomValue < coinSpawnChance)
        {
            Instantiate(coinPrefabs, spawnTransform.position, spawnTransform.rotation);
        }
        else
        {

            Instantiate(MissilePrefabs, spawnTransform.position, spawnTransform.rotation);

        }








    }




    void SetNextSpawnTime()
    {
        nextSpawnTime = Random.Range(minSpawnlnterval, maxSpawnlnterval);
    }
}
