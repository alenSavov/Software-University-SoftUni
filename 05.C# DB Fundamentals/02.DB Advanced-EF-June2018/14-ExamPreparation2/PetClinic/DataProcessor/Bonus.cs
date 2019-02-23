namespace PetClinic.DataProcessor
{
    using System;
    using System.Linq;
    using PetClinic.Data;

    public class Bonus
    {
        private const string FailureMessage = "Vet with phone number {0} not found!";
        private const string SuccessMessage = "{0}'s profession updated from {1} to {2}.";


        public static string UpdateVetProfession(PetClinicContext context, string phoneNumber, string newProfession)
        {
            var vet = context.Vets
                             .FirstOrDefault(x => x.PhoneNumber == phoneNumber);

            if (vet == null)
            {
                return String.Format(FailureMessage, phoneNumber);
            }

            var oldProfession = vet.Profession;
            vet.Profession = newProfession;

            context.SaveChanges();

            return String.Format(SuccessMessage, vet.Name, oldProfession, newProfession);
        }
    }
}
