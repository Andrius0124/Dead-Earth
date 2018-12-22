using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

public class Controller : MonoBehaviour {

	// Use this for initialization
	private Animator _animator;
	private int _horizontalHash =0;
	private int _verticalHash =0;
	private int _attackTriggerHash = 0;
	public float yAxis =0f;
	public float xAxis = 0f;
	void Start () {
		_animator =GetComponent<Animator>();
		_horizontalHash = Animator.StringToHash("Horizontal");
		_verticalHash = Animator.StringToHash("Vertical");
		_attackTriggerHash = Animator.StringToHash("Attack");
	}
	
	// Update is called once per frame
	void Update () {
		xAxis = CrossPlatformInputManager.GetAxis("Horizontal") * 2.32f;
		yAxis = CrossPlatformInputManager.GetAxis("Vertical") * 5.66f;

		_animator.SetFloat(_horizontalHash,xAxis, 0.10f,Time.deltaTime);
		_animator.SetFloat(_verticalHash,yAxis, 0.01f,Time.deltaTime);

	}
	public void Attack()
	{
		//_animator.SetTrigger(_attackTriggerHash);
	}
}
