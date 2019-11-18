using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField]
    private Rigidbody playerRigidbody;


    public float speed;
    public Joystick joystick;
        

    public void FixedUpdate()
    {
        Vector3 direction = Vector3.forward * joystick.Vertical + Vector3.right * joystick.Horizontal;
        playerRigidbody.AddForce(direction * speed * Time.fixedDeltaTime, ForceMode.VelocityChange);
    }
}
