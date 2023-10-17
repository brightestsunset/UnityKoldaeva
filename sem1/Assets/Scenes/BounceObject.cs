using UnityEngine;

public class BounceObject : MonoBehaviour
{
    public float bounceForce = 500f;

    private void OnCollisionEnter(Collision collision)
    {
        Rigidbody rb = GetComponent<Rigidbody>();

        if (rb != null)
        {
            // �������� ����������� �������, ����������� ��� �������
            // �������� ����� �������� ������� � �������� ������������.
            Vector3 direction = transform.position - collision.contacts[0].point;

            // ����������� ����������� ������� ��� ������������� ����.
            direction = direction.normalized;

            // ��������� ���� ������� � �������.
            rb.AddForce(direction * bounceForce);
        }
    }
}