using UnityEngine;
using UnityEngine.UI;
using System.Collections.Generic;
using System;

public class SpinWheelGame : MonoBehaviour
{
    //public Text playerText;
    public Text resultText;
    public Transform wheel;

    private int currentPlayer;
    private int spinResult;
    private List<string> truths = new List<string>();
    private List<string> dares = new List<string>();

    private float rotationSpeed = 0f;
    private float targetRotation = 0f;
    private bool spinning = false;
    public GameObject ChooseTruthDare;
    public Button spinButton;

    void Start()
    {
        // Add your own truth and dare options here
        truths.Add("Tell us your most embarrassing moment.");
        truths.Add("What is your biggest fear?");
        truths.Add("Have you ever cheated on a test?");
        truths.Add("What is your secret talent?");

        dares.Add("Do a cartwheel.");
        dares.Add("Sing a song out loud.");
        dares.Add("Give someone a piggyback ride.");
        dares.Add("Do 10 push-ups.");

        currentPlayer = 0;
        spinResult = 0;
        resultText.text = "Spin the wheel!";
    }

    void Update()
    {
        /*if (spinning)
        {
            // Rotate the wheel smoothly towards the target rotation
            float step = rotationSpeed * Time.deltaTime;
            wheel.rotation = Quaternion.RotateTowards(wheel.rotation, Quaternion.Euler(0f, 0f, targetRotation), step);

            // Check if the wheel has reached the target rotation
            if (Quaternion.Angle(wheel.rotation, Quaternion.Euler(0f, 0f, targetRotation)) < 0.1f)
            {
                spinning = false;

                StartCoroutine(DisplayResult());
            }

        }*/
        if (spinning)
        {
            // Calculate the rotation step based on the rotation speed
            float step = rotationSpeed * Time.deltaTime;

            // Rotate the wheel towards the target rotation
            wheel.Rotate(0f, 0f, step);

            // Update the rotation speed based on the remaining distance to the target rotation
            float remainingRotation = Mathf.Abs(targetRotation - wheel.rotation.eulerAngles.z);
            rotationSpeed = Mathf.Lerp(200f, 400f, remainingRotation / 360f);

            // Check if the wheel has reached the target rotation
            if (remainingRotation < 0.1f)
            {
                spinning = false;
                StartCoroutine(DisplayResult());

            }
        }
    }
    public void SpinButtonClicked()
    {
        if (!spinning)
        {
            spinResult = UnityEngine.Random.Range(1, 5);
            currentPlayer = (currentPlayer + 1) % 4;

            targetRotation = 45f * (spinResult - 1);
            rotationSpeed = Mathf.Lerp(200f, 400f, Mathf.Abs(targetRotation - wheel.rotation.eulerAngles.z) / 360f);
            spinButton.interactable = false;

            spinning = true;
        }
    }
    IEnumerator<WaitForSeconds> DisplayResult()
    {
        resultText.text = "Result: " + spinResult;

        yield return new WaitForSeconds(0.75f);
        ChooseTruthDare.SetActive(true);
        spinButton.interactable = true;

        resultText.text = "Player " + (currentPlayer + 1) + ", choose truth or dare!";
    }

    public void ChooseTruth()
    {
        string truth = GetRandomTruth();
        resultText.text = truth;// "Player " + (currentPlayer + 1) + " chose truth:\n" + truth;
    }

    public void ChooseDare()
    {
        string dare = GetRandomDare();
        resultText.text = dare;// "Player " + (currentPlayer + 1) + " chose dare:\n" + dare;
    }

   

    private string GetRandomTruth()
    {
        int index = UnityEngine.Random.Range(0, truths.Count);
        print(index);
        string truth = truths[index];
      //  truths.RemoveAt(index);
        return truth;
    }

    private string GetRandomDare()
    {
        int index = UnityEngine.Random.Range(0, dares.Count);
        string dare = dares[index];
       // dares.RemoveAt(index);
        return dare;
    }
}