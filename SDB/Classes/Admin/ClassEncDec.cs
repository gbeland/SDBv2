using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;

namespace SDB.Classes.Admin
{
	// ReSharper disable MemberCanBePrivate.Global
	// ReSharper disable MemberCanBeMadeStatic.Global
	#pragma warning disable 612,618
	public static class ClassEncDec
	{
		const int _BUFFER_LEN = 4096;

		/// <summary>
		/// Encrypt a byte array into a byte array using a key and an IV 
		/// </summary>
		public static byte[] Encrypt(byte[] clearData, byte[] key, byte[] iv)
		{
			// Create a MemoryStream to accept the encrypted bytes 
			MemoryStream ms = new MemoryStream();

			// Create a symmetric algorithm. 
			// We are going to use Rijndael because it is strong and
			// available on all platforms. 
			// You can use other algorithms, to do so substitute the
			// next line with something like 
			//      TripleDES alg = TripleDES.Create(); 
			Rijndael alg = Rijndael.Create();

			// Now set the key and the IV. 
			// We need the IV (Initialization Vector) because
			// the algorithm is operating in its default 
			// mode called CBC (Cipher Block Chaining).
			// The IV is XORed with the first block (8 byte) 
			// of the data before it is encrypted, and then each
			// encrypted block is XORed with the 
			// following block of plaintext.
			// This is done to make encryption more secure. 

			// There is also a mode called ECB which does not need an IV,
			// but it is much less secure. 
			alg.Key = key;
			alg.IV = iv;

			// Create a CryptoStream through which we are going to be
			// pumping our data. 
			// CryptoStreamMode.Write means that we are going to be
			// writing data to the stream and the output will be written
			// in the MemoryStream we have provided. 
			CryptoStream cs = new CryptoStream(ms,
			   alg.CreateEncryptor(), CryptoStreamMode.Write);

			// Write the data and make it do the encryption 
			cs.Write(clearData, 0, clearData.Length);

			// Close the crypto stream (or do FlushFinalBlock). 
			// This will tell it that we have done our encryption and
			// there is no more data coming in, 
			// and it is now a good time to apply the padding and
			// finalize the encryption process. 
			cs.Close();

			// Now get the encrypted data from the MemoryStream.
			// Some people make a mistake of using GetBuffer() here,
			// which is not the right way. 
			byte[] encryptedData = ms.ToArray();

			return encryptedData;
		}

		/// <summary>
		/// Encrypt a string into a string using a password 
		/// Uses Encrypt(byte[], byte[], byte[]) 
		/// </summary>
		public static string Encrypt(string clearText, string password)
		{
			// First we need to turn the input string into a byte array. 
			byte[] clearBytes = Encoding.Unicode.GetBytes(clearText);

			// Then, we need to turn the password into Key and IV 
			// We are using salt to make it harder to guess our key
			// using a dictionary attack - 
			// trying to guess a password by enumerating all possible words. 

			PasswordDeriveBytes pdb = new PasswordDeriveBytes(password,
				new byte[] {0x49, 0x76, 0x61, 0x6e, 0x20, 0x4d, 
			0x65, 0x64, 0x76, 0x65, 0x64, 0x65, 0x76});

			// Now get the key/IV and do the encryption using the
			// function that accepts byte arrays. 
			// Using PasswordDeriveBytes object we are first getting
			// 32 bytes for the Key 
			// (the default Rijndael key length is 256bit = 32bytes)
			// and then 16 bytes for the IV. 
			// IV should always be the block size, which is by default
			// 16 bytes (128 bit) for Rijndael. 
			// If you are using DES/TripleDES/RC2 the block size is
			// 8 bytes and so should be the IV size. 
			// You can also read KeySize/BlockSize properties off
			// the algorithm to find out the sizes. 
			byte[] encryptedData = Encrypt(clearBytes, pdb.GetBytes(32), pdb.GetBytes(16));

			// Now we need to turn the resulting byte array into a string. 
			// A common mistake would be to use an Encoding class for that.
			//It does not work because not all byte values can be
			// represented by characters. 
			// We are going to be using Base64 encoding that is designed
			//exactly for what we are trying to do. 
			return Convert.ToBase64String(encryptedData);
		}

