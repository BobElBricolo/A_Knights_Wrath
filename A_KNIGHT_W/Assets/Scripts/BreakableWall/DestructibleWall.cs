using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestructibleWall : MonoBehaviour
{

    [SerializeField] private GameObject _effect;

    private int randomNumber;

    // Start is called before the first frame update
    private void start()
    {
        randomNumber = Random.Range(0, 10);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Attack")
        {

            if (random() > 4)
            {
                StartCoroutine(destructWall());
            }
        }
    }

    IEnumerator destructWall()
    {
        _effect.SetActive(true);
        yield return new WaitForSeconds(4f);
        Destroy(this.gameObject);
    }

    //Fonction mathématique de nombres aléatoires
    private int random()
    {
        int a = 3;
        int x = randomNumber;
        int mod = 11;
        int reponse;

        reponse = (a * x) % mod;

        return reponse;
    }

}


