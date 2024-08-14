using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OrganicScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        // Verifica si el objeto que colisiona tiene el tag "Player" o el tag que tú quieras
        if (other.gameObject.tag == "Player")
        {
            // Destruye este objeto al colisionar
            Destroy(gameObject);
        }
    }
}
