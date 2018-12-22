using UnityEngine;
using System.Collections;
using System;

// Doesn't do anything yet
public class AIZombieStateMachine : AIStateMachine
{
    // Inspector Assigned 

    [SerializeField] [Range(10.0f,360.0f)] float _fov = 60f;
    [SerializeField] [Range(0,1)] float _sight = 0.5f;
    [SerializeField] [Range(0,1)] float _hearing = 1f;
    [SerializeField] [Range(0,1)] float _aggression = 1f;
    [SerializeField] [Range(0,100)] int _health = 100;
    [SerializeField] [Range(0,1)] float _intelligence = 0.5f;
    [SerializeField] [Range(0,1)] float _satisfaction = 1f;

    //private 
    private int _seeking = 0;
    private bool _feeding;
    private bool _crawling;
    private int _attackType = 0;
    private float _speed = 0.0f;
    // Hashes
    private int _speedHash = Animator.StringToHash("Speed");
    private int _feedingHash = Animator.StringToHash("Feeding");
    private int _seekingHash = Animator.StringToHash("Seeking");
    private int _attackHash = Animator.StringToHash("Attack");

    // publick Properties

    public float fov { get{return _fov;} }

    public AITargetType targetType{ get { return _target.type; }}

    public float hearing { get{return _hearing; } }
    public float sight { get{return _sight;} }
    public bool crawling { get{return _crawling;} }
    public float intelligence { get{return _intelligence;} }
    public float satisfaction { get{return _satisfaction;} set{_satisfaction = value; } }
    public float aggression { get{return _aggression;} set{_aggression = value;} }
    public int health { get{return _health;} set{_health = value;} }
    public int attackType { get{return _attackType;} set{_attackType = value;} }
    public bool feeding { get{return _feeding;} set{_feeding = value;} }
    public int seeking { get{return _seeking;} set{_seeking = value;} }
    public float speed
    {
        get{return _speed;}
        set{_speed = value;}
    }
    protected override void Update()
    {
        base.Update();

        if(_animator != null)
        {
            _animator.SetFloat("Speed", _speed);
            _animator.SetBool("Feeding",_feeding);
            _animator.SetInteger("Seeking",_seeking);
            _animator.SetInteger("Attack", _attackType);
        }
    }
}
