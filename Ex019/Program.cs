int i = 14212;
int duplicate = i;
int reverse = 0;
while (i > 0)
{
    int a = i % 10;
    reverse = reverse * 10 + a;
    i = i / 10;
}
if(duplicate == reverse)
{
    Console.WriteLine("Палиндром");
}
else
{
    Console.WriteLine("Не палиндром");
}