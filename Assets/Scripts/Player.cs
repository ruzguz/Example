using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    //[SerializeField]
    private Color[] _colors = new Color[] { Color.red, Color.blue, Color.green, Color.yellow, Color.black, Color.white };

    //  public int score = 0;

    //  private int _lives = 3;
    //  private int _shield = 3;

    // private float _jumpForce = 8f;       
    // private float _speed = 5f;

[HideInInspector]
public int score = 0;

[Header("Health Settings")]
[SerializeField]
private int _lives = 3;
[SerializeField]
private int _shield = 3;

[Header("Movement Settings")]
[SerializeField]
[Min(3)]
private float _jumpForce = 8f;       
[SerializeField]
[Range(0,5)]
private float _speed = 5f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        // If user press space key 
        // change player color 
        if (Input.GetKeyDown("space"))
        {
            int randomIndex = Random.Range(0, _colors.Length);
            transform.GetComponent<Renderer>().material.color = _colors[randomIndex];
        }
        
    }
}
