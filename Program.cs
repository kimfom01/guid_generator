Console.Write("How many guids do you need: ");

int count;
bool success = int.TryParse(Console.ReadLine(), out count);

while (!success)
{
    Console.WriteLine("Invalid input!");
    Console.Write("How many guids do you need: ");
    success = int.TryParse(Console.ReadLine(), out count);
}

Console.WriteLine("Generating...");

for (int i = 0; i < count; i++)
{
    Console.WriteLine(Guid.NewGuid());
}

Console.WriteLine("Done");
