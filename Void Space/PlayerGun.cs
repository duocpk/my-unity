using UnityEngine;

public class PlayerGun : MonoBehaviour
{
    public GameObject ProjectileObject = null;
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Instantiate(ProjectileObject, this.transform.position, this.transform.localRotation);
        }
    }
}
