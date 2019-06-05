using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TorretaMovimiento : Torreta
{
    [Header("Only Movement")]
    public Transform[] waypoints;       //Los puntos hacia donde va moverse la torreta
    public Transform currentDestination;    //El punto de destino actual
    int indexWaypoint = 0;              //Para recorrer el arreglo

    // Start is called before the first frame update
    public override void Start()
    {
        base.Start();
        currentDestination = waypoints[indexWaypoint];
    }

    // Update is called once per frame
    void Update()
    {
        TurretState();
    }

    public override void TurretState()
    {
        if(transform.position == currentDestination.position)
        {
            indexWaypoint = (indexWaypoint + 1) % waypoints.Length;     //Para recorrer el arreglo y mantener valores de 0 hasta el tamaño del arreglo, para que no se desfase
            currentDestination = waypoints[indexWaypoint];

            transform.localScale = new Vector3(1f,(transform.localScale.y *-1f),1f);    //Para dar el giro a la torreta
        }

        transform.position = Vector3.MoveTowards(transform.position, currentDestination.position, speed * Time.deltaTime);  //Mover la torreta de un punto A a un punto B con una velocidad
    }

    public override void ReciveDamage(int totalDamage)
    {
        health -= totalDamage;
        Debug.Log("Vida Actual: "+health);
    }
}
