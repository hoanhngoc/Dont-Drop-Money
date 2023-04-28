using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boom : MonoBehaviour
{
    public float minspeed;
    public float maxspeed;
    public GameController gameController;
    [SerializeField] AudioClip picksound;

    private float speed;
    public float spawndelay;
    private float spawntime;

    // Start is called before the first frame update
    void Start()
    {
        speed = Random.Range(minspeed, minspeed);
        gameController = FindObjectOfType<GameController>(); ;
        
    }

    // Update is called once per frame
    void Update()
    {
        spawntime += Time.time;
        if(spawntime >= spawndelay)
        {
            spawntime = 0;
            transform.Translate(Vector2.down * speed * Time.deltaTime); 
        }
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("box"))
        {
            SoundManager.instance.PlaySound(picksound);
            Destroy(gameObject);
            gameController.GameOVer();
        }
    }
}
