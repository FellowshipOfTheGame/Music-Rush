using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{
    public GameObject bullet;
    // Start is called before the first frame update
    void Start()
    {
        //ActiveBullets();
    }


    public void ActiveBullets()
    {
        GameObject bullets;
        bullets = Instantiate(bullet);
        bullets.transform.position = bullet.transform.position;
        bullets.SetActive(true);
    }

}
