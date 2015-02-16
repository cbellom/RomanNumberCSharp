using UnityEngine;
using System.Collections;

public class Parser : MonoBehaviour {
	private int[] values ={ 1000, 900, 500, 400, 100, 90,50, 40, 10, 9, 5, 4, 1 };
	private string[] romanNumbers ={ "M", "CM", "D", "CD", "C","XC", "L", "XL", "X", "IX", "V", "IV", "I"};

	public string getRomanNumberFromInt(int number){
		string romanNumber = "";
		int index = 0;

		while (number > 0){
			while (number >= values[index]){
				romanNumber += romanNumbers[index];
				number = number - values[index];
			}
			index++;
		}
		return romanNumber;
	}

}
