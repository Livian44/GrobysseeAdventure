using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] GameObject player;
    [SerializeField] float speed = 0.5f;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Movement(player, speed);
    }

    private static void Movement(GameObject player, float speed)
    {
        Vector2 position = player.transform.position;
        float inputX = Input.GetAxis("Horizontal") * Time.deltaTime * speed;
        float inputY = Input.GetAxis("Vertical") * Time.deltaTime * speed;
        player.transform.position = new Vector2(position.x + inputX, position.y + inputY);
    }
}
