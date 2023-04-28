using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Money : MonoBehaviour
{
    public float speed;
    public Score MoneyScore;
    public int addcoin;
    [SerializeField] AudioClip picksound;

    public float waittime = 5;
    // Start is called before the first frame update
    void Start()
    {
        MoneyScore = FindObjectOfType<Score>();
       
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector2.down*speed*Time.deltaTime);
       
     }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("box"))
        {
            SoundManager.instance.PlaySound(picksound);
            MoneyScore.currentpoint = MoneyScore.currentpoint + addcoin;
            Destroy(gameObject);
        }
    }
    public void timeup()
    {
        for(int i = 0; i <= waittime; i++)
        {
            i++;
            if(i==waittime)
            {
                speed = speed + 2f;
            }
        }
    }
}
