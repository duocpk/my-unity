using UnityEngine;

public class EnemyDetector : MonoBehaviour
{
    public float FireRate = 1f;
    public GameObject ProjectileObject = null;
    public GameObject Parent = null;
    void OnTriggerEnter(Collider SphereCollider)
    {
        if (SphereCollider.tag == gameObject.GetComponentInParent<EnemyController>().TargetTag)
        {
            gameObject.GetComponentInParent<EnemyController>().EnterCollider = true;
            InvokeRepeating("Shoot", 0f, FireRate);
        }
    }
    void OnTriggerExit(Collider SphereCollider)
    {
        if (SphereCollider.tag == gameObject.GetComponentInParent<EnemyController>().TargetTag)
        {
            gameObject.GetComponentInParent<EnemyController>().EnterCollider = true;
            CancelInvoke();
        }
    }
    void Shoot()
    {
        Instantiate(ProjectileObject, Parent.transform.position, Parent.transform.localRotation);
    }
}
