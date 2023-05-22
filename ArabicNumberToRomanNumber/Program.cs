int[] Arabik = {1000, 500, 100, 50, 10, 5, 1};
char[] Roman = { 'M', 'D','C', 'L', 'X', 'V', 'I'};
Console.WriteLine("Enter to number : ");
int arabicNumber = Convert.ToInt32(Console.ReadLine());
string result = "";
for (int i = 0; i < Roman.Length; i++)
{
	while (arabicNumber >= Arabik[i])
	{
		arabicNumber -= Arabik[i];
		result += Roman[i];
	}
}
Console.WriteLine(result);