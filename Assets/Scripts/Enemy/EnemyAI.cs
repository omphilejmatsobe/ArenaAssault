using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyAI : MonoBehaviour
{
    private NavMeshAgent agent;
    [SerializeField] Transform playerTransform;
    [SerializeField] GameObject bulletProjectile;
    [SerializeField] float bulletForce;

    bool inAttack = true;
    bool allowAttack = true;

    // Start is called before the first frame update
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
    }

    public void attackPlayer()
    {
        agent.destination = transform.position;
        transform.LookAt(playerTransform);

        if (allowAttack == true)
        {
            GameObject bullet = Instantiate(bulletProjectile, transform.position, Quaternion.identity);
            bullet.GetComponent<Rigidbody>().AddForce(transform.forward * bulletForce, ForceMode.Impulse);

            allowAttack = false;
            StartCoroutine(enemyAttackDelay());
        }
    }

    IEnumerator enemyAttackDelay()
    {
        yield return new WaitForSeconds(0.2f);
        allowAttack = true;
    }

    // Update is called once per frame
    void Update()
    {
        agent.destination = playerTransform.position;

    }
}
