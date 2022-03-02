﻿using System;
using Hl7.Fhir.Model;
using GaTech.Chai.FhirIg.Extensions;

namespace GaTech.Chai.Cbs.UsCbsConditionProfile
{
    /// <summary>
    /// Case Based Surveillance Lab Condition Profile Extensions
    /// http://cbsig.chai.gatech.edu/StructureDefinition/us-cbs-condition
    /// </summary>
    public class UsCbsCondition
    {
        readonly Condition condition;

        internal UsCbsCondition(Condition condition)
        {
            this.condition = condition;
        }

        /// <summary>
        /// Factory for Case Based Surveillance Lab Condition Profile
        /// http://cbsig.chai.gatech.edu/StructureDefinition/us-cbs-condition
        /// </summary>
        public static Condition Create()
        {
            var condition = new Condition();
            condition.UsCbsCondition().AddProfile();
            return condition;
        }

        /// <summary>
        /// The official URL for the Case Based Surveillance Lab Condition profile, used to assert conformance.
        /// </summary>
        public const string ProfileUrl = "http://cbsig.chai.gatech.edu/StructureDefinition/us-cbs-condition";

        /// <summary>
        /// Set the assertion that an condition object conforms to the Case Based Surveillance Lab Condition profile.
        /// </summary>
        public void AddProfile()
        {
            this.condition.AddProfile(ProfileUrl);
        }

        /// <summary>
        /// Clear the assertion that an condition object conforms to the Case Based Surveillance Lab Condition profile.
        /// </summary>
        public void RemoveProfile()
        {
            this.condition.RemoveProfile(ProfileUrl);
        }

        /// <summary>
        /// Diagnosis Date
        /// http://cbsig.chai.gatech.edu/StructureDefinition/cbs-diagnosis-date
        /// </summary>
        public FhirDateTime DiagnosisDate
        {
            get => this.condition.GetExtension(
                    "http://cbsig.chai.gatech.edu/StructureDefinition/cbs-diagnosis-date")?.Value as FhirDateTime;
            set => this.condition.Extension.AddOrUpdateExtension(
                    "http://cbsig.chai.gatech.edu/StructureDefinition/cbs-diagnosis-date", value);
        }

        /// <summary>
        /// Set Classification Status
        /// http://cbsig.chai.gatech.edu/StructureDefinition/cbs-case-class-status
        /// </summary>
        public CodeableConcept ClassificationStatus
        {
            get => this.condition.GetExtension(
                    "http://cbsig.chai.gatech.edu/StructureDefinition/cbs-case-class-status")?.Value as CodeableConcept;
            set => this.condition.Extension.AddOrUpdateExtension(
                    "http://cbsig.chai.gatech.edu/StructureDefinition/cbs-case-class-status", value);
        }
        /// <summary>
        /// Illness Duration
        /// http://cbsig.chai.gatech.edu/StructureDefinition/cbs-illness-duration
        /// </summary>
        public Quantity IllnesDuration
        {
            get => this.condition.GetExtension(
                    "http://cbsig.chai.gatech.edu/StructureDefinition/cbs-illness-duration")?.Value as Quantity;
            set => this.condition.Extension.AddOrUpdateExtension(
                    "http://cbsig.chai.gatech.edu/StructureDefinition/cbs-illness-duration", value);
        }

        /// <summary>
        /// Nationally Notifiable Disease Surveillance System (NNDSS) & Other Conditions of Public Health Importance
        /// 2.16.840.1.114222.4.5.277
        /// </summary>
        public static class ConditionCode
        {
            /// <summary>
            /// Nationally Notifiable Disease Surveillance System (NNDSS) & Other Conditions of Public Health Importance
            /// 2.16.840.1.114222.4.5.277
            /// </summary>
            /// <param name="code"></param>
            /// <param name="display"></param>
            /// <returns></returns>
            public static CodeableConcept Encode(string code, string display)
            {
                return new CodeableConcept("urn:oid:2.16.840.1.114222.4.5.277", code, display, null);
            }
        }

        /// <summary>
        /// Valueset for Case Classification Status (2.16.840.1.114222.4.11.968)
        /// Indicates how the Nationally Notifiable Disease case was classified at its close
        /// There are three systems involved, SNOMED-CT, PHINVS, and NullFlavor
        /// </summary>
        public static class CaseClassificationStatus
        {
            public static CodeableConcept ConfirmedPresent => new CodeableConcept("http://snomed.info/sct", "410605003", "Confirmed present", null);
            public static CodeableConcept NotACase => new CodeableConcept("urn:oid:2.16.840.1.114222.4.5.274", "PHC178", "Not a Case", null);
            public static CodeableConcept ProbableDiagnosis => new CodeableConcept("http://snomed.info/sct", "2931005", "Probable diagnosis", null);
            public static CodeableConcept Suspected => new CodeableConcept("http://snomed.info/sct", "415684004", "Suspected", null);
            public static CodeableConcept Unknown => new CodeableConcept ("http://hl7.org/fhir/v3/NullFlavor", "UNK", "Unknown", null);
        }
    }
}
