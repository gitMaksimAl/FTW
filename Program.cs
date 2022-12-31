void PrintText(string[] text) {
	for (int i = 0; i < text.GetLength(0); i++)
		Console.Write($"{text[i]} ");
	Console.Write('\n');
}

// The function counts the number of rows of a certain length in an array.
int GetRowsAmount(int wordLen, string[] array) {
	int wordAmount = 0;
	for (int i = 0; i < array.GetLength(0); i++) {
		if (array[i].Length <= wordLen) wordAmount += 1;
	}
	return wordAmount;
}

// Gets an array of strings with a specific length.
string[] GetSizedStrings(int size, string[] text) {
	string[] shorty = new string[GetRowsAmount(size, text)];
	for (int i = 0, j = 0; i < text.GetLength(0); i++) {
		if (text[i].Length <= size) {
			shorty[j] = text[i];
			j++;
		}
	}
	return shorty;
}

string[] text = {"hello", "2", "word", "-)"};

PrintText(GetSizedStrings(3, text));

