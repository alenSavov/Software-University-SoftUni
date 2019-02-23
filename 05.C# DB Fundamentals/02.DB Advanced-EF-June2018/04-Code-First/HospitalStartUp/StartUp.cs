namespace Hospital.App
{
    using P01_HospitalDatabase.Data;

    public class StartUp
    {
        public static void Main()
        {
            using (var db = new HospitalContext())
            {
                //DatabaseInitializer.SeedPatients(db, 100);
            }
        }
    }
}
