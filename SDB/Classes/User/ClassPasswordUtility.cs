using System;
using System.Collections.Generic;
using System.Linq;

namespace SDB.Classes.User
{
	public static class ClassPasswordUtility
	{
		private static readonly Random _random = new Random((int)(DateTime.Now.Ticks) + 8);
		private static readonly int[] _lowerCase, _upperCase, _numbers, _punctuation, _similars;

		static ClassPasswordUtility()
		{
			#region ASCII Reference
			// 0-9: 48-57
			// A-Z: 65-90
			// a-z: 97-122
			// Limited punctuation:
			// !  #  $  %  &  *  +  ,  -  .  :  ;
			// 33 35 36 37 38 42 43 44 45 46 58 59
			// Similars:
			// l   I   1   O   0   B   8   S   5
			// 108 73  49  79  48  66  56  83  53
			#endregion

			_lowerCase = CreateIntArray(97, 122);
			_upperCase = CreateIntArray(65, 90);
			_numbers = CreateIntArray(48, 57);
			_punctuation = new[] {33, 35, 36, 37, 38, 42, 43, 45};
			_similars = new[] {108, 73, 49, 79, 48, 66, 56, 83, 53};
		}

		public static string Generate(int totalLength, bool includeLower, bool includeUpper, bool includeNumerals, bool includeSymbols, bool noSimilar)
		{
			var characterPool = new List<int>();

			// Get one of each required character type
			if (includeLower)
				characterPool.Add(GetRandomFromCharArray(_lowerCase, noSimilar));
			if (includeUpper)
				characterPool.Add(GetRandomFromCharArray(_upperCase, noSimilar));
			if (includeNumerals)
				characterPool.Add(GetRandomFromCharArray(_numbers, noSimilar));
			if (includeSymbols)
				characterPool.Add(GetRandomFromCharArray(_punctuation, noSimilar));

			// Combine all character types into a common pool
			var acceptableCharTypes = new List<int>();
			if (includeLower)
				acceptableCharTypes.AddRange(_lowerCase);
			if (includeUpper)
				acceptableCharTypes.AddRange(_upperCase);
			if (includeNumerals)
				acceptableCharTypes.AddRange(_numbers);
			if (includeSymbols)
				acceptableCharTypes.AddRange(_punctuation);
			if (noSimilar)
				acceptableCharTypes = acceptableCharTypes.Except(_similars).ToList();

			// Get a random character of a random type until filled
			while (characterPool.Count < totalLength)
				characterPool.Add(acceptableCharTypes[_random.Next(0, acceptableCharTypes.Count)]);

			// Shuffle the final pool to arrive at generated password
			Shuffle(characterPool);

			var generated = new char[totalLength];
			for (var i = 0; i < totalLength; i++)
				generated[i] = Convert.ToChar(characterPool[i]);
			return new string(generated);
		}

		public static bool VerifyComplexity(string password, int minimumLength, bool requireLower, bool requireUpper, bool requireNumerals, bool requireSymbols)
		{
			if (string.IsNullOrWhiteSpace(password) || password.Length < minimumLength)
				return false;

			if (requireLower & !password.Any(c => _lowerCase.Contains(c)))
				return false;

			if (requireUpper & !password.Any(c => _upperCase.Contains(c)))
				return false;

			if (requireNumerals & !password.Any(c => _numbers.Contains(c)))
				return false;

			if (requireSymbols & !password.Any(c => _punctuation.Contains(c)))
				return false;

			return true;
		}

		/// <summary>
		/// Creates an int array containing values from StartValue to StopValue, inclusive.
		/// </summary>
		private static int[] CreateIntArray(int startValue, int stopValue)
		{
			if (startValue >= stopValue)
				throw new ArgumentException();

			var arraySize = (stopValue - startValue) + 1;
			var asciiArray = new int[arraySize];
			for (var i = 0; i < asciiArray.Length; i++)
				asciiArray[i] = startValue++;
			return asciiArray;
		}

		/// <summary>
		/// An implementation of the Fisher-Yates shuffle.
		/// </summary>
		/// <remarks>http://en.wikipedia.org/wiki/Fisher-Yates_shuffle</remarks>
		private static void Shuffle(IList<int> array)
		{
			var r = new Random();
			var x = array.Count;
			while (x > 1)
			{
				var k = r.Next(x);
				x--;
				var temp = array[x];
				array[x] = array[k];
				array[k] = temp;
			}
		}

		/// <summary>
		/// Returns a random int value from a supplied int array.
		/// Omits values present in "Similars" if the form checkbox (No Similars) is checked.
		/// </summary>
		private static int GetRandomFromCharArray(int[] arr, bool noSimilar)
		{
			var newArr = (int[])arr.Clone();
			if (noSimilar)
				newArr = newArr.Except(_similars).ToArray();
			return newArr[_random.Next(0, newArr.Length)];
		}
	}
}