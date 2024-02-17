using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Item : MonoBehaviour
{
    public Event dropped;
    public Event pickup;
    public Image icon;

    private void Start()
    {
        dropped.Occurred(this.gameObject);

    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag=="Player")
        {
            pickup.Occurred(this.gameObject);
            this.gameObject.GetComponent<MeshRenderer>().enabled = false;
            this.gameObject.GetComponent<Collider>().enabled = false;
            Destroy(this.gameObject, 5f);
        }
    }
}
