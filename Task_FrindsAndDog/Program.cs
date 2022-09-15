int count = 0, distance = 10000,
    firstFriendSpeed = 1,
    secondFriendSpeed = 2,
    dogSpeed = 5, friend = 2;
int time = 0;

while (distance > 10)
{
    if (friend == 1)
    {
        time = distance / (firstFriendSpeed + dogSpeed);
        friend = 2;
    }

    else
    {
        time = distance / (secondFriendSpeed + dogSpeed);
        friend = 1;
    } 

    distance = distance - (firstFriendSpeed + secondFriendSpeed) * time;
    count++;
}

Console.Write("Собака пробежала ");
Console.Write(count);
Console.Write(" раз!");