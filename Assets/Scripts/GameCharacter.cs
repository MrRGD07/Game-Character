using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameCharacter : MonoBehaviour
{
    public string name = "Bucket";
    private int level = 21;
    private int levelOutput;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(name);
        levelOutput = MakeCharacter(name, level);
        Debug.Log(levelOutput);
    }
    /// <summary>
    /// Prints the name and level of the given character to the console based on the input the method gets
    /// </summary>
    /// <param name="characterName"></param>
    /// <param name="characterlevel"></param>
    public int MakeCharacter(string characterName, int characterlevel)
    {
        Debug.Log($"The characters name is: {characterName} and their lvl is {characterlevel}");

        return characterlevel * 2 + 8 * 10;
    }
}
