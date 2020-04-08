using UnityEngine;

public class ObjectHealth : MonoBehaviour
{
    public GameObject DeathParticlesPrefab = null;
    private Transform ThisTransform = null;
    // Start is called before the first frame update
    public float HealthPoint
    {
        get
        {
            return this.HealthPoints;
        }
        set
        {
            this.HealthPoints = value;
            if (HealthPoints <= 0)
            {
                if(this.tag == "Enemy")
                {
                    GameObject.Find("Spawner").GetComponent<Spawner>().EnemyCount--;
                    GameObject.Find("Spawner").GetComponent<Spawner>().MaxEnemy++;
                }
                SendMessage("Die",
                SendMessageOptions.DontRequireReceiver);
                if (DeathParticlesPrefab != null)
                    Instantiate(DeathParticlesPrefab,
                    ThisTransform.position, ThisTransform.rotation);
                Destroy(gameObject);
            }
        }
    }
    void Start()
    {
        ThisTransform = GetComponent<Transform>();
    }
    // Update is called once per frame
    [SerializeField]
    private float HealthPoints = 100f;
}
