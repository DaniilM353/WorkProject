using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public Transform stick;
    public float range = 30f;
    public float speed = 500f;
    private bool m_isDown = false;
    public float power = 20f;

    private bool m_isDown = false;
    private Vector3 m_lastPosition;

    private void Update()
    {
        m_lastPosition = helper.position;
        m_isDown = Input.GetMouseButton(0);
        Quaternion rot = stick.localRotation;

        Quaternion toRot = Quaternion.Euler(0, 0, m_isDown ? range : -range);

        rot = Quaternion.RotateTowards(rot, toRot, speed * Time.deltaTime);

        stick.localRotation = rot;
    }
    public void OnCollisionStick(Collider collider)
    {
        if (collider.TryGetComponent(out Rigidbody stone))
        {
            var dir = (helper.localPosition - m_lastPosition).normalized;
            stone.AddForce(dir * power, ForceMode.Impulse);
        }
    }
}
