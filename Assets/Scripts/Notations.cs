using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Notations : MonoBehaviour
{
    protected string Notation(double number, string digit)
    {
        double digitTemp = Math.Floor(Math.Log10(number));
        IDictionary<double, string> prefix = new Dictionary<double, string>()
        {
            {3, "K"},
            {6, "M"},
            {9, "B"},
            {12, "T"},
            {15, "Qa"},
            {18, "Qi"},
            {21, "Se"},
            {26, "Sep"},
        };

        double digitEvery3 = 3 * Math.Floor(digitTemp / 3);
        if (number >= 1000)
            return (number / Math.Pow(10, digitEvery3)).ToString(digit) + prefix[digitEvery3];
        return number.ToString(digit);
    }
}
