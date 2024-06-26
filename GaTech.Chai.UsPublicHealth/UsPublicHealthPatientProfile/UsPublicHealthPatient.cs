using System;
using Hl7.Fhir.Model;
using GaTech.Chai.Share;
using GaTech.Chai.UsCore;

namespace GaTech.Chai.UsPublicHealth
{
    /// <summary>
    /// US Public Health Patient Profile
    /// http://hl7.org/fhir/us/ecr/StructureDefinition/us-ph-patient
    /// </summary>
    public class UsPublicHealthPatient
    {
        readonly Patient patient;
        readonly UsPublicHealthTribalAffiliation patientTribalAffiliation;

        internal UsPublicHealthPatient(Patient p)
        {
            this.patient = p;
            p.UsCorePatient().AddProfile();
            this.patientTribalAffiliation = new UsPublicHealthTribalAffiliation(p);
        }

        /// <summary>
        /// Factory for US Public Health Patient Profile
        /// http://hl7.org/fhir/us/ecr/StructureDefinition/us-ph-patient
        /// </summary>
        public static Patient Create()
        {
            var patient = new Patient();
            patient.UsPublicHealthPatient().AddProfile();
            return patient;
        }

        /// <summary>
        /// The official URL for the US Public Health Patient Profile, used to assert conformance.
        /// </summary>
        public const string ProfileUrl = "http://hl7.org/fhir/us/ecr/StructureDefinition/us-ph-patient";

        /// <summary>
        /// Set profile for US Public Health Patient Profile
        /// </summary>
        public void AddProfile()
        {
            patient.AddProfile(ProfileUrl);
        }

        /// <summary>
        /// Clear profile for US Public Health Patient Profile
        /// </summary>
        public void RemoveProfile()
        {
            patient.RemoveProfile(ProfileUrl);
        }

        /// <summary>
        /// Patient Birth Place
        /// http://hl7.org/fhir/StructureDefinition/patient-birthPlace
        /// </summary>
        public Address BirthPlace
        {
            get => patient.GetExtension(
                    "http://hl7.org/fhir/StructureDefinition/patient-birthPlace")?.Value as Address;
            set => patient.Extension.AddOrUpdateExtension(
                    "http://hl7.org/fhir/StructureDefinition/patient-birthPlace", value);
        }

        /// <summary>
        /// Patient Gender Identity
        /// http://hl7.org/fhir/StructureDefinition/patient-genderIdentity
        /// </summary>
        public CodeableConcept GenderIdentity
        {
            get => patient.GetExtension(
                    "http://hl7.org/fhir/StructureDefinition/patient-genderIdentity")?.Value as CodeableConcept;
            set => patient.Extension.AddOrUpdateExtension(
                    "http://hl7.org/fhir/StructureDefinition/patient-genderIdentity", value);
        }

        /// <summary>
        /// Tribal affiliation and membership of the patient
        /// http://hl7.org/fhir/us/ecr/StructureDefinition/us-ph-tribal-affiliation-extension
        /// </summary>
        public UsPublicHealthTribalAffiliation TribalAffiliation => patientTribalAffiliation;

        /// <summary>
        /// Set data-absent-reason extension to identifier
        /// </summary>
        public void SetIdentifierDataAbsentReason()
        {
            IdentifierDataAbsentReason = new Code("masked");
        }
        public Code IdentifierDataAbsentReason
        {
            get => patient.Identifier?[0].GetExtension("http://hl7.org/fhir/StructureDefinition/data-absent-reason")?.Value as Code;
            set
            {
                if (patient.Identifier == null || patient.Identifier.Count == 0)
                {
                    patient.Identifier.Add(new Identifier());
                }
                patient.Identifier[0].Extension.AddOrUpdateExtension("http://hl7.org/fhir/StructureDefinition/data-absent-reason", value);
            }
        }

        /// <summary>
        /// Set data-absent-reason extension to Name
        /// </summary>
        public void SetNameDataAbsentReason()
        {
            NameDataAbsentReason = new Code("masked");
        }
        public Code NameDataAbsentReason
        {
            get => patient.Name?[0].GetDataAbsentReason();
            set
            {
                if (patient.Name == null || patient.Name.Count == 0)
                {
                    patient.Name.Add(new HumanName());
                }
                patient.Name[0].AddDataAbsentReason(value);
            }
        }

        /// <summary>
        /// Set data-absent-reason extension to Telecom
        /// </summary>
        public void SetTelecomDataAbsentReason()
        {
            TelecomDataAbsentReason = new Code("masked");
        }
        public Code TelecomDataAbsentReason
        {
            get => patient.Telecom?[0].GetDataAbsentReason();
            set
            {
                if (patient.Telecom == null || patient.Telecom.Count == 0)
                {
                    patient.Telecom.Add(new ContactPoint());
                }
                patient.Telecom[0].AddDataAbsentReason(value);
            }
        }

        /// <summary>
        /// Set data-absent-reason extension to Gender
        /// </summary>
        public void SetGenderDataAbsentReason()
        {
            GenderDataAbsentReason = new Code("masked");
        }
        public Code GenderDataAbsentReason
        {
            get => patient.GenderElement?.GetExtension(
                    "http://hl7.org/fhir/StructureDefinition/data-absent-reason")?.Value as Code;
            set
            {
                if (patient.GenderElement == null)
                    patient.GenderElement = new Code<AdministrativeGender>();
                patient.GenderElement.Extension.AddOrUpdateExtension(
                    "http://hl7.org/fhir/StructureDefinition/data-absent-reason", value);
            }
        }

