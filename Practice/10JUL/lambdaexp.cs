Func<int,int> square = x => x*x;

Console.WriteLine(square(8));

Func<int,int,int> sub = (a,b) => a-b;

Console.WriteLine(sub(58,18));