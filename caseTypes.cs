// Advanced - string to int conversion
string value = "123";
int result = 0;
if (int.Tryparse(value, out result))
{
    Console.WriteLine(" success" + result);
}
else
{
    Console.WriteLine(" failure.");
}