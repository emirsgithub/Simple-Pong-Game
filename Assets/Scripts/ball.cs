using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ball : MonoBehaviour
{
    public float speed;
    public Rigidbody2D rb;
    public Vector3 startPosition;
    public GameObject spaceText;

    void Start()
    {
        StartCoroutine(WaitForKeyPress(KeyCode.Space));
    }

    IEnumerator WaitForKeyPress(KeyCode key)
    {
        yield return new WaitUntil(() => Input.GetKeyDown(key));
        startPosition = transform.position;
        spaceText.SetActive(false);
        Launch();
    }

    private void Launch()
    {
        
        float x = Random.Range(0, 2) == 0 ? -1 : 1;
        float y = Random.Range(0, 2) == 0 ? -1 : 1;

        rb.velocity = new Vector2(speed * x, speed * y);
    }

    public void Reset()
    {
        rb.velocity = Vector2.zero;
        transform.position = startPosition;
        Launch();
    }

}
