using System;
using Hl7.Fhir.Model;
using GaTech.Chai.Share;
using GaTech.Chai.UsCore;
using System.Collections.Generic;

namespace GaTech.Chai.Mdi
{
    /// <summary>
    /// DiagnosticReportToxicologyLabResultToMdiProfile
    /// http://hl7.org/fhir/us/mdi/StructureDefinition/DiagnosticReport-toxicology-to-mdi
    /// </summary>
    public class DiagnosticReportToxicologyLabResultToMdi
    {
        readonly DiagnosticReport diagnosticReport;
        readonly static Dictionary<string, Resource> resources = new();

        internal DiagnosticReportToxicologyLabResultToMdi(DiagnosticReport diagnosticReport)
        {
            this.diagnosticReport = diagnosticReport;
        }

        /// <summary>
        /// Factory for DiagnosticReportToxicologyLabResultToMdiProfile
        /// http://hl7.org/fhir/us/mdi/StructureDefinition/DiagnosticReport-toxicology-to-mdi
        /// </summary>
        public static DiagnosticReport Create()
        {
            // clear static resource container.
            resources.Clear();

            var diagnosticReport = new DiagnosticReport();
            diagnosticReport.DiagnosticReportToxicologyLabResultToMdi().AddProfile();
            diagnosticReport.Category.SetCategory(ValueSets.DiagnosticServiceSections.Laboratory);

            return diagnosticReport;
        }

        /// <summary>
        /// Factory for DiagnosticReportToxicologyLabResultToMdiProfile with subject
        /// http://hl7.org/fhir/us/mdi/StructureDefinition/DiagnosticReport-toxicology-to-mdi
        /// </summary>
        public static DiagnosticReport Create(Patient subject)
        {
            // clear static resource container.
            resources.Clear();

            var diagnosticReport = new DiagnosticReport();

            diagnosticReport.DiagnosticReportToxicologyLabResultToMdi().AddProfile();
            diagnosticReport.Category.SetCategory(ValueSets.DiagnosticServiceSections.Laboratory);
            diagnosticReport.DiagnosticReportToxicologyLabResultToMdi().SubjectAsResource = subject;

            return diagnosticReport;
        }

        /// <summary>
        /// The official URL for the DiagnosticReportToxicologyLabResultToMdi profile, used to assert conformance.
        /// </summary>
        public const string ProfileUrl = "http://hl7.org/fhir/us/mdi/StructureDefinition/DiagnosticReport-toxicology-to-mdi";

        /// <summary>
        /// Set profile for the DiagnosticReportToxicologyLabResultToMdiProfile
        /// </summary>
        public void AddProfile()
        {
            diagnosticReport.AddProfile(ProfileUrl);
        }

        /// <summary>
        /// Clear profile for DiagnosticReportToxicologyLabResultToMdiProfile
        /// </summary>
        public void RemoveProfile()
        {
            diagnosticReport.RemoveProfile(ProfileUrl);
        }

        /// <summary>
        /// Get and Set subject as Patient
        /// </summary>
        public Patient SubjectAsResource
        {
            get
            {
                Resource value;
                resources.TryGetValue(this.diagnosticReport.Subject.Reference, out value);

                return (Patient)value;
            }
            set
            {
                this.diagnosticReport.Subject = value.AsReference();
                resources[value.AsReference().Reference] = value;
            }
        }

        /// <summary>
        /// Adding Performer
        /// </summary>
        public void AddPerformer(Resource performer)
        {
            if (!this.diagnosticReport.Performer.Contains(performer.AsReference()))
            {
                this.diagnosticReport.Performer.Add(performer.AsReference());
            }

            resources[performer.AsReference().Reference] = performer;
        }

        /// <summary>
        /// Adding Performer
        /// </summary>
        public void AddSpecimen(Specimen specimen)
        {
            if (!this.diagnosticReport.Specimen.Contains(specimen.AsReference()))
            {
                this.diagnosticReport.Specimen.Add(specimen.AsReference(specimen.Type.Text));
            }

            resources[specimen.AsReference().Reference] = specimen;
        }

