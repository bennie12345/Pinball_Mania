using UnityEngine;
using System.Collections;

public class Flipper : MonoBehaviour
{

    [SerializeField]private bool _left;
    [SerializeField]private bool _right;

    [SerializeField]private Vector3 _l_com;
    [SerializeField]private Vector3 _r_com;

    private float _forceAmount = 20f;
    private Rigidbody _rb;

    void Awake()
    {
        _rb = GetComponent<Rigidbody>();
        if (this._left)
        {
            _rb.centerOfMass = _l_com;

        }
        if (this._right)
        {
            _rb.centerOfMass = _r_com;
        }
    }

    void Update()
    {
        Flippers();
    }

    private void Flippers()
    {
        if (this._left)
        {
            if (Input.GetKey(KeyCode.LeftShift))
            {
                _rb.AddForce(transform.forward * _forceAmount, ForceMode.Impulse);
            }
            else
            {
                _rb.AddForce(-transform.forward * 2f, ForceMode.Impulse);
            }
        }


        if (this._right)
        {
            if (Input.GetKey(KeyCode.RightShift))
            {
                _rb.AddForce(transform.forward * _forceAmount, ForceMode.Impulse);
            }
            else
            {
                _rb.AddForce(-transform.forward * 2f, ForceMode.Impulse);
            }
        }
    }
}