		/// <summary>
		/// Encrypt bytes into bytes using a password 
		/// Uses Encrypt(byte[], byte[], byte[]) 
		/// </summary>
		public static byte[] Encrypt(byte[] clearData, string password)
		{
			// We need to turn the password into Key and IV. 
			// We are using salt to make it harder to guess our key
			// using a dictionary attack - 
			// trying to guess a password by enumerating all possible words. 

			PasswordDeriveBytes pdb = new PasswordDeriveBytes(password,
				new byte[] {0x49, 0x76, 0x61, 0x6e, 0x20, 0x4d, 
			0x65, 0x64, 0x76, 0x65, 0x64, 0x65, 0x76});

			// Now get the key/IV and do the encryption using the function
			// that accepts byte arrays. 
			// Using PasswordDeriveBytes object we are first getting
			// 32 bytes for the Key 
			// (the default Rijndael key length is 256bit = 32bytes)
			// and then 16 bytes for the IV. 
			// IV should always be the block size, which is by default
			// 16 bytes (128 bit) for Rijndael. 
			// If you are using DES/TripleDES/RC2 the block size is 8
			// bytes and so should be the IV size. 
			// You can also read KeySize/BlockSize properties off the
			// algorithm to find out the sizes. 
			return Encrypt(clearData, pdb.GetBytes(32), pdb.GetBytes(16));

		}

		/// <summary>
		/// Encrypt a file into another file using a password 
		/// </summary>
		public static void Encrypt(string fileIn, string fileOut, string password)
		{

			// First we are going to open the file streams 
			FileStream fsIn = new FileStream(fileIn,
				FileMode.Open, FileAccess.Read);
			FileStream fsOut = new FileStream(fileOut,
				FileMode.OpenOrCreate, FileAccess.Write);

			// Then we are going to derive a Key and an IV from the
			// Password and create an algorithm 

			PasswordDeriveBytes pdb = new PasswordDeriveBytes(password,
				new byte[] {0x49, 0x76, 0x61, 0x6e, 0x20, 0x4d, 
			0x65, 0x64, 0x76, 0x65, 0x64, 0x65, 0x76});

			Rijndael alg = Rijndael.Create();
			alg.Key = pdb.GetBytes(32);
			alg.IV = pdb.GetBytes(16);

			// Now create a crypto stream through which we are going
			// to be pumping data. 
			// Our fileOut is going to be receiving the encrypted bytes. 
			CryptoStream cs = new CryptoStream(fsOut,
				alg.CreateEncryptor(), CryptoStreamMode.Write);

			// Now will will initialize a buffer and will be processing
			// the input file in chunks. 
			// This is done to avoid reading the whole file (which can
			// be huge) into memory. 
			byte[] buffer = new byte[_BUFFER_LEN];
			int bytesRead;

			do
			{
				// read a chunk of data from the input file 
				bytesRead = fsIn.Read(buffer, 0, _BUFFER_LEN);

				// encrypt it 
				cs.Write(buffer, 0, bytesRead);
			} while (bytesRead != 0);

			// close everything 

			// this will also close the unrelying fsOut stream
			cs.Close();
			fsIn.Close();
		}

