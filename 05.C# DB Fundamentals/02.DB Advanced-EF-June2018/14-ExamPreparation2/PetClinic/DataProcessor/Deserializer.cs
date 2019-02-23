namespace PetClinic.DataProcessor
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Globalization;
    using System.IO;
    using System.Linq;
    using System.Text;
    using System.Xml.Serialization;
    using Newtonsoft.Json;
    using PetClinic.Data;
    using PetClinic.DataProcessor.Dto.Import;
    using PetClinic.Models;

    public class Deserializer
    {
        private const string FailureMessage = "Error: Invalid data.";
        private const string SuccessMessage = "Record {0} successfully imported.";

        private const string SuccessMessageAnimal = "Record {0} Passport №: {1} successfully imported.";
        private const string FailureMessageAnimal = "Error: Invalid data.";

        private const string SuccessMessageVet = "Record {0} successfully imported.";
        private const string SuccessMessageProcedure = "Record successfully imported.";

        public static string ImportAnimalAids(PetClinicContext context, string jsonString)
        {
            var deserializedAnimalAids = JsonConvert.DeserializeObject<AnimalAidsDto[]>(jsonString);

            var validAnimalAids = new List<AnimalAid>();

            var sb = new StringBuilder();

            foreach (var animalAidDto in deserializedAnimalAids)
            {
                if (!IsValid(animalAidDto))
                {
                    sb.AppendLine(FailureMessage);
                    continue;
                }

                var animalAidExist = validAnimalAids.SingleOrDefault(x => x.Name == animalAidDto.Name);

                if (animalAidExist != null)
                {
                    sb.AppendLine(FailureMessage);
                    continue;
                }

                var animalAid = new AnimalAid
                {
                    Name = animalAidDto.Name,
                    Price = animalAidDto.Price
                };

                validAnimalAids.Add(animalAid);
                sb.AppendLine(String.Format(SuccessMessage, animalAid.Name));
            }

            context.AddRange(validAnimalAids);
            context.SaveChanges();

            var result = sb.ToString().TrimEnd();
            return result;
        }

        public static string ImportAnimals(PetClinicContext context, string jsonString)
        {
            var deserializedAnimals = JsonConvert.DeserializeObject<AnimalDto[]>(jsonString);


            var validAnimals = new List<Animal>();

            var sb = new StringBuilder();

            foreach (var animalDto in deserializedAnimals)
            {
                var passportExist = validAnimals.Any(x => x.Passport.SerialNumber == animalDto.Passport.SerialNumber);
                if (!IsValid(animalDto) || !IsValid(animalDto.Passport) || passportExist)
                {
                    sb.AppendLine(FailureMessageAnimal);
                    continue;
                }

                Passport passport = new Passport
                {
                    OwnerName = animalDto.Passport.OwnerName,
                    OwnerPhoneNumber = animalDto.Passport.OwnerPhoneNumber,
                    RegistrationDate = DateTime.ParseExact(animalDto.Passport.RegistrationDate, "dd-MM-yyyy", CultureInfo.InvariantCulture),
                    SerialNumber = animalDto.Passport.SerialNumber
                };

                Animal animal = new Animal
                {
                    Name = animalDto.Name,
                    Type = animalDto.Type,
                    Age = animalDto.Age,
                    Passport = passport
                };

                validAnimals.Add(animal);
                sb.AppendLine(String.Format(SuccessMessageAnimal, animal.Name, animal.Passport.SerialNumber));

            }

            context.AddRange(validAnimals);
            context.SaveChanges();

            var result = sb.ToString().TrimEnd();
            return result;
        }

        public static string ImportVets(PetClinicContext context, string xmlString)
        {
            var serializer = new XmlSerializer(typeof(VetDto[]), new XmlRootAttribute("Vets"));
            var deserializedVets = (VetDto[])serializer.Deserialize(new StringReader(xmlString));


            var validVets = new List<Vet>();

            StringBuilder sb = new StringBuilder();

            foreach (var vetDto in deserializedVets)
            {
                if (!IsValid(vetDto))
                {
                    sb.AppendLine(FailureMessage);
                    continue;
                }

                var vetPhoneNumbersExist = validVets.SingleOrDefault(x => x.PhoneNumber == vetDto.PhoneNumber);
                if (vetPhoneNumbersExist != null)
                {
                    sb.AppendLine(FailureMessage);
                    continue;
                }

                Vet vet = new Vet
                {
                    Name = vetDto.Name,
                    PhoneNumber = vetDto.PhoneNumber,
                    Age = vetDto.Age,
                    Profession = vetDto.Profession
                };

                validVets.Add(vet);


                sb.AppendLine(String.Format(SuccessMessageVet, vet.Name));
            }

            context.Vets.AddRange(validVets);
            context.SaveChanges();

            return sb.ToString().TrimEnd();
        }

        public static string ImportProcedures(PetClinicContext context, string xmlString)
        {
            var serializer = new XmlSerializer(typeof(ProceduresDto[]), new XmlRootAttribute("Procedures"));
            var deserializedProcedures = (ProceduresDto[])serializer.Deserialize(new StringReader(xmlString));

            var procedureAnimalAid = new List<ProcedureAnimalAid>();
            var procedures = new List<Procedure>();

            StringBuilder sb = new StringBuilder();

            foreach (var procedureDto in deserializedProcedures)
            {
                var vetObj = context.Vets.SingleOrDefault(x => x.Name == procedureDto.Vet.Name);
                var animalObj = context.Animals.SingleOrDefault(x => x.Passport.SerialNumber == procedureDto.Animal);
                var allAidsExist = true;

                foreach (var procedureDtoAnimalAid in procedureDto.AnimalAids)
                {
                    var animailAid = context.AnimalAids.SingleOrDefault(x => x.Name == procedureDtoAnimalAid.Name);
                    if (animailAid == null || procedureAnimalAid.Any(x => x.AnimalAid.Name == procedureDtoAnimalAid.Name))
                    {
                        allAidsExist = false;
                        break;
                    }

                    var animalAidProcedure = new ProcedureAnimalAid
                    {
                         AnimalAid = animailAid
                    };
                    procedureAnimalAid.Add(animalAidProcedure);

                }
                    if (!IsValid(procedureDto) || !procedureDto.AnimalAids.All(IsValid) || vetObj == null || animalObj == null)
                    {
                        sb.AppendLine(FailureMessage);
                        continue;
                    }

                Procedure procedure = new Procedure
                {
                    Vet = vetObj,
                    Animal = animalObj,
                    DateTime = DateTime.ParseExact(procedureDto.DateTime, "dd-MM-yyyy", CultureInfo.InvariantCulture),
                    ProcedureAnimalAids = procedureAnimalAid
                };

                procedures.Add(procedure);
                sb.AppendLine(SuccessMessageProcedure);
            }

            context.Procedures.AddRange(procedures);
            context.SaveChanges();

            return sb.ToString().TrimEnd();


        }

        public static bool IsValid(object obj)
        {
            var validationContext = new System.ComponentModel.DataAnnotations.ValidationContext(obj);
            var result = new List<ValidationResult>();

            return Validator.TryValidateObject(obj, validationContext, result, true);
        }
    }
}