        /// <summary>
        /// Adding Performer
        /// </summary>
        public void AddResult(Observation result)
        {
            if (!this.diagnosticReport.Result.Contains(result.AsReference()))
            {
                this.diagnosticReport.Result.Add(result.AsReference(result.Code.Text));
            }

            resources[result.AsReference().Reference] = result;
        }

        /// <summary>
        /// Tracking Number (EdrsFileNumber) extension identifier. IG allows multiple numbers.
        /// Check system, value for existence.
        /// </summary>
        public (string, string) EdrsFileNumber
        {
            get
            {
                foreach (Extension ext in this.diagnosticReport.GetExtensions(MdiStructureDefinition.ExtensionTrackingNumberUrl))
                {
                    Coding coding = (ext.Value as Identifier).Type?.Coding?.Find(e => e.System == MdiCodeSystem.MdiCodes.officialUrl && e.Code == MdiCodeSystem.MdiCodes.EdrsFileNumber.Coding[0].Code);
                    if (coding != null)
                    {
                        return ((ext.Value as Identifier).System, (ext.Value as Identifier).Value);
                    }
                }

                return (null, null);
            }

            set
            {
                Extension ext = new Extension() { Url = MdiStructureDefinition.ExtensionTrackingNumberUrl };
                ext.Value = new Identifier() { Type = MdiCodeSystem.MdiCodes.EdrsFileNumber, System = value.Item1, Value = value.Item2 };
                this.diagnosticReport.Extension.AddOrUpdateExtension(ext, true);
            }
        }

        /// <summary>
        /// Tracking Number (MDI Case Number) extension identifier
        /// </summary>
        public (string, string) MdiCaseNumber
        {
            get
            {
                foreach (Extension ext in this.diagnosticReport.GetExtensions(MdiStructureDefinition.ExtensionTrackingNumberUrl))
                {
                    Coding coding = (ext.Value as Identifier).Type?.Coding?.Find(e => e.System == MdiCodeSystem.MdiCodes.officialUrl && e.Code == MdiCodeSystem.MdiCodes.MdiCaseNumber.Coding[0].Code);
                    if (coding != null)
                    {
                        return ((ext.Value as Identifier).System, (ext.Value as Identifier).Value);
                    }
                }

                return (null, null);
            }

            set
            {
                Extension ext = new()
                {
                    Url = MdiStructureDefinition.ExtensionTrackingNumberUrl,
                    Value = new Identifier() { Type = MdiCodeSystem.MdiCodes.MdiCaseNumber, System = value.Item1, Value = value.Item2 }
                };
                this.diagnosticReport.Extension.AddOrUpdateExtension(ext, true);
            }
        }

        /// <summary>
        /// Tracking Number (Toxicology Laboratory Case Number) extension identifier
        /// (System string, Value string)
        /// </summary>
        public (string, string) ToxLabCaseNumber
        {
            get
            {
                foreach (Extension ext in this.diagnosticReport.GetExtensions(MdiStructureDefinition.ExtensionTrackingNumberUrl))
                {
                    Coding coding = (ext.Value as Identifier).Type?.Coding?.Find(e => e.System == MdiCodeSystem.MdiCodes.officialUrl && e.Code == MdiCodeSystem.MdiCodes.ToxLabCaseNumber.Coding[0].Code);
                    if (coding != null)
                    {
                        return ((ext.Value as Identifier).System, (ext.Value as Identifier).Value);
                    }
                }

                return (null, null);
            }

            set
            {
                Extension ext = new()
                {
                    Url = MdiStructureDefinition.ExtensionTrackingNumberUrl,
                    Value = new Identifier() { Type = MdiCodeSystem.MdiCodes.ToxLabCaseNumber, System = value.Item1, Value = value.Item2 }
                };
                this.diagnosticReport.Extension.AddOrUpdateExtension(ext);
            }
        }

        public Dictionary<String, Resource> GetReferencedResources()
        {
            return resources;
        }
    }
}