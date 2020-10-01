using System;

public class Car
{
	public Car()
	{
		CarLot.numberOfCars++;
	}
	public Car(int year, string make, string model, string engineNoise, string honkNoise, bool isDrivable)
	{
		Year = year;
		Make = make;
		Model = model;
		EngineNoise = engineNoise;
		HonkNoise = honkNoise;
		IsDrivable = isDrivable;

	}
	//Car shall have the following properties: Year, Make, Model, EngineNoise, HonkNoise, IsDriveable
	//Car shall have the following methods: MakeEngineNoise(), MakeHonkNoise()
	//The methods should take one string parameter: the respective noise property
	public string Make { get; set; }
	public string Model { get; set; }
	public string EngineNoise { get; set; }
	public string HonkNoise { get; set; }
	public bool IsDrivable { get; set; }
	public int Year { get; set; }
	public void MakeEngineNoise(string eng)
	{
		Console.WriteLine(EngineNoise);

	} 
     public void MakeHonkNoise()
    {
		Console.WriteLine(EngineNoise);
    }
}     
	    
	









































}


















	      
 
	

	
  
    

	 



    
