using System;
using Hl7.Fhir.Model;
using GaTech.Chai.Share;
using System.Collections.Generic;
using System.Linq;
using Hl7.Fhir.Utility;

namespace GaTech.Chai.Mdi
{
    /// <summary>
    /// This Bundle profile represents a Document Bundle exchanged between an MDI CMS and EDRS. 
    /// It can be used for bi-directional exchange. It contains a Composition - MDI and EDRS.
    /// http://hl7.org/fhir/us/mdi/StructureDefinition/Bundle-document-mdi-and-edrs
    /// </summary>
    public class BundleDocumentMdiAndEdrs
    {
        readonly Bundle bundle;

        internal BundleDocumentMdiAndEdrs(Bundle bundle)
        {
            this.bundle = bundle;
        }

        /// <summary>
        /// Factory for BundleDocumentMdiAndEdrsProfile with composition and identifier
        /// http://hl7.org/fhir/us/mdi/StructureDefinition/Bundle-document-mdi-and-edrs
        /// </summary>
        public static Bundle Create(Identifier identifier, Composition composition)
        {
            Bundle bundle = new()
            {
                Identifier = identifier ?? throw new Exception("Identifier cannot be null for MDIandEdrs Bundle.")
            };

            bundle.BundleDocumentMdiAndEdrs().MDItoEDRSComposition = composition ?? throw new Exception("Composition cannot be null for MDIandEdrs Bundle entry[0].");
            bundle.BundleDocumentMdiAndEdrs().AddProfile();
            bundle.BundleDocumentMdiAndEdrs().AddFixedValues();

            return bundle;
        }

        public static Bundle Create()
        {
            Bundle bundle = new();
            bundle.BundleDocumentMdiAndEdrs().AddFixedValues();
            bundle.BundleDocumentMdiAndEdrs().AddProfile();

            return bundle;
        }

        public void AddFixedValues()
        {
            bundle.Type = Bundle.BundleType.Document;
        }

        public void ImportResourcesInEntry()
        {
            foreach (Bundle.EntryComponent entry in this.bundle.Entry)
            {
                if (entry.Resource != null)
                {
                    Record.GetResources()[entry.Resource.AsReference().Reference] = entry.Resource;
                }
            }
        }

        /// <summary>
        /// The official URL for the BundleDocumentMdiAndEdrsProfile, used to assert conformance.
        /// </summary>
        public const string ProfileUrl = "http://hl7.org/fhir/us/mdi/StructureDefinition/Bundle-document-mdi-and-edrs";

        /// <summary>
        /// Set the profile URL for the BundleDocumentMdiAndEdrsProfile.
        /// </summary>
        public void AddProfile()
        {
            bundle.AddProfile(ProfileUrl);
        }

        /// <summary>
        /// Clear the profile URL for the BundleDocumentMdiAndEdrsProfile.
        /// </summary>
        public void RemoveProfile()
        {
            bundle.RemoveProfile(ProfileUrl);
        }

        public string COD1A
        {
            get
            {
                (string value, string interval) = CauseOfDeathPart1A;
                return value;
            }
        }

        public string INTERVAL1A
        {
            get
            {
                (string value, string interval) = CauseOfDeathPart1A;
                return interval;
            }
        }

        public string COD1B
        {
            get
            {
                (string value, string interval) = CauseOfDeathPart1B;
                return value;
            }
        }

        public string INTERVAL1B
        {
            get
            {
                (string value, string interval) = CauseOfDeathPart1B;
                return interval;
            }
        }
        public string COD1C
        {
            get
            {
                (string value, string interval) = CauseOfDeathPart1C;
                return value;
            }
        }

        public string INTERVAL1C
        {
            get
            {
                (string value, string interval) = CauseOfDeathPart1C;
                return interval;
            }
        }
        public string COD1D
        {
            get
            {
                (string value, string interval) = CauseOfDeathPart1D;
                return value;
            }
        }

        public string INTERVAL1D
        {
            get
            {
                (string value, string interval) = CauseOfDeathPart1D;
                return interval;
            }
        }

        public (string, string) CauseOfDeathPart1A
        {
            get
            {
                foreach (Resource resource in bundle.GetResources())
                {
                    if (resource is Observation)
                    {
                        Observation ob = (Observation)resource;
                        if (ob.IsObservationCauseOfDeathPart1())
                        {
                            if (ob.ObservationMdiCauseOfDeathPart1().LineNumber.Value is 1)
                            {
                                return (ob.ObservationMdiCauseOfDeathPart1().ValueText, ob.ObservationMdiCauseOfDeathPart1().IntervalAsString);
                            }
                        }
                    }
                }

                return (null, null);
            }
        }

        public (string, string) CauseOfDeathPart1B
        {
            get
            {
                Composition composition = (Composition)this.bundle.Entry[0]?.Resource;

                foreach (Resource resource in bundle.GetResources())
                {
                    if (resource is Observation)
                    {
                        Observation ob = (Observation)resource;
                        if (ob.IsObservationCauseOfDeathPart1())
                        {
                            if (ob.ObservationMdiCauseOfDeathPart1().LineNumber.Value is 2)
                            {
                                return (ob.ObservationMdiCauseOfDeathPart1().ValueText, ob.ObservationMdiCauseOfDeathPart1().IntervalAsString);
                            }
                        }
                    }
                }

                return (null, null);
            }
        }

