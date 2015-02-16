using UnityEngine;
using System.Collections;

public class PlusManager : MonoBehaviour {
	public int firstNumber;
	public int secondNumber;

	private int result;	
	private Parser parser;
	private string message;

	void Start () {
		plusNumbersAndParser ();
	}

	public void plusNumbersAndParser(){
		if (!validateNumber (firstNumber) || !validateNumber (secondNumber)) {
			message = "Numero(s) invalido(s) debe(n) ser mayor que 0 y menor que 5000";
		} else {
			result = firstNumber + secondNumber;
			
			if(!validateNumber(result))
				message = "La suma de los dos numeros debe ser mayor que 0 y menor que 5000";
			else
				message = "Numero Romano: " + parseIntToRomanNumber(result);
		}
		
		print (message);
	}

	public string parseIntToRomanNumber(int number){
		parser = new Parser ();
		return parser.getRomanNumberFromInt (result);
	}

	public bool validateNumber(int number){
		if (number <= 0 || number >= 5000)
			return false;

		return true;
	}
}
