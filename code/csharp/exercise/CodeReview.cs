namespace CodeReview
{
    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FullName => FirstName + " " + LastName;

        public DateTime BirthdayDate { get; set; }

        public static int ComputeAge(Person person)
        {
            var totalDays = (DateTime.Now - person.BirthdayDate).TotalDays;
            return ServiceLocator.Current.GetInstance<IAgeComputer>().ComputeAge(totalDays);
        }
    }

    public class Foo
    {
        public event EventHandler MyEvent;
        private readonly int _syncRoot = 42;
    
        public void RaiseMyEvent()
        {
            Monitor.Enter(_syncRoot);
            try
            {
                if (MyEvent != null)
                    MyEvent(this, new EventArgs());
            }
            finally
            {
                Monitor.Exit(_syncRoot);
            }
        }
    }
}