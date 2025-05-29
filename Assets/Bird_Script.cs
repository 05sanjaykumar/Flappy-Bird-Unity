using UnityEngine;
using UnityEngine.InputSystem;

public class Bird_Script : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public Rigidbody2D myRigidBody;
    public float flap_strength;
    void Start()
    {
        gameObject.name = "Sanjay's Bird";
        

    }

    // Update is called once per frame
    void Update()
    {
        if (Keyboard.current.spaceKey.wasPressedThisFrame)
        {
            myRigidBody.linearVelocity = Vector2.up*flap_strength;
        }

    }
}
