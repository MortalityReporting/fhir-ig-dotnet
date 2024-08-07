﻿using System;
using Hl7.Fhir.Model;
using GaTech.Chai.Share;
using System.Collections.Generic;

namespace GaTech.Chai.Odh.UsualWorkProfile
{
    /// <summary>
    /// UsualWorkProfile
    /// http://hl7.org/fhir/us/odh/StructureDefinition/odh-UsualWork
    /// </summary>
    public class OdhUsualWork
    {
        readonly Observation observation;

        internal OdhUsualWork(Observation observation)
        {
            this.observation = observation;
        }

        /// <summary>
        /// Factory for ODH Profile
        /// </summary>
        public static Observation Create()
        {
            var observation = new Observation();
            observation.Category.SetCategory(new Coding("http://terminology.hl7.org/CodeSystem/observation-category", "social-history"));
            observation.Code = new CodeableConcept("http://loinc.org", "21843-8", "History of Usual occupation", null);
            observation.OdhUsualWork().AddProfile();

            return observation;
        }

        /// <summary>
        /// The official URL for UsualWorkProfile, used to assert conformance.
        /// </summary>
        public const string ProfileUrl = "http://hl7.org/fhir/us/odh/StructureDefinition/odh-UsualWork";

        /// <summary>
        /// Set profile for UsualWorkProfile
        /// </summary>
        public void AddProfile()
        {
            observation.AddProfile(ProfileUrl);
        }

        /// <summary>
        /// Clear profile for UsualWorkProfile
        /// </summary>
        public void RemoveProfile()
        {
            observation.RemoveProfile(ProfileUrl);
        }

        /// <summary>
        /// Occupation CDC Census 2010 value. Only one coding is allowed.
        /// </summary>
        public Coding OccupationCdcCensus2010
        {
            get
            {
                return (this.observation.Value as CodeableConcept)?.Coding?.Find(c => c.System == OccupationCdcCensus2010Oid);
            }
            set
            {
                if (value.System != OccupationCdcCensus2010Oid)
                {
                    throw(new ArgumentException("System must be " + OccupationCdcCensus2010Oid));
                }

                Coding coding = (this.observation.Value as CodeableConcept)?.Coding?.Find(c => c.System == OccupationCdcCensus2010Oid);
                if (coding == null)
                {
                    CodeableConcept valueCodeable = this.observation.Value as CodeableConcept;
                    if (valueCodeable == null)
                    {
                        this.observation.Value = new CodeableConcept() { Coding = new List<Coding> { value } };
                    } else
                    {
                        valueCodeable.Coding.Add(value);
                    }
                }
                else
                {
                    coding.Code = value.Code;
                    coding.Display = value.Display;
                }
            }
        }

        /// <summary>
        /// Occupation ONETSOC Detail. Only one coding is allowed.
        /// </summary>
        public Coding OccupationCdcOnetSdc2010
        {
            get
            {
                return (this.observation.Value as CodeableConcept)?.Coding?.Find(c => c.System == OccupationOdhOid);
            }
            set
            {
                if (value.System != OccupationOdhOid)
                {
                    throw (new ArgumentException("System must be " + OccupationOdhOid));
                }

                Coding coding = (this.observation.Value as CodeableConcept)?.Coding?.Find(c => c.System == OccupationOdhOid);
                if (coding == null)
                {
                    CodeableConcept valueCodeable = this.observation.Value as CodeableConcept;
                    if (valueCodeable == null)
                    {
                        this.observation.Value = new CodeableConcept() { Coding = new List<Coding> { value } };
                    }
                    else
                    {
                        valueCodeable.Coding.Add(value);
                    }
                }
                else
                {
                    coding.Code = value.Code;
                    coding.Display = value.Display;
                }
            }
        }

