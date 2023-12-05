namespace Classes
{
    public class Calculator
    {
        // a method with varying number of parameters
        public int Add(int[] numbers) { }

        // better approach - params modifier
        public int Add(params int[] numbers) { }
    }

    var result = calculator.Add(new int[] { 1, 2, 3, 4 });

    // this is instead a better approach for above implementation
    var result = calculator.Add(1, 2, 3, 4);

}