		/// <summary>
		/// Decrypt a byte array into a byte array using a key and an IV  
		/// </summary>
		public static byte[] Decrypt(byte[] cipherData, byte[] key, byte[] iv)
		{
			// Create a MemoryStream that is going to accept the
			// decrypted bytes 
			MemoryStream ms = new MemoryStream();

			// Create a symmetric algorithm. 
			// We are going to use Rijndael because it is strong and
			// available on all platforms. 
			// You can use other algorithms, to do so substitute the next
			// line with something like 
			//     TripleDES alg = TripleDES.Create(); 
			Rijndael alg = Rijndael.Create();

			// Now set the key and the IV. 
			// We need the IV (Initialization Vector) because the algorithm
			// is operating in its default 
			// mode called CBC (Cipher Block Chaining). The IV is XORed with
			// the first block (8 byte) 
			// of the data after it is decrypted, and then each decrypted
			// block is XORed with the previous 
			// cipher block. This is done to make encryption more secure. 
			// There is also a mode called ECB which does not need an IV,
			// but it is much less secure. 
			alg.Key = key;
			alg.IV = iv;

			// Create a CryptoStream through which we are going to be
			// pumping our data. 
			// CryptoStreamMode.Write means that we are going to be
			// writing data to the stream 
			// and the output will be written in the MemoryStream
			// we have provided. 
			CryptoStream cs = new CryptoStream(ms,
				alg.CreateDecryptor(), CryptoStreamMode.Write);

			// Write the data and make it do the decryption 
			cs.Write(cipherData, 0, cipherData.Length);

			// Close the crypto stream (or do FlushFinalBlock). 
			// This will tell it that we have done our decryption
			// and there is no more data coming in, 
			// and it is now a good time to remove the padding
			// and finalize the decryption process.
			try
			{
				cs.Close();
			}
			catch
			{
				return (ms.ToArray());
			}

			// Now get the decrypted data from the MemoryStream. 
			// Some people make a mistake of using GetBuffer() here,
			// which is not the right way. 
			byte[] decryptedData = ms.ToArray();

			return decryptedData;
		}

		/// <summary>
		///  Decrypt a string into a string using a password
		///  Uses Decrypt(byte[], byte[], byte[]) 
		/// </summary>
		public static string Decrypt(string cipherText, string password)
		{
			// First we need to turn the input string into a byte array. 
			// We presume that Base64 encoding was used 
			byte[] cipherBytes = Convert.FromBase64String(cipherText);

			// Then, we need to turn the password into Key and IV 
			// We are using salt to make it harder to guess our key
			// using a dictionary attack - 
			// trying to guess a password by enumerating all possible words. 

			PasswordDeriveBytes pdb = new PasswordDeriveBytes(password,
				new byte[] {0x49, 0x76, 0x61, 0x6e, 0x20, 0x4d, 0x65, 
			0x64, 0x76, 0x65, 0x64, 0x65, 0x76});

			// Now get the key/IV and do the decryption using
			// the function that accepts byte arrays. 
			// Using PasswordDeriveBytes object we are first
			// getting 32 bytes for the Key 
			// (the default Rijndael key length is 256bit = 32bytes)
			// and then 16 bytes for the IV. 
			// IV should always be the block size, which is by
			// default 16 bytes (128 bit) for Rijndael. 
			// If you are using DES/TripleDES/RC2 the block size is
			// 8 bytes and so should be the IV size. 
			// You can also read KeySize/BlockSize properties off
			// the algorithm to find out the sizes. 
			byte[] decryptedData = Decrypt(cipherBytes,
				pdb.GetBytes(32), pdb.GetBytes(16));

			// Now we need to turn the resulting byte array into a string. 
			// A common mistake would be to use an Encoding class for that.
			// It does not work 
			// because not all byte values can be represented by characters. 
			// We are going to be using Base64 encoding that is 
			// designed exactly for what we are trying to do. 
			return Encoding.Unicode.GetString(decryptedData);
		}

		/// <summary>
		/// Decrypt bytes into bytes using a password 
		/// Uses Decrypt(byte[], byte[], byte[]) 
		/// </summary>
		public static byte[] Decrypt(byte[] cipherData, string password)
		{
			// We need to turn the password into Key and IV. 
			// We are using salt to make it harder to guess our key
			// using a dictionary attack - 
			// trying to guess a password by enumerating all possible words. 

			PasswordDeriveBytes pdb = new PasswordDeriveBytes(password,
				new byte[] {0x49, 0x76, 0x61, 0x6e, 0x20, 0x4d, 
			0x65, 0x64, 0x76, 0x65, 0x64, 0x65, 0x76});

			// Now get the key/IV and do the Decryption using the 
			//function that accepts byte arrays. 
			// Using PasswordDeriveBytes object we are first getting
			// 32 bytes for the Key 
			// (the default Rijndael key length is 256bit = 32bytes)
			// and then 16 bytes for the IV. 
			// IV should always be the block size, which is by default
			// 16 bytes (128 bit) for Rijndael. 
			// If you are using DES/TripleDES/RC2 the block size is
			// 8 bytes and so should be the IV size. 

			// You can also read KeySize/BlockSize properties off the
			// algorithm to find out the sizes. 
			return Decrypt(cipherData, pdb.GetBytes(32), pdb.GetBytes(16));
		}

