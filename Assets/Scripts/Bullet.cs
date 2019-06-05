using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float speed = 5f;

    /*  Definir las condiciones para ya no necesitar la bala
        y mandar llamar el metodo de PoolingManager para
        regresar el objeto a la alberca
     */

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.right * speed * Time.deltaTime);
    }
}