        /// <summary>
        /// Usual Industry component
        /// </summary>
        public Coding IndustryCdcCensus2010
        {
            get
            {
                Observation.ComponentComponent component = this.observation.Component.GetComponent("http://loinc.org", "21844-6");
                if (component != null)
                {
                    return (component.Value as CodeableConcept)?.Coding?.Find(c => c.System == IndustryCdcCensus2010Oid);
                } else
                {
                    return null;
                }
            }
            set
            {
                if (value.System != IndustryCdcCensus2010Oid)
                {
                    throw (new ArgumentException("System must be " + IndustryCdcCensus2010Oid));
                }

                Observation.ComponentComponent component = this.observation.Component.GetOrAddComponent("http://loinc.org", "21844-6", "History of Usual industry");
                Coding coding = (component.Value as CodeableConcept)?.Coding?.Find(c => c.System == IndustryCdcCensus2010Oid);
                if (coding == null)
                {
                    component.Value = new CodeableConcept() { Coding = new List<Coding> { value } };
                }
                else
                {
                    (component.Value as CodeableConcept).Coding.Add(value);
                }
            }
        }

        /// <summary
        /// Usual Indstry component
        /// <summary>
        public Coding IndustryNaicsDetail
        {
            get
            {
                Observation.ComponentComponent component = this.observation.Component.GetComponent("http://loinc.org", "21844-6");
                if (component != null)
                {
                    return (component.Value as CodeableConcept)?.Coding?.Find(c => c.System == IndustryCdcNaics2012Oid);
                }
                else
                {
                    return null;
                }
            }
            set
            {
                if (value.System != IndustryCdcNaics2012Oid)
                {
                    throw (new ArgumentException("System must be " + IndustryCdcNaics2012Oid));
                }

                Observation.ComponentComponent component = this.observation.Component.GetOrAddComponent("http://loinc.org", "21844-6", "History of Usual industry");
                Coding coding = (component.Value as CodeableConcept)?.Coding?.Find(c => c.System == IndustryCdcNaics2012Oid);
                if (coding == null)
                {
                    component.Value = new CodeableConcept() { Coding = new List<Coding> { value } };
                }
                else
                {
                    (component.Value as CodeableConcept).Coding.Add(value);
                }
            }
        }

        /// <summary>
        /// Usual Occupation Duration component
        /// <summary>
        public Decimal? UsualOccupationDuration
        {
            get
            {
                return (this.observation.Component?.GetComponent("http://loinc.org", "74163-7")?.Value as Quantity)?.Value;
            }
            set
            {
                Observation.ComponentComponent component = this.observation.Component.GetOrAddComponent("http://loinc.org", "74163-7", "Usual occupation duration");
                component.Value = new Quantity() { System = "http://unitsofmeasure.org", Code = "a", Unit = "year", Value = value };
            }
        }

        /// <summary>
        /// UsualOccupationDuration's reference range property
        /// </summary>
        public CodeableConcept UsualOccupationDurationReferenceType
        {
            get
            {
                return this.observation.Component?.GetComponent("http://loinc.org", "74163-7")?.ReferenceRange?[0].Type;
            }
            set
            {
                Observation.ComponentComponent component = this.observation.Component.GetOrAddComponent("http://loinc.org", "74163-7", "Usual occupation duration");
                if (component.ReferenceRange == null)
                {
                    component.ReferenceRange = new List<Observation.ReferenceRangeComponent> { new Observation.ReferenceRangeComponent() { Type = value } };
                }
                else
                {
                    component.ReferenceRange[0].Type = value;
                }
            }
        }
        public CodeableConcept UsualOccupationDurationReferenceAppliesTo
        {
            get
            {
                return this.observation.Component?.GetComponent("http://loinc.org", "74163-7")?.ReferenceRange?[0].AppliesTo?[0];
            }
            set
            {
                Observation.ComponentComponent component = this.observation.Component.GetOrAddComponent("http://loinc.org", "74163-7", "Usual occupation duration");
                if (component.ReferenceRange == null)
                {
                    component.ReferenceRange = new List<Observation.ReferenceRangeComponent> { new Observation.ReferenceRangeComponent() { AppliesTo = new List<CodeableConcept> { value } } };
                }
                else
                {
                    component.ReferenceRange[0].AppliesTo = new List<CodeableConcept> { value };
                }
            }
        }

        /// OID for PHIN VADS code systems for ODH
        /// </summary>
        public const string OccupationOdhOid = "urn:oid:2.16.840.1.114222.4.5.327";
        public const string OccupationCdcCensus2010Oid = "urn:oid:2.16.840.1.114222.4.5.314";
        public const string IndustryCdcCensus2010Oid = "urn:oid:2.16.840.1.114222.4.5.315";
        public const string IndustryCdcNaics2012Oid = "urn:oid:2.16.840.1.114222.4.5.315";
    }
}