        public (string, string) CauseOfDeathPart1C
        {
            get
            {
                foreach (Resource resource in bundle.GetResources())
                {
                    if (resource is Observation)
                    {
                        Observation ob = (Observation)resource;
                        if (ob.IsObservationCauseOfDeathPart1())
                        {
                            if (ob.ObservationMdiCauseOfDeathPart1().LineNumber.Value is 3)
                            {
                                return (ob.ObservationMdiCauseOfDeathPart1().ValueText, ob.ObservationMdiCauseOfDeathPart1().IntervalAsString);
                            }
                        }
                    }
                }

                return (null, null);
            }
        }

        public (string, string) CauseOfDeathPart1D
        {
            get
            {
                foreach (Resource resource in bundle.GetResources())
                {
                    if (resource is Observation)
                    {
                        Observation ob = (Observation)resource;
                        if (ob.IsObservationCauseOfDeathPart1())
                        {
                            if (ob.ObservationMdiCauseOfDeathPart1().LineNumber.Value is 4)
                            {
                                return (ob.ObservationMdiCauseOfDeathPart1().ValueText, ob.ObservationMdiCauseOfDeathPart1().IntervalAsString);
                            }
                        }
                    }
                }

                return (null, null);
            }
        }

        public Resource FindResourceInEntry(ResourceReference reference)
        {
            if (reference == null) return null;
            IEnumerable<Resource> entryResources = this.bundle.GetResources();
            if (entryResources.Count<Resource>() > 0)
            {
                IEnumerable<Resource> retResource = from e in entryResources
                                                    where e.AsReference().Reference.Equals(reference.Reference)
                                                    select e;
                if (retResource.Any())
                {
                    return retResource.First<Resource>();
                }
            }

            return null;
        }

        // private void AddReferencesInCompositionToEntry(Composition composition)
        // {
        //     Resource resource = Record.GetResources()[composition.Subject.Reference];
        //     if (resource == null)
        //     {
        //         throw (new MissingMemberException("Subject resource is not available in Record."));
        //     }

        //     if (resource != null)
        //     {
        //         bool exists = bundle.FindEntry(resource.AsReference()).Any<Bundle.EntryComponent>();
        //         if (!exists)
        //         {
        //             bundle.AddResourceEntry(resource, resource.AsReference().Reference);
        //         }
        //     }

        //     if (!composition.Author.IsNullOrEmpty() && composition.Author[0].Reference != null)
        //     {
        //         resource = Record.GetResources()[composition.Author[0].Reference];
        //         if (resource == null)
        //         {
        //             throw (new MissingMemberException("Author[0] resource is not available in Record."));
        //         }

        //         if (resource != null)
        //         {
        //             bool exists = bundle.FindEntry(resource.AsReference()).Any<Bundle.EntryComponent>();
        //             if (!exists)
        //             {
        //                 bundle.AddResourceEntry(resource, resource.AsReference().Reference);
        //             }
        //         }
        //     }

        //     if (!composition.Attester.IsNullOrEmpty() && composition.Attester[0].Party != null && composition.Attester[0].Party.Reference != null)
        //     {
        //         resource = Record.GetResources()[composition.Attester[0].Party.Reference];
        //         if (resource == null)
        //         {
        //             throw (new MissingMemberException("Attester[0] resource is not available in Record."));
        //         }

        //         if (resource != null)
        //         {
        //             bool exists = bundle.FindEntry(resource.AsReference()).Any<Bundle.EntryComponent>();
        //             if (!exists)
        //             {
        //                 bundle.AddResourceEntry(resource, resource.AsReference().Reference);
        //             }
        //         }
        //     }
            
        //     foreach (SectionComponent section in composition.Section)
        //     {
        //         foreach (ResourceReference sectionEntryReference in section.Entry)
        //         {
        //             resource = Record.GetResources()[sectionEntryReference.Reference];
        //             if (resource == null)
        //             {
        //                 throw (new MissingMemberException(sectionEntryReference.Reference + " resource is not available in Record."));
        //             }
        //             if (resource != null)
        //             {
        //                 bool exists = bundle.FindEntry(resource.AsReference()).Any<Bundle.EntryComponent>();
        //                 if (!exists)
        //                 {
        //                     bundle.AddResourceEntry(resource, resource.AsReference().Reference);
        //                 }
        //             }
        //         }
        //     }
        // }

        public Composition MDItoEDRSComposition
        {
            get
            {
                return this.bundle.Entry?[0].Resource as Composition;
            }
            set
            {
                // First check if the composition is
                // a http://hl7.org/fhir/us/mdi/StructureDefinition/Composition-mdi-to-edrs profile.
                if (!value.hasProfile(CompositionMdiAndEdrs.ProfileUrl))
                {
                    throw (new ArgumentException("The composition must have Composition-mdi-to-edrs as a profile."));
                }

                // First entry MUST be composition
                // Check if composition already exists.
                if (bundle.Entry.Any<Bundle.EntryComponent>())
                {
                    Resource resource = this.bundle.Entry[0].Resource;
                    if (resource is Composition)
                    {
                        // There exists one.... we will be replacing this.
                        this.bundle.Entry.RemoveAt(0);
                    }
                }

                Bundle.EntryComponent entryComponent = new()
                {
                    Resource = value,
                    FullUrl = value.AsReference().Reference
                };

                bundle.Entry.Insert(0, entryComponent);

                // Add references in composition to bundle entry.
                bundle.AddRefsInCompositionToEntry(value);
            }
        }
    }
}