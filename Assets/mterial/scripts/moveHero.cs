using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor.Tilemaps;
using UnityEngine;
using UnityEngine.UI;

public class moveHero : MonoBehaviour
{
    public float _hp;
    public float speed;
    private Rigidbody2D rb;
    private Vector2 moveInput;
    private Vector2 moveVelocity;
    private Animator _anim;
    private bool facingRight = true;


    public GameObject fireBall;
    public Transform firePointInstantiate;

    private float timeBtwFire;
    public float startTimeBtwFire;

    




    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        _anim = GetComponent<Animator>();
    }

    
    void Update()
    {
        
        MovinginstructinAnimation();
        Attack();
    }
    private void FixedUpdate()
    {
        
            moveInput = new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));
            moveVelocity = moveInput.normalized * speed;
            rb.MovePosition(rb.position + moveVelocity * Time.fixedDeltaTime);
        
            
        
    }


    void MovinginstructinAnimation()
    {
        if (moveInput.x == 0)        
            _anim.SetBool("isRuning", false);
        else
        {
            _anim.SetBool("isRuning", true);
            _anim.SetBool("isAttack", false);
            
        }      
            
        if (moveInput.y < 0 && moveInput.x == 0)
        {
            _anim.SetBool("runingDown", true);
            
        }
            
        else if (moveInput.y > 0 && moveInput.x == 0)
        {
            _anim.SetBool("runUp", true);
            _anim.SetBool("isAttack", false);
        }
            
        else
        {
            _anim.SetBool("runingDown", false);
            _anim.SetBool("runUp", false);
            
        }            
        if (!facingRight && moveInput.x > 0)
            Flip();
        else if (facingRight && moveInput.x < 0)
            Flip();
        
    }
    void Flip()
    {
        facingRight = !facingRight;
        transform.Rotate(0f, 180f, 0f);
    }
    void Attack()
    {
        if (timeBtwFire <= 0)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {                
                _anim.SetBool("isAttack", true);                
            }
        } 
        else
        {
            timeBtwFire -= Time.deltaTime;
        }
    }
    void AttackToogle()
    {
        _anim.SetBool("isAttack", false);
        
    }
    void InstantiateFireBall()
    {
        Instantiate(fireBall, firePointInstantiate.position, transform.rotation);
        timeBtwFire = startTimeBtwFire;
    }
   
    

  
}
