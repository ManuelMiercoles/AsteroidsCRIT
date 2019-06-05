using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class OmniScript1 : MonoBehaviour {
    public enum StatusTurret
    {
        PATROL, WAIT, DETECION, ATTACK
    }
    [Header("Basic Turret")]
    public int maxHealth;
    public StatusTurret currenState; //el estado actual de la torreta
    public float speed = 5f;
    public float waitTime = 1f;

    [Header("Alert State")]
    public LayerMask targetMask;
    public float radiusSensor;
    public GameObject pointSensor;

    [Header("Attack state")]
   // public GameObject bulletPrefab;
    public GameObject spawnPoint;
   // public float fireRate = 0.5f;
    //public float nextFire;

    [Header("Player")]
    public GameObject player;
    public bool isDetected = false;

   /* public int health
    {
        get;
        set;
    }
    */
    // Start is called before the first frame update
    public virtual void Start()
    {
        player = GameObject.Find("Player");
       // health = maxHealth;
    }

    public abstract void TurretState();
    // public abstract void ReciveDamage(int totalDamage);
    public virtual void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(pointSensor.transform.position, radiusSensor);
    }
}
