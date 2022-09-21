using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrayerMovement : MonoBehaviour
{

    private Rigidbody2D rb;
    private void Awake() {
        rb = GetComponent<Rigidbody2D>();

    }
    private void FixedUpdate() {
        rb.velocity = new Vector2 (horizontal ,0f) * speed;
    }

        public float speed = 5.5f;
        private float horizontal;
        private Transform prayerTransform;

    // Start is called before the first frame update
    void Start()
    {
        prayerTransform = GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        horizontal = Input.GetAxisRaw("Horizontal");

        //prayerTransform.position += new Vector3 (horizontal * speed * Time.deltaTime, 0, 0);
        //prayerTransform.position += new Vector3 (1, 0, 0) * horizontal * speed * Time.deltaTime;
        //prayerTransform.Translate(Vector3.right * horizontal * speed * Time.deltaTime, Space.World);
        
    }
}