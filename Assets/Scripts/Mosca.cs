using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mosca : MonoBehaviour
{
    Vector3 initialPosition;
    public bool hasKey;

    // Start is called before the first frame update
    void Start()
    {
        initialPosition = transform.position;
    }

    private void Update()
    {
        if (hasKey)
        {
            Debug.Log("Tiene la llave");
        }
    }


    //Destruir la mosca si colisiona con el ventilador
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name == "Ventilador")
        {
            transform.position = initialPosition;
        }else if (collision.gameObject.name == "Llave")
        {
            hasKey = true;
            Destroy(collision.gameObject);
        }
    }
}
