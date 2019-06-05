using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TorretaTecho : Torreta
{
    [Header("Patrol State")]
    public GameObject rotorTurret;
    public float rightAngle = 45f;
    public float leftAngle = 335f;
    float auxSpeed;

    public override void Start()
    {
        base.Start();
        auxSpeed = speed;
    }

    void FixedUpdate()
    {
        Collider2D targetDetected = 
        Physics2D.OverlapCircle(pointSensor.transform.position, radiusSensor, targetMask);
        if (targetDetected)
        {
            Debug.Log("Detecte al jugador :V");
            currenState = StatusTurret.DETECION;
            isDetected = true;
        }
        else if (isDetected && !targetDetected)
        {
            Debug.Log("Regreso a patrullar");
            currenState = StatusTurret.PATROL;
            isDetected = false;
            speed = -auxSpeed;
        }
    }

    void Update()
    {
        TurretState();

        if(isDetected && nextFire < Time.time)
        {
            Debug.Log("Disparo!");
            //Sustituir esta linea llamando el metodo de PoolingManager
            Instantiate(bulletPrefab, spawnPoint.transform.position, spawnPoint.transform.rotation);
            nextFire = Time.time + fireRate;
        }

    }

    public override void TurretState()
    {
        if (!isDetected)
        {
            //Hay que patrullar

            if (rotorTurret.transform.localEulerAngles.z > rightAngle
                    && rotorTurret.transform.localEulerAngles.z < leftAngle)
            {
                if (currenState != StatusTurret.WAIT)
                {
                    StartCoroutine(WaitPatrol());
                }
            }
            rotorTurret.transform.Rotate(0f, 0f, speed * Time.deltaTime);
        }
        else
        {
            Vector2 direction = player.transform.position - rotorTurret.transform.position;
            float angleTarget = Mathf.Atan2(direction.x *-1f, direction.y*-1f) * Mathf.Rad2Deg;
            Quaternion finalAngle = Quaternion.AngleAxis(angleTarget, Vector3.back);

            rotorTurret.transform.rotation = 
            Quaternion.Lerp(rotorTurret.transform.rotation, finalAngle, Time.deltaTime * 10);
        }

    }

    IEnumerator WaitPatrol()
    {
        auxSpeed = speed;
        speed = 0f;
        currenState = StatusTurret.WAIT;
        yield return new WaitForSeconds(waitTime);
        speed = auxSpeed;
        speed *= -1;
        yield return new WaitForSeconds(0.2f);
        currenState = StatusTurret.PATROL;
    }

    

    public override void ReciveDamage(int totalDamage)
    {
        health -= totalDamage;
        Debug.Log("Vida Actual Torreta: "+ health);
    }
}
