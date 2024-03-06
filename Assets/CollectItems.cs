using UnityEngine;

public class CollectItems : MonoBehaviour
{
    public OpenDoor door;

    public int collectedItems = 0;
    void Start()
    {
        
    }

    void Update()
    {
        if(collectedItems >= 3)
        {
            door.OpenTheDoor();
        }
    }

    void OnCollisionEnter(Collision collision)
    {
        //Debug.Log("Name of GO: " + collision.gameObject.name);

        if(collision.gameObject.tag == "Collectable")
        {
            collectedItems++;

            Destroy(collision.gameObject);
        }

        
    }

    void MyOwnMethod()
    {
        Debug.Log("Method");
    }
}

















