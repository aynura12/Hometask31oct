#region Average
int number = 10 ;
int sum = 0;
int average = 0;
int count = 0;
if (number != 10)
{ Console.WriteLine("Bize lazim olan 1-10 araligindaki reqemlerin ededi ortasidir,edediniz 10-a beraber olmalidir"); }
else
{
    for (int i = 1; i < number; i++)
    {

        if (i % 2 == 0)
        {
            sum = sum + i;

            count++;
        }

    }
    average = sum / count;
    Console.WriteLine(average);



}

#endregion
#region
int nmbr = -17;
int rem = 0;
int level = 0;

while (nmbr != 0)
{
    rem = nmbr % 10;
    nmbr = (nmbr - rem) / 10;
    level = level + rem;
}
if (level < 0)
{ 
    Console.WriteLine(level = level * (-1));
}

else
{
    Console.WriteLine(level);
}

if (level == 0)
{ Console.WriteLine("0 daxil ede bilmerik");
}





#endregion
