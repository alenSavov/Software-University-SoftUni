namespace PetClinic.DataProcessor
{
    using System;
    using System.Globalization;
    using System.Linq;
    using Newtonsoft.Json;
    using PetClinic.Data;

    public class Serializer
    {
        public static string ExportAnimalsByOwnerPhoneNumber(PetClinicContext context, string phoneNumber)
        {
          
            
            var animals = context.Animals
                                 .Where(x => x.Passport.OwnerPhoneNumber == phoneNumber)
                                 .Select(x => new
                                 {
                                     OwnerName = x.Passport.OwnerName,
                                     AnimalName = x.Name,
                                     Age = x.Passport.Animal.Age,
                                     SerialNumber = x.PassportSerialNumber,
                                     RegisteredOn = x.Passport.RegistrationDate.ToString("dd-MM-yyyy")
                                 })
                                 .OrderBy(x => x.Age)
                                 .ThenBy(x => x.SerialNumber)
                                 .ToArray();

            var jsonString = JsonConvert.SerializeObject(animals, Newtonsoft.Json.Formatting.Indented);
            return jsonString;
        }

        public static string ExportAllProcedures(PetClinicContext context)
        {
            throw new NotImplementedException();
        }
    }
}
