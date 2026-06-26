using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinController : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject coinParticle;
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            Pontuation pontuation = other.GetComponent<Pontuation>();
            pontuation.AddPoints();
            Destroy(this.gameObject);
            Instantiate(coinParticle, this.transform.position, Quaternion.Euler(-90, 0, 0));
        }
    }
}
