using UnityEngine;

public class EnemyController : MonoBehaviour
{
    public bool EnterCollider = false;
    public float MinDistance = 6f;
    public float MaxSpeed = 3f;
    public string TargetTag;
    Rigidbody ThisBody = null;
    Transform ThisTransform = null;
    public Transform TargetTransform = null;

    void Start()
    {
        TargetTransform = GameObject.FindGameObjectWithTag(TargetTag).GetComponent<Transform>(); 
        ThisBody = GetComponent<Rigidbody>();
        ThisTransform = GetComponent<Transform>();
    }

    void FixedUpdate()
    {
       if(EnterCollider == true)
        {
            Vector3 LookDirection = TargetTransform.position - ThisTransform.position;
            ThisTransform.localRotation = Quaternion.LookRotation(LookDirection.normalized, Vector3.up);
            if(Vector3.Distance(TargetTransform.position, ThisTransform.position) > MinDistance)
            {
                ThisBody.AddForce((TargetTransform.position - ThisTransform.position).normalized * MaxSpeed);
                ThisBody.velocity = new Vector3
                (Mathf.Clamp(ThisBody.velocity.x, -MaxSpeed, MaxSpeed),
                Mathf.Clamp(ThisBody.velocity.y, -MaxSpeed, MaxSpeed),
                Mathf.Clamp(ThisBody.velocity.z, -MaxSpeed, MaxSpeed));
            }
        }
        
    }
}
