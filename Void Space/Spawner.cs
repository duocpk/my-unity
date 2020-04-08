using UnityEngine;

public class Spawner : MonoBehaviour
{
    public float MaxRadius = 1f;
    public float Interval = 5f;
    public byte MaxEnemy = 5;
    public byte EnemyCount = 0;
    public GameObject ObjToSpawn = null;
    private Transform Origin = null;
    void Awake()
    {
        Origin = GameObject.FindGameObjectWithTag
        ("Player").GetComponent<Transform>();
    }
    void Start()
    {
        if (MaxEnemy > EnemyCount) {
            InvokeRepeating("Spawn", 0f, Interval);
            
        }
    }
    //------------------------------
    void Spawn()
    {
        if(MaxEnemy > EnemyCount)
        {
            if (Origin == null) return;
            Vector3 SpawnPos = Origin.position + Random.onUnitSphere *
            MaxRadius;
            SpawnPos = new Vector3(SpawnPos.x, 0f, SpawnPos.z);
            Instantiate(ObjToSpawn, SpawnPos, Quaternion.identity);
            EnemyCount++;
        }
    }
}