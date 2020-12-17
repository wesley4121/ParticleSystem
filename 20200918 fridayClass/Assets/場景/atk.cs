using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class atk : MonoBehaviour
{
    public GameObject m_parti;

    private Animator m_ani;

    private void Start()
    {
        m_ani = GetComponent<Animator>();
    }
    void Update()
    {
        if (Input.GetKey(KeyCode.Space) && !m_ani.GetCurrentAnimatorStateInfo(0).IsName("arthur_attack_01"))
        {
            m_ani.SetFloat("mAtk", 1);
            m_parti.GetComponent<ParticleSystem>().Play();

        }
        if (!m_ani.GetCurrentAnimatorStateInfo(0).IsName("idle"))
        {
            m_ani.SetFloat("mAtk", 0);
        }
/*        if (m_ani.GetCurrentAnimatorStateInfo(0).IsName("arthur_attack_01"))
        {
            m_parti.GetComponent<ParticleSystem>().Play();
            m_parti2.GetComponent<ParticleSystem>().Play();
        }
*/

    }
}
