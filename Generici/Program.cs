using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generici
{
	class Program
	{
		static void Main(string[] args)
		{
			NasaLista<int> testBr = new NasaLista<int>();
			testBr.Dodaj(2);
			testBr.Dodaj(5);
			testBr.Dodaj(6);
			testBr.Dodaj(8);

			do
			{
				if (testBr.Sledeci(out int sl))
					Console.WriteLine(sl);
				else
				{
					break;
				}
			} while (true);

			NasaLista<bool> testBro = new NasaLista<bool>();
			testBro.Dodaj(true);
			testBro.Dodaj(true);
			testBro.Dodaj(false);
			testBro.Dodaj(false);

			do
			{
				if (testBro.Sledeci(out  bool sl))
					Console.WriteLine(sl);
				else
				{
					break;
				}
			} while (true);
			Console.ReadKey();
		}
	}

	class NasaLista<T>
	{
		private T[] niz = new T[0];
		private int trenutniElement = -1;

		public void Dodaj(T ele)
		{
			Array.Resize<T>(ref niz, niz.Length + 1);
			niz[niz.Length - 1] = ele;
		}

		public bool Sledeci(out T ele)
		{
			if (trenutniElement < niz.Length - 1)
			{
				ele = niz[++trenutniElement];
				return true;
			}

			ele = default(T);
			return false;
		}

	}
	

	class Zamenjivac<T>
	{
		public void Zamena (T x, T y)
		{
			switch(x)
			{
				case int b:
					Console.WriteLine("Broj je :D" + b * 2);
					break;
				case string s:
					Console.WriteLine("String je :D" + s.ToUpper());
					break;
			}
			T temp = x;
			x = y;
			y = temp;
		}
	}
}