        /// <summary>
        /// Set data-absent-reason extension to Birth Date
        /// </summary>
        public void SetBrithDateDataAbsentReason()
        {
            BrithDateDataAbsentReason = new Code("masked");
        }
        public Code BrithDateDataAbsentReason
        {
            get => patient.BirthDateElement?.GetExtension(
                    "http://hl7.org/fhir/StructureDefinition/data-absent-reason")?.Value as Code;
            set
            {
                if (patient.BirthDateElement == null)
                    patient.BirthDateElement = new Date();

                patient.BirthDateElement.Extension.AddOrUpdateExtension(
                    "http://hl7.org/fhir/StructureDefinition/data-absent-reason", value);
            }
        }

        /// <summary>
        /// Set data-absent-reason extension to Birth Date
        /// </summary>
        public void SetAddressDataAbsentReason()
        {
            AddressDataAbsentReason = new Code("masked");
        }
        public Code AddressDataAbsentReason
        {
            get => patient.Address?[0].GetDataAbsentReason();
            set
            {
                if (patient.Address == null || patient.Address.Count == 0)
                {
                    patient.Address.Add(new Address());
                }
                patient.Address[0].AddDataAbsentReason(value);
            }
        }

        /// <summary>
        /// Set data-absent-reason extension to ContactName
        /// </summary>
        public void SetContactNameDataAbsentReason()
        {
            ContactNameDataAbsentReason = new Code("maksed");
        }
        public Code ContactNameDataAbsentReason
        {
            get => patient.Contact?[0].Name?.GetDataAbsentReason();
            set
            {
                if (patient.Contact == null || patient.Contact.Count == 0)
                {
                    patient.Contact.Add(new Patient.ContactComponent());
                }

                if (patient.Contact[0].Name == null)
                    patient.Contact[0].Name = new HumanName();

                patient.Contact[0].Name.AddDataAbsentReason(value);
            }
        }

        /// <summary>
        /// Set data-absent-reason extension to ContactTelecom
        /// </summary>
        public void SetContactTelecomDataAbsentReason()
        {
            ContactTelecomDataAbsentReason = new Code("masked");
        }
        public Code ContactTelecomDataAbsentReason
        {
            get => patient.Contact?[0].Telecom?[0].GetDataAbsentReason();
            set
            {
                if (patient.Contact == null || patient.Contact.Count == 0)
                {
                    patient.Contact.Add(new Patient.ContactComponent());
                }

                if (patient.Contact[0].Telecom == null)
                    patient.Contact[0].Telecom.Add(new ContactPoint());

                patient.Contact[0].Telecom[0].AddDataAbsentReason(value);
            }
        }

        /// <summary>
        /// Set data-absent-reason extension to ContactAddress
        /// </summary>
        public void SetContactAddressDataAbsentReason()
        {
            ContactAddressDataAbsentReason = new Code("masked");
        }
        public Code ContactAddressDataAbsentReason
        {
            get => patient.Contact?[0].Address?.GetDataAbsentReason();
            set
            {
                if (patient.Contact == null || patient.Contact.Count == 0)
                {
                    patient.Contact.Add(new Patient.ContactComponent());
                }

                if (patient.Contact[0].Address == null)
                    patient.Contact[0].Address = new Address();

                patient.Contact[0].Address.AddDataAbsentReason(value);
            }
        }

        /// <summary>
        /// Set data-absent-reason extension to CommunicationLanguage
        /// </summary>
        public void SetCommunicationLanguageDataAbsentReason()
        {
            CommunicationLanguageDataAbsentReason = new Code("masked");
        }
        public Code CommunicationLanguageDataAbsentReason
        {
            get => patient.Communication?[0].Language?.GetDataAbsentReason();
            set
            {
                if (patient.Communication == null || patient.Communication.Count == 0)
                {
                    patient.Communication.Add(new Patient.CommunicationComponent());
                }

                if (patient.Communication[0].Language == null)
                {
                    patient.Communication[0].Language = new CodeableConcept();
                }

                patient.Communication[0].Language.AddDataAbsentReason(value);
            }
        }

        public static CodeableConcept GenderMale = new CodeableConcept("http://hl7.org/fhir/gender-identity", "male", "male", null);
        public static CodeableConcept GenderFemale = new CodeableConcept("http://hl7.org/fhir/gender-identity", "female", "female", null);
        public static CodeableConcept NonBinary = new CodeableConcept("http://hl7.org/fhir/gender-identity", "non-binary", "non-binary", null);
        public static CodeableConcept TransgenderMale = new CodeableConcept("http://hl7.org/fhir/gender-identity", "transgender-male", "transgender male", null);
        public static CodeableConcept TransgenderFemale = new CodeableConcept("http://hl7.org/fhir/gender-identity", "transgender-male", "transgender male", null);
        public static CodeableConcept Other = new CodeableConcept("http://hl7.org/fhir/gender-identity", "other", "other", null);
        public static CodeableConcept NonDisclose = new CodeableConcept("http://hl7.org/fhir/gender-identity", "non-disclose", "non-disclose", null);
    }
}