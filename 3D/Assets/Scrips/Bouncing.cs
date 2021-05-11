using UnityEngine;

public class Bouncing : MonoBehaviour
{
    // Start is called before the first frame update
    public Rigidbody rb;
    public Vector3 force;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnCollisionEnter(Collision collision)
    {
        print("Kiss");
        rb.AddForce(force);
    }
}
