    using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class RoverManager : MonoBehaviour
{
    [SerializeField]
    public Transform checkpoint;
    [SerializeField]
    public Text distanceTexts;
    private float distance;
    public Animator anim;
    public AudioSource lost;
    public GameObject youLost;
    public AudioSource crash;
    public bool isZoom = false;
    public AudioSource win;
    public GameObject winCanvas;

    void Start()
    {
        youLost.SetActive(false);
        anim = GetComponent<Animator>();
        isZoom = false;
        winCanvas.SetActive(false);
    }

    void Update()
    {
        //distance text için
        distance = (checkpoint.transform.position - transform.position).magnitude;

        distanceTexts.text = "Distance: " + distance.ToString("F1") + " meters";

        if (distance <= 0)
        {
            distanceTexts.text = "Landed!";
        }

        if (Input.GetKeyDown(KeyCode.Q))
        {
            SceneManager.LoadSceneAsync(SceneManager.GetActiveScene().buildIndex);
        }
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            SceneManager.LoadScene("Start");
        }
    }

    public void OnTriggerEnter2D(Collider2D Planet)
    {
        if (Planet.tag == "notMars")//mars olmayan her şey için
        {
            crash.Play();
            anim.SetBool("Crash", true);
            Debug.Log("test");
            Invoke("active", 3f);
            isZoom = true;
        }

        if (Planet.tag == "Mars")
        {
            GetComponent<Animator>().SetTrigger("Win");
            Invoke("Active", 3f);
            isZoom = true;
        }

    }

    void active()
    {
        youLost.SetActive(true);
        lost.Play();
    }


    void Active()
    {
        winCanvas.SetActive(true);
        win.Play();
    }


}
