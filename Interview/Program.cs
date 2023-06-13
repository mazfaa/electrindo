Console.Write("Input a Number : ");
int n = Convert.ToInt32(Console.ReadLine());

static bool IsPrime(int n) {
  if (n < 2) return false;

  for (int i = 2; i <= Math.Sqrt(n); i++) 
    if (n % 2 == 0) return false;

  return true;
}

if (IsPrime(n)) Console.WriteLine(n + " is Prime Number");
else Console.WriteLine(n + " is Not Prime Number");

Console.WriteLine("Factors : ");
for (int i = n; i >= 1; i--)
  if (n % i == 0) Console.WriteLine(i);