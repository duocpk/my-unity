using UnityEngine;
using Ditzelgames;

public class DestructionOrb : MonoBehaviour
{
    public string ExceptionTag = "Enemy";
    public float Damage = 15f;
    public float ProjectileSpeed = 10f;

    void Start()
    {
        PhysicsHelper.ApplyForceToReachVelocity(this.GetComponent<Rigidbody>(), transform.forward * ProjectileSpeed, 1000000);
        DestroyObject(gameObject, 8f);
    }

    void OnTriggerEnter(Collider Enterer)
    {
        if (Enterer.tag == "Player")
        {
            Enterer.GetComponent<ObjectHealth>().HealthPoint -= Damage;
            // insert exkaplosian
            DestroyObject(gameObject);
        }
    }
}