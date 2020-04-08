using UnityEngine;

public class PlayerController : MonoBehaviour
{
    //------------------------------
    private Rigidbody ThisBody = null;
    private Transform ThisTransform = null;
    public bool MouseLook = true;
    public string HorzAxis = "Horizontal";
    public string VertAxis = "Vertical";
    public string FireAxis = "Fire1";
    public float MaxSpeed = 3f;
    public float Speed = 3f;
    //------------------------------
    // Use this for initialization
    void Awake()
    {
        ThisBody = GetComponent<Rigidbody>();
        ThisTransform = GetComponent<Transform>();

    }
    //------------------------------
    // Update is called once per frame
    void FixedUpdate()
    {
        Vector3 MousePosWorld = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, 0.0f));
        Vector3 MousePos = new Vector3(Input.mousePosition.x, 0.0f, Input.mousePosition.z);
        Vector3 MoveDir = MousePosWorld - ThisTransform.position;

        MousePosWorld = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, 0.0f));
        MousePosWorld = new Vector3(MousePosWorld.x, 0.0f, MousePosWorld.z);

        Vector3 LookDirection = MousePosWorld - ThisTransform.position;
        ThisTransform.localRotation = Quaternion.LookRotation(LookDirection.normalized, Vector3.up);

        if (Input.GetAxis(VertAxis) > 0.0f)
        {
            ThisBody.AddForce(transform.forward.normalized * Speed);
        }
        if(Input.GetAxis(VertAxis) < 0.0f)
        {
            ThisBody.AddForce(-transform.forward.normalized * Speed / 2);
        }
        if (Input.GetAxis(HorzAxis) > 0.0f)
        {
            ThisBody.AddForce(ThisTransform.right.normalized * Speed / 2);
        }
        if (Input.GetAxis(HorzAxis) < 0.0f)
        {
            ThisBody.AddForce(-ThisTransform.right.normalized * Speed / 2);
        }
        //Clamp speed
        ThisBody.velocity = new Vector3
        (Mathf.Clamp(ThisBody.velocity.x, -MaxSpeed, MaxSpeed),
        Mathf.Clamp(ThisBody.velocity.y, -MaxSpeed, MaxSpeed),
        Mathf.Clamp(ThisBody.velocity.z, -MaxSpeed, MaxSpeed));
    }
}
