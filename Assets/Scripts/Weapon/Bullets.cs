using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullets : MonoBehaviour
{
    [SerializeField] Guns bulletData;
    [SerializeField] ParticleSystem particleStartPref, particleEndPref;
    [SerializeField] AudioSource sound;
    [SerializeField] GameManager gameManager;

    AudioSource bulletSound;

    // Start is called before the first frame update
    void Start()
    {
        bulletSound = Instantiate(sound);
        bulletSound.Play();

        gameManager = GameObject.FindWithTag("GameManager").GetComponent<GameManager>();
    }
    private void OnCollisionEnter(Collision other)
    {

        if (other.gameObject.tag == "Player")
        {
            gameManager.playerHealth -= bulletData.damage;
            Debug.Log("Enemy");
        }

        if (other.gameObject.tag == "Enemy")
        {
            other.gameObject.GetComponent<EnemyAI>().health -= bulletData.damage;
            Debug.Log("Hit player");
        }

        Destroy(bulletSound);
        Destroy(this.gameObject);
    }

    // Update is called once per frame
    void Update()
    {
    }
}
