using System.Collections;
using System.Collections.Generic;
using Unity.AI.Navigation;
using UnityEngine;

public class CollectItems : MonoBehaviour
{
    public int collectedObjects = 0;

    public OpenDoor door;

    private void Update()
    {
        if(collectedObjects >= 3)
        {
            door.OpenTheDoor(); 
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        //Tag method
        if (collision.gameObject.tag == "Collectable")
        {
            collectedObjects++;
            Destroy(collision.gameObject);
        }


        //Debug.Log("Collided with: " + collision.gameObject.name);
    }

    /*
        //Advanced method
        Collectable collectable = collision.gameObject.GetComponent<Collectable>();

        if (collectable != null )
        {
            collectedObjects++;
            Destroy(collision.gameObject);
        }
*/

    void MyOwnMethod()
    {
    }
}
