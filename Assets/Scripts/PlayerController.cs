using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    public float angularSpeed;
    public float Speed;
    public Rigidbody SelfRigibody;
    public GameObject TilePrefab;


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");
        Vector3 moveRight = Vector3.up * horizontal;
        Vector3 moveForward = transform.forward * Speed;
        moveForward.y = SelfRigibody.velocity.y;
        SelfRigibody.velocity = moveForward;
        SelfRigibody.angularVelocity = moveRight * angularSpeed;

    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.TryGetComponent(out SpawnInfo spawnInfo) && spawnInfo.canTouch == true)
        {
            spawnInfo.canTouch = false;
            Instantiate(TilePrefab, spawnInfo.Finish.position, TilePrefab.transform.rotation);
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.TryGetComponent(out Enemy enemy)) 
        {
            SceneManager.LoadScene(0);  
        }
    }
}

