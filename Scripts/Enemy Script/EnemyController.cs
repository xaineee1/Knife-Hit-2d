using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    [SerializeField]
    private float rotationSpeed;

    private bool enemyRotation;
    private float enemyRotationSpeed;

    private void Awake()
    {
        enemyRotation = true;
    }

    private void Update()
    {
        if(enemyRotation)
        {
            RotateTheEnemy();
        }
    }

    private void RotateTheEnemy()
    {
        transform.Rotate(new Vector3(0, 0, rotationSpeed * Time.deltaTime), Space.Self);
    }
}