		/// <summary>
		/// Decrypt a file into another file using a password 
		/// </summary>
		public static void Decrypt(string fileIn, string fileOut, string password)
		{

			// First we are going to open the file streams 
			FileStream fsIn = new FileStream(fileIn,
						FileMode.Open, FileAccess.Read);
			FileStream fsOut = new FileStream(fileOut,
						FileMode.OpenOrCreate, FileAccess.Write);

			// Then we are going to derive a Key and an IV from
			// the Password and create an algorithm 

			PasswordDeriveBytes pdb = new PasswordDeriveBytes(password,
				new byte[] {0x49, 0x76, 0x61, 0x6e, 0x20, 0x4d, 
			0x65, 0x64, 0x76, 0x65, 0x64, 0x65, 0x76});
			Rijndael alg = Rijndael.Create();

			alg.Key = pdb.GetBytes(32);
			alg.IV = pdb.GetBytes(16);

			// Now create a crypto stream through which we are going
			// to be pumping data. 
			// Our fileOut is going to be receiving the Decrypted bytes. 
			CryptoStream cs = new CryptoStream(fsOut,
				alg.CreateDecryptor(), CryptoStreamMode.Write);

			// Now will will initialize a buffer and will be 
			// processing the input file in chunks. 
			// This is done to avoid reading the whole file (which can be
			// huge) into memory. 
			byte[] buffer = new byte[_BUFFER_LEN];
			int bytesRead;

			do
			{
				// read a chunk of data from the input file 
				bytesRead = fsIn.Read(buffer, 0, _BUFFER_LEN);

				// Decrypt it 
				cs.Write(buffer, 0, bytesRead);

			} while (bytesRead != 0);

			// close everything 
			cs.Close(); // this will also close the unrelying fsOut stream 
			fsIn.Close();
		}
	}
	#pragma warning restore 612,618
	// ReSharper restore MemberCanBePrivate.Global
	// ReSharper restore MemberCanBeMadeStatic.Global

	/// <summary>
	/// Provides just one method to encrypt a string using Rijndael algorithm.
	/// Key and IV generation is done using PBDKF2 (via Rfc2898DeriveBytes); unlike ClassEncDec which uses deprecated PBDKF1.
	/// </summary>
	/// <remarks>This class is used for Customer Portal Logins; it is not interchangeable with ClassEncDec without some modification.</remarks>
	public static class ClassEncryptionNew
	{
		/// <summary>
		/// Returns a base-64 encoded string representing the hashed password.
		/// </summary>
		public static string Encrypt(string clearText, string salt)
		{
			byte[] clearBytes = Encoding.Unicode.GetBytes(clearText);
			// Derived key salt is "Yesco Service"
			Rfc2898DeriveBytes derived = new Rfc2898DeriveBytes(salt,
				new byte[] { 0x59, 0x65, 0x73, 0x63, 0x6f, 0x20, 0x53, 0x65, 0x72, 0x76, 0x69, 0x63, 0x65 });
			MemoryStream ms = new MemoryStream();
			Rijndael alg = Rijndael.Create();
			alg.Padding = PaddingMode.Zeros;
			alg.Key = derived.GetBytes(32);
			alg.IV = derived.GetBytes(16);

			CryptoStream cs = new CryptoStream(ms, alg.CreateEncryptor(), CryptoStreamMode.Write);
			cs.Write(clearBytes, 0, clearBytes.Length);
			cs.Close();
			return Convert.ToBase64String(ms.ToArray());
		}
	}
}