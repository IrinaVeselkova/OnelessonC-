int count = 0;
int distance = 10000;
int FirstFriendSpeed = 2;
int SecondFriendSpeed = 3;
int dogSpeed = 5;
bool friend2 = true;
int time = 0;

{
    while (distance > 10)
    {
        if (friend2 == false)
        {
            time = distance / (FirstFriendSpeed + dogSpeed);
            friend2 = true;
        }
        time = distance / (SecondFriendSpeed + dogSpeed);
        friend2 = true;
    distance = distance - (FirstFriendSpeed + SecondFriendSpeed) * time;
    count++;
    }
    Console.WriteLine(count);
} 
