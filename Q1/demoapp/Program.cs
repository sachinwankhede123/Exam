Console.Write("Enter lower : ");
int l = int.Parse(Console.ReadLine());
Console.Write("Enter upper: ");
int u = int.Parse(Console.ReadLine());


 bool isOdd(int n){
		if(n%2==0)
			return false;
		return true;
	}
 bool isEven(int n){
		if(n%2==0)
			return true;
		return false;
	}
 bool isPrime(int n){
		int count=0;
		for(int i=2;i<n;++i)
		{
			if(n%i==0)
				count+=1;

			}
		if(count!=0)
			return false;
		else 
			return true;
	}
    