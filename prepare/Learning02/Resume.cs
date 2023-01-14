public class Resume{
    public string _name;
    public List<Job> _Job = new List<Job>();

    public void DisplayValues(){
        Console.WriteLine($"Name: {_name}");
        Console.WriteLine("Jobs: ");


        foreach (
            Job job in _Job)
        {
            job.DisplayValues();
        }
    }


}