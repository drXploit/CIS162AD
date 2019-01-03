using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
/*
 * Creator: Jeremy Bowne
 * Class: CIS162AD
 * Assignment: Chapter 8 Exercise 8
 * Filename: pigLatin.cs
 * Date: 10-18-2018
 * 
 * reAay ouyay aay hizway ithway igPay atin?Lay? (Translated: "Are you a 
 * whiz with Pig Latin?") Write a program that converts an english phrase 
 * into a pseudo-Pig Latin Phrase (that is Pig Latin that doesn't follow all 
 * the Pig Latin syntax rules). Use predefined methods of the Array and
 * string classes to do the work. For simplicity in your conversion, place
 * the first letter as the last character in the word and prefix the characters
 * "ay" onto the end. For example, the word "example" would become "xam-
 * pleeay", and "method" would become "ethodmay." Allow the user to input
 * the english phrase. After converting it, display the new Pig Latin phrase.
 * 
 */
namespace PigLatin
{
    class pigLatin
    {
        /*
         * Main entrypoint
         * */
        static void Main(string[] args)
        {
            // variables
            string sValue = "";
            
            // while loop to allow the user to input multiple sentences
            while (!sValue.Contains("!QUIT"))
            {
                Write("\nType a sentence to convert to Pig Latin (\"!QUIT\" to quit): ");
                sValue = ReadLine();
                if (!sValue.Contains("!QUIT"))
                {
                    WriteLine(sValue);
                    string[] words = convertString(sValue); // convert our string
                    string buildString = "";

                    // rebuild the string from the array of words
                    for (int i = 0; i < words.Length; i++)
                        buildString = buildString + words[i] + " ";

                    WriteLine(buildString);
                }
            }
        }

        /*
         * convertString will convert a sentence into Pig Latin
         * returns the converted array of words to be put back together elsewhere
         * */
        static string[] convertString(string strSentence)
        { 
            // split the string into a word array with space as the token
            string[] words = strSentence.Split(' ');

            //cycle through each word
            for (int i = 0; i < words.Length; i++)
            {
                // store the first character
                string firstChar = words[i].Substring(0, 1);

                // remove the first character
                words[i] = words[i].Remove(0, 1);

                int index = (words[i].Length); //update index

                // place the first character as the last character
                words[i] = words[i].Insert(index, firstChar);

                index = (words[i].Length); // update index

                // insert 'ay' as the trailing series of characters
                words[i] = words[i].Insert(index, "ay");
            }

            return words;
    }
}
}
